using SRDebugger.Internal;
using SRDebugger.Services;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
	{
		private const int Max = 1000;

		private static readonly string MaxString = 999 + "+";

		private int _prevErrorCount = -1;

		private int _prevInfoCount = -1;

		private int _prevWarningCount = -1;

		[Import]
		public IConsoleService ConsoleService;

		[RequiredField]
		public Text ErrorCountText;

		[RequiredField]
		public Text InfoCountText;

		[RequiredField]
		public Text WarningCountText;

		protected override void Awake()
		{
			base.Awake();
			ErrorCountText.text = "0";
			WarningCountText.text = "0";
			InfoCountText.text = "0";
		}

		protected override void Update()
		{
			base.Update();
			if (ConsoleService != null)
			{
				if (HasChanged(ConsoleService.ErrorCount, ref _prevErrorCount, 1000))
				{
					ErrorCountText.text = SRDebuggerUtil.GetNumberString(ConsoleService.ErrorCount, 1000, MaxString);
				}
				if (HasChanged(ConsoleService.WarningCount, ref _prevWarningCount, 1000))
				{
					WarningCountText.text = SRDebuggerUtil.GetNumberString(ConsoleService.WarningCount, 1000, MaxString);
				}
				if (HasChanged(ConsoleService.InfoCount, ref _prevInfoCount, 1000))
				{
					InfoCountText.text = SRDebuggerUtil.GetNumberString(ConsoleService.InfoCount, 1000, MaxString);
				}
			}
		}

		private static bool HasChanged(int newCount, ref int oldCount, int max)
		{
			int num = Mathf.Clamp(newCount, 0, max);
			int num2 = Mathf.Clamp(oldCount, 0, max);
			bool result = num != num2;
			oldCount = newCount;
			return result;
		}
	}
}
