using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodePackager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer <_masterEventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.Cooldowns <_cooldowns>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection> _detectedObjectsCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns _cooldowns { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer get__masterEventExposer()
        {
            return (Master.EventExposer)this.<_masterEventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns get__cooldowns()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.Cooldowns)this.<_cooldowns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodePackager(Master.EventExposer masterEventExposer, Game.EssenceCollection.Data.EssenceNodes.Cooldowns cooldowns, Game.Server.ServerDomain serverDomain)
        {
            this._detectedObjectsCache = new System.Collections.Generic.List<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection>();
            val_2 = new System.Object();
            this.<_masterEventExposer>k__BackingField = masterEventExposer;
            this.<_cooldowns>k__BackingField = val_2;
            this._serverDomain = serverDomain;
            masterEventExposer.add_EssenceTrackerSessionCompleted(value:  new System.Action<TrackerSessionPackage>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager::EventExposerOnEssenceTrackerSessionCompleted(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnEssenceTrackerSessionCompleted(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.TrackerSessionPackage trackerSessionPackage)
        {
            CameraInfoFrame[] val_4 = trackerSessionPackage.cameraInfoFrames;
            if(trackerSessionPackage.cameraInfoFrames.Length == 0)
            {
                    return;
            }
            
            val_4 = trackerSessionPackage.detectedObjects;
            if(trackerSessionPackage.detectedObjects.Length == 0)
            {
                    return;
            }
            
            val_4 = this.CopySelectedDetectedObjects(srcDetectedObjects:  trackerSessionPackage.detectedObjects, canSelectObjectEvaluations:  trackerSessionPackage.canSelectObjectEvaluations);
            if(val_2.Length == 0)
            {
                    return;
            }
            
            .package = this.CopyCameraInfoFrames(srcCameraInfoFrames:  trackerSessionPackage.cameraInfoFrames);
            mem[1152921525382707672] = val_4;
            mem[1152921525382707680] = 0;
            .serverDomain = this._serverDomain;
            .masterEventExposer = this.<_masterEventExposer>k__BackingField;
            new Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeServerDispatcher().SendRequest();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame[] CopyCameraInfoFrames(Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame[] srcCameraInfoFrames)
        {
            CameraInfoFrame[] val_1 = new CameraInfoFrame[0];
            if(srcCameraInfoFrames.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                var val_3 = (srcCameraInfoFrames + (0 * 80)) + 32;
                var val_5 = (val_1 + (0 * 80)) + 32;
            }
            while((0 + 1) < srcCameraInfoFrames.Length);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] CopySelectedDetectedObjects(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] srcDetectedObjects, bool[] canSelectObjectEvaluations)
        {
            var val_6;
            var val_7;
            this._detectedObjectsCache.Clear();
            val_6 = 0;
            goto label_2;
            label_9:
            if(canSelectObjectEvaluations[0] != false)
            {
                    this._detectedObjectsCache.Add(item:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = srcDetectedObjects[0], minX = srcDetectedObjects[0], minY = srcDetectedObjects[0], maxX = srcDetectedObjects[0], maxY = srcDetectedObjects[0], conf = srcDetectedObjects[0]});
            }
            
            val_6 = 1;
            label_2:
            if(val_6 < srcDetectedObjects.Length)
            {
                goto label_9;
            }
            
            int val_1 = this._detectedObjectsCache.Count;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] val_2 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[0];
            val_7 = 0;
            goto label_11;
            label_16:
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_3 = this._detectedObjectsCache.Item[0];
            val_7 = 1;
            val_2[0] = 0;
            val_2[0] = 0;
            label_11:
            if(val_7 < this._detectedObjectsCache.Count)
            {
                goto label_16;
            }
            
            return val_2;
        }
    
    }

}
