using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModCell : MonoBehaviour, ICellInterface<GameUI.ModSelectionCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI nameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI descriptionText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI sellText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button modCell;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button closeDescPanelButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button equipModButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button unequipModButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button sellButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StarDisplay stars;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle highlightToggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject inUseParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject availableParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI quantityText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject descriptionPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject categoryInUseDescription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI categoryTextAvailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI categoryTextUnavailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI categoryTextEquipped;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModSelectionCellData modCellPayload;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.Actions.GatherModsForEquipping.ModContext modContext { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.Actions.GatherModsForEquipping.ModContext get_modContext()
        {
            if(this.modCellPayload != null)
            {
                    return (ModContext)this.modCellPayload.context;
            }
            
            return (ModContext)this.modCellPayload.context;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetText()
        {
            this.nameText.text = this.modCellPayload.context.Mod.Name;
            this.descriptionText.text = this.modCellPayload.context.Mod.Description;
            this.sellText.text = this.modCellPayload.context.Mod.PartsBuyback.ToString(format:  "n0");
            this.quantityText.text = this.modCellPayload.context.quantity.ToString(format:  "n0");
            this.categoryTextAvailable.text = this.modCellPayload.context.Mod.CategoryStringLocalized;
            this.categoryTextUnavailable.text = this.modCellPayload.context.Mod.CategoryStringLocalized;
            this.categoryTextEquipped.text = this.modCellPayload.context.Mod.CategoryStringLocalized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SelectThisModCell()
        {
            if(this.modCellPayload == null)
            {
                    return;
            }
            
            this.modCellPayload.SelectModCell.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisplaySellThisDialog()
        {
            if(this.modCellPayload == null)
            {
                    return;
            }
            
            this.modCellPayload.DisplaySellDialog.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddCallbacks()
        {
            this.equipModButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::SelectThisModCell()));
            this.equipModButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::SelectThisModCell()));
            this.unequipModButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::SelectThisModCell()));
            this.unequipModButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::SelectThisModCell()));
            this.sellButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::DisplaySellThisDialog()));
            this.sellButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.ModCell::DisplaySellThisDialog()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCellState()
        {
            var val_8;
            if(this.modCellPayload.context.isEquipped != false)
            {
                    var val_1 = (this.modCellPayload.context.quantity < 2) ? 1 : 0;
            }
            else
            {
                    val_8 = 0;
            }
            
            this.sellButton.gameObject.SetActive(value:  (this.modCellPayload.context.modSellable == true) ? 1 : 0);
            this.sellButton.interactable = (val_8 == 0) ? 1 : 0;
            this.categoryInUseDescription.SetActive(value:  (this.modCellPayload.context.modEquippable == false) ? 1 : 0);
            this.availableParent.SetActive(value:  (this.modCellPayload.context.modEquippable == true) ? 1 : 0);
            this.inUseParent.SetActive(value:  (this.modCellPayload.context.modEquippable == false) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelected(bool value)
        {
            value = value;
            this.highlightToggle.SetHighlightAndOtherCellsHighlightState(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.ModSelectionCellData payload)
        {
            this.modCellPayload = payload;
            this.AddCallbacks();
            this.SetText();
            this.UpdateCellState();
            this.stars.SetStars(numStars:  this.modCellPayload.context.Mod.Stars);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite icon)
        {
            this.image.overrideSprite = icon;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDescriptionPanel()
        {
            this.descriptionPanel.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideDescriptionPanel()
        {
            this.descriptionPanel.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.modCell.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.ModCell::ShowDescriptionPanel()));
            this.closeDescPanelButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void GameUI.ModCell::HideDescriptionPanel()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.HideDescriptionPanel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModCell()
        {
        
        }
    
    }

}
