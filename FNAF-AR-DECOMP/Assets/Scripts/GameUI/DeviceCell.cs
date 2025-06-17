using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI nameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI descriptionText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI numOwnedText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject numParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image lureSubimage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject lureImageParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject deactivatePanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button deactivateButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.DeviceData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numOwned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onClicked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _onDeactivateClicked;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.DeviceData Data { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumOwned { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.DeviceData get_Data()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.DeviceData)this._data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumOwned()
        {
            return (int)this._numOwned;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDeactiveButtonClicked()
        {
            if(this._onDeactivateClicked == null)
            {
                    return;
            }
            
            this._onDeactivateClicked.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnButtonClicked()
        {
            if(this._onClicked == null)
            {
                    return;
            }
            
            this._onClicked.Invoke(obj:  this._data.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(Game.ItemDefinition.Data.DataDefinitions.DeviceData data, int num, UnityEngine.Sprite icon, UnityEngine.Sprite subicon, System.Action<string> onClicked, bool shouldHaveCancelPanel, System.Action onDeactivateClicked)
        {
            var val_2;
            this._numOwned = num;
            this._data = data;
            this._onClicked = onClicked;
            this._onDeactivateClicked = onDeactivateClicked;
            this.image.overrideSprite = icon;
            this.lureSubimage.overrideSprite = subicon;
            UnityEngine.Object val_2 = 0;
            val_2 = UnityEngine.Object.op_Inequality(x:  subicon, y:  val_2);
            this.lureImageParent.SetActive(value:  val_2);
            if((onClicked != null) && (data.Type != 6))
            {
                    if(data.Type != 1)
            {
                goto label_9;
            }
            
            }
            
            this.button.interactable = false;
            label_9:
            if((shouldHaveCancelPanel != false) && (data.Type == 5))
            {
                    this.deactivatePanel.SetActive(value:  true);
                val_2 = 1;
            }
            else
            {
                    this.deactivatePanel.SetActive(value:  false);
                val_2 = 0;
            }
            
            this.deactivateButton.interactable = false;
            this.UpdateTextDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTextDisplay()
        {
            this.nameText.text = this._data.Name;
            this.descriptionText.text = this._data.Description;
            this.numOwnedText.text = this._numOwned.ToString();
            this.numParent.SetActive(value:  (this._numOwned != 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Decrement()
        {
            int val_2 = this._numOwned;
            val_2 = val_2 - 1;
            this._numOwned = val_2;
            this.numOwnedText.text = this._numOwned.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DeviceCell::OnButtonClicked()));
            this.deactivateButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DeviceCell::OnDeactiveButtonClicked()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DeviceCell::OnButtonClicked()));
            this.deactivateButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DeviceCell::OnDeactiveButtonClicked()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceCell()
        {
        
        }
    
    }

}
