using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct RuntimeCrossSceneReference
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Object _sourceObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _sourceField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CodingJar.MultiScene.UniqueObject DEPRECATED_fromObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CodingJar.MultiScene.UniqueObject _toObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CodingJar.MultiScene.RuntimeCrossSceneReference.GenericDataBundle _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Object _toObjectCached;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object fromObject { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object toObject { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsSceneReference DEPRECATED_fromScene { set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sourceField { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<CodingJar.MultiScene.GenericData> data { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsSceneReference toScene { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RuntimeCrossSceneReference(UnityEngine.Object from, string fromField, CodingJar.MultiScene.UniqueObject to, System.Collections.Generic.List<CodingJar.MultiScene.GenericData> data)
        {
            mem[1152921520123127840] = 0;
            this._toObject = 0;
            mem[1152921520123127808] = 0;
            mem[1152921520123127824] = 0;
            this.DEPRECATED_fromObject = from;
            mem[1152921520123127800] = fromField;
            mem[1152921520123127904] = to.componentName;
            mem[1152921520123127888] = to.scene._path;
            this._data = to.editorPrefabRelativePath;
            mem[1152921520123127872] = to.scene.editorAssetGUID;
            mem[1152921520123127936] = data;
            mem[1152921520123127944] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object get_fromObject()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object get_toObject()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DEPRECATED_fromScene(AmsSceneReference value)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_sourceField()
        {
            return (string)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<CodingJar.MultiScene.GenericData> get_data()
        {
            return (System.Collections.Generic.List<CodingJar.MultiScene.GenericData>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AmsSceneReference get_toScene()
        {
            AmsSceneReference val_0;
            val_0._path = null;
            val_0.editorAssetGUID = null;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_toScene(AmsSceneReference value)
        {
            mem[1152921520124034400] = value._path;
            mem[1152921520124034384] = value.editorAssetGUID;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSameSource(CodingJar.MultiScene.RuntimeCrossSceneReference other)
        {
            CodingJar.MultiScene.UniqueObject val_1 = this.DEPRECATED_fromObject;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
    
    }

}
