using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideNode
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Uid;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideEvent[] Events;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] EventArgs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.NodeEventData EventData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideCondition[] Conditions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] ConditionArgs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideAction Action;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ActionArgs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.ActionProcessors.IActionData ActionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.GuideResolution Resolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ResolutionArgs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Guide.NodeResolutionData ResolutionData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideNode()
        {
            this.EventData = new Systems.Guide.NodeEventData();
            this.ResolutionData = new Systems.Guide.NodeResolutionData();
        }
    
    }

}
