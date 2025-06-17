using System.Collections;
using UnityEngine;

namespace SRF
{
	public static class Coroutines
	{
		public static IEnumerator WaitForSecondsRealTime(float time)
		{
			float endTime = Time.realtimeSinceStartup + time;
			while (Time.realtimeSinceStartup < endTime)
			{
				yield return null;
			}
		}
	}
}
