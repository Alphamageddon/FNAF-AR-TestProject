using UnityEngine;

namespace DevTools.Runtime.DebugMenu
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ShowHideSROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, object> _registeredDebugMenuSections;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<object> _shownDebugMenuSections;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _currentDebugMenuIndex;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CurrentDebugMenuSectionIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string CurrentDebugMenuSectionName { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CurrentSectionVisible { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterMenuSection(string sectionName, object sectionMenuObject, bool defaultToOn = False)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = null;
            if((DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.ContainsKey(key:  sectionName)) != false)
            {
                    val_5 = null;
                DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Add(key:  sectionName, value:  sectionMenuObject);
            }
            else
            {
                    val_6 = null;
                DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.set_Item(key:  sectionName, value:  sectionMenuObject);
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.SetProperVisibility(sectionName:  sectionName, defaultToOn:  defaultToOn);
            if((DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex & 2147483648) == 0)
            {
                    return;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DeregisterMenuSection(string sectionName)
        {
            null = null;
            if((DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.ContainsKey(key:  sectionName)) == false)
            {
                    return;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.HideSection(sectionName:  sectionName);
            bool val_2 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Remove(key:  sectionName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SetProperVisibility(string sectionName, bool defaultToOn)
        {
            defaultToOn = defaultToOn;
            if((UnityEngine.PlayerPrefs.GetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), defaultValue:  defaultToOn)) == 1)
            {
                    DevTools.Runtime.DebugMenu.ShowHideSROptions.ShowSection(sectionName:  sectionName);
                return;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.HideSection(sectionName:  sectionName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool HasSections()
        {
            null = null;
            return (bool)(DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ShowAll()
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = val_7.GetEnumerator();
            label_8:
            if(((-570391096) & 1) == 0)
            {
                goto label_5;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.ShowSection(sectionName:  0.emailUIDataHandler);
            goto label_8;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525511292360});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void HideAll()
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = val_7.GetEnumerator();
            label_8:
            if(((-570254520) & 1) == 0)
            {
                goto label_5;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.HideSection(sectionName:  0.emailUIDataHandler);
            goto label_8;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525511428936});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int get_CurrentDebugMenuSectionIndex()
        {
            null = null;
            return (int)DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CurrentDebugMenuSectionIndex(int value)
        {
            int val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = value;
            val_5 = null;
            val_6 = null;
            if(DevTools.Runtime.DebugMenu.ShowHideSROptions.HasSections() != true)
            {
                    val_6 = null;
                DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex = 0;
            }
            
            val_6 = null;
            int val_2 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Count;
            if(val_2 <= val_4)
            {
                goto label_9;
            }
            
            val_7 = null;
            if((val_4 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_8 = null;
            goto label_13;
            label_9:
            val_8 = null;
            val_8 = null;
            val_4 = 0;
            label_13:
            label_18:
            DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex = val_4;
            return;
            label_10:
            val_9 = null;
            int val_3 = val_2 - 1;
            goto label_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_CurrentDebugMenuSectionName()
        {
            var val_4;
            var val_5;
            int val_7;
            var val_8;
            val_4 = null;
            if(DevTools.Runtime.DebugMenu.ShowHideSROptions.HasSections() != false)
            {
                    val_5 = null;
                val_5 = null;
                val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
                if((val_7 & 2147483648) == 0)
            {
                    val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
                System.Collections.Generic.KeyValuePair<System.String, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  DevTools.Runtime.DebugMenu.ShowHideSROptions.__il2cppRuntimeField_static_fields, index:  val_7);
                GameUI.EmailUIDataHandler val_3 = val_2.Value.emailUIDataHandler;
                return (string)val_8;
            }
            
            }
            
            val_8 = "";
            return (string)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_CurrentSectionVisible()
        {
            var val_7;
            var val_8;
            int val_10;
            var val_11;
            val_7 = null;
            if(DevTools.Runtime.DebugMenu.ShowHideSROptions.HasSections() != false)
            {
                    val_8 = null;
                val_8 = null;
                val_10 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
                if((val_10 & 2147483648) == 0)
            {
                    val_10 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
                System.Collections.Generic.KeyValuePair<System.String, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  DevTools.Runtime.DebugMenu.ShowHideSROptions.__il2cppRuntimeField_static_fields, index:  val_10);
                var val_6 = ((UnityEngine.PlayerPrefs.GetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  val_2.Value.emailUIDataHandler), defaultValue:  0)) == 1) ? 1 : 0;
                return (bool)val_11;
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CurrentSectionVisible(bool value)
        {
            var val_4;
            var val_5;
            int val_7;
            val_4 = null;
            if(DevTools.Runtime.DebugMenu.ShowHideSROptions.HasSections() == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            val_7 = DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex;
            System.Collections.Generic.KeyValuePair<System.String, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(source:  DevTools.Runtime.DebugMenu.ShowHideSROptions.__il2cppRuntimeField_static_fields, index:  val_7);
            GameUI.EmailUIDataHandler val_3 = val_2.Value.emailUIDataHandler;
            if(value != false)
            {
                    DevTools.Runtime.DebugMenu.ShowHideSROptions.ShowSection(sectionName:  val_3);
                return;
            }
            
            DevTools.Runtime.DebugMenu.ShowHideSROptions.HideSection(sectionName:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ShowSection(string sectionName)
        {
            var val_7;
            System.Collections.Generic.HashSet<System.Object> val_8;
            var val_9;
            var val_11;
            val_7 = null;
            val_7 = null;
            object val_1 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Item[sectionName];
            val_8 = DevTools.Runtime.DebugMenu.ShowHideSROptions._shownDebugMenuSections;
            val_9 = public System.Boolean System.Collections.Generic.HashSet<System.Object>::Contains(System.Object item);
            if((val_8.Contains(item:  val_1)) != true)
            {
                    SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
                if(val_3 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_9 = 12;
                val_3.AddOptionContainer(container:  val_1);
            }
            
                val_11 = null;
                val_11 = null;
                val_8 = DevTools.Runtime.DebugMenu.ShowHideSROptions._shownDebugMenuSections;
                bool val_5 = val_8.Add(item:  val_1);
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), value:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void HideSection(string sectionName)
        {
            var val_7;
            System.Collections.Generic.HashSet<System.Object> val_8;
            var val_9;
            var val_11;
            val_7 = null;
            val_7 = null;
            object val_1 = DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections.Item[sectionName];
            val_8 = DevTools.Runtime.DebugMenu.ShowHideSROptions._shownDebugMenuSections;
            val_9 = public System.Boolean System.Collections.Generic.HashSet<System.Object>::Contains(System.Object item);
            if((val_8.Contains(item:  val_1)) != false)
            {
                    SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
                if(val_3 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_9 = 13;
                val_3.RemoveOptionContainer(container:  val_1);
            }
            
                val_11 = null;
                val_11 = null;
                val_8 = DevTools.Runtime.DebugMenu.ShowHideSROptions._shownDebugMenuSections;
                bool val_5 = val_8.Remove(item:  val_1);
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  DevTools.Runtime.DebugMenu.DebugMenuSectionSettings.GetSectionKey(sectionName:  sectionName), value:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ShowHideSROptions()
        {
            DevTools.Runtime.DebugMenu.ShowHideSROptions._registeredDebugMenuSections = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            DevTools.Runtime.DebugMenu.ShowHideSROptions._shownDebugMenuSections = new System.Collections.Generic.HashSet<System.Object>();
            DevTools.Runtime.DebugMenu.ShowHideSROptions._currentDebugMenuIndex = 0;
        }
    
    }

}
