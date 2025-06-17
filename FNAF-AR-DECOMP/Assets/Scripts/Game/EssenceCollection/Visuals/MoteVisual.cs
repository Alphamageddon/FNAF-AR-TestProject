using UnityEngine;

namespace Game.EssenceCollection.Visuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoteVisual : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.MoteVisual <prefabCreatedFrom>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 <currentVelocity>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.MoteVisual prefabCreatedFrom { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 currentVelocity { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.MoteVisual get_prefabCreatedFrom()
        {
            return (Game.EssenceCollection.Visuals.MoteVisual)this.<prefabCreatedFrom>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_prefabCreatedFrom(Game.EssenceCollection.Visuals.MoteVisual value)
        {
            this.<prefabCreatedFrom>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_currentVelocity()
        {
            return new UnityEngine.Vector3() {x = this.<currentVelocity>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_currentVelocity(UnityEngine.Vector3 value)
        {
            this.<currentVelocity>k__BackingField = value;
            mem[1152921525323968340] = value.y;
            mem[1152921525323968344] = value.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Sanitize()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.<currentVelocity>k__BackingField = val_1;
            mem[1152921525324080340] = val_1.y;
            mem[1152921525324080344] = val_1.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MoteVisual()
        {
        
        }
    
    }

}
