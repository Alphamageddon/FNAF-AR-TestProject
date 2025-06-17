using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopStageView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform workshopStageTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform cameraTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 workshopCameraPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 workshopModifyCameraPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStage workshopStage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int lastSelectedSlotIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string lastSelectedPlushSuitId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 desiredCamPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> requestedSpawnIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWorkshopCamPos()
        {
            this.desiredCamPos = this.workshopCameraPos;
            mem[1152921524957774512] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWorkshopModifyCamPos()
        {
            this.desiredCamPos = this.workshopModifyCameraPos;
            mem[1152921524957886512] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetCameraRotation()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.cameraTransform.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RotateCamera(UnityEngine.Vector3 prev, UnityEngine.Vector3 curr)
        {
            float val_3 = (float)UnityEngine.Screen.width;
            val_3 = val_3 * 0.5f;
            val_3 = 180f / val_3;
            val_3 = (curr.x - prev.x) * val_3;
            this.cameraTransform.Rotate(xAngle:  0f, yAngle:  val_3, zAngle:  0f, relativeTo:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsWaitingForSpawn()
        {
            var val_2;
            if(this.requestedSpawnIds != null)
            {
                    if(this.requestedSpawnIds.Count > 0)
            {
                    val_2 = 1;
                return (bool)val_2;
            }
            
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToSpawnWorkshopAnimatronic()
        {
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            if(val_1 == null)
            {
                    return;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_3 = val_1.DisplayEndoskeleton;
            if((this.workshopSlotDataModel.GetSelectedSlotDataIndex() == this.lastSelectedSlotIndex) && ((System.String.op_Inequality(a:  val_3.plushSuit, b:  this.lastSelectedPlushSuitId)) != true))
            {
                    return;
            }
            
            this.SpawnWorkshopAnimatronic();
            this.ResetCameraRotation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCameraPosition()
        {
            this.cameraTransform.localPosition = new UnityEngine.Vector3() {x = this.desiredCamPos, y = V9.16B, z = V10.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnWorkshopAnimatronic()
        {
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_2 = val_1.DisplayEndoskeleton;
            this.lastSelectedSlotIndex = this.workshopSlotDataModel.GetSelectedSlotDataIndex();
            this.lastSelectedPlushSuitId = val_2.plushSuit;
            this.requestedSpawnIds.Add(item:  val_2.plushSuit);
            .endoskeleton = val_1.DisplayEndoskeleton;
            this.workshopStage.RequestAnimatronicSpawn(workshopEntry:  new AnimatronicEntity.Data.WorkshopEntry(entryToCopy:  val_1.ServerEntry));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnComplete(string animatronicId)
        {
            bool val_1 = this.requestedSpawnIds.Remove(item:  animatronicId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Master.MasterDomain val_7;
            Master.EventExposer val_8;
            Master.MasterDomain val_9;
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.requestedSpawnIds = new System.Collections.Generic.List<System.String>();
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            val_7 = this._masterDomain;
            this.workshopSlotDataModel = val_3.gameUIData.emailUIDataHandler;
            if(val_7 == null)
            {
                goto label_3;
            }
            
            val_8 = this._masterDomain.eventExposer;
            val_9 = val_7;
            goto label_6;
            label_3:
            val_9 = this._masterDomain;
            val_8 = this._masterDomain.eventExposer;
            if(val_9 == null)
            {
                goto label_5;
            }
            
            val_7 = val_9;
            goto label_6;
            label_5:
            val_7 = this._masterDomain;
            if(val_7 == null)
            {
                goto label_7;
            }
            
            label_6:
            this.workshopStage = new GameUI.WorkshopStage(masterEventExposer:  val_8, animatronic3DAccess:  this._masterDomain.animatronic3DDomain, itemDefinitionAccess:  this._masterDomain.ItemDefinitionDomain, stageRootTransform:  this.workshopStageTransform, workshopStageView:  this, spawnCompleteCallback:  new System.Action<System.String>(object:  this, method:  System.Void GameUI.WorkshopStageView::SpawnComplete(string animatronicId)));
            return;
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.lastSelectedSlotIndex = 0;
            this.desiredCamPos = this.workshopCameraPos;
            mem[1152921524959198640] = ???;
            this.lastSelectedPlushSuitId = System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.TryToSpawnWorkshopAnimatronic();
            this.UpdateCameraPosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.workshopStage.ClearStage();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.workshopStage.Teardown();
            this.workshopStage = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopStageView()
        {
        
        }
    
    }

}
