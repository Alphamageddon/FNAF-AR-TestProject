using UnityEngine;

public class BillboardIndicator : MonoBehaviour
{
	private Animator _animator;

	private static readonly int FlashId = Animator.StringToHash("Flashing");

	private static readonly int JitterId = Animator.StringToHash("Jitter");

	private static readonly int SteadyId = Animator.StringToHash("Steady");

	private void OnEnable()
	{
		_animator = GetComponent<Animator>();
	}

	public void PlayAnimation(TextAnim anim)
	{
		if (!(_animator == null))
		{
			switch (anim)
			{
			case TextAnim.Steady:
				_animator.SetTrigger(SteadyId);
				break;
			case TextAnim.Flashing:
				_animator.SetTrigger(FlashId);
				break;
			case TextAnim.Jitter:
				_animator.SetTrigger(JitterId);
				break;
			}
		}
	}
}
