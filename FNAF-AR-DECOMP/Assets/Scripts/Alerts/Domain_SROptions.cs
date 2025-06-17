using UnityEngine;

namespace Alerts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MapEvalSpeedup { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseDateOverride { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int OverrideMonth { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int OverrideDay { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int OverrideYear { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LogicalId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Domain_SROptions()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain_SROptions(Alerts.Domain domain)
        {
            this._domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForceNextEvaluation()
        {
            this._domain.<PassiveTriggers>k__BackingField._nextCheckTimestamp = UnityEngine.Time.time;
            this._domain.<AnimatronicTriggers>k__BackingField._nextCheckTimestamp = UnityEngine.Time.time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MapEvalSpeedup()
        {
            return (float)(this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MapEvalSpeedup(float value)
        {
            this._domain._debugAlertEvalSpeedup = value;
            this._domain.<PassiveTriggers>k__BackingField.ResetNextCheckTimestamp(needsCooldown:  false);
            this._domain.<AnimatronicTriggers>k__BackingField.ResetNextCheckTimestamp(needsCooldown:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_UseDateOverride()
        {
            if(this._domain != null)
            {
                    return (bool)this._domain.<Debug_UseDateOverride>k__BackingField;
            }
            
            return (bool)this._domain.<Debug_UseDateOverride>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_UseDateOverride(bool value)
        {
            this._domain.<Debug_UseDateOverride>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_OverrideMonth()
        {
            if(this._domain != null)
            {
                    return (int)this._domain.<Debug_DateOverrideMonth>k__BackingField;
            }
            
            return (int)this._domain.<Debug_DateOverrideMonth>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OverrideMonth(int value)
        {
            this._domain.<Debug_DateOverrideMonth>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_OverrideDay()
        {
            if(this._domain != null)
            {
                    return (int)this._domain.<Debug_DateOverrideDay>k__BackingField;
            }
            
            return (int)this._domain.<Debug_DateOverrideDay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OverrideDay(int value)
        {
            this._domain.<Debug_DateOverrideDay>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_OverrideYear()
        {
            if(this._domain != null)
            {
                    return (int)this._domain.<Debug_DateOverrideYear>k__BackingField;
            }
            
            return (int)this._domain.<Debug_DateOverrideYear>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OverrideYear(int value)
        {
            this._domain.<Debug_DateOverrideYear>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_LogicalId()
        {
            if(this._domain != null)
            {
                    return (string)this._domain.<Debug_LogicalId>k__BackingField;
            }
            
            return (string)this._domain.<Debug_LogicalId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LogicalId(string value)
        {
            this._domain.<Debug_LogicalId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerThisLogicalId()
        {
            this._domain.Debug_TriggerThisLogicalId();
        }
    
    }

}
