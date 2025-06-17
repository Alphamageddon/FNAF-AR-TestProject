using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideNodeDriver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideNode> _listening;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideNode> _acting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideNode> _expiredLastFrame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideActionSharedContext _actionSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideConditionSharedContext _conditionSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideNode> _tempExpiring;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Systems.Guide.GuideNode> _tempResolving;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] Listening { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] Acting { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] ExpiredLastFrame { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] get_Listening()
        {
            if(this._listening != null)
            {
                    return this._listening.ToArray();
            }
            
            return this._listening.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] get_Acting()
        {
            if(this._acting != null)
            {
                    return this._acting.ToArray();
            }
            
            return this._acting.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideNode[] get_ExpiredLastFrame()
        {
            if(this._expiredLastFrame != null)
            {
                    return this._expiredLastFrame.ToArray();
            }
            
            return this._expiredLastFrame.ToArray();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Guide.GuideActionSharedContext actionSharedContext, Systems.Guide.GuideConditionSharedContext conditionSharedContext)
        {
            this._listening = new System.Collections.Generic.List<Systems.Guide.GuideNode>();
            this._acting = new System.Collections.Generic.List<Systems.Guide.GuideNode>();
            this._expiredLastFrame = new System.Collections.Generic.List<Systems.Guide.GuideNode>();
            this._actionSharedContext = actionSharedContext;
            this._conditionSharedContext = conditionSharedContext;
            this._tempExpiring = new System.Collections.Generic.List<Systems.Guide.GuideNode>();
            this._tempResolving = new System.Collections.Generic.List<Systems.Guide.GuideNode>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._actionSharedContext = 0;
            this._conditionSharedContext = 0;
            if(this._tempResolving != null)
            {
                    this._tempResolving.Clear();
            }
            
            this._tempResolving = 0;
            if(this._tempExpiring != null)
            {
                    this._tempExpiring.Clear();
            }
            
            this._tempExpiring = 0;
            if(this._expiredLastFrame != null)
            {
                    this._expiredLastFrame.Clear();
            }
            
            this._expiredLastFrame = 0;
            if(this._acting != null)
            {
                    this._acting.Clear();
            }
            
            this._acting = 0;
            if(this._listening != null)
            {
                    this._listening.Clear();
            }
            
            this._listening = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_9;
            var val_10;
            var val_11;
            this._expiredLastFrame.Clear();
            val_9 = 0;
            goto label_2;
            label_8:
            Systems.Guide.GuideNode val_1 = this._acting.Item[0];
            Systems.Guide.GuideActionInterpreter.UpdateAction(node:  val_1, actionSharedContext:  this._actionSharedContext);
            if((Systems.Guide.GuideActionInterpreter.ShouldComplete(node:  val_1, actionSharedContext:  this._actionSharedContext)) != false)
            {
                    Systems.Guide.GuideActionInterpreter.CompleteAction(node:  val_1, actionSharedContext:  this._actionSharedContext);
                this._tempExpiring.Add(item:  val_1);
                this._tempResolving.Add(item:  val_1);
            }
            
            val_9 = 1;
            label_2:
            if(val_9 < this._acting.Count)
            {
                goto label_8;
            }
            
            val_10 = 0;
            goto label_9;
            label_13:
            bool val_5 = this._acting.Remove(item:  this._tempExpiring.Item[0]);
            val_10 = 1;
            label_9:
            if(val_10 < this._tempExpiring.Count)
            {
                goto label_13;
            }
            
            this._expiredLastFrame.AddRange(collection:  this._tempExpiring);
            this._tempExpiring.Clear();
            val_11 = 0;
            goto label_16;
            label_19:
            Systems.Guide.GuideResolutionInterpreter.ResolveNode(node:  this._tempExpiring.Item[0], instance:  this);
            val_11 = 1;
            label_16:
            if(val_11 < this._tempResolving.Count)
            {
                goto label_19;
            }
            
            this._tempResolving.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadNode(Systems.Guide.GuideNode node)
        {
            Systems.Guide.GuideNode val_4 = node;
            if((Systems.Guide.GuideEventInterpreter.EvaluateEvent(guideEvent:  0, eventArg:  System.String.alignConst, node:  val_4 = node, triggeringIndex: out  0)) != false)
            {
                    if((Systems.Guide.GuideConditionInterpreter.EvaluateAllConditions(node:  val_4, context:  this._conditionSharedContext)) == false)
            {
                    return;
            }
            
                this._acting.Add(item:  val_4);
                Systems.Guide.GuideActionInterpreter.ActivateListeningNode(node:  val_4, actionSharedContext:  this._actionSharedContext);
                val_4 = node.Uid;
                Systems.Analytics.AnalyticsCalls.FireEvent_GuideNodeActivated(nodeId:  val_4);
                return;
            }
            
            this._listening.Add(item:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessEvent(Systems.Guide.GuideEvent guideEvent, string argument)
        {
            var val_8;
            var val_9;
            val_8 = 0;
            goto label_1;
            label_11:
            Systems.Guide.GuideNode val_1 = this._listening.Item[0];
            if((this.ValidateTriggers(node:  val_1, guideEvent:  guideEvent, argument:  argument, triggeringIndex: out  0)) != false)
            {
                    val_1.EventData.Index = 0;
                this._tempExpiring.Add(item:  val_1);
                this._acting.Add(item:  val_1);
                Systems.Guide.GuideActionInterpreter.ActivateListeningNode(node:  val_1, actionSharedContext:  this._actionSharedContext);
                Systems.Analytics.AnalyticsCalls.FireEvent_GuideNodeActivated(nodeId:  val_1.Uid);
            }
            
            val_8 = 1;
            label_1:
            if(val_8 < this._listening.Count)
            {
                goto label_11;
            }
            
            val_9 = 0;
            goto label_12;
            label_16:
            bool val_6 = this._listening.Remove(item:  this._tempExpiring.Item[0]);
            val_9 = 1;
            label_12:
            if(val_9 < this._tempExpiring.Count)
            {
                goto label_16;
            }
            
            this._expiredLastFrame.AddRange(collection:  this._tempExpiring);
            this._tempExpiring.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearAllTutorials()
        {
            this._acting.Clear();
            this._listening.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidateTriggers(Systems.Guide.GuideNode node, Systems.Guide.GuideEvent guideEvent, string argument, out int triggeringIndex)
        {
            if((Systems.Guide.GuideEventInterpreter.EvaluateEvent(guideEvent:  guideEvent, eventArg:  argument, node:  node, triggeringIndex: out  1152921523380363936)) == false)
            {
                    return false;
            }
            
            return Systems.Guide.GuideConditionInterpreter.EvaluateAllConditions(node:  node, context:  this._conditionSharedContext);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideNodeDriver()
        {
        
        }
    
    }

}
