using UnityEngine;

namespace Game.AssetManagement.Icons
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IconLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.IBundleCache _bundleCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _inProgressBundleLoads;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _completeCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartLoadingBundles(Systems.AssetManagement.Bundles.IBundleCache bundleCache, System.Collections.Generic.Dictionary<Game.AssetManagement.Icons.IconGroup, Game.AssetManagement.Icons.IconGroupData> iconLookups, System.Action completeCallback)
        {
            var val_7 = this;
            this._bundleCache = bundleCache;
            this._completeCallback = completeCallback;
            this._inProgressBundleLoads = iconLookups.Count;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = iconLookups.Values.GetEnumerator();
            label_5:
            if(((-582845064) & 1) == 0)
            {
                goto label_4;
            }
            
            this.StartLoadingBundle(iconGroupData:  0.emailUIDataHandler);
            goto label_5;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525498838392});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartLoadingBundle(Game.AssetManagement.Icons.IconGroupData iconGroupData)
        {
            IconLoader.<>c__DisplayClass6_0 val_1 = new IconLoader.<>c__DisplayClass6_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .iconGroupData = iconGroupData;
            .<>4__this = this;
            if(iconGroupData != null)
            {
                goto label_8;
            }
            
            label_9:
            label_8:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_7;
            label_1:
            mem[16] = iconGroupData;
            mem[24] = this;
            if(mem[16] != 0)
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            this._bundleCache.LoadAssetBundleAsync(bundleName:  iconGroupData.BundleName, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(object:  val_1, method:  System.Void IconLoader.<>c__DisplayClass6_0::<StartLoadingBundle>b__0(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle)), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure(object:  val_1, method:  System.Void IconLoader.<>c__DisplayClass6_0::<StartLoadingBundle>b__1(UnityEngine.CachedAssetBundle info)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconBundleLoadComplete()
        {
            int val_1 = this._inProgressBundleLoads;
            val_1 = val_1 - 1;
            this._inProgressBundleLoads = val_1;
            if(val_1 > 0)
            {
                    return;
            }
            
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._bundleCache = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IconLoader()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IconLoader()
        {
            Game.AssetManagement.Icons.IconLoader.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
