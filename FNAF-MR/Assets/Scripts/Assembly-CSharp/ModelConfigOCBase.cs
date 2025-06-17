using System.Collections.Generic;
using RuntimeHandle;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelConfigOCBase : MonoBehaviour
{
	private enum Mode
	{
		Position = 1,
		Rotation = 2,
		Scale = 3
	}

	[Header("Material")]
	[SerializeField]
	private Material baseMaterial;

	[HideInInspector]
	public GameObject selectedObject;

	[Header("Bone Objects")]
	public List<RigBone> bones;

	[Header("UI Parents")]
	public GameObject DeselectedUI;

	public GameObject SelectedUI;

	[Header("Relevant UI Elements")]
	public Button positionButton;

	public Button rotationButton;

	public Button scaleButton;

	public TextMeshProUGUI hideMeshButtonText;

	public Slider XSlider;

	public Slider YSlider;

	public Slider ZSlider;

	public Slider RotationSlider;

	public TMP_Dropdown BoneDropdown;

	public Transform cameraMover;

	public GameObject hideableMesh;

	public SelectTransformGizmo selectionHandler;

	public Dictionary<GameObject, OCCreatorObject> objects = new Dictionary<GameObject, OCCreatorObject>();

	private Mode currentMode = Mode.Position;

	private void Awake()
	{
		List<TMP_Dropdown.OptionData> list = new List<TMP_Dropdown.OptionData>();
		foreach (RigBone bone in bones)
		{
			list.Add(new TMP_Dropdown.OptionData(bone.BoneName));
		}
		BoneDropdown.AddOptions(list);
	}

	public void AddShape(string type)
	{
		AddShape(type, BoneDropdown.options[BoneDropdown.value].text);
	}

	public void AddShape(string type, string parent)
	{
		if (type == "Cube")
		{
			AddShape(PrimitiveType.Cube, parent);
		}
	}

	private void AddShape(PrimitiveType type, string parent)
	{
		GameObject gameObject = GameObject.CreatePrimitive(type);
		gameObject.GetComponent<MeshRenderer>().material = baseMaterial;
		if (parent != null)
		{
			gameObject.transform.SetParent(GetBone(parent).transform);
		}
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
		gameObject.layer = 8;
		gameObject.tag = "Selectable";
		OCCreatorObject value = new OCCreatorObject(type, parent);
		objects.Add(gameObject, value);
		SelectObject(gameObject);
	}

	private GameObject GetBone(string name)
	{
		foreach (RigBone bone in bones)
		{
			if (bone.BoneName == name)
			{
				return bone.Bone;
			}
		}
		return null;
	}

	public void RemoveObject(GameObject go)
	{
		objects.Remove(go);
		Object.Destroy(go);
		DeselectObjects();
	}

	public void RemoveObject()
	{
		if (selectedObject != null)
		{
			objects.Remove(selectedObject);
			Object.Destroy(selectedObject);
			selectedObject = null;
			DeselectObjects();
		}
	}

	public void SelectObject(GameObject go)
	{
		if (objects.ContainsKey(go))
		{
			SelectedUI.SetActive(value: true);
			DeselectedUI.SetActive(value: false);
			selectedObject = go;
			SetHighlight(go, highlight: true);
			selectionHandler.ForceSelection(go.transform);
		}
	}

	public void DeselectObjects()
	{
		SelectedUI.SetActive(value: false);
		DeselectedUI.SetActive(value: true);
		selectionHandler.ForceDeselect();
		if (selectedObject != null)
		{
			SetHighlight(selectedObject, highlight: false);
		}
		selectedObject = null;
	}

	public void SetColor(Color setColor)
	{
		if (selectedObject != null)
		{
			objects[selectedObject].color = setColor;
		}
	}

	public void SetHighlight(GameObject go, bool highlight)
	{
	}

	public void SetPosition(string axis, float value)
	{
		switch (axis)
		{
		case "X":
			cameraMover.position = new Vector3(value, cameraMover.position.y, cameraMover.position.z);
			break;
		case "Y":
			cameraMover.position = new Vector3(cameraMover.position.x, value, cameraMover.position.z);
			break;
		case "Z":
			cameraMover.position = new Vector3(cameraMover.position.x, cameraMover.position.y, value);
			break;
		}
	}

	public void SetRotation(float value)
	{
		base.transform.localEulerAngles = new Vector3(0f, value, 0f);
	}

	public static float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
	{
		float num = from - fromMin;
		float num2 = fromMax - fromMin;
		float num3 = num / num2;
		return (toMax - toMin) * num3 + toMin;
	}

	private void UpdateModeButtons(Mode mode)
	{
		switch (mode)
		{
		case Mode.Position:
			positionButton.interactable = false;
			rotationButton.interactable = true;
			scaleButton.interactable = true;
			break;
		case Mode.Rotation:
			positionButton.interactable = true;
			rotationButton.interactable = false;
			scaleButton.interactable = true;
			break;
		case Mode.Scale:
			positionButton.interactable = true;
			rotationButton.interactable = true;
			scaleButton.interactable = false;
			break;
		}
	}

	public void PositionButtonPressed()
	{
		UpdateModeButtons(Mode.Position);
		selectionHandler.SetHandleType(HandleType.POSITION);
	}

	public void RotationButtonPressed()
	{
		UpdateModeButtons(Mode.Rotation);
		selectionHandler.SetHandleType(HandleType.ROTATION);
	}

	public void ScaleButtonPressed()
	{
		UpdateModeButtons(Mode.Scale);
		selectionHandler.SetHandleType(HandleType.SCALE);
	}

	public void XSliderChanged()
	{
		switch (currentMode)
		{
		case Mode.Position:
			SetPosition("X", XSlider.value);
			break;
		case Mode.Rotation:
		case Mode.Scale:
			break;
		}
	}

	public void YSliderChanged()
	{
		switch (currentMode)
		{
		case Mode.Position:
			SetPosition("Y", YSlider.value);
			break;
		case Mode.Rotation:
		case Mode.Scale:
			break;
		}
	}

	public void ZSliderChanged()
	{
		switch (currentMode)
		{
		case Mode.Position:
			SetPosition("Z", ZSlider.value);
			break;
		case Mode.Rotation:
		case Mode.Scale:
			break;
		}
	}

	public void RotationSliderChanged()
	{
		SetRotation(RotationSlider.value);
	}

	private void UpdateSliderValues(GameObject go)
	{
		if (go == null)
		{
			XSlider.value = 0f;
			YSlider.value = 0f;
			ZSlider.value = 0f;
		}
		else if (currentMode == Mode.Position)
		{
			XSlider.value = go.transform.localPosition.x;
			YSlider.value = go.transform.localPosition.y;
			ZSlider.value = go.transform.localPosition.z;
		}
	}

	public void HideHideableMesh()
	{
		if (hideableMesh.activeSelf)
		{
			hideableMesh.SetActive(value: false);
			hideMeshButtonText.text = "Unhide\nMesh";
		}
		else
		{
			hideableMesh.SetActive(value: true);
			hideMeshButtonText.text = "Hide\nMesh";
		}
	}
}
