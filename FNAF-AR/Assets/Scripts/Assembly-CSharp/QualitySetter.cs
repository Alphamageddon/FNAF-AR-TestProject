using UnityEngine;

public class QualitySetter : MonoBehaviour
{
	public enum QualityLevel
	{
		None = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		VeryHigh = 4
	}

	private static int _initialResolutionWidth;

	private static int _initialResolutionHeight;

	private static readonly int DEFAULT_RESOLUTION = 7;

	private static readonly int DEFAULT_FPS = 30;

	private int _currentResolutionWidth;

	private int _currentResolutionHeight;

	public int resolutionMultiplier = 10;

	public int targetFrameRate = 60;

	private bool shouldCheckResolutionChanged;

	public static QualitySetter Instance;

	private void Awake()
	{
		Instance = this;
		_ = SystemInfo.systemMemorySize;
		_ = 2047;
	}

	private void Start()
	{
		_initialResolutionWidth = Display.main.systemWidth;
		_initialResolutionHeight = Display.main.systemHeight;
		SetRatio(0.6f, 1f);
	}

	private void InitSavedValues()
	{
		int num = DEFAULT_RESOLUTION;
		if (PlayerPrefs.HasKey("ResolutionMultiplier"))
		{
			num = PlayerPrefs.GetInt("ResolutionMultiplier");
			if (num < 3)
			{
				num = 3;
			}
		}
		SetResolutionMultiplier(num);
		int fPS = DEFAULT_FPS;
		if (PlayerPrefs.HasKey("TargetFrameRate"))
		{
			fPS = PlayerPrefs.GetInt("TargetFrameRate");
		}
		SetFPS(fPS);
	}

	private void SetRatio(float w, float h)
	{
		if ((float)(_initialResolutionWidth / _initialResolutionHeight) > w / h)
		{
			_initialResolutionWidth = (int)((float)_initialResolutionHeight * (w / h));
		}
		else
		{
			_initialResolutionHeight = (int)((float)_initialResolutionWidth * (h / w));
		}
		InitSavedValues();
	}

	public void SetResolutionMultiplier(int multiplier)
	{
		resolutionMultiplier = multiplier;
		PlayerPrefs.SetInt("ResolutionMultiplier", multiplier);
		PlayerPrefs.Save();
		float num = (float)multiplier / 10f;
		Debug.Log("Setting resolution multiplier " + multiplier + " reduced to: " + num);
		Debug.Log("Initial resolution is " + _initialResolutionWidth + "x" + _initialResolutionHeight);
		_currentResolutionWidth = (int)((float)_initialResolutionWidth * num);
		_currentResolutionHeight = (int)((float)_initialResolutionHeight * num);
		SetResolution();
	}

	private void SetResolution()
	{
		shouldCheckResolutionChanged = false;
		Screen.SetResolution(_currentResolutionWidth, _currentResolutionHeight, FullScreenMode.FullScreenWindow);
		shouldCheckResolutionChanged = true;
	}

	public void SetFPS(int fps)
	{
		targetFrameRate = fps;
		PlayerPrefs.SetInt("TargetFrameRate", fps);
		PlayerPrefs.Save();
	}

	private void Update()
	{
		Application.targetFrameRate = -1;
		if (shouldCheckResolutionChanged && (_currentResolutionWidth != Screen.width || _currentResolutionHeight != Screen.height))
		{
			OnScreenSizeChanged();
		}
	}

	private void OnScreenSizeChanged()
	{
		Debug.LogError("ResolutionChangeException: Resolution fucking changed help");
		_initialResolutionWidth = Display.main.systemWidth;
		_initialResolutionHeight = Display.main.systemHeight;
		SetRatio(0.6f, 1f);
	}
}
