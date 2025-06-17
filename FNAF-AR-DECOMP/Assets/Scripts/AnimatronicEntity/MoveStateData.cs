using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MoveStateData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode <startNode>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode <endNode>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <nodeCounter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <maxNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <timeElapsed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <nodeTravelTime>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode startNode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode endNode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int nodeCounter { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int maxNodes { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeElapsed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float nodeTravelTime { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode get_startNode()
        {
            return (MapMode.MovementNode.LocationNode)this.<startNode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_startNode(MapMode.MovementNode.LocationNode value)
        {
            this.<startNode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode get_endNode()
        {
            return (MapMode.MovementNode.LocationNode)this.<endNode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_endNode(MapMode.MovementNode.LocationNode value)
        {
            this.<endNode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_nodeCounter()
        {
            return (int)this.<nodeCounter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_nodeCounter(int value)
        {
            this.<nodeCounter>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_maxNodes()
        {
            return (int)this.<maxNodes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_maxNodes(int value)
        {
            this.<maxNodes>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_timeElapsed()
        {
            return (float)this.<timeElapsed>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timeElapsed(float value)
        {
            this.<timeElapsed>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_nodeTravelTime()
        {
            return (float)this.<nodeTravelTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_nodeTravelTime(float value)
        {
            this.<nodeTravelTime>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoveStateData()
        {
            this.<timeElapsed>k__BackingField = 0f;
            this.<nodeCounter>k__BackingField = 0;
            this.<startNode>k__BackingField = 0;
            this.<endNode>k__BackingField = 0;
            this.<maxNodes>k__BackingField = UnityEngine.Random.Range(min:  2, max:  5);
            this.<nodeTravelTime>k__BackingField = (float)UnityEngine.Random.Range(min:  30, max:  45);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoveStateData(AnimatronicEntity.MoveStateData moveStateData)
        {
            if(moveStateData != null)
            {
                    this.<startNode>k__BackingField = moveStateData.<startNode>k__BackingField;
                this.SetEndNode(newNode:  moveStateData.<endNode>k__BackingField);
                this.<nodeCounter>k__BackingField = moveStateData.<nodeCounter>k__BackingField;
                this.<maxNodes>k__BackingField = moveStateData.<maxNodes>k__BackingField;
                this.<timeElapsed>k__BackingField = moveStateData.<timeElapsed>k__BackingField;
            }
            else
            {
                    this.<startNode>k__BackingField = 11993091;
                this.SetEndNode(newNode:  15026800);
                this.<nodeCounter>k__BackingField = 64;
                this.<maxNodes>k__BackingField = 0;
                this.<timeElapsed>k__BackingField = 1.85775E-36f;
            }
            
            this.<nodeTravelTime>k__BackingField = moveStateData.<nodeTravelTime>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveToNextPoint(MapMode.MovementNode.LocationNode newNode)
        {
            this.<startNode>k__BackingField = this.<endNode>k__BackingField;
            this.SetEndNode(newNode:  newNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEndNode(MapMode.MovementNode.LocationNode newNode)
        {
            if((this.<endNode>k__BackingField) != null)
            {
                    this.<endNode>k__BackingField.Occupied = (this.<endNode>k__BackingField.Occupied) - 1;
            }
            
            this.<endNode>k__BackingField = newNode;
            if(newNode == null)
            {
                    return;
            }
            
            newNode.Occupied = newNode.Occupied + 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[6];
            val_1[0] = "Current Index: ";
            val_1[1] = this.<nodeCounter>k__BackingField;
            val_1[2] = "Moving from ";
            val_1[3] = this.<startNode>k__BackingField;
            val_1[4] = " to ";
            val_1[5] = this.<endNode>k__BackingField;
            return (string)+val_1;
        }
    
    }

}
