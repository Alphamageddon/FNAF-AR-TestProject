using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleLoader : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CacheBundle(Systems.AssetManagement.Bundles.BundleState state, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure)
        {
            if(state != null)
            {
                    this.TryToLoadAssetBundle(state:  state, uri:  state.<LocalUri>k__BackingField, onSuccess:  onSuccess, onFailure:  onFailure);
            }
            else
            {
                    this.TryToLoadAssetBundle(state:  0, uri:  69077560, onSuccess:  onSuccess, onFailure:  onFailure);
            }
            
            state.RemoveBundleReference();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DownloadBundle(Systems.AssetManagement.Bundles.BundleState state, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure)
        {
            if(state != null)
            {
                    this.TryToLoadAssetBundle(state:  state, uri:  state.<ServerUri>k__BackingField, onSuccess:  onSuccess, onFailure:  onFailure);
            }
            else
            {
                    this.TryToLoadAssetBundle(state:  0, uri:  0, onSuccess:  onSuccess, onFailure:  onFailure);
            }
            
            state.RemoveBundleReference();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadBundle(Systems.AssetManagement.Bundles.BundleState state, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure)
        {
            this.TryToLoadAssetBundle(state:  state, uri:  state.<ServerUri>k__BackingField, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToLoadAssetBundle(Systems.AssetManagement.Bundles.BundleState state, string uri, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure)
        {
            bool val_1 = false;
            state.AddBundleReference(onSuccess:  onSuccess, onFailure:  onFailure, shouldLoad: out  val_1);
            if(val_1 == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  state.LoadAssetBundle(state:  state, uri:  uri));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator LoadAssetBundle(Systems.AssetManagement.Bundles.BundleState state, string uri)
        {
            BundleLoader.<LoadAssetBundle>d__5 val_1 = new BundleLoader.<LoadAssetBundle>d__5();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .state = state;
            }
            else
            {
                    mem[40] = state;
            }
            
            .uri = uri;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleLoader()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundleLoader()
        {
            Systems.AssetManagement.Bundles.BundleLoader.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
