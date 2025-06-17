using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerDataStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _completeFlags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.PlayerDataStartupTask Setup(Master.EventExposer masterEvents, Game.Server.ServerDomain serverDomain)
        {
            this._masterEvents = masterEvents;
            this._serverDomain = serverDomain;
            return (Master.Startup.PlayerDataStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEvents.remove_PlayerAnimatronicDataLoaded(value:  new System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e)));
            this._masterEvents.remove_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData e)));
            this._masterEvents = 0;
            mem[1152921523304368648] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "PlayerData";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._masterEvents.add_PlayerAnimatronicDataLoaded(value:  new System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e)));
            this._serverDomain.playerAnimatronicDataLoader.Load();
            this._masterEvents.add_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData e)));
            this._serverDomain.playerWorkshopDataLoader.Load();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e)
        {
            this._masterEvents.remove_PlayerAnimatronicDataLoaded(value:  new System.Action<System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnPlayerAnimatronicDataLoaded(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> e)));
            this.CallIfDone(flag:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData e)
        {
            this._masterEvents.remove_WorkshopDataV2Updated(value:  new System.Action<AnimatronicEntity.Data.WorkshopData>(object:  this, method:  System.Void Master.Startup.PlayerDataStartupTask::OnWorkshopDataV2Updated(AnimatronicEntity.Data.WorkshopData e)));
            this.CallIfDone(flag:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallIfDone(int flag)
        {
            int val_1 = this._completeFlags;
            val_1 = val_1 | flag;
            this._completeFlags = val_1;
            if(val_1 != 3)
            {
                    return;
            }
            
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerDataStartupTask()
        {
        
        }
    
    }

}
