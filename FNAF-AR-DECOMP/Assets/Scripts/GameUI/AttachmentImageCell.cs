using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AttachmentImageCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI tapToExpandText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void SetData(UnityEngine.Sprite sprite, string tapToExpandString, System.Action<UnityEngine.Sprite> TapToExpandImage)
        {
            AttachmentImageCell.<>c__DisplayClass3_0 val_1 = new AttachmentImageCell.<>c__DisplayClass3_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .TapToExpandImage = TapToExpandImage;
            .sprite = sprite;
            if(this.image != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            this.image.overrideSprite = sprite;
            this.tapToExpandText.text = tapToExpandString;
            this.button.onClick.RemoveAllListeners();
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void AttachmentImageCell.<>c__DisplayClass3_0::<SetData>b__0()));
            return;
            label_1:
            mem[16] = TapToExpandImage;
            mem[24] = sprite;
            if(this.image != null)
            {
                goto label_8;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttachmentImageCell()
        {
        
        }
    
    }

}
