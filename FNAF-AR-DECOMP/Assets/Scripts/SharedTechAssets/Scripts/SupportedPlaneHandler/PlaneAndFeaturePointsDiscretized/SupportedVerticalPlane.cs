using UnityEngine;

namespace SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedVerticalPlane : SupportedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 <Center>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> <DiscretizedPointsInSpace>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 <Normal>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _trueNormal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _trueCenter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2> _discretizedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _upBasis;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _sideBasis;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> _tileVertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlane.Tile> _tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> _planeSpaceBoundary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig.Vertical _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _distanceSinceChange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _angleSinceChange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _bufferPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector3 centerUp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 _bufferIntPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.RecentlyAddedData recentlyAddedData;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Center { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> DiscretizedPointsInSpace { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Normal { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_Center()
        {
            return new UnityEngine.Vector3() {x = this.<Center>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Center(UnityEngine.Vector3 value)
        {
            this.<Center>k__BackingField = value;
            mem[1152921523070050932] = value.y;
            mem[1152921523070050936] = value.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> get_DiscretizedPointsInSpace()
        {
            return (System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>)this.<DiscretizedPointsInSpace>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DiscretizedPointsInSpace(System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3> value)
        {
            this.<DiscretizedPointsInSpace>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 get_Normal()
        {
            return new UnityEngine.Vector3() {x = this.<Normal>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Normal(UnityEngine.Vector3 value)
        {
            this.<Normal>k__BackingField = value;
            mem[1152921523070515340] = value.y;
            mem[1152921523070515344] = value.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedVerticalPlane(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig.Vertical config, int id, UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 normal)
        {
            this._tiles = new System.Collections.Generic.Dictionary<IntVector2, Tile>();
            this.centerUp = 0;
            mem[1152921523070659236] = 0;
            val_2 = new System.Object();
            mem[1152921523070659056] = id;
            mem[1152921523070659064] = val_2;
            this.<Center>k__BackingField = center;
            mem[1152921523070659076] = center.y;
            mem[1152921523070659080] = center.z;
            this._trueCenter = center;
            mem[1152921523070659124] = center.y;
            mem[1152921523070659128] = center.z;
            this.<Normal>k__BackingField = normal;
            mem[1152921523070659100] = normal.y;
            mem[1152921523070659104] = normal.z;
            mem[1152921523070659208] = config.angleTolerance;
            this._config = config.resolution;
            this._discretizedPoints = new System.Collections.Generic.HashSet<IntVector2>();
            this.<DiscretizedPointsInSpace>k__BackingField = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>();
            UnityEngine.Vector3 val_5 = this.GetUpVector();
            this._upBasis = val_5;
            mem[1152921523070659148] = val_5.y;
            mem[1152921523070659152] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            this._sideBasis = val_6;
            mem[1152921523070659160] = val_6.y;
            mem[1152921523070659164] = val_6.z;
            this._tileVertices = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]>();
            this._planeSpaceBoundary = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this.ComputePlaneSpaceBoundary();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ComputePlaneSpaceBoundary()
        {
            var val_4;
            this._planeSpaceBoundary.Clear();
            val_4 = 0;
            goto label_2;
            label_6:
            UnityEngine.Vector3 val_1 = X22.Item[0];
            UnityEngine.Vector2 val_2 = this.ConvertToPlaneSpace(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this._planeSpaceBoundary.Add(item:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_4 = 1;
            label_2:
            if(val_4 < this._planeSpaceBoundary.Count)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 ConvertToPlaneSpace(UnityEngine.Vector3 point)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = this.<Center>k__BackingField, y = V11.16B, z = V12.16B});
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = this._upBasis, y = V11.16B, z = V12.16B});
            this._bufferPoint = new UnityEngine.Vector2(x:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = this._sideBasis, y = V11.16B, z = V12.16B}), y:  val_3);
            return new UnityEngine.Vector2() {x = this._bufferPoint, y = val_3};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PointWithinVerticalPolygon(UnityEngine.Vector3 point)
        {
            float val_14;
            var val_15;
            System.Collections.Generic.List<UnityEngine.Vector2> val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            val_14 = point.x;
            UnityEngine.Vector2 val_1 = this.ConvertToPlaneSpace(point:  new UnityEngine.Vector3() {x = val_14, y = point.y, z = point.z});
            this._bufferPoint = val_1;
            mem[1152921523071056680] = val_1.y;
            UnityEngine.Vector2 val_2 = this._planeSpaceBoundary.Item[0];
            val_15 = 2;
            goto label_2;
            label_15:
            UnityEngine.Vector2 val_3 = this._planeSpaceBoundary.Item[W21];
            val_16 = this._planeSpaceBoundary;
            val_14 = val_3.x;
            UnityEngine.Vector2 val_4 = val_16.Item[2];
            float val_5 = val_14 - val_2.x;
            float val_6 = val_4.x - val_2.x;
            val_17 = val_3.y - val_2.y;
            float val_7 = this._bufferPoint - val_2.x;
            float val_8 = val_4.y - val_2.y;
            if(val_5 != 0f)
            {
                goto label_5;
            }
            
            val_18 = val_7 / val_6;
            if((val_18 < 0f) || (val_18 > 1f))
            {
                goto label_12;
            }
            
            val_19 = val_8 * val_18;
            goto label_8;
            label_5:
            val_8 = val_5 * val_8;
            val_17 = val_17 * val_6;
            val_4.y = val_4.y - val_2.y;
            val_4.y = val_5 * val_4.y;
            val_4.y = val_4.y - (val_17 * val_7);
            val_17 = val_8 - val_17;
            val_18 = val_4.y / val_17;
            if((val_18 < 0f) || (val_18 > 1f))
            {
                goto label_12;
            }
            
            val_19 = val_6 * val_18;
            val_17 = val_5;
            label_8:
            val_7 = val_7 - val_19;
            val_7 = val_7 / val_17;
            if((val_7 < 0f) || (val_18 < 0f))
            {
                goto label_12;
            }
            
            val_7 = val_7 + val_18;
            if(val_7 <= 1f)
            {
                goto label_13;
            }
            
            label_12:
            val_15 = 3;
            label_2:
            val_16 = val_15 - 1;
            if(val_16 < (this._planeSpaceBoundary.Count - 1))
            {
                goto label_15;
            }
            
            val_20 = 0;
            return (bool)val_20;
            label_13:
            val_20 = 1;
            return (bool)val_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GetUpVector()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.<Normal>k__BackingField, y = V11.16B, z = V12.16B}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = this.centerUp, y = V11.16B, z = V12.16B}, rhs:  new UnityEngine.Vector3() {x = this.<Normal>k__BackingField, y = V8.16B, z = V9.16B}));
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.centerUp, y = val_2.y, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateTileVertices(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlane.Tile t)
        {
            UnityEngine.Vector3 val_1 = this.ConvertToWorldSpace(planeSpaceCoords:  new UnityEngine.Vector2() {x = t.center});
            float val_19 = val_1.z;
            float val_17 = 6.97385E+07f;
            val_17 = this._config * val_17;
            val_17 = val_17 * 0.5f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  val_17, a:  new UnityEngine.Vector3() {x = this._upBasis, y = V8.16B, z = V9.16B});
            float val_20 = val_2.x;
            SupportedPlaneConfig.Vertical val_18 = this._config;
            float val_21 = val_2.y;
            val_18 = val_18 * (float)S4;
            val_18 = val_18 * 0.5f;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  val_18, a:  new UnityEngine.Vector3() {x = this._sideBasis, y = val_2.z, z = V9.16B});
            float val_4 = val_19 - val_2.z;
            float val_5 = val_1.x - val_20;
            float val_6 = val_1.y - val_21;
            float val_7 = val_5 - val_3.x;
            float val_8 = val_6 - val_3.y;
            float val_9 = val_4 - val_3.z;
            val_19 = val_19 + val_2.z;
            float val_10 = val_19 - val_3.z;
            val_20 = val_1.x + val_20;
            val_21 = val_1.y + val_21;
            float val_11 = val_20 - val_3.x;
            float val_12 = val_21 - val_3.y;
            float val_13 = val_20 + val_3.x;
            float val_14 = val_21 + val_3.y;
            float val_15 = val_19 + val_3.z;
            float val_23 = val_6;
            float val_22 = val_5;
            float val_16 = val_4 + val_3.z;
            val_22 = val_22 + val_3.x;
            val_23 = val_23 + val_3.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 IntVectorToPlaneSpace(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 vec)
        {
            SupportedPlaneConfig.Vertical val_4 = this._config;
            float val_3 = (float)vec.side;
            val_3 = val_4 * val_3;
            val_4 = val_4 * ((float)vec.side >> 32);
            this._bufferPoint = new UnityEngine.Vector2(x:  val_3, y:  val_4);
            return new UnityEngine.Vector2() {x = this._bufferPoint, y = val_4};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]> GetNewFilledTileVertices()
        {
            var val_4;
            var val_10;
            var val_11;
            this._tileVertices.Clear();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._tiles.Keys.GetEnumerator();
            label_13:
            if((1285189888 & 1) == 0)
            {
                goto label_4;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            Tile val_6 = this._tiles.Item[new IntVector2() {side = val_5, up = val_5}];
            int val_10 = val_6._tileSize;
            val_10 = val_10 * val_10;
            if(val_6.count != val_10)
            {
                goto label_13;
            }
            
            Tile val_7 = this._tiles.Item[new IntVector2() {side = val_5, up = val_5}];
            Tile val_8 = this._tiles.Item[new IntVector2() {side = val_5, up = val_5}];
            this._tileVertices.set_Item(key:  new UnityEngine.Vector2() {x = val_7.center, y = V8.16B}, value:  val_8.vertices);
            goto label_13;
            label_4:
            val_10 = 0;
            val_11 = 1;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523071906048});
            if(( & 1) != 0)
            {
                    return (System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]>)this._tileVertices;
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]>)this._tileVertices;
            }
            
