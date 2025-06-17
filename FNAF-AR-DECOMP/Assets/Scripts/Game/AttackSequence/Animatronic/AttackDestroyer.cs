using UnityEngine;

namespace Game.AttackSequence.Animatronic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AttackDestroyer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload> OnAnimatronicAboutToBeDestroyed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackSpawner _spawner;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimatronicAboutToBeDestroyed(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimatronicAboutToBeDestroyed, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicAboutToBeDestroyed != 1152921525452416752);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimatronicAboutToBeDestroyed(System.Action<Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimatronicAboutToBeDestroyed, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicAboutToBeDestroyed != 1152921525452553328);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackAnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)
        {
            animatronic.add_OnReadyForCleanup(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackDestroyer::AttackAnimatronicReadyForCleanup(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttackAnimatronicReadyForCleanup(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)
        {
            .EntityId = animatronic.EntityId;
            if(this.OnAnimatronicAboutToBeDestroyed != null)
            {
                    this.OnAnimatronicAboutToBeDestroyed.Invoke(obj:  new Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload());
            }
            
            System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic> val_3 = new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackDestroyer::AttackAnimatronicReadyForCleanup(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic));
            if(animatronic != null)
            {
                    animatronic.remove_OnReadyForCleanup(value:  val_3);
            }
            else
            {
                    0.remove_OnReadyForCleanup(value:  val_3);
            }
            
            animatronic.Teardown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.AttackSpawner spawner)
        {
            this._spawner = spawner;
            spawner.add_OnAnimatronicSpawned(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackDestroyer::AttackAnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._spawner.remove_OnAnimatronicSpawned(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Animatronic.AttackDestroyer::AttackAnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)));
            this._spawner = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttackDestroyer()
        {
        
        }
    
    }

}
