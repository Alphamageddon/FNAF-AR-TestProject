using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceAngleCalculator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera <_mainCamera>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera get__mainCamera()
        {
            return (UnityEngine.Camera)this.<_mainCamera>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__mainCamera(UnityEngine.Camera value)
        {
            this.<_mainCamera>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceAngleCalculator(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Master.SceneLookupTableAccess sceneLookupTableAccess)
        {
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this.<_mainCamera>k__BackingField = cameraSceneLookupTable.ForegroundCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetAngleToEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_mainCamera>k__BackingField)) == false)
            {
                    return 180f;
            }
            
            UnityEngine.Vector3 val_4 = essenceNode.EssenceVisual.transform.position;
            UnityEngine.Vector3 val_6 = this.<_mainCamera>k__BackingField.transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_9 = this.<_mainCamera>k__BackingField.transform.forward;
            return UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, to:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAngleMagnitudeToEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            Game.EssenceCollection.Data.MasterDataConnector val_2;
            float val_3;
            val_2 = this;
            if((this.<_masterDataConnector>k__BackingField.GeigerCounter_MaxAngleDetect) > 0f)
            {
                    val_2 = this.<_masterDataConnector>k__BackingField;
                val_3 = (this.GetAngleToEssence(essenceNode:  essenceNode)) / (this.<_masterDataConnector>k__BackingField.GeigerCounter_MaxAngleDetect);
                return UnityEngine.Mathf.Clamp(value:  val_3 = 1f, min:  0f, max:  1f);
            }
            
            return UnityEngine.Mathf.Clamp(value:  val_3, min:  0f, max:  1f);
        }
    
    }

}
