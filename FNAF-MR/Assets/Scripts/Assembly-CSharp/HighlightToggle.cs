using UnityEngine;
using UnityEngine.UI;

public class HighlightToggle : MonoBehaviour
{
	[SerializeField]
	private GameObject selectedObject;

	[SerializeField]
	private GameObject unselectedObject;

	[SerializeField]
	private bool autoSelectOnButtonClick = true;

	[SerializeField]
	private bool unselectSiblingsOnSelected;

	private void SetSelected(bool value)
	{
		if (selectedObject != null)
		{
			selectedObject.SetActive(value);
		}
		if (!(unselectedObject == null))
		{
			unselectedObject.SetActive(!value);
		}
	}

	private void UnselectSiblings()
	{
		HighlightToggle[] componentsInChildren = base.transform.parent.GetComponentsInChildren<HighlightToggle>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].SetHighlight(value: false);
		}
	}

	public void SetHighlight(bool value)
	{
		SetSelected(value);
	}

	public void SetHighlightAndOtherCellsHighlightState(bool value)
	{
		if (unselectSiblingsOnSelected)
		{
			UnselectSiblings();
		}
		SetSelected(value);
	}

	private void Awake()
	{
		if (autoSelectOnButtonClick && base.gameObject.GetComponent<Button>() != null)
		{
			Debug.Log("found button for highlight " + base.gameObject.name);
			base.gameObject.GetComponent<Button>().onClick.AddListener(ButtonPress);
		}
	}

	private void ButtonPress()
	{
		Debug.Log("clicked highlight");
		SetHighlightAndOtherCellsHighlightState(value: true);
	}
}
