using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CPUCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI userNameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject highlightObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.CPUCell.CPUCellData cpuCellData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.CPUCell.CPUCellData data)
        {
            string val_7;
            this.cpuCellData = data;
            val_7 = data.serverData.AnimatronicName;
            this.userNameText.text = val_7;
            if(this.cpuCellData.SelectFunction != null)
            {
                    UnityEngine.Events.UnityAction val_3 = null;
                val_7 = val_3;
                val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.CPUCell::<SetData>b__6_0());
                this.button.onClick.AddListener(call:  val_3);
            }
            
            this.button.interactable = (this.cpuCellData.playerOwned == true) ? 1 : 0;
            this.userNameText.gameObject.SetActive(value:  (this.cpuCellData.playerOwned == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetIconName()
        {
            UnityEngine.Sprite val_1 = this.image.overrideSprite;
            if(val_1 == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            if(val_1 != null)
            {
                    return val_1.name;
            }
            
            return val_1.name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIcon(UnityEngine.Sprite icon)
        {
            if(this.image.overrideSprite == icon)
            {
                    return;
            }
            
            this.image.overrideSprite = icon;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetSelected(bool value)
        {
            if(this.highlightObject == 0)
            {
                    return;
            }
            
            this.highlightObject.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CPUCell()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <SetData>b__6_0()
        {
            this.cpuCellData.SelectFunction.Invoke(arg1:  this, arg2:  false);
        }
    
    }

}
