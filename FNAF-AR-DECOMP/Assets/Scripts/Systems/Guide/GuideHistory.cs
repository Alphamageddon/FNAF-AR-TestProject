using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideHistory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int HISTORY_LENGTH = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideHistory.FrameSnapshot[] _frameSnapshots;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _driver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideHistory.NodeContext> _cachedDeliverableContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, Systems.Guide.GuideHistory.NodeContext> _tempContextMap;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideHistory.NodeContext[] DeliverableContext { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Guide.GuideNodeDriver driver)
        {
            this._cachedDeliverableContext = new System.Collections.Generic.List<NodeContext>();
            this._tempContextMap = new System.Collections.Generic.Dictionary<System.Int32, NodeContext>();
            this._frameSnapshots = new FrameSnapshot[100];
            this._driver = driver;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._frameSnapshots = 0;
            this._cachedDeliverableContext = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideHistory.NodeContext[] get_DeliverableContext()
        {
            if(this._cachedDeliverableContext != null)
            {
                    return this._cachedDeliverableContext.ToArray();
            }
            
            return this._cachedDeliverableContext.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateFrame()
        {
            GuideHistory.FrameSnapshot val_1 = new GuideHistory.FrameSnapshot(driver:  this._driver);
            this.ProcessHistoryIntoContext(frame:  val_1);
            this.ShiftFrames();
            this.AppendFrame(frame:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessHistoryIntoContext(Systems.Guide.GuideHistory.FrameSnapshot frame)
        {
            var val_1;
            this._tempContextMap.Clear();
            if(frame != null)
            {
                    this.AppendNodesToTempContextMapIfNotPresent(nodes:  frame.acting, state:  1);
            }
            else
            {
                    this.AppendNodesToTempContextMapIfNotPresent(nodes:  15026800, state:  1);
            }
            
            this.AppendNodesToTempContextMapIfNotPresent(nodes:  frame.expired, state:  1);
            val_1 = 0;
            goto label_4;
            label_15:
            if(this._frameSnapshots[0] != null)
            {
                    FrameSnapshot val_2 = this._frameSnapshots[0];
                this.AppendNodesToTempContextMapIfNotPresent(nodes:  this._frameSnapshots[0x0][0].acting, state:  2);
                FrameSnapshot val_3 = this._frameSnapshots[0];
                this.AppendNodesToTempContextMapIfNotPresent(nodes:  this._frameSnapshots[0x0][0].expired, state:  2);
            }
            
            val_1 = 1;
            label_4:
            if(val_1 < this._frameSnapshots.Length)
            {
                goto label_15;
            }
            
            this.AppendNodesToTempContextMapIfNotPresent(nodes:  frame.listening, state:  0);
            this.CompileTempContextIntoDeliverableContext();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AppendNodesToTempContextMapIfNotPresent(Systems.Guide.GuideNode[] nodes, Systems.Guide.GuideHistory.NodeState state)
        {
            goto label_1;
            label_8:
            Systems.Guide.GuideNode val_3 = nodes[0];
            int val_1 = val_3.GetHashCode();
            if((this._tempContextMap.ContainsKey(key:  val_1)) != true)
            {
                    this._tempContextMap.set_Item(key:  val_1, value:  new NodeContext() {node = val_3, state = state});
            }
            
            0 = 1;
            label_1:
            if(0 < nodes.Length)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CompileTempContextIntoDeliverableContext()
        {
            var val_3;
            var val_9;
            this._cachedDeliverableContext.Clear();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._tempContextMap.Values.GetEnumerator();
            label_6:
            if((1580044608 & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_3.trackableId;
            this._cachedDeliverableContext.Add(item:  new NodeContext() {node = val_5.m_SubId1, state = val_5.m_SubId2});
            goto label_6;
            label_4:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523366760768});
            val_9 = null;
            val_9 = null;
            if((GuideHistory.<>c.<>9__15_0) == null)
            {
                goto label_13;
            }
            
            label_18:
            this._cachedDeliverableContext.Sort(comparison:  GuideHistory.<>c.<>9__15_0);
            return;
            label_13:
            GuideHistory.<>c.<>9__15_0 = new System.Comparison<NodeContext>(object:  GuideHistory.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GuideHistory.<>c::<CompileTempContextIntoDeliverableContext>b__15_0(Systems.Guide.GuideHistory.NodeContext x, Systems.Guide.GuideHistory.NodeContext y));
            if(this._cachedDeliverableContext != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShiftFrames()
        {
            var val_5 = 0;
            do
            {
                var val_1 = val_5 + 98;
                var val_2 = val_5 + 99;
                val_5 = val_5 - 1;
                this._frameSnapshots[val_5] = this._frameSnapshots[val_5];
            }
            while((val_5 + 99) > 1);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AppendFrame(Systems.Guide.GuideHistory.FrameSnapshot frame)
        {
            if(this._frameSnapshots == null)
            {
                goto label_0;
            }
            
            if(frame != null)
            {
                goto label_1;
            }
            
            goto label_4;
            label_0:
            if(frame == null)
            {
                goto label_4;
            }
            
            label_1:
            label_4:
            this._frameSnapshots[0] = frame;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideHistory()
        {
        
        }
    
    }

}
