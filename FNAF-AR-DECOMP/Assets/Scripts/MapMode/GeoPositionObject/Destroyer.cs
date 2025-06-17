using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Destroyer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Destroyer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Destroyer(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAllWorkshops()
        {
            List.Enumerator<T> val_2 = this._geoPositionObjectDomain.<container>k__BackingField.ClearAllOfType(entityType:  0).GetEnumerator();
            label_9:
            if(((-1445878936) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            UnityEngine.Object.Destroy(obj:  val_3._serverGameUIDataModel.gameObject);
            goto label_9;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524635804520});
            this._geoPositionObjectDomain._animatronicEntityDomain.workshopLocations.ClearWorkshopLocations();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAnimatronics(System.Collections.Generic.List<MapMode.GeoPositionObject.MapAnimatronic> animatronics)
        {
            var val_7 = this;
            List.Enumerator<T> val_1 = animatronics.GetEnumerator();
            label_8:
            if(((-1445693208) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            MapMode.GeoPositionObject.GeoPositionObject val_3 = this._geoPositionObjectDomain.<container>k__BackingField.Remove(geoPositionObject:  val_2);
            UnityEngine.Object.Destroy(obj:  val_2.gameObject);
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAllGeocodeResults()
        {
            List.Enumerator<T> val_2 = this._geoPositionObjectDomain.<container>k__BackingField.ClearAllOfType(entityType:  2).GetEnumerator();
            label_9:
            if(((-1445523848) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            UnityEngine.Object.Destroy(obj:  val_3._serverGameUIDataModel.gameObject);
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAllGridMarkers()
        {
            List.Enumerator<T> val_2 = this._geoPositionObjectDomain.<container>k__BackingField.ClearAllOfType(entityType:  3).GetEnumerator();
            label_9:
            if(((-1445354504) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            UnityEngine.Object.Destroy(obj:  val_3._serverGameUIDataModel.gameObject);
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAnimatronic(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            MapMode.GeoPositionObject.GeoPositionObject val_15;
            var val_16;
            var val_17;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = this._geoPositionObjectDomain.<container>k__BackingField._geoPositionObjectInfos.GetEnumerator();
            label_26:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            T val_6 = val_2.Current;
            if((val_6 + 16) != 1)
            {
                goto label_26;
            }
            
            val_15 = mem[val_6 + 24];
            val_15 = val_6 + 24;
            val_15 = 0;
            if((System.String.op_Equality(a:  64.entityId, b:  animatronicEntity.entityId)) == false)
            {
                goto label_26;
            }
            
            MapMode.GeoPositionObject.GeoPositionObject val_12 = this._geoPositionObjectDomain.<container>k__BackingField.Remove(geoPositionObject:  val_15);
            UnityEngine.Object.Destroy(obj:  val_15.gameObject);
            label_13:
            val_16 = 0;
            val_17 = 127;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_2.Dispose();
            }
            
            if( == 127)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DestroyAllAnimatronics()
        {
            List.Enumerator<T> val_2 = this._geoPositionObjectDomain.<container>k__BackingField.ClearAllOfType(entityType:  1).GetEnumerator();
            label_9:
            if(((-1444987016) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            UnityEngine.Object.Destroy(obj:  val_3._serverGameUIDataModel.gameObject);
            goto label_9;
        }
    
    }

}
