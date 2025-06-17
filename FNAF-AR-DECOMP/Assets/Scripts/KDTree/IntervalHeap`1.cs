using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntervalHeap<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DEFAULT_SIZE = 64;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T[] tData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] tKeys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Size>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Capacity>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Size { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Capacity { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Min { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Max { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MinKey { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxKey { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntervalHeap<T>()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntervalHeap<T>(int capacity)
        {
            mem[1152921519608564128] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            mem[1152921519608564136] = new double[0];
            if(this != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Size()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Size(int value)
        {
            mem[1152921519608796336] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Capacity()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Capacity(int value)
        {
            mem[1152921519609020340] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Min()
        {
            if(this != null)
            {
                    if((__RuntimeMethodHiddenParam + 24 + 192 + 32) != 0)
            {
                    return 0;
            }
            
                return 0;
            }
            
            System.Exception val_1 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Max()
        {
            if(this != null)
            {
                    var val_1 = (this != 1) ? 1 : 0;
                var val_2 = __RuntimeMethodHiddenParam + ((this != 0x1 ? 1 : 0) << 3);
                return (object)(__RuntimeMethodHiddenParam + (this != 0x1 ? 1 : 0) << 3) + 32;
            }
            
            System.Exception val_3 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_MinKey()
        {
            if(this != null)
            {
                    if((__RuntimeMethodHiddenParam + 24 + 192 + 32) != 0)
            {
                    return (double)D0;
            }
            
                return (double)D0;
            }
            
            System.Exception val_1 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_MaxKey()
        {
            if(this != null)
            {
                    var val_1 = (this != 1) ? 1 : 0;
                var val_2 = __RuntimeMethodHiddenParam + ((this != 0x1 ? 1 : 0) << 3);
                return (double)(__RuntimeMethodHiddenParam + (this != 0x1 ? 1 : 0) << 3) + 32;
            }
            
            System.Exception val_3 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Insert(double key, T value)
        {
            if(this >= this)
            {
                    if(this != null)
            {
                
            }
            
                System.Array.Copy(sourceArray:  this, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 8, length:  __RuntimeMethodHiddenParam + 24 + 192 + 16);
                mem[1152921519609621312] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
                double[] val_1 = new double[2117872432];
                System.Array.Copy(sourceArray:  this, destinationArray:  val_1, length:  __RuntimeMethodHiddenParam + 24 + 192 + 16);
                mem[1152921519609621320] = val_1;
            }
            
            mem[1152921536552600776] = value;
            var val_2 = 2117872431 + 16942979448;
            mem2[0] = key;
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveMin()
        {
            var val_5;
            var val_6;
            if(this == null)
            {
                goto label_2;
            }
            
            val_5 = mem[X22 + 24];
            val_5 = X22 + 24;
            if(this >= val_5)
            {
                    val_5 = mem[X22 + 24];
                val_5 = X22 + 24;
            }
            
            var val_1 = X22 + 16943949440;
            mem2[0] = (X22 + 16943949440) + 32;
            val_6 = mem[X22 + 24];
            val_6 = X22 + 24;
            if(this >= val_6)
            {
                    val_6 = mem[X22 + 24];
                val_6 = X22 + 24;
            }
            
            var val_2 = X22 + 16943949440;
            mem2[0] = (X22 + 16943949440) + 32;
            var val_3 = X22 + 16943949440;
            mem2[0] = 0;
            if(this != null)
            {
                goto __RuntimeMethodHiddenParam + 24 + 192 + 56;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 192 + 56;
            label_2:
            System.Exception val_4 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReplaceMin(double key, T value)
        {
            var val_9;
            var val_10;
            val_9 = __RuntimeMethodHiddenParam;
            if(this != null)
            {
                    mem2[0] = key;
                if(this < 2)
            {
                    return;
            }
            
                val_9 = ???;
                val_10 = ???;
            }
            else
            {
                    System.Exception val_8 = new System.Exception();
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveMax()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = __RuntimeMethodHiddenParam;
            val_13 = this;
            if(this == null)
            {
                goto label_2;
            }
            
            if(val_13 != 1)
            {
                goto label_5;
            }
            
            val_12 = ???;
            val_13 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 72;
            label_5:
            var val_1 = val_13 - 1;
            val_14 = mem[val_13 + 16 + 24];
            val_14 = val_13 + 16 + 24;
            if(val_13 >= val_14)
            {
                    val_14 = mem[val_13 + 16 + 24];
                val_14 = val_13 + 16 + 24;
            }
            
            var val_2 = (val_13 + 16) + (((long)(int)()) << 3);
            mem2[0] = (val_13 + 16 + ((long)(int)()) << 3) + 32;
            val_15 = mem[val_13 + 24 + 24];
            val_15 = val_13 + 24 + 24;
            if(val_13 >= val_15)
            {
                    val_15 = mem[val_13 + 24 + 24];
                val_15 = val_13 + 24 + 24;
            }
            
            var val_3 = (val_13 + 24) + (((long)(int)()) << 3);
            mem2[0] = (val_13 + 24 + ((long)(int)()) << 3) + 32;
            var val_4 = (val_13 + 16) + (((long)(int)()) << 3);
            mem2[0] = 0;
            if(val_13 != 0)
            {
                goto val_12 + 24 + 192 + 80;
            }
            
            goto val_12 + 24 + 192 + 80;
            label_2:
            System.Exception val_11 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReplaceMax(double key, T value)
        {
            var val_9;
            var val_10;
            double val_11;
            var val_12;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = value;
            val_11 = key;
            val_12 = this;
            if(this == null)
            {
                goto label_2;
            }
            
            if(val_12 != 1)
            {
                goto label_4;
            }
            
            val_9 = ???;
            val_12 = ???;
            val_10 = ???;
            val_11 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 88;
            label_4:
            mem2[0] = val_10;
            mem2[0] = val_11;
            if((val_12 + 24 + 32) <= val_11)
            {
                goto val_9 + 24 + 192 + 80;
            }
            
            goto val_9 + 24 + 192 + 80;
            label_2:
            System.Exception val_8 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int Swap(int x, int y)
        {
            var val_9;
            var val_10;
            var val_1 = X22 + (((long)(int)(y)) << 3);
            var val_2 = X23 + (((long)(int)(y)) << 3);
            val_9 = mem[X26 + 24];
            val_9 = X26 + 24;
            if(val_9 <= x)
            {
                    val_9 = mem[X26 + 24];
                val_9 = X26 + 24;
            }
            
            var val_3 = X26 + (((long)(int)(x)) << 3);
            var val_4 = X26 + (((long)(int)(y)) << 3);
            mem2[0] = (X26 + ((long)(int)(x)) << 3) + 32;
            val_10 = mem[X26 + 24];
            val_10 = X26 + 24;
            if(val_10 <= x)
            {
                    val_10 = mem[X26 + 24];
                val_10 = X26 + 24;
            }
            
            var val_5 = X26 + (((long)(int)(x)) << 3);
            var val_6 = X26 + (((long)(int)(y)) << 3);
            mem2[0] = (X26 + ((long)(int)(x)) << 3) + 32;
            var val_7 = (long)y + (((long)(int)(x)) << 3);
            mem2[0] = (X22 + ((long)(int)(y)) << 3) + 32;
            KDTree.IntervalHeap<T> val_8 = this + (((long)(int)(x)) << 3);
            mem2[0] = (X23 + ((long)(int)(y)) << 3) + 32;
            return (int)y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftInsertedValueUp()
        {
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            var val_24;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            val_39 = __RuntimeMethodHiddenParam;
            val_40 = this;
            val_41 = 1152921519610350671;
            if()
            {
                    return;
            }
            
            val_42 = 1152921519610350670;
            if()
            {
                goto label_2;
            }
            
            val_43 = 2118601807;
            var val_1 = X22 + 16948814456;
            if(((X22 + 16948814456) + 32) >= 0)
            {
                    return;
            }
            
            val_44 = ???;
            val_39 = ???;
            val_40 = ???;
            val_41 = ???;
            val_42 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 64;
            label_2:
            var val_2 = (val_41 < 0) ? (val_41 + 1) : (val_41);
            var val_5 = val_2 & 4294967294;
            var val_6 = (val_40 + 24) + (((long)(int)()) << 3);
            val_45 = mem[val_40 + 24];
            val_45 = val_40 + 24;
            var val_7 = ((val_2 >> 1) - 1) | 1;
            val_5 = val_41 - val_5;
            if(val_5 != 1)
            {
                goto label_11;
            }
            
            var val_8 = val_45 + (((long)(int)()) << 3);
            if(((val_40 + 24 + ((long)(int)()) << 3) + 32) >= 0)
            {
                goto label_13;
            }
            
            val_41 = val_40;
            if(val_41 < (val_40 + 24 + 24))
            {
                goto label_24;
            }
            
            label_23:
            label_24:
            var val_9 = (val_40 + 24) + (((long)(int)()) << 3);
            val_46 = mem[val_40 + 24];
            val_46 = val_40 + 24;
            var val_10 = val_7 - 1;
            var val_11 = val_46 + (((long)(int)(((((val_41 < 0x0 ? (val_41 + 1) : val_41 >> 1) - 1) | 1) - 1))) << 3);
            if(((val_40 + 24 + ((long)(int)()) << 3) + 32) >= 0)
            {
                    return;
            }
            
            val_47 = val_40;
            val_48 = mem[val_39 + 24 + 192 + 96];
            val_48 = val_39 + 24 + 192 + 96;
            goto label_19;
            label_11:
            val_49 = (long)val_7;
            var val_12 = val_45 + (((long)(int)((((val_41 < 0x0 ? (val_41 + 1) : val_41 >> 1) - 1) | 1))) << 3);
            if(((val_40 + 24 + ((long)(int)()) << 3) + 32) > ((val_40 + 24 + ((long)(int)((((val_41 < 0x0 ? (val_41 + 1) : val_41 >> 1) - 1) | 1))) << 3) + 32))
            {
                goto label_21;
            }
            
            if(val_41 >= (val_40 + 24 + 24))
            {
                goto label_23;
            }
            
            goto label_24;
            label_13:
            var val_13 = (val_40 + 24) + (((long)(int)()) << 3);
            val_46 = mem[val_40 + 24];
            val_46 = val_40 + 24;
            var val_14 = val_46 + (((long)(int)((((val_41 < 0x0 ? (val_41 + 1) : val_41 >> 1) - 1) | 1))) << 3);
            if(((val_40 + 24 + ((long)(int)()) << 3) + 32) <= ((val_40 + 24 + ((long)(int)((((val_41 < 0x0 ? (val_41 + 1) : val_41 >> 1) - 1) | 1))) << 3) + 32))
            {
                    return;
            }
            
            label_21:
            val_47 = val_40;
            val_48 = mem[val_39 + 24 + 192 + 104];
            val_48 = val_39 + 24 + 192 + 104;
            label_19:
            val_44 = val_16;
            val_40 = val_18;
            val_41 = val_20;
            val_43 = val_22;
            val_45 = val_24;
            goto val_39 + 24 + 192 + 104;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftUpMin(int iChild)
        {
            int val_5 = iChild;
            var val_1 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            val_1 = val_1 >> 1;
            val_1 = val_1 - 1;
            if(val_1 < (-2))
            {
                    return;
            }
            
            val_1 = val_1 & 4294967294;
            do
            {
                var val_2 = X23 + (((long)(int)(iChild)) << 3);
                var val_3 = X23 + (((long)(int)((((val_5 < 0 ? (iChild + 1) : iChild >> 1) - 1) & 4294967294))) << 3);
                if(((X23 + ((long)(int)(iChild)) << 3) + 32) >= 0)
            {
                    return;
            }
            
                var val_4 = val_1 >> 1;
                val_4 = val_4 - 1;
                val_4 = val_4 & 4294967294;
                val_5 = val_1;
            }
            while(val_4 >= (-2));
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftUpMax(int iChild)
        {
            int val_5 = iChild;
            var val_1 = (val_5 < 0) ? (val_5 + 1) : (val_5);
            val_1 = val_1 >> 1;
            val_1 = val_1 - 1;
            val_1 = val_1 | 1;
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                var val_2 = X23 + (((long)(int)(iChild)) << 3);
                var val_3 = X23 + (((long)(int)((((val_5 < 0 ? (iChild + 1) : iChild >> 1) - 1) | 1))) << 3);
                if(((X23 + ((long)(int)(iChild)) << 3) + 32) <= ((X23 + ((long)(int)((((val_5 < 0 ? (iChild + 1) : iChild >> 1) - 1) | 1))) << 3) + 32))
            {
                    return;
            }
            
                var val_4 = val_1 >> 1;
                val_4 = val_4 - 1;
                val_4 = val_4 | 1;
                val_5 = val_1;
            }
            while((val_4 & 2147483648) == 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftDownMin(int iParent)
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = iParent;
            goto label_18;
            label_20:
            var val_1 = W23 + 4;
            if(val_1 < this)
            {
                    var val_2 = X24 + (((long)(int)((W23 + 4))) << 3);
                var val_3 = X24 + (((long)(int)(W21)) << 3);
                if(((X24 + ((long)(int)((W23 + 4))) << 3) + 32) < 0)
            {
                    val_10 = val_1;
            }
            
            }
            
            var val_4 = val_1 + (((long)(int)((W23 + 4))) << 3);
            var val_5 = val_1 + (((long)(int)(iParent)) << 3);
            if((((W23 + 4) + ((long)(int)((W23 + 4))) << 3) + 32) >= 0)
            {
                    return;
            }
            
            val_1 = val_10 + 1;
            val_9 = val_10;
            if(val_1 < this)
            {
                    var val_6 = val_9 + (((long)(int)(((W23 + 4) + 1))) << 3);
                var val_7 = val_9 + (((long)(int)((W23 + 4))) << 3);
                val_9 = val_10;
                if((((W23 + 4) + ((long)(int)(((W23 + 4) + 1))) << 3) + 32) < 0)
            {
                    val_9 = val_10;
            }
            
            }
            
            label_18:
            val_11 = val_9 << 1;
            val_10 = val_11 + 2;
            if(val_10 < this)
            {
                goto label_20;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftDownMax(int iParent)
        {
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_27 = iParent;
            val_28 = this;
            goto label_27;
            label_29:
            if(W22 == val_28)
            {
                goto label_2;
            }
            
            var val_1 = W22 + 2;
            if(val_1 != val_28)
            {
                goto label_4;
            }
            
            val_29 = (long)W22 + 1;
            var val_3 = X24 + (((long)(int)((W22 + 1))) << 3);
            var val_4 = X24 + (((long)(int)(W22)) << 3);
            if(((X24 + ((long)(int)((W22 + 1))) << 3) + 32) <= ((X24 + ((long)(int)(W22)) << 3) + 32))
            {
                goto label_17;
            }
            
            goto label_10;
            label_4:
            if(val_1 < val_28)
            {
                    var val_5 = X24 + (((long)(int)((W22 + 2))) << 3);
                var val_6 = X24 + (((long)(int)(W22)) << 3);
            }
            
            label_17:
            var val_7 = val_1 + (((long)(int)((W22 + 2))) << 3);
            var val_8 = val_1 + (((long)(int)(iParent)) << 3);
            if((((W22 + 2) + ((long)(int)((W22 + 2))) << 3) + 32) <= (((W22 + 2) + ((long)(int)(iParent)) << 3) + 32))
            {
                    return;
            }
            
            val_29 = (long)val_1 - 1;
            int val_10 = val_27 + (((long)(int)(((W22 + 2) - 1))) << 3);
            int val_11 = val_27 + (((long)(int)((W22 + 2))) << 3);
            val_27 = val_1;
            if(((iParent + ((long)(int)(((W22 + 2) - 1))) << 3) + 32) > ((iParent + ((long)(int)((W22 + 2))) << 3) + 32))
            {
                    val_27 = val_1;
            }
            
            label_27:
            if(1 <= val_28)
            {
                goto label_29;
            }
            
            return;
            label_2:
            int val_12 = val_27 << 1;
            var val_13 = X23 + (((long)(int)((iParent << 1))) << 3);
            var val_14 = X23 + (((long)(int)(iParent)) << 3);
            if(((X23 + ((long)(int)((iParent << 1))) << 3) + 32) <= ((X23 + ((long)(int)(iParent)) << 3) + 32))
            {
                    return;
            }
            
            val_30 = mem[__RuntimeMethodHiddenParam + 24];
            val_30 = __RuntimeMethodHiddenParam + 24;
            goto label_36;
            label_10:
            var val_15 = X22 + (((long)(int)((W22 + 1))) << 3);
            var val_16 = X22 + (((long)(int)(iParent)) << 3);
            if(((X22 + ((long)(int)((W22 + 1))) << 3) + 32) <= ((X22 + ((long)(int)(iParent)) << 3) + 32))
            {
                    return;
            }
            
            val_30 = mem[__RuntimeMethodHiddenParam + 24];
            val_30 = __RuntimeMethodHiddenParam + 24;
            label_36:
            val_28 = ???;
            val_27 = ???;
            val_29 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 64;
        }
    
    }

}
