using UnityEngine;

public class AnimatronicEntityConfig : MonoBehaviour
{
	public int maxEntitiesAllowed;

	public float updateFrequencyMinSeconds;

	public float updateFrequencyMaxSeconds;

	public float stalkingDegreesPerSecond;

	public float stalkingClockwiseChance;

	public float stalkingSwitchbackMinTimer;

	public float stalkingSwitchbackMaxTimer;

	public float approachUpdateFrequencyMinSeconds;

	public float approachUpdateFrequencyMaxSeconds;

	public float playerDistanceToTriggerStalkingMode;

	public float playerDistanceToTriggerDarkMode;

	public float playerDistanceToTriggerTravelMode;

	public float playerDistanceTravelMax;

	public float darkModeMetersPerSecond;

	public float sendDistance;

	public float blinkTime;

	public float sendSpawnOffset;

	public AnimatronicEntityConfig()
	{
		updateFrequencyMinSeconds = 0.5f;
		updateFrequencyMaxSeconds = 2f;
		stalkingDegreesPerSecond = 6f;
		stalkingClockwiseChance = 0.5f;
		maxEntitiesAllowed = 5;
		stalkingSwitchbackMinTimer = 5f;
		stalkingSwitchbackMaxTimer = 10f;
		approachUpdateFrequencyMinSeconds = 0.2f;
		approachUpdateFrequencyMaxSeconds = 1f;
		darkModeMetersPerSecond = 10f;
		sendDistance = 500f;
		playerDistanceToTriggerStalkingMode = 80f;
		playerDistanceToTriggerDarkMode = 20f;
		playerDistanceToTriggerTravelMode = 800f;
		playerDistanceTravelMax = 1000f;
		blinkTime = 2f;
		sendSpawnOffset = 150f;
	}
}
