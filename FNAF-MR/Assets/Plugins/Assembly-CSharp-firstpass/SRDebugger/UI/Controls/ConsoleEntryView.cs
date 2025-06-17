using System;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRF;
using SRF.UI;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
	{
		public const string ConsoleBlobInfo = "Console_Info_Blob";

		public const string ConsoleBlobWarning = "Console_Warning_Blob";

		public const string ConsoleBlobError = "Console_Error_Blob";

		private int _count;

		private bool _hasCount;

		private ConsoleEntry _prevData;

		private RectTransform _rectTransform;

		[RequiredField]
		public Text Count;

		[RequiredField]
		public CanvasGroup CountContainer;

		[RequiredField]
		public StyleComponent ImageStyle;

		[RequiredField]
		public Text Message;

		[RequiredField]
		public Text StackTrace;

		public void SetDataContext(object data)
		{
			if (!(data is ConsoleEntry consoleEntry))
			{
				throw new Exception("Data should be a ConsoleEntry");
			}
			if (consoleEntry.Count > 1)
			{
				if (!_hasCount)
				{
					CountContainer.alpha = 1f;
					_hasCount = true;
				}
				if (consoleEntry.Count != _count)
				{
					Count.text = SRDebuggerUtil.GetNumberString(consoleEntry.Count, 999, "999+");
					_count = consoleEntry.Count;
				}
			}
			else if (_hasCount)
			{
				CountContainer.alpha = 0f;
				_hasCount = false;
			}
			if (consoleEntry != _prevData)
			{
				_prevData = consoleEntry;
				Message.text = consoleEntry.MessagePreview;
				StackTrace.text = consoleEntry.StackTracePreview;
				if (string.IsNullOrEmpty(StackTrace.text))
				{
					Message.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 2f, _rectTransform.rect.height - 4f);
				}
				else
				{
					Message.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 12f, _rectTransform.rect.height - 14f);
				}
				switch (consoleEntry.LogType)
				{
				case LogType.Log:
					ImageStyle.StyleKey = "Console_Info_Blob";
					break;
				case LogType.Warning:
					ImageStyle.StyleKey = "Console_Warning_Blob";
					break;
				case LogType.Error:
				case LogType.Assert:
				case LogType.Exception:
					ImageStyle.StyleKey = "Console_Error_Blob";
					break;
				}
			}
		}

		protected override void Awake()
		{
			base.Awake();
			_rectTransform = base.CachedTransform as RectTransform;
			CountContainer.alpha = 0f;
			Message.supportRichText = Settings.Instance.RichTextInConsole;
		}
	}
}
