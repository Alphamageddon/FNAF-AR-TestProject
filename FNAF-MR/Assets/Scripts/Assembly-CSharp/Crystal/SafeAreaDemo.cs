using System;
using UnityEngine;

namespace Crystal
{
	public class SafeAreaDemo : MonoBehaviour
	{
		[SerializeField]
		private KeyCode KeySafeArea = KeyCode.A;

		private SafeArea.SimDevice[] Sims;

		private int SimIdx;

		private void Awake()
		{
			if (!Application.isEditor)
			{
				UnityEngine.Object.Destroy(this);
			}
			Sims = (SafeArea.SimDevice[])Enum.GetValues(typeof(SafeArea.SimDevice));
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeySafeArea))
			{
				ToggleSafeArea();
			}
		}

		private void ToggleSafeArea()
		{
			SimIdx++;
			if (SimIdx >= Sims.Length)
			{
				SimIdx = 0;
			}
			SafeArea.Sim = Sims[SimIdx];
			Debug.LogFormat("Switched to sim device {0} with debug key '{1}'", Sims[SimIdx], KeySafeArea);
		}
	}
}
