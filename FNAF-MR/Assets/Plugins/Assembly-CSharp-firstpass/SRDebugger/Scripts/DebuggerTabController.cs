using System;
using System.Linq;
using SRDebugger.UI.Other;
using SRF;
using UnityEngine;

namespace SRDebugger.Scripts
{
	public class DebuggerTabController : SRMonoBehaviourEx
	{
		private SRTab _aboutTabInstance;

		private DefaultTabs? _activeTab;

		private bool _hasStarted;

		public SRTab AboutTab;

		[RequiredField]
		public SRTabController TabController;

		public DefaultTabs? ActiveTab
		{
			get
			{
				string key = TabController.ActiveTab.Key;
				if (string.IsNullOrEmpty(key))
				{
					return null;
				}
				object obj = Enum.Parse(typeof(DefaultTabs), key);
				if (!Enum.IsDefined(typeof(DefaultTabs), obj))
				{
					return null;
				}
				return (DefaultTabs)obj;
			}
		}

		protected override void Start()
		{
			base.Start();
			_hasStarted = true;
			SRTab[] array = Resources.LoadAll<SRTab>("SRDebugger/UI/Prefabs/Tabs");
			string[] names = Enum.GetNames(typeof(DefaultTabs));
			SRTab[] array2 = array;
			foreach (SRTab sRTab in array2)
			{
				if (sRTab.GetComponent(typeof(IEnableTab)) is IEnableTab { IsEnabled: false })
				{
					continue;
				}
				if (names.Contains(sRTab.Key))
				{
					object obj = Enum.Parse(typeof(DefaultTabs), sRTab.Key);
					if (Enum.IsDefined(typeof(DefaultTabs), obj) && Settings.Instance.DisabledTabs.Contains((DefaultTabs)obj))
					{
						continue;
					}
				}
				TabController.AddTab(SRInstantiate.Instantiate(sRTab));
			}
			if (AboutTab != null)
			{
				_aboutTabInstance = SRInstantiate.Instantiate(AboutTab);
				TabController.AddTab(_aboutTabInstance, visibleInSidebar: false);
			}
			DefaultTabs tab = _activeTab ?? Settings.Instance.DefaultTab;
			if (!OpenTab(tab))
			{
				TabController.ActiveTab = TabController.Tabs.FirstOrDefault();
			}
		}

		public bool OpenTab(DefaultTabs tab)
		{
			if (!_hasStarted)
			{
				_activeTab = tab;
				return true;
			}
			string text = tab.ToString();
			foreach (SRTab tab2 in TabController.Tabs)
			{
				if (tab2.Key == text)
				{
					TabController.ActiveTab = tab2;
					return true;
				}
			}
			return false;
		}

		public void ShowAboutTab()
		{
			if (_aboutTabInstance != null)
			{
				TabController.ActiveTab = _aboutTabInstance;
			}
		}
	}
}
