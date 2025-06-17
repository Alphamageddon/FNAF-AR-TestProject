using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct UniqueObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int CurrentSerializedVersion = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsSceneReference scene;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string fullPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string componentName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int componentIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int editorLocalId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string editorPrefabRelativePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int version;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<UnityEngine.Component> _reusableComponentsList;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Nullable<UnityEngine.SceneManagement.Scene> _dontDestroyOnLoadScene;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UniqueObject(UnityEngine.Component component)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.SceneManagement.Scene GetDontDestroyOnLoadScene()
        {
            UnityEngine.Object val_4;
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if((1152921505137414152 & 1) == 0)
            {
                    UnityEngine.GameObject val_1 = null;
                val_4 = val_1;
                val_1 = new UnityEngine.GameObject(name:  "AMS-DontDestroyOnLoad-Finder");
                UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
                UnityEngine.SceneManagement.Scene val_2 = val_1.scene;
                int val_3 = val_2.m_Handle & 4294967295;
                val_6 = null;
                val_6 = null;
                CodingJar.MultiScene.UniqueObject._dontDestroyOnLoadScene = 0;
                UnityEngine.Object.DestroyImmediate(obj:  val_1);
            }
            
            val_7 = null;
            val_7 = null;
            return (UnityEngine.SceneManagement.Scene)530567176;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object RuntimeResolve()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object Resolve()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UniqueObject()
        {
            CodingJar.MultiScene.UniqueObject._reusableComponentsList = new System.Collections.Generic.List<UnityEngine.Component>();
            CodingJar.MultiScene.UniqueObject._dontDestroyOnLoadScene = 0;
        }
    
    }

}
