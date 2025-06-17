using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocalLocalizationKVPs : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP> locKVPs;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP Item { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ContainsKey(string searchKey)
        {
            .searchKey = searchKey;
            return (bool)((this.locKVPs.Find(match:  new System.Predicate<LocalLocalizationKVP>(object:  new LocalLocalizationKVPs.<>c__DisplayClass3_0(), method:  System.Boolean LocalLocalizationKVPs.<>c__DisplayClass3_0::<ContainsKey>b__0(Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP x)))) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP get_Item(string key)
        {
            .key = key;
            if(this.locKVPs != null)
            {
                    return this.locKVPs.Find(match:  new System.Predicate<LocalLocalizationKVP>(object:  new LocalLocalizationKVPs.<>c__DisplayClass5_0(), method:  System.Boolean LocalLocalizationKVPs.<>c__DisplayClass5_0::<get_Item>b__0(Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP x)));
            }
            
            return this.locKVPs.Find(match:  new System.Predicate<LocalLocalizationKVP>(object:  new LocalLocalizationKVPs.<>c__DisplayClass5_0(), method:  System.Boolean LocalLocalizationKVPs.<>c__DisplayClass5_0::<get_Item>b__0(Game.Localization.LocalLocalizationKVPs.LocalLocalizationKVP x)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocalLocalizationKVPs()
        {
        
        }
    
    }

}
