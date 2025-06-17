using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRDebuggerUtil
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsMobilePlatform { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsMobilePlatform()
        {
            if(UnityEngine.Application.isMobilePlatform == false)
            {
                    return (bool)((UnityEngine.Application.platform - 18) < 3) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool EnsureEventSystemExists()
        {
            UnityEngine.Object val_10;
            var val_11;
            val_10 = SRDebugger.Settings.Instance;
            if(val_10.EnableEventSystemGeneration == false)
            {
                goto label_16;
            }
            
            val_10 = UnityEngine.EventSystems.EventSystem.current;
            if(val_10 == 0)
            {
                goto label_7;
            }
            
            label_16:
            val_11 = 0;
            return (bool)val_11;
            label_7:
            UnityEngine.EventSystems.EventSystem val_5 = UnityEngine.Object.FindObjectOfType<UnityEngine.EventSystems.EventSystem>();
            val_10 = val_5;
            if(val_5 != 0)
            {
                    if(val_10.gameObject.activeSelf != false)
            {
                    if(val_10.enabled == true)
            {
                goto label_16;
            }
            
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  "[SRDebugger] No EventSystem found in scene - creating a default one.");
            SRDebugger.Internal.SRDebuggerUtil.CreateDefaultEventSystem();
            val_11 = 1;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CreateDefaultEventSystem()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "EventSystem");
            if(val_1 != null)
            {
                    UnityEngine.EventSystems.EventSystem val_2 = val_1.AddComponent<UnityEngine.EventSystems.EventSystem>();
            }
            else
            {
                    UnityEngine.EventSystems.EventSystem val_3 = val_1.AddComponent<UnityEngine.EventSystems.EventSystem>();
            }
            
            UnityEngine.EventSystems.StandaloneInputModule val_4 = val_1.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> ScanForOptions(object obj)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            SRDebugger.Internal.OptionDefinition val_22;
            string val_23;
            int val_24;
            string val_25;
            System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> val_1 = null;
            val_18 = val_1;
            val_1 = new System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>();
            System.Type val_2 = obj.GetType();
            val_19 = 1152921523017747104;
            val_20 = 1152921523017748128;
            val_21 = 0;
            goto label_3;
            label_30:
            System.ComponentModel.CategoryAttribute val_3 = SRF.Helpers.SRReflection.GetAttribute<System.ComponentModel.CategoryAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg);
            if(val_3 != null)
            {
                    val_23 = val_3.Category;
            }
            else
            {
                    val_23 = "Default";
            }
            
            if((SRF.Helpers.SRReflection.GetAttribute<SROptions.SortAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg)) != null)
            {
                    val_24 = val_5.SortPriority;
            }
            else
            {
                    val_24 = 0;
            }
            
            if((SRF.Helpers.SRReflection.GetAttribute<SROptions.DisplayNameAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg)) != null)
            {
                    val_25 = val_6.Name;
            }
            else
            {
                    val_25 = System.Type.__il2cppRuntimeField_byval_arg;
            }
            
            if(System.Type.__il2cppRuntimeField_byval_arg.IsStatic != true)
            {
                    val_18 = val_18;
                val_19 = 1152921523017747104;
                val_20 = 1152921523017748128;
                if((System.Type.op_Inequality(left:  System.Type.__il2cppRuntimeField_byval_arg, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != true)
            {
                    val_20 = 1152921523017748128;
                SRDebugger.Internal.OptionDefinition val_12 = null;
                val_22 = val_12;
                val_12 = new SRDebugger.Internal.OptionDefinition();
                .<Name>k__BackingField = val_25;
                .<Category>k__BackingField = val_23;
                .<SortPriority>k__BackingField = val_24;
                .<Method>k__BackingField = new SRF.Helpers.MethodReference(target:  obj, method:  System.Type.__il2cppRuntimeField_byval_arg);
                val_1.Add(item:  null);
                val_20 = 1152921523017748128;
            }
            
            }
            
            val_21 = 1;
            label_3:
            if(val_21 < 1152921522941538784)
            {
                goto label_30;
            }
            
            return (System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetNumberString(int value, int max, string exceedsMaxString)
        {
            if(value >= max)
            {
                    return (string)exceedsMaxString;
            }
            
            exceedsMaxString = value.ToString();
            return (string)exceedsMaxString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ConfigureCanvas(UnityEngine.Canvas canvas)
        {
            if(SRDebugger.Settings.Instance.UseDebugCamera == false)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            UnityEngine.Camera val_5 = SRDebugger.Internal.Service.DebugCamera.Camera;
            if(canvas != null)
            {
                    canvas.worldCamera = val_5;
            }
            else
            {
                    0.worldCamera = val_5;
            }
            
            canvas.renderMode = 1;
        }
    
    }

}
