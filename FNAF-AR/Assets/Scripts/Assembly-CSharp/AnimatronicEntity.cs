using System;

public class AnimatronicEntity
{
	public float timeInSameRoom;

	public Action StateChanged;

	public AnimatronicEntityDomain AnimatronicEntityDomain { get; }

	public string entityId { get; }

	public StateData stateData { get; }

	public OriginData originData { get; }

	public AnimatronicConfigData animatronicConfigData { get; }

	public AttackSequenceData AttackSequenceData { get; }

	public bool LocationInitialized { get; set; }

	public EndoskeletonData endoskeletonData { get; }

	public RewardDataV3 rewardDataV3 { get; set; }

	public int wearAndTear { get; set; }

	public bool isScavenging { get; set; }

	public ScavengingData scavengingData { get; set; }

	public AnimatronicEntity(string id, AnimatronicEntityDomain domain, CPUData cpu, PlushSuitData plushSuit, OriginData.OriginState originState)
	{
		AnimatronicEntityDomain = domain;
		entityId = domain.container.GetFakeID(id);
		stateData = new StateData(StateData.AnimatronicState.FarAway, expressDelivery: false);
		originData = new OriginData();
		originData.originState = originState;
		animatronicConfigData = new AnimatronicConfigData(cpu, plushSuit, null);
		AttackSequenceData = new AttackSequenceData();
		AttackSequenceData.encounterStartTime = 0L;
		AttackSequenceData.attackSequenceComplete = false;
		endoskeletonData = new EndoskeletonData();
		rewardDataV3 = new RewardDataV3();
		wearAndTear = 100;
	}

	public AnimatronicEntity(AnimatronicEntityDomain animatronicEntityDomain, string entityId, StateData stateData, OriginData originData, AnimatronicConfigData animatronicConfigData, AttackSequenceData attackSequenceData, EndoskeletonData endoskeletonData, int wearAndTear, RewardDataV3 rewardDataV3, bool isScavenging = false, ScavengingData scavengingEnvironment = null)
	{
		AnimatronicEntityDomain = animatronicEntityDomain;
		this.entityId = entityId;
		this.stateData = new StateData(stateData);
		this.originData = new OriginData(originData);
		this.animatronicConfigData = new AnimatronicConfigData(animatronicConfigData);
		AttackSequenceData = new AttackSequenceData(attackSequenceData);
		this.endoskeletonData = new EndoskeletonData(endoskeletonData);
		LocationInitialized = false;
		this.wearAndTear = wearAndTear;
		if (rewardDataV3 != null)
		{
			this.rewardDataV3 = new RewardDataV3(rewardDataV3);
			this.isScavenging = isScavenging;
			scavengingData = scavengingEnvironment;
		}
	}

	public void InitDataGeneric()
	{
		InitGeoPosition();
		LocationInitialized = true;
	}

	public void InitDataForTutorialOrigin()
	{
		CreateStartNode();
		CreateEndNode();
		LocationInitialized = true;
	}

	public void InitDataForFarAwayState()
	{
		InitGeoPosition();
		CreateStartNode();
		CreateEndNode();
		LocationInitialized = true;
	}

	public void InitDataForScavengeState()
	{
		stateData.animatronicState = StateData.AnimatronicState.Scavenging;
		LocationInitialized = true;
	}

	public void InitDataForSent()
	{
		stateData.animatronicState = StateData.AnimatronicState.SentAway;
		SetSentAnimatronicDataDirection();
		LocationInitialized = true;
	}

	public void InitDataForScavengeAppointmentState()
	{
		stateData.animatronicState = StateData.AnimatronicState.ScavengeAppointment;
		LocationInitialized = true;
	}

	public void InitDataForNearPlayerState()
	{
		LocationInitialized = true;
	}

	public void InitDataForSentAwayState()
	{
		InitGeoPosition();
		SetSentAnimatronicDataDirection();
		stateData.animatronicState = StateData.AnimatronicState.SentAway;
		LocationInitialized = true;
	}

	private void InitGeoPosition()
	{
	}

	private void InitMovementNodes()
	{
		CreateStartNode();
		CreateEndNode();
	}

	private void CreateStartNode()
	{
	}

	private void CreateEndNode()
	{
	}

	private void SetSentAnimatronicDataDirection()
	{
	}

	public void StateChangedByServer()
	{
		StateChanged?.Invoke();
		if (stateData.animatronicState == StateData.AnimatronicState.SentAway)
		{
			SetSentAnimatronicDataDirection();
		}
	}
}
