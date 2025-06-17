using System;
using SRF;
using SRF.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class ActionControl : OptionsControlBase
	{
		private MethodReference _method;

		[RequiredField]
		public Button Button;

		[RequiredField]
		public Text Title;

		public MethodReference Method => _method;

		protected override void Start()
		{
			base.Start();
			Button.onClick.AddListener(ButtonOnClick);
		}

		private void ButtonOnClick()
		{
			if (_method == null)
			{
				Debug.LogWarning("[SRDebugger.Options] No method set for action control", this);
				return;
			}
			try
			{
				_method.Invoke(null);
			}
			catch (Exception exception)
			{
				Debug.LogError("[SRDebugger] Exception thrown while executing action.");
				Debug.LogException(exception);
			}
		}

		public void SetMethod(string methodName, MethodReference method)
		{
			_method = method;
			Title.text = methodName;
		}
	}
}
