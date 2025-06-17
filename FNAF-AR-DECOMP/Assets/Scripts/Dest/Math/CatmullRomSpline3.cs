using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CatmullRomSpline3 : SplineBase
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Dest.Math.SplineTypes SplineType { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Dest.Math.SplineTypes get_SplineType()
        {
            return (Dest.Math.SplineTypes)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_SplineType(Dest.Math.SplineTypes value)
        {
            if(true == value)
            {
                    return;
            }
            
            mem[1152921519501578904] = value;
            mem[1152921519501578908] = 1;
            this.UpdateAdjacentSegments(vertexIndex:  0);
            this.UpdateAdjacentSegments(vertexIndex:  value.Count - 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Dest.Math.CatmullRomSpline3 Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "CatmullRomSpline3");
            if(val_1 != null)
            {
                    return val_1.AddComponent<Dest.Math.CatmullRomSpline3>();
            }
            
            return val_1.AddComponent<Dest.Math.CatmullRomSpline3>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Dest.Math.CatmullRomSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
        {
            var val_11;
            Dest.Math.CatmullRomSpline3 val_2 = new UnityEngine.GameObject(name:  "CatmullRomSpline3").AddComponent<Dest.Math.CatmullRomSpline3>();
            mem2[0] = type;
            var val_14 = 0;
            val_14 = val_14 + 1;
            mem2[0] = new System.Collections.Generic.List<ItemData>(capacity:  points.Count);
            val_11 = 0;
            goto label_9;
            label_23:
            var val_15 = 0;
            val_15 = val_15 + 1;
            T val_8 = points.Item[0];
            .Position = V0.16B;
            mem[1152921519501895492] = V1.16B;
            mem[1152921519501895496] = V2.16B;
            X23.Add(item:  new SplineBase.ItemData());
            val_11 = 1;
            label_9:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_11 < points.Count)
            {
                goto label_23;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(points.Count >= 2)
            {
                    int val_13 = val_2.SegmentCount;
                if(val_13 >= 1)
            {
                    do
            {
                val_2.UpdateSegment(index:  0);
                val_11 = 0 + 1;
            }
            while(val_13 != val_11);
            
            }
            
            }
            
            mem2[0] = 1;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSegment(int index)
        {
            var val_36;
            var val_37;
            var val_38;
            int val_39;
            UnityEngine.Vector3 val_41;
            UnityEngine.Vector3 val_43;
            UnityEngine.Vector3 val_44;
            UnityEngine.Vector3 val_45;
            float val_46;
            var val_49;
            int val_50;
            int val_33 = this.SegmentCount;
            val_36 = Count;
            val_37 = X23.Item[index];
            val_33 = val_33 - 1;
            if((public System.Int32 System.Collections.Generic.List<ItemData>::get_Count()) == 0)
            {
                goto label_4;
            }
            
            if(val_37 == null)
            {
                goto label_5;
            }
            
            if(index == 0)
            {
                goto label_6;
            }
            
            label_15:
            val_38 = public ItemData System.Collections.Generic.List<ItemData>::get_Item(int index);
            val_39 = index - 1;
            goto label_7;
            label_4:
            val_36 = val_36.Item[index + 1];
            val_41 = val_5.Position;
            val_44 = val_3.Position;
            val_43 = val_3.Position;
            val_45 = val_3.Position;
            if(index != 0)
            {
                    val_36 = val_36.Item[index - 1];
                val_44 = val_7.Position;
            }
            
            if(val_33 != index)
            {
                goto label_13;
            }
            
            val_46 = V10.16B;
            goto label_14;
            label_5:
            if(index != 0)
            {
                goto label_15;
            }
            
            label_6:
            val_38 = public ItemData System.Collections.Generic.List<ItemData>::get_Item(int index);
            val_39 = val_33;
            label_7:
            ItemData val_8 = val_37.Item[val_39];
            val_44 = val_8.Position;
            int val_9 = index + 1;
            val_37 = val_37.Item[val_9 - ((val_9 / val_36) * val_36)];
            val_41 = val_12.Position;
            val_49 = public ItemData System.Collections.Generic.List<ItemData>::get_Item(int index);
            int val_13 = index + 2;
            val_50 = val_13 - ((val_13 / val_36) * val_36);
            goto label_20;
            label_13:
            val_49 = public ItemData System.Collections.Generic.List<ItemData>::get_Item(int index);
            val_50 = index + 2;
            label_20:
            if(val_36.Item[val_50] == null)
            {
                goto label_22;
            }
            
            val_46 = V10.16B;
            label_14:
            ItemData val_16 = this.Item[index];
            val_16.A = val_3.Position;
            mem2[0] = val_3.Position;
            mem2[0] = val_3.Position;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_44, y = val_43, z = val_45});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_41, y = val_46, z = ???});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_16.B = val_19;
            mem2[0] = val_19.y;
            mem2[0] = val_19.z;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(d:  2.5f, a:  new UnityEngine.Vector3() {x = val_3.Position, y = val_3.Position, z = val_3.Position});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44, y = val_43, z = val_45}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = val_41, y = val_46, z = ???});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_15.Position, y = ???, z = ???});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_16.C = val_25;
            mem2[0] = val_25.y;
            mem2[0] = val_25.z;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_44, y = val_43, z = val_45});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_3.Position, y = val_3.Position, z = val_3.Position});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_41, y = val_46, z = ???});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_15.Position, y = ???, z = ???});
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            val_16.D = val_32;
            mem2[0] = val_32.y;
            mem2[0] = val_32.z;
            return;
            label_22:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAdjacentSegments(int vertexIndex)
        {
            int val_12;
            var val_13;
            int val_10 = vertexIndex;
            int val_1 = Count;
            if(val_1 < 2)
            {
                    return;
            }
            
            int val_2 = val_10 - 2;
            int val_3 = val_10 - 1;
            val_12 = val_10 + 1;
            if((public System.Int32 System.Collections.Generic.List<ItemData>::get_Count()) != 0)
            {
                    val_3 = ((val_3 >= 0) ? 0 : (val_1)) + val_3;
                val_10 = ((val_10 >= 0) ? 0 : (val_1)) + val_10;
                val_13 = val_12 - ((val_12 < val_1) ? 0 : (val_1));
                this.UpdateSegment(index:  ((val_2 >= 0) ? 0 : (val_1)) + val_2);
                this.UpdateSegment(index:  val_3);
                this.UpdateSegment(index:  val_10);
            }
            else
            {
                    int val_9 = this.SegmentCount;
                if((val_2 & 2147483648) == 0)
            {
                    this.UpdateSegment(index:  val_2);
            }
            
                if((val_3 & 2147483648) == 0)
            {
                    this.UpdateSegment(index:  val_3);
            }
            
                if(((val_10 & 2147483648) == 0) && (val_9 > val_10))
            {
                    this.UpdateSegment(index:  val_10);
            }
            
                if(val_12 >= val_9)
            {
                    return;
            }
            
            }
            
            this.UpdateSegment(index:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddVertexFirst(UnityEngine.Vector3 position)
        {
            goto typeof(Dest.Math.CatmullRomSpline3).__il2cppRuntimeField_1C8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddVertexLast(UnityEngine.Vector3 position)
        {
            SplineBase.ItemData val_1 = new SplineBase.ItemData();
            .Position = position;
            mem[1152921519502410100] = position.y;
            mem[1152921519502410104] = position.z;
            X21.Add(item:  val_1);
            this.UpdateAdjacentSegments(vertexIndex:  val_1.Count - 1);
            mem[1152921519502378124] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RemoveVertex(int index)
        {
            RemoveAt(index:  index);
            this.UpdateAdjacentSegments(vertexIndex:  index - 1);
            mem[1152921519502495244] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Clear()
        {
            Clear();
            mem[1152921519502608268] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void InsertBefore(int vertexIndex, UnityEngine.Vector3 position)
        {
            .Position = position;
            mem[1152921519502757364] = position.y;
            mem[1152921519502757368] = position.z;
            X22.Insert(index:  vertexIndex, item:  new SplineBase.ItemData());
            this.UpdateAdjacentSegments(vertexIndex:  vertexIndex);
            mem[1152921519502725388] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void InsertAfter(int vertexIndex, UnityEngine.Vector3 position)
        {
            int val_2 = vertexIndex;
            .Position = position;
            mem[1152921519502877556] = position.y;
            mem[1152921519502877560] = position.z;
            val_2 = val_2 + 1;
            X22.Insert(index:  val_2, item:  new SplineBase.ItemData());
            this.UpdateAdjacentSegments(vertexIndex:  val_2);
            mem[1152921519502845580] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override UnityEngine.Vector3 GetVertex(int vertexIndex)
        {
            if(this.Item[vertexIndex] != null)
            {
                    return new UnityEngine.Vector3() {x = val_1.Position};
            }
            
            return new UnityEngine.Vector3() {x = val_1.Position};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetVertex(int vertexIndex, UnityEngine.Vector3 position)
        {
            ItemData val_1 = Item[vertexIndex];
            val_1.Position = position;
            mem2[0] = position.y;
            mem2[0] = position.z;
            this.UpdateAdjacentSegments(vertexIndex:  vertexIndex);
            mem[1152921519503085964] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CatmullRomSpline3()
        {
        
        }
    
    }

}
