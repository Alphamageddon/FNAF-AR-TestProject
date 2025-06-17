using UnityEngine;

namespace CodingJar.MultiScene.CustomResolvers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class AmsCinemachineResolver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool hasCinemachine;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AddCustomResolver()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_8;
            val_4 = null;
            val_4 = null;
            CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver.hasCinemachine = false;
            val_5 = 0;
            label_25:
            if(val_5 >= val_2.Length)
            {
                goto label_5;
            }
            
            System.Reflection.Assembly val_4 = System.AppDomain.CurrentDomain.GetAssemblies()[0];
            var val_5 = 0;
            label_12:
            if(val_5 >= val_2[0x0][0].resolve_event_holder)
            {
                goto label_15;
            }
            
            val_5 = val_5 + 1;
            if((System.String.op_Equality(a:  System.Reflection.Assembly.__il2cppRuntimeField_byval_arg, b:  "Cinemachine")) == false)
            {
                goto label_12;
            }
            
            val_6 = null;
            val_6 = null;
            CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver.hasCinemachine = true;
            label_15:
            val_8 = null;
            val_8 = null;
            val_5 = val_5 + 1;
            if(CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver.hasCinemachine == false)
            {
                goto label_25;
            }
            
            goto label_26;
            label_5:
            val_8 = null;
            label_26:
            val_8 = null;
            if(CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver.hasCinemachine == false)
            {
                    return;
            }
            
            mem[1152921520125593584] = 0;
            mem[1152921520125593592] = static System.Boolean CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver::HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            mem[1152921520125593568] = static System.Boolean CodingJar.MultiScene.CustomResolvers.AmsCinemachineResolver::HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver.AddCustomResolver(customResolver:  new AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            var val_8;
            UnityEngine.Object val_9;
            val_8 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return false;
            }
            
            if(isActiveAndEnabled == false)
            {
                    return false;
            }
            
            System.Type val_4 = GetType();
            val_9 = val_4;
            if((System.String.IsNullOrEmpty(value:  val_4)) == true)
            {
                    return false;
            }
            
            if((val_9.StartsWith(value:  "Cinemachine")) == false)
            {
                    return false;
            }
            
            val_9 = 1152921520125787840;
            object[] val_7 = new object[1];
            val_7[0] = ;
            CodingJar.MultiScene.AmsDebug.LogWarning(context:  xRef._sourceObject, message:  "xSceneRef on Cinemachine Behaviour: {0}. Disabling/Enabling to ensure pipeline is up to date.", parms:  val_7);
            if( != 0)
            {
                    enabled = false;
            }
            else
            {
                    enabled = false;
            }
            
            enabled = true;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AmsCinemachineResolver()
        {
        
        }
    
    }

}
