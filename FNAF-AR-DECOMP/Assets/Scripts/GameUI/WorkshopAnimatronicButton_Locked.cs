using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopAnimatronicButton_Locked : MonoBehaviour, IWorkshopSlotButton
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject selectedStateImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI streakUnlockNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI fazTokenPriceText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button thisButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.Data.StoreDisplayData _storeDisplayData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _displayNumber;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(int displayNumber, Game.Store.Data.StoreDisplayData data, System.Action<GameUI.WorkshopAnimatronicButton_Locked> buttonCallback)
        {
            WorkshopAnimatronicButton_Locked.<>c__DisplayClass6_0 val_1 = new WorkshopAnimatronicButton_Locked.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    .buttonCallback = buttonCallback;
            }
            else
            {
                    mem[16] = buttonCallback;
            }
            
            .<>4__this = this;
            this._displayNumber = displayNumber;
            string val_2 = displayNumber.ToString();
            if(data != null)
            {
                    this.SetDataForPurchase(price:  val_2, data:  data);
            }
            else
            {
                    this.SetDataForStreak(streak:  val_2);
            }
            
            this.thisButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void WorkshopAnimatronicButton_Locked.<>c__DisplayClass6_0::<Initialize>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataForStreak(string streak)
        {
            this.streakUnlockNumText.text = streak;
            this.streakUnlockNumText.transform.parent.gameObject.SetActive(value:  true);
            this.fazTokenPriceText.transform.parent.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDataForPurchase(string price, Game.Store.Data.StoreDisplayData data)
        {
            this._storeDisplayData = data;
            this.fazTokenPriceText.text = price;
            this.streakUnlockNumText.transform.parent.gameObject.SetActive(value:  false);
            this.fazTokenPriceText.transform.parent.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSelectedUI(bool value)
        {
            value = value;
            this.selectedStateImage.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSortWeight()
        {
            if(this._storeDisplayData == null)
            {
                    return (int)this._displayNumber + 20;
            }
            
            return 10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData GetStoreDisplayData()
        {
            return (Game.Store.Data.StoreDisplayData)this._storeDisplayData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotData GetWorkshopSlotData()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopAnimatronicButton_Locked()
        {
        
        }
    
    }

}
