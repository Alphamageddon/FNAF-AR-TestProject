using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModCell : MonoBehaviour, ICellInterface<ModSelectionCellData>
{
	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private TextMeshProUGUI sellText;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Button modCell;

	[SerializeField]
	private Button equipModButton;

	[SerializeField]
	private Button unequipModButton;

	[SerializeField]
	private Button sellButton;

	[SerializeField]
	private StarDisplay stars;

	[SerializeField]
	private HighlightToggle highlightToggle;

	[SerializeField]
	private GameObject inUseParent;

	[SerializeField]
	private GameObject availableParent;

	[SerializeField]
	private TextMeshProUGUI quantityText;

	[SerializeField]
	private GameObject descriptionPanel;

	[SerializeField]
	private GameObject categoryInUseDescription;

	[SerializeField]
	private TextMeshProUGUI categoryTextAvailable;

	[SerializeField]
	private TextMeshProUGUI categoryTextUnavailable;

	[SerializeField]
	private TextMeshProUGUI categoryTextEquipped;

	private ModSelectionCellData modCellPayload;

	public GatherModsForEquipping.ModContext modContext
	{
		get
		{
			if (modCellPayload != null)
			{
				return modCellPayload.context;
			}
			return null;
		}
	}

	private void SetText()
	{
		nameText.text = modCellPayload.context.Mod.Name;
		descriptionText.text = modCellPayload.context.Mod.Description;
		sellText.text = modCellPayload.context.Mod.PartsBuyback.ToString("n0");
		quantityText.text = modCellPayload.context.quantity.ToString("n0");
		categoryTextAvailable.text = modCellPayload.context.Mod.CategoryStringLocalized;
		categoryTextUnavailable.text = modCellPayload.context.Mod.CategoryStringLocalized;
		categoryTextEquipped.text = modCellPayload.context.Mod.CategoryStringLocalized;
	}

	private void SelectThisModCell()
	{
		if (modCellPayload != null)
		{
			modCellPayload.SelectModCell(this);
		}
	}

	private void DisplaySellThisDialog()
	{
		if (modCellPayload != null)
		{
			modCellPayload.DisplaySellDialog(this);
		}
	}

	private void AddCallbacks()
	{
		equipModButton.onClick.RemoveListener(SelectThisModCell);
		equipModButton.onClick.AddListener(SelectThisModCell);
		unequipModButton.onClick.RemoveListener(SelectThisModCell);
		unequipModButton.onClick.AddListener(SelectThisModCell);
		sellButton.onClick.RemoveListener(DisplaySellThisDialog);
		sellButton.onClick.AddListener(DisplaySellThisDialog);
	}

	private void UpdateCellState()
	{
		sellButton.gameObject.SetActive(modCellPayload.context.modSellable);
		sellButton.interactable = !modCellPayload.context.isEquipped;
		categoryInUseDescription.SetActive(!modCellPayload.context.modEquippable);
		availableParent.SetActive(modCellPayload.context.modEquippable);
		inUseParent.SetActive(!modCellPayload.context.modEquippable);
	}

	public void SetSelected(bool value)
	{
		highlightToggle.SetHighlightAndOtherCellsHighlightState(value);
	}

	public void SetData(ModSelectionCellData payload)
	{
		modCellPayload = payload;
		AddCallbacks();
		SetText();
		UpdateCellState();
		stars.SetStars(modCellPayload.context.Mod.Stars);
	}

	public void SetSprite(Sprite icon)
	{
		image.overrideSprite = icon;
	}
}
