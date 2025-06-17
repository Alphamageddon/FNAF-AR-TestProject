using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocalLocalizer : ILocalization
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.LocalLocalizationKVPs _localLocalizationKVPs;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language CurrentLanguage { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalizedString(string localizedStringId, string originalString)
        {
            Game.Localization.Language val_7;
            var val_8;
            val_7 = this;
            if((this._localLocalizationKVPs.ContainsKey(searchKey:  localizedStringId)) != false)
            {
                    val_7 = Game.Localization.LocalizationDomain._localizationDomain.CurrentLanguage;
                string val_4 = this._localLocalizationKVPs.Item[localizedStringId].Item[val_7];
                var val_6 = ((System.String.IsNullOrWhiteSpace(value:  val_4)) != true) ? originalString : (val_4);
                return (string)val_8;
            }
            
            val_8 = originalString;
            return (string)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalizedString(string localizedStringId, string originalString, System.Collections.Generic.Dictionary<string, string> replacementTokens)
        {
            return this.GetLocalizedString(localizedStringId:  localizedStringId, originalString:  originalString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocalLocalizer(Game.Localization.LocalLocalizationKVPs localLocalizationKVPs)
        {
            this._localLocalizationKVPs = localLocalizationKVPs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language get_CurrentLanguage()
        {
            if(Game.Localization.LocalizationDomain._localizationDomain != null)
            {
                    return Game.Localization.LocalizationDomain._localizationDomain.CurrentLanguage;
            }
            
            return Game.Localization.LocalizationDomain._localizationDomain.CurrentLanguage;
        }
    
    }

}
