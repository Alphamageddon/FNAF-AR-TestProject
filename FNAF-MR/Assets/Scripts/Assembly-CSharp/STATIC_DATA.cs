using System.Collections.Generic;

public sealed class STATIC_DATA
{
	public class Angle
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class AngleRange
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class BaseAngle
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class BaseEffects
	{
		public double Shear { get; set; }

		public double Audio { get; set; }
	}

	public class Charge
	{
		public BaseAngle BaseAngle { get; set; }

		public BaseEffects BaseEffects { get; set; }

		public Angle Angle { get; set; }

		public Effects Effects { get; set; }

		public FlashlightAngle FlashlightAngle { get; set; }

		public FlashlightEffects FlashlightEffects { get; set; }
	}

	public class ChargeStaticSettings
	{
		public AngleRange AngleRange { get; set; }

		public ShaderSettings ShaderSettings { get; set; }

		public FlashlightAngleRange FlashlightAngleRange { get; set; }

		public FlashlightAdditive FlashlightAdditive { get; set; }
	}

	public class Circle
	{
		public BaseAngle BaseAngle { get; set; }

		public BaseEffects BaseEffects { get; set; }

		public Angle Angle { get; set; }

		public Effects Effects { get; set; }

		public FlashlightAngle FlashlightAngle { get; set; }

		public FlashlightEffects FlashlightEffects { get; set; }
	}

	public class CircleStaticSettings
	{
		public AngleRange AngleRange { get; set; }

		public ShaderSettings ShaderSettings { get; set; }

		public FlashlightAngleRange FlashlightAngleRange { get; set; }

		public FlashlightAdditive FlashlightAdditive { get; set; }
	}

	public class Duration
	{
		public double Min { get; set; }

		public double Max { get; set; }
	}

	public class Effects
	{
		public double Shear { get; set; }

		public double Audio { get; set; }
	}

	public class Entry
	{
		public string Profile { get; set; }

		public Circle Circle { get; set; }

		public Pause Pause { get; set; }

		public Charge Charge { get; set; }

		public WalkFootsteps WalkFootsteps { get; set; }

		public RunFootsteps RunFootsteps { get; set; }

		public CircleStaticSettings CircleStaticSettings { get; set; }

		public PauseStaticSettings PauseStaticSettings { get; set; }

		public ChargeStaticSettings ChargeStaticSettings { get; set; }

		public WalkFootstepAdditive WalkFootstepAdditive { get; set; }

		public RunFootstepAdditive RunFootstepAdditive { get; set; }

		public PhantomWalk PhantomWalk { get; set; }

		public PhantomWalkStaticSettings PhantomWalkStaticSettings { get; set; }
	}

	public class FadeSettings
	{
		public double FadeIn { get; set; }

		public double FadeOut { get; set; }
	}

	public class FlashlightAdditive
	{
		public bool IsPositional { get; set; }

		public ShaderSettings ShaderSettings { get; set; }
	}

	public class FlashlightAngle
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class FlashlightAngleRange
	{
		public int Min { get; set; }

		public int Max { get; set; }
	}

	public class FlashlightEffects
	{
		public double Shear { get; set; }

		public double Audio { get; set; }
	}

	public class Pause
	{
		public BaseAngle BaseAngle { get; set; }

		public BaseEffects BaseEffects { get; set; }

		public Angle Angle { get; set; }

		public Effects Effects { get; set; }

		public FlashlightAngle FlashlightAngle { get; set; }

		public FlashlightEffects FlashlightEffects { get; set; }
	}

	public class PauseStaticSettings
	{
		public AngleRange AngleRange { get; set; }

		public ShaderSettings ShaderSettings { get; set; }

		public FlashlightAngleRange FlashlightAngleRange { get; set; }

		public FlashlightAdditive FlashlightAdditive { get; set; }
	}

	public class PhantomWalk
	{
		public BaseAngle BaseAngle { get; set; }

		public BaseEffects BaseEffects { get; set; }

		public Angle Angle { get; set; }

		public Effects Effects { get; set; }

		public FlashlightAngle FlashlightAngle { get; set; }

		public FlashlightEffects FlashlightEffects { get; set; }
	}

	public class PhantomWalkStaticSettings
	{
		public AngleRange AngleRange { get; set; }

		public ShaderSettings ShaderSettings { get; set; }

		public FlashlightAngleRange FlashlightAngleRange { get; set; }

		public FlashlightAdditive FlashlightAdditive { get; set; }
	}

	public class Root
	{
		public List<Entry> Entries { get; set; }
	}

	public class RunFootstepAdditive
	{
		public bool IsPositional { get; set; }

		public FadeSettings FadeSettings { get; set; }

		public Duration Duration { get; set; }

		public ShaderSettings ShaderSettings { get; set; }
	}

	public class RunFootsteps
	{
		public bool IsPositional { get; set; }

		public FadeSettings FadeSettings { get; set; }

		public Duration Duration { get; set; }

		public Effects Effects { get; set; }
	}

	public class ShaderSettings
	{
		public double Shear { get; set; }

		public double Audio { get; set; }
	}

	public class WalkFootstepAdditive
	{
		public FadeSettings FadeSettings { get; set; }

		public Duration Duration { get; set; }

		public ShaderSettings ShaderSettings { get; set; }
	}

	public class WalkFootsteps
	{
		public FadeSettings FadeSettings { get; set; }

		public Duration Duration { get; set; }

		public Effects Effects { get; set; }
	}
}
