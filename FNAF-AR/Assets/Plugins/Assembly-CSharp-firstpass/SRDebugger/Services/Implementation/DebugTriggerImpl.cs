using System;
using SRDebugger.Internal;
using SRDebugger.UI.Other;
using SRF;
using SRF.Service;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IDebugTriggerService))]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService
	{
		private PinAlignment _position;

		private TriggerRoot _trigger;

		public bool IsEnabled
		{
			get
			{
				if (_trigger != null)
				{
					return _trigger.CachedGameObject.activeSelf;
				}
				return false;
			}
			set
			{
				if (value && _trigger == null)
				{
					CreateTrigger();
				}
				if (_trigger != null)
				{
					_trigger.CachedGameObject.SetActive(value);
				}
			}
		}

		public PinAlignment Position
		{
			get
			{
				return _position;
			}
			set
			{
				if (_trigger != null)
				{
					SetTriggerPosition(_trigger.TriggerTransform, value);
				}
				_position = value;
			}
		}

		protected override void Awake()
		{
			base.Awake();
			UnityEngine.Object.DontDestroyOnLoad(base.CachedGameObject);
			base.CachedTransform.SetParent(Hierarchy.Get("SRDebugger"), worldPositionStays: true);
			base.name = "Trigger";
		}

		private void CreateTrigger()
		{
			TriggerRoot triggerRoot = Resources.Load<TriggerRoot>("SRDebugger/UI/Prefabs/Trigger");
			if (triggerRoot == null)
			{
				Debug.LogError("[SRDebugger] Error loading trigger prefab");
				return;
			}
			_trigger = SRInstantiate.Instantiate(triggerRoot);
			_trigger.CachedTransform.SetParent(base.CachedTransform, worldPositionStays: true);
			SetTriggerPosition(_trigger.TriggerTransform, _position);
			switch (Settings.Instance.TriggerBehaviour)
			{
			case Settings.TriggerBehaviours.TripleTap:
				_trigger.TripleTapButton.onClick.AddListener(OnTriggerButtonClick);
				_trigger.TapHoldButton.gameObject.SetActive(value: false);
				break;
			case Settings.TriggerBehaviours.TapAndHold:
				_trigger.TapHoldButton.onLongPress.AddListener(OnTriggerButtonClick);
				_trigger.TripleTapButton.gameObject.SetActive(value: false);
				break;
			case Settings.TriggerBehaviours.DoubleTap:
				_trigger.TripleTapButton.RequiredTapCount = 2;
				_trigger.TripleTapButton.onClick.AddListener(OnTriggerButtonClick);
				_trigger.TapHoldButton.gameObject.SetActive(value: false);
				break;
			default:
				throw new Exception("Unhandled TriggerBehaviour");
			}
			SRDebuggerUtil.EnsureEventSystemExists();
			SceneManager.activeSceneChanged += OnActiveSceneChanged;
		}

		protected override void OnDestroy()
		{
			SceneManager.activeSceneChanged -= OnActiveSceneChanged;
			base.OnDestroy();
		}

		private static void OnActiveSceneChanged(Scene s1, Scene s2)
		{
			SRDebuggerUtil.EnsureEventSystemExists();
		}

		private void OnTriggerButtonClick()
		{
			SRDebug.Instance.ShowDebugPanel();
		}

		private static void SetTriggerPosition(RectTransform t, PinAlignment position)
		{
			float x = 0f;
			float y = 0f;
			float x2 = 0f;
			float y2 = 0f;
			switch (position)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.TopRight:
			case PinAlignment.TopCenter:
				y = 1f;
				y2 = 1f;
				break;
			case PinAlignment.BottomLeft:
			case PinAlignment.BottomRight:
			case PinAlignment.BottomCenter:
				y = 0f;
				y2 = 0f;
				break;
			case PinAlignment.CenterLeft:
			case PinAlignment.CenterRight:
				y = 0.5f;
				y2 = 0.5f;
				break;
			}
			switch (position)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.BottomLeft:
			case PinAlignment.CenterLeft:
				x = 0f;
				x2 = 0f;
				break;
			case PinAlignment.TopRight:
			case PinAlignment.BottomRight:
			case PinAlignment.CenterRight:
				x = 1f;
				x2 = 1f;
				break;
			case PinAlignment.TopCenter:
			case PinAlignment.BottomCenter:
				x = 0.5f;
				x2 = 0.5f;
				break;
			}
			t.pivot = new Vector2(x, y);
			Vector2 anchorMax = (t.anchorMin = new Vector2(x2, y2));
			t.anchorMax = anchorMax;
		}
	}
}
