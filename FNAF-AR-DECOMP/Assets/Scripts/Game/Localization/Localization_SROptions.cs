using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Localization_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.LocalizationDomain _localizationDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowDebugVisuals { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language CurrentLanguage { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Localization_SROptions(Game.Localization.LocalizationDomain localizationDomain)
        {
            this._localizationDomain = localizationDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowDebugVisuals()
        {
            if(this._localizationDomain != null)
            {
                    return this._localizationDomain.ShowDebug;
            }
            
            return this._localizationDomain.ShowDebug;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowDebugVisuals(bool value)
        {
            value = value;
            this._localizationDomain.ShowDebug = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language get_CurrentLanguage()
        {
            if(this._localizationDomain != null)
            {
                    return this._localizationDomain.CurrentLanguage;
            }
            
            return this._localizationDomain.CurrentLanguage;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CurrentLanguage(Game.Localization.Language value)
        {
            this._localizationDomain.CurrentLanguage = value;
        }
    
    }

}
