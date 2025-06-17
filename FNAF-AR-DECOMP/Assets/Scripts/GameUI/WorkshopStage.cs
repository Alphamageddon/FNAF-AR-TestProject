using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopStage
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3DDomain _animatronic3DDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.IItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStageView _workshopStageView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _stageRootTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _spawnCompleteCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Data.WorkshopEntry _requestedAnimatronic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.IAnimatronic3D _spawnedAnimatronic;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopStage(Master.EventExposer masterEventExposer, Utilities.AsyncInterfaceAccess<Animatronics.Animatronic3d.IAnimatronic3DDomain> animatronic3DAccess, Utilities.AsyncInterfaceAccess<Game.ItemDefinition.IItemDefinitionDomain> itemDefinitionAccess, UnityEngine.Transform stageRootTransform, GameUI.WorkshopStageView workshopStageView, System.Action<string> spawnCompleteCallback)
        {
            val_1 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._workshopStageView = workshopStageView;
            this._stageRootTransform = stageRootTransform;
            this._spawnCompleteCallback = spawnCompleteCallback;
            masterEventExposer.add_WorkshopCpuChanged(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuChanged()));
            this._masterEventExposer.add_WorkshopCpuMenuClosed(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuMenuClosed()));
            this._masterEventExposer.add_WorkshopCpuMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuMenuOpened()));
            this._masterEventExposer.add_WorkshopModMenuClosed(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopModMenuClosed()));
            this._masterEventExposer.add_WorkshopModMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopModMenuOpened()));
            this._masterEventExposer.add_WorkshopRepairSuccess(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopRepairSuccess()));
            this._masterEventExposer.add_WorkshopCameraRotated(value:  new System.Action<UnityEngine.Vector3, UnityEngine.Vector3>(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCameraRotated(UnityEngine.Vector3 prev, UnityEngine.Vector3 curr)));
            val_1.GetInterfaceAsync(callback:  new System.Action<Animatronics.Animatronic3d.IAnimatronic3DDomain>(object:  this, method:  System.Void GameUI.WorkshopStage::Animatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain animatronic3DDomain)));
            itemDefinitionAccess.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.WorkshopStage::ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Animatronic3DDomainReady(Animatronics.Animatronic3d.IAnimatronic3DDomain animatronic3DDomain)
        {
            this._animatronic3DDomain = animatronic3DDomain;
            this.TryToSpawnAnimatronic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionDomainReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            this._itemDefinitionDomain = itemDefinitionDomain;
            this.TryToSpawnAnimatronic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_WorkshopRepairSuccess(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopRepairSuccess()));
            this._masterEventExposer.remove_WorkshopModMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopModMenuOpened()));
            this._masterEventExposer.remove_WorkshopModMenuClosed(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopModMenuClosed()));
            this._masterEventExposer.remove_WorkshopCpuMenuOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuMenuOpened()));
            this._masterEventExposer.remove_WorkshopCpuMenuClosed(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuMenuClosed()));
            this._masterEventExposer.remove_WorkshopCpuChanged(value:  new System.Action(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCpuChanged()));
            this._masterEventExposer.remove_WorkshopCameraRotated(value:  new System.Action<UnityEngine.Vector3, UnityEngine.Vector3>(object:  this, method:  System.Void GameUI.WorkshopStage::WorkshopCameraRotated(UnityEngine.Vector3 prev, UnityEngine.Vector3 curr)));
            this.ClearStage();
            this._masterEventExposer = 0;
            this._itemDefinitionDomain = 0;
            this._stageRootTransform = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearStage()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._spawnedAnimatronic.Teardown();
            this._spawnedAnimatronic = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestAnimatronicSpawn(AnimatronicEntity.Data.WorkshopEntry workshopEntry)
        {
            if(this._requestedAnimatronic != null)
            {
                    ConsoleLogger.LogError(className:  "WorkshopStage", functionName:  "RequestAnimatronicSpawn", logString:  "Requested an animatronic spawn on workshop stage while another animatronic is spawning");
                return;
            }
            
            this._requestedAnimatronic = workshopEntry;
            this.TryToSpawnAnimatronic();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopCpuChanged()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._spawnedAnimatronic.SetAnimationTrigger(animationTrigger:  7, shouldSet:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopCpuMenuClosed()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._spawnedAnimatronic.SetAnimationTrigger(animationTrigger:  7, shouldSet:  false);
            this = this._spawnedAnimatronic;
            if(this == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.SetAnimationBool(animationBool:  2, value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopCpuMenuOpened()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._spawnedAnimatronic.RaiseAudioEventFromPlushSuit(eventName:  56);
            this = this._spawnedAnimatronic;
            if(this == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.SetAnimationBool(animationBool:  2, value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopModMenuClosed()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._spawnedAnimatronic.SetAudioMute(shouldMute:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopModMenuOpened()
        {
            if(this._spawnedAnimatronic == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._spawnedAnimatronic.SetAudioMute(shouldMute:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopRepairSuccess()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._spawnedAnimatronic.TriggerRepairInterpolation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopCameraRotated(UnityEngine.Vector3 prev, UnityEngine.Vector3 curr)
        {
            this._workshopStageView.RotateCamera(prev:  new UnityEngine.Vector3() {x = prev.x, y = prev.y, z = prev.z}, curr:  new UnityEngine.Vector3() {x = curr.x, y = curr.y, z = curr.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToSpawnAnimatronic()
        {
            string val_10;
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_11;
            var val_12;
            if(this._animatronic3DDomain == null)
            {
                    return;
            }
            
            if(this._itemDefinitionDomain == null)
            {
                    return;
            }
            
            if(this._requestedAnimatronic == null)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            Game.ItemDefinition.Container.ItemDefinitions val_2 = this._itemDefinitionDomain.ItemDefinitions;
            if(val_2 != null)
            {
                    val_10 = this._requestedAnimatronic.endoskeleton.plushSuit;
                val_11 = val_2.GetCPUById(id:  this._requestedAnimatronic.endoskeleton.cpu);
            }
            else
            {
                    val_10 = this._requestedAnimatronic.endoskeleton.plushSuit;
                val_11 = 0.GetCPUById(id:  this._requestedAnimatronic.endoskeleton.cpu);
            }
            
            Animatronics.Animatronic3d.CreationRequest val_7 = new Animatronics.Animatronic3d.CreationRequest(configData:  new AnimatronicEntity.AnimatronicConfigData(cpuData:  val_11, plushSuitData:  val_2.GetPlushSuitById(id:  val_10), attackProfile:  0), parent:  this._stageRootTransform);
            val_12 = 0;
            val_7.add_OnRequestComplete(value:  new System.Action<Animatronics.Animatronic3d.CreationRequest>(object:  this, method:  System.Void GameUI.WorkshopStage::AnimatronicSpawnComplete(Animatronics.Animatronic3d.CreationRequest request)));
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 0;
            this._animatronic3DDomain.CreateAnimatronic3D(request:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicSpawnComplete(Animatronics.Animatronic3d.CreationRequest request)
        {
            Animatronics.Animatronic3d.IAnimatronic3D val_16;
            var val_17;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            this.ClearStage();
            if(request.Animatronic3D == null)
            {
                goto label_2;
            }
            
            if(request == null)
            {
                goto label_3;
            }
            
            val_16 = request.Animatronic3D;
            val_17 = this;
            this._spawnedAnimatronic = val_16;
            goto label_4;
            label_2:
            ConsoleLogger.LogError(className:  "WorkshopStage", functionName:  "AnimatronicSpawnComplete", logString:  "Workshop model for stage didn\'t load");
            goto label_7;
            label_3:
            val_16 = 0.Animatronic3D;
            val_17 = this;
            this._spawnedAnimatronic = val_16;
            label_4:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_20 = request.ConfigData.PlushSuitData;
            val_16.Setup(cpuData:  request.ConfigData.CpuData, plushSuitData:  val_20, attackProfile:  0, audioMode:  4, masterEventExposer:  0, displayMode:  6, cameraStableTransform:  0);
            var val_16 = mem[val_3];
            if((mem[val_3] + 286) == 0)
            {
                goto label_17;
            }
            
            var val_14 = mem[val_3] + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_19:
            if(((mem[val_3] + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[val_3] + 286))
            {
                goto label_19;
            }
            
            label_17:
            val_20 = 0;
            goto label_20;
            label_18:
            val_16 = val_16 + (((mem[val_3] + 176 + 8)) << 4);
            val_21 = val_16 + 296;
            label_20:
            val_22 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetAnimationMode(Animatronics.Animatronic3d.Model.Animation.AnimationMode animationMode);
            this._spawnedAnimatronic.SetAnimationMode(animationMode:  1);
            var val_20 = mem[val_3];
            if((mem[val_3] + 286) == 0)
            {
                goto label_22;
            }
            
            var val_17 = mem[val_3] + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_24:
            if(((mem[val_3] + 176 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (mem[val_3] + 286))
            {
                goto label_24;
            }
            
            label_22:
            val_22 = 34;
            goto label_25;
            label_23:
            var val_19 = val_17;
            val_19 = val_19 + 34;
            val_20 = val_20 + val_19;
            val_23 = val_20 + 296;
            label_25:
            this._spawnedAnimatronic.SetTransformOverrideMode(mode:  3);
            var val_24 = mem[val_3];
            if((mem[val_3] + 286) == 0)
            {
                goto label_30;
            }
            
            var val_21 = mem[val_3] + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_29:
            if(((mem[val_3] + 176 + 8) + -8) == null)
            {
                goto label_28;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (mem[val_3] + 286))
            {
                goto label_29;
            }
            
            goto label_30;
            label_28:
            var val_23 = val_21;
            val_23 = val_23 + 5;
            val_24 = val_24 + val_23;
            val_24 = val_24 + 296;
            label_30:
            val_25 = 1;
            this._spawnedAnimatronic.SetAnimationTrigger(animationTrigger:  5, shouldSet:  true);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_25 = 28;
            this._spawnedAnimatronic.SetWearAndTear(value:  this._requestedAnimatronic.GetWearAndTearPercentage());
            label_7:
            this._requestedAnimatronic = 0;
            if(this._spawnCompleteCallback == null)
            {
                    return;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_12 = request.ConfigData.PlushSuitData;
            this._spawnCompleteCallback.Invoke(obj:  val_12.Id);
        }
    
    }

}
