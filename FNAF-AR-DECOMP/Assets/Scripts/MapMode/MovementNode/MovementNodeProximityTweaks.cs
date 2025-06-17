using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MovementNodeProximityTweaks
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMinNorthMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMaxNorthMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMinSouthMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMaxSouthMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMinWestMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMaxWestMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMinEastMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float workshopMaxEastMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minWorkshopDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minPlayerDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float spawnPointRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int nodesPerRing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float movementNodeOuterRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float movementNodeMiddleRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float movementNodeInnerRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int pathSearchAngle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d ChooseNewWorkshopLocationMeters(Mapbox.Utils.Vector2d startingLocationMeters)
        {
            Mapbox.Utils.Vector2d val_7 = new Mapbox.Utils.Vector2d(x:  (double)this.EastWest(east:  ((UnityEngine.Random.Range(min:  0, max:  100)) < 50) ? 1 : 0), y:  (double)this.NorthSouth(north:  ((UnityEngine.Random.Range(min:  0, max:  100)) < 50) ? 1 : 0));
            Mapbox.Utils.Vector2d val_8 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_7.x, y = val_7.y}, b:  new Mapbox.Utils.Vector2d() {x = startingLocationMeters.x, y = startingLocationMeters.y});
            return new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float NorthSouth(bool north)
        {
            if(north == false)
            {
                    return (float)-(UnityEngine.Random.Range(min:  System.Math.Abs(this.workshopMinSouthMeters), max:  System.Math.Abs(this.workshopMaxSouthMeters)));
            }
            
            return UnityEngine.Random.Range(min:  System.Math.Abs(this.workshopMinNorthMeters), max:  System.Math.Abs(this.workshopMaxNorthMeters));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float EastWest(bool east)
        {
            if(east == false)
            {
                    return (float)-(UnityEngine.Random.Range(min:  System.Math.Abs(this.workshopMinWestMeters), max:  System.Math.Abs(this.workshopMaxWestMeters)));
            }
            
            return UnityEngine.Random.Range(min:  System.Math.Abs(this.workshopMinEastMeters), max:  System.Math.Abs(this.workshopMaxEastMeters));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementNodeProximityTweaks()
        {
            this.minWorkshopDistance = 500f;
            this.minPlayerDistance = 4.591775E-41f;
            this.spawnPointRadius = 800f;
            this.nodesPerRing = 7;
            this.workshopMinNorthMeters = ;
            this.workshopMaxNorthMeters = ;
            this.workshopMinSouthMeters = 100f;
            this.workshopMaxSouthMeters = 1000f;
            this.workshopMinWestMeters = ;
            this.workshopMaxWestMeters = ;
            this.workshopMinEastMeters = 100f;
            this.workshopMaxEastMeters = 1000f;
            this.movementNodeOuterRadius = 800f;
            this.movementNodeMiddleRadius = 600f;
            this.movementNodeInnerRadius = 400f;
            this.pathSearchAngle = 45;
        }
    
    }

}
