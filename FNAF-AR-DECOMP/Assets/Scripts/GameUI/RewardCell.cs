using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardCell : MonoBehaviour, ICellInterface<GameUI.ItemUIDescription>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI titleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject numBg;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI numText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> stars;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this.icon.sprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.ItemUIDescription itemUiDescription)
        {
            var val_9;
            string val_10;
            val_9 = itemUiDescription;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if(this.titleText != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.titleText.text = itemUiDescription.typeName;
            if(val_9 == null)
            {
                goto label_3;
            }
            
            val_10 = itemUiDescription.number.ToString();
            goto label_4;
            label_1:
            if(this.titleText != null)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_10 = 0;
            label_4:
            this.numText.text = "x" + val_10;
            List.Enumerator<T> val_3 = this.stars.GetEnumerator();
            label_13:
            if(((-1338099736) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
            val_4.SetActive(value:  ((this.stars.IndexOf(item:  val_4)) < itemUiDescription.magnitude) ? 1 : 0);
            goto label_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideNumTextGroup()
        {
            if(this.numBg != 0)
            {
                    this.numBg.SetActive(value:  false);
            }
            
            if(this.numText == 0)
            {
                    return;
            }
            
            this.numText.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardCell()
        {
        
        }
    
    }

}
