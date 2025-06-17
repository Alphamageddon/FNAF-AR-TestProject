using UnityEngine;
using UnityEngine.Serialization;

public class MoveableEnvironmentObject : MonoBehaviour
{
	private Animator animator;

	[FormerlySerializedAs("objectDisabled")]
	[SerializeField]
	private GameObject falsePosition;

	[FormerlySerializedAs("objectEnabled")]
	[SerializeField]
	private GameObject truePosition;

	private float cooldown;

	public bool state;

	private void OnEnable()
	{
		state = false;
		animator = GetComponent<Animator>();
	}

	public void Tapped()
	{
		if (!(cooldown > 0f))
		{
			cooldown = 0.2f;
			state = !state;
			Debug.Log("box tapped");
			truePosition.SetActive(state);
			falsePosition.SetActive(!state);
			animator.ResetTrigger("Go");
			animator.SetInteger("Position", state ? 1 : 0);
			animator.SetTrigger("Go");
			Debug.Log("set Position of " + base.gameObject.name + " to " + (state ? 1 : 0));
		}
	}

	private void Update()
	{
		if (cooldown > 0f)
		{
			cooldown -= Time.deltaTime;
		}
	}
}
