using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class AmsCrossSceneReferences : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int CurrentSerializedVersion = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _version;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference> _crossSceneReferences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _realSceneRootsForPostBuild;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<AmsSceneReference> _mergedScenes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<AmsSceneReference, AmsSceneReference> _activeMergedScenes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference> _referencesToResolve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Action<CodingJar.MultiScene.RuntimeCrossSceneReference> CrossSceneReferenceRestored;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_CrossSceneReferenceRestored(System.Action<CodingJar.MultiScene.RuntimeCrossSceneReference> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored != 1152921505136668680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_CrossSceneReferenceRestored(System.Action<CodingJar.MultiScene.RuntimeCrossSceneReference> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored != 1152921505136668680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static CodingJar.MultiScene.AmsCrossSceneReferences GetSceneSingleton(UnityEngine.SceneManagement.Scene scene, bool bCreateIfNotFound)
        {
            UnityEngine.Object val_10;
            bool val_11;
            var val_12;
            val_11 = bCreateIfNotFound;
            bCreateIfNotFound = val_11;
            CodingJar.MultiScene.AmsMultiSceneSetup val_2 = CodingJar.GameObjectEx.GetSceneSingleton<CodingJar.MultiScene.AmsMultiSceneSetup>(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = scene.m_Handle & 4294967295}, bCreate:  bCreateIfNotFound);
            val_12 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                    return (CodingJar.MultiScene.AmsCrossSceneReferences)val_11.AddComponent<CodingJar.MultiScene.AmsCrossSceneReferences>();
            }
            
            val_10 = val_2.gameObject.GetComponent<CodingJar.MultiScene.AmsCrossSceneReferences>();
            bool val_6 = UnityEngine.Object.op_Implicit(exists:  val_10);
            var val_7 = (val_6 != true) ? (val_10) : 0;
            if(val_6 == true)
            {
                    return (CodingJar.MultiScene.AmsCrossSceneReferences)val_11.AddComponent<CodingJar.MultiScene.AmsCrossSceneReferences>();
            }
            
            if(val_11 == false)
            {
                    return (CodingJar.MultiScene.AmsCrossSceneReferences)val_11.AddComponent<CodingJar.MultiScene.AmsCrossSceneReferences>();
            }
            
            val_11 = val_2.gameObject;
            return (CodingJar.MultiScene.AmsCrossSceneReferences)val_11.AddComponent<CodingJar.MultiScene.AmsCrossSceneReferences>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddReference(CodingJar.MultiScene.RuntimeCrossSceneReference reference)
        {
            var val_3;
            int val_2 = this._crossSceneReferences.FindIndex(match:  new System.Predicate<CodingJar.MultiScene.RuntimeCrossSceneReference>(object:  null, method:  public System.Boolean CodingJar.MultiScene.RuntimeCrossSceneReference::IsSameSource(CodingJar.MultiScene.RuntimeCrossSceneReference other)));
            if((val_2 & 2147483648) == 0)
            {
                    val_3 = public System.Void System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference>::set_Item(int index, CodingJar.MultiScene.RuntimeCrossSceneReference value);
                this._crossSceneReferences.set_Item(index:  val_2, value:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
                return;
            }
            
            val_3 = public System.Void System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference>::Add(CodingJar.MultiScene.RuntimeCrossSceneReference item);
            this._crossSceneReferences.Add(item:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetCrossSceneReferences(UnityEngine.SceneManagement.Scene toScene)
        {
            .toScene = toScene;
            int val_3 = this._crossSceneReferences.RemoveAll(match:  new System.Predicate<CodingJar.MultiScene.RuntimeCrossSceneReference>(object:  new AmsCrossSceneReferences.<>c__DisplayClass12_0(), method:  System.Boolean AmsCrossSceneReferences.<>c__DisplayClass12_0::<ResetCrossSceneReferences>b__0(CodingJar.MultiScene.RuntimeCrossSceneReference x)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            string val_31;
            string val_32;
            string val_35;
            var val_36;
            object[] val_1 = new object[6];
            val_1[0] = this.GetType();
            UnityEngine.SceneManagement.Scene val_4 = this.gameObject.scene;
            val_1[1] = val_4.m_Handle.name;
            UnityEngine.SceneManagement.Scene val_7 = this.gameObject.scene;
            bool val_9 = val_7.m_Handle.isLoaded;
            val_1[2] = val_9;
            UnityEngine.SceneManagement.Scene val_11 = this.gameObject.scene;
            val_1[3] = val_11.m_Handle.path;
            val_1[4] = UnityEngine.Time.frameCount;
            UnityEngine.SceneManagement.Scene val_15 = this.gameObject.scene;
            val_1[5] = val_15.m_Handle.rootCount;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "{0}.Awake() Scene: {1}. IsLoaded: {2}. Path: {3}. Frame: {4}. Root Count: {5}", parms:  val_1);
            if(this._version <= 1)
            {
                    int val_17 = this._crossSceneReferences.Count;
                this.ConditionalResolveReferences(references:  this._crossSceneReferences);
                object[] val_19 = new object[2];
                val_19[0] = this.name;
                if(val_17 == this._crossSceneReferences.Count)
            {
                    UnityEngine.SceneManagement.Scene val_22 = this.gameObject.scene;
                val_19[1] = val_22.m_Handle.name;
                val_35 = "{0} needs upgrading.  Please resave {1}";
            }
            else
            {
                    val_19[1] = val_17 - this._crossSceneReferences.Count;
                val_35 = "{0} was upgraded. {1} cross-scene references will be re-created on next save.";
            }
            
                CodingJar.MultiScene.AmsDebug.LogWarning(context:  this, message:  val_35, parms:  val_19);
            }
            
            UnityEngine.SceneManagement.Scene val_27 = this.gameObject.scene;
            int val_28 = val_27.m_Handle & 4294967295;
            List.Enumerator<T> val_29 = this._mergedScenes.GetEnumerator();
            label_48:
            if(((-1671751600) & 1) == 0)
            {
                goto label_44;
            }
            
            val_36 = null;
            val_36 = null;
            val_31 = val_32;
            CodingJar.MultiScene.AmsCrossSceneReferences._activeMergedScenes.Add(key:  new AmsSceneReference() {editorAssetGUID = val_9, _path = val_31}, value:  new AmsSceneReference());
            goto label_48;
            label_44:
            long val_33 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520114964560});
            this._referencesToResolve.Clear();
            this._referencesToResolve.AddRange(collection:  this._crossSceneReferences);
            this.ConditionalResolveReferences(references:  this._referencesToResolve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_26;
            var val_27;
            var val_28;
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_29;
            var val_30;
            var val_31;
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_32;
            var val_33;
            var val_34;
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_35;
            object[] val_1 = new object[6];
            val_1[0] = this.GetType();
            UnityEngine.SceneManagement.Scene val_4 = this.gameObject.scene;
            val_1[1] = val_4.m_Handle.name;
            UnityEngine.SceneManagement.Scene val_7 = this.gameObject.scene;
            val_1[2] = val_7.m_Handle.isLoaded;
            UnityEngine.SceneManagement.Scene val_11 = this.gameObject.scene;
            val_1[3] = val_11.m_Handle.path;
            val_1[4] = UnityEngine.Time.frameCount;
            UnityEngine.SceneManagement.Scene val_15 = this.gameObject.scene;
            val_1[5] = val_15.m_Handle.rootCount;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "{0}.Start() Scene: {1}. IsLoaded: {2}. Path: {3}. Frame: {4}. Root Count: {5}", parms:  val_1);
            this.PerformPostBuildCleanup();
            this.ConditionalResolveReferences(references:  this._referencesToResolve);
            val_27 = null;
            val_28 = null;
            if(((System.Delegate.Remove(source:  CodingJar.MultiScene.AmsMultiSceneSetup.OnStart, value:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleNewSceneLoaded(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != val_28))
            {
                    val_27 = null;
                val_28 = null;
                val_26 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnStart = val_26;
            val_30 = null;
            val_31 = null;
            if(((System.Delegate.Combine(a:  CodingJar.MultiScene.AmsMultiSceneSetup.OnStart, b:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleNewSceneLoaded(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != val_31))
            {
                    val_30 = null;
                val_31 = null;
                val_29 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnStart = val_29;
            val_33 = null;
            val_34 = null;
            if(((System.Delegate.Remove(source:  CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed, value:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleSceneDestroyed(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != val_34))
            {
                    val_33 = null;
                val_34 = null;
                val_32 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed = val_32;
            if(((System.Delegate.Combine(a:  CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed, b:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleSceneDestroyed(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != null))
            {
                    val_35 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed = val_35;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            string val_3;
            string val_8;
            string val_9;
            string val_10;
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_14;
            var val_15;
            var val_16;
            System.Action<CodingJar.MultiScene.AmsMultiSceneSetup> val_17;
            System.Collections.Generic.List<AmsSceneReference> val_18;
            var val_19;
            val_15 = null;
            val_16 = null;
            if(((System.Delegate.Remove(source:  CodingJar.MultiScene.AmsMultiSceneSetup.OnStart, value:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleNewSceneLoaded(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != val_16))
            {
                    val_15 = null;
                val_16 = null;
                val_14 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnStart = val_14;
            if(((System.Delegate.Remove(source:  CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed, value:  new System.Action<CodingJar.MultiScene.AmsMultiSceneSetup>(object:  this, method:  System.Void CodingJar.MultiScene.AmsCrossSceneReferences::HandleSceneDestroyed(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)))) != null) && (null != null))
            {
                    val_17 = 0;
            }
            
            CodingJar.MultiScene.AmsMultiSceneSetup.OnDestroyed = val_17;
            val_18 = this._mergedScenes;
            List.Enumerator<T> val_6 = val_18.GetEnumerator();
            label_10:
            if(((-1671224016) & 1) == 0)
            {
                goto label_6;
            }
            
            val_19 = null;
            val_19 = null;
            val_8 = val_9;
            val_3 = val_10;
            bool val_11 = CodingJar.MultiScene.AmsCrossSceneReferences._activeMergedScenes.Remove(key:  new AmsSceneReference() {editorAssetGUID = val_3, name = val_3, _path = val_8});
            goto label_10;
            label_6:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520115492144});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleNewSceneLoaded(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)
        {
            object val_22;
            System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference> val_23;
            UnityEngine.SceneManagement.Scene val_2 = sceneSetup.gameObject.scene;
            if(val_2.m_Handle.isLoaded != true)
            {
                    object[] val_4 = new object[2];
                val_4[0] = this.GetType();
                val_4[1] = val_2.m_Handle.name;
                UnityEngine.Debug.LogErrorFormat(context:  this, format:  "{0} Received HandleNewSceneLoaded from scene {1} which isn\'t considered loaded.  The scene MUST be considered loaded by this point", args:  val_4);
            }
            
            val_22 = 0;
            goto label_14;
            label_31:
            CodingJar.MultiScene.RuntimeCrossSceneReference val_7 = this._crossSceneReferences.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                goto label_18;
            }
            
            if(((this._referencesToResolve.Contains(item:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()})) == true) || ((UnityEngine.SceneManagement.Scene.op_Equality(lhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = -1670937216}, rhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_2.m_Handle})) == false))
            {
                goto label_23;
            }
            
            this._referencesToResolve.Add(item:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            goto label_23;
            label_18:
            object[] val_13 = new object[1];
            if(val_13 == null)
            {
                goto label_24;
            }
            
            if(val_22 != 0)
            {
                goto label_25;
            }
            
            goto label_28;
            label_24:
            if(val_22 == 0)
            {
                goto label_28;
            }
            
            label_25:
            label_28:
            val_13[0] = val_22;
            CodingJar.MultiScene.AmsDebug.LogWarning(context:  this, message:  "xRef Index {0} had Null source (probably stale), Consider removing (via right-click on entry)", parms:  val_13);
            label_23:
            val_22 = 1;
            label_14:
            val_23 = this._crossSceneReferences;
            if(val_22 < val_23.Count)
            {
                goto label_31;
            }
            
            if(this._referencesToResolve.Count < 1)
            {
                    return;
            }
            
            object[] val_16 = new object[3];
            val_16[0] = val_2.m_Handle.name;
            val_16[1] = this._referencesToResolve.Count;
            UnityEngine.SceneManagement.Scene val_20 = this.gameObject.scene;
            val_23 = val_20.m_Handle.name;
            val_16[2] = val_23;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "Scene {0} Loaded. {1} Cross-Scene References (in total) from Cross-Scene Manager in {2} are queued for resolve.", parms:  val_16);
            this.ConditionalResolveReferences(references:  this._referencesToResolve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleSceneDestroyed(CodingJar.MultiScene.AmsMultiSceneSetup sceneSetup)
        {
            int val_13;
            AmsCrossSceneReferences.<>c__DisplayClass17_0 val_1 = new AmsCrossSceneReferences.<>c__DisplayClass17_0();
            UnityEngine.SceneManagement.Scene val_3 = sceneSetup.gameObject.scene;
            if(val_1 != null)
            {
                    val_13 = val_1;
                .destroyedScene = val_3;
            }
            else
            {
                    val_13 = 16;
                mem[16] = val_3.m_Handle;
            }
            
            if(mem[16].IsValid() == false)
            {
                    return;
            }
            
            val_13 = mem[16];
            UnityEngine.SceneManagement.Scene val_6 = this.gameObject.scene;
            if((UnityEngine.SceneManagement.Scene.op_Equality(lhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_13}, rhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_6.m_Handle & 4294967295})) != false)
            {
                    return;
            }
            
            int val_10 = this._referencesToResolve.RemoveAll(match:  new System.Predicate<CodingJar.MultiScene.RuntimeCrossSceneReference>(object:  val_1, method:  System.Boolean AmsCrossSceneReferences.<>c__DisplayClass17_0::<HandleSceneDestroyed>b__0(CodingJar.MultiScene.RuntimeCrossSceneReference x)));
            this._referencesToResolve.AddRange(collection:  System.Linq.Enumerable.Where<CodingJar.MultiScene.RuntimeCrossSceneReference>(source:  this._crossSceneReferences, predicate:  new System.Func<CodingJar.MultiScene.RuntimeCrossSceneReference, System.Boolean>(object:  val_1, method:  System.Boolean AmsCrossSceneReferences.<>c__DisplayClass17_0::<HandleSceneDestroyed>b__1(CodingJar.MultiScene.RuntimeCrossSceneReference x))));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator CoWaitForSceneLoadThenResolveReferences(UnityEngine.SceneManagement.Scene scene)
        {
            AmsCrossSceneReferences.<CoWaitForSceneLoadThenResolveReferences>d__18 val_1 = new AmsCrossSceneReferences.<CoWaitForSceneLoadThenResolveReferences>d__18();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .scene = scene;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResolvePendingCrossSceneReferences()
        {
            this.ConditionalResolveReferences(references:  this._referencesToResolve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RetryAllResolves()
        {
            this._referencesToResolve.Clear();
            this._referencesToResolve.AddRange(collection:  this._crossSceneReferences);
            this.ConditionalResolveReferences(references:  this._referencesToResolve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConditionalResolveReferences(System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference> references)
        {
            string val_13;
            string val_14;
            int val_29;
            int val_31;
            var val_32;
            var val_33;
            UnityEngine.SceneManagement.Scene val_2 = this.gameObject.scene;
            val_29 = references.Count - 1;
            if((val_29 & 2147483648) != 0)
            {
                    return;
            }
            
            label_113:
            CodingJar.MultiScene.RuntimeCrossSceneReference val_11 = references.Item[val_29];
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                goto label_56;
            }
            
            if(val_14.IsValid() != true)
            {
                    val_32 = null;
                val_32 = null;
                if((CodingJar.MultiScene.AmsCrossSceneReferences._activeMergedScenes.TryGetValue(key:  new AmsSceneReference() {editorAssetGUID = val_14, name = val_14, _path = val_13}, value: out  new AmsSceneReference())) != false)
            {
                    object[] val_17 = new object[3];
                val_17[0] = val_14;
                val_17[1] = val_14;
                val_17[2] = 0;
                CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "Redirecting cross scene reference {0} from original target scene {1} to scene {2}", parms:  val_17);
                val_13 = 0;
                val_14 = 0;
            }
            
            }
            
            object[] val_18 = new object[5];
            val_18[0] = this.GetType();
            val_18[1] = val_2.m_Handle.name;
            val_18[2] = val_14;
            val_18[3] = val_2.m_Handle.isLoaded;
            val_31 = 0.isLoaded;
            val_18[4] = val_31;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "{0}.ConditionalResolveReferences() Scene: {1}. xRef: {2}. fromSceneLoaded: {3}. toSceneLoaded: {4}.", parms:  val_18);
            if(0.isLoaded == false)
            {
                goto label_103;
            }
            
            references.RemoveAt(index:  val_29);
            object[] val_26 = new object[1];
            val_31 = val_14;
            val_26[0] = val_31;
            CodingJar.MultiScene.AmsDebug.Log(context:  this, message:  "Restoring Cross-Scene Reference {0}", parms:  val_26);
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver.Resolve(xRef:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            val_33 = null;
            val_33 = null;
            if(CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored == null)
            {
                goto label_103;
            }
            
            val_31 = public System.Void System.Action<CodingJar.MultiScene.RuntimeCrossSceneReference>::Invoke(CodingJar.MultiScene.RuntimeCrossSceneReference obj);
            CodingJar.MultiScene.AmsCrossSceneReferences.CrossSceneReferenceRestored.Invoke(obj:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            goto label_103;
            label_56:
            object[] val_27 = new object[2];
            if(val_27 == null)
            {
                goto label_104;
            }
            
            if(val_29 != 0)
            {
                goto label_105;
            }
            
            goto label_108;
            label_104:
            if(val_29 == 0)
            {
                goto label_108;
            }
            
            label_105:
            label_108:
            val_27[0] = val_29;
            val_31 = val_14;
            val_27[1] = val_31;
            CodingJar.MultiScene.AmsDebug.LogWarning(context:  this, message:  "Missing Source Object for xRef at (possible index) {0}: {1}", parms:  val_27);
            label_103:
            val_29 = val_29 - 1;
            if((val_29 & 2147483648) == 0)
            {
                goto label_113;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PerformPostBuildCleanup()
        {
            UnityEngine.Object val_12;
            var val_13;
            val_12 = this;
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == true)
            {
                    return;
            }
            
            if(this._realSceneRootsForPostBuild.Count < 1)
            {
                    return;
            }
            
            UnityEngine.SceneManagement.Scene val_5 = this.gameObject.scene;
            val_13 = 0;
            goto label_6;
            label_24:
            if((this._realSceneRootsForPostBuild.Contains(item:  ???)) == true)
            {
                goto label_9;
            }
            
            object[] val_7 = new object[2];
            UnityEngine.SceneManagement.Scene val_9 = this.gameObject.scene;
            string val_10 = val_9.m_Handle.name;
            if(val_7 == null)
            {
                goto label_11;
            }
            
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_10 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_7[0] = val_10;
            val_7[1] = ???.name;
            CodingJar.MultiScene.AmsDebug.LogWarning(context:  this, message:  "Destroying \'{0}/{1}\' since we\'ve determined it\'s a temporary for a cross-scene reference", parms:  val_7);
            UnityEngine.Object.DestroyImmediate(obj:  ???);
            label_9:
            val_13 = 1;
            label_6:
            if(val_13 < (???))
            {
                goto label_24;
            }
            
            val_12 = this._realSceneRootsForPostBuild;
            val_12.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsCrossSceneReferences()
        {
            this._version = 2;
            this._crossSceneReferences = new System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference>();
            this._realSceneRootsForPostBuild = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._mergedScenes = new System.Collections.Generic.List<AmsSceneReference>();
            this._referencesToResolve = new System.Collections.Generic.List<CodingJar.MultiScene.RuntimeCrossSceneReference>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AmsCrossSceneReferences()
        {
            CodingJar.MultiScene.AmsCrossSceneReferences._activeMergedScenes = new System.Collections.Generic.Dictionary<AmsSceneReference, AmsSceneReference>();
        }
    
    }

}
