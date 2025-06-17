using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class OptionControlFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.IList<SRDebugger.UI.Controls.DataBoundControl> _dataControlPrefabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.UI.Controls.Data.ActionControl _actionControlPrefab;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.UI.Controls.OptionsControlBase CreateControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            var val_10;
            UnityEngine.Object val_11;
            var val_12;
            if(SRDebugger.Internal.OptionControlFactory._dataControlPrefabs == null)
            {
                    SRDebugger.Internal.OptionControlFactory._dataControlPrefabs = UnityEngine.Resources.LoadAll<SRDebugger.UI.Controls.DataBoundControl>(path:  "SRDebugger/UI/Prefabs/Options");
            }
            
            if(SRDebugger.Internal.OptionControlFactory._actionControlPrefab == 0)
            {
                    val_10 = null;
                SRDebugger.Internal.OptionControlFactory._actionControlPrefab = System.Linq.Enumerable.FirstOrDefault<SRDebugger.UI.Controls.Data.ActionControl>(source:  UnityEngine.Resources.LoadAll<SRDebugger.UI.Controls.Data.ActionControl>(path:  "SRDebugger/UI/Prefabs/Options"));
            }
            else
            {
                    val_10 = null;
            }
            
            val_11 = 0;
            if(SRDebugger.Internal.OptionControlFactory._actionControlPrefab == val_11)
            {
                    val_12 = null;
                val_11 = 0;
                UnityEngine.Debug.LogError(message:  null);
            }
            
            if((from.<Property>k__BackingField) != null)
            {
                    SRDebugger.UI.Controls.DataBoundControl val_6 = SRDebugger.Internal.OptionControlFactory.CreateDataControl(from:  from, categoryPrefix:  categoryPrefix);
                return (SRDebugger.UI.Controls.OptionsControlBase)SRDebugger.Internal.OptionControlFactory.CreateActionControl(from:  from, categoryPrefix:  val_11);
            }
            
            if((from.<Method>k__BackingField) != null)
            {
                    return (SRDebugger.UI.Controls.OptionsControlBase)SRDebugger.Internal.OptionControlFactory.CreateActionControl(from:  from, categoryPrefix:  val_11);
            }
            
            System.Exception val_8 = new System.Exception(message:  "OptionDefinition did not contain property or method.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.UI.Controls.Data.ActionControl CreateActionControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            UnityEngine.Object val_3;
            string val_4;
            val_3 = SRInstantiate.Instantiate<SRDebugger.UI.Controls.Data.ActionControl>(prefab:  SRDebugger.Internal.OptionControlFactory._actionControlPrefab);
            if(val_3 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "[SRDebugger.OptionsTab] Error creating action control from prefab");
                val_3 = 0;
                return (SRDebugger.UI.Controls.Data.ActionControl)val_3;
            }
            
            if(from != null)
            {
                    val_4 = from.<Name>k__BackingField;
            }
            else
            {
                    val_4 = 11993091;
            }
            
            if(val_3 != null)
            {
                    val_3.SetMethod(methodName:  val_4, method:  from.<Method>k__BackingField);
            }
            else
            {
                    val_3.SetMethod(methodName:  val_4, method:  from.<Method>k__BackingField);
            }
            
            mem2[0] = from;
            return (SRDebugger.UI.Controls.Data.ActionControl)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRDebugger.UI.Controls.DataBoundControl CreateDataControl(SRDebugger.Internal.OptionDefinition from, string categoryPrefix)
        {
            string val_13;
            var val_14;
            string val_15;
            val_13 = categoryPrefix;
            .from = from;
            SRDebugger.UI.Controls.DataBoundControl val_3 = System.Linq.Enumerable.FirstOrDefault<SRDebugger.UI.Controls.DataBoundControl>(source:  SRDebugger.Internal.OptionControlFactory._dataControlPrefabs, predicate:  new System.Func<SRDebugger.UI.Controls.DataBoundControl, System.Boolean>(object:  new OptionControlFactory.<>c__DisplayClass4_0(), method:  System.Boolean OptionControlFactory.<>c__DisplayClass4_0::<CreateDataControl>b__0(SRDebugger.UI.Controls.DataBoundControl p)));
            if(val_3 == 0)
            {
                    object[] val_5 = new object[1];
                val_5[0] = (OptionControlFactory.<>c__DisplayClass4_0)[1152921523014268080].from.<Property>k__BackingField.PropertyType;
                UnityEngine.Debug.LogWarning(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[SRDebugger.OptionsTab] Can\'t find data control for type {0}", args:  val_5));
                val_14 = 0;
                return (SRDebugger.UI.Controls.DataBoundControl)val_14;
            }
            
            val_14 = SRInstantiate.Instantiate<SRDebugger.UI.Controls.DataBoundControl>(prefab:  val_3);
            val_15 = (OptionControlFactory.<>c__DisplayClass4_0)[1152921523014268080].from.<Name>k__BackingField;
            if((System.String.IsNullOrEmpty(value:  val_13)) != true)
            {
                    if((val_15.StartsWith(value:  val_13)) != false)
            {
                    val_15 = val_15.Substring(startIndex:  val_13.Length);
            }
            
            }
            
            val_14.Bind(propertyName:  val_15, prop:  (OptionControlFactory.<>c__DisplayClass4_0)[1152921523014268080].from.<Property>k__BackingField);
            val_13 = (OptionControlFactory.<>c__DisplayClass4_0)[1152921523014268080].from;
            mem2[0] = val_13;
            return (SRDebugger.UI.Controls.DataBoundControl)val_14;
        }
    
    }

}
