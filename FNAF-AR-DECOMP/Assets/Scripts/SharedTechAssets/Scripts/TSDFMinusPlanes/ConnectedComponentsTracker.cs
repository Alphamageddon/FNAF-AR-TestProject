using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConnectedComponentsTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, int> _voxelToComponentId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker.VoxelConnectedComponent> IdToComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, int> _pointToNeighborType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _newComponentId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _componentSizeThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<int> _sufficientSizedComponents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<int> _changedComponents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache _coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> VisibleCoords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool>> _changesOnKnownComponents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int RIGHT = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int LEFT = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int UP = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DOWN = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int AWAY = 16;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOWARDS = 32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> seenPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> queue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<bool> groupReachesThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> skipNeighbors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool> changedVoxels;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConnectedComponentsTracker(com.illumix.IntVector3.IntVector3Cache coordCache)
        {
            this._componentSizeThreshold = 6;
            this.seenPoints = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.queue = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
            this.groupReachesThreshold = new System.Collections.Generic.List<System.Boolean>();
            this.skipNeighbors = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.changedVoxels = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>();
            this._voxelToComponentId = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int32>();
            this.IdToComponent = new System.Collections.Generic.Dictionary<System.Int32, VoxelConnectedComponent>();
            this._newComponentId = 0;
            this._sufficientSizedComponents = new System.Collections.Generic.HashSet<System.Int32>();
            this._changedComponents = new System.Collections.Generic.HashSet<System.Int32>();
            this._pointToNeighborType = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int32>();
            this._coordCache = coordCache;
            this._changesOnKnownComponents = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>>();
            this.VisibleCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateOpposite(com.illumix.IntVector3.IntVector3 voxel, byte direction, bool isAdd)
        {
            int val_51;
            int val_52;
            int val_53;
            int val_54;
            com.illumix.IntVector3.IntVector3 val_61;
            var val_62;
            var val_63;
            var val_64;
            int val_65;
            byte val_1 = direction & 255;
            if(val_1 > 8)
            {
                goto label_1;
            }
            
            val_1 = val_1 - 1;
            if(val_1 > 7)
            {
                goto label_6;
            }
            
            var val_47 = 52950304 + (((direction & 255) - 1)) << 2;
            val_47 = val_47 + 52950304;
            goto (52950304 + (((direction & 255) - 1)) << 2 + 52950304);
            label_1:
            if(val_1 == 16)
            {
                goto label_5;
            }
            
            if(val_1 != 32)
            {
                goto label_6;
            }
            
            if(voxel == null)
            {
                goto label_7;
            }
            
            val_51 = voxel.Item1;
            val_52 = voxel.Item2;
            goto label_8;
            label_5:
            if(voxel == null)
            {
                goto label_9;
            }
            
            val_53 = voxel.Item1;
            val_54 = voxel.Item2;
            goto label_10;
            label_7:
            val_51 = 0.Item1;
            val_52 = 0.Item2;
            label_8:
            val_61 = this._coordCache.GenerateIntVector(x:  val_51, y:  val_52, z:  voxel.Item3 - 2);
            val_62 = 16;
            goto label_26;
            label_9:
            val_53 = 0.Item1;
            val_54 = 0.Item2;
            label_10:
            val_61 = this._coordCache.GenerateIntVector(x:  val_53, y:  val_54, z:  voxel.Item3 + 2);
            val_62 = 32;
            label_26:
            if(this._pointToNeighborType == null)
            {
                goto label_28;
            }
            
            val_63 = this._pointToNeighborType.Item[null];
            if(isAdd == false)
            {
                goto label_29;
            }
            
            label_31:
            val_64 = 1152921523030712032;
            val_65 = val_63 | ;
            goto label_30;
            label_28:
            val_63 = 0.Item[null];
            if(isAdd == true)
            {
                goto label_31;
            }
            
            label_29:
            val_64 = 1152921523030712032;
            val_65 = val_63 & (~);
            label_30:
            this._pointToNeighborType.set_Item(key:  null, value:  val_65);
            return;
            label_6:
            System.InvalidOperationException val_46 = new System.InvalidOperationException(message:  "GetOpposite only takes the above directions");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int QueryNeighbors(com.illumix.IntVector3.IntVector3 voxel, out System.Collections.Generic.List<int> neighborIds)
        {
            System.Collections.Generic.List<T> val_56;
            var val_57;
            int val_58;
            var val_59;
            var val_60;
            int val_61;
            int val_62;
            var val_63;
            int val_64;
            var val_65;
            int val_66;
            int val_67;
            int val_68;
            int val_69;
            val_56 = 1152921523031063408;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            neighborIds = val_1;
            if(voxel != null)
            {
                    val_57 = voxel.Item1;
                val_58 = voxel.Item2;
            }
            else
            {
                    val_57 = 0.Item1;
                val_58 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_8 = this._coordCache.GenerateIntVector(x:  val_57 + 2, y:  val_58, z:  voxel.Item3);
            if((this._voxelToComponentId.ContainsKey(key:  val_8)) != false)
            {
                    val_1.Add(item:  this._voxelToComponentId.Item[val_8]);
                val_59 = 1;
            }
            else
            {
                    val_59 = 0;
            }
            
            if(voxel != null)
            {
                    val_60 = voxel.Item1;
                val_61 = voxel.Item2;
            }
            else
            {
                    val_60 = 0.Item1;
                val_61 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_17 = this._coordCache.GenerateIntVector(x:  val_60 - 2, y:  val_61, z:  voxel.Item3);
            if((this._voxelToComponentId.ContainsKey(key:  val_17)) != false)
            {
                    val_59 = val_59 | 2;
                val_1.Add(item:  this._voxelToComponentId.Item[val_17]);
            }
            
            if(voxel != null)
            {
                    val_62 = voxel.Item1;
                val_63 = voxel.Item2;
            }
            else
            {
                    val_62 = 0.Item1;
                val_63 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_26 = this._coordCache.GenerateIntVector(x:  val_62, y:  val_63 + 2, z:  voxel.Item3);
            if((this._voxelToComponentId.ContainsKey(key:  val_26)) != false)
            {
                    val_59 = val_59 | 4;
                val_1.Add(item:  this._voxelToComponentId.Item[val_26]);
            }
            
            if(voxel != null)
            {
                    val_64 = voxel.Item1;
                val_65 = voxel.Item2;
            }
            else
            {
                    val_64 = 0.Item1;
                val_65 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_35 = this._coordCache.GenerateIntVector(x:  val_64, y:  val_65 - 2, z:  voxel.Item3);
            if((this._voxelToComponentId.ContainsKey(key:  val_35)) != false)
            {
                    val_59 = val_59 | 8;
                val_1.Add(item:  this._voxelToComponentId.Item[val_35]);
            }
            
            if(voxel != null)
            {
                    val_66 = voxel.Item1;
                val_67 = voxel.Item2;
            }
            else
            {
                    val_66 = 0.Item1;
                val_67 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_44 = this._coordCache.GenerateIntVector(x:  val_66, y:  val_67, z:  voxel.Item3 + 2);
            if((this._voxelToComponentId.ContainsKey(key:  val_44)) != false)
            {
                    val_59 = val_59 | 16;
                val_1.Add(item:  this._voxelToComponentId.Item[val_44]);
            }
            
            if(voxel != null)
            {
                    val_68 = voxel.Item1;
                val_69 = voxel.Item2;
            }
            else
            {
                    val_68 = 0.Item1;
                val_69 = 0.Item2;
            }
            
            com.illumix.IntVector3.IntVector3 val_53 = this._coordCache.GenerateIntVector(x:  val_68, y:  val_69, z:  voxel.Item3 - 2);
            if((this._voxelToComponentId.ContainsKey(key:  val_53)) == false)
            {
                    return (int)val_59;
            }
            
            val_56 = neighborIds;
            val_59 = val_59 | 32;
            val_1.Add(item:  this._voxelToComponentId.Item[val_53]);
            return (int)val_59;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> GetUniqueNeighbors(System.Collections.Generic.List<int> neighbors)
        {
            var val_5;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_5 = 0;
            goto label_1;
            label_7:
            int val_2 = neighbors.Item[0];
            if((val_1.Contains(item:  val_2)) != true)
            {
                    val_1.Add(item:  val_2);
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < neighbors.Count)
            {
                goto label_7;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateNeighborsNeighbors(com.illumix.IntVector3.IntVector3 voxel, int neighborType, bool isAdd)
        {
            if((neighborType & 1) != 0)
            {
                goto label_0;
            }
            
            if((neighborType & 2) != 0)
            {
                goto label_1;
            }
            
            label_6:
            if((neighborType & 4) != 0)
            {
                goto label_2;
            }
            
            label_7:
            if((neighborType & 8) != 0)
            {
                goto label_3;
            }
            
            label_8:
            if((neighborType & 16) != 0)
            {
                goto label_4;
            }
            
            label_9:
            if((neighborType & 32) != 0)
            {
                goto label_5;
            }
            
            return;
            label_0:
            isAdd = isAdd;
            this.UpdateOpposite(voxel:  voxel, direction:  1, isAdd:  isAdd);
            if((neighborType & 2) == 0)
            {
                goto label_6;
            }
            
            label_1:
            this.UpdateOpposite(voxel:  voxel, direction:  2, isAdd:  isAdd);
            if((neighborType & 4) == 0)
            {
                goto label_7;
            }
            
            label_2:
            this.UpdateOpposite(voxel:  voxel, direction:  4, isAdd:  isAdd);
            if((neighborType & 8) == 0)
            {
                goto label_8;
            }
            
            label_3:
            this.UpdateOpposite(voxel:  voxel, direction:  8, isAdd:  isAdd);
            if((neighborType & 16) == 0)
            {
                goto label_9;
            }
            
            label_4:
            this.UpdateOpposite(voxel:  voxel, direction:  16, isAdd:  isAdd);
            if((neighborType & 32) == 0)
            {
                    return;
            }
            
            label_5:
            this.UpdateOpposite(voxel:  voxel, direction:  32, isAdd:  isAdd);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MergeComponents(System.Collections.Generic.List<int> componentIds)
        {
            var val_21;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            val_36 = 1152921517710430544;
            val_37 = 0;
            val_38 = 0;
            goto label_1;
            label_7:
            VoxelConnectedComponent val_2 = X23.Item[12007.Item[0]];
            int val_3 = val_2.tsdfCoords.Count;
            var val_4 = (val_3 > (-2147483648)) ? (val_3) : -2147483648;
            int val_5 = (val_3 > (-2147483648)) ? (val_37) : (val_38);
            val_37 = 1;
            label_1:
            if(val_37 < componentIds.Count)
            {
                goto label_7;
            }
            
            VoxelConnectedComponent val_8 = this.IdToComponent.Item[componentIds.Item[val_5]];
            int val_9 = componentIds.Item[val_5];
            if((this._sufficientSizedComponents.Contains(item:  val_9)) != false)
            {
                    if((this._changesOnKnownComponents.ContainsKey(key:  val_9)) != true)
            {
                    this._changesOnKnownComponents.set_Item(key:  val_9, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>());
            }
            
            }
            
            val_39 = 0;
            val_40 = 0;
            goto label_15;
            label_61:
            if(val_39 == val_5)
            {
                goto label_16;
            }
            
            int val_13 = componentIds.Item[0];
            if((this._sufficientSizedComponents.Contains(item:  val_13)) != false)
            {
                    if((this._changesOnKnownComponents.ContainsKey(key:  val_13)) != true)
            {
                    this._changesOnKnownComponents.set_Item(key:  val_13, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>());
            }
            
            }
            
            VoxelConnectedComponent val_18 = this.IdToComponent.Item[componentIds.Item[0]];
            HashSet.Enumerator<T> val_19 = val_18.tsdfCoords.GetEnumerator();
            label_37:
            if((1244903232 & 1) == 0)
            {
                goto label_27;
            }
            
            GameUI.EmailUIDataHandler val_22 = val_21.emailUIDataHandler;
            this._voxelToComponentId.set_Item(key:  val_22, value:  val_9);
            if((this._sufficientSizedComponents.Contains(item:  val_9)) != false)
            {
                    this._changesOnKnownComponents.Item[val_9].set_Item(key:  val_22, value:  true);
            }
            
            if((this._sufficientSizedComponents.Contains(item:  val_13)) == false)
            {
                goto label_37;
            }
            
            this._changesOnKnownComponents.Item[val_13].set_Item(key:  val_22, value:  false);
            goto label_37;
            label_27:
            val_41 = 0;
            long val_27 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523031619392});
            if(((368 == 0) ? 368 : 368) == 368)
            {
                    val_40 = 0;
            }
            
            bool val_29 = this._changedComponents.Add(item:  val_13);
            VoxelConnectedComponent val_31 = this.IdToComponent.Item[componentIds.Item[0]];
            val_8 + 16.UnionWith(other:  val_31.tsdfCoords);
            VoxelConnectedComponent val_33 = this.IdToComponent.Item[componentIds.Item[0]];
            val_36 = 1152921517710430544;
            val_33.tsdfCoords.Clear();
            label_16:
            val_39 = 1;
            label_15:
            if(val_39 < componentIds.Count)
            {
                goto label_61;
            }
            
            return val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddVoxel(com.illumix.IntVector3.IntVector3 voxel)
        {
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int32> val_20;
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int32> val_21;
            var val_22;
            System.Collections.Generic.List<System.Int32> val_2 = 0;
            val_20 = this._voxelToComponentId;
            if((val_20.ContainsKey(key:  voxel)) == true)
            {
                    return;
            }
            
            int val_3 = this.QueryNeighbors(voxel:  voxel, neighborIds: out  val_2);
            System.Collections.Generic.List<System.Int32> val_4 = val_3.GetUniqueNeighbors(neighbors:  val_2);
            val_21 = this._pointToNeighborType;
            val_21.set_Item(key:  voxel, value:  val_3);
            this.UpdateNeighborsNeighbors(voxel:  voxel, neighborType:  val_3, isAdd:  true);
            if(val_4 == null)
            {
                goto label_4;
            }
            
            if(val_4.Count != 1)
            {
                goto label_5;
            }
            
            label_7:
            val_22 = val_4;
            int val_6 = val_22.Item[0];
            goto label_6;
            label_4:
            if(val_4.Count == 1)
            {
                goto label_7;
            }
            
            label_5:
            if(val_4.Count >= 2)
            {
                goto label_8;
            }
            
            val_20 = this._newComponentId;
            this._newComponentId = val_20 + 1;
            ConnectedComponentsTracker.VoxelConnectedComponent val_10 = null;
            val_21 = val_10;
            val_10 = new ConnectedComponentsTracker.VoxelConnectedComponent();
            .id = val_20;
            .tsdfCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.IdToComponent.set_Item(key:  val_20, value:  val_10);
            goto label_12;
            label_8:
            val_22 = this;
            label_6:
            val_20 = this.MergeComponents(componentIds:  val_4);
            label_12:
            bool val_13 = this._changedComponents.Add(item:  val_20);
            VoxelConnectedComponent val_14 = this.IdToComponent.Item[val_20];
            bool val_15 = val_14.tsdfCoords.Add(item:  voxel);
            this._voxelToComponentId.set_Item(key:  voxel, value:  val_20);
            if((this._sufficientSizedComponents.Contains(item:  val_20)) == false)
            {
                    return;
            }
            
            if((this._changesOnKnownComponents.ContainsKey(key:  val_20)) != true)
            {
                    System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_18 = null;
                val_21 = val_18;
                val_18 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>();
                this._changesOnKnownComponents.set_Item(key:  val_20, value:  val_18);
            }
            
            this._changesOnKnownComponents.Item[val_20].set_Item(key:  voxel, value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> GetNeighbors(com.illumix.IntVector3.IntVector3 voxel, int neighborType)
        {
            com.illumix.IntVector3.IntVector3Cache val_44;
            var val_45;
            int val_46;
            var val_47;
            int val_48;
            int val_49;
            var val_50;
            int val_51;
            int val_52;
            com.illumix.IntVector3.IntVector3 val_53;
            int val_54;
            int val_55;
            val_44 = this;
            System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_1 = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
            if((neighborType & 1) != 0)
            {
                goto label_1;
            }
            
            if((neighborType & 2) != 0)
            {
                goto label_2;
            }
            
            label_11:
            if((neighborType & 4) != 0)
            {
                goto label_3;
            }
            
            label_16:
            if((neighborType & 8) != 0)
            {
                goto label_4;
            }
            
            label_21:
            if((neighborType & 16) != 0)
            {
                goto label_5;
            }
            
            goto label_26;
            label_1:
            if(voxel != null)
            {
                    val_45 = voxel.Item1;
                val_46 = voxel.Item2;
            }
            else
            {
                    val_45 = 0.Item1;
                val_46 = 0.Item2;
            }
            
            val_1.Add(item:  this._coordCache.GenerateIntVector(x:  val_45 + 2, y:  val_46, z:  voxel.Item3));
            if((neighborType & 2) == 0)
            {
                goto label_11;
            }
            
            label_2:
            if(voxel != null)
            {
                    val_47 = voxel.Item1;
                val_48 = voxel.Item2;
            }
            else
            {
                    val_47 = 0.Item1;
                val_48 = 0.Item2;
            }
            
            val_1.Add(item:  this._coordCache.GenerateIntVector(x:  val_47 - 2, y:  val_48, z:  voxel.Item3));
            if((neighborType & 4) == 0)
            {
                goto label_16;
            }
            
            label_3:
            if(voxel != null)
            {
                    val_49 = voxel.Item1;
                val_50 = voxel.Item2;
            }
            else
            {
                    val_49 = 0.Item1;
                val_50 = 0.Item2;
            }
            
            val_1.Add(item:  this._coordCache.GenerateIntVector(x:  val_49, y:  val_50 + 2, z:  voxel.Item3));
            if((neighborType & 8) == 0)
            {
                goto label_21;
            }
            
            label_4:
            if(voxel != null)
            {
                    val_51 = voxel.Item1;
                val_52 = voxel.Item2;
            }
            else
            {
                    val_51 = 0.Item1;
                val_52 = 0.Item2;
            }
            
            val_53 = this._coordCache.GenerateIntVector(x:  val_51, y:  val_52 - 2, z:  voxel.Item3);
            val_1.Add(item:  val_53);
            if((neighborType & 16) == 0)
            {
                goto label_26;
            }
            
            label_5:
            if(voxel != null)
            {
                    val_54 = voxel.Item1;
                val_52 = voxel.Item2;
            }
            else
            {
                    val_54 = 0.Item1;
                val_52 = 0.Item2;
            }
            
            val_53 = this._coordCache.GenerateIntVector(x:  val_54, y:  val_52, z:  voxel.Item3 + 2);
            val_1.Add(item:  val_53);
            label_26:
            var val_44 = (uint)(neighborType >> 5) & 1;
            val_44 = val_44 + 7;
            val_44 = val_44 & 7;
            if(val_44 != 0)
            {
                    return val_1;
            }
            
            val_44 = this._coordCache;
            if(voxel != null)
            {
                    val_55 = voxel.Item1;
                val_53 = voxel.Item2;
            }
            else
            {
                    val_55 = 0.Item1;
                val_53 = 0.Item2;
            }
            
            val_1.Add(item:  val_44.GenerateIntVector(x:  val_55, y:  val_53, z:  voxel.Item3 - 2));
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveComponentsApprox(com.illumix.IntVector3.IntVector3 voxel, int id, int neighborsType)
        {
            var val_70;
            System.Collections.Generic.IEnumerable<T> val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            int val_91;
            var val_92;
            int val_93;
            int val_94;
            var val_95;
            int val_96;
            var val_97;
            int val_98;
            int val_99;
            int val_100;
            int val_101;
            var val_102;
            System.Collections.Generic.Dictionary<TKey, TValue> val_103;
            System.Collections.Generic.Dictionary<TKey, TValue> val_104;
            var val_105;
            var val_106;
            var val_107;
            var val_110;
            this.seenPoints.Clear();
            this.queue.Clear();
            this.groupReachesThreshold.Clear();
            this.skipNeighbors.Clear();
            val_86 = this.GetNeighbors(voxel:  voxel, neighborType:  neighborsType);
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_2 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>(collection:  val_86);
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>>();
            val_87 = 0;
            goto label_5;
            label_71:
            com.illumix.IntVector3.IntVector3 val_4 = val_86.Item[0];
            if((this.skipNeighbors.Contains(item:  val_4)) == false)
            {
                goto label_8;
            }
            
            this.groupReachesThreshold.Add(item:  true);
            val_88 = val_87;
            goto label_10;
            label_8:
            bool val_6 = val_2.Remove(item:  val_4);
            this.queue.Clear();
            this.queue.Add(item:  val_4);
            val_89 = 0;
            goto label_56;
            label_66:
            int val_7 = this._pointToNeighborType.Item[X26];
            if((val_7 & 1) != 0)
            {
                    if(X26 != 0)
            {
                    val_90 = X26.Item1;
                val_91 = X26.Item2;
            }
            else
            {
                    val_90 = X26.Item1;
                val_91 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_14 = this._coordCache.GenerateIntVector(x:  val_90 + 2, y:  val_91, z:  X26.Item3);
                if((this.seenPoints.Contains(item:  val_14)) != true)
            {
                    this.queue.Add(item:  val_14);
            }
            
            }
            
            if((val_7 & 2) != 0)
            {
                    if(X26 != 0)
            {
                    val_92 = X26.Item1;
                val_93 = X26.Item2;
            }
            else
            {
                    val_92 = X26.Item1;
                val_93 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_22 = this._coordCache.GenerateIntVector(x:  val_92 - 2, y:  val_93, z:  X26.Item3);
                if((this.seenPoints.Contains(item:  val_22)) != true)
            {
                    this.queue.Add(item:  val_22);
            }
            
            }
            
            if((val_7 & 4) != 0)
            {
                    if(X26 != 0)
            {
                    val_94 = X26.Item1;
                val_95 = X26.Item2;
            }
            else
            {
                    val_94 = X26.Item1;
                val_95 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_30 = this._coordCache.GenerateIntVector(x:  val_94, y:  val_95 + 2, z:  X26.Item3);
                if((this.seenPoints.Contains(item:  val_30)) != true)
            {
                    this.queue.Add(item:  val_30);
            }
            
            }
            
            if((val_7 & 8) != 0)
            {
                    if(X26 != 0)
            {
                    val_96 = X26.Item1;
                val_97 = X26.Item2;
            }
            else
            {
                    val_96 = X26.Item1;
                val_97 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_38 = this._coordCache.GenerateIntVector(x:  val_96, y:  val_97 - 2, z:  X26.Item3);
                if((this.seenPoints.Contains(item:  val_38)) != true)
            {
                    this.queue.Add(item:  val_38);
            }
            
            }
            
            val_89 = 1;
            if((val_7 & 16) != 0)
            {
                    if(X26 != 0)
            {
                    val_98 = X26.Item1;
                val_99 = X26.Item2;
            }
            else
            {
                    val_98 = X26.Item1;
                val_99 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_46 = this._coordCache.GenerateIntVector(x:  val_98, y:  val_99, z:  X26.Item3 + 2);
                if((this.seenPoints.Contains(item:  val_46)) != true)
            {
                    this.queue.Add(item:  val_46);
            }
            
            }
            
            if((val_7 & 32) != 0)
            {
                    if(X26 != 0)
            {
                    val_100 = X26.Item1;
                val_101 = X26.Item2;
            }
            else
            {
                    val_100 = X26.Item1;
                val_101 = X26.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_54 = this._coordCache.GenerateIntVector(x:  val_100, y:  val_101, z:  X26.Item3 - 2);
                if((this.seenPoints.Contains(item:  val_54)) != true)
            {
                    this.queue.Add(item:  val_54);
            }
            
            }
            
            label_56:
            if(val_89 >= this.queue.Count)
            {
                goto label_59;
            }
            
            com.illumix.IntVector3.IntVector3 val_57 = this.queue.Item[1];
            bool val_58 = this.seenPoints.Add(item:  val_57);
            if((val_2.Contains(item:  val_57)) != false)
            {
                    bool val_60 = this.skipNeighbors.Add(item:  val_57);
            }
            
            if(this.seenPoints.Count < this._componentSizeThreshold)
            {
                goto label_66;
            }
            
            val_102 = 1;
            goto label_67;
            label_59:
            val_102 = 0;
            label_67:
            val_88 = val_87;
            this.groupReachesThreshold.Add(item:  false);
            val_103 = val_3;
            if(val_103 == 0)
            {
                    val_103 = val_3;
            }
            
            val_3.set_Item(key:  0, value:  this.seenPoints);
            this.seenPoints = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            label_10:
            val_86 = val_86;
            val_87 = val_88 + 1;
            label_5:
            if(val_87 < val_86.Count)
            {
                goto label_71;
            }
            
            if((this._sufficientSizedComponents.Contains(item:  id)) != false)
            {
                    if((this._changesOnKnownComponents.ContainsKey(key:  id)) != true)
            {
                    this._changesOnKnownComponents.set_Item(key:  id, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>());
            }
            
            }
            
            val_104 = val_3;
            if(val_104 == 0)
            {
                    val_104 = val_3;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_68 = val_3.Keys.GetEnumerator();
            val_105 = 0;
            val_106 = 0;
            label_109:
            if((1245916096 & 1) == 0)
            {
                goto label_79;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_71 = val_70.region;
            if(this.groupReachesThreshold.Item[val_71] == true)
            {
                goto label_109;
            }
            
            int val_86 = this._newComponentId;
            val_86 = val_86 + 1;
            this._newComponentId = val_86;
            new ConnectedComponentsTracker.VoxelConnectedComponent() = new System.Object();
            .id = val_86;
            .tsdfCoords = val_3.Item[val_71];
            this.IdToComponent.set_Item(key:  val_86, value:  new ConnectedComponentsTracker.VoxelConnectedComponent());
            bool val_75 = this._changedComponents.Add(item:  val_86);
            HashSet.Enumerator<T> val_77 = val_3.Item[val_71].GetEnumerator();
            label_97:
            if((1245916064 & 1) == 0)
            {
                goto label_88;
            }
            
            GameUI.EmailUIDataHandler val_78 = val_70.emailUIDataHandler;
            if((this._sufficientSizedComponents.Contains(item:  id)) != false)
            {
                    this._changesOnKnownComponents.Item[id].set_Item(key:  val_78, value:  false);
            }
            
            VoxelConnectedComponent val_81 = this.IdToComponent.Item[id];
            bool val_82 = val_81.tsdfCoords.Remove(item:  val_78);
            this._voxelToComponentId.set_Item(key:  val_78, value:  val_86);
            goto label_97;
            label_88:
            val_107 = val_106;
            long val_83 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523032632224});
            if((((1044 == 0) ? 1044 : 1044) == 1044) || ( == 0))
            {
                goto label_109;
            }
            
            goto label_109;
            label_79:
            val_110 = 1072;
            long val_85 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523032632256});
            if( == 0)
            {
                    return;
            }
            
            if((public System.Boolean System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>::Contains(com.illumix.IntVector3.IntVector3 item)) == 0)
            {
                    return;
            }
            
            if( == 1072)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveComponents(com.illumix.IntVector3.IntVector3 voxel, int id, int neighborsType)
        {
            var val_69;
            System.Collections.Generic.IEnumerable<T> val_99;
            System.Collections.Generic.Dictionary<TKey, TValue> val_100;
            var val_101;
            System.Collections.Generic.HashSet<T> val_102;
            var val_103;
            System.Collections.Generic.HashSet<T> val_104;
            var val_105;
            int val_106;
            var val_107;
            int val_108;
            int val_109;
            var val_110;
            int val_111;
            var val_112;
            int val_113;
            int val_114;
            int val_115;
            int val_116;
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_117;
            var val_118;
            var val_119;
            var val_120;
            var val_121;
            var val_122;
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_1 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_2 = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_3 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            val_99 = this.GetNeighbors(voxel:  voxel, neighborType:  neighborsType);
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_5 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>(collection:  val_99);
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>> val_6 = null;
            val_100 = val_6;
            val_6 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>>();
            val_101 = 0;
            goto label_1;
            label_61:
            com.illumix.IntVector3.IntVector3 val_7 = val_99.Item[0];
            val_102 = val_3;
            if(val_102 == 0)
            {
                    val_102 = val_3;
            }
            
            if((val_3.Contains(item:  val_7)) == true)
            {
                goto label_4;
            }
            
            bool val_9 = val_5.Remove(item:  val_7);
            if(val_2 != null)
            {
                    val_2.Clear();
            }
            else
            {
                    val_2.Clear();
            }
            
            val_2.Add(item:  val_7);
            val_103 = 0;
            goto label_55;
            label_58:
            com.illumix.IntVector3.IntVector3 val_10 = val_2.Item[0];
            bool val_11 = val_1.Add(item:  val_10);
            if((val_5.Contains(item:  val_10)) != false)
            {
                    val_104 = val_3;
                if(val_104 == 0)
            {
                    val_104 = val_3;
            }
            
                bool val_13 = val_3.Add(item:  val_10);
            }
            
            int val_14 = mem[1152921523033166016].Item[val_10];
            if((val_14 & 1) != 0)
            {
                    if(val_10 != null)
            {
                    val_105 = val_10.Item1;
                val_106 = val_10.Item2;
            }
            else
            {
                    val_105 = val_10.Item1;
                val_106 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_21 = mem[1152921523033166048].GenerateIntVector(x:  val_105 + 2, y:  val_106, z:  val_10.Item3);
                if((val_1.Contains(item:  val_21)) != true)
            {
                    val_2.Add(item:  val_21);
            }
            
            }
            
            if((val_14 & 2) != 0)
            {
                    if(val_10 != null)
            {
                    val_107 = val_10.Item1;
                val_108 = val_10.Item2;
            }
            else
            {
                    val_107 = val_10.Item1;
                val_108 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_29 = mem[1152921523033166048].GenerateIntVector(x:  val_107 - 2, y:  val_108, z:  val_10.Item3);
                if((val_1.Contains(item:  val_29)) != true)
            {
                    val_2.Add(item:  val_29);
            }
            
            }
            
            if((val_14 & 4) != 0)
            {
                    if(val_10 != null)
            {
                    val_109 = val_10.Item1;
                val_110 = val_10.Item2;
            }
            else
            {
                    val_109 = val_10.Item1;
                val_110 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_37 = mem[1152921523033166048].GenerateIntVector(x:  val_109, y:  val_110 + 2, z:  val_10.Item3);
                if((val_1.Contains(item:  val_37)) != true)
            {
                    val_2.Add(item:  val_37);
            }
            
            }
            
            if((val_14 & 8) != 0)
            {
                    if(val_10 != null)
            {
                    val_111 = val_10.Item1;
                val_112 = val_10.Item2;
            }
            else
            {
                    val_111 = val_10.Item1;
                val_112 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_45 = mem[1152921523033166048].GenerateIntVector(x:  val_111, y:  val_112 - 2, z:  val_10.Item3);
                if((val_1.Contains(item:  val_45)) != true)
            {
                    val_2.Add(item:  val_45);
            }
            
            }
            
            val_103 = 1;
            if((val_14 & 16) != 0)
            {
                    if(val_10 != null)
            {
                    val_113 = val_10.Item1;
                val_114 = val_10.Item2;
            }
            else
            {
                    val_113 = val_10.Item1;
                val_114 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_53 = mem[1152921523033166048].GenerateIntVector(x:  val_113, y:  val_114, z:  val_10.Item3 + 2);
                if((val_1.Contains(item:  val_53)) != true)
            {
                    val_2.Add(item:  val_53);
            }
            
            }
            
            if((val_14 & 32) != 0)
            {
                    if(val_10 != null)
            {
                    val_115 = val_10.Item1;
                val_116 = val_10.Item2;
            }
            else
            {
                    val_115 = val_10.Item1;
                val_116 = val_10.Item2;
            }
            
                com.illumix.IntVector3.IntVector3 val_61 = mem[1152921523033166048].GenerateIntVector(x:  val_115, y:  val_116, z:  val_10.Item3 - 2);
                if((val_1.Contains(item:  val_61)) != true)
            {
                    val_2.Add(item:  val_61);
            }
            
            }
            
            label_55:
            if(val_103 < val_2.Count)
            {
                goto label_58;
            }
            
            val_100 = val_100;
            val_6.set_Item(key:  0, value:  val_1);
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_64 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            val_99 = val_99;
            label_4:
            val_101 = 1;
            label_1:
            if(val_101 < val_99.Count)
            {
                goto label_61;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_67 = val_6.Keys.GetEnumerator();
            val_117 = 0;
            label_70:
            label_67:
            if((1246437696 & 1) == 0)
            {
                goto label_64;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_70 = val_69.region;
            if(val_6.Item[val_70].Count <= val_117)
            {
                goto label_67;
            }
            
            int val_74 = val_6.Item[val_70].Count;
            goto label_70;
            label_64:
            long val_75 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033153856});
            if((mem[1152921523033166032].Contains(item:  id)) != false)
            {
                    if((mem[1152921523033166064].ContainsKey(key:  id)) != true)
            {
                    System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_79 = null;
                val_117 = val_79;
                val_79 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>();
                mem[1152921523033166064].set_Item(key:  id, value:  val_79);
            }
            
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_81 = val_6.Keys.GetEnumerator();
            val_118 = 0;
            val_119 = 0;
            label_115:
            if((1246437696 & 1) == 0)
            {
                goto label_85;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_82 = val_69.region;
            if(val_82 != 0)
            {
                goto label_86;
            }
            
            VoxelConnectedComponent val_83 = mem[1152921523033166008].Item[id];
            int val_84 = val_83.tsdfCoords.Count;
            VoxelConnectedComponent val_85 = mem[1152921523033166008].Item[id];
            val_85.tsdfCoords = val_6.Item[0];
            goto label_115;
            label_86:
            mem[1152921523033166024] = mem[1152921523033166024] + 1;
            new ConnectedComponentsTracker.VoxelConnectedComponent() = new System.Object();
            .id = mem[1152921523033166024];
            .tsdfCoords = val_6.Item[val_82];
            mem[1152921523033166008].set_Item(key:  mem[1152921523033166024], value:  new ConnectedComponentsTracker.VoxelConnectedComponent());
            bool val_90 = mem[1152921523033166040].Add(item:  mem[1152921523033166024]);
            HashSet.Enumerator<T> val_92 = val_6.Item[val_82].GetEnumerator();
            label_106:
            val_120 = 1152921518982210176;
            if((1246437664 & 1) == 0)
            {
                goto label_100;
            }
            
            GameUI.EmailUIDataHandler val_93 = val_69.emailUIDataHandler;
            if((mem[1152921523033166032].Contains(item:  id)) != false)
            {
                    mem[1152921523033166064].Item[id].set_Item(key:  val_93, value:  false);
            }
            
            mem[1152921523033166000].set_Item(key:  val_93, value:  mem[1152921523033166024]);
            goto label_106;
            label_100:
            val_121 = val_119;
            long val_96 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033153824});
            if((((981 == 0) ? 981 : 981) == 981) || ( == 0))
            {
                goto label_115;
            }
            
            goto label_115;
            label_85:
            val_122 = 1009;
            long val_98 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033153856});
            if( == 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
            
            if( == 1009)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveVoxel(com.illumix.IntVector3.IntVector3 voxel)
        {
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int32> val_14 = this._voxelToComponentId;
            if((val_14.ContainsKey(key:  voxel)) == false)
            {
                    return;
            }
            
            val_14 = this.QueryNeighbors(voxel:  voxel, neighborIds: out  0);
            this._pointToNeighborType.set_Item(key:  voxel, value:  0);
            this.UpdateNeighborsNeighbors(voxel:  voxel, neighborType:  val_14, isAdd:  false);
            int val_4 = this._voxelToComponentId.Item[voxel];
            if((this._sufficientSizedComponents.Contains(item:  val_4)) != false)
            {
                    if((this._changesOnKnownComponents.ContainsKey(key:  val_4)) != true)
            {
                    this._changesOnKnownComponents.set_Item(key:  val_4, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>());
            }
            
                this._changesOnKnownComponents.Item[val_4].set_Item(key:  voxel, value:  false);
            }
            
            bool val_9 = this._voxelToComponentId.Remove(key:  voxel);
            bool val_10 = this._changedComponents.Add(item:  val_4);
            if(val_2.Count > 1)
            {
                    this.RemoveComponentsApprox(voxel:  voxel, id:  val_4, neighborsType:  val_14);
                return;
            }
            
            VoxelConnectedComponent val_12 = this.IdToComponent.Item[val_4];
            bool val_13 = val_12.tsdfCoords.Remove(item:  voxel);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateVoxels(System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool> changes)
        {
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = changes.Keys.GetEnumerator();
            label_7:
            if((1246937192 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_3 = 0.emailUIDataHandler;
            if(changes.Item[val_3] == false)
            {
                goto label_5;
            }
            
            this.AddVoxel(voxel:  val_3);
            goto label_7;
            label_5:
            this.RemoveVoxel(voxel:  val_3);
            goto label_7;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033653352});
            this.UpdateChangedVoxels();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateChangedVoxels()
        {
            var val_3;
            var val_18;
            var val_31;
            var val_42;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_57;
            var val_59;
            var val_60;
            this.changedVoxels.Clear();
            HashSet.Enumerator<T> val_1 = this._changedComponents.GetEnumerator();
            val_52 = 1152921518981974352;
            val_53 = 1152921518981976400;
            val_54 = 0;
            val_55 = 0;
            label_96:
            if((1247228352 & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_4 = val_3.region;
            VoxelConnectedComponent val_5 = this.IdToComponent.Item[val_4];
            if(val_5.tsdfCoords.Count < this._componentSizeThreshold)
            {
                goto label_7;
            }
            
            if((this._sufficientSizedComponents.Contains(item:  val_4)) == true)
            {
                goto label_9;
            }
            
            bool val_8 = this._sufficientSizedComponents.Add(item:  val_4);
            HashSet.Enumerator<T> val_9 = val_5.tsdfCoords.GetEnumerator();
            label_15:
            if((1247228320 & 1) == 0)
            {
                goto label_16;
            }
            
            GameUI.EmailUIDataHandler val_10 = val_3.emailUIDataHandler;
            this.changedVoxels.set_Item(key:  val_10, value:  true);
            bool val_11 = this.VisibleCoords.Add(item:  val_10);
            goto label_15;
            label_16:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033944480});
            if(((617 == 0) ? 617 : 617) == 617)
            {
                goto label_96;
            }
            
            if( != 0)
            {
                    val_57 = 0;
            }
            
            label_9:
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_14 = this._changesOnKnownComponents.Item[val_4];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_16 = val_14.Keys.GetEnumerator();
            label_38:
            val_52 = val_52;
            if((1247228288 & 1) == 0)
            {
                goto label_26;
            }
            
            GameUI.EmailUIDataHandler val_19 = val_18.emailUIDataHandler;
            if(val_14.Item[val_19] == false)
            {
                goto label_28;
            }
            
            this.changedVoxels.set_Item(key:  val_19, value:  true);
            bool val_21 = this.VisibleCoords.Add(item:  val_19);
            goto label_38;
            label_28:
            if((this.changedVoxels.ContainsKey(key:  val_19)) != false)
            {
                    if(this.changedVoxels.Item[val_19] == true)
            {
                goto label_38;
            }
            
            }
            
            this.changedVoxels.set_Item(key:  val_19, value:  false);
            bool val_24 = this.VisibleCoords.Remove(item:  val_19);
            goto label_38;
            label_26:
            val_53 = 1152921518981976400;
            long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033944448});
            if(((617 == 0) ? 617 : 617) == 617)
            {
                goto label_96;
            }
            
            if( != 0)
            {
                    val_57 = 0;
            }
            
            label_7:
            if((this._sufficientSizedComponents.Contains(item:  val_4)) == false)
            {
                goto label_96;
            }
            
            bool val_28 = this._sufficientSizedComponents.Remove(item:  val_4);
            HashSet.Enumerator<T> val_29 = val_5.tsdfCoords.GetEnumerator();
            label_63:
            if((1247228320 & 1) == 0)
            {
                goto label_64;
            }
            
            GameUI.EmailUIDataHandler val_32 = val_31.emailUIDataHandler;
            if((this.changedVoxels.ContainsKey(key:  val_32)) != false)
            {
                    if(this.changedVoxels.Item[val_32] == true)
            {
                goto label_63;
            }
            
            }
            
            this.changedVoxels.set_Item(key:  val_32, value:  false);
            bool val_35 = this.VisibleCoords.Remove(item:  val_32);
            goto label_63;
            label_64:
            long val_36 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033944480});
            if(((479 == 0) ? 479 : 479) == 479)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_57 = 0;
            }
            
            }
            
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_38 = this._changesOnKnownComponents.Item[val_4];
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_40 = val_38.Keys.GetEnumerator();
            label_86:
            if((1247228288 & 1) == 0)
            {
                goto label_77;
            }
            
            GameUI.EmailUIDataHandler val_43 = val_42.emailUIDataHandler;
            if(val_38.Item[val_43] == true)
            {
                goto label_86;
            }
            
            if((this.changedVoxels.ContainsKey(key:  val_43)) != false)
            {
                    if(this.changedVoxels.Item[val_43] == true)
            {
                goto label_86;
            }
            
            }
            
            this.changedVoxels.set_Item(key:  val_43, value:  false);
            bool val_47 = this.VisibleCoords.Remove(item:  val_43);
            goto label_86;
            label_77:
            val_59 = ;
            long val_48 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033944448});
            if((((617 == 0) ? 617 : 617) == 617) || ( == 0))
            {
                goto label_96;
            }
            
            goto label_96;
            label_3:
            val_60 = 645;
            long val_50 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523033944512});
            this._changedComponents.Clear();
            this._changesOnKnownComponents.Clear();
        }
    
    }

}
