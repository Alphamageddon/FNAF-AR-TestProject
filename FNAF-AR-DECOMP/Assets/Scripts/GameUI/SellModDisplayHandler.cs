using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SellModDisplayHandler : MonoBehaviour, ICellInterface<GameUI.ModCell>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI titleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI messageText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StarDisplay stars;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SELL_PREFIX_TEXT = "ui_workshop_modify_dialogs_sellprefix";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SELL_POSTFIX_TEXT = "ui_workshop_modify_dialogs_sellpostfix";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.ModCell modCell)
        {
            SellModDisplayHandler.<>c__DisplayClass6_0 val_1 = new SellModDisplayHandler.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .modCell = modCell;
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void SellModDisplayHandler.<>c__DisplayClass6_0::<SetData>b__0(Game.Localization.ILocalization localization)));
            ModContext val_5 = (SellModDisplayHandler.<>c__DisplayClass6_0)[1152921524853687072].modCell.modContext;
            this.messageText.text = val_5.Mod.Name;
            ModContext val_6 = (SellModDisplayHandler.<>c__DisplayClass6_0)[1152921524853687072].modCell.modContext;
            this.stars.SetStars(numStars:  val_6.Mod.Stars);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            if(this.icon == 0)
            {
                    return;
            }
            
            this.icon.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SellModDisplayHandler()
        {
        
        }
    
    }

}
