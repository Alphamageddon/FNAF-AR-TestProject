using System.ComponentModel;
using SRDebugger.Internal;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(Canvas))]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour
	{
		private Canvas _canvas;

		private CanvasScaler _canvasScaler;

		private float _originalScale;

		private float _lastSetScale;

		private void Start()
		{
			_canvas = GetComponent<Canvas>();
			_canvasScaler = GetComponent<CanvasScaler>();
			SRDebuggerUtil.ConfigureCanvas(_canvas);
			_originalScale = _canvasScaler.scaleFactor;
			_canvasScaler.scaleFactor = _originalScale * SRDebug.Instance.Settings.UIScale;
			_lastSetScale = _canvasScaler.scaleFactor;
			SRDebug.Instance.Settings.PropertyChanged += SettingsOnPropertyChanged;
		}

		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			if (_canvasScaler.scaleFactor != _lastSetScale)
			{
				_originalScale = _canvasScaler.scaleFactor;
			}
			_canvasScaler.scaleFactor = _originalScale * SRDebug.Instance.Settings.UIScale;
			_lastSetScale = _canvasScaler.scaleFactor;
		}
	}
}
