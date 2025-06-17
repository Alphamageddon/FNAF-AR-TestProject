using UnityEngine;

public class AnimatorDispatcher
{
	private Animator _animator;

	public void SetAnimationMode(AnimationMode animationMode)
	{
		SetAnimationInt(AnimationInt.AnimationMode, (int)animationMode);
		SetAnimationTrigger(AnimationTrigger.SwitchMode, shouldSet: true);
	}

	public bool IsAnimationTagActive(AnimationTag animationTag)
	{
		return _animator.GetCurrentAnimatorStateInfo(0).IsTag(animationTag.ToString());
	}

	public bool IsAnimating()
	{
		if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
		{
			return !_animator.IsInTransition(0);
		}
		return false;
	}

	public void SetAnimationBool(AnimationBool animationBool, bool value)
	{
		_animator.SetBool(animationBool.ToString(), value);
	}

	public void SetAnimationInt(AnimationInt animationInt, int value)
	{
		_animator.SetInteger(animationInt.ToString(), value);
	}

	public void SetAnimationFloat(AnimationFloat animationFloat, float value)
	{
		_animator.SetFloat(animationFloat.ToString(), value);
	}

	public void SetAnimationTrigger(AnimationTrigger animationTrigger, bool shouldSet)
	{
		if (shouldSet)
		{
			_animator.SetTrigger(animationTrigger.ToString());
		}
		else
		{
			_animator.ResetTrigger(animationTrigger.ToString());
		}
	}

	public void SetAnimatorLayerWeight(int layer, float weight)
	{
		_animator.SetLayerWeight(layer, weight);
	}

	public void Setup(Animator animator)
	{
		_animator = animator;
	}

	public void Teardown()
	{
		_animator = null;
	}
}
