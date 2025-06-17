using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SimulatedGuideEventAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Systems.Guide.SimulatedGuideEventAdapter LastInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _nodeDriver;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SimulatedGuideEventAdapter()
        {
            Systems.Guide.SimulatedGuideEventAdapter.LastInstance = this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Guide.GuideNodeDriver nodeDriver)
        {
            this._nodeDriver = nodeDriver;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._nodeDriver = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ActivateNode(string nodeUid)
        {
            this._nodeDriver.LoadNode(node:  Systems.Guide.GuideFactory.GenerateNode(uid:  nodeUid));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimulateClockSecond()
        {
            this._nodeDriver.ProcessEvent(guideEvent:  1, argument:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimulateScreenOpen(string screenName)
        {
            this._nodeDriver.ProcessEvent(guideEvent:  2, argument:  screenName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimulateScreenClose(string screenName)
        {
            this._nodeDriver.ProcessEvent(guideEvent:  3, argument:  screenName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InjectManualNode(Systems.Guide.GuideNode node)
        {
            this._nodeDriver.LoadNode(node:  node);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SimulateUiClick(string buttonIdentifier)
        {
            this._nodeDriver.ProcessEvent(guideEvent:  4, argument:  buttonIdentifier);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void KillAllActiveNodes()
        {
            this._nodeDriver.ClearAllTutorials();
        }
    
    }

}
