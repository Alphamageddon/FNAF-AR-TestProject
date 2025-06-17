using UnityEngine;

namespace Animatronics.Animatronic3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Animatronic3DPrefabLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Animatronics.Animatronic3d.Model.Animatronic3D> _completeCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Load(Systems.AssetManagement.Assets.IAssetCache assetCache, string bundleName, string prefabName, System.Action<Animatronics.Animatronic3d.Model.Animatronic3D> completeCallback)
        {
            this._completeCallback = completeCallback;
            System.Action<UnityEngine.GameObject> val_1 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DPrefabLoader::LoadSuccess(UnityEngine.GameObject gameObject));
            System.Action val_2 = new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.Animatronic3DPrefabLoader::LoadFailure());
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(assetCache, typeof(public System.Void Systems.AssetManagement.Assets.IAssetCache::LoadAssetAsync<UnityEngine.GameObject>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CancelLoad()
        {
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(UnityEngine.GameObject gameObject)
        {
            Animatronics.Animatronic3d.Model.Animatronic3D val_3;
            if(this._completeCallback != null)
            {
                    val_3 = 0;
                if(gameObject != 0)
            {
                    val_3 = gameObject.GetComponent<Animatronics.Animatronic3d.Model.Animatronic3D>();
            }
            
                if(this._completeCallback == null)
            {
                    return;
            }
            
                this._completeCallback.Invoke(obj:  val_3);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  gameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure()
        {
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke(obj:  0);
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronic3DPrefabLoader()
        {
        
        }
    
    }

}
