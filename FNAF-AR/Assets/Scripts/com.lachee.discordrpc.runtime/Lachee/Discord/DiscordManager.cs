using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using Lachee.Discord.Control;
using Lachee.Discord.Events;
using UnityEngine;

namespace Lachee.Discord
{
	[ExecuteInEditMode]
	public sealed class DiscordManager : MonoBehaviour
	{
		public enum Pipe
		{
			FirstAvailable = -1,
			Pipe0 = 0,
			Pipe1 = 1,
			Pipe2 = 2,
			Pipe3 = 3,
			Pipe4 = 4,
			Pipe5 = 5,
			Pipe6 = 6,
			Pipe7 = 7,
			Pipe8 = 8,
			Pipe9 = 9
		}

		public const string EXAMPLE_APPLICATION = "424087019149328395";

		private static DiscordManager _instance;

		[Header("Properties")]
		[Tooltip("The ID of the Discord Application. Visit the Discord API to create a new application if nessary.")]
		public string applicationID = "424087019149328395";

		[Tooltip("The Steam App ID. This is a optional field used to launch your game through steam instead of the executable.")]
		public string steamID = "";

		[Tooltip("The pipe discord is located on. Useful for testing multiple clients.")]
		public Pipe targetPipe = Pipe.FirstAvailable;

		[Tooltip("Logging level of the Discord IPC connection.")]
		public LogLevel logLevel = LogLevel.Warning;

		[Tooltip("The file to write the logs too in a build. If empty, then the console logger will be used.")]
		public string logFile = "discord.log";

		[Tooltip("Registers a custom URI scheme for your game. This is required for the Join / Specate features to work.")]
		public bool registerUriScheme;

		[SerializeField]
		[Tooltip("The enabled state of the IPC connection")]
		private bool active = true;

		[Tooltip("The current Discord user. This does not get set until the first Ready event.")]
		[Header("State")]
		[SerializeField]
		private User _currentUser;

		[Tooltip("The current subscription flag")]
		[SerializeField]
		private Event _currentSubscription;

		[Tooltip("The current Rich Presence displayed on the Discord Client.")]
		[SerializeField]
		private Presence _currentPresence;

		[Header("Handlers and Events")]
		public UnityReadyEvent OnReady;

		public UnityCloseEvent OnClose;

		public UnityPresenceEvent OnPresence;

		public UnityJoinEvent OnJoin;

		[HideInInspector]
		public UnitySubscribeEvent OnSubscribe;

		[HideInInspector]
		public UnityUnsubscribeEvent OnUnsubscribe;

		[HideInInspector]
		public UnityErrorEvent OnError;

		[HideInInspector]
		public UnitySpectateEvent OnSpectate;

		[HideInInspector]
		public UnityJoinRequestEvent OnJoinRequest;

		[HideInInspector]
		public UnityConnectionEstablishedEvent OnConnectionEstablished;

		[HideInInspector]
		public UnityConnectionFailedEvent OnConnectionFailed;

		private DiscordRpcClient _client;

		public static DiscordManager current => _instance;

		public User CurrentUser => _currentUser;

		public Event CurrentSubscription => _currentSubscription;

		public Presence CurrentPresence => _currentPresence;

		public DiscordRpcClient client => _client;

		public bool isInitialized
		{
			get
			{
				if (_client != null)
				{
					return _client.IsInitialized;
				}
				return false;
			}
		}

		private void OnDisable()
		{
			Deinitialize();
		}

		private void OnDestroy()
		{
			Deinitialize();
		}

		private void OnEnable()
		{
			if (base.gameObject.activeSelf && !isInitialized)
			{
				Initialize();
			}
		}

		private void Awake()
		{
			SetupSingleton();
		}

		private void Start()
		{
			if (!isInitialized)
			{
				if (_client != null)
				{
					Debug.LogWarning("Client already exists! Disposing Early.");
					Deinitialize();
				}
				Initialize();
			}
		}

