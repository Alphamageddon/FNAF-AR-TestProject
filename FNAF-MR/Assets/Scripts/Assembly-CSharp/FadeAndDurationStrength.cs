using UnityEngine;

public class FadeAndDurationStrength
{
	private readonly float _fadeIn;

	private readonly float _duration;

	private readonly float _fadeOut;

	private float _start;

	private float _fadeInEnd;

	private float _durationEnd;

	private float _fadeOutEnd;

	public bool HasEnded(float time)
	{
		if (_start < 0f)
		{
			return true;
		}
		return _fadeOutEnd <= time;
	}

	public void Start(float time)
	{
		_start = time;
		_fadeInEnd = _fadeIn + time;
		time = _fadeInEnd + _duration;
		_durationEnd = time;
		_fadeOutEnd = time + _fadeOut;
	}

	public float GetStrength(float time)
	{
		if (_start < 0f)
		{
			return 0f;
		}
		float num;
		if (_fadeInEnd > time)
		{
			num = _fadeIn;
		}
		else
		{
			if (_durationEnd > time)
			{
				return 1f;
			}
			if (_fadeOutEnd <= time)
			{
				return 0f;
			}
			num = _fadeIn + _duration + _fadeOut;
		}
		return (time - _start) / num;
	}

	public FadeAndDurationStrength(StaticFadeSettings fadeSettings, StaticValueRange durationRange)
	{
		_start = 0f;
		_fadeInEnd = 0f;
		_durationEnd = 0f;
		_fadeOutEnd = 0f;
		_fadeIn = fadeSettings.FadeIn;
		_duration = Random.Range(durationRange.Min, durationRange.Max);
		_fadeOut = fadeSettings.FadeOut;
	}
}
