using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MovementNodeContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnNodeReset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _center;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<MapMode.MovementNode.LocationNode> _validMovementNodes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Center { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.MovementNode.LocationNode> ValidMovementNodes { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Center()
        {
            return new Mapbox.Utils.Vector2d() {x = this._center};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.MovementNode.LocationNode> get_ValidMovementNodes()
        {
            return (System.Collections.Generic.List<MapMode.MovementNode.LocationNode>)this._validMovementNodes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnNodeReset(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnNodeReset, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnNodeReset != 1152921524618335664);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnNodeReset(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnNodeReset, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnNodeReset != 1152921524618472240);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetCenter(Mapbox.Utils.Vector2d point)
        {
            this._center = point;
            mem[1152921524618596544] = point.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.MovementNode.LocationNode> GetAllValidNodes()
        {
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_1 = new System.Collections.Generic.List<MapMode.MovementNode.LocationNode>();
            val_1.AddRange(collection:  this._validMovementNodes);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearAllNodes()
        {
            this._validMovementNodes.Clear();
            if(this.OnNodeReset == null)
            {
                    return;
            }
            
            this.OnNodeReset.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterNodeReset(System.Action callback)
        {
            this.OnNodeReset = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementNodeContainer()
        {
            this._validMovementNodes = new System.Collections.Generic.List<MapMode.MovementNode.LocationNode>();
        }
    
    }

}
