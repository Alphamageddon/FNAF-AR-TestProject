using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FallbackNode
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode <Node>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Distance>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode Node { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Distance { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode get_Node()
        {
            return (MapMode.MovementNode.LocationNode)this.<Node>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Node(MapMode.MovementNode.LocationNode value)
        {
            this.<Node>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Distance()
        {
            return (double)this.<Distance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Distance(double value)
        {
            this.<Distance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FallbackNode()
        {
            this.<Node>k__BackingField = 0;
            this.<Distance>k__BackingField = -2.2250738585072E-308;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateFallback(MapMode.MovementNode.FallbackNode fallback)
        {
            MapMode.MovementNode.LocationNode val_1;
            if(fallback != null)
            {
                    val_1 = fallback.<Node>k__BackingField;
            }
            else
            {
                    val_1 = 11993091;
            }
            
            if((this.<Distance>k__BackingField) <= (fallback.<Distance>k__BackingField))
            {
                    return;
            }
            
            this.<Distance>k__BackingField = fallback.<Distance>k__BackingField;
            this.<Node>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateFallback(MapMode.MovementNode.LocationNode node, double distance)
        {
            if((this.<Distance>k__BackingField) <= distance)
            {
                    return;
            }
            
            this.<Distance>k__BackingField = distance;
            this.<Node>k__BackingField = node;
        }
    
    }

}
