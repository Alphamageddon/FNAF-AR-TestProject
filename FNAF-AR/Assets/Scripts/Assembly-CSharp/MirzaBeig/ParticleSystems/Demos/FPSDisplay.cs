using UnityEngine;
using UnityEngine.UI;

namespace MirzaBeig.ParticleSystems.Demos
{
	public class FPSDisplay : MonoBehaviour
	{
		private float timer;

		public float updateTime = 1f;

		private int frameCount;

		private float fpsAccum;

		private Text fpsText;

		private void Awake()
		{
		}

		private void Start()
		{
			fpsText = GetComponent<Text>();
		}

		private void Update()
		{
			frameCount++;
			timer += Time.deltaTime;
			fpsAccum += 1f / Time.deltaTime;
			if (timer >= updateTime)
			{
				timer = 0f;
				int num = Mathf.RoundToInt(fpsAccum / (float)frameCount);
				fpsText.text = "Average FPS: " + num;
				frameCount = 0;
				fpsAccum = 0f;
			}
		}
	}
}
