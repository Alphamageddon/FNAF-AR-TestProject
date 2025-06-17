using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardDispatcher
{
	private EventExposer _masterEventExposer;

	private ServerDomain _serverDomain;

	private bool _shouldRequestRewards;

	public RewardDispatcher(EventExposer masterEventExposer, ServerDomain serverDomain)
	{
		_shouldRequestRewards = true;
		_masterEventExposer = masterEventExposer;
		_serverDomain = serverDomain;
	}

	public void Teardown()
	{
		_masterEventExposer = null;
		_serverDomain = null;
	}

	public void RequestRewards(AnimatronicEntity entity, bool encounterDefeated, Action onComplete, bool didUseJammer, bool leftEncounter)
	{
		if (!_shouldRequestRewards && !entity.entityId.ToLower().Contains("shadowbonnie"))
		{
			ExecuteFTUEEncounterRewardFlow(entity.endoskeletonData.cpu, encounterDefeated, onComplete);
			return;
		}
		if (encounterDefeated)
		{
			ReportWin(entity, onComplete, _serverDomain);
			return;
		}
		if (didUseJammer)
		{
			ReportJammer(entity, _serverDomain);
			onComplete?.Invoke();
			return;
		}
		if (leftEncounter)
		{
			ReportLeft(entity, _serverDomain);
			onComplete?.Invoke();
			return;
		}
		ReportLoss(entity, _serverDomain);
		if (onComplete != null)
		{
			CoroutineHelper.StartCoroutine(WaitAndCallComplete(onComplete));
		}
	}

	public IEnumerator WaitAndCallComplete(Action callback)
	{
		yield return new WaitForSeconds(0.3f);
		callback();
		yield return null;
	}

	public static void ReportWin(AnimatronicEntity entity, Action onComplete, ServerDomain serverDomain)
	{
		Debug.LogError("Reporting Won via RewardDispatcher");
		_ = entity.animatronicConfigData.CpuData;
		_ = entity.animatronicConfigData.PlushSuitData;
		serverDomain.mapEntityEncounterWonRequester.FinishEncounter(entity.entityId, onComplete);
	}

	public static void ReportLoss(AnimatronicEntity entity, ServerDomain serverDomain)
	{
		Debug.LogError("Reporting Loss via RewardDispatcher");
		_ = entity.animatronicConfigData.CpuData;
		_ = entity.animatronicConfigData.PlushSuitData;
		serverDomain.mapEntityEncounterLostRequester.FinishEncounter(entity.entityId);
	}

	public static void ReportLeft(AnimatronicEntity entity, ServerDomain serverDomain)
	{
		Debug.LogError("Reporting Left via RewardDispatcher");
		serverDomain.mapEntityEncounterLeftRequester.LeaveEncounter(entity.entityId);
	}

	public static void ReportJammer(AnimatronicEntity entity, ServerDomain serverDomain)
	{
		Debug.LogError("Reporting Jammed via RewardDispatcher");
		serverDomain.mapEntityJamRequester.JamEntity(entity.entityId);
	}

	private void ExecuteFTUEEncounterRewardFlow(string cpuId, bool encounterDefeated, Action onComplete)
	{
		new List<LootRewardEntry>();
		if (cpuId.ToLower() != "bareendo_ftue" && cpuId.ToLower() != "freddyfazbear_basic")
		{
			Debug.LogError("RewardDispatcher ExecuteFTUEEncounterRewardFlow - Invalid cpuId '" + cpuId + "'");
			return;
		}
		new LootRewardDisplayData();
		onComplete?.Invoke();
	}
}
