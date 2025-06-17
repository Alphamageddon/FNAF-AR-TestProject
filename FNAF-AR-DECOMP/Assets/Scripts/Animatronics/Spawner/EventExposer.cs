using UnityEngine;

namespace Animatronics.Spawner
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventExposer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.Spawner.AnimatronicsSpawnerDomain _animatronicsSpawnerDomain;
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
            while(this.OnAnimatronicRequestedFromServer != 1152921525047358648);
        
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
            while(this.OnAnimatronicRequestedFromServer != 1152921525047495224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventExposer(Animatronics.Spawner.AnimatronicsSpawnerDomain animatronicsSpawnerDomain)
        {
            this._animatronicsSpawnerDomain = animatronicsSpawnerDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteSetup()
        {
            this._animatronicsSpawnerDomain.<spawner>k__BackingField.add_OnAnimatronicRequestedFromServer(value:  new System.Action<System.String>(object:  this, method:  System.Void Animatronics.Spawner.EventExposer::Spawner_OnAnimatronicRequestedFromServer(string e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Spawner_OnAnimatronicRequestedFromServer(string e)
        {
            if(this.OnAnimatronicRequestedFromServer == null)
            {
                    return;
            }
            
            this.OnAnimatronicRequestedFromServer.Invoke(obj:  e);
        }
    
    }

}
