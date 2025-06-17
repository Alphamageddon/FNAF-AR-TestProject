using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class GetSocialFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge _nativeImplementation;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static GetSocialSdk.Core.IGetSocialNativeBridge Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static GetSocialSdk.Core.IGetSocialNativeBridge get_Instance()
        {
            if(GetSocialSdk.Core.GetSocialFactory._nativeImplementation != null)
            {
                    return val_1;
            }
            
            GetSocialSdk.Core.IGetSocialNativeBridge val_1 = GetSocialSdk.Core.GetSocialFactory.FindNativeBridge();
            GetSocialSdk.Core.GetSocialFactory._nativeImplementation = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge FindNativeBridge()
        {
            GetSocialSdk.Core.IGetSocialNativeBridge val_1 = GetSocialSdk.Core.GetSocialFactory.FindBridgeImplementation(currentRuntime:  0);
            if(val_1 == null)
            {
                    return GetSocialSdk.Core.GetSocialNativeBridgeMock.Instance;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge FindBridgeImplementation(GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes currentRuntime)
        {
            var val_12;
            System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> val_14;
            var val_15;
            System.Func<System.Type, GetSocialSdk.Core.IGetSocialNativeBridge> val_17;
            GetSocialFactory.<>c__DisplayClass5_0 val_1 = new GetSocialFactory.<>c__DisplayClass5_0();
            .currentRuntime = currentRuntime;
            .type = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_12 = null;
            val_12 = null;
            val_14 = GetSocialFactory.<>c.<>9__5_0;
            if(val_14 == null)
            {
                    System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> val_5 = null;
                val_14 = val_5;
                val_5 = new System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>>(object:  GetSocialFactory.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.Type> GetSocialFactory.<>c::<FindBridgeImplementation>b__5_0(System.Reflection.Assembly s));
                GetSocialFactory.<>c.<>9__5_0 = val_14;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = GetSocialFactory.<>c.<>9__5_2;
            if(val_17 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<GetSocialSdk.Core.IGetSocialNativeBridge>(source:  System.Linq.Enumerable.Select<System.Type, GetSocialSdk.Core.IGetSocialNativeBridge>(source:  System.Linq.Enumerable.Where<System.Type>(source:  System.Linq.Enumerable.SelectMany<System.Reflection.Assembly, System.Type>(source:  System.AppDomain.CurrentDomain.GetAssemblies(), selector:  val_5), predicate:  new System.Func<System.Type, System.Boolean>(object:  val_1, method:  System.Boolean GetSocialFactory.<>c__DisplayClass5_0::<FindBridgeImplementation>b__1(System.Type p))), selector:  System.Func<System.Type, GetSocialSdk.Core.IGetSocialNativeBridge> val_9 = null), predicate:  new System.Func<GetSocialSdk.Core.IGetSocialNativeBridge, System.Boolean>(object:  val_1, method:  System.Boolean GetSocialFactory.<>c__DisplayClass5_0::<FindBridgeImplementation>b__3(GetSocialSdk.Core.IGetSocialNativeBridge impl)));
            }
            
            val_17 = val_9;
            val_9 = new System.Func<System.Type, GetSocialSdk.Core.IGetSocialNativeBridge>(object:  GetSocialFactory.<>c.__il2cppRuntimeField_static_fields, method:  GetSocialSdk.Core.IGetSocialNativeBridge GetSocialFactory.<>c::<FindBridgeImplementation>b__5_2(System.Type implementation));
            GetSocialFactory.<>c.<>9__5_2 = val_17;
            return System.Linq.Enumerable.FirstOrDefault<GetSocialSdk.Core.IGetSocialNativeBridge>(source:  System.Linq.Enumerable.Select<System.Type, GetSocialSdk.Core.IGetSocialNativeBridge>(source:  System.Linq.Enumerable.Where<System.Type>(source:  System.Linq.Enumerable.SelectMany<System.Reflection.Assembly, System.Type>(source:  System.AppDomain.CurrentDomain.GetAssemblies(), selector:  val_5), predicate:  new System.Func<System.Type, System.Boolean>(object:  val_1, method:  System.Boolean GetSocialFactory.<>c__DisplayClass5_0::<FindBridgeImplementation>b__1(System.Type p))), selector:  val_9), predicate:  new System.Func<GetSocialSdk.Core.IGetSocialNativeBridge, System.Boolean>(object:  val_1, method:  System.Boolean GetSocialFactory.<>c__DisplayClass5_0::<FindBridgeImplementation>b__3(GetSocialSdk.Core.IGetSocialNativeBridge impl)));
        }
    
    }

}
