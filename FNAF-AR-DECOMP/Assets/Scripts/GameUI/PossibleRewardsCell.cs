using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PossibleRewardsCell : MonoBehaviour, ICellInterface<GameUI.PossibleRewardsCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _number;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _image;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.PossibleRewardsCellData data)
        {
            this._title.text = data.name;
            this._number.gameObject.SetActive(value:  (data.quantity > 1) ? 1 : 0);
            if(data.quantity < 2)
            {
                    return;
            }
            
            this._number.text = data + 16.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this._image.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PossibleRewardsCell()
        {
        
        }
    
    }

}
