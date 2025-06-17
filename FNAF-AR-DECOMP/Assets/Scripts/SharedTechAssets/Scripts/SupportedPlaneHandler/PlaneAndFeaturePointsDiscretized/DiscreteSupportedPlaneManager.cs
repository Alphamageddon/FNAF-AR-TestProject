using UnityEngine;

namespace SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DiscreteSupportedPlaneManager : IBoundedPlaneAccepter, IPointAccepter, IDepthMapAccepter, IBlockCoordAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser _vDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PointDispenser _filteredPointDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedHorizontalPlane> _horizontalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane> _verticalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig _planeConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 bufferPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.Vector2>> _updatedHorizontalPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<int> _updatedHorizontalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>> _updatedVerticalPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<int> _updatedVerticalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> unaddedPoints;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedHorizontalPlaneDispenser dispenser, SharedTechAssets.Scripts.TechInterfaces.Dispensers.SupportedVerticalPlaneDispenser vDispenser, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig config, PointDispenser pointDispenser, UnityEngine.Camera camera)
        {
            this._planeConfig = config;
            this._dispenser = dispenser;
            this._vDispenser = vDispenser;
            this._filteredPointDispenser = pointDispenser;
            this._horizontalPlanes = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedHorizontalPlane>();
            this._verticalPlanes = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane>();
            this._camera = camera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig val_3;
            this._horizontalPlanes.set_Item(key:  id, value:  new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedHorizontalPlane(config:  new Horizontal() {resolution = this._planeConfig.hConfig, tileSize = this._planeConfig.hConfig, pointAddTolerance = X24, heightTolerance = X24}, id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}));
            val_3 = this._planeConfig;
            if(this._planeConfig != null)
            {
                goto label_4;
            }
            
            val_3 = this._planeConfig;
            if(val_3 == null)
            {
                goto label_5;
            }
            
            label_4:
            this._dispenser.HorizontalSupportedPlaneAddedEvent(id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, discretizedCenter:  new UnityEngine.Vector2() {x = (SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedHorizontalPlane)[1152921523065586960].<discretizedCenter>k__BackingField, y = V11.16B}, tileLength:  this._planeConfig.hConfig * (1.152922E+18f));
            return;
            label_5:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            bool val_2 = this._horizontalPlanes.Item[id].Update(height:  height, boundary:  boundary);
            if(this._dispenser == null)
            {
                goto label_3;
            }
            
            if(val_2 == false)
            {
                goto label_4;
            }
            
            label_5:
            this._dispenser.OnHorizontalSupportedPlaneSignificantUpdateEvent(id:  id, boundary:  boundary, height:  height);
            return;
            label_3:
            if(val_2 == true)
            {
                goto label_5;
            }
            
            label_4:
            this._dispenser.HorizontalSupportedPlaneUpdateBoundaryEvent(id:  id, boundary:  boundary, height:  height);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneRemove(int id)
        {
            var val_8;
            var val_9;
            SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedHorizontalPlane val_1 = this._horizontalPlanes.Item[id];
            HashSet.Enumerator<T> val_2 = val_1.SupportingPoints.GetEnumerator();
            label_5:
            if((1279130576 & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_5 = this.AddSinglePoint(point:  new UnityEngine.Vector3() {x = this.bufferPoint, y = val_1.<Height>k__BackingField, z = V1.16B});
            goto label_5;
            label_4:
            val_8 = 0;
            val_9 = 1;
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523065846736});
            this._dispenser.HorizontalSupportedPlaneRemovedEvent(id:  id);
            bool val_7 = this._horizontalPlanes.Remove(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane val_1 = null;
            val_1 = new SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane(config:  new SupportedPlaneConfig.Vertical() {resolution = this._planeConfig.vConfig, tileSize = this._planeConfig.vConfig, pointAddTolerance = this._planeConfig.vConfig, heightTolerance = this._planeConfig.vConfig, angleTolerance = true}, id:  id, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, boundary:  boundary, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            this._verticalPlanes.set_Item(key:  id, value:  val_1);
            this._vDispenser.VerticalSupportedPlaneAddedEvent(id:  id, boundary:  boundary, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            UnityEngine.Vector3 val_4;
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> val_7;
            SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane val_1 = this._verticalPlanes.Item[id];
            if((val_1.Update(boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z})) == false)
            {
                goto label_3;
            }
            
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_4 = val_1.<Normal>k__BackingField;
            val_7 = val_1.<DiscretizedPointsInSpace>k__BackingField;
            goto label_5;
            label_3:
            this._vDispenser.OnVerticalSupportedPlaneUpdateBoundary(id:  id, boundary:  boundary);
            return;
            label_4:
            val_4 = val_1.<Normal>k__BackingField;
            val_7 = 0;
            label_5:
            this._vDispenser.VerticalSupportedPlaneUpdateSignificantUpdateEvent(id:  id, boundary:  boundary, normal:  new UnityEngine.Vector3() {x = val_4, y = normal.y, z = normal.x}, reprojectedPoints:  val_7, reprojectedTiles:  val_1.GetNewFilledTileVertices());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneRemove(int id)
        {
            bool val_1 = this._verticalPlanes.Remove(key:  id);
            this._vDispenser.VerticalSupportedPlaneRemovedEvent(id:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AddSinglePoint(UnityEngine.Vector3 point)
        {
            var val_4;
            float val_37;
            float val_38;
            var val_39;
            System.Collections.Generic.List<UnityEngine.Vector2> val_41;
            var val_42;
            double val_43;
            float val_44;
            float val_45;
            System.Collections.Generic.List<GameUI.EmailData> val_46;
            var val_47;
            val_37 = point.z;
            val_38 = point.x;
            val_39 = this;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._horizontalPlanes.Values.GetEnumerator();
            val_41 = 1152921523066424144;
            val_42 = 1152921505071702016;
            val_43 = 0.5;
            label_14:
            if((1279912320 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            UnityEngine.Vector3 val_7 = this._camera.transform.position;
            double val_8 = Math3d.GetDistance(vec1:  new UnityEngine.Vector3() {x = val_38, y = point.y, z = val_37}, vec2:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            if(val_8 > val_43)
            {
                    val_8 = val_8 * 0.1;
                val_44 = val_7.y + (float)val_8;
            }
            
            if(((System.Math.Abs(val_5._emailIdsToBeDeletedOnServer - point.y)) >= 0) || ((val_5.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = val_38, y = point.y, z = val_37})) == false))
            {
                goto label_14;
            }
            
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_38, y:  val_37);
            UnityEngine.Vector2 val_12 = val_5.DiscretizePoint(x:  val_11.x, y:  val_11.y);
            val_45 = val_12.y;
            val_46 = val_5._emailDatas;
            if((val_46.Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_45})) != false)
            {
                    bool val_14 = this._updatedHorizontalPlanes.Add(item:  val_5._masterDomain);
                if((this._updatedHorizontalPoints.ContainsKey(key:  val_5._masterDomain)) != true)
            {
                    val_41 = null;
                val_41 = new System.Collections.Generic.List<UnityEngine.Vector2>();
                this._updatedHorizontalPoints.set_Item(key:  val_5._masterDomain, value:  null);
            }
            
                this._updatedHorizontalPoints.Item[val_5._masterDomain].Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_45});
                val_46 = val_5.AddToTiles(point:  new UnityEngine.Vector2() {x = val_12.x, y = val_45});
                int val_38 = val_18._tileSize;
                val_38 = val_38 * val_38;
                if(val_18.count == val_38)
            {
                    this._dispenser.HorizontalSupportedPlaneAddTileEvent(id:  val_5._masterDomain, tileCenter:  new UnityEngine.Vector2() {x = val_18.center, y = val_45});
            }
            
            }
            
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523066628480});
            val_47 = 1;
            return (bool)val_47;
            label_3:
            long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523066628480});
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_23 = this._verticalPlanes.Values.GetEnumerator();
            val_41 = 1152921523066519376;
            val_46 = 1152921504840871936;
            label_59:
            if((1279912288 & 1) == 0)
            {
                goto label_51;
            }
            
            GameUI.EmailUIDataHandler val_24 = val_4.emailUIDataHandler;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38, y = point.y, z = val_37}, b:  new UnityEngine.Vector3() {x = val_24._emailDatas, y = V11.16B, z = val_24._emailIdsToBeDeletedOnServer});
            float val_26 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, rhs:  new UnityEngine.Vector3() {x = val_24._itemDefinitions, y = V11.16B, z = val_24._emailIdsToBeDeletedOnServer});
            if((System.Math.Abs(val_26) >= 0) || ((val_24.PointWithinVerticalPolygon(point:  new UnityEngine.Vector3() {x = val_38, y = point.y, z = val_37})) == false))
            {
                goto label_59;
            }
            
            val_43 = val_24._itemDefinitions;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_43, y = val_24._emailIdsToBeDeletedOnServer, z = val_24._emailDatas}, d:  val_26);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38, y = point.y, z = val_37}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            val_37 = val_29.x;
            val_38 = val_29.z;
            val_46 = this._updatedVerticalPoints;
            if((val_46.ContainsKey(key:  val_24._masterDomain)) != true)
            {
                    val_46 = val_24._masterDomain;
                val_41 = null;
                val_41 = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>();
                this._updatedVerticalPoints.set_Item(key:  val_46, value:  null);
            }
            
            if((val_24.AddDiscretizedProjectedPoint(projectedPoint:  new UnityEngine.Vector3() {x = val_37, y = val_29.y, z = val_38})) != false)
            {
                    this._updatedVerticalPoints.Item[val_24._masterDomain].set_Item(key:  new UnityEngine.Vector2() {x = val_37, y = val_29.y}, value:  new UnityEngine.Vector3() {x = val_38, y = val_26, z = val_24._emailIdsToBeDeletedOnServer});
                val_46 = this._updatedVerticalPlanes;
                bool val_34 = val_46.Add(item:  val_24._masterDomain);
                if(val_24._masterDomain._theGameDomain == 4811031554560000)
            {
                    val_46 = val_24._masterDomain._sceneLookupTableAccess;
                this._vDispenser.VerticalSupportedPlaneAddTileEvent(id:  val_24._masterDomain, key:  new UnityEngine.Vector2() {x = val_37, y = val_29.y}, discretizedKey:  new UnityEngine.Vector2Int() {m_X = val_46, m_Y = val_46}, vertices:  val_24._masterDomain._gameUIDomain);
            }
            
            }
            
            val_39 = 0;
            val_47 = 1;
            val_42 = 704;
            goto label_73;
            label_51:
            val_39 = 0;
            val_47 = 0;
            val_42 = 702;
            label_73:
            long val_35 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523066628448});
            var val_36 = (702 == 0) ? 702 : 702;
            if(val_36 != 702)
            {
                    if(val_36 == 704)
            {
                    return (bool)val_47;
            }
            
            }
            
            val_47 = 0;
            return (bool)val_47;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointUpdatedEvent(UnityEngine.Vector3[] pointData)
        {
            var val_4;
            System.Collections.Generic.List<UnityEngine.Vector3> val_17;
            var val_18;
            var val_19;
            val_17 = this.unaddedPoints;
            val_17.Clear();
            val_18 = 0;
            goto label_2;
            label_7:
            val_17 = 0;
            if((this.AddSinglePoint(point:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f})) != true)
            {
                    val_17 = this.unaddedPoints;
                val_17.Add(item:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f});
            }
            
            val_18 = 1;
            label_2:
            if(val_18 < pointData.Length)
            {
                goto label_7;
            }
            
            HashSet.Enumerator<T> val_2 = this._updatedHorizontalPlanes.GetEnumerator();
            label_14:
            if((1280369424 & 1) == 0)
            {
                goto label_9;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_5 = val_4.region;
            this._dispenser.HorizontalSupportedPlaneUpdatePointsEvent(id:  val_5, points:  this._updatedHorizontalPoints.Item[val_5]);
            this._updatedHorizontalPoints.Item[val_5].Clear();
            goto label_14;
            label_9:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523067085584});
            val_19 = 0;
            this._updatedHorizontalPlanes.Clear();
            HashSet.Enumerator<T> val_10 = this._updatedVerticalPlanes.GetEnumerator();
            label_29:
            if((1280369424 & 1) == 0)
            {
                goto label_24;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_11 = val_4.region;
            this._vDispenser.VerticalSupportedPlaneUpdatePointsEvent(id:  val_11, points:  this._updatedVerticalPoints.Item[val_11]);
            this._updatedVerticalPoints.Item[val_11].Clear();
            goto label_29;
            label_24:
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523067085584});
            this._updatedVerticalPlanes.Clear();
            this._filteredPointDispenser.SendPointUpdateEvent(pointData:  this.unaddedPoints.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDepthMapUpdatedEvent(UnityEngine.Vector3[,] depthMap, bool[,] keepMask, UnityEngine.Vector3 cameraPos)
        {
            var val_8;
            var val_19;
            var val_20;
            var val_23;
            val_19 = 0;
            goto label_1;
            label_13:
            val_20 = 0;
            goto label_2;
            label_11:
            if((keepMask[0 + (16824064 * 0)]) != false)
            {
                    var val_2 = 0 + ((keepMask[(16824064 * 0) + 0][0] + 16) * 0);
                val_2 = depthMap + (val_2 * 12);
                bool val_3 = this.AddSinglePoint(point:  new UnityEngine.Vector3() {x = ((keepMask[(16824064 * 0) + 0][0] + 16 * 0) + 0 * 12) + depthMap + 32, y = ((keepMask[(16824064 * 0) + 0][0] + 16 * 0) + 0 * 12) + depthMap + 32 + 4, z = ((keepMask[(16824064 * 0) + 0][0] + 16 * 0) + 0 * 12) + depthMap + 40});
            }
            
            val_20 = 1;
            label_2:
            if(val_20 < (depthMap.GetLength(dimension:  1)))
            {
                goto label_11;
            }
            
            val_19 = 1;
            label_1:
            if(val_19 < (depthMap.GetLength(dimension:  0)))
            {
                goto label_13;
            }
            
            HashSet.Enumerator<T> val_6 = this._updatedHorizontalPlanes.GetEnumerator();
            label_20:
            if((1280784560 & 1) == 0)
            {
                goto label_15;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_9 = val_8.region;
            this._dispenser.HorizontalSupportedPlaneUpdatePointsEvent(id:  val_9, points:  this._updatedHorizontalPoints.Item[val_9]);
            this._updatedHorizontalPoints.Item[val_9].Clear();
            goto label_20;
            label_15:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523067500720});
            val_23 = 0;
            this._updatedHorizontalPlanes.Clear();
            HashSet.Enumerator<T> val_14 = this._updatedVerticalPlanes.GetEnumerator();
            label_35:
            if((1280784560 & 1) == 0)
            {
                goto label_30;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_15 = val_8.region;
            this._vDispenser.VerticalSupportedPlaneUpdatePointsEvent(id:  val_15, points:  this._updatedVerticalPoints.Item[val_15]);
            this._updatedVerticalPoints.Item[val_15].Clear();
            goto label_35;
            label_30:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523067500720});
            this._updatedVerticalPlanes.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBlockUpdatedEvent(UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> pointsToAdd, System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove)
        {
            goto label_1;
            label_4:
            UnityEngine.Vector3 val_1 = pointsToRemove.Item[0];
            bool val_2 = this.AddSinglePoint(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            0 = 1;
            label_1:
            if(0 < pointsToRemove.Count)
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DiscreteSupportedPlaneManager()
        {
            this._updatedHorizontalPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.Vector2>>();
            this._updatedHorizontalPlanes = new System.Collections.Generic.HashSet<System.Int32>();
            this._updatedVerticalPoints = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>>();
            this._updatedVerticalPlanes = new System.Collections.Generic.HashSet<System.Int32>();
            this.unaddedPoints = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
