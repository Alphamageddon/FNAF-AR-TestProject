using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActivityLogData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string animatronicName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string senderName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.StateData.AnimatronicState animatronicState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite iconSprite;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime orderedDateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime lastUpdateDateTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActivityLogData(AnimatronicEntity.AnimatronicEntity entity, UnityEngine.Sprite icon)
        {
            val_1 = new System.Object();
            if(entity != null)
            {
                    this.id = entity.entityId;
            }
            else
            {
                    this.id = 0.entityId;
            }
            
            this.animatronicName = entity.animatronicConfigData.PlushSuitData.AnimatronicName;
            this.animatronicState = entity.stateData.animatronicState;
            this.iconSprite = val_1;
            this.senderName = "USERNAME";
            System.DateTime val_9 = System.DateTime.Now;
            this.orderedDateTime = 0;
            this.lastUpdateDateTime = val_9;
        }
    
    }

}
