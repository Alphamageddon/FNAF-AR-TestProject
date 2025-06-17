using UnityEngine;

namespace Animatronics.Animatronic3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CreationRequest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntity <Entity>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicConfigData <ConfigData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Transform <Parent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3D <Animatronic3D>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Animatronics.Animatronic3d.CreationRequest> OnRequestComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _animatronicShadersComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _animatronicGameObjectComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _cpuSoundBankComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _plushSuitSoundBankComplete;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity Entity { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicConfigData ConfigData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Parent { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3D Animatronic3D { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity get_Entity()
        {
            return (AnimatronicEntity.AnimatronicEntity)this.<Entity>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicConfigData get_ConfigData()
        {
            return (AnimatronicEntity.AnimatronicConfigData)this.<ConfigData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform get_Parent()
        {
            return (UnityEngine.Transform)this.<Parent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.IAnimatronic3D get_Animatronic3D()
        {
            return (Animatronics.Animatronic3d.IAnimatronic3D)this.<Animatronic3D>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Animatronic3D(Animatronics.Animatronic3d.IAnimatronic3D value)
        {
            this.<Animatronic3D>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRequestComplete(System.Action<Animatronics.Animatronic3d.CreationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRequestComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestComplete != 1152921525057135360);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRequestComplete(System.Action<Animatronics.Animatronic3d.CreationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRequestComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestComplete != 1152921525057271936);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreationRequest(AnimatronicEntity.AnimatronicEntity entity, UnityEngine.Transform parent)
        {
            this.<Entity>k__BackingField = entity;
            this.<ConfigData>k__BackingField = entity.animatronicConfigData;
            this.<Parent>k__BackingField = parent;
            this.<Animatronic3D>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreationRequest(AnimatronicEntity.AnimatronicConfigData configData, UnityEngine.Transform parent)
        {
            this.<Entity>k__BackingField = 0;
            this.<ConfigData>k__BackingField = configData;
            this.<Parent>k__BackingField = parent;
            this.<Animatronic3D>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAnimatronicShaders(Systems.AssetManagement.Assets.IAssetCache assetCache)
        {
            string val_6;
            .<>4__this = this;
            if((this.<ConfigData>k__BackingField.PlushSuitData) == null)
            {
                goto label_3;
            }
            
            val_6 = val_2.AnimatronicAssetBundle;
            if(val_6 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_6 = System.String.alignConst;
            label_4:
            if((System.String.IsNullOrWhiteSpace(value:  val_6)) != false)
            {
                    this._animatronicShadersComplete = true;
                this.TryToNotifyComplete();
                return;
            }
            
            .initializer = new Systems.AssetManagement.Shaders.ShaderCollectionInitializer(assetCache:  assetCache, bundleName:  val_6, shaderCollectionName:  "PreWarmOnLoad", forceLoad:  false, onFinished:  new System.Action(object:  new CreationRequest.<>c__DisplayClass23_0(), method:  System.Void CreationRequest.<>c__DisplayClass23_0::<LoadAnimatronicShaders>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AnimatronicShaderLoadComplete()
        {
            this._animatronicShadersComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadCpuSoundBank(Game.Audio.IAudioPlayer audioPlayer)
        {
            IntPtr val_11;
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_1 = this.<ConfigData>k__BackingField.CpuData;
            if((System.String.IsNullOrWhiteSpace(value:  val_1.SoundBankName)) != false)
            {
                    Game.ItemDefinition.Data.DataDefinitions.CPUData val_3 = this.<ConfigData>k__BackingField.CpuData;
                this._cpuSoundBankComplete = true;
                this.TryToNotifyComplete();
                return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_7 = this.<ConfigData>k__BackingField.CpuData;
            .SoundBankName = val_7.SoundBankName;
            .Success = new System.Action<System.String>(object:  this, method:  System.Void Animatronics.Animatronic3d.CreationRequest::<LoadCpuSoundBank>b__25_0(string soundBankName));
            System.Action<System.String> val_9 = null;
            val_11 = System.Void Animatronics.Animatronic3d.CreationRequest::<LoadCpuSoundBank>b__25_1(string soundBankName);
            val_9 = new System.Action<System.String>(object:  this, method:  val_11);
            .Failure = val_9;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_11 = 0;
            audioPlayer.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CpuSoundBankLoadComplete(string soundBankName, bool success)
        {
            this._cpuSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadPlushSuitSoundBank(Game.Audio.IAudioPlayer audioPlayer)
        {
            AnimatronicEntity.AnimatronicConfigData val_10;
            string val_11;
            IntPtr val_13;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_1 = this.<ConfigData>k__BackingField.PlushSuitData;
            val_10 = this.<ConfigData>k__BackingField;
            val_11 = val_1.SoundBankName;
            if((val_10.AttackProfile != null) && (val_2.EncounterType == 1))
            {
                    val_10 = this.<ConfigData>k__BackingField.CpuData;
                val_11 = val_3.SoundBankName;
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_11)) != false)
            {
                    this._plushSuitSoundBankComplete = true;
                this.TryToNotifyComplete();
                return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            .SoundBankName = val_11;
            .Success = new System.Action<System.String>(object:  this, method:  System.Void Animatronics.Animatronic3d.CreationRequest::<LoadPlushSuitSoundBank>b__27_0(string soundBankName));
            System.Action<System.String> val_9 = null;
            val_13 = System.Void Animatronics.Animatronic3d.CreationRequest::<LoadPlushSuitSoundBank>b__27_1(string soundBankName);
            val_9 = new System.Action<System.String>(object:  this, method:  val_13);
            .Failure = val_9;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = 0;
            audioPlayer.SoundBankLoader.RequestSoundBank(request:  new Systems.Audio.Wwise.SoundBankRequest());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlushSuitSoundBankLoadComplete(string soundBankName, bool success)
        {
            this._plushSuitSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimatronicCreationSuccess(Animatronics.Animatronic3d.IAnimatronic3D animatronic3D)
        {
            this._animatronicGameObjectComplete = true;
            this.<Animatronic3D>k__BackingField = animatronic3D;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimatronicCreationFailure()
        {
            this._animatronicGameObjectComplete = true;
            this.<Animatronic3D>k__BackingField = 0;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SoundBankLoadComplete(string soundBankName, bool success)
        {
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToNotifyComplete()
        {
            if(this._animatronicShadersComplete == false)
            {
                    return;
            }
            
            if(this._animatronicGameObjectComplete == false)
            {
                    return;
            }
            
            if(this._cpuSoundBankComplete == false)
            {
                    return;
            }
            
            if(this._plushSuitSoundBankComplete == false)
            {
                    return;
            }
            
            if(this.OnRequestComplete != null)
            {
                    this.OnRequestComplete.Invoke(obj:  this);
            }
            
            this.OnRequestComplete = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CreationRequest()
        {
            Animatronics.Animatronic3d.CreationRequest.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LoadCpuSoundBank>b__25_0(string soundBankName)
        {
            this._cpuSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LoadCpuSoundBank>b__25_1(string soundBankName)
        {
            this._cpuSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LoadPlushSuitSoundBank>b__27_0(string soundBankName)
        {
            this._plushSuitSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <LoadPlushSuitSoundBank>b__27_1(string soundBankName)
        {
            this._plushSuitSoundBankComplete = true;
            this.TryToNotifyComplete();
        }
    
    }

}
