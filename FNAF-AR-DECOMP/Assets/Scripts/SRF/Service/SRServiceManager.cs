using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRServiceManager : SRAutoSingleton<SRF.Service.SRServiceManager>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const bool EnableLogging = False;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int LoadingCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRF.SRList<SRF.Service.SRServiceManager.Service> _services;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> _serviceStubs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _hasQuit;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsLoading { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsLoading()
        {
            null = null;
            return (bool)(SRF.Service.SRServiceManager.LoadingCount > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetService<T>()
        {
            object val_7;
            var val_8;
            var val_9;
            var val_10;
            val_7 = __RuntimeMethodHiddenParam;
            object val_2 = SRF.Service.SRServiceManager.GetServiceInternal(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            if(val_2 != null)
            {
                    val_8 = val_2;
                if(val_8 != null)
            {
                    return (SRDebugger.Services.IBugReportService)val_8;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            if(SRF.Service.SRServiceManager._hasQuit != true)
            {
                    object[] val_4 = new object[2];
                val_4[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
                val_10 = null;
                val_10 = null;
                val_4[1] = SRF.Service.SRServiceManager._hasQuit;
                val_7 = SRF.SRFStringExtensions.Fmt(formatString:  "Service {0} not found. (HasQuit: {1})", args:  val_4);
                UnityEngine.Debug.LogWarning(message:  val_7);
            }
            
            val_8 = 0;
            return (SRDebugger.Services.IBugReportService)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object GetService(System.Type t)
        {
            System.Type val_4;
            var val_5;
            var val_6;
            val_4 = t;
            object val_1 = SRF.Service.SRServiceManager.GetServiceInternal(t:  val_4);
            if(val_1 != null)
            {
                    return val_1;
            }
            
            val_5 = null;
            val_5 = null;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return val_1;
            }
            
            object[] val_2 = new object[2];
            val_2[0] = val_4;
            val_6 = null;
            val_6 = null;
            val_4 = SRF.Service.SRServiceManager._hasQuit;
            val_2[1] = val_4;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Service {0} not found. (HasQuit: {1})", args:  val_2));
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object GetServiceInternal(System.Type t)
        {
            var val_6;
            object val_7;
            val_6 = null;
            val_6 = null;
            if(SRF.Service.SRServiceManager._hasQuit != false)
            {
                    val_7 = 0;
                return val_7;
            }
            
            val_7 = 0;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return val_7;
            }
            
            SRF.Service.SRServiceManager val_2 = SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.Instance;
            var val_6 = 0;
            label_12:
            if(val_6 >= val_2._services.Count)
            {
                goto label_8;
            }
            
            Service val_4 = val_2._services.Item[0];
            val_6 = val_6 + 1;
            if((t & 1) == 0)
            {
                goto label_12;
            }
            
            val_7 = val_4.Object;
            if(val_7 != null)
            {
                    return val_7;
            }
            
            SRF.Service.SRServiceManager.UnRegisterService(t:  t);
            label_8:
            SRF.Service.SRServiceManager val_5 = SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.Instance;
            if(val_5 != null)
            {
                    return val_5.AutoCreateService(t:  t);
            }
            
            return val_5.AutoCreateService(t:  t);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool HasService<T>()
        {
            return SRF.Service.SRServiceManager.HasService(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool HasService(System.Type t)
        {
            var val_6;
            var val_7;
            val_6 = null;
            val_6 = null;
            if((SRF.Service.SRServiceManager._hasQuit == true) || (UnityEngine.Application.isPlaying == false))
            {
                goto label_7;
            }
            
            SRF.Service.SRServiceManager val_2 = SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.Instance;
            var val_6 = 0;
            label_11:
            if(val_6 >= val_2._services.Count)
            {
                goto label_7;
            }
            
            Service val_4 = val_2._services.Item[0];
            val_6 = val_6 + 1;
            if((t & 1) == 0)
            {
                goto label_11;
            }
            
            var val_5 = (val_4.Object != 0) ? 1 : 0;
            return (bool)val_7;
            label_7:
            val_7 = 0;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterService<T>(object service)
        {
            SRF.Service.SRServiceManager.RegisterService(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), service:  service);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void RegisterService(System.Type t, object service)
        {
            var val_11;
            var val_12;
            val_11 = null;
            val_11 = null;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            if((SRF.Service.SRServiceManager.HasService(t:  t)) == false)
            {
                goto label_6;
            }
            
            if((SRF.Service.SRServiceManager.GetServiceInternal(t:  t)) != service)
            {
                goto label_9;
            }
            
            return;
            label_6:
            SRF.Service.SRServiceManager.UnRegisterService(t:  t);
            if((t & 1) == 0)
            {
                goto label_13;
            }
            
            SRF.Service.SRServiceManager val_3 = SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.Instance;
            SRServiceManager.Service val_4 = new SRServiceManager.Service();
            if(val_4 != null)
            {
                    .Object = service;
            }
            else
            {
                    mem[16] = service;
            }
            
            .Type = t;
            val_3._services.Add(item:  val_4);
            return;
            label_9:
            System.Exception val_6 = null;
            val_12 = val_6;
            val_6 = new System.Exception(message:  "Service already registered for type " + t);
            goto label_18;
            label_13:
            System.Type val_8 = service.GetType();
            System.ArgumentException val_10 = null;
            val_12 = val_10;
            val_10 = new System.ArgumentException(message:  System.String.Format(format:  "service {0} must be assignable from type {1}", args:  new object[2]));
            label_18:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnRegisterService<T>()
        {
            SRF.Service.SRServiceManager.UnRegisterService(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void UnRegisterService(System.Type t)
        {
            var val_8;
            int val_9;
            val_8 = null;
            val_8 = null;
            if(SRF.Service.SRServiceManager._hasQuit == true)
            {
                    return;
            }
            
            if((SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.HasInstance) == false)
            {
                    return;
            }
            
            if((SRF.Service.SRServiceManager.HasService(t:  t)) == false)
            {
                    return;
            }
            
            SRF.Service.SRServiceManager val_3 = SRF.Components.SRAutoSingleton<SRF.Service.SRServiceManager>.Instance;
            val_9 = val_3._services.Count - 1;
            if((val_9 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                Service val_5 = val_3._services.Item[val_9];
                if((System.Type.op_Equality(left:  val_5.Type, right:  t)) != false)
            {
                    val_3._services.RemoveAt(index:  val_9);
            }
            
                val_9 = val_9 - 1;
            }
            while((val_9 & 2147483648) == 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            null = null;
            SRF.Service.SRServiceManager._hasQuit = false;
            this.Awake();
            UnityEngine.Object.DontDestroyOnLoad(target:  this.CachedGameObject);
            this.CachedGameObject.hideFlags = 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void UpdateStubs()
        {
            UnityEngine.Object val_10;
            object val_11;
            val_10 = this;
            if(this._serviceStubs != null)
            {
                    return;
            }
            
            this._serviceStubs = new System.Collections.Generic.List<ServiceStub>();
            System.Collections.Generic.List<System.Type> val_2 = new System.Collections.Generic.List<System.Type>();
            val_2.AddRange(collection:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            List.Enumerator<T> val_4 = val_2.GetEnumerator();
            val_11 = 1152921518247890560;
            label_9:
            if(((-1002161160) & 1) == 0)
            {
                goto label_8;
            }
            
            this.ScanType(type:  0.emailUIDataHandler);
            goto label_9;
            label_8:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520784555000});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected object AutoCreateService(System.Type t)
        {
            var val_3;
            var val_14;
            System.Type val_15;
            object val_16;
            System.Collections.Generic.List<System.String> val_17;
            val_15 = t;
            this.UpdateStubs();
            List.Enumerator<T> val_1 = this._serviceStubs.GetEnumerator();
            label_6:
            if(((-1001966208) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if((System.Type.op_Inequality(left:  val_4._serverGameUIDataModel, right:  val_15)) == true)
            {
                goto label_6;
            }
            
            if(val_4._masterDomain == null)
            {
                goto label_7;
            }
            
            val_16 = val_4._masterDomain.Invoke();
            goto label_8;
            label_2:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520784749952});
            goto label_31;
            label_7:
            val_17 = val_4._emailIdsToBeDeletedOnServer;
            if((System.Type.op_Equality(left:  val_17, right:  0)) != false)
            {
                    val_17 = val_4._emailDatas.Invoke();
            }
            
            val_16 = SRF.Service.SRServiceManager.DefaultServiceConstructor(serviceIntType:  val_15, implType:  val_17);
            label_8:
            val_14 = 1152921505142521856;
            if((SRF.Service.SRServiceManager.HasService(t:  val_15)) == true)
            {
                    return (object)val_16;
            }
            
            SRF.Service.SRServiceManager.RegisterService(t:  val_15, service:  val_16);
            return (object)val_16;
            label_31:
            val_16 = 0;
            return (object)val_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnApplicationQuit()
        {
            null = null;
            SRF.Service.SRServiceManager._hasQuit = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object DefaultServiceConstructor(System.Type serviceIntType, System.Type implType)
        {
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((val_7 & 1) != 0)
            {
                    val_7 = "_S_" + serviceIntType;
                UnityEngine.Component val_4 = new UnityEngine.GameObject(name:  val_7).AddComponent(componentType:  implType);
                return (object)UnityEngine.ScriptableObject.CreateInstance(type:  implType);
            }
            
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                    return System.Activator.CreateInstance(type:  implType);
            }
            
            return (object)UnityEngine.ScriptableObject.CreateInstance(type:  implType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ScanType(System.Type type)
        {
            if((SRF.Helpers.SRReflection.GetAttribute<SRF.Service.ServiceAttribute>(t:  type)) != null)
            {
                    .Type = type;
                .InterfaceType = val_1.<ServiceType>k__BackingField;
                this._serviceStubs.Add(item:  new SRServiceManager.ServiceStub());
            }
            
            SRF.Service.SRServiceManager.ScanTypeForConstructors(t:  type, stubs:  this._serviceStubs);
            SRF.Service.SRServiceManager.ScanTypeForSelectors(t:  type, stubs:  this._serviceStubs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ScanTypeForSelectors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
        {
            System.Collections.Generic.List<ServiceStub> val_14;
            var val_15;
            object val_16;
            var val_17;
            var val_18;
            string val_19;
            val_15 = 0;
            goto label_4;
            label_50:
            SRServiceManager.<>c__DisplayClass24_0 val_1 = null;
            val_16 = val_1;
            val_1 = new SRServiceManager.<>c__DisplayClass24_0();
            SRF.Service.ServiceSelectorAttribute val_2 = SRF.Helpers.SRReflection.GetAttribute<SRF.Service.ServiceSelectorAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg);
            if(val_16 == null)
            {
                goto label_6;
            }
            
            val_14 = val_16;
            .attrib = val_2;
            if(val_2 == null)
            {
                goto label_40;
            }
            
            label_16:
            if((System.Type.op_Inequality(left:  System.Type.__il2cppRuntimeField_byval_arg, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_11;
            }
            
            val_16 = new object[2];
            if(val_16 == null)
            {
                goto label_13;
            }
            
            if(t != null)
            {
                goto label_14;
            }
            
            goto label_25;
            label_6:
            mem[16] = val_2;
            val_14 = 16;
            if(mem[16] != 0)
            {
                goto label_16;
            }
            
            goto label_40;
            label_11:
            object[] val_6 = new object[2];
            val_16 = val_6;
            if(val_16 == null)
            {
                goto label_21;
            }
            
            if(t != null)
            {
                goto label_22;
            }
            
            goto label_42;
            label_13:
            if(t == null)
            {
                goto label_25;
            }
            
            label_14:
            if(t == null)
            {
                    val_17 = 0;
            }
            
            label_25:
            if(val_5.Length == 0)
            {
                    val_17 = 0;
            }
            
            val_16[0] = t;
            val_16[1] = System.Type.__il2cppRuntimeField_byval_arg;
            val_19 = "ServiceSelector must have return type of Type ({0}.{1}())";
            goto label_30;
            label_21:
            if(t == null)
            {
                goto label_42;
            }
            
            label_22:
            if(t == null)
            {
                    val_18 = 0;
            }
            
            label_42:
            if(val_6.Length == 0)
            {
                    val_18 = 0;
            }
            
            val_16[0] = t;
            val_16[1] = System.Type.__il2cppRuntimeField_byval_arg;
            val_19 = "ServiceSelector must have no parameters ({0}.{1}())";
            label_30:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  val_19, args:  val_6));
            label_40:
            val_15 = 1;
            label_4:
            if(val_15 < null)
            {
                goto label_50;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ScanTypeForConstructors(System.Type t, System.Collections.Generic.List<SRF.Service.SRServiceManager.ServiceStub> stubs)
        {
            SRF.Service.ServiceConstructorAttribute val_11;
            var val_12;
            object val_13;
            System.Type val_14;
            var val_15;
            var val_16;
            string val_17;
            System.Object[] val_18;
            val_12 = 0;
            goto label_49;
            label_57:
            SRServiceManager.<>c__DisplayClass25_0 val_1 = null;
            val_13 = val_1;
            val_1 = new SRServiceManager.<>c__DisplayClass25_0();
            SRF.Service.ServiceConstructorAttribute val_2 = SRF.Helpers.SRReflection.GetAttribute<SRF.Service.ServiceConstructorAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg);
            if(val_13 == null)
            {
                goto label_6;
            }
            
            val_11 = val_13;
            .attrib = val_2;
            if(val_2 == null)
            {
                goto label_40;
            }
            
            label_18:
            val_14 = mem[val_2 + 16];
            val_14 = val_2.<ServiceType>k__BackingField;
            if((System.Type.op_Inequality(left:  System.Type.__il2cppRuntimeField_byval_arg, right:  val_14)) == false)
            {
                goto label_13;
            }
            
            object[] val_4 = new object[3];
            val_14 = t;
            if(val_4 == null)
            {
                goto label_15;
            }
            
            if(val_14 != null)
            {
                goto label_16;
            }
            
            goto label_27;
            label_6:
            mem[16] = val_2;
            val_11 = 16;
            if(mem[16] != 0)
            {
                goto label_18;
            }
            
            goto label_40;
            label_13:
            object[] val_5 = new object[2];
            val_13 = val_5;
            if(val_13 == null)
            {
                goto label_23;
            }
            
            if(t != null)
            {
                goto label_24;
            }
            
            goto label_42;
            label_15:
            if(val_14 == null)
            {
                goto label_27;
            }
            
            label_16:
            if(val_14 == null)
            {
                    val_15 = 0;
            }
            
            label_27:
            if(val_4.Length == 0)
            {
                    val_15 = 0;
            }
            
            val_4[0] = val_14;
            val_4[1] = System.Type.__il2cppRuntimeField_byval_arg;
            val_11 = .attrib;
            val_4[2] = val_2.<ServiceType>k__BackingField;
            val_17 = "ServiceConstructor must have return type of {2} ({0}.{1}())";
            val_18 = val_4;
            goto label_37;
            label_23:
            if(t == null)
            {
                goto label_42;
            }
            
            label_24:
            if(t == null)
            {
                    val_16 = 0;
            }
            
            label_42:
            if(val_5.Length == 0)
            {
                    val_16 = 0;
            }
            
            val_13[0] = t;
            val_13[1] = System.Type.__il2cppRuntimeField_byval_arg;
            val_17 = "ServiceConstructor must have no parameters ({0}.{1}())";
            val_18 = val_13;
            label_37:
            UnityEngine.Debug.LogError(message:  System.String.Format(format:  val_17, args:  val_5));
            label_40:
            val_12 = 1;
            label_49:
            if(val_12 < null)
            {
                goto label_57;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Reflection.MethodInfo[] GetStaticMethods(System.Type t)
        {
            if(t == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRServiceManager()
        {
            this._services = new SRF.SRList<Service>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SRServiceManager()
        {
        
        }
    
    }

}
