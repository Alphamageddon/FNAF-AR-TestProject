using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class LogView : ConsoleBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string datePatt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.IList<string> events;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddLog(string log)
        {
            var val_4 = null;
            System.DateTime val_1 = System.DateTime.Now;
            string val_2 = System.String.Format(format:  "{0}\n{1}\n", arg0:  val_1.dateData, arg1:  log);
            var val_4 = 0;
            val_4 = val_4 + 1;
            Facebook.Unity.Example.LogView.events.Insert(index:  0, item:  ???);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnGUI()
        {
            var val_24;
            UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            bool val_2 = this.Button(label:  "Back");
            if(val_2 != false)
            {
                    val_2.GoBack();
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_4 = UnityEngine.Input.GetTouch(index:  0);
                if(format == 1)
            {
                    UnityEngine.Touch val_6 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector2 val_7 = position;
                mem[1152921520101080824] = "The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.";
                mem[1152921520101080828] = S8 + val_7.y;
            }
            
            }
            
            UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[1];
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_11 = UnityEngine.Screen.width;
            }
            
            UnityEngine.GUILayoutOption val_12 = UnityEngine.GUILayout.MinWidth(minWidth:  760f);
            if(val_9 == null)
            {
                goto label_8;
            }
            
            if(val_12 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_12 == null)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            val_9[0] = val_12;
            UnityEngine.Vector2 val_13 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = V8.16B, y = V9.16B}, options:  val_9);
            mem[1152921520101080824] = val_13.x;
            mem[1152921520101080828] = val_13.y;
            val_24 = null;
            val_24 = null;
            UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.GUILayoutOption val_18 = UnityEngine.GUILayout.ExpandHeight(expand:  true);
            if(val_17 == null)
            {
                goto label_16;
            }
            
            if(val_18 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_18 == null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            val_17[0] = val_18;
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_21 = UnityEngine.Screen.width - 30;
            }
            
            val_17[1] = UnityEngine.GUILayout.MaxWidth(maxWidth:  700f);
            string val_23 = UnityEngine.GUILayout.TextArea(text:  System.String.Join(separator:  "\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  Facebook.Unity.Example.LogView.events)), style:  this.TextStyle, options:  val_17);
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndVertical();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LogView()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LogView()
        {
            Facebook.Unity.Example.LogView.datePatt = "M/d/yyyy hh:mm:ss tt";
            Facebook.Unity.Example.LogView.events = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
