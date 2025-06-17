using UnityEngine;

namespace TapjoyUnity.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class TapjoyUnityInit : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool initialized;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            TapjoyUnity.TapjoyFunc<T1, TResult> val_8;
            var val_9;
            var val_11;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_13;
            var val_14;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_16;
            var val_17;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_19;
            var val_20;
            TapjoyUnity.TapjoyFunc<System.Int32> val_22;
            var val_23;
            TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> val_25;
            TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat> val_27;
            val_8 = 1152921505138262016;
            val_9 = null;
            val_9 = null;
            if(TapjoyUnity.Internal.TapjoyUnityInit.initialized == true)
            {
                    return;
            }
            
            TapjoyUnity.Internal.TapjoyUnityInit.initialized = true;
            TapjoyUnity.Internal.ApiBindingAndroid.Install();
            val_11 = null;
            val_11 = null;
            val_13 = TapjoyUnityInit.<>c.<>9__1_0;
            if(val_13 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = null;
                val_13 = val_1;
                val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::<Awake>b__1_0(UnityEngine.SceneManagement.Scene oldScene, UnityEngine.SceneManagement.Scene newScene));
                TapjoyUnityInit.<>c.<>9__1_0 = val_13;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  val_1);
            val_14 = null;
            val_14 = null;
            val_16 = TapjoyUnityInit.<>c.<>9__1_1;
            if(val_16 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = null;
                val_16 = val_2;
                val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::<Awake>b__1_1(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
                TapjoyUnityInit.<>c.<>9__1_1 = val_16;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  val_2);
            val_17 = null;
            val_17 = null;
            val_19 = TapjoyUnityInit.<>c.<>9__1_2;
            if(val_19 == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_3 = null;
                val_19 = val_3;
                val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TapjoyUnityInit.<>c::<Awake>b__1_2(UnityEngine.SceneManagement.Scene scene));
                TapjoyUnityInit.<>c.<>9__1_2 = val_19;
            }
            
            UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  val_3);
            val_20 = null;
            val_20 = null;
            val_22 = TapjoyUnityInit.<>c.<>9__1_3;
            if(val_22 == null)
            {
                    TapjoyUnity.TapjoyFunc<System.Int32> val_4 = null;
                val_22 = val_4;
                val_4 = new TapjoyUnity.TapjoyFunc<System.Int32>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TapjoyUnityInit.<>c::<Awake>b__1_3());
                TapjoyUnityInit.<>c.<>9__1_3 = val_22;
            }
            
            TapjoyUnity.Internal.UnityDependency.sceneCount = val_22;
            val_23 = null;
            val_23 = null;
            val_25 = TapjoyUnityInit.<>c.<>9__1_4;
            if(val_25 == null)
            {
                    TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> val_5 = null;
                val_25 = val_5;
                val_5 = new TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  TapjoyUnity.Internal.UnityCompat.SceneCompat TapjoyUnityInit.<>c::<Awake>b__1_4());
                val_23 = null;
                TapjoyUnityInit.<>c.<>9__1_4 = val_25;
            }
            
            TapjoyUnity.Internal.UnityDependency.GetActiveScene = val_25;
            val_23 = null;
            val_27 = TapjoyUnityInit.<>c.<>9__1_5;
            if(val_27 == null)
            {
                    TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat> val_6 = null;
                val_27 = val_6;
                val_6 = new TapjoyUnity.TapjoyFunc<System.Int32, TapjoyUnity.Internal.UnityCompat.SceneCompat>(object:  TapjoyUnityInit.<>c.__il2cppRuntimeField_static_fields, method:  TapjoyUnity.Internal.UnityCompat.SceneCompat TapjoyUnityInit.<>c::<Awake>b__1_5(int index));
                TapjoyUnityInit.<>c.<>9__1_5 = val_27;
            }
            
            TapjoyUnity.Internal.UnityDependency.GetSceneAt = val_27;
            TapjoyUnity.TapjoyFunc<System.Object, System.String> val_7 = null;
            val_8 = val_7;
            val_7 = new TapjoyUnity.TapjoyFunc<System.Object, System.String>(object:  0, method:  public static System.String UnityEngine.JsonUtility::ToJson(object obj));
            TapjoyUnity.Internal.UnityDependency.ToJson = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TapjoyUnity.Internal.UnityCompat.SceneCompat Wrap(UnityEngine.SceneManagement.Scene scene)
        {
            TapjoyUnity.Internal.UnityCompat.SceneCompat val_0;
            int val_2 = scene.m_Handle.buildIndex;
            string val_3 = scene.m_Handle.name;
            string val_4 = scene.m_Handle.path;
            bool val_5 = scene.m_Handle.IsValid();
            val_0._path = 0;
            mem[1152921520150415976] = 0;
            val_0._hashCode = 0;
            val_0._valid = false;
            val_0._buildIndex.HasValue = false;
            mem[1152921520150415958] = 0;
            val_0._name = 0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyUnityInit()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TapjoyUnityInit()
        {
        
        }
    
    }

}
