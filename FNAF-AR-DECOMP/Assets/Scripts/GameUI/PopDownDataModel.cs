using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PopDownDataModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.PopDownData popDownData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.FeatureFlags.FeatureFlagMap <featureFlagMap>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.FeatureFlags.FeatureFlagMap featureFlagMap { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_featureFlagMap(Systems.Guide.FeatureFlags.FeatureFlagMap value)
        {
            this.<featureFlagMap>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.FeatureFlags.FeatureFlagMap get_featureFlagMap()
        {
            return (Systems.Guide.FeatureFlags.FeatureFlagMap)this.<featureFlagMap>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PopDownDataModel(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void GameUI.PopDownDataModel::EventExposer_FeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_FeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap obj)
        {
            this.<featureFlagMap>k__BackingField = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPopDownDataFromAlertEntry(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            var val_13;
            PopDownDataModel.<>c__DisplayClass8_0 val_1 = new PopDownDataModel.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    val_13 = val_1;
                .alertEntry = alertEntry;
                mem[1152921524887151328] = this;
            }
            else
            {
                    mem[16] = this;
                val_13 = 24;
                mem[24] = alertEntry;
            }
            
            .animatronicId = 0;
            if((this._masterDomain.alertsDomain.LastKnownAnimatronicPerAlert.ContainsAlert(alertId:  val_13.Logical)) != false)
            {
                    .animatronicId = this._masterDomain.alertsDomain.LastKnownAnimatronicPerAlert.GetPlushSuitIdForAlertId(alertId:  mem[24].Logical);
            }
            
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void PopDownDataModel.<>c__DisplayClass8_0::<SetPopDownDataFromAlertEntry>b__0(Game.Localization.ILocalization iLocalization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalizationCallback(Game.Localization.ILocalization iLocalization, ProtoData.ALERT_DATA.Types.ENTRY alertEntry, string animatronicId)
        {
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_6 = iLocalization.GetLocalizedString(localizedStringId:  alertEntry.EventBody.DisplayTextBody, originalString:  alertEntry.EventBody.DisplayTextBody);
            GameUI.PopDownData val_7 = null;
            .showTime = 5f;
            val_7 = new GameUI.PopDownData();
            UIDISPLAYRESTRICTION val_9 = alertEntry.UI.UIDisplayRestriction;
            if(val_7 != null)
            {
                    .uIDISPLAYRESTRICTION = val_9;
                .message = val_6;
            }
            else
            {
                    mem[16] = val_9;
                mem[32] = val_6;
            }
            
            .senderId = animatronicId;
            this.popDownData = val_7;
        }
    
    }

}
