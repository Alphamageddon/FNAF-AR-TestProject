using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceSliderData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI essenceTotalText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI sliderValueText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Slider essenceSlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI essenceCurrentText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button addButton;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceSliderData()
        {
        
        }
    
    }

}
