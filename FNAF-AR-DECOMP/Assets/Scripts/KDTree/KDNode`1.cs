using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class KDNode<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal int iDimensions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal int iBucketCapacity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal double[][] tPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal T[] tData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal KDTree.KDNode<T> pLeft;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal KDTree.KDNode<T> pRight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal int iSplitDimension;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal double fSplitValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal double[] tMinBound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal double[] tMaxBound;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected internal bool bSinglePoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Size>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Size { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLeaf { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected KDNode<T>(int iDimensions, int iBucketCapacity)
        {
            int val_2 = iBucketCapacity;
            if(this != null)
            {
                    mem[1152921519610922976] = iDimensions;
                mem[1152921519610922980] = val_2;
            }
            else
            {
                    mem[16] = iDimensions;
                mem[20] = val_2;
            }
            
            mem[1152921519610923048] = 1;
            val_2 = val_2 + 1;
            mem[1152921519610922984] = new System.Double[][0];
            mem[1152921519610922992] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Size()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Size(int value)
        {
            mem[1152921519611155244] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLeaf()
        {
            return (bool)(X8 != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddPoint(double[] tPoint, T kValue)
        {
            var val_2 = this;
            goto label_0;
            label_8:
            if(this != null)
            {
                
            }
            
            val_2 = mem[tPoint[val_2] > D1 ? 1152921519611420160 : 1152921519611420152];
            val_2 = (tPoint[val_2] > D1) ? 1152921519611420160 : 1152921519611420152;
            label_0:
            if((val_2 & 1) == 0)
            {
                goto label_8;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 192 + 40;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddLeafPoint(double[] tPoint, T kValue)
        {
            var val_3;
            if(X24 == 0)
            {
                goto label_1;
            }
            
            if(tPoint != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(tPoint == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            var val_1 = X24 + 16958921344;
            mem2[0] = tPoint;
            var val_2 = X24 + 16958921344;
            mem2[0] = kValue;
            if(this != null)
            {
                
            }
            
            if(this != null)
            {
                
            }
            
            var val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            val_3 = val_3 - 1;
            if(this != val_3)
            {
                    return;
            }
            
            if((this & 1) != 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 56];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 56;
            }
            else
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckBounds(double[] tPoint)
        {
            var val_3;
            var val_4;
            if(W8 < 1)
            {
                goto label_0;
            }
            
            val_3 = 0;
            label_10:
            var val_1 = X24 + 0;
            if((tPoint[0] > ((X24 + 0) + 32)) || ((tPoint[0x0] + 32) < 0))
            {
                goto label_9;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < (X24 + 0))
            {
                goto label_10;
            }
            
            label_0:
            val_4 = 1;
            return (bool)val_4;
            label_9:
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExtendBounds(double[] tPoint)
        {
            float val_13;
            int val_14;
            var val_15;
            if(true == 0)
            {
                goto label_1;
            }
            
            if(tPoint < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            label_35:
            bool val_1 = System.Double.IsNaN(d:  tPoint[0]);
            var val_2 = X27 + 0;
            if(val_1 == false)
            {
                goto label_9;
            }
            
            if((System.Double.IsNaN(d:  (X27 + 0) + 32)) == false)
            {
                goto label_12;
            }
            
            bool val_4 = val_1 + 0;
            if((System.Double.IsNaN(d:  (val_1 + 0) + 32)) == true)
            {
                goto label_17;
            }
            
            label_12:
            mem[1152921519611997864] = 0;
            label_17:
            bool val_6 = val_1 + 0;
            mem2[0] = 9221120237041090560;
            bool val_7 = val_1 + 0;
            mem2[0] = 9221120237041090560;
            goto label_29;
            label_9:
            val_13 = mem[tPoint[0x0] + 32];
            val_13 = tPoint[0x0] + 32;
            if(((X27 + 0) + 32) <= val_13)
            {
                goto label_24;
            }
            
            val_14 = tPoint.Length;
            goto label_25;
            label_24:
            bool val_8 = val_1 + 0;
            val_13 = mem[tPoint[0x0] + 32];
            val_13 = tPoint[0x0] + 32;
            if(((val_1 + 0) + 32) >= 0)
            {
                goto label_29;
            }
            
            val_14 = tPoint.Length;
            label_25:
            if(val_13 >= val_14)
            {
                goto label_30;
            }
            
            val_15 = val_13;
            if(val_1 == true)
            {
                goto label_33;
            }
            
            goto label_32;
            label_30:
            val_15 = mem[tPoint[0x0] + 32];
            val_15 = tPoint[0x0] + 32;
            if(val_1 == true)
            {
                goto label_33;
            }
            
            label_32:
            label_33:
            mem2[0] = val_15;
            mem[1152921519611997864] = 0;
            label_29:
            val_13 = val_13 + 1;
            if(val_13 < (val_1 + 0))
            {
                goto label_35;
            }
            
            return;
            label_1:
            mem[1152921519611997848] = new double[0];
            mem[1152921519611997856] = new double[0];
            System.Array.Copy(sourceArray:  tPoint, destinationArray:  tPoint, length:  __RuntimeMethodHiddenParam);
            System.Array.Copy(sourceArray:  tPoint, destinationArray:  tPoint, length:  __RuntimeMethodHiddenParam);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IncreaseLeafCapacity()
        {
            System.Array.Resize<System.Double[]>(array: ref  1152921519612155880, newSize:  (X22 + 24) << 1);
            var val_3 = (__RuntimeMethodHiddenParam + 24 + 192) << 1;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 72;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CalculateSplit()
        {
            float val_5;
            float val_6;
            if(true != 0)
            {
                    return false;
            }
            
            if(true < 1)
            {
                    return false;
            }
            
            var val_10 = 0;
            val_5 = 0;
            var val_1 = X23 + 0;
            float val_9 = (X23 + 0) + 32;
            var val_2 = X23 + 0;
            val_9 = val_9 - ((X23 + 0) + 32);
            float val_4 = ((System.Double.IsNaN(d:  val_9)) != true) ? 0 : (val_9);
            if(val_4 > val_5)
            {
                    val_5 = val_4;
                mem[1152921519612267912] = val_10;
            }
            
            val_10 = val_10 + 1;
            if(val_5 == 0f)
            {
                    return false;
            }
            
            var val_5 = val_10 + 553820800;
            var val_6 = val_10 + 553820800;
            float val_11 = ((0 + 1) + 553820800) + 32;
            val_11 = (((0 + 1) + 553820800) + 32) + val_11;
            val_6 = val_11 * 0.5;
            mem[1152921519612267920] = val_6;
            if(val_6 != Infinity)
            {
                goto label_16;
            }
            
            val_6 = 1.79769313486232E+308;
            goto label_17;
            label_16:
            if(val_6 != (-Infinity))
            {
                goto label_18;
            }
            
            val_6 = -1.79769313486232E+308;
            label_17:
            mem[1152921519612267920] = val_6;
            label_18:
            var val_7 = val_10 + 553820800;
            if(val_6 != (((0 + 1) + 553820800) + 32))
            {
                    return false;
            }
            
            var val_8 = val_10 + 553820800;
            mem[1152921519612267920] = ((0 + 1) + 553820800) + 32;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SplitLeafNode()
        {
            var val_3;
            var val_4;
            mem[1152921519612379904] = __RuntimeMethodHiddenParam + 24 + 192 + 80;
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 80;
            mem[1152921519612379896] = val_4;
            if(this < 1)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_13:
            val_3 = mem[typeof(KDTree.KDNode<T>).<Size>k__BackingField + 32];
            val_3 = typeof(KDTree.KDNode<T>).<Size>k__BackingField + 32;
            var val_1 = val_4 + 0;
            var val_2 = val_3 + ((__RuntimeMethodHiddenParam + 24 + 192 + 80) << 3);
            if(((typeof(KDTree.KDNode<T>).<Size>k__BackingField + 32 + (__RuntimeMethodHiddenParam + 24 + 192 + 80) << 3) + 32) <= D1)
            {
                goto label_9;
            }
            
            if(val_4 != 0)
            {
                goto label_12;
            }
            
            goto label_11;
            label_9:
            if(val_4 != 0)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            val_3 = val_3 + 1;
            if(val_3 < this)
            {
                goto label_13;
            }
            
            label_2:
            mem[1152921519612379880] = 0;
            mem[1152921519612379888] = 0;
        }
    
    }

}
