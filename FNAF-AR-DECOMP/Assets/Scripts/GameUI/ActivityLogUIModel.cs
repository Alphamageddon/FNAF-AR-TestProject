using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActivityLogUIModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool dirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.ActivityLogData> _incomingActivityLogDatas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.ActivityLogData> _sentActivityLogDatas;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable incomingActivityLogDatas { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable sentActivityLogDatas { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable get_incomingActivityLogDatas()
        {
            return (System.Collections.IEnumerable)this._incomingActivityLogDatas;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerable get_sentActivityLogDatas()
        {
            return (System.Collections.IEnumerable)this._sentActivityLogDatas;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActivityLogUIModel()
        {
            this._incomingActivityLogDatas = new System.Collections.Generic.List<GameUI.ActivityLogData>();
            this._sentActivityLogDatas = new System.Collections.Generic.List<GameUI.ActivityLogData>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SortByStateData(GameUI.ActivityLogData p1, GameUI.ActivityLogData p2)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortIncomingActivityLogData()
        {
            this._incomingActivityLogDatas.Sort(comparison:  new System.Comparison<GameUI.ActivityLogData>(object:  this, method:  System.Int32 GameUI.ActivityLogUIModel::SortByStateData(GameUI.ActivityLogData p1, GameUI.ActivityLogData p2)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SortSentActivityLogData()
        {
            this._incomingActivityLogDatas.Sort(comparison:  new System.Comparison<GameUI.ActivityLogData>(object:  this, method:  System.Int32 GameUI.ActivityLogUIModel::SortByStateData(GameUI.ActivityLogData p1, GameUI.ActivityLogData p2)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetEntitySentIndex(string entityId, out bool found)
        {
            var val_6;
            found = false;
            List.Enumerator<T> val_1 = this._sentActivityLogDatas.GetEnumerator();
            val_6 = 0;
            goto label_2;
            label_5:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_2._masterDomain, b:  entityId)) == true)
            {
                goto label_4;
            }
            
            val_6 = 1;
            label_2:
            if(((-1200519592) & 1) != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            found = true;
            label_6:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524881163864});
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetEntityIncomingIndex(string entityId, out bool found)
        {
            var val_6;
            found = false;
            List.Enumerator<T> val_1 = this._incomingActivityLogDatas.GetEnumerator();
            val_6 = 0;
            goto label_2;
            label_5:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_2._masterDomain, b:  entityId)) == true)
            {
                goto label_4;
            }
            
            val_6 = 1;
            label_2:
            if(((-1200358600) & 1) != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            found = true;
            label_6:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524881324856});
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDirty(bool value)
        {
            var val_1 = (this.dirty == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.dirty = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDirty()
        {
            return (bool)this.dirty;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddIncomingActivityLogData(GameUI.ActivityLogData activityLogData)
        {
            this._incomingActivityLogDatas.Add(item:  activityLogData);
            this.SortIncomingActivityLogData();
            if(this.dirty == true)
            {
                    return;
            }
            
            this.dirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddSentActivityLogData(GameUI.ActivityLogData activityLogData)
        {
            this._sentActivityLogDatas.Add(item:  activityLogData);
            this.SortSentActivityLogData();
            if(this.dirty == true)
            {
                    return;
            }
            
            this.dirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetIncomingActvityLogSize()
        {
            if(this._incomingActivityLogDatas != null)
            {
                    return this._incomingActivityLogDatas.Count;
            }
            
            return this._incomingActivityLogDatas.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSentActivityLogSize()
        {
            if(this._sentActivityLogDatas != null)
            {
                    return this._sentActivityLogDatas.Count;
            }
            
            return this._sentActivityLogDatas.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIncomingActivityLogDataAtIndex(GameUI.ActivityLogData newActivityLogData, int index)
        {
            if(this._incomingActivityLogDatas.Count <= index)
            {
                    return;
            }
            
            this._incomingActivityLogDatas.set_Item(index:  index, value:  newActivityLogData);
            this.SortIncomingActivityLogData();
            if(this.dirty == true)
            {
                    return;
            }
            
            this.dirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIncomingActivityLogDataByEntityID(GameUI.ActivityLogData newActivityLogData, string entityId)
        {
            bool val_1 = false;
            if(val_1 == 0)
            {
                    return;
            }
            
            this.SetIncomingActivityLogDataAtIndex(newActivityLogData:  newActivityLogData, index:  this.GetEntityIncomingIndex(entityId:  entityId, found: out  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSentActivityLogDataAtIndex(GameUI.ActivityLogData newActivityLogData, int index)
        {
            if(this._sentActivityLogDatas.Count <= index)
            {
                    return;
            }
            
            this._sentActivityLogDatas.set_Item(index:  index, value:  newActivityLogData);
            this.SortSentActivityLogData();
            if(this.dirty == true)
            {
                    return;
            }
            
            this.dirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSentActivityLogDataByEntityID(GameUI.ActivityLogData newActivityLogData, string entityId)
        {
            bool val_1 = false;
            if(val_1 == 0)
            {
                    return;
            }
            
            this.SetSentActivityLogDataAtIndex(newActivityLogData:  newActivityLogData, index:  this.GetEntitySentIndex(entityId:  entityId, found: out  val_1));
        }
    
    }

}
