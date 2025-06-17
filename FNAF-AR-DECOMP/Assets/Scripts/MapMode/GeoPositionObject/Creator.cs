using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Creator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _gatheringWorkshops;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Random.State _oldRandomState;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Creator()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Creator(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetWorkshopLocations()
        {
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAllWorkshops();
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAllAnimatronics();
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAllGeocodeResults();
            this._geoPositionObjectDomain.<destroyer>k__BackingField.DestroyAllGridMarkers();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.Workshop CreateWorkshop(MapMode.MovementNode.LocationNode node)
        {
            var val_10;
            UnityEngine.Object val_11;
            MapMode.GeoPositionObject.GeoPositionObject val_12;
            val_10 = node;
            val_11 = this.GetPrefabOfType(entityType:  0);
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            if(val_11 == 0)
            {
                    ConsoleLogger.LogError(className:  "MapMode.GeoPositionObject.Creator", functionName:  "CreateWorkshop", logString:  "No prefab found");
                val_12 = 0;
                return (MapMode.GeoPositionObject.Workshop)val_12;
            }
            
            val_12 = UnityEngine.Object.Instantiate<MapMode.GeoPositionObject.Workshop>(original:  val_11);
            val_12.transform.parent = this._geoPositionObjectDomain._playerTarget.transform;
            mem2[0] = node._id;
            .<geoPosition>k__BackingField = node._positionLatLon;
            mem[1152921524634484328] = ???;
            val_12.SetGeoPositionData(geoPositionData:  new MapMode.GeoPositionObject.GeoPositionData());
            this._geoPositionObjectDomain.<container>k__BackingField.Add(entityType:  0, geoPositionObject:  val_12);
            val_10 = this._geoPositionObjectDomain._animatronicEntityDomain.workshopLocations;
            val_10.AddWorkshopLocation(workshopLocation:  new Mapbox.Utils.Vector2d() {x = node._positionLatLon, y = V9.16B});
            return (MapMode.GeoPositionObject.Workshop)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.MapAnimatronic CreateAnimatronic(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            MapMode.GeoPositionObject.GeoPositionObject val_10;
            UnityEngine.Object val_11;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = animatronicEntity.animatronicConfigData.PlushSuitData;
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  val_2.MapIconPrefab)) == true)
            {
                    return (MapMode.GeoPositionObject.MapAnimatronic)val_10;
            }
            
            val_11 = this.GetPrefabOfType(entityType:  1);
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            if(val_11 == 0)
            {
                    ConsoleLogger.LogError(className:  "MapMode.GeoPositionObject.Creator", functionName:  "CreateAnimatronic", logString:  "No prefab found");
                val_10 = 0;
                return (MapMode.GeoPositionObject.MapAnimatronic)val_10;
            }
            
            val_10 = UnityEngine.Object.Instantiate<MapMode.GeoPositionObject.MapAnimatronic>(original:  val_11, parent:  this._geoPositionObjectDomain._playerTarget.transform, worldPositionStays:  false);
            val_10.SetAnimatronicEntity(animatronicEntity:  animatronicEntity, billboardCamera:  this._geoPositionObjectDomain._referenceCamera);
            this._geoPositionObjectDomain.<container>k__BackingField.Add(entityType:  1, geoPositionObject:  val_10);
            this.CreateMapAnimatronicIcon(mapAnimatronic:  val_10);
            return (MapMode.GeoPositionObject.MapAnimatronic)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeocodeResultObject CreateGeocodeResultObject(MapMode.MovementNode.LocationNode node)
        {
            MapMode.GeoPositionObject.Container val_8;
            UnityEngine.Object val_9;
            MapMode.GeoPositionObject.GeoPositionObject val_10;
            val_8 = this;
            val_9 = this._geoPositionObjectDomain.<creator>k__BackingField.GetPrefabOfType(entityType:  2);
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            if(val_9 == 0)
            {
                    ConsoleLogger.LogError(className:  "MapMode.GeoPositionObject.Creator", functionName:  "CreateGeocodeResult", logString:  "No prefab found");
                val_10 = 0;
                return (MapMode.GeoPositionObject.GeocodeResultObject)val_10;
            }
            
            val_10 = UnityEngine.Object.Instantiate<MapMode.GeoPositionObject.GeocodeResultObject>(original:  val_9, parent:  this._geoPositionObjectDomain._playerTarget.transform, worldPositionStays:  true);
            mem2[0] = node._id;
            MapMode.GeoPositionObject.GeoPositionData val_7 = new MapMode.GeoPositionObject.GeoPositionData();
            .<geoPosition>k__BackingField = node._positionLatLon;
            mem[1152921524634927768] = 1152921504851574784;
            if(val_10 != null)
            {
                    val_10.SetGeoPositionData(geoPositionData:  val_7);
            }
            else
            {
                    val_10.SetGeoPositionData(geoPositionData:  val_7);
            }
            
            val_10.SetText(text:  "Node");
            val_8 = this._geoPositionObjectDomain.<container>k__BackingField;
            val_8.Add(entityType:  2, geoPositionObject:  val_10);
            return (MapMode.GeoPositionObject.GeocodeResultObject)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateMapAnimatronicIcon(MapMode.GeoPositionObject.MapAnimatronic mapAnimatronic)
        {
            var val_8;
            bool val_9;
            if(mapAnimatronic != null)
            {
                    val_8 = mapAnimatronic;
                val_9 = this.ShouldShowMapIcon(entity:  mapAnimatronic.<animatronicEntity>k__BackingField);
            }
            else
            {
                    val_8 = 32;
                val_9 = this.ShouldShowMapIcon(entity:  64);
            }
            
            mapAnimatronic._showIcon = val_9;
            var val_8 = 0;
            val_8 = val_8 + 1;
            this._geoPositionObjectDomain._animatronic3DDomain.CreateMapIcon(configData:  val_8.animatronicConfigData, onSuccess:  new System.Action<Animatronics.Animatronic3d.PrefabManagement.MapIconContainer>(object:  mapAnimatronic, method:  public System.Void MapMode.GeoPositionObject.MapAnimatronic::OnMapIconLoadedSuccessfully(Animatronics.Animatronic3d.PrefabManagement.MapIconContainer container)), onFailure:  new System.Action<System.String>(object:  mapAnimatronic, method:  public System.Void MapMode.GeoPositionObject.MapAnimatronic::OnMapIconLoadFailure(string error)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObject GetPrefabOfType(MapMode.GeoPositionObject.EntityType entityType)
        {
            GameUI.ServerGameUIDataModel val_6;
            List.Enumerator<T> val_1 = this._geoPositionObjectDomain._geoPositionObjectConfig._possiblePrefabs.GetEnumerator();
            label_6:
            if(((-1446466184) & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if(val_2._masterDomain != entityType)
            {
                goto label_6;
            }
            
            val_6 = val_2._serverGameUIDataModel;
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524635217272});
            return (MapMode.GeoPositionObject.GeoPositionObject)val_6;
            label_4:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524635217272});
            val_6 = 0;
            return (MapMode.GeoPositionObject.GeoPositionObject)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldShowMapIcon(AnimatronicEntity.AnimatronicEntity entity)
        {
            Game.ItemDefinition.Data.DataDefinitions.CPUData val_2 = entity.animatronicConfigData.CpuData;
            if((val_2.AlwaysShowIcon == true) || (this._geoPositionObjectDomain._transponderActive == true))
            {
                    return true;
            }
            
            if(entity.stateData.expressDelivery != false)
            {
                    return true;
            }
            
            OriginState val_6 = entity.originData.originState;
            if((val_6 | 2) == 2)
            {
                    return true;
            }
            
            val_6 = ((val_6 != 1) ? 1 : 0) & ((val_6 != 5) ? 1 : 0);
            return true;
        }
    
    }

}
