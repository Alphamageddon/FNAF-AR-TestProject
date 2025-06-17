using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
	public void ResetPreferences()
	{
		PlayerPrefs.DeleteAll();
		AssetBundle.UnloadAllAssetBundles(unloadAllObjects: true);
		if (!Caching.ClearCache())
		{
			Debug.LogError("COULD NOT CLEAR CACHE.");
		}
		else
		{
			Debug.Log("success!");
		}
	}
}
