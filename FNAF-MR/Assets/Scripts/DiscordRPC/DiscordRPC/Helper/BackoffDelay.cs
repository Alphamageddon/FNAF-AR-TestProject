using System;

namespace DiscordRPC.Helper
{
	internal class BackoffDelay
	{
		private int _current;

		private int _fails;

		public int Maximum { get; private set; }

		public int Minimum { get; private set; }

		public int Current => _current;

		public int Fails => _fails;

		public Random Random { get; set; }

		private BackoffDelay()
		{
		}

		public BackoffDelay(int min, int max)
			: this(min, max, new Random())
		{
		}

		public BackoffDelay(int min, int max, Random random)
		{
			Minimum = min;
			Maximum = max;
			_current = min;
			_fails = 0;
			Random = random;
		}

		public void Reset()
		{
			_fails = 0;
			_current = Minimum;
		}

		public int NextDelay()
		{
			_fails++;
			double num = (float)(Maximum - Minimum) / 100f;
			_current = (int)Math.Floor(num * (double)_fails) + Minimum;
			return Math.Min(Math.Max(_current, Minimum), Maximum);
		}
	}
}
