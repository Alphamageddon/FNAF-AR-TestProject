using UnityEngine;

namespace CodingJar
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GameObjectEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<UnityEngine.GameObject> s_GameObjects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetFullName(UnityEngine.GameObject gameObj)
        {
            return CodingJar.TransformEx.FullPath(transform:  gameObj.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.GameObject CreateGameObjectInScene(string name, UnityEngine.SceneManagement.Scene scene)
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            bool val_3 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = scene.m_Handle & 4294967295});
            bool val_6 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle & 4294967295});
            return (UnityEngine.GameObject)new UnityEngine.GameObject(name:  name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetSceneSingleton<T>(UnityEngine.SceneManagement.Scene scene, bool bCreate)
        {
            string val_5;
            var val_6;
            UnityEngine.Object val_7;
            val_5;
            val_6 = 0;
            label_7:
            if(val_6 >= (???))
            {
                goto label_2;
            }
            
            val_7 = ???;
            val_6 = val_6 + 1;
            if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
            {
                goto label_7;
            }
            
            return (CodingJar.MultiScene.AmsMultiSceneSetup)val_7;
            label_2:
            if(bCreate != false)
            {
                    val_5 = "! "("! ") + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
                val_7 = CodingJar.GameObjectEx.CreateGameObjectInScene(name:  val_5, scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = scene.m_Handle});
                return (CodingJar.MultiScene.AmsMultiSceneSetup)val_7;
            }
            
            val_7 = 0;
            return (CodingJar.MultiScene.AmsMultiSceneSetup)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<UnityEngine.GameObject> GetRootObjectsEvenIfNotLoaded(UnityEngine.SceneManagement.Scene scene)
        {
            var val_5;
            System.Collections.Generic.List<UnityEngine.GameObject> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = CodingJar.GameObjectEx.s_GameObjects;
            val_6.Clear();
            if(scene.m_Handle.IsValid() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_6 = CodingJar.GameObjectEx.s_GameObjects;
                val_6.Capacity = UnityEngine.Mathf.Max(a:  val_6.Capacity, b:  scene.m_Handle.rootCount);
            }
            
            val_8 = null;
            val_8 = null;
            return (System.Collections.Generic.List<UnityEngine.GameObject>)CodingJar.GameObjectEx.s_GameObjects;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetRequiredComponent<T>(UnityEngine.GameObject gameObject)
        {
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) != false)
            {
                    return (object)gameObject;
            }
            
            if(gameObject == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.GameObject FindByAbsolutePath(string absolutePath)
        {
            UnityEngine.Object val_7;
            if(UnityEngine.SceneManagement.SceneManager.sceneCount >= 1)
            {
                    var val_7 = 0;
                do
            {
                UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
                val_7 = CodingJar.GameObjectEx.FindBySceneAndPath(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_2.m_Handle & 4294967295}, absolutePath:  absolutePath);
                if((UnityEngine.Object.op_Implicit(exists:  val_7)) == true)
            {
                    return (UnityEngine.GameObject)val_7;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < UnityEngine.SceneManagement.SceneManager.sceneCount);
            
            }
            
            val_7 = 0;
            return (UnityEngine.GameObject)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.GameObject FindBySceneAndPath(UnityEngine.SceneManagement.Scene scene, string absolutePath)
        {
            var val_8;
            System.Char[] val_21;
            var val_22;
            UnityEngine.Object val_23;
            var val_24;
            char[] val_1 = new char[1];
            val_21 = val_1;
            val_21[0] = '/';
            val_22 = absolutePath.Split(separator:  val_1);
            if(val_2.Length < 1)
            {
                goto label_35;
            }
            
            if(val_2.Length == 1)
            {
                    val_21 = new string[2];
                val_21[0] = "/";
                val_21[1] = val_22[0];
                val_22 = val_21;
            }
            
            List.Enumerator<T> val_6 = CodingJar.GameObjectEx.GetRootObjectsEvenIfNotLoaded(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = scene.m_Handle & 4294967295}).GetEnumerator();
            do
            {
                label_32:
                if(((-1676655344) & 1) == 0)
            {
                goto label_35;
            }
            
                GameUI.EmailUIDataHandler val_9 = val_8.emailUIDataHandler;
                val_21 = val_9.name;
            }
            while((System.String.op_Inequality(a:  val_21, b:  val_22[1])) == true);
            
            val_23 = val_9.transform;
            if(val_2.Length < 3)
            {
                goto label_26;
            }
            
            var val_24 = 6;
            label_29:
            if((UnityEngine.Object.op_Implicit(exists:  val_23)) == false)
            {
                goto label_26;
            }
            
            var val_14 = val_24 - 4;
            val_21 = val_22[2];
            val_23 = val_23.Find(n:  val_21);
            val_24 = val_24 + 1;
            if((val_24 - 3) < (long)val_2.Length)
            {
                goto label_29;
            }
            
            label_26:
            if((UnityEngine.Object.op_Implicit(exists:  val_23)) == false)
            {
                goto label_32;
            }
            
            val_24 = val_23.gameObject;
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921520110060816});
            return (UnityEngine.GameObject)val_24;
            label_35:
            val_24 = 0;
            return (UnityEngine.GameObject)val_24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GameObjectEx()
        {
            CodingJar.GameObjectEx.s_GameObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
