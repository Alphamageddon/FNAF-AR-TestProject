using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AttachmentRewardCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image categoryIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI itemText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI quantityText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action selectCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetData(string rewardName, int amount, UnityEngine.Sprite categorySprite)
        {
            this.categoryIcon.overrideSprite = categorySprite;
            this.itemText.text = rewardName;
            this.quantityText.text = "x" + amount.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetNewSprite(UnityEngine.Sprite categorySprite)
        {
            this.categoryIcon.overrideSprite = categorySprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttachmentRewardCell()
        {
        
        }
    
    }

}
