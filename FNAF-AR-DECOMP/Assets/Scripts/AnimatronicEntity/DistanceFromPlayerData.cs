using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DistanceFromPlayerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _distance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <initialized>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <minDistance>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool initialized { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float distance { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minDistance { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_initialized()
        {
            return (bool)this.<initialized>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_initialized(bool value)
        {
            this.<initialized>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_distance()
        {
            return (float)this._distance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_distance(float value)
        {
            this._distance = value;
            if((this.<initialized>k__BackingField) != true)
            {
                    this.RecalculateMinDistance();
            }
            
            this.<initialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_minDistance()
        {
            return (float)this.<minDistance>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_minDistance(float value)
        {
            this.<minDistance>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DistanceFromPlayerData()
        {
            this.<initialized>k__BackingField = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DistanceFromPlayerData(float newDistance, float newMinDistance, bool newInitialized)
        {
            this._distance = newDistance;
            this.<minDistance>k__BackingField = newMinDistance;
            this.<initialized>k__BackingField = newInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DistanceFromPlayerData(AnimatronicEntity.DistanceFromPlayerData distanceFromPlayerData)
        {
            if(distanceFromPlayerData != null)
            {
                    this._distance = distanceFromPlayerData._distance;
                this.<minDistance>k__BackingField = distanceFromPlayerData.<minDistance>k__BackingField;
            }
            else
            {
                    this._distance = 1.68059E-38f;
                this.<minDistance>k__BackingField = 2.105703E-38f;
            }
            
            this.<initialized>k__BackingField = distanceFromPlayerData.<initialized>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DistanceFromPlayerData(float distance)
        {
            this._distance = distance;
            if((this.<initialized>k__BackingField) != true)
            {
                    this.RecalculateMinDistance();
            }
            
            this.<initialized>k__BackingField = true;
            this.RecalculateMinDistance();
            this.<initialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecalculateMinDistance()
        {
            this.<minDistance>k__BackingField = UnityEngine.Mathf.Lerp(a:  ImperialMetricConversions.FeetToMeters(feet:  100f), b:  ImperialMetricConversions.FeetToMeters(feet:  350f), t:  UnityEngine.Random.Range(min:  0f, max:  1f));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            var val_2;
            if((this.<initialized>k__BackingField) != false)
            {
                    string val_1 = this._distance.ToString();
                return (string)val_2;
            }
            
            val_2 = "not initialized";
            return (string)val_2;
        }
    
    }

}
