using UnityEngine;

namespace Systems.ARObjectDetection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Listener
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float LogFrequency = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float minConfidenceForRecord = 0.7;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.ARObjectDetectionDomain _arObjectDetectionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Wintellect.PowerCollections.OrderedSet<Systems.ARObjectDetection.Data.DetectedObject> _detectedObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float LastTimeLogged;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Listener(Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain)
        {
            this._arObjectDetectionDomain = arObjectDetectionDomain;
            this.LastTimeLogged = 0f;
            this._detectedObjects = new Wintellect.PowerCollections.OrderedSet<Systems.ARObjectDetection.Data.DetectedObject>();
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.add_BeginEvent(value:  new IxObjectDetectionDeliverer.Begin(object:  this, method:  System.Void Systems.ARObjectDetection.Listener::IxObjectDetectionDelivererOnBeginEvent()));
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.add_UpdatedEvent(value:  new IxObjectDetectionDeliverer.Update(object:  this, method:  System.Void Systems.ARObjectDetection.Listener::IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxObjectDetectionDelivererOnBeginEvent()
        {
            if((this._arObjectDetectionDomain.<EventExposer>k__BackingField.OnObjectDetectionBeginEvent) == null)
            {
                    return;
            }
            
            this._arObjectDetectionDomain.<EventExposer>k__BackingField.OnObjectDetectionBeginEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxObjectDetectionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)
        {
            this.UpdateDetectedObjectCounts(detections:  detections);
            this.LogToAnalytics();
            this._arObjectDetectionDomain.<EventExposer>k__BackingField.TriggerOnObjectDetectionUpdatedEvent(detectedObjects:  detections);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDetectedObjectCounts(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)
        {
            var val_6;
            System.Func<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection, System.String> val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            val_8 = Listener.<>c.<>9__8_0;
            if(val_8 == null)
            {
                    System.Func<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection, System.String> val_1 = null;
                val_8 = val_1;
                val_1 = new System.Func<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection, System.String>(object:  Listener.<>c.__il2cppRuntimeField_static_fields, method:  System.String Listener.<>c::<UpdateDetectedObjectCounts>b__8_0(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection x));
                Listener.<>c.<>9__8_0 = val_8;
            }
            
            string val_4 = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection, System.String>(source:  detections, selector:  val_1)));
            val_9 = 0;
            goto label_6;
            label_10:
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection val_7 = detections[0];
            if(val_7 < 0)
            {
                    SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] val_8 = detections[0][32];
                this.AddOrUpdateDetectedObject(ixObjectDetection:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = detections[0], minX = detections[0], minY = detections[0], maxX = detections[0], maxY = detections[0], conf = val_7});
            }
            
            val_9 = 1;
            label_6:
            if(val_9 < detections.Length)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddOrUpdateDetectedObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection ixObjectDetection)
        {
            System.Collections.Generic.IEnumerable<Systems.ARObjectDetection.Data.DetectedObject> val_1 = this.FindExistingObjectsOfSameType(ixObjectDetection:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = ixObjectDetection.objectType, minX = 1.169185E+21f, minY = 2.524356E-29f, maxX = ixObjectDetection.maxX});
            if((System.Linq.Enumerable.Any<Systems.ARObjectDetection.Data.DetectedObject>(source:  val_1)) != false)
            {
                    this.UpdateExistingObject(foundObject:  System.Linq.Enumerable.First<Systems.ARObjectDetection.Data.DetectedObject>(source:  val_1));
                return;
            }
            
            this.AddNewObject(ixObjectDetection:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection() {objectType = ixObjectDetection.objectType, minX = 1.169185E+21f, minY = 2.524356E-29f, maxX = ixObjectDetection.maxX});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateExistingObject(Systems.ARObjectDetection.Data.DetectedObject foundObject)
        {
            var val_2;
            int val_3;
            if(foundObject != null)
            {
                    val_2 = foundObject;
                val_3 = foundObject.numTimesSeen;
            }
            else
            {
                    val_2 = 24;
                val_3 = 15026800;
            }
            
            mem[24] = 15026801;
            bool val_1 = this._detectedObjects.Add(item:  foundObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddNewObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection ixObjectDetection)
        {
            Systems.ARObjectDetection.Data.DetectedObject val_1 = new Systems.ARObjectDetection.Data.DetectedObject();
            if(val_1 != null)
            {
                    .objectType = ixObjectDetection.objectType;
            }
            else
            {
                    mem[16] = ixObjectDetection.objectType;
            }
            
            .numTimesSeen = 1;
            bool val_2 = this._detectedObjects.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.IEnumerable<Systems.ARObjectDetection.Data.DetectedObject> FindExistingObjectsOfSameType(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection ixObjectDetection)
        {
            mem[1152921523439547120] = ixObjectDetection.maxX;
            .ixObjectDetection = ixObjectDetection.objectType;
            System.Predicate<Systems.ARObjectDetection.Data.DetectedObject> val_2 = new System.Predicate<Systems.ARObjectDetection.Data.DetectedObject>(object:  new Listener.<>c__DisplayClass12_0(), method:  System.Boolean Listener.<>c__DisplayClass12_0::<FindExistingObjectsOfSameType>g__Predicate|0(Systems.ARObjectDetection.Data.DetectedObject o));
            if(this._detectedObjects != null)
            {
                    return (System.Collections.Generic.IEnumerable<Systems.ARObjectDetection.Data.DetectedObject>)this._detectedObjects;
            }
            
            return (System.Collections.Generic.IEnumerable<Systems.ARObjectDetection.Data.DetectedObject>)this._detectedObjects;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LogToAnalytics()
        {
            float val_3 = this.LastTimeLogged;
            val_3 = val_3 + 5f;
            if(UnityEngine.Time.time <= val_3)
            {
                    return;
            }
            
            Systems.Analytics.AnalyticsCalls.FireEvent_AR_ObjectsDetected(detectedObjects:  this._detectedObjects);
            this.LastTimeLogged = UnityEngine.Time.time;
        }
    
    }

}
