using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodeServerDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage package;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer masterEventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodeServerDispatcher(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage newPackage, Game.Server.ServerDomain newServerDomain, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this.masterEventExposer = eventExposer;
            this.package = newPackage.cameraInfoFrames;
            mem[1152921525383437552] = newPackage.canSelectObjectEvaluations;
            this.serverDomain = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendRequest()
        {
            var val_5;
            var val_6;
            string val_7;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if((X22 + 24) < 1)
            {
                goto label_2;
            }
            
            val_5 = (X22 + 24) & 4294967295;
            val_6 = 0;
            val_7 = X22 + 32;
            goto label_3;
            label_6:
            val_5 = mem[X22 + 24];
            val_5 = X22 + 24;
            val_6 = 1;
            val_7 = val_7 + 32;
            label_3:
            val_1.Add(item:  val_7);
            if((val_5 - 1) != val_6)
            {
                goto label_6;
            }
            
            label_2:
            this.serverDomain.essenceNodeSpawnRequester.Spawn(objectTypes:  val_1, newCallback:  new System.Action<System.Collections.Generic.List<Game.Server.EssenceNodeEntry>>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeServerDispatcher::OnReceived(System.Collections.Generic.List<Game.Server.EssenceNodeEntry> typesToSpawn)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnReceived(System.Collections.Generic.List<Game.Server.EssenceNodeEntry> typesToSpawn)
        {
            this.masterEventExposer.OnEssenceNodeSelected(trackerSessionPackage:  new TrackerSessionPackage() {cameraInfoFrames = this.package, detectedObjects = this.package, canSelectObjectEvaluations = ???}, types:  typesToSpawn);
        }
    
    }

}