            return (System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3[]>)this._tileVertices;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReprojectTileVertices()
        {
            var val_5;
            var val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._tiles.Values.GetEnumerator();
            label_4:
            if((1285405384 & 1) == 0)
            {
                goto label_3;
            }
            
            this.GenerateTileVertices(t:  0.emailUIDataHandler);
            goto label_4;
            label_3:
            val_5 = 0;
            val_6 = 1;
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523072121544});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 ConvertToWorldSpace(UnityEngine.Vector2 planeSpaceCoords)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  planeSpaceCoords.x, a:  new UnityEngine.Vector3() {x = this._sideBasis, y = V13.16B, z = V14.16B});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<Center>k__BackingField, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  planeSpaceCoords.y, a:  new UnityEngine.Vector3() {x = this._upBasis, y = val_1.y, z = val_1.x});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Update(System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            float val_6;
            float val_9;
            float val_10;
            var val_11;
            float val_6 = normal.z;
            val_6 = normal.x;
            mem[1152921523072374024] = boundary;
            this.ComputePlaneSpaceBoundary();
            float val_1 = this.UpdateCenter(newCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, newNormal:  new UnityEngine.Vector3() {x = val_6, y = normal.y, z = val_6});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            float val_3 = UnityEngine.Vector3.SignedAngle(from:  new UnityEngine.Vector3() {x = this._trueNormal, y = center.x, z = center.y}, to:  new UnityEngine.Vector3() {x = val_6, y = normal.y, z = val_6}, axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = 0f});
            mem[1152921523072374076] = val_6;
            this._trueNormal = normal;
            mem[1152921523072374072] = normal.y;
            val_6 = val_1 + this._distanceSinceChange;
            val_3 = val_3 + this._angleSinceChange;
            this._distanceSinceChange = val_6;
            this._angleSinceChange = val_3;
            val_9 = System.Math.Abs(val_6);
            if(val_9 > val_3)
            {
                goto label_5;
            }
            
            val_10 = this._angleSinceChange;
            val_9 = System.Math.Abs(val_10);
            if(val_9 <= val_3)
            {
                goto label_8;
            }
            
            label_5:
            this.<Center>k__BackingField = this._trueCenter;
            mem[1152921523072374040] = ???;
            this.<Normal>k__BackingField = this._trueNormal;
            mem[1152921523072374064] = ???;
            UnityEngine.Vector3 val_4 = this.GetUpVector();
            val_10 = val_4.x;
            val_6 = val_4.z;
            this._upBasis = val_4;
            mem[1152921523072374108] = val_4.y;
            mem[1152921523072374112] = val_6;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_10, y = val_4.y, z = val_6}, rhs:  new UnityEngine.Vector3() {x = this.<Normal>k__BackingField, y = val_1, z = center.y});
            this._sideBasis = val_5;
            mem[1152921523072374120] = val_5.y;
            mem[1152921523072374124] = val_5.z;
            this.ReprojectAllPoints();
            this.ReprojectTileVertices();
            val_11 = 1;
            this._distanceSinceChange = 0f;
            this._angleSinceChange = 0f;
            return (bool)val_11;
            label_8:
            val_11 = 0;
            return (bool)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float UpdateCenter(UnityEngine.Vector3 newCenter, UnityEngine.Vector3 newNormal)
        {
            float val_5 = newCenter.z;
            val_5 = val_5;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._trueCenter, y = V14.16B, z = V15.16B}, b:  new UnityEngine.Vector3() {x = newCenter.x, y = newCenter.y, z = val_5});
            float val_2 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = newNormal.x, y = newNormal.y, z = newNormal.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = newNormal.x, y = newNormal.y, z = newNormal.z}, d:  val_2);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._trueCenter, y = newCenter.y, z = newCenter.x}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this._trueCenter = val_4;
            mem[1152921523072490180] = val_4.y;
            mem[1152921523072490184] = val_4.z;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReprojectAllPoints()
        {
            var val_4;
            var val_12;
            var val_13;
            this.<DiscretizedPointsInSpace>k__BackingField = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, UnityEngine.Vector3>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this.<DiscretizedPointsInSpace>k__BackingField.Values.GetEnumerator();
            label_6:
            if((1285891216 & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_6 = val_4.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = this.<Center>k__BackingField, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.<Normal>k__BackingField, y = val_7.y, z = val_7.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rhs:  new UnityEngine.Vector3() {x = this.<Normal>k__BackingField, y = V11.16B, z = V12.16B}));
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.ReAddDiscretizedProjectedPoint(projectedPoint:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            goto label_6;
            label_3:
            val_12 = 0;
            val_13 = 1;
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523072607376});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReAddDiscretizedProjectedPoint(UnityEngine.Vector3 projectedPoint)
        {
            UnityEngine.Vector2 val_1 = this.ConvertToPlaneSpace(point:  new UnityEngine.Vector3() {x = projectedPoint.x, y = projectedPoint.y, z = projectedPoint.z});
            this._bufferIntPoint = this.DiscretizeVal(val:  val_1.x);
            mem[1152921523072748092] = this.DiscretizeVal(val:  val_1.y);
            float val_9 = (float)this._bufferIntPoint;
            val_9 = this._config * val_9;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = this._sideBasis, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<Center>k__BackingField, y = projectedPoint.y, z = projectedPoint.x}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            SupportedPlaneConfig.Vertical val_10 = this._config;
            val_10 = val_10 * (float)val_4.y;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_10, a:  new UnityEngine.Vector3() {x = this._upBasis, y = val_5.z, z = val_4.x});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            float val_11 = (float)this._bufferIntPoint;
            float val_12 = (float)val_7.y;
            val_11 = this._config * val_11;
            val_12 = this._config * val_12;
            this._bufferPoint = new UnityEngine.Vector2(x:  val_11, y:  val_12);
            this.<DiscretizedPointsInSpace>k__BackingField.set_Item(key:  new UnityEngine.Vector2() {x = this._bufferPoint, y = V11.16B}, value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AddDiscretizedProjectedPoint(UnityEngine.Vector3 projectedPoint)
        {
            float val_11;
            float val_12;
            var val_13;
            val_11 = projectedPoint.x;
            UnityEngine.Vector2 val_1 = this.ConvertToPlaneSpace(point:  new UnityEngine.Vector3() {x = val_11, y = projectedPoint.y, z = projectedPoint.z});
            val_12 = val_1.y;
            this._bufferIntPoint = this.DiscretizeVal(val:  val_1.x);
            mem[1152921523072877500] = this.DiscretizeVal(val:  val_12);
            if((this._discretizedPoints.Add(item:  new IntVector2() {side = this._bufferIntPoint, up = this._bufferIntPoint})) != false)
            {
                    mem[1152921523072877512] = this.AddToTiles(point:  new IntVector2() {side = this._bufferIntPoint, up = this._bufferIntPoint});
                float val_11 = (float)this._bufferIntPoint;
                val_11 = this._config * val_11;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_11, a:  new UnityEngine.Vector3() {x = this._sideBasis, y = V11.16B, z = V12.16B});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<Center>k__BackingField, y = projectedPoint.y, z = val_11}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                SupportedPlaneConfig.Vertical val_12 = this._config;
                val_12 = val_12 * (float)val_6.y;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(d:  val_12, a:  new UnityEngine.Vector3() {x = this._upBasis, y = val_7.z, z = val_6.x});
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                mem[1152921523072877520] = val_9.x;
                mem[1152921523072877524] = val_9.y;
                mem[1152921523072877528] = val_9.z;
                float val_13 = (float)this._bufferIntPoint;
                float val_14 = (float)val_9.y;
                val_13 = this._config * val_13;
                val_14 = this._config * val_14;
                this._bufferPoint = new UnityEngine.Vector2(x:  val_13, y:  val_14);
                this.recentlyAddedData = this._bufferPoint;
                mem[1152921523072877508] = val_7.x;
                this.<DiscretizedPointsInSpace>k__BackingField.set_Item(key:  new UnityEngine.Vector2() {x = this._bufferPoint, y = val_7.x}, value:  new UnityEngine.Vector3() {x = val_7.y, y = val_7.z, z = V11.16B});
                val_13 = 1;
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int DiscretizeVal(float val)
        {
            SupportedPlaneConfig.Vertical val_4 = this._config;
            val_4 = System.Math.Abs(val) / val_4;
            int val_5 = (int)val_4;
            val_4 = val_4 - (float)val_5;
            val_5 = ((val_4 > 0.5f) ? 1 : 0) + val_5;
            return (int)(val < 0) ? (-val_5) : (val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetTileVal(int val)
        {
            int val_3 = (val + 1) / W8;
            val_3 = val_3 - 1;
            return (int)((val & (-2147483648)) != 0) ? (val / W8) : (val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 KeyToCenter(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 key)
        {
            int val_1 = key.side >> 32;
            SupportedPlaneConfig.Vertical val_7 = this._config;
            float val_4 = -1f;
            val_1 = W9 * val_1;
            val_4 = (float)W9 + val_4;
            float val_5 = (float)W9 * key.side;
            val_4 = val_4 * 0.5f;
            float val_6 = (float)val_1;
            val_5 = val_4 + val_5;
            val_6 = val_4 + val_6;
            val_4 = val_7 * val_5;
            val_7 = val_7 * val_6;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  val_7);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 GetTileKey(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 point)
        {
            int val_6;
            int val_7;
            if((point.side & 2147483648) == 0)
            {
                    val_6 = point.side / W9;
            }
            else
            {
                    int val_1 = point.side + 1;
                val_1 = val_1 / W9;
                val_6 = val_1 - 1;
            }
            
            int val_2 = point.side >> 32;
            if((val_2 & 2147483648) == 0)
            {
                    val_7 = val_2 / W9;
                return new IntVector2() {side = val_6, up = val_7};
            }
            
            val_2 = val_2 + 1;
            val_7 = (val_2 / W9) - 1;
            return new IntVector2() {side = val_6, up = val_7};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlane.Tile AddToTiles(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedVerticalPlane.IntVector2 point)
        {
            int val_12;
            int val_13;
            System.Collections.Generic.Dictionary<IntVector2, Tile> val_14;
            var val_15;
            int val_16;
            bool val_8 = true;
            if((point.side & 2147483648) == 0)
            {
                    val_12 = point.side / val_8;
            }
            else
            {
                    int val_1 = point.side + 1;
                val_1 = val_1 / val_8;
                val_12 = val_1 - 1;
            }
            
            int val_2 = point.side >> 32;
            if((val_2 & 2147483648) == 0)
            {
                    val_13 = val_2 / val_8;
            }
            else
            {
                    val_2 = val_2 + 1;
                val_8 = val_2 / val_8;
                val_13 = val_8 - 1;
            }
            
            val_14 = this._tiles;
            if((val_14.ContainsKey(key:  new IntVector2() {side = val_12, up = val_13})) != true)
            {
                    SupportedPlane.Tile val_4 = null;
                val_14 = val_4;
                val_4 = new SupportedPlane.Tile(tileSize:  W24);
                UnityEngine.Vector2 val_5 = this.KeyToCenter(key:  new IntVector2() {side = val_12, up = val_13});
                .center = val_5;
                mem[1152921523073508228] = val_5.y;
                GameSparks.RT.Proto.Key val_6 = new GameSparks.RT.Proto.Key(field:  val_12, wireType:  val_13);
                .discretizedKey = val_6.<Field>k__BackingField;
                this.GenerateTileVertices(t:  val_4);
                this._tiles.set_Item(key:  new IntVector2() {side = val_12, up = val_13}, value:  val_4);
            }
            
            Tile val_7 = this._tiles.Item[new IntVector2() {side = val_12, up = val_13}];
            if(val_7 != null)
            {
                    val_15 = val_7;
                val_16 = val_7.count;
            }
            else
            {
                    val_15 = 32;
                val_16 = 64;
            }
            
            mem[32] = 65;
            return val_7;
        }
    
    }

}
