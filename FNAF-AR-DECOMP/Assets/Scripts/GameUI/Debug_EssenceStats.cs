using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Debug_EssenceStats
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject debug_EssenceStatsParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text debug_EssenceText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text debug_ThreatText;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Debug_EssenceStats(Master.MasterDomain masterDomain, UnityEngine.GameObject debug_EssenceStatsParent, UnityEngine.UI.Text debug_EssenceText, UnityEngine.UI.Text debug_ThreatText)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this.debug_EssenceStatsParent = val_1;
            this.debug_EssenceText = debug_EssenceText;
            this.debug_ThreatText = debug_ThreatText;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateStatsText()
        {
            float val_2 = this._masterDomain.essenceCollectionDomain.ThreatPercent;
            val_2 = val_2 * 100f;
            string val_3 = this._masterDomain.essenceCollectionDomain.AmountOfEssence.ToString();
            string val_4 = (int)val_2.ToString();
            if(this.debug_ThreatText != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.debug_EssenceStatsParent.SetActive(value:  false);
        }
    
    }

}
