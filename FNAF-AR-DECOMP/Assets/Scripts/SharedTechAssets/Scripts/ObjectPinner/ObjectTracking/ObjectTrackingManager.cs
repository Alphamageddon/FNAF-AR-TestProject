using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.ObjectTracking
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectTrackingManager : IObjectPinEventAccepter, ISupportedHorizontalPlaneAccepter, ISupportedVerticalPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float horizontalTileLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float verticalTileLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float voxelResolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.SemanticHorizontalPlaneTracker _horizontalPlaneTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.SemanticVerticalPlaneTracker _verticalPlaneTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker _semanticVoxelTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager.ObjectGeometry> _idToObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currPredId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _currLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _currConf;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<int> _collisions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate> removeUpdates;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(DefaultNamespace.SemanticHorizontalPlaneTracker horizontalPlaneTracker, DefaultNamespace.SemanticVerticalPlaneTracker verticalPlaneTracker, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.SemanticBlockCoordTracker semanticVoxelTracker, SharedTechAssets.Scripts.TechInterfaces.Dispensers.TrackedObjectDispenser dispenser)
        {
            this._horizontalPlaneTracker = horizontalPlaneTracker;
            this._verticalPlaneTracker = verticalPlaneTracker;
            this._semanticVoxelTracker = semanticVoxelTracker;
            this._idToObject = new System.Collections.Generic.Dictionary<System.Int32, ObjectGeometry>();
            this._dispenser = dispenser;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeginEvent(int predId, string label, float confidence)
        {
            this._currPredId = predId;
            this._currLabel = label;
            this._currConf = confidence;
            this.HandleRemovedVoxels();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate CreateUpdateForNewObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager.ObjectGeometry obj)
        {
            var val_11;
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_0;
            HashSet.Enumerator<T> val_1 = obj.horizontalTiles.GetEnumerator();
            label_5:
            if((1287553888 & 1) == 0)
            {
                goto label_3;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = 1287529776, tileKey = new UnityEngine.Vector2() {x = 9.988378E+07f, y = 2.524356E-29f}, isAdd = true});
            goto label_5;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523074270048});
            HashSet.Enumerator<T> val_6 = obj.verticalTiles.GetEnumerator();
            label_13:
            if((1287553888 & 1) == 0)
            {
                goto label_11;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = 1287529776, tileKey = new UnityEngine.Vector2() {x = 9.988378E+07f, y = 2.524356E-29f}, isAdd = true});
            goto label_13;
            label_11:
            val_11 = 0;
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523074270048});
            if(((182 == 0) ? 182 : 182) == 182)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_11 = 0;
            }
            
            }
            
            HashSet.Enumerator<T> val_9 = obj.voxels.GetEnumerator();
            label_23:
            if((1287553856 & 1) == 0)
            {
                goto label_24;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo() {coord = new UnityEngine.Vector3Int() {m_X = 1287553856, m_Y = 268435460}, isAdd = true});
            goto label_23;
            label_24:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523074270016});
            val_0.voxelResolution = 0f;
            mem[1152921523074334692] = 0;
            val_0.verticalTileUpdateInfo = 0;
            val_0.objId = 0;
            mem[1152921523074334676] = 0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate CreateUpdateForUpdatedObject(int objId, string label)
        {
            var val_7;
            var val_8;
            var val_9;
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_0;
            val_7 = 0;
            goto label_2;
            label_8:
            CandidateTileInfo val_1 = this._horizontalPlaneTracker.NewLabeledTiles.Item[0];
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = val_1.planeId, tileKey = new UnityEngine.Vector2() {x = val_1.key.x, y = 0f}, isAdd = true});
            val_7 = 1;
            label_2:
            if(val_7 < this._horizontalPlaneTracker.NewLabeledTiles.Count)
            {
                goto label_8;
            }
            
            val_8 = 0;
            goto label_9;
            label_15:
            CandidateTileInfo val_3 = this._verticalPlaneTracker.NewLabeledTiles.Item[0];
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = val_3.planeId, tileKey = new UnityEngine.Vector2() {x = val_3.key.x, y = 0f}, isAdd = true});
            val_8 = 1;
            label_9:
            if(val_8 < this._verticalPlaneTracker.NewLabeledTiles.Count)
            {
                goto label_15;
            }
            
            val_9 = 0;
            goto label_16;
            label_22:
            UnityEngine.Vector3Int val_5 = this._semanticVoxelTracker.NewLabeledBlocks.Item[0];
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo() {coord = new UnityEngine.Vector3Int() {m_X = val_5.m_X, m_Y = val_5.m_Y}, isAdd = true});
            val_9 = 1;
            label_16:
            if(val_9 < this._semanticVoxelTracker.NewLabeledBlocks.Count)
            {
                goto label_22;
            }
            
            val_0.voxelResolution = 0f;
            mem[1152921523074563236] = 0;
            val_0.verticalTileUpdateInfo = 0;
            val_0.objId = 0;
            mem[1152921523074563220] = 0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSingleCollision()
        {
            var val_13;
            System.Collections.Generic.HashSet<System.Int32> val_14;
            var val_15;
            val_13 = this;
            int val_1 = this._horizontalPlaneTracker.CurrentObjectCollisions.Count;
            val_14 = this._verticalPlaneTracker.CurrentObjectCollisions.Count;
            int val_3 = this._semanticVoxelTracker.CurrentObjectCollisions.Count;
            int val_4 = val_14 + val_1;
            val_4 = val_4 + val_3;
            if(val_4 == 1)
            {
                    val_15 = 1;
                return (bool)(val_13 == 1) ? 1 : 0;
            }
            
            val_15 = 0;
            if(val_14 > 1)
            {
                    return (bool)(val_13 == 1) ? 1 : 0;
            }
            
            if(val_1 > 1)
            {
                    return (bool)(val_13 == 1) ? 1 : 0;
            }
            
            if(val_3 > 1)
            {
                    return (bool)(val_13 == 1) ? 1 : 0;
            }
            
            if(val_1 == 1)
            {
                    bool val_6 = this._collisions.Add(item:  this._horizontalPlaneTracker.CurrentObjectCollisions.Item[0]);
            }
            
            if(val_14 == 1)
            {
                    val_14 = this._collisions;
                bool val_8 = val_14.Add(item:  this._verticalPlaneTracker.CurrentObjectCollisions.Item[0]);
            }
            
            if(val_3 == 1)
            {
                    val_14 = this._semanticVoxelTracker.CurrentObjectCollisions.Item[0];
                bool val_10 = this._collisions.Add(item:  val_14);
            }
            
            val_13 = this._collisions.Count;
            this._collisions.Clear();
            return (bool)(val_13 == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateNewObject()
        {
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            val_17 = 0;
            goto label_3;
            label_9:
            CandidateTileInfo val_1 = this._horizontalPlaneTracker.NewLabeledTiles.Item[0];
            val_18 = val_1.planeId;
            bool val_3 = 0.Add(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = this._horizontalPlaneTracker.NewLabeledTiles, y = this._horizontalPlaneTracker.NewLabeledTiles}, planeId = val_18 & 4294967295});
            val_17 = 1;
            label_3:
            if(val_17 < this._horizontalPlaneTracker.NewLabeledTiles.Count)
            {
                goto label_9;
            }
            
            val_19 = 0;
            goto label_10;
            label_16:
            CandidateTileInfo val_5 = this._verticalPlaneTracker.NewLabeledTiles.Item[0];
            val_18 = val_5.planeId;
            bool val_7 = 0.Add(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = this._verticalPlaneTracker.NewLabeledTiles, y = this._verticalPlaneTracker.NewLabeledTiles}, planeId = val_18 & 4294967295});
            val_19 = 1;
            label_10:
            if(val_19 < this._verticalPlaneTracker.NewLabeledTiles.Count)
            {
                goto label_16;
            }
            
            val_20 = 0;
            goto label_17;
            label_23:
            UnityEngine.Vector3Int val_9 = this._semanticVoxelTracker.NewLabeledBlocks.Item[0];
            val_18 = val_9.m_Z & 4294967295;
            bool val_10 = 0.Add(item:  new UnityEngine.Vector3Int() {m_X = val_9.m_X, m_Y = val_9.m_Y, m_Z = val_18});
            val_20 = 1;
            label_17:
            if(val_20 < this._semanticVoxelTracker.NewLabeledBlocks.Count)
            {
                goto label_23;
            }
            
            this._idToObject.set_Item(key:  this._currPredId, value:  new ObjectGeometry() {voxelResolution = 0f});
            this._horizontalPlaneTracker.LabelNewPoints(id:  this._currPredId, label:  this._currLabel);
            this._verticalPlaneTracker.LabelNewPoints(id:  this._currPredId, label:  this._currLabel);
            this._semanticVoxelTracker.LabelNewVoxels(id:  this._currPredId, label:  this._currLabel);
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_12 = this.CreateUpdateForNewObject(obj:  new ObjectGeometry() {voxelResolution = 0f});
            this._dispenser.AddObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {voxelResolution = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateObject()
        {
            string val_4;
            float val_5;
            System.Collections.Generic.HashSet<TileInfo> val_6;
            System.Collections.Generic.HashSet<TileInfo> val_7;
            System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_8;
            string val_10;
            System.Collections.Generic.List<System.Int32> val_27;
            var val_28;
            var val_29;
            if(this._horizontalPlaneTracker.CurrentObjectCollisions.Count != 1)
            {
                goto label_3;
            }
            
            if(this._horizontalPlaneTracker != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            val_27 = this._horizontalPlaneTracker.CurrentObjectCollisions;
            if(val_27 != null)
            {
                goto label_21;
            }
            
            label_22:
            val_27 = 0;
            label_21:
            int val_2 = val_27.Item[0];
            this._horizontalPlaneTracker.LabelNewPoints(id:  val_2, label:  this._currLabel);
            this._verticalPlaneTracker.LabelNewPoints(id:  val_2, label:  this._currLabel);
            this._semanticVoxelTracker.LabelNewVoxels(id:  val_2, label:  this._currLabel);
            ObjectGeometry val_3 = this._idToObject.Item[val_2];
            List.Enumerator<T> val_9 = this._horizontalPlaneTracker.NewLabeledTiles.GetEnumerator();
            label_14:
            if((1288763280 & 1) == 0)
            {
                goto label_12;
            }
            
            bool val_12 = val_6.Add(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = 2.524356E-29f, y = 1.08793E+08f}, planeId = 1288763280});
            goto label_14;
            label_3:
            if(this._verticalPlaneTracker.CurrentObjectCollisions.Count != 1)
            {
                goto label_17;
            }
            
            if(this._verticalPlaneTracker != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_17:
            if(this._semanticVoxelTracker.CurrentObjectCollisions != null)
            {
                goto label_21;
            }
            
            goto label_22;
            label_12:
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523075479440});
            List.Enumerator<T> val_16 = this._verticalPlaneTracker.NewLabeledTiles.GetEnumerator();
            label_31:
            if((1288763248 & 1) == 0)
            {
                goto label_29;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_17 = val_4.trackableId;
            bool val_20 = val_7.Add(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = val_17.m_SubId1 >> 32, y = val_17.m_SubId2}, planeId = val_17.m_SubId1 & 4294967295});
            goto label_31;
            label_29:
            val_28 = 0;
            long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523075479408});
            if(((327 == 0) ? 327 : 327) == 327)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_28 = 0;
            }
            
            }
            
            List.Enumerator<T> val_23 = this._semanticVoxelTracker.NewLabeledBlocks.GetEnumerator();
            label_42:
            if((1288763216 & 1) == 0)
            {
                goto label_40;
            }
            
            bool val_24 = val_8.Add(item:  new UnityEngine.Vector3Int() {m_X = 1288763216, m_Y = 268435460, m_Z = 1288712592});
            goto label_42;
            label_40:
            val_29 = 395;
            long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523075479376});
            val_10 = val_4;
            val_4 = val_10;
            val_6 = val_6;
            val_7 = val_7;
            val_5 = val_5;
            val_8 = val_8;
            this._idToObject.set_Item(key:  val_2, value:  new ObjectGeometry() {label = val_4, id = val_4, horizontalTiles = val_6, verticalTiles = val_7, voxelResolution = val_5, voxels = val_8});
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_26 = this.CreateUpdateForUpdatedObject(objId:  val_2, label:  this._currLabel);
            this._dispenser.UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = val_4, label = val_4, voxelResolution = val_6, horizontalTileUpdateInfo = val_6, verticalTileUpdateInfo = val_5, voxelUpdateInfo = val_5});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MergeObjects()
        {
            System.Collections.Generic.IEnumerable<T> val_3;
            var val_4;
            var val_5;
            System.Collections.Generic.IEnumerable<T> val_22;
            System.Collections.Generic.IEnumerable<T> val_23;
            var val_53;
            var val_54;
            int val_55;
            System.Collections.Generic.Dictionary<System.Int32, ObjectGeometry> val_56;
            var val_57;
            var val_58;
            System.Collections.Generic.List<System.Int32> val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            val_53 = 1152921517710430544;
            val_54 = 0;
            val_55 = 0;
            goto label_2;
            label_9:
            int val_1 = this._horizontalPlaneTracker.CurrentObjectCollisions.Item[0];
            val_56 = this._idToObject;
            ObjectGeometry val_2 = val_56.Item[val_1];
            var val_6 = (1289302064 > 0) ? 1289302064 : 0;
            val_54 = 1;
            label_2:
            if(val_54 < this._horizontalPlaneTracker.CurrentObjectCollisions.Count)
            {
                goto label_9;
            }
            
            val_57 = 0;
            goto label_10;
            label_20:
            int val_9 = this._verticalPlaneTracker.CurrentObjectCollisions.Item[0];
            if((this._horizontalPlaneTracker.CurrentObjectCollisions.Contains(item:  val_9)) != true)
            {
                    this._horizontalPlaneTracker.CurrentObjectCollisions.Add(item:  val_9);
            }
            
            val_56 = this._idToObject;
            ObjectGeometry val_11 = val_56.Item[val_9];
            var val_12 = (1289302064 > val_6) ? 1289302064 : (val_6);
            val_57 = 1;
            label_10:
            if(val_57 < this._verticalPlaneTracker.CurrentObjectCollisions.Count)
            {
                goto label_20;
            }
            
            val_58 = 0;
            goto label_21;
            label_31:
            int val_15 = this._semanticVoxelTracker.CurrentObjectCollisions.Item[0];
            if((this._horizontalPlaneTracker.CurrentObjectCollisions.Contains(item:  val_15)) != true)
            {
                    this._horizontalPlaneTracker.CurrentObjectCollisions.Add(item:  val_15);
            }
            
            val_56 = this._idToObject;
            ObjectGeometry val_17 = val_56.Item[val_15];
            var val_18 = (1289302064 > val_12) ? 1289302064 : (val_12);
            int val_19 = (1289302064 > val_12) ? (val_15) : ((1289302064 > val_6) ? (val_9) : ((1289302064 > 0) ? (val_1) : (val_55)));
            val_58 = 1;
            label_21:
            val_59 = this._semanticVoxelTracker.CurrentObjectCollisions;
            if(val_58 < val_59.Count)
            {
                goto label_31;
            }
            
            ObjectGeometry val_21 = this._idToObject.Item[val_19];
            val_60 = 0;
            goto label_34;
            label_78:
            int val_24 = this._horizontalPlaneTracker.CurrentObjectCollisions.Item[0];
            if(val_24 == val_19)
            {
                goto label_36;
            }
            
            ObjectGeometry val_25 = this._idToObject.Item[val_24];
            HashSet.Enumerator<T> val_26 = val_3.GetEnumerator();
            label_41:
            if((1289302032 & 1) == 0)
            {
                goto label_39;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = 1287529776, tileKey = new UnityEngine.Vector2() {x = 1.138689E+08f, y = 2.524356E-29f}, isAdd = true});
            goto label_41;
            label_39:
            val_61 = 0;
            val_62 = 471;
            long val_29 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018192});
            if((( == 0) ? 471 : ()) == 471)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_61 = 0;
            }
            
            }
            
            val_63 = val_61;
            HashSet.Enumerator<T> val_31 = val_22.GetEnumerator();
            label_51:
            if((1289302032 & 1) == 0)
            {
                goto label_52;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = 1287529776, tileKey = new UnityEngine.Vector2() {x = 1.138689E+08f, y = 2.524356E-29f}, isAdd = true});
            goto label_51;
            label_52:
            long val_32 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018192});
            if(((553 == 0) ? 553 : 553) == 553)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_63 = 0;
            }
            
            }
            
            HashSet.Enumerator<T> val_34 = val_23.GetEnumerator();
            label_61:
            if((1289302000 & 1) == 0)
            {
                goto label_59;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo() {coord = new UnityEngine.Vector3Int() {m_X = 1289302000, m_Y = 268435460}, isAdd = true});
            goto label_61;
            label_59:
            val_64 = val_63;
            val_65 = 1152921523075915280;
            long val_35 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018160});
            if(((623 == 0) ? 623 : 623) != 623)
            {
                goto label_65;
            }
            
            val_67 = val_3;
            val_66 = 0;
            if(val_67 != 0)
            {
                goto label_69;
            }
            
            goto label_67;
            label_65:
            val_67 = val_3;
            if( != 0)
            {
                    val_64 = 0;
            }
            
            if(val_67 != 0)
            {
                goto label_69;
            }
            
            label_67:
            label_69:
            val_67.UnionWith(other:  val_3);
            val_22.UnionWith(other:  val_22);
            val_23.UnionWith(other:  val_23);
            this._horizontalPlaneTracker.RelabelTiles(tiles:  val_3, id:  val_19, label:  this._currLabel);
            this._verticalPlaneTracker.RelabelTiles(tiles:  val_22, id:  val_19, label:  this._currLabel);
            this._semanticVoxelTracker.RelabelVoxelsForObject(voxelCoords:  val_23, id:  val_19, label:  this._currLabel);
            val_55 = val_19;
            this._dispenser.RemoveObject(objId:  val_24);
            val_59 = this._idToObject;
            bool val_37 = val_59.Remove(key:  val_24);
            label_36:
            val_53 = 1152921517710430544;
            val_60 = 1;
            label_34:
            if(val_60 < this._horizontalPlaneTracker.CurrentObjectCollisions.Count)
            {
                goto label_78;
            }
            
            List.Enumerator<T> val_39 = this._horizontalPlaneTracker.NewLabeledTiles.GetEnumerator();
            label_83:
            if((1289301968 & 1) == 0)
            {
                goto label_84;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = 1289301968, tileKey = new UnityEngine.Vector2() {x = 2.524356E-29f, y = 0f}, isAdd = true});
            goto label_83;
            label_84:
            long val_40 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018128});
            if(((884 == 0) ? 884 : 884) == 884)
            {
                
            }
            
            List.Enumerator<T> val_42 = this._verticalPlaneTracker.NewLabeledTiles.GetEnumerator();
            label_94:
            if((1289301936 & 1) == 0)
            {
                goto label_95;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_43 = val_5.trackableId;
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = val_43.m_SubId1, tileKey = new UnityEngine.Vector2() {x = val_43.m_SubId1, y = 0f}, isAdd = true});
            goto label_94;
            label_95:
            long val_44 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018096});
            if(((970 == 0) ? 970 : 970) == 970)
            {
                
            }
            
            List.Enumerator<T> val_46 = this._semanticVoxelTracker.NewLabeledBlocks.GetEnumerator();
            label_105:
            if((1289301904 & 1) == 0)
            {
                goto label_103;
            }
            
            0.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo() {coord = new UnityEngine.Vector3Int() {m_X = 1289301904, m_Y = 268435460}, isAdd = true});
            goto label_105;
            label_103:
            val_68 = 0;
            long val_47 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523076018064});
            val_3 = 0;
            val_4 = 0;
            val_5 = 0;
            this._dispenser.UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {voxelResolution = 0f});
            this._horizontalPlaneTracker.LabelNewPoints(id:  val_55, label:  this._currLabel);
            this._verticalPlaneTracker.LabelNewPoints(id:  val_55, label:  this._currLabel);
            this._semanticVoxelTracker.LabelNewVoxels(id:  val_55, label:  this._currLabel);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEndEvent()
        {
            if(this._horizontalPlaneTracker.CurrentObjectCollisions.Count == 0)
            {
                    if(this._verticalPlaneTracker.CurrentObjectCollisions.Count == 0)
            {
                    if(this._semanticVoxelTracker.CurrentObjectCollisions.Count == 0)
            {
                goto label_9;
            }
            
            }
            
            }
            
            if(this.IsSingleCollision() != false)
            {
                    this.UpdateObject();
            }
            else
            {
                    this.MergeObjects();
            }
            
            label_15:
            this._horizontalPlaneTracker.ClearInfo();
            this._verticalPlaneTracker.ClearInfo();
            this._semanticVoxelTracker.ClearInfo();
            return;
            label_9:
            this.CreateNewObject();
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector2 discretizedCenter, float tileLength)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddPoints(int id, System.Collections.Generic.List<UnityEngine.Vector2> points)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneAddTile(int id, UnityEngine.Vector2 center)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, UnityEngine.Vector3 center)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdatePoints(int id, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> points)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneUpdateBoundary(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneSignificantUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> reprojectedPoints, System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> reprojectedTiles)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneAddTile(int id, UnityEngine.Vector2 key, UnityEngine.Vector2Int discretizedKey, UnityEngine.Vector3[] boundary)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalSupportedPlaneRemove(int planeId)
        {
            System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_6;
            float val_7;
            var val_12;
            var val_17;
            string val_19;
            System.Collections.Generic.HashSet<TileInfo> val_20;
            System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_21;
            System.Collections.Generic.HashSet<TileInfo> val_22;
            System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate> val_33;
            var val_34;
            var val_36;
            var val_37;
            var val_38;
            val_33 = this;
            SemanticHorizontalPlane val_1 = this._horizontalPlaneTracker.OnHorizontalSupportedPlaneRemove(id:  planeId);
            if(val_1.LabeledTiles == null)
            {
                    return;
            }
            
            val_34 = val_1.LabeledTiles.Keys;
            if(val_34.Count == 0)
            {
                    return;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = val_1.LabeledTiles.Keys.GetEnumerator();
            val_36 = 0;
            label_34:
            if((1291275552 & 1) == 0)
            {
                goto label_6;
            }
            
            TileSemanticInfo val_8 = val_1.LabeledTiles.Item[new UnityEngine.Vector2() {x = val_7, y = V1.16B}];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_10 = val_8.labelToObjId.Keys.GetEnumerator();
            label_20:
            if((1291275520 & 1) == 0)
            {
                goto label_9;
            }
            
            int val_14 = val_8.labelToObjId.Item[val_12.emailUIDataHandler];
            if((this.removeUpdates.ContainsKey(key:  val_14)) != true)
            {
                    val_6 = 0;
                val_7 = 0;
                this.removeUpdates.set_Item(key:  val_14, value:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {voxelResolution = 0f});
            }
            
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_16 = this.removeUpdates.Item[val_14];
            val_17.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = planeId, tileKey = new UnityEngine.Vector2() {x = val_7, y = V1.16B}, isAdd = V1.16B});
            ObjectGeometry val_18 = this._idToObject.Item[val_14];
            bool val_23 = val_20.Remove(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = val_7, y = V1.16B}, planeId = planeId});
            val_6 = val_21;
            val_7 = val_22;
            this._idToObject.set_Item(key:  val_14, value:  new ObjectGeometry() {label = val_19, id = val_19, horizontalTiles = val_20, verticalTiles = val_7, voxelResolution = val_7, voxels = val_6});
            goto label_20;
            label_9:
            val_37 = val_36;
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523077991680});
            if((((282 == 0) ? 282 : 282) == 282) || ( == 0))
            {
                goto label_34;
            }
            
            goto label_34;
            label_6:
            val_38 = 310;
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523077991712});
            if(((282 == 0) ? 310 : 282) == 310)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_36 = 0;
            }
            
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_29 = this.removeUpdates.Values.GetEnumerator();
            label_48:
            if((1291275408 & 1) == 0)
            {
                goto label_46;
            }
            
            this._dispenser.UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = val_7, label = val_7, voxelResolution = val_6, horizontalTileUpdateInfo = val_6});
            goto label_48;
            label_46:
            val_34 = 377;
            long val_31 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523077991568});
            val_33 = this.removeUpdates;
            val_33.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalSupportedPlaneRemove(int planeId)
        {
            System.Collections.Generic.HashSet<TileInfo> val_6;
            float val_7;
            var val_12;
            var val_17;
            string val_19;
            System.Collections.Generic.HashSet<TileInfo> val_20;
            System.Collections.Generic.HashSet<TileInfo> val_21;
            float val_22;
            System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate> val_33;
            var val_34;
            var val_36;
            var val_37;
            val_33 = this;
            SemanticVerticalPlane val_1 = this._verticalPlaneTracker.OnHorizontalSupportedPlaneRemove(planeId:  planeId);
            if(val_1.LabeledTiles == null)
            {
                    return;
            }
            
            val_34 = val_1.LabeledTiles.Keys;
            if(val_34.Count == 0)
            {
                    return;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = val_1.LabeledTiles.Keys.GetEnumerator();
            val_34 = 0;
            label_34:
            if((1291599392 & 1) == 0)
            {
                goto label_6;
            }
            
            TileSemanticInfo val_8 = val_1.LabeledTiles.Item[new UnityEngine.Vector2() {x = val_7, y = V1.16B}];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_10 = val_8.labelToObjId.Keys.GetEnumerator();
            label_20:
            if((1291599360 & 1) == 0)
            {
                goto label_9;
            }
            
            int val_14 = val_8.labelToObjId.Item[val_12.emailUIDataHandler];
            if((this.removeUpdates.ContainsKey(key:  val_14)) != true)
            {
                    val_6 = 0;
                val_7 = 0;
                this.removeUpdates.set_Item(key:  val_14, value:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {voxelResolution = 0f});
            }
            
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_16 = this.removeUpdates.Item[val_14];
            val_17.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo() {planeId = planeId, tileKey = new UnityEngine.Vector2() {x = val_7, y = V1.16B}, isAdd = V1.16B});
            ObjectGeometry val_18 = this._idToObject.Item[val_14];
            bool val_23 = val_21.Remove(item:  new TileInfo() {center = new UnityEngine.Vector2() {x = val_7, y = V1.16B}, planeId = planeId});
            val_7 = val_19;
            val_6 = val_20;
            this._idToObject.set_Item(key:  val_14, value:  new ObjectGeometry() {label = val_7, id = val_7, horizontalTiles = val_6, verticalTiles = val_21, voxelResolution = val_22, voxels = val_22});
            goto label_20;
            label_9:
            val_36 = val_34;
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078315520});
            if((((282 == 0) ? 282 : 282) == 282) || ( == 0))
            {
                goto label_34;
            }
            
            goto label_34;
            label_6:
            val_37 = 310;
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078315552});
            if(((282 == 0) ? 310 : 282) == 310)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_34 = 0;
            }
            
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_29 = this.removeUpdates.Values.GetEnumerator();
            label_48:
            if((1291599248 & 1) == 0)
            {
                goto label_49;
            }
            
            this._dispenser.UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = val_7, label = val_7, voxelResolution = val_6, horizontalTileUpdateInfo = val_6});
            goto label_48;
            label_49:
            long val_31 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078315408});
            val_33 = this.removeUpdates;
            val_33.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleRemovedVoxels()
        {
            System.Collections.Generic.HashSet<TileInfo> val_3;
            string val_4;
            var val_9;
            var val_14;
            float val_16;
            System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_17;
            string val_18;
            System.Collections.Generic.HashSet<TileInfo> val_19;
            var val_29;
            var val_31;
            var val_32;
            this._semanticVoxelTracker.PopulateVoxelsToRemove();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._semanticVoxelTracker.VoxelsToRemove.Keys.GetEnumerator();
            val_29 = 0;
            label_35:
            if((1291944752 & 1) == 0)
            {
                goto label_5;
            }
            
            BlockInfo val_5 = this._semanticVoxelTracker.VoxelsToRemove.Item[new UnityEngine.Vector3Int() {m_X = 1291944752, m_Y = 268435460, m_Z = 1291821424}];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = val_5.LabelToObjId.Keys.GetEnumerator();
            label_21:
            if((1291944720 & 1) == 0)
            {
                goto label_10;
            }
            
            int val_11 = val_5.LabelToObjId.Item[val_9.emailUIDataHandler];
            if((this.removeUpdates.ContainsKey(key:  val_11)) != true)
            {
                    val_3 = 0;
                val_4 = 0;
                this.removeUpdates.set_Item(key:  val_11, value:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {voxelResolution = 0f});
            }
            
            SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate val_13 = this.removeUpdates.Item[val_11];
            val_14.Add(item:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo() {coord = new UnityEngine.Vector3Int() {m_X = 1291944752, m_Y = 268435460, m_Z = 1291821424}, isAdd = false});
            ObjectGeometry val_15 = this._idToObject.Item[val_11];
            bool val_20 = val_17.Remove(item:  new UnityEngine.Vector3Int() {m_X = 1291944752, m_Y = 268435460, m_Z = 1291821424});
            val_4 = val_18;
            val_3 = val_19;
            this._idToObject.set_Item(key:  val_11, value:  new ObjectGeometry() {label = val_4, id = val_4, horizontalTiles = val_3, verticalTiles = val_3, voxelResolution = val_16, voxels = val_17});
            goto label_21;
            label_10:
            val_31 = val_29;
            long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078660880});
            if((((255 == 0) ? 255 : 255) == 255) || ( == 0))
            {
                goto label_35;
            }
            
            goto label_35;
            label_5:
            val_32 = 283;
            long val_23 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078660912});
            if(((255 == 0) ? 283 : 255) == 283)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
            }
            
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_26 = this.removeUpdates.Values.GetEnumerator();
            label_50:
            if((1291944608 & 1) == 0)
            {
                goto label_51;
            }
            
            this._dispenser.UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = val_4, label = val_4, voxelResolution = val_3, horizontalTileUpdateInfo = val_3, verticalTileUpdateInfo = val_16, voxelUpdateInfo = val_16});
            goto label_50;
            label_51:
            long val_28 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523078660768});
            this._semanticVoxelTracker.VoxelsToRemove.Clear();
            this.removeUpdates.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectTrackingManager()
        {
            this._collisions = new System.Collections.Generic.HashSet<System.Int32>();
            this.removeUpdates = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate>();
        }
    
    }

}
