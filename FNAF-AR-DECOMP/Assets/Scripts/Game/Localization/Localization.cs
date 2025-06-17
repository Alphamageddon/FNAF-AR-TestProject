using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Localization : AsyncInterfaceAccess<Game.Localization.ILocalization>, ILocalization
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PlayerPrefsPreviousSystemLanguageKey = "LocalizationPreviousSystemLanguage";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PlayerPrefsCurrentLanguageKey = "LocalizationCurrentLanguage";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PlayerPrefsShowDebugKey = "LocalizationShowDebug";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Language _currentLanguage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showDebug;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOC_DATA <_locData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, ProtoData.LOC_DATA.Types.ENTRY> _locDataQuickLookup;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Localization.ILocalization GetPublicInterface { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOC_DATA _locData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowDebug { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Language PreviousSystemLanguage { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language CurrentLanguage { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return (bool)this._initialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Localization.ILocalization get_GetPublicInterface()
        {
            return (Game.Localization.ILocalization)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.LOC_DATA get__locData()
        {
            return (ProtoData.LOC_DATA)this.<_locData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__locData(ProtoData.LOC_DATA value)
        {
            this.<_locData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowDebug()
        {
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  "LocalizationShowDebug", defaultValue:  0)) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowDebug(bool value)
        {
            bool val_1 = value;
            UnityEngine.PlayerPrefs.SetInt(key:  "LocalizationShowDebug", value:  val_1);
            this._showDebug = val_1;
            Game.Localization.TextMeshProUGUILocalizer.RedoAllLocalizationLookups();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Language get_PreviousSystemLanguage()
        {
            Game.Localization.Language val_2 = 0;
            bool val_3 = System.Enum.TryParse<Game.Localization.Language>(value:  UnityEngine.PlayerPrefs.GetString(key:  "LocalizationPreviousSystemLanguage", defaultValue:  "None"), result: out  val_2);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PreviousSystemLanguage(Game.Localization.Language value)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = value});
            UnityEngine.PlayerPrefs.SetString(key:  "LocalizationPreviousSystemLanguage", value:  value.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language get_CurrentLanguage()
        {
            Game.Localization.Language val_2 = 0;
            bool val_3 = System.Enum.TryParse<Game.Localization.Language>(value:  UnityEngine.PlayerPrefs.GetString(key:  "LocalizationCurrentLanguage", defaultValue:  "English"), result: out  val_2);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CurrentLanguage(Game.Localization.Language value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  "LocalizationCurrentLanguage", value:  value.ToString());
            this._currentLanguage = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = value});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Localization(Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this._locDataQuickLookup = new System.Collections.Generic.Dictionary<System.String, ENTRY>();
            masterDataDomain.<_getAccessToData>k__BackingField.GetLocDataAsync(returnLocDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.LOC_DATA>(object:  this, method:  System.Void Game.Localization.Localization::ReturnLocDataCallback(ProtoData.LOC_DATA locData)));
            this._showDebug = masterDataDomain.<_getAccessToData>k__BackingField.ShowDebug;
            this.InitCurrentLanguage();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnLocDataCallback(ProtoData.LOC_DATA locData)
        {
            this.<_locData>k__BackingField = locData;
            this.CreateQuickLookup();
            this._initialized = true;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalizedString(string localizedStringId, string originalString)
        {
            string val_24;
            if((this._locDataQuickLookup.ContainsKey(key:  localizedStringId)) == false)
            {
                goto label_2;
            }
            
            Game.Localization.Language val_23 = this._currentLanguage;
            val_23 = val_23 - 1;
            if(val_23 > 5)
            {
                goto label_3;
            }
            
            var val_24 = 52947152 + ((this._currentLanguage - 1)) << 2;
            val_24 = val_24 + 52947152;
            goto (52947152 + ((this._currentLanguage - 1)) << 2 + 52947152);
            label_2:
            val_24 = 0;
            goto label_7;
            label_3:
            string val_5 = this._locDataQuickLookup.Item[localizedStringId].English;
            val_24 = ;
            label_7:
            if(this._showDebug == false)
            {
                    return (string)((System.String.IsNullOrEmpty(value:  val_24 = (val_16 != true) ? "#>!!" : "#>"((val_16 != true) ? "#>!!" : "#>") + (val_16 != true) ? originalString : (val_24)((val_16 != true) ? originalString : (val_24)) + (val_16 != true) ? "!!<#" : "<#"((val_16 != true) ? "!!<#" : "<#"))) != true) ? originalString : (val_24);
            }
            
            bool val_16 = System.String.IsNullOrEmpty(value:  val_24);
            return (string)((System.String.IsNullOrEmpty(value:  val_24)) != true) ? originalString : (val_24);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalizedString(string localizedStringId, string originalString, System.Collections.Generic.Dictionary<string, string> replacementTokens)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = this.GetLocalizedString(localizedStringId:  localizedStringId, originalString:  originalString);
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = replacementTokens.Keys.GetEnumerator();
            label_6:
            if(((-813256520) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_4 = 0.emailUIDataHandler;
            string val_5 = replacementTokens.Item[val_4];
            string val_8 = val_10.Replace(oldValue:  "<fnaf "("<fnaf ") + val_4 + " fnaf>"(" fnaf>"), newValue:  this.GetLocalizedString(localizedStringId:  val_5, originalString:  val_5));
            goto label_6;
            label_3:
            val_11 = 0;
            val_12 = 1;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525268426936});
            if(( & 1) != 0)
            {
                    return (string)val_10;
            }
            
            if( == 0)
            {
                    return (string)val_10;
            }
            
            return (string)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitCurrentLanguage()
        {
            Game.Localization.Language val_1 = this.PreviousSystemLanguage;
            Game.Localization.Language val_2 = val_1.GetCurrentSystemLanguage();
            if(val_1 != val_2)
            {
                    this.CurrentLanguage = val_2;
                this.PreviousSystemLanguage = val_2;
            }
            
            this._currentLanguage = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Language GetCurrentSystemLanguage()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            UnityEngine.SystemLanguage val_1 = UnityEngine.Application.systemLanguage;
            if(val_1 >= 16)
            {
                    var val_2 = (val_1 > 28) ? 34 : 28;
                var val_3 = (val_1 <= 28) ? (4 + 1) : 4;
                var val_4 = (val_1 > 28) ? 30 : 21;
                var val_5 = (val_1 > 28) ? 6 : 2;
            }
            else
            {
                    val_10 = 3;
                val_9 = 15;
                val_8 = 1;
                val_7 = 14;
            }
            
            val_1 = (val_1 == val_9) ? (val_10) : ((val_1 == val_7) ? (val_8) : 0);
            return (Game.Localization.Language)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateQuickLookup()
        {
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            var val_31;
            this._locDataQuickLookup.Clear();
            val_25 = 1152921504685174784;
            val_26 = 1152921525268053744;
            val_27 = this.<_locData>k__BackingField.Entries.GetEnumerator();
            label_26:
            var val_27 = 0;
            val_27 = val_27 + 1;
            if(val_27.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            T val_6 = val_27.Current;
            if((this._locDataQuickLookup.ContainsKey(key:  val_6.ID)) == false)
            {
                goto label_17;
            }
            
            ConsoleLogger.LogError(className:  "Localization", functionName:  "CreateQuickLookup", logString:  System.String.Format(format:  "localization entry already exits for id \'{0}\'.  Previous Entry:{1}, New Entry:{2}", arg0:  val_6.ID, arg1:  this._locDataQuickLookup.Item[val_6.ID], arg2:  val_6));
            goto label_26;
            label_17:
            this._locDataQuickLookup.Add(key:  val_6.ID, value:  val_6);
            goto label_26;
            label_9:
            val_30 = 0;
            val_31 = 145;
            if(val_27 == null)
            {
                
            }
            else
            {
                    var val_29 = 0;
                val_29 = val_29 + 1;
                val_27.Dispose();
            }
            
            if( == 145)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_27 = ???;
            val_31 = ???;
            val_25 = ???;
            val_26 = ???;
        }
    
    }

}
