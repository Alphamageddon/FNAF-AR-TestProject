using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ButtonConfigs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string BUTTON_BACK_TO_MAP = "backToMap";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<object>> _buttonDisableReferences;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnFabButtonConfigurationChangeEvent(string buttonName, bool desiredState, object requestingEntity)
        {
            System.Collections.Generic.List<System.Object> val_1 = this._buttonDisableReferences.Item[buttonName];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(desiredState == false)
            {
                goto label_3;
            }
            
            label_4:
            bool val_2 = val_1.Remove(item:  requestingEntity);
            return;
            label_2:
            if(desiredState == true)
            {
                goto label_4;
            }
            
            label_3:
            if((val_1.Contains(item:  requestingEntity)) != false)
            {
                    return;
            }
            
            val_1.Add(item:  requestingEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsButtonEnabled(string buttonName)
        {
            return (bool)(this._buttonDisableReferences.Item[buttonName].Count == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ButtonConfigs(Master.MasterDomain masterDomain)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Object>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Object>>();
            val_1.Add(key:  "backToMap", value:  new System.Collections.Generic.List<System.Object>());
            this._buttonDisableReferences = val_1;
            masterDomain.eventExposer.add_FabButtonConfigurationChangeEvent(value:  new EventExposer.FabButtonChangeHandler(object:  this, method:  System.Void GameUI.ButtonConfigs::EventExposer_OnFabButtonConfigurationChangeEvent(string buttonName, bool desiredState, object requestingEntity)));
        }
    
    }

}
