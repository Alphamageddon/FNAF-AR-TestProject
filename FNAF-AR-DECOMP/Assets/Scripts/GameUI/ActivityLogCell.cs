using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActivityLogCell : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text modelName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text statusText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text sentByText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text lastUpdateDateTimeText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text orderedDateTimeText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string preAttackString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string attackString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string postAttackString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string attackCompleteString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ActivityLogData activityLogData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetStateFormatted(AnimatronicEntity.StateData.AnimatronicState animatronicState)
        {
            string val_1;
            if(animatronicState < 3)
            {
                goto label_0;
            }
            
            if(animatronicState != 3)
            {
                goto label_1;
            }
            
            val_1 = this.attackString;
            return (string)mem[this.attackCompleteString];
            label_0:
            val_1 = this.preAttackString;
            return (string)mem[this.attackCompleteString];
            label_1:
            val_1 = this.attackCompleteString;
            return (string)mem[this.attackCompleteString];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string FormatTimeSpan(System.TimeSpan elapsed)
        {
            return (string)System.String.Format(format:  "{0:00}d {1:00}h ago", arg0:  elapsed._ticks.Days, arg1:  elapsed._ticks.Hours);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVisuals()
        {
            string val_7;
            if(this.activityLogData.animatronicState < 3)
            {
                goto label_4;
            }
            
            if(this.activityLogData.animatronicState != 3)
            {
                goto label_5;
            }
            
            val_7 = this.attackString;
            goto label_7;
            label_4:
            val_7 = this.preAttackString;
            goto label_7;
            label_5:
            val_7 = this.attackCompleteString;
            label_7:
            System.DateTime val_1 = System.DateTime.Now;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.activityLogData.orderedDateTime});
            System.DateTime val_3 = System.DateTime.Now;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = this.activityLogData.lastUpdateDateTime});
            string val_6 = val_4._ticks.FormatTimeSpan(elapsed:  new System.TimeSpan() {_ticks = val_2._ticks}).FormatTimeSpan(elapsed:  new System.TimeSpan() {_ticks = val_4._ticks});
            this.icon.overrideSprite = this.activityLogData.iconSprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetActivityLogData(GameUI.ActivityLogData activityLogData)
        {
            this.activityLogData = activityLogData;
            this.UpdateVisuals();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActivityLogCell()
        {
        
        }
    
    }

}
