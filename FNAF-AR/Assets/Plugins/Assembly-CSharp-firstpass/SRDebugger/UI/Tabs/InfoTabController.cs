using System.Collections.Generic;
using System.Text;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using SRF.Service;
using UnityEngine;

namespace SRDebugger.UI.Tabs
{
	public class InfoTabController : SRMonoBehaviourEx
	{
		public const char Tick = '✓';

		public const char Cross = '×';

		public const string NameColor = "#BCBCBC";

		private Dictionary<string, InfoBlock> _infoBlocks = new Dictionary<string, InfoBlock>();

		[RequiredField]
		public InfoBlock InfoBlockPrefab;

		[RequiredField]
		public RectTransform LayoutContainer;

		protected override void OnEnable()
		{
			base.OnEnable();
			Refresh();
		}

		public void Refresh()
		{
			ISystemInformationService service = SRServiceManager.GetService<ISystemInformationService>();
			foreach (string category in service.GetCategories())
			{
				if (!_infoBlocks.ContainsKey(category))
				{
					InfoBlock value = CreateBlock(category);
					_infoBlocks.Add(category, value);
				}
			}
			foreach (KeyValuePair<string, InfoBlock> infoBlock in _infoBlocks)
			{
				FillInfoBlock(infoBlock.Value, service.GetInfo(infoBlock.Key));
			}
		}

		private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			foreach (InfoEntry item in info)
			{
				if (item.Title.Length > num)
				{
					num = item.Title.Length;
				}
			}
			num += 2;
			bool flag = true;
			foreach (InfoEntry item2 in info)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append("<color=");
				stringBuilder.Append("#BCBCBC");
				stringBuilder.Append(">");
				stringBuilder.Append(item2.Title);
				stringBuilder.Append(": ");
				stringBuilder.Append("</color>");
				for (int i = item2.Title.Length; i <= num; i++)
				{
					stringBuilder.Append(' ');
				}
				if (item2.Value is bool)
				{
					stringBuilder.Append(((bool)item2.Value) ? '✓' : '×');
				}
				else
				{
					stringBuilder.Append(item2.Value);
				}
			}
			block.Content.text = stringBuilder.ToString();
		}

		private InfoBlock CreateBlock(string title)
		{
			InfoBlock infoBlock = SRInstantiate.Instantiate(InfoBlockPrefab);
			infoBlock.Title.text = title;
			infoBlock.CachedTransform.SetParent(LayoutContainer, worldPositionStays: false);
			return infoBlock;
		}
	}
}
