using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MinHeap<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int DEFAULT_SIZE;
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
        public double MinKey { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MinHeap<T>()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MinHeap<T>(int iCapacity)
        {
            mem[1152921519613223904] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem[1152921519613223912] = new double[0];
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
            mem[1152921519613456112] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Capacity()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Capacity(int value)
        {
            mem[1152921519613680116] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Insert(double key, T value)
        {
            if(this >= this)
            {
                    if(this != null)
            {
                
            }
            
                System.Array.Copy(sourceArray:  this, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 16, length:  __RuntimeMethodHiddenParam + 24 + 192 + 24);
                mem[1152921519613796224] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
                double[] val_1 = new double[2122047344];
                System.Array.Copy(sourceArray:  this, destinationArray:  val_1, length:  __RuntimeMethodHiddenParam + 24 + 192 + 24);
                mem[1152921519613796232] = val_1;
            }
            
            mem[1152921536590174992] = value;
            var val_2 = 2122047344 + 16976378752;
            mem2[0] = key;
            if(this != null)
            {
                
            }
            
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
            
            var val_1 = X22 + 16977348736;
            mem2[0] = (X22 + 16977348736) + 32;
            val_6 = mem[X22 + 24];
            val_6 = X22 + 24;
            if(this >= val_6)
            {
                    val_6 = mem[X22 + 24];
                val_6 = X22 + 24;
            }
            
            var val_2 = X22 + 16977348736;
            mem2[0] = (X22 + 16977348736) + 32;
            var val_3 = X22 + 16977348736;
            mem2[0] = 0;
            if(this != null)
            {
                goto __RuntimeMethodHiddenParam + 24 + 192 + 64;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 192 + 64;
            label_2:
            System.Exception val_4 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Min()
        {
            if(this != null)
            {
                    if((__RuntimeMethodHiddenParam + 24 + 192 + 40) != 0)
            {
                    return 0;
            }
            
                return 0;
            }
            
            System.Exception val_1 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_MinKey()
        {
            if(this != null)
            {
                    if((__RuntimeMethodHiddenParam + 24 + 192 + 40) != 0)
            {
                    return (double)D0;
            }
            
                return (double)D0;
            }
            
            System.Exception val_1 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftUp(int iChild)
        {
            var val_13;
            var val_14;
            var val_15;
            if(iChild == 0)
            {
                    return;
            }
            
            do
            {
                int val_1 = iChild - 1;
                var val_2 = (val_1 < 0) ? iChild : (val_1);
                var val_3 = X23 + (((long)(int)(iChild)) << 3);
                val_2 = val_2 >> 1;
                val_13 = (long)val_2;
                var val_4 = X24 + (((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3);
                if(((X23 + ((long)(int)(iChild)) << 3) + 32) >= 0)
            {
                    return;
            }
            
                var val_5 = X24 + (((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3);
                var val_6 = X24 + (((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3);
                val_14 = mem[X26 + 24];
                val_14 = X26 + 24;
                if(iChild >= val_14)
            {
                    val_14 = mem[X26 + 24];
                val_14 = X26 + 24;
            }
            
                var val_7 = X26 + (((long)(int)(iChild)) << 3);
                var val_8 = X26 + (((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3);
                mem2[0] = (X26 + ((long)(int)(iChild)) << 3) + 32;
                val_15 = mem[X26 + 24];
                val_15 = X26 + 24;
                if(iChild >= val_15)
            {
                    val_15 = mem[X26 + 24];
                val_15 = X26 + 24;
            }
            
                var val_9 = X26 + (((long)(int)(iChild)) << 3);
                var val_10 = X26 + (((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3);
                mem2[0] = (X26 + ((long)(int)(iChild)) << 3) + 32;
                var val_11 = val_13 + (((long)(int)(iChild)) << 3);
                mem2[0] = (X24 + ((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3) + 32;
                var val_12 = val_13 + (((long)(int)(iChild)) << 3);
                mem2[0] = (X24 + ((long)(int)((val_1 < 0 ? iChild : (iChild - 1) >> 1))) << 3) + 32;
            }
            while(iChild >= 3);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SiftDown(int iParent)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = iParent;
            goto label_0;
            label_28:
            var val_1 = W22 + 1;
            if(val_1 < this)
            {
                    var val_2 = X24 + (((long)(int)(W22)) << 3);
                var val_3 = X24 + (((long)(int)((W22 + 1))) << 3);
            }
            
            var val_4 = val_1 + (((long)(int)(iParent)) << 3);
            var val_5 = (long)val_1 + (((long)(int)((W22 + 1))) << 3);
            if((((W22 + 1) + ((long)(int)(iParent)) << 3) + 32) <= (((long)(int)((W22 + 1)) + ((long)(int)((W22 + 1))) << 3) + 32))
            {
                    return;
            }
            
            var val_6 = (long)val_1 + (((long)(int)(iParent)) << 3);
            val_15 = mem[((long)(int)((W22 + 1)) + ((long)(int)(iParent)) << 3) + 32];
            val_15 = ((long)(int)((W22 + 1)) + ((long)(int)(iParent)) << 3) + 32;
            var val_7 = X26 + (((long)(int)(iParent)) << 3);
            val_16 = mem[X27 + 24];
            val_16 = X27 + 24;
            if(val_1 >= val_16)
            {
                    val_16 = mem[X27 + 24];
                val_16 = X27 + 24;
            }
            
            var val_8 = X27 + (((long)(int)((W22 + 1))) << 3);
            var val_9 = X27 + (((long)(int)(iParent)) << 3);
            mem2[0] = (X27 + ((long)(int)((W22 + 1))) << 3) + 32;
            val_17 = mem[X27 + 24];
            val_17 = X27 + 24;
            if(val_1 >= val_17)
            {
                    val_17 = mem[X27 + 24];
                val_17 = X27 + 24;
            }
            
            var val_10 = X27 + (((long)(int)((W22 + 1))) << 3);
            var val_11 = X27 + (((long)(int)(iParent)) << 3);
            mem2[0] = (X27 + ((long)(int)((W22 + 1))) << 3) + 32;
            int val_12 = val_14 + (((long)(int)((W22 + 1))) << 3);
            mem2[0] = val_15;
            int val_13 = val_14 + (((long)(int)((W22 + 1))) << 3);
            val_14 = val_1;
            mem2[0] = (X26 + ((long)(int)(iParent)) << 3) + 32;
            label_0:
            if(1 < this)
            {
                goto label_28;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MinHeap<T>()
        {
            mem2[0] = 64;
        }
    
    }

}
