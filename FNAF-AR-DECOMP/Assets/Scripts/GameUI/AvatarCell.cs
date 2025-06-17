using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AvatarCell : MonoBehaviour, ICellInterface<GameUI.AvatarCellDataPack>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image avatarImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button button;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.AvatarCellDataPack data)
        {
            .data = data;
            this.button.onClick.RemoveAllListeners();
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new AvatarCell.<>c__DisplayClass2_0(), method:  System.Void AvatarCell.<>c__DisplayClass2_0::<SetData>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this.avatarImage.sprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AvatarCell()
        {
        
        }
    
    }

}
