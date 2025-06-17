using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VerticalBoundedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Normal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Boundary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Center;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> _planeSpaceBoundary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _upBasis;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _sideBasis;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 MinCoord;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 MaxCoord;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _bufferPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector3 centerUp;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VerticalBoundedPlane(UnityEngine.Vector3 normal, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            this._planeSpaceBoundary = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this.centerUp = 0;
            mem[1152921523040943968] = 0;
            this.Normal = normal;
            mem[1152921523040943860] = normal.y;
            mem[1152921523040943864] = normal.z;
            this.Boundary = boundary;
            this.Center = center;
            mem[1152921523040943884] = center.y;
            mem[1152921523040943888] = center.z;
            UnityEngine.Vector3 val_2 = this.GetUpVector();
            this._upBasis = val_2;
            mem[1152921523040943908] = val_2.y;
            mem[1152921523040943912] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            this._sideBasis = val_3;
            mem[1152921523040943920] = val_3.y;
            mem[1152921523040943924] = val_3.z;
            this.ComputePlaneSpaceBoundary();
            this.ComputeMinMaxCoords();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(UnityEngine.Vector3 normal, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            this.Normal = normal;
            mem[1152921523041068148] = normal.y;
            mem[1152921523041068152] = normal.z;
            this.Boundary = boundary;
            this.Center = center;
            mem[1152921523041068172] = center.y;
            mem[1152921523041068176] = center.z;
            UnityEngine.Vector3 val_1 = this.GetUpVector();
            this._upBasis = val_1;
            mem[1152921523041068196] = val_1.y;
            mem[1152921523041068200] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            this._sideBasis = val_2;
            mem[1152921523041068208] = val_2.y;
            mem[1152921523041068212] = val_2.z;
            this.ComputePlaneSpaceBoundary();
            this.ComputeMinMaxCoords();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ComputeMinMaxCoords()
        {
            goto label_1;
            label_10:
            UnityEngine.Vector3 val_1 = this.Boundary.Item[0];
            if(val_1.x < 0)
            {
                    mem2[0] = val_1.x;
            }
            
            if(val_1.x > this.MaxCoord.x)
            {
                    mem2[0] = val_1.x;
            }
            
            if(val_1.y < 0)
            {
                    mem[1152921523041192508] = val_1.y;
            }
            
            if(val_1.y > val_1.x)
            {
                    mem[1152921523041192520] = val_1.y;
            }
            
            if(val_1.z < 0)
            {
                    mem[1152921523041192512] = val_1.z;
            }
            
            if(val_1.z > val_1.x)
            {
                    mem[1152921523041192524] = val_1.z;
            }
            
            0 = 1;
            label_1:
            if(0 < this.Boundary.Count)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ComputePlaneSpaceBoundary()
        {
            var val_4;
            this._planeSpaceBoundary.Clear();
            val_4 = 0;
            goto label_2;
            label_6:
            UnityEngine.Vector3 val_1 = this.Boundary.Item[0];
            UnityEngine.Vector2 val_2 = this.ConvertToPlaneSpace(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this._planeSpaceBoundary.Add(item:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_4 = 1;
            label_2:
            if(val_4 < this.Boundary.Count)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 ConvertToPlaneSpace(UnityEngine.Vector3 point)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = this.Center, y = V11.16B, z = V12.16B});
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
            mem[1152921523041585876] = val_1.y;
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
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.Normal, y = V11.16B, z = V12.16B}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = this.centerUp, y = V11.16B, z = V12.16B}, rhs:  new UnityEngine.Vector3() {x = this.Normal, y = V8.16B, z = V9.16B}));
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.centerUp, y = val_2.y, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
    
    }

}
