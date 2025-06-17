using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SequentialRewardsDialog : MonoBehaviour, ICellInterface<GameUI.SequentialRewardsDialogData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _image;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.SequentialRewardsDialogData data)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this._image.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SequentialRewardsDialog()
        {
        
        }
    
    }

}
