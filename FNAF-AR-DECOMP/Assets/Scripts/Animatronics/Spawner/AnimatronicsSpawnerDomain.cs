using UnityEngine;

namespace Animatronics.Spawner
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicsSpawnerDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.ServerChunkLoader _serverChunkLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Spawner.Spawner <spawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Spawner.EventExposer eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Spawner.NextAnimatronicSpawnUpdater spawnUpdater;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _movementNodeDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain MasterDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain AnimatronicEntityDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Spawner.Spawner spawner { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain get_MasterDomain()
        {
            return (Master.MasterDomain)this._masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain get_AnimatronicEntityDomain()
        {
            return (AnimatronicEntity.AnimatronicEntityDomain)this._animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Spawner.Spawner get_spawner()
        {
            return (Animatronics.Spawner.Spawner)this.<spawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_spawner(Animatronics.Spawner.Spawner value)
        {
            this.<spawner>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicsSpawnerDomain(Master.MasterDomain masterDomain, AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain, MapMode.MovementNode.MovementNodeDomain movementNodeDomain)
        {
            val_1 = new System.Object();
            this._masterDomain = masterDomain;
            this._animatronicEntityDomain = val_1;
            this._movementNodeDomain = movementNodeDomain;
            this.CreateSubclasses();
            this.CompleteSetup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateSubclasses()
        {
            ._animatronicsSpawnerDomain = this;
            this.eventExposer = new Animatronics.Spawner.EventExposer();
            ._animatronicsSpawnerDomain = this;
            this.<spawner>k__BackingField = new Animatronics.Spawner.Spawner();
            this._serverChunkLoader = new AnimatronicEntity.ServerChunkLoader();
            this.spawnUpdater = new Animatronics.Spawner.NextAnimatronicSpawnUpdater();
            this.eventExposer.CompleteSetup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CompleteSetup()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            this.spawnUpdater.Setup(requestCallback:  new System.Action<DisplayState>(object:  val_2.serverDomain.nextAnimatronicRequester, method:  public System.Void Game.Server.NextAnimatronicRequester::RequestNextAnimatronic(Game.Server.NextAnimatronicRequester.DisplayState currentDisplayState)), masterExposer:  val_1.eventExposer, gameDisplayChanger:  this._masterDomain.theGameDomain.gameDisplayChanger);
            val_1.eventExposer.add_EntityChunkGenerated(value:  new System.Action<AnimatronicEntity.SaveGameChunk>(object:  this, method:  System.Void Animatronics.Spawner.AnimatronicsSpawnerDomain::OnEntityChunkGenerated(AnimatronicEntity.SaveGameChunk entityChunk)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.spawnUpdater.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEntityChunkGenerated(AnimatronicEntity.SaveGameChunk entityChunk)
        {
            this.<spawner>k__BackingField.OnRequestNewAnimatronicFromServer(chunk:  entityChunk);
        }
    
    }

}