		private void FixedUpdate()
		{
			if (client != null)
			{
				client.Logger.Level = logLevel;
				client.Invoke();
			}
		}

		private void SetupSingleton()
		{
			if (_instance != null && _instance != this)
			{
				Debug.LogWarning("[DAPI] Multiple DiscordManagers exist already. Destroying self.", _instance);
				Object.Destroy(this);
				return;
			}
			if (_client != null)
			{
				Debug.LogError("[DAPI] Cannot initialize a new client when one is already initialized.");
				return;
			}
			_instance = this;
			if (Application.isPlaying)
			{
				Object.DontDestroyOnLoad(this);
			}
		}

		public void Initialize()
		{
			if (active && Application.isPlaying)
			{
				SetupSingleton();
				DiscordRPC.Logging.ILogger logger = null;
				logger = ((!Application.isEditor) ? ((DiscordRPC.Logging.ILogger)new FileLogger(logFile)
				{
					Level = logLevel
				}) : ((DiscordRPC.Logging.ILogger)new UnityLogger
				{
					Level = logLevel
				}));
				Debug.Log("[DRP] Starting Discord Rich Presence");
				_client = new DiscordRpcClient(applicationID, (int)targetPipe, logger, autoEvents: false, new UnityNamedPipe());
				if (registerUriScheme)
				{
					client.RegisterUriScheme(steamID);
				}
				client.OnError += delegate(object s, ErrorMessage args)
				{
					Debug.LogError("[DRP] Error Occured within the Discord IPC: (" + args.Code.ToString() + ") " + args.Message);
				};
				client.OnJoinRequested += delegate
				{
					Debug.Log("[DRP] Join Requested");
				};
				client.OnReady += delegate(object s, ReadyMessage args)
				{
					Debug.Log("[DRP] Connection established and received READY from Discord IPC. Sending our previous Rich Presence and Subscription.");
					_currentUser = args.User;
					_currentUser.GetAvatar();
				};
				client.OnPresenceUpdate += delegate(object s, PresenceMessage args)
				{
					Debug.Log("[DRP] Our Rich Presence has been updated. Applied changes to local store.");
					Debug.Log(args.Presence.State);
					_currentPresence = (Presence)(RichPresence)args.Presence;
				};
				client.OnSubscribe += delegate
				{
					Debug.Log("[DRP] New Subscription. Updating local store.");
					_currentSubscription = client.Subscription.ToUnity();
				};
				client.OnUnsubscribe += delegate
				{
					Debug.Log("[DRP] Removed Subscription. Updating local store.");
					_currentSubscription = client.Subscription.ToUnity();
				};
				client.OnReady += delegate(object s, ReadyMessage args)
				{
					OnReady?.Invoke(new ReadyEvent(args));
				};
				client.OnClose += delegate(object s, CloseMessage args)
				{
					OnClose?.Invoke(args);
				};
				client.OnError += delegate(object s, ErrorMessage args)
				{
					OnError?.Invoke(args);
				};
				client.OnPresenceUpdate += delegate(object s, PresenceMessage args)
				{
					OnPresence?.Invoke(new PresenceEvent(args));
				};
				client.OnSubscribe += delegate(object s, SubscribeMessage args)
				{
					OnSubscribe?.Invoke(args);
				};
				client.OnUnsubscribe += delegate(object s, UnsubscribeMessage args)
				{
					OnUnsubscribe?.Invoke(args);
				};
				client.OnJoin += delegate(object s, JoinMessage args)
				{
					OnJoin?.Invoke(args);
				};
				client.OnSpectate += delegate(object s, SpectateMessage args)
				{
					OnSpectate?.Invoke(args);
				};
				client.OnJoinRequested += delegate(object s, JoinRequestMessage args)
				{
					OnJoinRequest?.Invoke(new JoinRequestEvent(args));
				};
				client.OnConnectionEstablished += delegate(object s, ConnectionEstablishedMessage args)
				{
					OnConnectionEstablished.Invoke(args);
				};
				client.OnConnectionFailed += delegate(object s, ConnectionFailedMessage args)
				{
					OnConnectionFailed.Invoke(args);
				};
				SetSubscription(_currentSubscription);
				SetPresence(_currentPresence);
				_client.Initialize();
				Debug.Log("[DRP] Discord Rich Presence intialized and connecting...");
			}
		}

