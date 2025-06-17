using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class Statistics : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Average;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Percentile50;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Percentile90;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Percentile99;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Statistics()
        {
        
        }
    
    }

}
