using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraInfoRecorder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _startingDistance = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _minDistance = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _perFrameDistanceScale = 0.75;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 upperLeftViewport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 upperRightViewport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 lowerLeftViewport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 lowerRightViewport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.EssenceCollectionDomain <_essenceCollectionDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Systems.ARObjectDetection.ARObjectDetectionDomain <_arObjectDetectionDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer <_masterEventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator <_arObjectEvaluator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly TheGame.GameDisplayChanger <_gameDisplay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CameraSceneLookupTable <_cameraSceneLookupTable>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _cameraToUse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _recordingIsOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder.CameraInfoFrame> _cameraFrames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _currentDistanceToUse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _featureAllowed;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.EssenceCollectionDomain _essenceCollectionDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.ARObjectDetectionDomain _arObjectDetectionDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator _arObjectEvaluator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplay { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CameraSceneLookupTable _cameraSceneLookupTable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.EssenceCollectionDomain get__essenceCollectionDomain()
        {
            return (Game.EssenceCollection.EssenceCollectionDomain)this.<_essenceCollectionDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.ARObjectDetectionDomain get__arObjectDetectionDomain()
        {
            return (Systems.ARObjectDetection.ARObjectDetectionDomain)this.<_arObjectDetectionDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer get__masterEventExposer()
        {
            return (Master.EventExposer)this.<_masterEventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator get__arObjectEvaluator()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator)this.<_arObjectEvaluator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger get__gameDisplay()
        {
            return (TheGame.GameDisplayChanger)this.<_gameDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CameraSceneLookupTable get__cameraSceneLookupTable()
        {
            return (CameraSceneLookupTable)this.<_cameraSceneLookupTable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__cameraSceneLookupTable(CameraSceneLookupTable value)
        {
            this.<_cameraSceneLookupTable>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraInfoRecorder(Game.EssenceCollection.EssenceCollectionDomain essenceCollectionDomain, Master.SceneLookupTableAccess sceneLookupTableAccess, Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain, Master.EventExposer masterEventExposer, Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator arObjectEvaluator, TheGame.GameDisplayChanger gameDisplay)
        {
            this.upperLeftViewport = 0;
            mem[1152921525373087416] = 0;
            this.upperRightViewport = 0;
            mem[1152921525373087428] = 0;
            this.lowerLeftViewport = 0;
            mem[1152921525373087440] = 0;
            this.lowerRightViewport = 0;
            mem[1152921525373087452] = 0;
            this._cameraFrames = new System.Collections.Generic.List<CameraInfoFrame>();
            val_2 = new System.Object();
            this.<_essenceCollectionDomain>k__BackingField = essenceCollectionDomain;
            this.<_arObjectDetectionDomain>k__BackingField = val_2;
            this.<_masterEventExposer>k__BackingField = masterEventExposer;
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_attackSequenceDomain>k__BackingField = attackSequenceDomain;
            this.<_arObjectEvaluator>k__BackingField = arObjectEvaluator;
            this.<_gameDisplay>k__BackingField = gameDisplay;
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder::SetCameraSceneLookupTable(CameraSceneLookupTable cameraSceneLookupTable)));
            this.<_arObjectDetectionDomain>k__BackingField.EventExposer.add_OnObjectDetectionBeginEvent(value:  new System.Action(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder::EventExposerOnOnObjectDetectionBeginEvent()));
            this.<_arObjectDetectionDomain>k__BackingField.EventExposer.add_OnObjectDetectionUpdatedEvent(value:  new System.Action<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[]>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder::EventExposerOnOnObjectDetectionUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)));
            this.<_masterEventExposer>k__BackingField.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder::MasterEventExposerOnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCameraSceneLookupTable(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this.<_cameraSceneLookupTable>k__BackingField = cameraSceneLookupTable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnOnObjectDetectionBeginEvent()
        {
            this.StartCameraInformationRecording();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnOnObjectDetectionUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)
        {
            this.ProcessObjectsDetected(detectedObjects:  detectedObjects);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MasterEventExposerOnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)
        {
            this._featureAllowed = data.IsEssenceAllowed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForceSpawnNow()
        {
            Master.EventExposer val_9;
            Game.EssenceCollection.Data.MasterDataConnector val_10;
            float val_11;
            val_9 = this;
            if(this.CanDoEssenceNow() == false)
            {
                    return;
            }
            
            if(this._recordingIsOn != true)
            {
                    this.StartCameraInformationRecording();
                this.RecordThisFrame();
            }
            
            this._recordingIsOn = false;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] val_2 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[1];
            string val_5 = "ForcedSpawn_" + TheGame.ServerTime.GetCurrentTime().ToString();
            val_10 = this.<_masterDataConnector>k__BackingField;
            if(val_10 == null)
            {
                goto label_3;
            }
            
            val_11 = this.<_masterDataConnector>k__BackingField.CloakDecloak_CenterOfScreenMinX;
            goto label_4;
            label_3:
            val_11 = this.<_masterDataConnector>k__BackingField.CloakDecloak_CenterOfScreenMinX;
            if((this.<_masterDataConnector>k__BackingField) == null)
            {
                goto label_5;
            }
            
            val_10 = this.<_masterDataConnector>k__BackingField;
            label_4:
            label_12:
            label_13:
            val_2[2] = 0;
            val_2[0] = 0;
            bool[] val_6 = new bool[1];
            val_6[0] = true;
            val_9 = this.<_masterEventExposer>k__BackingField;
            val_9.OnEssenceTrackerSessionCompleted(trackerSessionPackage:  new TrackerSessionPackage() {cameraInfoFrames = this._cameraFrames.ToArray(), detectedObjects = val_2, canSelectObjectEvaluations = val_6});
            return;
            label_5:
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                goto label_12;
            }
            
            if((this.<_masterDataConnector>k__BackingField) != null)
            {
                goto label_13;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartCameraInformationRecording()
        {
            this._cameraFrames.Clear();
            if(this.CanDoEssenceNow() == false)
            {
                    return;
            }
            
            this._recordingIsOn = true;
            this._currentDistanceToUse = this.<_masterDataConnector>k__BackingField.Detect_DistanceFromCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecordThisFrame()
        {
            UnityEngine.Vector3 val_1 = this.ProjectPointForwards(viewportPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, distanceToUse:  1f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            float val_17 = -90f;
            val_2.z = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, to:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) + val_17;
            float val_16 = System.Math.Abs(val_2.z);
            val_17 = val_16 / val_17;
            val_16 = val_17 + 1f;
            float val_5 = UnityEngine.Mathf.Lerp(a:  this._currentDistanceToUse * 0.33f, b:  this._currentDistanceToUse, t:  val_16);
            UnityEngine.Vector3 val_8 = this._cameraToUse.transform.position;
            UnityEngine.Quaternion val_10 = this._cameraToUse.transform.rotation;
            UnityEngine.Vector3 val_11 = this.ProjectPointForwards(viewportPoint:  new UnityEngine.Vector3() {x = this.upperLeftViewport, y = val_10.y, z = val_10.z}, distanceToUse:  val_5);
            UnityEngine.Vector3 val_12 = this.ProjectPointForwards(viewportPoint:  new UnityEngine.Vector3() {x = this.upperRightViewport, y = val_11.y, z = val_5}, distanceToUse:  val_5);
            UnityEngine.Vector3 val_13 = this.ProjectPointForwards(viewportPoint:  new UnityEngine.Vector3() {x = this.lowerLeftViewport, y = val_12.y, z = val_5}, distanceToUse:  val_5);
            UnityEngine.Vector3 val_14 = this.ProjectPointForwards(viewportPoint:  new UnityEngine.Vector3() {x = this.lowerRightViewport, y = val_13.y, z = val_5}, distanceToUse:  val_5);
            this._currentDistanceToUse = UnityEngine.Mathf.Lerp(a:  this._currentDistanceToUse, b:  1f, t:  0.75f);
            this._cameraFrames.Add(item:  new CameraInfoFrame() {timestamp = UnityEngine.Time.time, cameraPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, cameraRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, upperLeftProjectedPoint = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, upperRightProjectedPoint = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, lowerLeftProjectedPoint = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, lowerRightProjectedPoint = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 ProjectPointForwards(UnityEngine.Vector3 viewportPoint, float distanceToUse)
        {
            UnityEngine.Vector3 val_1 = this._cameraToUse.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessObjectsDetected(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)
        {
            System.Boolean[] val_7;
            if(this._recordingIsOn == false)
            {
                    return;
            }
            
            this._recordingIsOn = false;
            if(this.CanDoEssenceNow() == false)
            {
                    return;
            }
            
            bool[] val_2 = new bool[0];
            val_7 = val_2;
            if(detectedObjects.Length >= 1)
            {
                    do
            {
                val_7[0] = this.<_arObjectEvaluator>k__BackingField.CanSelectObject(detectedObject:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = detectedObjects[0], minX = detectedObjects[0], minY = detectedObjects[0], maxX = detectedObjects[0], maxY = detectedObjects[0], conf = detectedObjects[0]});
            }
            while((0 + 1) < detectedObjects.Length);
            
            }
            
            this.<_masterEventExposer>k__BackingField.OnEssenceTrackerSessionCompleted(trackerSessionPackage:  new TrackerSessionPackage() {cameraInfoFrames = this._cameraFrames.ToArray(), detectedObjects = detectedObjects, canSelectObjectEvaluations = val_2});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanDoEssenceNow()
        {
            bool val_6 = this._featureAllowed;
            if(val_6 == false)
            {
                    return (bool)val_6 & 1;
            }
            
            if((this.<_gameDisplay>k__BackingField.GetDisplayType()) == 1)
            {
                    if(this.IsCameraReady() != false)
            {
                    if((this.<_attackSequenceDomain>k__BackingField.IsInEncounter()) == false)
            {
                goto label_5;
            }
            
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
            label_5:
            bool val_6 = (this.<_essenceCollectionDomain>k__BackingField.RewardsFlowActive) ^ 1;
            return (bool)val_6 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCameraReady()
        {
            return UnityEngine.Object.op_Implicit(exists:  this._cameraToUse);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToGetCamera()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_cameraSceneLookupTable>k__BackingField)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._cameraToUse)) == true)
            {
                    return;
            }
            
            this._cameraToUse = this.<_cameraSceneLookupTable>k__BackingField.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.IsCameraReady() != true)
            {
                    this.TryToGetCamera();
            }
            
            if(this._recordingIsOn == false)
            {
                    return;
            }
            
            this.RecordThisFrame();
        }
    
    }

}
