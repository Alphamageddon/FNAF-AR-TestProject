using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScavengingData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode nextPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long timeStamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double DistanceFromNextPoint;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScavengingData()
        {
            this.timeStamp = 0;
            this.DistanceFromNextPoint = 0;
            this.nextPoint = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScavengingData(AnimatronicEntity.ScavengingData scavengingData)
        {
            if(scavengingData != null)
            {
                    this.nextPoint = scavengingData.nextPoint;
            }
            else
            {
                    this.nextPoint = 11993091;
            }
            
            this.timeStamp = scavengingData.timeStamp;
            this.DistanceFromNextPoint = 0;
        }
    
    }

}