		public void Deinitialize()
		{
			if (_client != null)
			{
				Debug.Log("[DRP] Disposing Discord IPC Client...");
				_client.Dispose();
				_client = null;
				Debug.Log("[DRP] Finished Disconnecting");
			}
		}

		public void SetPresence(Presence presence)
		{
			if (client == null)
			{
				Debug.LogError("[DRP] Attempted to send a presence update but no client exists!");
				return;
			}
			_ = client.IsInitialized;
			if (!presence.secrets.IsEmpty() && _currentSubscription == Event.None)
			{
				Debug.LogWarning("[DRP] Sending a secret, however we are not actually subscribed to any events. This will cause the messages to be ignored!");
			}
			_currentPresence = presence;
			client.SetPresence(presence?.ToRichPresence());
		}

		[ContextMenu("Resend Presence")]
		public void ResetPresence()
		{
			SetPresence(_currentPresence);
		}

		public void SetSubscription(Event evt)
		{
			if (client == null)
			{
				Debug.LogError("[DRP] Attempted to send a presence update but no client exists!");
				return;
			}
			_currentSubscription = evt;
			client.SetSubscription(evt.ToDiscordRPC());
		}

		public Presence UpdateDetails(string details)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateDetails(details);
		}

		public Presence UpdateState(string state)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateState(state);
		}

		public Presence UpdateParty(Party party)
		{
			if (_client == null)
			{
				return null;
			}
			if (party == null)
			{
				return (Presence)_client.UpdateParty(null);
			}
			return (Presence)_client.UpdateParty(party.ToRichParty());
		}

		public Presence UpdatePartySize(int size, int max)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdatePartySize(size, max);
		}

		public Presence UpdateLargeAsset(Asset asset)
		{
			if (_client == null)
			{
				return null;
			}
			if (asset == null)
			{
				return (Presence)_client.UpdateLargeAsset("", "");
			}
			return (Presence)_client.UpdateLargeAsset(asset.image, asset.tooltip);
		}

		public Presence UpdateSmallAsset(Asset asset)
		{
			if (_client == null)
			{
				return null;
			}
			if (asset == null)
			{
				return (Presence)_client.UpdateSmallAsset("", "");
			}
			return (Presence)_client.UpdateSmallAsset(asset.image, asset.tooltip);
		}

		public Presence UpdateSecrets(Secrets secrets)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateSecrets(secrets.ToRichSecrets());
		}

		public Presence UpdateStartTime()
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateStartTime();
		}

		public Presence UpdateStartTime(Timestamp timestamp)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateStartTime(timestamp.GetDateTime());
		}

		public Presence UpdateEndTime()
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateEndTime();
		}

		public Presence UpdateEndTime(Timestamp timestamp)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateEndTime(timestamp.GetDateTime());
		}

		public Presence UpdateClearTime(Timestamp timestamp)
		{
			if (_client == null)
			{
				return null;
			}
			return (Presence)_client.UpdateClearTime();
		}

		public void Respond(JoinRequestMessage request, bool acceptRequest)
		{
			if (client == null)
			{
				Debug.LogError("[DRP] Attempted to send a presence update but no client exists!");
			}
			else if (!client.IsInitialized)
			{
				Debug.LogError("[DRP] Attempted to send a presence update to a client that is not initialized!");
			}
			else
			{
				client.Respond(request, acceptRequest);
			}
		}
	}
}
