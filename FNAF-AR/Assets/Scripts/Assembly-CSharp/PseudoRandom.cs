using UnityEngine;

public class PseudoRandom
{
	private static int _modulus;

	private int _multiplier;

	private int _increment;

	private int _seed;

	private bool _initialized;

	public bool Initialized => _initialized;

	public PseudoRandom()
	{
		_multiplier = 125;
		_increment = 789;
		_initialized = false;
	}

	public void SetSeed(int newSeed)
	{
		_seed = newSeed;
		_initialized = true;
	}

	public int Next()
	{
		if (_initialized)
		{
			_seed = _increment + _seed * _multiplier - (_increment + _seed * _multiplier) / _modulus * _modulus;
			return _seed;
		}
		Debug.LogError("Pseudorandom Number Generator being used without being initialized!");
		return 0;
	}

	static PseudoRandom()
	{
		_modulus = 1073741824;
	}
}
