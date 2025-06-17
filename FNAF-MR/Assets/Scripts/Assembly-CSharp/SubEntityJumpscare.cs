using System;
using System.Collections.Generic;

public class SubEntityJumpscare
{
	public readonly SubEntityData.SubEntityJumpscareSource Source;

	public readonly float TimeToJumpscare;

	public readonly bool PauseWhileDeactivationRequirementActive;

	public readonly List<SubEntityJumpscareEffect> JumpscareEffects = new List<SubEntityJumpscareEffect>();

	public readonly float EffectSeconds;

	public SubEntityJumpscare(SUB_ENTITY_DATA.Jumpscare rawSettings)
	{
		Source = (SubEntityData.SubEntityJumpscareSource)Enum.Parse(typeof(SubEntityData.SubEntityJumpscareSource), rawSettings.JumpscareSource);
		TimeToJumpscare = rawSettings.TimeToJumpscare;
		PauseWhileDeactivationRequirementActive = rawSettings.PauseWhileDeactivationRequirementActive;
		if (rawSettings.JumpscareEffects != null)
		{
			foreach (SUB_ENTITY_DATA.JumpscareEffect jumpscareEffect in rawSettings.JumpscareEffects)
			{
				JumpscareEffects.Add(new SubEntityJumpscareEffect(jumpscareEffect));
			}
		}
		EffectSeconds = rawSettings.JumpscareEffectSeconds;
	}
}
