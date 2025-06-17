using UnityEngine;

namespace MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MapMode.PlayerTarget <PlayerTarget>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.ApproachModeZoomListener <approachModeZoomListener>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain MasterDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeDomain movementNodeDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget PlayerTarget { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.ApproachModeZoomListener approachModeZoomListener { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain get_MasterDomain()
        {
            return (Master.MasterDomain)this.masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeDomain get_movementNodeDomain()
        {
            if(this.masterDomain != null)
            {
                    return (MapMode.MovementNode.MovementNodeDomain)this.masterDomain.MovementNodeDomain;
            }
            
            return (MapMode.MovementNode.MovementNodeDomain)this.masterDomain.MovementNodeDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MapMode.PlayerTarget get_PlayerTarget()
        {
            return (Game.MapMode.PlayerTarget)this.<PlayerTarget>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PlayerTarget(Game.MapMode.PlayerTarget value)
        {
            this.<PlayerTarget>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.ApproachModeZoomListener get_approachModeZoomListener()
        {
            return (MapMode.ApproachModeZoomListener)this.<approachModeZoomListener>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_approachModeZoomListener(MapMode.ApproachModeZoomListener value)
        {
            this.<approachModeZoomListener>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.masterDomain.SceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void MapMode.Domain::GetMapLookupAsync(MapSceneLookupTable mapSceneLookupTable)));
            MapMode.ApproachModeZoomListener val_3 = new MapMode.ApproachModeZoomListener();
            .domain = this;
            this.<approachModeZoomListener>k__BackingField = val_3;
            val_3.OnEnable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetMapLookupAsync(MapSceneLookupTable mapSceneLookupTable)
        {
            this.<PlayerTarget>k__BackingField = mapSceneLookupTable._playerTarget;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.<approachModeZoomListener>k__BackingField.OnDisable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain()
        {
        
        }
    
    }

}
