using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomNightUIView : MonoBehaviour
{
	[Header("Custom Night Controller")]
	[SerializeField]
	private CustomNightController controller;

	[Header("Begin Button")]
	[SerializeField]
	private Button beginButton;

	[Header("Animatronic Value Selector Cell Prefab")]
	[SerializeField]
	private CustomNightCell customNightCell;

	[Header("UI Hookups")]
	[SerializeField]
	private Transform cellParent;

	[SerializeField]
	private GameObject selectorCanvas;

	private MasterDataConnector masterDataConnector;

	public List<CustomNightAnimatronic> customNightAnimatronics;

	private void Start()
	{
		customNightAnimatronics = new List<CustomNightAnimatronic>();
		beginButton.onClick.AddListener(BeginCustomNight);
		selectorCanvas.SetActive(value: true);
		CreateSelectorCells();
	}

	private void BeginCustomNight()
	{
		selectorCanvas.SetActive(value: false);
		controller.Begin(customNightAnimatronics);
	}

	public void CreateSelectorCells()
	{
		CustomNightAnimatronic customNightAnimatronic = new CustomNightAnimatronic
		{
			Id = "Freddy",
			Bundle = "animatronics_freddy",
			Prefab = "FreddyPrefab",
			PortraitImageName = "alpine_ui_portrait_freddy",
			InitialAIValue = 0,
			originRoom = CustomNightAnimatronic.CustomNightRooms.Stage,
			EastPath = true,
			ThreeAMValueBoost = 1,
			pushbackRoom = CustomNightAnimatronic.CustomNightRooms.EastHall
		};
		customNightAnimatronics.Add(customNightAnimatronic);
		Object.Instantiate(customNightCell, cellParent).SetData(customNightAnimatronic);
		CustomNightAnimatronic customNightAnimatronic2 = new CustomNightAnimatronic
		{
			Id = "Bonnie",
			Bundle = "animatronics_bonnie",
			Prefab = "BonniePrefab",
			PortraitImageName = "alpine_ui_portrait_bonnie",
			InitialAIValue = 0,
			originRoom = CustomNightAnimatronic.CustomNightRooms.Stage,
			EastPath = false,
			ThreeAMValueBoost = 2,
			pushbackRoom = CustomNightAnimatronic.CustomNightRooms.DiningAreaWest
		};
		customNightAnimatronics.Add(customNightAnimatronic2);
		Object.Instantiate(customNightCell, cellParent).SetData(customNightAnimatronic2);
		CustomNightAnimatronic customNightAnimatronic3 = new CustomNightAnimatronic
		{
			Id = "Chica",
			Bundle = "animatronics_bareendo",
			Prefab = "BareEndoPrefab",
			PortraitImageName = "alpine_ui_portrait_bareendo",
			InitialAIValue = 0,
			originRoom = CustomNightAnimatronic.CustomNightRooms.Stage,
			EastPath = true,
			ThreeAMValueBoost = 2,
			pushbackRoom = CustomNightAnimatronic.CustomNightRooms.DiningAreaEast
		};
		customNightAnimatronics.Add(customNightAnimatronic3);
		Object.Instantiate(customNightCell, cellParent).SetData(customNightAnimatronic3);
		CustomNightAnimatronic customNightAnimatronic4 = new CustomNightAnimatronic
		{
			Id = "Foxy",
			Bundle = "animatronics_springtrap",
			Prefab = "SpringtrapPrefab",
			PortraitImageName = "alpine_ui_portrait_springtrap",
			InitialAIValue = 0,
			originRoom = CustomNightAnimatronic.CustomNightRooms.PirateCove,
			EastPath = false,
			ThreeAMValueBoost = 4,
			CanGoCloset = false,
			CanGoBackstage = false,
			pushbackRoom = CustomNightAnimatronic.CustomNightRooms.PirateCove
		};
		customNightAnimatronics.Add(customNightAnimatronic4);
		Object.Instantiate(customNightCell, cellParent).SetData(customNightAnimatronic4);
	}
}
