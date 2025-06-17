using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextureSideWallModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scaledFirstFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scaledTopFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scaledPreferredWallLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _centerSegments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _separateSubmesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float currentWallLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 wallDirection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 wallSegmentFirstVertex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 wallSegmentSecondVertex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 wallSegmentDirection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float wallSegmentLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.AtlasEntity _currentFacade;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Rect _currentTextureRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float finalFirstHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float finalTopHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float finalMidHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scaledFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int triIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 wallNormal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> wallTriangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float columnScaleRatio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float rightOfEdgeUv;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float currentY1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float currentY2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _wallSizeEpsilon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _narrowWallWidthDelta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _shortRowHeightDelta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _scale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _minWallLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _singleFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _currentMidHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _midUvInCurrentStep;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _singleColumnLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _leftOverColumnLength;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            List.Enumerator<T> val_1 = this._options.atlasInfo.Textures.GetEnumerator();
            label_6:
            if(((-2068448248) & 1) == 0)
            {
                goto label_4;
            }
            
            0.emailUIDataHandler.CalculateParameters();
            goto label_6;
            label_4:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519718267912});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_40;
            System.Collections.Generic.List<System.Int32> val_41;
            System.Collections.Generic.List<UnityEngine.Vector3> val_42;
            Mapbox.Unity.MeshGeneration.Data.AtlasEntity val_43;
            Mapbox.Unity.MeshGeneration.Data.AtlasEntity val_44;
            float val_45;
            Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions val_46;
            float val_47;
            float val_48;
            float val_49;
            var val_50;
            var val_51;
            float val_52;
            float val_53;
            val_40 = feature;
            val_41 = this;
            val_42 = md.Vertices;
            if(val_40 == null)
            {
                    return;
            }
            
            if(val_42.Count == 0)
            {
                    return;
            }
            
            val_42 = feature.Points;
            if(val_42.Count < 1)
            {
                    return;
            }
            
            if(tile != 0)
            {
                    this._scale = tile.TileScale;
            }
            
            this._currentFacade = this._options.atlasInfo.Textures.Item[UnityEngine.Random.Range(min:  0, max:  this._options.atlasInfo.Textures.Count)];
            this._currentTextureRect = val_7.TextureRect;
            mem[1152921519718564140] = ???;
            mem[1152921519718564148] = ???;
            val_43 = this._currentFacade;
            if(this._currentFacade != null)
            {
                goto label_19;
            }
            
            val_43 = this._currentFacade;
            if(val_43 == null)
            {
                goto label_29;
            }
            
            label_19:
            float val_39 = this._currentFacade.FloorHeight;
            val_39 = tile.TileScale * val_39;
            val_39 = val_39 / (float)this._currentFacade.MidFloorCount;
            this._singleFloorHeight = val_39;
            float val_40 = this._currentFacade.FirstFloorHeight;
            val_40 = tile.TileScale * val_40;
            this._scaledFirstFloorHeight = val_40;
            float val_41 = this._currentFacade.TopFloorHeight;
            val_41 = tile.TileScale * val_41;
            this._scaledTopFloorHeight = val_41;
            val_42 = this._currentFacade;
            val_44 = val_42;
            if(val_42 == null)
            {
                    val_44 = this._currentFacade;
            }
            
            val_45 = tile.TileScale * (float)this._currentFacade.PreferredEdgeSectionLength;
            this._scaledPreferredWallLength = val_45;
            if(val_44 == null)
            {
                goto label_27;
            }
            
            float val_42 = this._currentFacade.WallToFloorRatio;
            val_42 = val_45 * val_42;
            this._scaledFloorHeight = val_42;
            goto label_28;
            label_27:
            float val_43 = this._currentFacade.WallToFloorRatio;
            val_43 = val_45 * val_43;
            val_45 = this._scaledPreferredWallLength;
            val_44 = this._currentFacade;
            this._scaledFloorHeight = val_43;
            if(this._currentFacade == null)
            {
                goto label_29;
            }
            
            label_28:
            float val_44 = this._currentFacade.ColumnCount;
            val_44 = val_45 / val_44;
            this._singleColumnLength = val_44;
            this.QueryHeight(feature:  val_40, md:  public Mapbox.Unity.MeshGeneration.Data.AtlasEntity System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.AtlasEntity>::get_Item(int index), tile:  tile, maxHeight: out  float val_12 = -4.380293E-36f, minHeight: out  float val_13 = -4.380292E-36f);
            val_46 = this._options;
            if(this._options == null)
            {
                    val_46 = this._options;
            }
            
            float val_45 = this._options.extrusionScaleFactor;
            val_47 = this._scale;
            val_45 = 1f * val_45;
            val_48 = val_45 * val_47;
            if(val_46 == null)
            {
                    val_47 = this._scale;
            }
            
            float val_46 = this._options.extrusionScaleFactor;
            val_46 = 0f * val_46;
            val_47 = val_46 * val_47;
            val_47 = val_48 - val_47;
            this.height = val_47;
            this.GenerateRoofMesh(md:  md, minHeight:  val_47, maxHeight:  val_48);
            val_40 = this._options;
            if(this._options.extrusionGeometryType == 1)
            {
                    return;
            }
            
            val_48 = UnityEngine.Mathf.Min(a:  this.height, b:  this._scaledFirstFloorHeight);
            float val_47 = this._scaledTopFloorHeight;
            float val_48 = 0f;
            float val_16 = ((this.height - val_48) < 0) ? (val_48) : (val_47);
            this.finalFirstHeight = val_48;
            this.finalTopHeight = val_16;
            val_47 = val_16 + val_48;
            val_48 = this.height - val_47;
            this.finalMidHeight = UnityEngine.Mathf.Max(a:  0f, b:  val_48);
            this.wallTriangles = new System.Collections.Generic.List<System.Int32>();
            this.currentWallLength = 0f;
            val_50 = null;
            val_50 = null;
            this.start = Constants.Math.Vector3Zero;
            mem[1152921519718564072] = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            val_51 = 0;
            this.wallSegmentDirection = Constants.Math.Vector3Zero;
            mem[1152921519718564120] = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            goto label_40;
            label_62:
            UnityEngine.Vector3 val_20 = md.Vertices.Item[md.Edges.Item[0]];
            val_42 = md.Edges.Item[1];
            UnityEngine.Vector3 val_22 = md.Vertices.Item[val_42];
            val_49 = val_22.z;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_49}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            this.wallDirection = val_23;
            mem[1152921519718564080] = val_23.y;
            mem[1152921519718564084] = val_23.z;
            float val_24 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_49});
            this.currentWallLength = val_24;
            this._leftOverColumnLength = val_24;
            this.start = val_20;
            mem[1152921519718564068] = val_20.y;
            mem[1152921519718564072] = val_20.z;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_49}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_52 = val_25.y;
            this.wallSegmentDirection = val_25;
            mem[1152921519718564116] = val_52;
            mem[1152921519718564120] = val_25.z;
            if((this._centerSegments == false) || (this.currentWallLength <= this._singleColumnLength))
            {
                goto label_51;
            }
            
            float val_26 = this._leftOverColumnLength * 0.5f;
            this.wallSegmentFirstVertex = this.start;
            mem[1152921519718564092] = Constants.Math.Vector3Zero;
            mem[1152921519718564096] = ???;
            this.wallSegmentLength = val_26;
            val_53 = this.start;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_52, z = val_25.z}, d:  val_26);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_53, y = Constants.Math.Vector3Zero, z = ???}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            this.start = val_28;
            mem[1152921519718564068] = val_28.y;
            this.wallSegmentSecondVertex = val_28;
            mem[1152921519718564104] = val_28.y;
            float val_49 = 0.5f;
            val_49 = this._leftOverColumnLength * val_49;
            mem[1152921519718564072] = val_28.z;
            mem[1152921519718564108] = val_28.z;
            this._leftOverColumnLength = val_49;
            this.CreateWall(md:  md);
            goto label_51;
            label_58:
            this.wallSegmentFirstVertex = this.start;
            mem[1152921519718564096] = Constants.Math.Vector3Zero;
            double val_30 = System.Math.Min(val1:  (double)this._currentFacade.ColumnCount, val2:  (double)this.currentWallLength / this._singleColumnLength);
            val_49 = (float)val_30 / this._currentFacade.ColumnCount;
            val_53 = val_49 * this._scaledPreferredWallLength;
            this.wallSegmentLength = val_53;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.wallSegmentDirection, y = val_26, z = val_30}, d:  val_53);
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.start, y = val_52, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            this.start = val_32;
            mem[1152921519718564068] = val_32.y;
            this.wallSegmentSecondVertex = val_32;
            mem[1152921519718564104] = val_32.y;
            float val_33 = val_49 * this._scaledPreferredWallLength;
            val_33 = this.currentWallLength - val_33;
            mem[1152921519718564072] = val_32.z;
            mem[1152921519718564108] = val_32.z;
            this.currentWallLength = val_33;
            this.CreateWall(md:  md);
            label_51:
            val_48 = this.currentWallLength;
            if(val_48 > this._singleColumnLength)
            {
                goto label_58;
            }
            
            if(this._leftOverColumnLength > 0f)
            {
                    this.wallSegmentSecondVertex = val_22;
                mem[1152921519718564104] = val_22.y;
                this.wallSegmentFirstVertex = this.start;
                mem[1152921519718564096] = Constants.Math.Vector3Zero;
                this.wallSegmentLength = this._leftOverColumnLength;
                mem[1152921519718564108] = val_49;
                this.CreateWall(md:  md);
            }
            
            val_51 = 2;
            label_40:
            if(val_51 < md.Edges.Count)
            {
                goto label_62;
            }
            
            val_40 = md.Triangles;
            if(this._separateSubmesh != false)
            {
                    val_41 = this.wallTriangles;
                val_40.Add(item:  val_41);
                return;
            }
            
            val_42 = this.wallTriangles.Count;
            val_40.Capacity = val_42 + val_40.Count;
            val_41 = this.wallTriangles;
            md.Triangles.Item[0].AddRange(collection:  val_41);
            return;
            label_29:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateWall(Mapbox.Unity.MeshGeneration.Data.MeshData md)
        {
            float val_6;
            this.triIndex = md.Vertices.Count;
            this.columnScaleRatio = System.Math.Min(val1:  1f, val2:  this.wallSegmentLength / this._scaledPreferredWallLength);
            float val_4 = this._currentTextureRect.x;
            float val_9 = this.columnScaleRatio;
            float val_6 = val_4;
            val_6 = this.finalMidHeight;
            val_6 = val_6 * val_9;
            val_6 = val_4 + val_6;
            this.rightOfEdgeUv = val_6;
            if(val_6 <= 0f)
            {
                    val_6 = this.finalTopHeight;
            }
            
            float val_7 = this._currentFacade.ColumnCount;
            float val_8 = this._wallSizeEpsilon;
            val_7 = this._scaledPreferredWallLength / val_7;
            val_8 = val_7 * val_8;
            val_9 = S3 - val_9;
            this._minWallLength = val_8;
            this.wallNormal = -val_9;
            mem[1152921519718840016] = 0f;
            mem[1152921519718840020] = this.wallSegmentFirstVertex - this.wallSegmentSecondVertex;
            this.currentY1 = 0f;
            this.currentY2 = 0f;
            this.LeftOverRow(md:  md, leftOver:  val_6);
            this.FirstFloor(md:  md, hf:  this.height);
            this.TopFloor(md:  md, leftOver:  val_6);
            this.MidFloors(md:  md);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LeftOverRow(Mapbox.Unity.MeshGeneration.Data.MeshData md, float leftOver)
        {
            int val_30;
            float val_31;
            float val_32;
            var val_33;
            var val_34;
            float val_36;
            val_31 = leftOver;
            if(val_31 <= 0f)
            {
                    return;
            }
            
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_30 = this.currentY1;
            float val_31 = this.currentY2;
            val_30 = val_30 - val_31;
            val_31 = val_31 - val_31;
            this.currentY1 = val_30;
            this.currentY2 = val_31;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_32 = this.wallSegmentLength;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = md.UV.Item[0];
            float val_2 = this._currentTextureRect.x;
            if(val_32 < this._minWallLength)
            {
                    UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
                val_33 = 1152921517377849056;
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
                float val_5 = this._currentTextureRect.x;
                val_5 = val_5 + this._narrowWallWidthDelta;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5, y:  val_5);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                float val_8 = this._currentTextureRect.x;
                float val_32 = this._shortRowHeightDelta;
                val_32 = val_8 - val_32;
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_8, y:  val_32);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                val_34 = md.UV.Item[0];
                float val_11 = this._currentTextureRect.x;
                val_32 = this._narrowWallWidthDelta;
                float val_12 = val_11 + val_32;
                val_36 = val_11 - this._shortRowHeightDelta;
            }
            else
            {
                    UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
                val_33 = 1152921517377849056;
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  val_13.x);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
                float val_17 = this._currentTextureRect.x;
                float val_33 = this._shortRowHeightDelta;
                val_33 = val_17 - val_33;
                UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_17, y:  val_33);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
                val_34 = md.UV.Item[0];
                UnityEngine.Vector2 val_20;
                val_36 = val_18.x - this._shortRowHeightDelta;
            }
            
            val_20 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  val_36);
            val_34.Add(item:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_32, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_32, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_32, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_32, z = this._minWallLength});
            UnityEngine.Vector4 val_21 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = this.wallNormal, z = val_32});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w});
            UnityEngine.Vector4 val_22 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_21.y, z = val_21.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w});
            UnityEngine.Vector4 val_23 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_22.y, z = val_22.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w});
            UnityEngine.Vector4 val_24 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_23.y, z = val_23.z});
            val_31 = val_24.x;
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_31, y = val_24.y, z = val_24.z, w = val_24.w});
            this.wallTriangles.Add(item:  this.triIndex);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 3);
            val_30 = this.triIndex;
            this.wallTriangles.Add(item:  val_30 + 2);
            int val_34 = this.triIndex;
            val_34 = val_34 + 4;
            this.triIndex = val_34;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MidFloors(Mapbox.Unity.MeshGeneration.Data.MeshData md)
        {
            float val_2;
            UnityEngine.Rect val_38;
            float val_39;
            float val_40;
            float val_41;
            var val_42;
            Mapbox.Unity.MeshGeneration.Data.AtlasEntity val_44;
            float val_45;
            Mapbox.Unity.MeshGeneration.Data.AtlasEntity val_46;
            Mapbox.Unity.MeshGeneration.Data.AtlasEntity val_47;
            val_39 = this.finalMidHeight;
            this._currentMidHeight = val_39;
            if(val_39 < (this._singleFloorHeight + (-0.01f)))
            {
                    return;
            }
            
            val_38 = this._currentTextureRect;
            label_62:
            if(this._currentFacade == null)
            {
                    float val_38 = this._currentMidHeight;
            }
            
            val_38 = val_38 / this._singleFloorHeight;
            if(val_38 >= 0f)
            {
                goto label_5;
            }
            
            if((double)val_38 != (-0.5))
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            if((double)val_38 != 0.5)
            {
                goto label_8;
            }
            
            double val_39 = 1;
            label_7:
            val_39 = val_2 + val_39;
            var val_3 = (((long)val_2 & 1) != 0) ? (val_2) : (val_39);
            goto label_10;
            label_6:
            double val_4 = (double)val_38 + (-0.5);
            goto label_10;
            label_8:
            double val_5 = (double)val_38 + 0.5;
            label_10:
            float val_40 = (float)this._currentFacade.MidFloorCount;
            val_40 = ((float)System.Math.Min(val1:  (double)this._currentFacade.MidFloorCount, val2:  null)) / val_40;
            this._midUvInCurrentStep = val_40;
            val_2 = 0;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_42 = this._scaledFloorHeight;
            float val_41 = this._midUvInCurrentStep;
            val_40 = this.currentY1;
            val_41 = val_42 * val_41;
            val_42 = val_40 - val_41;
            val_41 = this.currentY2 - val_41;
            this.currentY1 = val_42;
            this.currentY2 = val_41;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_41 = this.wallSegmentLength;
            System.Collections.Generic.List<UnityEngine.Vector2> val_7 = md.UV.Item[0];
            float val_8 = val_38.x;
            if(val_41 >= this._minWallLength)
            {
                goto label_19;
            }
            
            val_2 = 0;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_8, y:  this._currentFacade.topOfMidUv);
            val_7.Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            float val_11 = val_38.x;
            val_11 = val_11 + this._narrowWallWidthDelta;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11, y:  this._currentFacade.topOfMidUv);
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            if(this._currentFacade == null)
            {
                    if(this._currentFacade == null)
            {
                goto label_42;
            }
            
            }
            
            float val_43 = this._currentFacade.midUvHeight;
            float val_44 = this._midUvInCurrentStep;
            val_43 = val_43 * val_44;
            val_44 = this._currentFacade.topOfMidUv - val_43;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_38.x, y:  val_44);
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_42 = md.UV.Item[0];
            float val_17 = val_38.x;
            val_41 = this._narrowWallWidthDelta;
            val_44 = this._currentFacade;
            if(this._currentFacade != null)
            {
                goto label_29;
            }
            
            val_44 = this._currentFacade;
            if(val_44 == null)
            {
                goto label_42;
            }
            
            label_29:
            float val_45 = this._currentFacade.midUvHeight;
            val_40 = this._currentFacade.topOfMidUv;
            val_17 = val_17 + val_41;
            val_45 = val_45 * this._midUvInCurrentStep;
            val_45 = val_40 - val_45;
            goto label_31;
            label_19:
            val_2 = 0;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_8, y:  this._currentFacade.topOfMidUv);
            val_7.Add(item:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  this._currentFacade.topOfMidUv);
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            val_46 = this._currentFacade;
            if(this._currentFacade != null)
            {
                goto label_37;
            }
            
            val_46 = this._currentFacade;
            if(val_46 == null)
            {
                goto label_42;
            }
            
            label_37:
            float val_46 = this._currentFacade.midUvHeight;
            float val_47 = this._midUvInCurrentStep;
            val_46 = val_46 * val_47;
            val_47 = this._currentFacade.topOfMidUv - val_46;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_38.x, y:  val_47);
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            val_42 = md.UV.Item[0];
            val_47 = this._currentFacade;
            if(this._currentFacade != null)
            {
                goto label_41;
            }
            
            val_47 = this._currentFacade;
            if(val_47 == null)
            {
                goto label_42;
            }
            
            label_41:
            float val_48 = this._currentFacade.midUvHeight;
            UnityEngine.Vector2 val_25;
            val_48 = val_48 * this._midUvInCurrentStep;
            val_45 = this._currentFacade.topOfMidUv - val_48;
            label_31:
            val_25 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  val_45);
            val_42.Add(item:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_41, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_41, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_41, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_41, z = this._minWallLength});
            UnityEngine.Vector4 val_26 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = this.wallNormal, z = val_41});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w});
            UnityEngine.Vector4 val_27 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_26.y, z = val_26.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w});
            UnityEngine.Vector4 val_28 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_27.y, z = val_27.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w});
            UnityEngine.Vector4 val_29 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_28.y, z = val_28.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
            this.wallTriangles.Add(item:  this.triIndex);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 3);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            int val_49 = this.triIndex;
            val_49 = val_49 + 4;
            this.triIndex = val_49;
            val_39 = this._currentMidHeight - (System.Math.Max(val1:  0.1f, val2:  this._scaledFloorHeight * this._midUvInCurrentStep));
            this._currentMidHeight = val_39;
            if(val_39 >= (this._singleFloorHeight + (-0.01f)))
            {
                goto label_62;
            }
            
            return;
            label_42:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TopFloor(Mapbox.Unity.MeshGeneration.Data.MeshData md, float leftOver)
        {
            float val_30;
            var val_31;
            var val_33;
            float val_31 = this.finalTopHeight;
            float val_30 = this.currentY1;
            val_30 = val_30 - val_31;
            val_31 = this.currentY2 - val_31;
            this.currentY1 = val_30;
            this.currentY2 = val_31;
            val_30 = val_30 - leftOver;
            float val_32 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_32, z = 0f});
            val_32 = val_32 - leftOver;
            float val_33 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_33, z = 0f});
            val_33 = val_33 - leftOver;
            val_33 = val_33 - this.finalTopHeight;
            float val_34 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_34, z = 0f});
            val_34 = val_34 - leftOver;
            val_34 = val_34 - this.finalTopHeight;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_30 = this.wallSegmentLength;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = md.UV.Item[0];
            float val_2 = this._currentTextureRect.x;
            if(val_30 < this._minWallLength)
            {
                    UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
                val_31 = 1152921517377849056;
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
                float val_5 = this._currentTextureRect.x;
                val_5 = val_5 + this._narrowWallWidthDelta;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5, y:  val_5);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  this._currentTextureRect.x, y:  this._currentFacade.bottomOfTopUv);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                System.Collections.Generic.List<UnityEngine.Vector2> val_10 = md.UV.Item[0];
                float val_11 = this._currentTextureRect.x;
                val_30 = this._narrowWallWidthDelta;
                val_11 = val_11 + val_30;
                UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11, y:  this._currentFacade.bottomOfTopUv);
                val_33 = public System.Void System.Collections.Generic.List<UnityEngine.Vector2>::Add(UnityEngine.Vector2 item);
            }
            else
            {
                    UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_2, y:  val_2);
                val_31 = 1152921517377849056;
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  val_13.x);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
                UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  this._currentTextureRect.x, y:  this._currentFacade.bottomOfTopUv);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
                UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  this._currentFacade.bottomOfTopUv);
                val_33 = public System.Void System.Collections.Generic.List<UnityEngine.Vector2>::Add(UnityEngine.Vector2 item);
            }
            
            md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_30, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_30, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_30, z = this._minWallLength});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = val_30, z = this._minWallLength});
            UnityEngine.Vector4 val_21 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = this.wallNormal, z = val_30});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w});
            UnityEngine.Vector4 val_22 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_21.y, z = val_21.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w});
            UnityEngine.Vector4 val_23 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_22.y, z = val_22.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w});
            UnityEngine.Vector4 val_24 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_23.y, z = val_23.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w});
            this.wallTriangles.Add(item:  this.triIndex);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 3);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            int val_35 = this.triIndex;
            val_35 = val_35 + 4;
            this.triIndex = val_35;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FirstFloor(Mapbox.Unity.MeshGeneration.Data.MeshData md, float hf)
        {
            var val_30;
            var val_31;
            float val_33;
            float val_34;
            float val_1 = S1 - hf;
            val_1 = val_1 + this.finalFirstHeight;
            float val_30 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_30, z = 0f});
            val_30 = val_30 - hf;
            val_30 = val_30 + this.finalFirstHeight;
            float val_31 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_31, z = 0f});
            val_31 = val_31 - hf;
            float val_32 = 0f;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = val_32, z = 0f});
            val_32 = val_32 - hf;
            md.Vertices.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = V9.16B, z = V10.16B});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = V9.16B, z = V10.16B});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = V9.16B, z = V10.16B});
            md.Normals.Add(item:  new UnityEngine.Vector3() {x = this.wallNormal, y = V9.16B, z = V10.16B});
            UnityEngine.Vector4 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = this.wallNormal, z = V9.16B});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_2.y, z = val_2.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_3.y, z = val_3.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            UnityEngine.Vector4 val_5 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = this.wallDirection, y = val_4.y, z = val_4.z});
            md.Tangents.Add(item:  new UnityEngine.Vector4() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
            System.Collections.Generic.List<UnityEngine.Vector2> val_6 = md.UV.Item[0];
            float val_7 = this._currentTextureRect.x;
            if(this.wallSegmentLength < this._minWallLength)
            {
                    UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7, y:  this._currentFacade.topOfBottomUv);
                val_30 = 1152921517377849056;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                float val_10 = this._currentTextureRect.x;
                val_10 = val_10 + this._narrowWallWidthDelta;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_10, y:  this._currentFacade.topOfBottomUv);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                float val_13 = this._currentTextureRect.x;
                UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13, y:  val_13);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
                val_31 = md.UV.Item[0];
                float val_16 = this._currentTextureRect.x;
                val_33 = val_16;
                val_34 = val_16;
                val_16 = val_33 + this._narrowWallWidthDelta;
            }
            else
            {
                    UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_7, y:  this._currentFacade.topOfBottomUv);
                val_30 = 1152921517377849056;
                val_6.Add(item:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
                UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  this.rightOfEdgeUv, y:  this._currentFacade.topOfBottomUv);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
                float val_21 = this._currentTextureRect.x;
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_21, y:  val_21);
                md.UV.Item[0].Add(item:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
                val_33 = this.rightOfEdgeUv;
                val_31 = md.UV.Item[0];
                val_34 = val_22.x;
                UnityEngine.Vector2 val_24;
            }
            
            val_24 = new UnityEngine.Vector2(x:  val_33, y:  val_34);
            val_31.Add(item:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            this.wallTriangles.Add(item:  this.triIndex);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            this.wallTriangles.Add(item:  this.triIndex + 1);
            this.wallTriangles.Add(item:  this.triIndex + 3);
            this.wallTriangles.Add(item:  this.triIndex + 2);
            int val_33 = this.triIndex;
            val_33 = val_33 + 4;
            this.triIndex = val_33;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateEdgeList(Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, float preferredEdgeSectionLength)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateRoofMesh(Mapbox.Unity.MeshGeneration.Data.MeshData md, float minHeight, float maxHeight)
        {
            if(this._options.extrusionGeometryType == 2)
            {
                    return;
            }
            
            this._counter = md.Vertices.Count;
            Mapbox.Unity.Map.ExtrusionType val_22 = this._options.extrusionType;
            val_22 = val_22 - 1;
            if(val_22 > 4)
            {
                    return;
            }
            
            var val_23 = 52956632 + ((this._options.extrusionType - 1)) << 2;
            val_23 = val_23 + 52956632;
            goto (52956632 + ((this._options.extrusionType - 1)) << 2 + 52956632);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void QueryHeight(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, out float maxHeight, out float minHeight)
        {
            Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions val_17;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_18;
            Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions val_19;
            var val_20;
            Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions val_21;
            Mapbox.Unity.Map.GeometryExtrusionWithAtlasOptions val_22;
            float val_23;
            val_17 = 1152921519721281824;
            val_18 = 1152921519721277776;
            minHeight = 0f;
            maxHeight = 0f;
            val_19 = this._options;
            if((this._options.extrusionType - 1) >= 3)
            {
                goto label_2;
            }
            
            val_19 = feature.Properties;
            val_20 = 1152921515845838592;
            if((val_19.ContainsKey(key:  this._options.propertyName)) == false)
            {
                    return;
            }
            
            val_19 = 1152921504617549824;
            maxHeight = System.Convert.ToSingle(value:  feature.Properties.Item[this._options.propertyName]);
            val_18 = feature.Properties;
            if((val_18.ContainsKey(key:  "min_height")) == false)
            {
                    return;
            }
            
            float val_7 = System.Convert.ToSingle(value:  feature.Properties.Item["min_height"]);
            goto label_16;
            label_2:
            if(this._options.extrusionType != 4)
            {
                    if(this._options.extrusionType != 5)
            {
                    return;
            }
            
                val_17 = this._options;
                maxHeight = this._options.maximumHeight;
                return;
            }
            
            val_19 = feature.Properties;
            val_20 = 1152921515845838592;
            if((val_19.ContainsKey(key:  this._options.propertyName)) == false)
            {
                    return;
            }
            
            val_21 = this._options;
            if(this._options != null)
            {
                goto label_25;
            }
            
            val_21 = this._options;
            if(val_21 == null)
            {
                goto label_26;
            }
            
            label_25:
            if(this._options.minimumHeight <= this._options.maximumHeight)
            {
                goto label_27;
            }
            
            UnityEngine.Debug.LogError(message:  "Maximum Height less than Minimum Height.Swapping values for extrusion.");
            val_22 = this._options;
            if(this._options != null)
            {
                goto label_30;
            }
            
            val_22 = this._options;
            if(val_22 == null)
            {
                goto label_31;
            }
            
            label_30:
            this._options.minimumHeight = this._options.maximumHeight;
            this._options.maximumHeight = this._options.minimumHeight;
            label_27:
            val_19 = 1152921504621436928;
            val_23 = System.Math.Max(val1:  this._options.minimumHeight, val2:  System.Convert.ToSingle(value:  feature.Properties.Item[this._options.propertyName]));
            maxHeight = System.Math.Min(val1:  val_23, val2:  this._options.maximumHeight);
            val_18 = feature.Properties;
            if((val_18.ContainsKey(key:  "min_height")) == false)
            {
                    return;
            }
            
            val_23 = System.Convert.ToSingle(value:  feature.Properties.Item["min_height"]);
            label_16:
            minHeight = System.Math.Min(val1:  val_23, val2:  this._options.maximumHeight);
            return;
            label_31:
            label_26:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextureSideWallModifier()
        {
            var val_2;
            this._centerSegments = true;
            this._separateSubmesh = true;
            val_2 = null;
            val_2 = null;
            this.start = Constants.Math.Vector3Zero;
            mem[1152921519721492904] = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            this._wallSizeEpsilon = 0.99f;
            this._narrowWallWidthDelta = 7.714148E-41f;
            this._shortRowHeightDelta = 0.015f;
            this._scale = 1f;
            this.wallDirection = Constants.Math.Vector3Zero;
            mem[1152921519721492916] = Constants.Math.Vector3Zero.__il2cppRuntimeField_8;
            mem[1152921519721492872] = 1;
            this = new UnityEngine.ScriptableObject();
        }
    
    }

}
