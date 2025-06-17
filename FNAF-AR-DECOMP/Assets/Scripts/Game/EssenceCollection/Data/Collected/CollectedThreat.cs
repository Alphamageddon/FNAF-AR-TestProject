using UnityEngine;

namespace Game.EssenceCollection.Data.Collected
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CollectedThreat
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string _threatLevelKey = "EssenceCollectionThreatLevel";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _deltaToTriggerSave = 0.05;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _percent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastSavedPercent;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Percent { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Percent()
        {
            return (float)this._percent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CollectedThreat(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector)
        {
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            float val_1 = UnityEngine.PlayerPrefs.GetFloat(key:  "EssenceCollectionThreatLevel", defaultValue:  0f);
            this._percent = val_1;
            this._lastSavedPercent = val_1;
            this.EnsureThreatIsInBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddThreat(int newThreatPills)
        {
            float val_1 = this.<_masterDataConnector>k__BackingField.ThreatCollection_ThreatPercentPerThreatPill;
            val_1 = val_1 * (float)newThreatPills;
            val_1 = this._percent + val_1;
            this._percent = val_1;
            this.EnsureThreatIsInBounds();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearThreat()
        {
            this._percent = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureThreatIsInBounds()
        {
            this._percent = UnityEngine.Mathf.Clamp(value:  this._percent, min:  0f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSaveThreat()
        {
            if((System.Math.Abs(this._percent - this._lastSavedPercent)) < 0.05f)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetFloat(key:  "EssenceCollectionThreatLevel", value:  this._percent);
            this._lastSavedPercent = this._percent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(float deltaTime)
        {
            float val_1 = this.<_masterDataConnector>k__BackingField.ThreatCollection_DropPerSecond;
            val_1 = val_1 * deltaTime;
            val_1 = this._percent - val_1;
            this._percent = val_1;
            this.EnsureThreatIsInBounds();
            this.UpdateSaveThreat();
        }
    
    }

}
