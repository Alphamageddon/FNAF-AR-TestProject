using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LayerSourceOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.Style layerSource;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            if(this.layerSource != null)
            {
                    return (string)this.layerSource.Id;
            }
            
            return (string)this.layerSource.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Id(string value)
        {
            this.layerSource.Id = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LayerSourceOptions()
        {
        
        }
    
    }

}
