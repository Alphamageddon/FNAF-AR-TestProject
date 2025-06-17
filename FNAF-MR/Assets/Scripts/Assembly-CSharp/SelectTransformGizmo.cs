using RuntimeHandle;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectTransformGizmo : MonoBehaviour
{
	private Transform highlight;

	private Transform selection;

	private RaycastHit raycastHit;

	private RaycastHit raycastHitHandle;

	private GameObject runtimeTransformGameObj;

	private RuntimeTransformHandle runtimeTransformHandle;

	private int runtimeTransformLayer = 9;

	private int runtimeTransformLayerMask;

	public ModelConfigOCBase ocCreator;

	private void Start()
	{
		runtimeTransformGameObj = new GameObject();
		runtimeTransformHandle = runtimeTransformGameObj.AddComponent<RuntimeTransformHandle>();
		runtimeTransformGameObj.layer = runtimeTransformLayer;
		runtimeTransformLayerMask = 1 << runtimeTransformLayer;
		runtimeTransformHandle.type = HandleType.POSITION;
		runtimeTransformHandle.space = HandleSpace.LOCAL;
		runtimeTransformHandle.autoScale = true;
		runtimeTransformHandle.autoScaleFactor = 1f;
		runtimeTransformGameObj.SetActive(value: false);
	}

	private void Update()
	{
		if (highlight != null)
		{
			highlight = null;
		}
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out raycastHit, 1000f))
		{
			highlight = raycastHit.transform;
			if (!highlight.CompareTag("Selectable") || !(highlight != selection))
			{
				highlight = null;
			}
		}
		if (!Input.GetMouseButtonDown(0) || EventSystem.current.IsPointerOverGameObject())
		{
			return;
		}
		ApplyLayerToChildren(runtimeTransformGameObj);
		if (Physics.Raycast(ray, out raycastHit))
		{
			if (!Physics.Raycast(ray, out raycastHitHandle, float.PositiveInfinity, runtimeTransformLayerMask))
			{
				if ((bool)highlight)
				{
					_ = selection != null;
					selection = raycastHit.transform;
					runtimeTransformHandle.target = selection;
					runtimeTransformGameObj.SetActive(value: true);
					ocCreator.SelectObject(selection.gameObject);
					highlight = null;
				}
				else if ((bool)selection)
				{
					selection = null;
					runtimeTransformGameObj.SetActive(value: false);
					ocCreator.DeselectObjects();
				}
			}
		}
		else if ((bool)selection)
		{
			selection = null;
			runtimeTransformGameObj.SetActive(value: false);
			ocCreator.DeselectObjects();
		}
	}

	public void SetHandleType(HandleType type)
	{
		runtimeTransformHandle.type = type;
	}

	public void ForceSelection(Transform selected)
	{
		selection = selected;
		runtimeTransformHandle.target = selected;
		runtimeTransformGameObj.SetActive(value: true);
	}

	public void ForceDeselect()
	{
		selection = null;
		runtimeTransformGameObj.SetActive(value: false);
	}

	private void ApplyLayerToChildren(GameObject parentGameObj)
	{
		foreach (Transform item in parentGameObj.transform)
		{
			int layer = runtimeTransformLayer;
			item.gameObject.layer = layer;
			foreach (Transform item2 in item)
			{
				item2.gameObject.layer = layer;
				foreach (Transform item3 in item2)
				{
					item3.gameObject.layer = layer;
					foreach (Transform item4 in item3)
					{
						item4.gameObject.layer = layer;
						foreach (Transform item5 in item4)
						{
							item5.gameObject.layer = layer;
						}
					}
				}
			}
		}
	}
}
