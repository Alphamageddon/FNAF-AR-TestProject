using UnityEngine;

namespace Animatronics.Spawner
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Spawner
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Spawner.AnimatronicsSpawnerDomain _animatronicsSpawnerDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnAnimatronicRequestedFromServer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimatronicRequestedFromServer(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimatronicRequestedFromServer, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicRequestedFromServer != 1152921525048919864);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimatronicRequestedFromServer(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimatronicRequestedFromServer, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicRequestedFromServer != 1152921525049056440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Spawner(Animatronics.Spawner.AnimatronicsSpawnerDomain animatronicsSpawnerDomain)
        {
            this._animatronicsSpawnerDomain = animatronicsSpawnerDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnNewAnimatronic(string animatronicId)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRequestNewAnimatronicFromServer(AnimatronicEntity.SaveGameChunk chunk)
        {
            this._animatronicsSpawnerDomain._animatronicEntityDomain.container.AddEntity(entity:  this._animatronicsSpawnerDomain._animatronicEntityDomain.creator.CreateEntity(saveGameChunk:  chunk));
        }
    
    }

}
