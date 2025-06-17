using System;
using DiscordRPC;
using DiscordRPC.Message;
using UnityEngine.Events;

namespace Lachee.Discord.Control
{
	[Serializable]
	public sealed class MessageEvents
	{
		[Serializable]
		public sealed class ReadyMessageEvent : UnityEvent<ReadyMessage>
		{
		}

		[Serializable]
		public sealed class CloseMessageEvent : UnityEvent<CloseMessage>
		{
		}

		[Serializable]
		public sealed class ErrorMessageEvent : UnityEvent<ErrorMessage>
		{
		}

		[Serializable]
		public sealed class PresenceMessageEvent : UnityEvent<PresenceMessage>
		{
		}

		[Serializable]
		public sealed class SubscribeMessageEvent : UnityEvent<SubscribeMessage>
		{
		}

		[Serializable]
		public sealed class UnsubscribeMessageEvent : UnityEvent<UnsubscribeMessage>
		{
		}

		[Serializable]
		public sealed class JoinMessageEvent : UnityEvent<JoinMessage>
		{
		}

		[Serializable]
		public sealed class SpectateMessageEvent : UnityEvent<SpectateMessage>
		{
		}

		[Serializable]
		public sealed class JoinRequestMessageEvent : UnityEvent<JoinRequestMessage>
		{
		}

		[Serializable]
		public sealed class ConnectionEstablishedMessageEvent : UnityEvent<ConnectionEstablishedMessage>
		{
		}

		[Serializable]
		public sealed class ConnectionFailedMessageEvent : UnityEvent<ConnectionFailedMessage>
		{
		}

		public ReadyMessageEvent OnReady = new ReadyMessageEvent();

		public CloseMessageEvent OnClose = new CloseMessageEvent();

		public ErrorMessageEvent OnError = new ErrorMessageEvent();

		public PresenceMessageEvent OnPresenceUpdate = new PresenceMessageEvent();

		public SubscribeMessageEvent OnSubscribe = new SubscribeMessageEvent();

		public UnsubscribeMessageEvent OnUnsubscribe = new UnsubscribeMessageEvent();

		public JoinMessageEvent OnJoin = new JoinMessageEvent();

		public SpectateMessageEvent OnSpectate = new SpectateMessageEvent();

		public JoinRequestMessageEvent OnJoinRequest = new JoinRequestMessageEvent();

		public ConnectionEstablishedMessageEvent OnConnectionEstablished = new ConnectionEstablishedMessageEvent();

		public ConnectionFailedMessageEvent OnConnectionFailed = new ConnectionFailedMessageEvent();

		public void RegisterEvents(DiscordRpcClient client)
		{
			client.OnReady += delegate(object s, ReadyMessage args)
			{
				OnReady.Invoke(args);
			};
			client.OnClose += delegate(object s, CloseMessage args)
			{
				OnClose.Invoke(args);
			};
			client.OnError += delegate(object s, ErrorMessage args)
			{
				OnError.Invoke(args);
			};
			client.OnPresenceUpdate += delegate(object s, PresenceMessage args)
			{
				OnPresenceUpdate.Invoke(args);
			};
			client.OnSubscribe += delegate(object s, SubscribeMessage args)
			{
				OnSubscribe.Invoke(args);
			};
			client.OnUnsubscribe += delegate(object s, UnsubscribeMessage args)
			{
				OnUnsubscribe.Invoke(args);
			};
			client.OnJoin += delegate(object s, JoinMessage args)
			{
				OnJoin.Invoke(args);
			};
			client.OnSpectate += delegate(object s, SpectateMessage args)
			{
				OnSpectate.Invoke(args);
			};
			client.OnJoinRequested += delegate(object s, JoinRequestMessage args)
			{
				OnJoinRequest.Invoke(args);
			};
			client.OnConnectionEstablished += delegate(object s, ConnectionEstablishedMessage args)
			{
				OnConnectionEstablished.Invoke(args);
			};
			client.OnConnectionFailed += delegate(object s, ConnectionFailedMessage args)
			{
				OnConnectionFailed.Invoke(args);
			};
		}
	}
}
