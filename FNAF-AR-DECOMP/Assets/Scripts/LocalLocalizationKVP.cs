using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class LocalLocalizationKVPs.LocalLocalizationKVP
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Key;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<Game.Localization.LocalLocalizationKVPs.LanguageToStringKVP> localization;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Item { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ContainsKey(Game.Localization.Language searchLanguage)
    {
        .searchLanguage = searchLanguage;
        return (bool)((this.localization.Find(match:  new System.Predicate<LanguageToStringKVP>(object:  new LocalLocalizationKVPs.LocalLocalizationKVP.<>c__DisplayClass2_0(), method:  System.Boolean LocalLocalizationKVPs.LocalLocalizationKVP.<>c__DisplayClass2_0::<ContainsKey>b__0(Game.Localization.LocalLocalizationKVPs.LanguageToStringKVP x)))) != 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Item(Game.Localization.Language key)
    {
        .key = key;
        if((this.localization.Find(match:  new System.Predicate<LanguageToStringKVP>(object:  new LocalLocalizationKVPs.LocalLocalizationKVP.<>c__DisplayClass4_0(), method:  System.Boolean LocalLocalizationKVPs.LocalLocalizationKVP.<>c__DisplayClass4_0::<get_Item>b__0(Game.Localization.LocalLocalizationKVPs.LanguageToStringKVP x)))) != null)
        {
                return (string)val_3.localizedString;
        }
        
        return (string)val_3.localizedString;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LocalLocalizationKVPs.LocalLocalizationKVP()
    {
    
    }

}
