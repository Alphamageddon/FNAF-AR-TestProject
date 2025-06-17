using System;
using System.Collections.Generic;

public class MenuTabsHandler
{
	private List<TabParentKeyValue> tabParents;

	private Tab currentTab;

	private Action<Tab> DidSwitchTabs;

	private Action<Tab> WillSwitchTabs;

	private bool IsCurrentTab(Tab tab)
	{
		foreach (TabParentKeyValue tabParent in tabParents)
		{
			if (tabParent.tab == tab)
			{
				return tabParent.parent.activeSelf;
			}
		}
		return false;
	}

	public MenuTabsHandler(List<TabParentKeyValue> tabParents, Action<Tab> switchedTabs, Action<Tab> willSwitchTabs)
	{
		this.tabParents = tabParents;
		DidSwitchTabs = switchedTabs;
		WillSwitchTabs = willSwitchTabs;
	}

	public void ShowTab(Tab tab)
	{
		if (IsCurrentTab(tab))
		{
			return;
		}
		WillSwitchTabs(tab);
		foreach (TabParentKeyValue tabParent in tabParents)
		{
			tabParent.parent.SetActive(tabParent.tab == tab);
		}
		DidSwitchTabs(tab);
		if (tab == Tab.leaderboard)
		{
		}
	}
}
