using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceSliderHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TEXT_FORMAT = "n0";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EssenceSliderData _essenceSliderData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceSliderHandler(GameUI.EssenceSliderData essenceSliderData)
        {
            this._essenceSliderData = essenceSliderData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetSliderValue()
        {
            return UnityEngine.Mathf.RoundToInt(f:  V0.16B);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEssenceValueFromSliderValue()
        {
            int val_1 = this.GetSliderValue();
            if(val_1 < 1)
            {
                    return;
            }
            
            this.AddEssenceValue(value:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEssenceValue(int value)
        {
            var val_8;
            int val_9;
            GameUI.WorkshopSlotData val_1 = this._essenceSliderData.workshopSlotDataModel.GetSelectedSlotData();
            val_8 = val_1.ClientEndoskeleton;
            if(val_8 != null)
            {
                    val_9 = val_2.numEssence;
            }
            else
            {
                    val_8 = 32;
                val_9 = 64;
            }
            
            mem[32] = val_9 + value;
            if(val_1 != null)
            {
                    val_1.UpdateIsDirty();
            }
            else
            {
                    0.UpdateIsDirty();
            }
            
            val_1.Save();
            this._essenceSliderData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.SpendEssence(amount:  value);
            this._essenceSliderData.masterDomain.serverDomain.endoskeletonConfigRequester.SetEndoskeletonConfig(slot:  this._essenceSliderData.workshopSlotDataModel.GetSelectedSlotDataIndex(), endoskeleton:  val_1.ClientEndoskeleton);
            this.InitializeSliderDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSliderDisplay()
        {
            this._essenceSliderData.sliderValueText.text = this.GetSliderValue().ToString(format:  "n0");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateSliderDisplay();
            this.UpdateAddButtonEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAddButtonEnable()
        {
            if(this._essenceSliderData != null)
            {
                goto label_0;
            }
            
            this._essenceSliderData = this._essenceSliderData;
            if(this._essenceSliderData == null)
            {
                goto label_1;
            }
            
            label_0:
            this._essenceSliderData.addButton.interactable = (this._essenceSliderData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence != 0) ? 1 : 0;
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitializeSliderDisplay()
        {
            GameUI.EssenceSliderData val_11;
            GameUI.EssenceSliderData val_12;
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = this._essenceSliderData.workshopSlotDataModel.GetSelectedSlotData().ClientEndoskeleton;
            this._essenceSliderData.essenceCurrentText.text = val_2.numEssence.ToString(format:  "n0");
            val_11 = this._essenceSliderData;
            if(this._essenceSliderData != null)
            {
                goto label_7;
            }
            
            val_11 = this._essenceSliderData;
            if(val_11 == null)
            {
                goto label_15;
            }
            
            label_7:
            this._essenceSliderData.essenceTotalText.text = this._essenceSliderData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence.ToString(format:  "n0");
            val_12 = this._essenceSliderData;
            if(this._essenceSliderData != null)
            {
                goto label_14;
            }
            
            val_12 = this._essenceSliderData;
            if(val_12 == null)
            {
                goto label_15;
            }
            
            label_14:
            this._essenceSliderData.essenceSlider.maxValue = (float)this._essenceSliderData.masterDomain.WorkshopDomain.Inventory.CurrencyContainer.Essence;
            this.UpdateSliderDisplay();
            this.UpdateAddButtonEnable();
            return;
            label_15:
        }
    
    }

}
