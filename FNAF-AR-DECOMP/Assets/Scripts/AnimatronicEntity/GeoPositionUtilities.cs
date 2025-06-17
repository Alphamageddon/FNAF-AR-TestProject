using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeoPositionUtilities
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected GeoPositionUtilities()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionUtilities(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetPlayerGeoPositionMeters()
        {
            if(this._animatronicEntityDomain != null)
            {
                goto label_0;
            }
            
            this._animatronicEntityDomain = this._animatronicEntityDomain;
            if(this._animatronicEntityDomain == null)
            {
                goto label_1;
            }
            
            label_0:
            UnityEngine.Vector3 val_2 = this._animatronicEntityDomain._playerTarget.transform.position;
            if(this._animatronicEntityDomain._map != null)
            {
                    return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            }
            
            return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetAnimatronicEntityGeoPositionMeters(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            if((animatronicEntity.<geoPositionData>k__BackingField) != null)
            {
                    return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = animatronicEntity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField});
            }
            
            return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = animatronicEntity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d CalculateDeltaMetersTowardsTarget(float metersPerSecond, float deltaTime, Mapbox.Utils.Vector2d targetGeoPositionMeters, Mapbox.Utils.Vector2d entityGeoPositionMeters, double magnitudeOffset = 0)
        {
            double val_6 = magnitudeOffset;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = targetGeoPositionMeters.x, y = targetGeoPositionMeters.y}, b:  new Mapbox.Utils.Vector2d() {x = entityGeoPositionMeters.x, y = entityGeoPositionMeters.y});
            double val_3 = val_2.x.magnitude;
            val_6 = val_3 - val_6;
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_3, y = val_2.y}, d:  Mapbox.Utils.Mathd.Min(a:  val_6, b:  (double)metersPerSecond * deltaTime));
            return new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d CalculateMetersInDirection(float metersPerSecond, float deltaTime, Mapbox.Utils.Vector2d direction)
        {
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = metersPerSecond, y = deltaTime}, d:  (double)metersPerSecond * deltaTime);
            return new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y};
        }
    
    }

}
