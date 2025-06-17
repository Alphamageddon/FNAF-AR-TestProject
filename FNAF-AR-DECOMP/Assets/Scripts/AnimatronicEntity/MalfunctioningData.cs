using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MalfunctioningData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <isMalfunctioning>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isMalfunctioning { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isMalfunctioning()
        {
            return (bool)this.<isMalfunctioning>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_isMalfunctioning(bool value)
        {
            this.<isMalfunctioning>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MalfunctioningData()
        {
            this.<isMalfunctioning>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MalfunctioningData(AnimatronicEntity.MalfunctioningData malfunctioningData)
        {
            this.<isMalfunctioning>k__BackingField = malfunctioningData.<isMalfunctioning>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MalfunctioningData(bool isMalfunctioning)
        {
            this.<isMalfunctioning>k__BackingField = isMalfunctioning;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.<isMalfunctioning>k__BackingField.ToString();
        }
    
    }

}
