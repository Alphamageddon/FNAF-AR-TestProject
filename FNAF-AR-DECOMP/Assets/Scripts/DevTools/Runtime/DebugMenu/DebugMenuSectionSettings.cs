using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DebugMenuSectionSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DebugMenuSectionPrefixKey = "DebugMenuSectionSetting_";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetSectionKey(string sectionName)
        {
            return "DebugMenuSectionSetting_" + sectionName;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsSectionVisible(string sectionName, bool defaultToOn = False)
        {
            defaultToOn = defaultToOn;
            return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), defaultValue:  defaultToOn)) == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetSectionVisible(string sectionName)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), value:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetSectionInvisible(string sectionName)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), value:  0);
        }
    
    }

}
