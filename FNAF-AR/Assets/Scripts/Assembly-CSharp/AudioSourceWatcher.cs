using UnityEngine;

internal class AudioSourceWatcher
{
	private AudioSource[] audioSources;

	public AudioSourceWatcher(GameObject gameObject)
	{
		audioSources = gameObject.GetComponentsInChildren<AudioSource>();
	}

	public bool AllAudioSourcesFinished()
	{
		int num = 0;
		do
		{
			if (num >= audioSources.Length)
			{
				return true;
			}
			num++;
		}
		while (!audioSources[0].isPlaying);
		return false;
	}
}
