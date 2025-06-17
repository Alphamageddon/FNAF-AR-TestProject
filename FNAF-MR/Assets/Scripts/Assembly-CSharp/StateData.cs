using System;

[Serializable]
public class StateData
{
	[Serializable]
	public enum AnimatronicState
	{
		NoState = -1,
		FarAway = 0,
		StalkingPlayer = 1,
		ApproachingPlayer = 2,
		NearPlayer = 3,
		SameRoom = 4,
		BackToWorkshop = 5,
		Destroy = 6,
		OnDeck = 7,
		WaitingForMovementNodes = 8,
		MoveToStalkingRange = 9,
		Scavenging = 10,
		Recall = 11,
		SentAway = 12,
		Blink = 13,
		Travel = 14,
		ScavengeAppointment = 15,
		COUNT = 16
	}

	private static AnimatronicState[] beforeAttackStates;

	private static AnimatronicState[] afterStalkingStates;

	public AnimatronicState animatronicState { get; set; }

	public bool expressDelivery { get; set; }

	public static bool IsInState(AnimatronicState sourceState, AnimatronicState stateToCheck)
	{
		return sourceState == stateToCheck;
	}

	public static bool IsInStates(AnimatronicState sourceState, AnimatronicState[] statesToCheck)
	{
		for (int i = 0; i < statesToCheck.Length; i++)
		{
			if (statesToCheck[i] == sourceState)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsBeforeAttack(AnimatronicState sourceState)
	{
		return IsInStates(sourceState, beforeAttackStates);
	}

	public static bool IsAfterStalking(AnimatronicState sourceState)
	{
		return IsInStates(sourceState, afterStalkingStates);
	}

	public StateData()
	{
		animatronicState = AnimatronicState.FarAway;
		expressDelivery = false;
	}

	public StateData(StateData stateData)
	{
		animatronicState = stateData.animatronicState;
		expressDelivery = stateData.expressDelivery;
	}

	public StateData(AnimatronicState animatronicState, bool expressDelivery)
	{
		this.animatronicState = animatronicState;
		this.expressDelivery = expressDelivery;
	}

	public override string ToString()
	{
		return animatronicState.ToString();
	}

	static StateData()
	{
		beforeAttackStates = new AnimatronicState[3]
		{
			AnimatronicState.StalkingPlayer,
			AnimatronicState.ApproachingPlayer,
			AnimatronicState.NearPlayer
		};
		afterStalkingStates = new AnimatronicState[2]
		{
			AnimatronicState.ApproachingPlayer,
			AnimatronicState.NearPlayer
		};
	}
}
