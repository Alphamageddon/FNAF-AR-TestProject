using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectDetection_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionManager _odm;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int UpdateFrequency { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DepthToggle { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectDetection_SROptions(DefaultNamespace.ObjectDetectionManager odm)
        {
            this._odm = odm;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_UpdateFrequency()
        {
            if(this._odm.Config != null)
            {
                    return (int)this._odm.Config.updateFrequency;
            }
            
            return (int)this._odm.Config.updateFrequency;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_UpdateFrequency(int value)
        {
            this._odm.Config.updateFrequency = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_DepthToggle()
        {
            if(this._odm.Config != null)
            {
                    return (bool)this._odm.Config.enableObjDetect;
            }
            
            return (bool)this._odm.Config.enableObjDetect;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DepthToggle(bool value)
        {
            this._odm.Config.enableObjDetect = value;
        }
    
    }

}
