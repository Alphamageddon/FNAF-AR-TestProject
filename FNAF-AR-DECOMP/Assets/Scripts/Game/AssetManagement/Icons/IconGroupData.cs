using UnityEngine;

namespace Game.AssetManagement.Icons
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IconGroupData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BundleName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> _lookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _inProgressIconLoads;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _completeCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAssetCache(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this._assetCache = assetCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAllIcons(string[] assetNames, System.Action completeCallback)
        {
            System.Action val_5;
            var val_6;
            val_5 = completeCallback;
            this._completeCallback = val_5;
            val_6 = 0;
            this._inProgressIconLoads = assetNames.Length;
            goto label_2;
            label_11:
            .<>4__this = this;
            val_5 = assetNames[0];
            .assetName = val_5;
            System.Action<UnityEngine.Sprite> val_2 = new System.Action<UnityEngine.Sprite>(object:  this, method:  System.Void Game.AssetManagement.Icons.IconGroupData::IconLoadSuccess(UnityEngine.Sprite loadedSprite));
            System.Action val_3 = new System.Action(object:  new IconGroupData.<>c__DisplayClass7_0(), method:  System.Void IconGroupData.<>c__DisplayClass7_0::<LoadAllIcons>b__0());
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = 1;
            label_2:
            if(val_6 < assetNames.Length)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetIcon(string name)
        {
            var val_3;
            if((this._lookup.ContainsKey(key:  name)) != false)
            {
                    UnityEngine.Sprite val_2 = this._lookup.Item[name];
                return (UnityEngine.Sprite)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.Sprite)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconLoadSuccess(UnityEngine.Sprite loadedSprite)
        {
            this._lookup.Add(key:  loadedSprite.name, value:  loadedSprite);
            int val_2 = this._inProgressIconLoads;
            val_2 = val_2 - 1;
            this._inProgressIconLoads = val_2;
            if(val_2 > 0)
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
        private void IconLoadComplete()
        {
            int val_1 = this._inProgressIconLoads;
            val_1 = val_1 - 1;
            this._inProgressIconLoads = val_1;
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
        public IconGroupData()
        {
            this._lookup = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._lookup.Keys.GetEnumerator();
            label_9:
            if(((-583393656) & 1) == 0)
            {
                goto label_3;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            this._assetCache.ReleaseAsset(bundleName:  this.BundleName, assetName:  0.emailUIDataHandler);
            goto label_9;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525498289800});
            this._lookup.Clear();
            mem2[0] = 0;
            mem2[0] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IconGroupData()
        {
            Game.AssetManagement.Icons.IconGroupData.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
