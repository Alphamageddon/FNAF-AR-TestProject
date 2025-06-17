using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCellDisabler : MonoBehaviour
{
	private const string ClassName = "ChildCellDisabler";

	[SerializeField]
	private float _disableTime;

	private List<IDisableableChildCell> _children;

	private bool _isDisabling;

	public void OnChildAdded(IDisableableChildCell child)
	{
		_children.Add(child);
		child.UpdateEnableState(!_isDisabling);
	}

	public void OnChildRemoved(IDisableableChildCell child)
	{
		_children.Remove(child);
	}

	public void Invoke()
	{
		if (_isDisabling)
		{
			Debug.LogError("ChildCellDisabler Invoke - Attempt to invoke childCellDisabler that is already in a disabled state");
		}
		_isDisabling = true;
		foreach (IDisableableChildCell child in _children)
		{
			child.UpdateEnableState(state: false);
		}
		StartCoroutine(WaitThenReenable(_disableTime));
	}

	private IEnumerator WaitThenReenable(float delay)
	{
		yield return new WaitForSeconds(delay);
		foreach (IDisableableChildCell child in _children)
		{
			child.UpdateEnableState(state: true);
		}
		_isDisabling = false;
	}

	public ChildCellDisabler()
	{
		_children = new List<IDisableableChildCell>();
	}
}
