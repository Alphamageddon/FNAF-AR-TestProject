using System.Collections;
using UnityEngine;

namespace SRDebugger.Internal
{
	public class BugReportScreenshotUtil
	{
		public static byte[] ScreenshotData;

		public static IEnumerator ScreenshotCaptureCo()
		{
			if (ScreenshotData != null)
			{
				Debug.LogWarning("[SRDebugger] Warning, overriding existing screenshot data.");
			}
			yield return new WaitForEndOfFrame();
			Texture2D texture2D = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, mipChain: false);
			texture2D.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.height), 0, 0);
			texture2D.Apply();
			ScreenshotData = texture2D.EncodeToPNG();
			Object.Destroy(texture2D);
		}
	}
}
