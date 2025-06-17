using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntitiesExistenceSynchronizer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broker_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            this.TryToCreateAnimatronic(animatronicEntity:  e.entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broker_OnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            this.DestroyAnimatronic(animatronicEntity:  e.entity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Broker_OnEntitiesClearedEvent(AnimatronicEntity.Container.EntitiesClearedArgs e)
        {
            this.DestroyAllAnimatronics();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToCreateAnimatronic(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_2 = animatronicEntity.animatronicConfigData.CpuData;
            if(val_2.Phantasm != 0)
            {
                    return;
            }
            
            if(animatronicEntity.stateData.animatronicState == 6)
            {
                    return;
            }
            
            MapMode.GeoPositionObject.MapAnimatronic val_5 = this._geoPositionObjectDomain.<creator>k__BackingField.CreateAnimatronic(animatronicEntity:  animatronicEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DestroyAnimatronic(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAnimatronic(animatronicEntity:  animatronicEntity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DestroyAllAnimatronics()
        {
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAllAnimatronics();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanOldAnimatronics()
        {
            MapMode.GeoPositionObject.MapAnimatronic val_14;
            var val_15;
            var val_16;
            System.Collections.Generic.List<MapMode.GeoPositionObject.MapAnimatronic> val_1 = new System.Collections.Generic.List<MapMode.GeoPositionObject.MapAnimatronic>();
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = this._geoPositionObjectDomain.<container>k__BackingField._geoPositionObjectInfos.GetEnumerator();
            label_31:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_7 = val_3.Current;
            if((val_7 + 16) != 1)
            {
                goto label_31;
            }
            
            val_14 = mem[val_7 + 24];
            val_14 = val_7 + 24;
            if(val_14 != 0)
            {
                    val_14 = 0;
            }
            
            if((this._geoPositionObjectDomain._animatronicEntityDomain.container.ContainsEntity(entityId:  64.entityId)) == true)
            {
                goto label_31;
            }
            
            val_1.Add(item:  val_14);
            goto label_31;
            label_13:
            val_15 = 0;
            val_16 = 119;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_3.Dispose();
            }
            
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAnimatronics(animatronics:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddNewAnimatronics()
        {
            System.Collections.Generic.List<T> val_24;
            var val_26;
            var val_27;
            var val_32;
            var val_33;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = null;
            val_24 = val_1;
            val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            var val_30 = 0;
            val_30 = val_30 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = this._geoPositionObjectDomain._animatronicEntityDomain.container.AnimatronicEntities.GetEnumerator();
            val_26 = 0;
            val_27 = 0;
            goto label_68;
            label_76:
            var val_31 = 0;
            val_31 = val_31 + 1;
            T val_7 = val_5.Current;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_24 = this._geoPositionObjectDomain.<container>k__BackingField._geoPositionObjectInfos.GetEnumerator();
            label_42:
            var val_33 = 0;
            val_33 = val_33 + 1;
            if(val_24.MoveNext() == false)
            {
                goto label_28;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            T val_14 = val_24.Current;
            if((val_14 + 16) != 1)
            {
                goto label_42;
            }
            
            val_32 = mem[val_14 + 24];
            val_32 = val_14 + 24;
            val_32 = mem[val_14 + 24 + 32];
            val_32 = val_14 + 24 + 32;
            if((System.String.op_Equality(a:  val_32.entityId, b:  val_7.entityId)) == false)
            {
                goto label_42;
            }
            
            val_33 = 1;
            goto label_43;
            label_28:
            val_33 = 0;
            label_43:
            if(val_24 == null)
            {
                
            }
            else
            {
                    var val_35 = 0;
                val_35 = val_35 + 1;
                val_24.Dispose();
            }
            
            if(((0 == 0) ? 157 : 0) != 157)
            {
                goto label_63;
            }
            
            val_24 = val_24;
            if(( & 1) != 0)
            {
                goto label_68;
            }
            
            label_70:
            val_1.Add(item:  val_7);
            goto label_68;
            label_63:
            val_24 = val_24;
            if( == false)
            {
                goto label_67;
            }
            
            val_26 = 0;
            val_27 = 0;
            if(( & 1) != 0)
            {
                goto label_68;
            }
            
            goto label_70;
            label_67:
            val_26 = 0;
            if(( & 1) == 0)
            {
                goto label_70;
            }
            
            label_68:
            var val_36 = 0;
            val_36 = val_36 + 1;
            if(val_5.MoveNext() == true)
            {
                goto label_76;
            }
            
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_5.Dispose();
            }
            
            if(((0 == 0) ? 191 : 0) != 191)
            {
                goto label_94;
            }
            
            if(val_24 != null)
            {
                goto label_98;
            }
            
            goto label_96;
            label_94:
            if( != false)
            {
                    val_27 = 0;
            }
            
            if(val_24 != null)
            {
                goto label_98;
            }
            
            label_96:
            label_98:
            List.Enumerator<T> val_27 = val_24.GetEnumerator();
            label_100:
            if(((-1453552904) & 1) == 0)
            {
                goto label_101;
            }
            
            this.TryToCreateAnimatronic(animatronicEntity:  0.emailUIDataHandler);
            goto label_100;
            label_101:
            long val_29 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524628130552});
            if( == 0)
            {
                    return;
            }
            
            if(243 == 0)
            {
                    return;
            }
            
            if(243 == 243)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AnimatronicEntitiesExistenceSynchronizer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntitiesExistenceSynchronizer(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            this._geoPositionObjectDomain._eventExposer.add_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._geoPositionObjectDomain._eventExposer.add_EntityRemovedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._geoPositionObjectDomain._eventExposer.add_EntitiesClearedEvent(value:  new System.Action<EntitiesClearedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntitiesClearedEvent(AnimatronicEntity.Container.EntitiesClearedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            this._geoPositionObjectDomain._eventExposer.remove_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._geoPositionObjectDomain._eventExposer.remove_EntityRemovedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntityRemovedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._geoPositionObjectDomain._eventExposer.remove_EntitiesClearedEvent(value:  new System.Action<EntitiesClearedArgs>(object:  this, method:  System.Void MapMode.GeoPositionObject.AnimatronicEntitiesExistenceSynchronizer::Broker_OnEntitiesClearedEvent(AnimatronicEntity.Container.EntitiesClearedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.CleanOldAnimatronics();
            this.AddNewAnimatronics();
        }
    
    }

}
