using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CubicSpline3 : SplineBase
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
            if(W8 == value)
            {
                    return;
            }
            
            mem[1152921519503430152] = value;
            mem[1152921519503430156] = 1;
            this.BuildSpline();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Dest.Math.CubicSpline3 Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "CubicSpline3");
            if(val_1 != null)
            {
                    return val_1.AddComponent<Dest.Math.CubicSpline3>();
            }
            
            return val_1.AddComponent<Dest.Math.CubicSpline3>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Dest.Math.CubicSpline3 Create(System.Collections.Generic.IList<UnityEngine.Vector3> points, Dest.Math.SplineTypes type)
        {
            var val_10;
            Dest.Math.CubicSpline3 val_2 = new UnityEngine.GameObject(name:  "CubicSpline3").AddComponent<Dest.Math.CubicSpline3>();
            mem2[0] = type;
            var val_13 = 0;
            val_13 = val_13 + 1;
            mem2[0] = new System.Collections.Generic.List<ItemData>(capacity:  points.Count);
            val_10 = 0;
            goto label_9;
            label_23:
            var val_14 = 0;
            val_14 = val_14 + 1;
            T val_8 = points.Item[0];
            .Position = V0.16B;
            mem[1152921519503744676] = V1.16B;
            mem[1152921519503744680] = V2.16B;
            X23.Add(item:  new SplineBase.ItemData());
            val_10 = 1;
            label_9:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_10 < points.Count)
            {
                goto label_23;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(points.Count >= 2)
            {
                    val_2.BuildSpline();
            }
            
            mem2[0] = 1;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildSpline()
        {
            if(Count < 2)
            {
                    return;
            }
            
            if(1152921519501553840 != 1)
            {
                    if((public System.Int32 System.Collections.Generic.List<ItemData>::get_Count()) != 0)
            {
                    return;
            }
            
                this.CreateOpenedSpline();
                return;
            }
            
            this.CreateClosedSpline();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateOpenedSpline()
        {
            float val_40;
            float val_44;
            int val_45;
            UnityEngine.Vector3 val_46;
            int val_47;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            var val_52;
            var val_53;
            int val_1 = Count;
            float[] val_2 = new float[0];
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[0];
            val_2[0] = 0.5f;
            ItemData val_4 = X23.Item[1];
            ItemData val_5 = X24.Item[0];
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.Position, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_5.Position, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_2[0]);
            val_44 = val_8.x;
            int val_9 = val_1 - 1;
            val_3[0] = val_8;
            val_3[0] = val_8.y;
            val_3[1] = val_8.z;
            if(val_9 >= 2)
            {
                    var val_43 = 0;
                do
            {
                val_45 = val_2.Length;
                var val_11 = val_43 + 1;
                if(val_43 >= val_45)
            {
                    val_45 = val_2.Length;
            }
            
                mem2[0] = 1f / (4f - null);
                ItemData val_15 = val_1.Item[val_43 + 2];
                val_46 = val_16.Position;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.Position, y = val_8.y, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_46, y = V12.16B, z = val_5.Position});
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = 4.372641E+10f, z = 4.372641E+10f});
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  1.139911E+09f);
                val_44 = val_20.x;
                val_40 = val_20.z;
                val_43 = val_43 + 1;
                mem2[0] = val_44;
                mem2[0] = val_20.y;
                mem2[0] = val_40;
            }
            while((val_9 - 1) != val_43);
            
            }
            
            int val_44 = val_1;
            val_47 = val_2.Length;
            val_44 = val_44 - 2;
            int val_50 = (long)val_44;
            if(val_44 >= val_47)
            {
                    val_47 = val_2.Length;
            }
            
            float val_45 = val_2[val_50];
            val_45 = 2f - val_45;
            var val_47 = (long)val_9;
            val_2[val_47] = 1f / val_45;
            ItemData val_22 = val_43.Item[val_9];
            ItemData val_23 = X26.Item[0].Item[val_50];
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.Position, y = val_44, z = val_20.y}, b:  new UnityEngine.Vector3() {x = val_23.Position, y = val_40, z = V12.16B});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            var val_46 = 12;
            val_46 = val_3 + (val_50 * val_46);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * 12) + val_3 + 32, y = ((long)(int)((val_1 - 2)) * 12) + val_3 + 32 + 4, z = ((long)(int)((val_1 - 2)) * 12) + val_3 + 40});
            val_49 = val_26.x;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49, y = val_26.y, z = val_26.z}, d:  val_2[(long)(int)((val_1 - 1))] + 32);
            val_50 = val_27.y;
            val_51 = val_27.z;
            val_47 = val_3 + (val_47 * 12);
            mem2[0] = val_27.x;
            val_52 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32;
            mem2[0] = val_50;
            mem2[0] = val_51;
            if(val_9 >= val_3.Length)
            {
                    val_50 = mem[((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 4];
                val_50 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 4;
                val_51 = mem[((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 8];
                val_51 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 8;
            }
            
            val_53 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 4.Item[val_9];
            if(val_53 == null)
            {
                goto label_39;
            }
            
            if((val_50 & 2147483648) == 0)
            {
                goto label_40;
            }
            
            return;
            label_39:
            if((val_50 & 2147483648) != 0)
            {
                    return;
            }
            
            label_40:
            var val_48 = 12;
            val_48 = val_3 + (val_50 * val_48);
            float val_29 = val_48 + 40;
            do
            {
                val_53 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 4.Item[val_50];
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.Position, y = V12.16B, z = val_23.Position}, b:  new UnityEngine.Vector3() {x = val_30.Position, y = val_46, z = 1f});
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(d:  val_2[val_50], a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32, y = val_50, z = val_51});
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((long)(int)((val_1 - 2)) * 12) + val_3 + 40) + -8, y = (((long)(int)((val_1 - 2)) * 12) + val_3 + 40) + -8 + 4, z = val_29}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
                val_48 = val_33.x;
                val_46 = val_33.z;
                ItemData val_34 = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32 + 4.Item[val_50];
                val_30.B = val_33;
                mem2[0] = val_33.y;
                mem2[0] = val_46;
                val_30.A = val_34.Position;
                mem2[0] = val_9;
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = val_48, y = val_33.y, z = val_46});
                UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
                val_49 = val_50;
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32, y = val_49, z = val_51});
                val_30.C = val_38;
                mem2[0] = val_38.y;
                mem2[0] = val_38.z;
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(d:  -2f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_48, y = val_33.y, z = val_46});
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_3 + 32, y = val_49, z = val_51});
                val_50 = val_50 - 1;
                val_52 = val_29 - 12;
                val_51 = val_46;
                val_30.D = val_41;
                mem2[0] = val_41.y;
                mem2[0] = val_41.z;
            }
            while((val_50 & 2147483648) == 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateClosedSpline()
        {
            UnityEngine.Vector3[] val_68;
            int val_69;
            float val_73;
            float val_74;
            var val_75;
            float val_76;
            float val_77;
            float val_78;
            float val_79;
            UnityEngine.Vector3[] val_80;
            int val_81;
            float val_82;
            float val_86;
            Dest.Math.CubicSpline3 val_87;
            var val_88;
            int val_1 = Count;
            float[] val_2 = new float[0];
            float[] val_3 = new float[0];
            val_68 = new UnityEngine.Vector3[0];
            UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[0];
            val_3[1] = 0.25f;
            val_2[1] = 0.25f;
            int val_6 = val_1 - 1;
            ItemData val_7 = X22.Item[1];
            ItemData val_8 = mem[1152921519504200288].Item[val_6];
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.Position, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_8.Position, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  0.75f, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_68[0] = val_10;
            val_68[0] = val_10.y;
            val_68[1] = val_10.z;
            ItemData val_11 = mem[1152921519504200288].Item[0];
            val_69 = val_1 - 2;
            ItemData val_12 = mem[1152921519504200288].Item[val_69];
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.Position, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.Position, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            if(val_6 >= 2)
            {
                    do
            {
                float val_16 = 1f / (4f - null);
                mem2[0] = val_16;
                float val_17 = -(val_16 * null);
                mem2[0] = val_17;
                ItemData val_18 = mem[1152921519504200288].Item[2];
                ItemData val_19 = mem[1152921519504200288].Item[0];
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.Position, y = 4f, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_19.Position, y = val_17, z = val_10.y});
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                val_68 = val_68;
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = val_20.y, z = val_20.z});
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(d:  val_16, a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                mem2[0] = val_23.x;
                mem2[0] = val_23.y;
                mem2[0] = val_23.z;
                var val_64 = 0;
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  1f, a:  new UnityEngine.Vector3() {x = 4.372641E+10f, y = val_23.z, z = val_22.z});
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                val_64 = val_64 + 1;
                val_64 = val_64 + 1;
                val_73 = 4f - (1f * null);
                val_74 = -(1f * val_26.x);
            }
            while(val_64 != val_6);
            
            }
            else
            {
                    val_74 = 1f;
                val_73 = 4f;
            }
            
            float val_65 = val_3[(long)val_6];
            float val_67 = 1f;
            val_75 = val_68 + ((long)val_69 * 12);
            val_67 = val_74 + val_67;
            val_65 = val_65 + val_2[(long)val_6];
            val_76 = mem[((long)(int)((val_1 - 2)) * 12) + val_4 + 32 + 4];
            val_76 = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32 + 4;
            val_74 = val_67 * val_65;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(d:  val_67, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32, y = val_76, z = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32 + 8});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_77 = val_28.x;
            val_78 = val_28.y;
            val_79 = val_28.z;
            var val_29 = val_68 + ((long)val_6 * 12);
            mem2[0] = val_77;
            mem2[0] = val_78;
            mem2[0] = val_79;
            val_74 = val_73 - val_74;
            if(val_6 >= val_4.Length)
            {
                    val_77 = mem[((long)(int)((val_1 - 1)) * 12) + val_4 + 32];
                val_77 = ((long)(int)((val_1 - 1)) * 12) + val_4 + 32;
                val_78 = mem[((long)(int)((val_1 - 1)) * 12) + val_4 + 32 + 4];
                val_78 = ((long)(int)((val_1 - 1)) * 12) + val_4 + 32 + 4;
                val_79 = mem[((long)(int)((val_1 - 1)) * 12) + val_4 + 32 + 8];
                val_79 = ((long)(int)((val_1 - 1)) * 12) + val_4 + 32 + 8;
            }
            
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_77, y = val_78, z = val_79}, d:  val_74);
            val_80 = val_5;
            val_81 = val_1;
            var val_68 = 12;
            val_68 = val_80 + ((long)val_6 * val_68);
            mem2[0] = val_30.x;
            mem2[0] = val_30.y;
            mem2[0] = val_30.z;
            val_82 = mem[val_3[(long)(int)((val_1 - 1))] + 32];
            val_82 = val_3[(long)(int)((val_1 - 1))] + 32;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(d:  val_82 + (val_2[(long)(int)((val_1 - 1))] + 32), a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 8});
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32, y = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32 + 4, z = ((long)(int)((val_1 - 2)) * 12) + val_4 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            val_86 = val_33.x;
            var val_69 = 12;
            int val_34 = val_81 - 3;
            val_69 = val_80 + ((long)val_69 * val_69);
            mem2[0] = val_86;
            mem2[0] = val_33.y;
            mem2[0] = val_33.z;
            if((val_34 & 2147483648) == 0)
            {
                    var val_71 = (long)val_34;
                val_34 = val_69 + (val_34 << );
                UnityEngine.Vector3[] val_37 = (val_68 + (((((long)(int)((val_1 - 2)) * 12) + val_5 + ((val_1 - 3)) << )) << 2)) + 40;
                val_81 = (val_80 + (((((long)(int)((val_1 - 2)) * 12) + val_5 + ((val_1 - 3)) << )) << 2)) + 40;
                val_75 = 12;
                var val_72 = val_69;
                do
            {
                var val_38 = val_80 + ((long)val_72 * val_75);
                val_76 = mem[((long)(int)((val_1 - 2)) * val_75) + val_5 + 32];
                val_76 = ((long)(int)((val_1 - 2)) * val_75) + val_5 + 32;
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(d:  val_3[(long)val_72], a:  new UnityEngine.Vector3() {x = val_76, y = ((long)(int)((val_1 - 2)) * val_75) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 2)) * val_75) + val_5 + 40});
                UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((val_4 + ((((long)(int)((val_1 - 2)) * 12) + val_5 + ((val_1 - 3)) << )) << 2) + 40) + -8, y = ((val_4 + ((((long)(int)((val_1 - 2)) * 12) + val_5 + ((val_1 - 3)) << )) << 2) + 40) + -8 + 4, z = val_37}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
                val_82 = val_2[(long)val_72];
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(d:  val_82, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 8});
                UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
                val_86 = val_42.x;
                mem2[0] = val_86;
                mem2[0] = val_42.y;
                mem2[0] = val_42.z;
                val_71 = val_71 - 1;
                val_72 = val_72 - 1;
                val_37 = val_37 - 12;
            }
            while((val_71 & 2147483648) == 0);
            
            }
            
            val_87 = this;
            ItemData val_43 = mem[1152921519504200288].Item[val_6];
            val_88 = val_43;
            var val_73 = 12;
            goto label_62;
            label_74:
            val_88 = val_43.Item[val_69];
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * val_75) + val_5 + 40, y = val_82, z = ((long)(int)((val_1 - 2)) * val_75) + val_5 + 32 + 4}, b:  new UnityEngine.Vector3() {x = val_44.Position, y = val_86, z = val_76});
            ItemData val_46 = mem[1152921519504200288].Item[val_69];
            val_44.A = val_46.Position;
            mem2[0] = val_6;
            val_73 = val_80 + ((long)val_69 * val_73);
            val_81 = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32;
            val_44.B = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32;
            mem2[0] = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 4;
            mem2[0] = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 8;
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 8});
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
            val_76 = val_50.y;
            val_75 = val_5 + (((long)val_69 + 1) * 12);
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_76, z = val_50.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32, y = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32 + 8});
            val_44.C = val_51;
            mem2[0] = val_51.y;
            mem2[0] = val_51.z;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Multiply(d:  -2f, a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 8});
            val_86 = val_53.x;
            val_82 = val_53.y;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_86, y = val_82, z = val_53.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32, y = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)(((val_1 - 2) + 1)) * 12) + val_5 + 32 + 8});
            val_44.D = val_54;
            mem2[0] = val_54.y;
            mem2[0] = val_54.z;
            val_87 = this;
            val_80 = val_5;
            val_69 = val_69 - 1;
            label_62:
            if((val_69 & 2147483648) == 0)
            {
                goto label_74;
            }
            
            ItemData val_55 = mem[1152921519504200288].Item[val_6];
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44.Position, y = val_82, z = val_53.z}, b:  new UnityEngine.Vector3() {x = val_55.Position, y = val_86, z = 2f});
            val_55.A = val_55.Position;
            mem2[0] = ((long)(int)((val_1 - 2)) * 12) + val_5 + 32 + 4;
            val_55.B = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32;
            mem2[0] = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 4;
            mem2[0] = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 8;
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
            UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 8});
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, b:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z});
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, b:  new UnityEngine.Vector3() {x = mem[1152921519504244576], y = mem[1152921519504244580], z = mem[1152921519504244584]});
            val_55.C = val_60;
            mem2[0] = val_60.y;
            mem2[0] = val_60.z;
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(d:  -2f, a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32, y = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 4, z = ((long)(int)((val_1 - 1)) * 12) + val_5 + 32 + 8});
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, b:  new UnityEngine.Vector3() {x = mem[1152921519504244576], y = mem[1152921519504244580], z = mem[1152921519504244584]});
            val_55.D = val_63;
            mem2[0] = val_63.y;
            mem2[0] = val_63.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddVertexFirst(UnityEngine.Vector3 position)
        {
            .Position = position;
            mem[1152921519504405716] = position.y;
            mem[1152921519504405720] = position.z;
            X21.Insert(index:  0, item:  new SplineBase.ItemData());
            this.BuildSpline();
            mem[1152921519504373740] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AddVertexLast(UnityEngine.Vector3 position)
        {
            .Position = position;
            mem[1152921519504525908] = position.y;
            mem[1152921519504525912] = position.z;
            X21.Add(item:  new SplineBase.ItemData());
            this.BuildSpline();
            mem[1152921519504493932] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void RemoveVertex(int index)
        {
            RemoveAt(index:  index);
            this.BuildSpline();
            mem[1152921519504610028] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Clear()
        {
            Clear();
            mem[1152921519504722028] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void InsertBefore(int vertexIndex, UnityEngine.Vector3 position)
        {
            .Position = position;
            mem[1152921519504870100] = position.y;
            mem[1152921519504870104] = position.z;
            X22.Insert(index:  vertexIndex, item:  new SplineBase.ItemData());
            this.BuildSpline();
            mem[1152921519504838124] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void InsertAfter(int vertexIndex, UnityEngine.Vector3 position)
        {
            .Position = position;
            mem[1152921519504990292] = position.y;
            mem[1152921519504990296] = position.z;
            X22.Insert(index:  vertexIndex + 1, item:  new SplineBase.ItemData());
            this.BuildSpline();
            mem[1152921519504958316] = 1;
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
            this.BuildSpline();
            mem[1152921519505198700] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CubicSpline3()
        {
        
        }
    
    }

}
