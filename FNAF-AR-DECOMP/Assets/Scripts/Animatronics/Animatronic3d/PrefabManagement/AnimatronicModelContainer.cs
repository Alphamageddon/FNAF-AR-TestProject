using UnityEngine;

namespace Animatronics.Animatronic3d.PrefabManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicModelContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.AnimatronicModelConfig <Prefab>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.PrefabManagement.PrefabLoadState <LoadState>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <AnimatronicEntityExists>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer> OnPrefabLoadSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnPrefabLoadFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _assetName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _bundleName;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.AnimatronicModelConfig Prefab { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.PrefabManagement.PrefabLoadState LoadState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AnimatronicEntityExists { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.AnimatronicModelConfig get_Prefab()
        {
            return (Animatronics.Animatronic3d.Model.AnimatronicModelConfig)this.<Prefab>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Prefab(Animatronics.Animatronic3d.Model.AnimatronicModelConfig value)
        {
            this.<Prefab>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.PrefabManagement.PrefabLoadState get_LoadState()
        {
            return (Animatronics.Animatronic3d.PrefabManagement.PrefabLoadState)this.<LoadState>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LoadState(Animatronics.Animatronic3d.PrefabManagement.PrefabLoadState value)
        {
            this.<LoadState>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AnimatronicEntityExists()
        {
            return (bool)this.<AnimatronicEntityExists>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AnimatronicEntityExists(bool value)
        {
            this.<AnimatronicEntityExists>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAnimatronicPrefab(Systems.AssetManagement.Assets.IAssetCache assetCache, System.Action<Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer> onSuccess, System.Action<string> onFailure)
        {
            System.Action<Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer> val_5;
            System.Action<System.String> val_6;
            var val_7;
            if(((System.Delegate.Combine(a:  this.OnPrefabLoadSuccess, b:  onSuccess)) != null) && (null != null))
            {
                    val_5 = 0;
            }
            
            this.OnPrefabLoadSuccess = val_5;
            if(((System.Delegate.Combine(a:  this.OnPrefabLoadFailure, b:  onFailure)) != null) && (null != null))
            {
                    val_6 = 0;
            }
            
            this.OnPrefabLoadFailure = val_6;
            if((this.<LoadState>k__BackingField) == 2)
            {
                goto label_5;
            }
            
            if((this.<LoadState>k__BackingField) == 1)
            {
                    return;
            }
            
            if((this.<LoadState>k__BackingField) != 0)
            {
                goto label_7;
            }
            
            this.LoadAnimatronicPrefab(assetCache:  assetCache);
            return;
            label_5:
            this.NotifySuccess();
            return;
            label_7:
            val_7 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AnimatronicEntityAdded(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            this.<AnimatronicEntityExists>k__BackingField = true;
            this.LoadAnimatronicPrefab(assetCache:  assetCache);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AnimatronicEntityRemoved()
        {
            this.<AnimatronicEntityExists>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadAnimatronicPrefab(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            if((this.<LoadState>k__BackingField) != 0)
            {
                    return;
            }
            
            this.<LoadState>k__BackingField = 1;
            System.Action<UnityEngine.GameObject> val_1 = new System.Action<UnityEngine.GameObject>(object:  this, method:  System.Void Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer::AssetLoadSuccess(UnityEngine.GameObject gameObject));
            System.Action val_2 = new System.Action(object:  this, method:  System.Void Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer::AssetLoadFailure());
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(assetCache, typeof(public System.Void Systems.AssetManagement.Assets.IAssetCache::LoadAssetAsync<UnityEngine.GameObject>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadSuccess(UnityEngine.GameObject gameObject)
        {
            var val_5;
            string val_7;
            string val_8;
            string val_9;
            var val_10;
            if((UnityEngine.Object.op_Implicit(exists:  gameObject)) == false)
            {
                goto label_3;
            }
            
            Animatronics.Animatronic3d.Model.AnimatronicModelConfig val_2 = gameObject.GetComponent<Animatronics.Animatronic3d.Model.AnimatronicModelConfig>();
            this.<Prefab>k__BackingField = val_2;
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
            {
                goto label_7;
            }
            
            this.<LoadState>k__BackingField = 2;
            this.NotifySuccess();
            return;
            label_3:
            val_5 = null;
            val_5 = null;
            val_7 = this.<Id>k__BackingField;
            val_8 = "GameObject for \'";
            val_9 = "\' claimed to have loaded successfully, but was returned null";
            goto label_10;
            label_7:
            val_10 = null;
            val_10 = null;
            val_7 = this.<Id>k__BackingField;
            val_8 = "GameObject for \'";
            val_9 = "\' did not have the required AnimatronicModelConfig component";
            label_10:
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer.__il2cppRuntimeField_static_fields, functionName:  "AssetLoadSuccess", logString:  val_8 + val_7 + val_9);
            this.AssetLoadFailure();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadFailure()
        {
            null = null;
            ConsoleLogger.LogError(className:  Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer.ClassName, functionName:  "AssetLoadFailure", logString:  "AnimatronicModelConfig for \'" + this.<Id>k__BackingField(this.<Id>k__BackingField) + "\' failed to load");
            this.<LoadState>k__BackingField = 0;
            this.NotifyFailure();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NotifySuccess()
        {
            if(this.OnPrefabLoadSuccess != null)
            {
                    this.OnPrefabLoadSuccess.Invoke(obj:  this);
            }
            
            this.OnPrefabLoadSuccess = 0;
            mem[1152921525061747744] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NotifyFailure()
        {
            if(this.OnPrefabLoadFailure != null)
            {
                    this.OnPrefabLoadFailure.Invoke(obj:  this.<Id>k__BackingField);
            }
            
            this.OnPrefabLoadSuccess = 0;
            this.OnPrefabLoadFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearAllEvents()
        {
            this.OnPrefabLoadSuccess = 0;
            this.OnPrefabLoadFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(AnimatronicEntity.AnimatronicConfigData configData)
        {
            string val_8;
            string val_9;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_1 = configData.PlushSuitData;
            this.<LoadState>k__BackingField = 0;
            this.<AnimatronicEntityExists>k__BackingField = false;
            this.<Id>k__BackingField = val_1.Id;
            this.<Prefab>k__BackingField = 0;
            if(configData.PlushSuitData != null)
            {
                    val_8 = val_2.AnimatronicPrefab;
            }
            else
            {
                    val_8 = 0;
            }
            
            this._assetName = (val_8 == 0) ? "" : (val_8);
            if(configData.PlushSuitData != null)
            {
                    val_9 = val_4.AnimatronicAssetBundle;
            }
            else
            {
                    val_9 = 0;
            }
            
            this._bundleName = (val_9 == 0) ? "" : (val_9);
            if((System.String.IsNullOrWhiteSpace(value:  this._assetName)) != true)
            {
                    if((System.String.IsNullOrWhiteSpace(value:  this._bundleName)) == false)
            {
                    return;
            }
            
            }
            
            this._assetName = "FreddyPrefab";
            this._bundleName = "animatronics/freddy";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicModelContainer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatronicModelContainer()
        {
            Animatronics.Animatronic3d.PrefabManagement.AnimatronicModelContainer.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
