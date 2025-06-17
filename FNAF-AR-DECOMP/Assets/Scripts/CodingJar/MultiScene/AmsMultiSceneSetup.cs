using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AmsMultiSceneSetup : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isMainScene;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<CodingJar.MultiScene.AmsMultiSceneSetup.SceneEntry> _sceneSetup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _thisScenePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<CodingJar.MultiScene.AmsMultiSceneSetup.SceneEntry> _bakedScenesMerged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> OnAwake;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> OnStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> OnDestroyed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<CodingJar.MultiScene.AmsMultiSceneSetup.SceneEntry> GetSceneSetup()
        {
            if(this._sceneSetup != null)
            {
                    return this._sceneSetup.AsReadOnly();
            }
            
            return this._sceneSetup.AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            object[] val_1 = new object[4];
            val_1[0] = this.GetType();
            UnityEngine.SceneManagement.Scene val_4 = this.gameObject.scene;
            val_1[1] = val_4.m_Handle.name;
            UnityEngine.SceneManagement.Scene val_7 = this.gameObject.scene;
            val_1[2] = val_7.m_Handle.isLoaded;
            val_1[3] = UnityEngine.Time.frameCount;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "{0}.Awake() (Scene {1}). IsLoaded: {2}. Frame: {3}", parms:  val_1);
            if(CodingJar.MultiScene.AmsMultiSceneSetup.OnAwake != null)
            {
                    CodingJar.MultiScene.AmsMultiSceneSetup.OnAwake.Invoke(obj:  this);
            }
            
            if(this._isMainScene == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.SceneManagement.Scene val_13 = this.gameObject.scene;
                if(val_13.m_Handle.isLoaded != true)
            {
                    if(UnityEngine.Time.frameCount < 2)
            {
                    return;
            }
            
            }
            
            }
            
            if(this._isMainScene == false)
            {
                    return;
            }
            
            this.LoadSceneSetupAtRuntime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed == null)
            {
                    return;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            object[] val_1 = new object[3];
            System.Type val_2 = this.GetType();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            UnityEngine.SceneManagement.Scene val_4 = this.gameObject.scene;
            val_1[1] = val_4.m_Handle.name;
            val_1[2] = UnityEngine.Time.frameCount;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "{0}.Start() Scene: {1}. Frame: {2}", parms:  val_1);
            if(CodingJar.MultiScene.AmsMultiSceneSetup.OnStart != null)
            {
                    CodingJar.MultiScene.AmsMultiSceneSetup.OnStart.Invoke(obj:  this);
            }
            
            if(this._isMainScene == false)
            {
                    return;
            }
            
            this.LoadSceneSetupAtRuntime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSceneSetup()
        {
            if(this._isMainScene == false)
            {
                    return;
            }
            
            this.LoadSceneSetupAtRuntime();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSceneSetupAtRuntime()
        {
            var val_6 = this;
            List.Enumerator<T> val_2 = new System.Collections.Generic.List<SceneEntry>(collection:  this._sceneSetup).GetEnumerator();
            label_3:
            if(((-1665817256) & 1) == 0)
            {
                goto label_2;
            }
            
            this.LoadEntryAtRuntime(entry:  0.emailUIDataHandler);
            goto label_3;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520120898904});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadEntryAtRuntime(CodingJar.MultiScene.AmsMultiSceneSetup.SceneEntry entry)
        {
            if(entry.loadMethod == 3)
            {
                    return;
            }
            
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneByPath(scenePath:  entry.scene.emailUIDataHandler);
            if(val_2.m_Handle.IsValid() != true)
            {
                    UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetSceneByPath(scenePath:  entry.scene);
            }
            
            if(val_4.m_Handle.IsValid() == true)
            {
                    return;
            }
            
            if(entry.loadMethod != 1)
            {
                    if(entry.loadMethod != 2)
            {
                    return;
            }
            
                object[] val_6 = new object[2];
                val_6[0] = null;
                UnityEngine.SceneManagement.Scene val_8 = this.gameObject.scene;
                val_6[1] = val_8.m_Handle.name;
                CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "Loading {0} Asynchronously from {1}", parms:  val_6);
                entry.<asyncOp>k__BackingField = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  entry.scene, mode:  1);
                return;
            }
            
            object[] val_11 = new object[2];
            entry = val_11;
            entry[0] = null;
            UnityEngine.SceneManagement.Scene val_13 = this.gameObject.scene;
            entry[1] = val_13.m_Handle.name;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "Loading {0} from {1}", parms:  val_11);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  entry.scene, mode:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.SceneManagement.Scene val_3 = this.gameObject.scene;
            int val_4 = val_1.m_Handle & 4294967295;
            val_4 = UnityEngine.SceneManagement.Scene.op_Equality(lhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_4}, rhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_3.m_Handle & 4294967295});
            this._isMainScene = val_4;
            this.transform.SetAsFirstSibling();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAfterDeserialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeforeSerialize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsMultiSceneSetup()
        {
            this._sceneSetup = new System.Collections.Generic.List<SceneEntry>();
            this._bakedScenesMerged = new System.Collections.Generic.List<SceneEntry>();
        }
    
    }

}
