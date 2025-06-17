using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UvModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.UVModifierOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _mdVertexCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _vert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> _uv;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.AtlasEntity _currentFacade;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Quaternion _textureDirection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[] _textureUvCoordinates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _vertexRelativePos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _firstVert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float miny;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float maxy;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType get_Type()
        {
            return 0;
        }
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
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.Map.UVModifierOptions val_37;
            System.Collections.Generic.List<UnityEngine.Vector2> val_38;
            System.Collections.Generic.List<UnityEngine.Vector3> val_39;
            float val_40;
            float val_41;
            var val_42;
            UnityEngine.Vector2[] val_43;
            float val_44;
            int val_46;
            UnityEngine.Quaternion val_47;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            var val_53;
            val_37 = tile;
            val_38 = this;
            val_39 = md.Vertices;
            if(feature == null)
            {
                    return;
            }
            
            if(val_39.Count == 0)
            {
                    return;
            }
            
            if(feature.Points.Count < 1)
            {
                    return;
            }
            
            this._uv.Clear();
            this._mdVertexCount = md.Vertices.Count;
            this._size = 1152921517377854176;
            mem[1152921519714405992] = ???;
            if(this._options.texturingType != 2)
            {
                    if(this._options.texturingType != 3)
            {
                goto label_12;
            }
            
            }
            
            if(this._options.texturingType == 2)
            {
                goto label_14;
            }
            
            val_37 = this._options;
            if(this._options.texturingType != 3)
            {
                goto label_60;
            }
            
            label_14:
            this._currentFacade = this._options.atlasInfo.Roofs.Item[UnityEngine.Random.Range(min:  0, max:  this._options.atlasInfo.Roofs.Count)];
            this.minx = ;
            this.miny = ;
            this.maxx = -3.402823E+38f;
            this.maxy = -3.402823E+38f;
            this._textureUvCoordinates = new UnityEngine.Vector2[0];
            val_39 = 1152921518725068768;
            UnityEngine.Vector3 val_8 = md.Vertices.Item[0];
            UnityEngine.Vector3 val_9 = md.Vertices.Item[1];
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_40 = val_10.x;
            val_41 = val_10.z;
            val_42 = null;
            val_42 = null;
            val_43 = 1152921504840925184;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_40, y = val_10.y, z = val_41}, toDirection:  new UnityEngine.Vector3() {x = Constants.Math.Vector3Right, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_40, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_44});
            this._textureDirection = val_11;
            mem[1152921519714406036] = val_11.y;
            mem[1152921519714406040] = val_11.z;
            mem[1152921519714406044] = val_11.w;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this._textureUvCoordinates[0] = val_12.x;
            this._textureUvCoordinates[0] = val_12.y;
            val_37 = md.Vertices;
            UnityEngine.Vector3 val_13 = val_37.Item[0];
            val_46 = this._mdVertexCount;
            this._firstVert = val_13;
            mem[1152921519714406072] = val_13.y;
            mem[1152921519714406076] = val_13.z;
            if(val_46 > 1)
            {
                    do
            {
                UnityEngine.Vector3 val_14 = md.Vertices.Item[1];
                this._vert = val_14;
                mem[1152921519714406004] = val_14.y;
                mem[1152921519714406008] = val_14.z;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this._firstVert, y = Constants.Math.Vector3Zero.__il2cppRuntimeField_40, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_44});
                val_40 = val_15.x;
                val_41 = val_15.z;
                this._vertexRelativePos = val_15;
                mem[1152921519714406060] = val_15.y;
                mem[1152921519714406064] = val_41;
                val_47 = this._textureDirection;
                UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_47, y = this._firstVert, z = Constants.Math.Vector3Zero.__il2cppRuntimeField_44, w = Constants.Math.Vector3Zero.__il2cppRuntimeField_40}, point:  new UnityEngine.Vector3() {x = val_40, y = val_15.y, z = val_41});
                this._vertexRelativePos = val_16;
                mem[1152921519714406060] = val_16.y;
                mem[1152921519714406064] = val_16.z;
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_16.x, y:  val_16.z);
                this._textureUvCoordinates[1] = val_17.x;
                this._textureUvCoordinates[1] = val_17.y;
                val_48 = this.minx;
                if(this._vertexRelativePos < 0)
            {
                    val_48 = this._vertexRelativePos;
                this.minx = this._vertexRelativePos;
            }
            
                val_49 = this.maxx;
                if(this._vertexRelativePos > val_49)
            {
                    val_49 = this._vertexRelativePos;
                this.maxx = this._vertexRelativePos;
            }
            
                val_50 = this.miny;
                if(val_40 < 0)
            {
                    val_50 = val_40;
                this.miny = val_40;
            }
            
                val_51 = this.maxy;
                if(val_40 > val_51)
            {
                    val_51 = val_40;
                this.maxy = val_40;
            }
            
                val_46 = this._mdVertexCount;
                val_37 = 1 + 1;
            }
            while(val_37 < val_46);
            
            }
            else
            {
                    val_49 = this.maxx;
                val_51 = this.maxy;
                val_48 = this.minx;
                val_50 = this.miny;
            }
            
            if(val_46 < 1)
            {
                goto label_60;
            }
            
            val_48 = val_49 - val_48;
            val_39 = 1152921517377849056;
            var val_38 = 0;
            val_44 = val_51 - val_50;
            do
            {
                val_37 = this._uv;
                val_47 = this.minx;
                val_40 = val_48;
                float val_18 = this._currentFacade.TextureRect.x;
                val_43 = this._textureUvCoordinates;
                val_41 = val_18;
                float val_19 = this._textureUvCoordinates[0] - val_47;
                float val_20 = val_43[0] - this.miny;
                val_20 = val_20 / val_44;
                val_19 = val_19 / val_48;
                val_19 = val_19 * val_40;
                UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  val_19 + val_18, y:  (val_20 * val_41) + val_18);
                val_37.Add(item:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
                val_38 = val_38 + 1;
            }
            while(val_38 < this._mdVertexCount);
            
            goto label_60;
            label_12:
            if(this._mdVertexCount < 1)
            {
                goto label_60;
            }
            
            val_43 = 1152921517377849056;
            var val_40 = 0;
            val_41 = 0.5;
            label_71:
            UnityEngine.Vector3 val_25 = md.Vertices.Item[0];
            this._vert = val_25;
            mem[1152921519714406004] = val_25.y;
            mem[1152921519714406008] = val_25.z;
            if(this._options.style != 6)
            {
                goto label_63;
            }
            
            val_44 = this._size;
            float val_27 = val_37.TileScale;
            Mapbox.Utils.Vector2d val_39 = this._size;
            float val_28 = this._vert + md.PositionInTile;
            val_28 = val_28 / val_37.TileScale;
            val_27 = (S13 + S14) / val_27;
            double val_31 = (val_44 * val_41) + (double)val_28;
            double val_32 = val_39 * val_41;
            val_32 = val_32 + (double)val_27;
            val_31 = val_31 / val_44;
            val_39 = val_32 / val_39;
            UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  (float)val_31, y:  (float)val_39);
            val_39 = this._uv;
            val_40 = val_33.x;
            val_53 = public System.Void System.Collections.Generic.List<UnityEngine.Vector2>::Add(UnityEngine.Vector2 item);
            goto label_67;
            label_63:
            val_39 = this._options;
            if(this._options.texturingType != 0)
            {
                goto label_69;
            }
            
            val_39 = this._uv;
            UnityEngine.Vector2 val_34 = new UnityEngine.Vector2(x:  this._vert, y:  val_25.y);
            val_53 = public System.Void System.Collections.Generic.List<UnityEngine.Vector2>::Add(UnityEngine.Vector2 item);
            label_67:
            val_39.Add(item:  new UnityEngine.Vector2() {x = val_34.x, y = val_34.y});
            label_69:
            val_40 = val_40 + 1;
            if(val_40 < this._mdVertexCount)
            {
                goto label_71;
            }
            
            label_60:
            val_38 = this._uv;
            md.UV.Item[0].AddRange(collection:  val_38);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UvModifier()
        {
            this._uv = new System.Collections.Generic.List<UnityEngine.Vector2>();
        }
    
    }

}
