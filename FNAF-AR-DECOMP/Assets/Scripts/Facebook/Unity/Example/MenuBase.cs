using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal abstract class MenuBase : ConsoleBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Facebook.Unity.ShareDialogMode shareDialogMode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void GetGui(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool ShowDialogModeSelector()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual bool ShowBackButton()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void HandleResult(Facebook.Unity.IResult result)
        {
            string val_11;
            var val_12;
            var val_17;
            string val_18;
            string val_19;
            var val_20;
            if(result == null)
            {
                goto label_1;
            }
            
            mem[1152921520101793736] = 0;
            var val_16 = 0;
            val_16 = val_16 + 1;
            goto label_5;
            label_1:
            val_11 = "Null Response\n";
            mem[1152921520101793680] = val_11;
            val_12 = null;
            goto label_8;
            label_5:
            if((System.String.IsNullOrEmpty(value:  result.Error)) == false)
            {
                goto label_9;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_13;
            label_9:
            mem[1152921520101793672] = "Error - Check log for details";
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_17;
            label_13:
            if(result.Cancelled == false)
            {
                goto label_18;
            }
            
            mem[1152921520101793672] = "Cancelled - Check log for details";
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_22;
            label_18:
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_26;
            label_17:
            val_17 = result;
            string val_7 = val_17.Error;
            val_18 = "Error Response:\n";
            goto label_28;
            label_22:
            val_17 = result;
            string val_9 = val_17.RawResult;
            val_18 = "Cancelled Response:\n";
            goto label_28;
            label_26:
            val_19 = 0;
            if((System.String.IsNullOrEmpty(value:  result.RawResult)) == false)
            {
                goto label_29;
            }
            
            val_20 = "Empty Response\n";
            goto label_30;
            label_29:
            mem[1152921520101793672] = "Success - Check log for details";
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17 = result;
            val_18 = "Success Response:\n";
            label_28:
            val_19 = val_17.RawResult;
            label_30:
            mem[1152921520101793680] = val_18 + val_19;
            val_11 = result;
            val_12 = null;
            label_8:
            Facebook.Unity.Example.LogView.AddLog(log:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnGUI()
        {
            UnityEngine.GUILayoutOption val_24;
            UnityEngine.GUILayoutOption[] val_25;
            var val_26;
            if(UnityEngine.Screen.orientation == 3)
            {
                    UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
                UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            }
            
            System.Type val_4 = this.GetType();
            UnityEngine.GUILayout.Label(text:  val_4, style:  this.LabelStyle, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            this.AddStatus();
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_8 = UnityEngine.Input.GetTouch(index:  0);
                if(format == 1)
            {
                    UnityEngine.Touch val_10 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector2 val_11 = position;
                mem[1152921520102176248] = val_4;
                mem[1152921520102176252] = S8 + val_11.y;
            }
            
            }
            
            UnityEngine.GUILayoutOption[] val_13 = new UnityEngine.GUILayoutOption[1];
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_15 = UnityEngine.Screen.width;
            }
            
            val_24 = UnityEngine.GUILayout.MinWidth(minWidth:  760f);
            if(val_13 == null)
            {
                goto label_9;
            }
            
            if(val_24 != null)
            {
                goto label_10;
            }
            
            goto label_13;
            label_9:
            if(val_24 == null)
            {
                goto label_13;
            }
            
            label_10:
            label_13:
            val_13[0] = val_24;
            UnityEngine.Vector2 val_17 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = V8.16B, y = V9.16B}, options:  val_13);
            mem[1152921520102176248] = val_17.x;
            mem[1152921520102176252] = val_17.y;
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if((this & 1) != 0)
            {
                    this.AddBackButton();
            }
            
            this.AddLogButton();
            if((this & 1) != 0)
            {
                    val_26 = null;
                val_26 = null;
                UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[1];
                val_24 = val_19;
                val_25 = val_24;
                val_24[0] = UnityEngine.GUILayout.MinWidth(minWidth:  (Facebook.Unity.Constants.IsMobile != true) ? 0f : 48f);
                UnityEngine.GUILayout.Label(content:  UnityEngine.GUIContent.none, options:  val_19);
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            if((this & 1) != 0)
            {
                    this.AddDialogModeButtons();
            }
            
            UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.EndScrollView();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddStatus()
        {
            UnityEngine.GUILayout.Space(pixels:  5f);
            UnityEngine.GUILayoutOption[] val_3 = new UnityEngine.GUILayoutOption[1];
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_6 = UnityEngine.Screen.width - 30;
            }
            
            UnityEngine.GUILayoutOption val_7 = UnityEngine.GUILayout.MinWidth(minWidth:  700f);
            if(val_3 == null)
            {
                goto label_5;
            }
            
            if(val_7 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_3[0] = val_7;
            UnityEngine.GUILayout.Box(text:  "Status: "("Status: ") + null, style:  this.TextStyle, options:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddBackButton()
        {
            UnityEngine.GUI.enabled = System.Linq.Enumerable.Any<System.String>(source:  Facebook.Unity.Example.ConsoleBase.MenuStack);
            bool val_4 = this.Button(label:  "Back");
            if(val_4 != false)
            {
                    val_4.GoBack();
            }
            
            UnityEngine.GUI.enabled = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddLogButton()
        {
            if((this.Button(label:  "Log")) == false)
            {
                    return;
            }
            
            this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddDialogModeButtons()
        {
            var val_12;
            var val_13;
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            System.Collections.IEnumerator val_4 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
            label_19:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            this.AddDialogModeButton(mode:  UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_4.Current}));
            goto label_19;
            label_11:
            val_12 = 0;
            val_13 = 79;
            if(val_4 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_4.Dispose();
            }
            
            UnityEngine.GUILayout.EndHorizontal();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddDialogModeButton(Facebook.Unity.ShareDialogMode mode)
        {
            var val_6;
            var val_7;
            if(UnityEngine.GUI.enabled != false)
            {
                    var val_2 = (Facebook.Unity.Example.MenuBase.shareDialogMode != mode) ? 1 : 0;
                val_7 = 1;
            }
            else
            {
                    val_7 = 0;
                val_6 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = mode});
            if((this.Button(label:  mode.ToString())) != false)
            {
                    Facebook.Unity.Example.MenuBase.shareDialogMode = val_4;
                FB.Mobile.ShareDialogMode = val_4;
            }
            
            UnityEngine.GUI.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected MenuBase()
        {
        
        }
    
    }

}
