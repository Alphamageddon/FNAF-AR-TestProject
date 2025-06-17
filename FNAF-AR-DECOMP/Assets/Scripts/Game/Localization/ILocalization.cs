using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILocalization
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.Localization.Language CurrentLanguage { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetLocalizedString(string localizedStringId, string originalString); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetLocalizedString(string localizedStringId, string originalString, System.Collections.Generic.Dictionary<string, string> replacementTokens); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.Localization.Language get_CurrentLanguage(); // 0
    
    }

}
