using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocalizationDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.ILocalization ILocalization;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Game.Localization.LocalizationDomain _localizationDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Localization _localization;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.LocalLocalizer _localLocalization;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Localization.Localization_SROptions _localizationSrOptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.Localization.LocalizationDomain Instance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.Localization.ILocalization> Localization { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.ILocalization ILocalLocalization { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language CurrentLanguage { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowDebug { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Game.Localization.LocalizationDomain get_Instance()
        {
            return (Game.Localization.LocalizationDomain)Game.Localization.LocalizationDomain._localizationDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_Instance(Game.Localization.LocalizationDomain value)
        {
            if(Game.Localization.LocalizationDomain._localizationDomain != null)
            {
                    ConsoleLogger.LogError(className:  "LocalizationDomain", functionName:  "Instance", logString:  "Setting Instance, but one already exists!");
            }
            
            Game.Localization.LocalizationDomain._localizationDomain = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.Localization.ILocalization> get_Localization()
        {
            return (Utilities.AsyncInterfaceAccess<Game.Localization.ILocalization>)this._localization;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.ILocalization get_ILocalLocalization()
        {
            return (Game.Localization.ILocalization)this._localLocalization;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.Language get_CurrentLanguage()
        {
            if(this._localization != null)
            {
                    return this._localization.CurrentLanguage;
            }
            
            return 0.CurrentLanguage;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_CurrentLanguage(Game.Localization.Language value)
        {
            this._localization.CurrentLanguage = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShowDebug()
        {
            if(this._localization != null)
            {
                    return this._localization.ShowDebug;
            }
            
            return 0.ShowDebug;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ShowDebug(bool value)
        {
            value = value;
            this._localization.ShowDebug = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocalizationDomain(Game.MasterData.MasterDataDomain masterDataDomain, Game.Localization.LocalLocalizationKVPs localLocalizationKVPs)
        {
            Game.Localization.LocalizationDomain.Instance = this;
            Game.Localization.Localization val_1 = new Game.Localization.Localization(masterDataDomain:  masterDataDomain);
            this._localization = val_1;
            val_1.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Game.Localization.LocalizationDomain::<.ctor>b__18_0(Game.Localization.ILocalization localization)));
            ._localLocalizationKVPs = localLocalizationKVPs;
            this._localLocalization = new Game.Localization.LocalLocalizer();
            Game.Localization.Localization_SROptions val_4 = new Game.Localization.Localization_SROptions();
            ._localizationDomain = this;
            this._localizationSrOptions = val_4;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Localization", sectionMenuObject:  val_4, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetCurrentLanguageCode2()
        {
            var val_3;
            if((this.CurrentLanguage - 1) <= 5)
            {
                    val_3 = mem[66464864 + ((val_1 - 1)) << 3];
                val_3 = 66464864 + ((val_1 - 1)) << 3;
                return (string)val_3;
            }
            
            val_3 = "en";
            return (string)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <.ctor>b__18_0(Game.Localization.ILocalization localization)
        {
            this.ILocalization = localization;
        }
    
    }

}
