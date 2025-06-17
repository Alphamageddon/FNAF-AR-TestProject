using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapMovementUtilities
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected MapMovementUtilities()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMovementUtilities(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateStalkingTimers(AnimatronicEntity.MapMovementUtilities.UpdateStalkingTimersParams updateStalkingTimersParams)
        {
            float val_15;
            float val_16;
            float val_17;
            AnimatronicEntity.StalkingTimerData val_18;
            Direction val_19;
            float val_21;
            float val_22;
            AnimatronicEntity.AnimatronicEntity val_23;
            if((updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.timeRemainingInitialized) == false)
            {
                goto label_2;
            }
            
            if((updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField) == null)
            {
                goto label_4;
            }
            
            val_15 = updateStalkingTimersParams.deltaTime;
            val_16 = updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.timeRemaining;
            goto label_5;
            label_2:
            updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.timeRemaining = UnityEngine.Random.Range(min:  updateStalkingTimersParams.stalkingMinTimer, max:  updateStalkingTimersParams.stalkingMaxTimer);
            val_17 = UnityEngine.Random.Range(min:  updateStalkingTimersParams.stalkingSwitchbackMinTimer, max:  updateStalkingTimersParams.stalkingSwitchbackMaxTimer);
            updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining = val_17;
            val_19 = ((UnityEngine.Random.Range(min:  0f, max:  1f)) >= 0) ? 1 : 0;
            goto label_12;
            label_4:
            float val_7 = updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.timeRemaining;
            val_15 = updateStalkingTimersParams.deltaTime;
            val_16 = val_7;
            label_5:
            val_7 = val_16 - val_15;
            updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.timeRemaining = val_7;
            if((updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField) != null)
            {
                    val_21 = updateStalkingTimersParams.deltaTime;
                val_22 = updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining;
            }
            else
            {
                    float val_9 = updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining;
                val_21 = updateStalkingTimersParams.deltaTime;
                val_22 = val_9;
            }
            
            val_9 = val_22 - val_21;
            updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining = val_9;
            if((updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining) > 0f)
            {
                    return;
            }
            
            val_17 = UnityEngine.Random.Range(min:  updateStalkingTimersParams.stalkingSwitchbackMinTimer, max:  updateStalkingTimersParams.stalkingSwitchbackMaxTimer);
            updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.switchbackTimeRemaining = val_17;
            val_23 = updateStalkingTimersParams.animatronicEntity;
            if(updateStalkingTimersParams.animatronicEntity != null)
            {
                goto label_21;
            }
            
            val_23 = updateStalkingTimersParams.animatronicEntity;
            if(updateStalkingTimersParams.animatronicEntity == null)
            {
                goto label_22;
            }
            
            label_21:
            val_18 = updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField;
            val_19 = ((updateStalkingTimersParams.animatronicEntity.<stalkingTimerData>k__BackingField.direction) != 1) ? 1 : 0;
            label_12:
            val_18.direction = val_19;
            return;
            label_22:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveEntityInACircleAroundPlayer(AnimatronicEntity.AnimatronicEntity entity, float delta)
        {
            float val_16;
            AnimatronicEntity.DistanceFromPlayerData val_17;
            AnimatronicEntity.AnimatronicEntityDomain val_18;
            val_16 = delta;
            val_17 = entity.<distanceFromPlayerData>k__BackingField;
            if((entity.<distanceFromPlayerData>k__BackingField._distance) <= 0f)
            {
                goto label_3;
            }
            
            val_18 = this._animatronicEntityDomain;
            if(this._animatronicEntityDomain != null)
            {
                goto label_4;
            }
            
            val_18 = this._animatronicEntityDomain;
            if(val_18 == null)
            {
                goto label_5;
            }
            
            label_4:
            Mapbox.Utils.Vector2d val_1 = this._animatronicEntityDomain.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_2 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (float)val_3.x, y:  (float)val_3.y);
            val_16 = this._animatronicEntityDomain._animatronicEntityConfig.stalkingDegreesPerSecond * val_16;
            val_16 = ((entity.<stalkingTimerData>k__BackingField.direction) == 0) ? (-val_16) : (val_16);
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_16);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            Mapbox.Utils.Vector2d val_10 = new Mapbox.Utils.Vector2d(x:  (double)val_9.x, y:  (double)val_9.y);
            val_16 = val_10.x;
            Mapbox.Utils.Vector2d val_13 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_16, y = val_10.y}, d:  (double)this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode / val_10.x.magnitude);
            Mapbox.Utils.Vector2d val_14 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_13.x, y = val_13.y}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            val_17 = entity.<geoPositionData>k__BackingField;
            Mapbox.Utils.Vector2d val_15 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_14.x, y = val_14.y});
            entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_15;
            mem2[0] = val_15.y;
            this.UpdateDistanceFromPlayer(entity:  entity);
            return;
            label_3:
            ConsoleLogger.LogError(className:  "MapMovementUtilities", functionName:  "MoveEntityInACircleAroundPlayer", logString:  "We are at the target, which shouldn\'t happen");
            return;
            label_5:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveTowardsPlayer(AnimatronicEntity.AnimatronicEntity entity, float delta, float bufferMeters)
        {
            Mapbox.Utils.Vector2d val_1 = this._animatronicEntityDomain.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_2 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, d:  (double)bufferMeters);
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            this.MoveTowardsPosition(entity:  entity, positionMeters:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y}, delta:  delta);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveTowardsPosition(AnimatronicEntity.AnimatronicEntity entity, Mapbox.Utils.Vector2d positionMeters, float delta)
        {
            Mapbox.Utils.Vector2d val_1 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = positionMeters.x, y = positionMeters.y});
            Mapbox.Utils.Vector2d val_5 = 0.CalculateDeltaMetersTowardsTarget(metersPerSecond:  this.GetSpeedForEntity(entity:  entity, distance:  val_2.x.magnitude), deltaTime:  delta, targetGeoPositionMeters:  new Mapbox.Utils.Vector2d() {x = positionMeters.x, y = positionMeters.y}, entityGeoPositionMeters:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, magnitudeOffset:  0);
            Mapbox.Utils.Vector2d val_6 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
            Mapbox.Utils.Vector2d val_7 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y});
            entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_7;
            mem2[0] = val_7.y;
            this.UpdateDistanceFromPlayer(entity:  entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MoveInDirection(AnimatronicEntity.AnimatronicEntity entity, Mapbox.Utils.Vector2d direction, float delta)
        {
            Mapbox.Utils.Vector2d val_1 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_3 = 0.CalculateMetersInDirection(metersPerSecond:  entity.<animatronicConfigMapper>k__BackingField.GetSpeedMeters(), deltaTime:  delta, direction:  new Mapbox.Utils.Vector2d() {x = direction.x, y = direction.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y});
            Mapbox.Utils.Vector2d val_5 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_5;
            mem2[0] = val_5.y;
            this.UpdateDistanceFromPlayer(entity:  entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LerpTowardsPoint(AnimatronicEntity.AnimatronicEntity entity, Mapbox.Utils.Vector2d point)
        {
            float val_5;
            if((entity.<moveStateData>k__BackingField) != null)
            {
                    val_5 = entity.<moveStateData>k__BackingField.<timeElapsed>k__BackingField;
            }
            else
            {
                    val_5 = 1.85775E-36f;
            }
            
            Mapbox.Utils.Vector2d val_3 = entity.<moveStateData>k__BackingField.<startNode>k__BackingField.PositionLatLon;
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.Lerp(from:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, to:  new Mapbox.Utils.Vector2d() {x = point.x, y = point.y}, t:  (double)UnityEngine.Mathf.Min(a:  1f, b:  val_5 / (entity.<moveStateData>k__BackingField.<nodeTravelTime>k__BackingField)));
            entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField = val_4;
            mem2[0] = val_4.y;
            this.UpdateDistanceFromPlayer(entity:  entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateDistanceFromPlayer(AnimatronicEntity.AnimatronicEntity entity)
        {
            Mapbox.Utils.Vector2d val_1 = this._animatronicEntityDomain.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_2 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            entity.<distanceFromPlayerData>k__BackingField._distance = (float)val_3.x.magnitude;
            if((entity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) != true)
            {
                    entity.<distanceFromPlayerData>k__BackingField.RecalculateMinDistance();
            }
            
            entity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetSpeedForEntity(AnimatronicEntity.AnimatronicEntity entity, double distance)
        {
            if((double)this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerTravelMode < 0)
            {
                    if((entity.<animatronicConfigMapper>k__BackingField) != null)
            {
                    return entity.<animatronicConfigMapper>k__BackingField.GetTravelSpeedMeters();
            }
            
                return entity.<animatronicConfigMapper>k__BackingField.GetTravelSpeedMeters();
            }
            
            if((entity.<stateData>k__BackingField.animatronicState) != 10)
            {
                    return entity.<animatronicConfigMapper>k__BackingField.GetSpeedMeters();
            }
            
            return entity.<animatronicConfigMapper>k__BackingField.GetSalvagerSpeedMeters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d TelportToRadius(AnimatronicEntity.AnimatronicEntity entity, float radius)
        {
            Mapbox.Utils.Vector2d val_1 = this._animatronicEntityDomain.<geoPositionUtilities>k__BackingField.GetPlayerGeoPositionMeters();
            Mapbox.Utils.Vector2d val_2 = 0.GetAnimatronicEntityGeoPositionMeters(animatronicEntity:  entity);
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, d:  (double)radius);
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            Mapbox.Utils.Vector2d val_6 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
            return new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y};
        }
    
    }

}
