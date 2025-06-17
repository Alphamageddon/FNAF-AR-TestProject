using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlushSuitCell : MonoBehaviour
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
        public GameUI.PlushSuitCell.PlushSuitCellData plushSuitCellData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.PlushSuitCell.PlushSuitCellData plushSuitCellData)
        {
            var val_8;
            var val_9;
            TMPro.TextMeshProUGUI val_10;
            PlushSuitCell.<>c__DisplayClass6_0 val_1 = new PlushSuitCell.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .plushSuitCellData = plushSuitCellData;
                mem[1152921524742305096] = this;
                val_9 = this;
                val_10 = this.userNameText;
                mem[1152921524742269032] = plushSuitCellData;
            }
            else
            {
                    val_8 = 16;
                mem[16] = plushSuitCellData;
                mem[24] = this;
                val_9 = this;
                val_10 = this.userNameText;
                mem[1152921524742269032] = mem[16];
            }
            
            val_10.text = plushSuitCellData + 16.AnimatronicName;
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void PlushSuitCell.<>c__DisplayClass6_0::<SetData>b__0()));
            this.button.interactable = ((plushSuitCellData + 32) != 0) ? 1 : 0;
            val_10.gameObject.SetActive(value:  ((plushSuitCellData + 32) != 0) ? 1 : 0);
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
        internal void SetSelected(bool v)
        {
            if(this.highlightObject == 0)
            {
                    return;
            }
            
            this.highlightObject.SetActive(value:  v);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetSelectable(bool value)
        {
            var val_2;
            if(value != false)
            {
                    var val_1 = (this.plushSuitCellData.playerOwned == true) ? 1 : 0;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.button.interactable = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlushSuitCell()
        {
        
        }
    
    }

}
