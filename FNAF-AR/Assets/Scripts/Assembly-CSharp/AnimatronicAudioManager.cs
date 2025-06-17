using FMODUnity;
using UnityEngine;

public class AnimatronicAudioManager : MonoBehaviour
{
	private float CameraStaticStrength;

	public void SetVolume(float level)
	{
	}

	public void SetMute(bool shouldMute)
	{
	}

	public void SetRtpcValue(string rtpcName, float rtpcValue)
	{
		RuntimeManager.StudioSystem.setParameterByName(rtpcName, rtpcValue);
		if (rtpcName == "CameraStaticStrength")
		{
			CameraStaticStrength = rtpcValue;
		}
	}

	public void SendEvent(string eventName)
	{
		Debug.Log("received event request " + eventName);
		RuntimeManager.PlayOneShot("event:/" + eventName, base.transform.position);
	}

	private void OnGUI()
	{
		_ = CameraStaticStrength;
		_ = 0f;
	}
}
