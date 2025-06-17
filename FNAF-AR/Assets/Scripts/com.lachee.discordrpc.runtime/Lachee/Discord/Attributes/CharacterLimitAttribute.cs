using UnityEngine;

namespace Lachee.Discord.Attributes
{
	public class CharacterLimitAttribute : PropertyAttribute
	{
		public int max = 32;

		public bool enforce;

		public CharacterLimitAttribute(int max)
		{
			this.max = max;
			enforce = false;
		}

		public CharacterLimitAttribute(int max, bool enforce)
		{
			this.max = max;
			this.enforce = enforce;
		}
	}
}
