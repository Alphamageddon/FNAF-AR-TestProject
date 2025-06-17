using UnityEngine;

namespace KDTree
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NearestNeighbour<T> : IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] tSearchPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.DistanceFunctions kDistanceFunction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.MinHeap<KDTree.KDNode<T>> pPending;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.IntervalHeap<T> pEvaluated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private KDTree.KDNode<T> pRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int iMaxPointsReturned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int iPointsRemaining;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double fThreshold;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _CurrentDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T _Current;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Current { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double CurrentDistance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object System.Collections.IEnumerator.Current { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T System.Collections.Generic.IEnumerator<T>.Current { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NearestNeighbour<T>(KDTree.KDNode<T> pRoot, double[] tSearchPoint, KDTree.DistanceFunctions kDistance, int iMaxPoints, double fThreshold)
        {
            KDTree.KDNode<T> val_5 = pRoot;
            mem[1152921519614666520] = 0;
            if(tSearchPoint == null)
            {
                goto label_2;
            }
            
            label_11:
            if(W9 != tSearchPoint.Length)
            {
                goto label_4;
            }
            
            int val_1 = tSearchPoint.Length & 4294967295;
            double[] val_2 = new double[0];
            mem[1152921519614666464] = val_2;
            System.Array.Copy(sourceArray:  tSearchPoint, destinationArray:  val_2, length:  tSearchPoint.Length);
            mem[1152921519614666504] = iMaxPoints;
            mem[1152921519614666508] = System.Math.Min(val1:  iMaxPoints, val2:  val_5 = pRoot);
            mem[1152921519614666512] = fThreshold;
            mem[1152921519614666472] = kDistance;
            mem[1152921519614666496] = val_5;
            mem[1152921519614666520] = 0;
            mem[1152921519614666488] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            mem[1152921519614666480] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            val_5 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 40;
            label_2:
            if(val_5 != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_4:
            System.Exception val_4 = new System.Exception(message:  "Dimensionality of search point and kd-tree are not the same.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool MoveNext()
        {
            var val_12;
            float val_13;
            System.Double[] val_14;
            System.Double[] val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            var val_22;
            if(true == 0)
            {
                goto label_1;
            }
            
            goto label_71;
            label_83:
            if(!=0)
            {
                    if(V0.16B >= 0)
            {
                goto label_7;
            }
            
            }
            
            val_12 = 69165056;
            if(X22 != 0)
            {
                goto label_26;
            }
            
            goto label_26;
            label_29:
            var val_1 = X22 + ((mem[69165112]) << 3);
            val_13 = mem[69165120];
            var val_3 = (((X22 + (mem[69165112]) << 3) + 32) > val_13) ? 69165096 : 69165104;
            val_12 = mem[(X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096];
            val_12 = (((X22 + (mem[69165112]) << 3) + 32) > val_13) ? 69165104 : 69165096;
            if(val_3 != 0)
            {
                    val_15 = mem[(X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 72];
                val_15 = (X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 72;
            }
            else
            {
                    val_15 = 0;
            }
            
            var val_14 = X24;
            if((X24 + 286) == 0)
            {
                goto label_20;
            }
            
            var val_11 = X24 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_19:
            if(((X24 + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X24 + 286))
            {
                goto label_19;
            }
            
            goto label_20;
            label_18:
            var val_13 = val_11;
            val_13 = val_13 + 1;
            val_14 = val_14 + val_13;
            val_16 = val_14 + 296;
            label_20:
            double val_4 = X24.DistanceToRectangle(point:  mem[69165112], min:  val_15, max:  (X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 80);
            if(((X22 + (mem[69165112]) << 3) + 32) >= 0f)
            {
                    if(val_4 > ((X22 + (mem[69165112]) << 3) + 32))
            {
                goto label_26;
            }
            
            }
            
            if(mem[69165112] >= (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                    if(val_4 > val_4)
            {
                goto label_26;
            }
            
            }
            
            val_13 = val_4;
            label_26:
            if((val_12 & 1) == 0)
            {
                goto label_29;
            }
            
            if(((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 88) == 0)
            {
                goto label_31;
            }
            
            val_14 = mem[(X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 24 + 32];
            val_14 = (X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 24 + 32;
            var val_20 = val_3;
            if(((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 286) == 0)
            {
                goto label_38;
            }
            
            var val_15 = (X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_37:
            if((((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176 + 8) + -8) == null)
            {
                goto label_36;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 286))
            {
                goto label_37;
            }
            
            goto label_38;
            label_31:
            val_15 = 0;
            goto label_39;
            label_64:
            var val_5 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 24) + 0;
            val_14 = mem[((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 24 + 0) + 32];
            val_14 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 24 + 0) + 32;
            var val_19 = val_3;
            if(((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 286) == 0)
            {
                goto label_47;
            }
            
            var val_17 = (X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_46:
            if((((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176 + 8) + -8) == null)
            {
                goto label_45;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 286))
            {
                goto label_46;
            }
            
            goto label_47;
            label_45:
            val_19 = val_19 + ((((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176 + 8)) << 4);
            val_18 = val_19 + 296;
            label_47:
            double val_6 = val_3.Distance(p1:  val_14, p2:  X24);
            if(((X22 + (mem[69165112]) << 3) + 32) >= 0f)
            {
                    if(val_6 >= ((X22 + (mem[69165112]) << 3) + 32))
            {
                goto label_58;
            }
            
            }
            
            if(val_3 >= (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                goto label_51;
            }
            
            var val_7 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32) + 0;
            val_14 = mem[((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32 + 0) + 32];
            val_14 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32 + 0) + 32;
            val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
            goto label_56;
            label_51:
            if(val_6 >= 0)
            {
                goto label_58;
            }
            
            var val_8 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32) + 0;
            val_14 = mem[((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32 + 0) + 32];
            val_14 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32 + 0) + 32;
            val_20 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 88];
            val_20 = __RuntimeMethodHiddenParam + 24 + 192 + 88;
            label_56:
            val_13 = val_6;
            label_58:
            val_15 = 1;
            label_39:
            if(val_15 < val_12)
            {
                goto label_64;
            }
            
            goto label_71;
            label_36:
            val_20 = val_20 + ((((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 176 + 8)) << 4);
            val_17 = val_20 + 296;
            label_38:
            double val_9 = val_3.Distance(p1:  val_14, p2:  X24);
            if(((X22 + (mem[69165112]) << 3) + 32) >= 0f)
            {
                    if(val_9 >= ((X22 + (mem[69165112]) << 3) + 32))
            {
                goto label_71;
            }
            
            }
            
            if(val_3 >= (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                    if(val_9 > val_9)
            {
                goto label_71;
            }
            
            }
            
            val_15 = 0;
            goto label_72;
            label_81:
            val_14 = val_3;
            var val_10 = ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165104 : 69165096 + 32) + 0;
            if(val_14 == ((X22 + (mem[69165112]) << 3) + 32 > val_13 ? 69165096 : 69165104 + 80))
            {
                    val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 88];
                val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 88;
            }
            else
            {
                    val_21 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96];
                val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
            }
            
            val_13 = val_9;
            val_15 = 1;
            label_72:
            if(val_15 < val_12)
            {
                goto label_81;
            }
            
            label_71:
            if(val_12 >= 1)
            {
                goto label_83;
            }
            
            label_7:
            val_22 = val_12;
            var val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            if(val_22 == 0)
            {
                    return (bool)val_22;
            }
            
            val_21 = val_21 - 1;
            mem[1152921519614831804] = val_21;
            mem[1152921519614831816] = val_13;
            mem[1152921519614831824] = val_12;
            val_22 = 1;
            return (bool)val_22;
            label_1:
            val_22 = 0;
            mem[1152921519614831824] = 0;
            return (bool)val_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            mem[1152921519614943852] = System.Math.Min(val1:  69165056, val2:  X22);
            mem[1152921519614943864] = 0;
            mem[1152921519614943832] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            mem[1152921519614943824] = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 24) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Current()
        {
            return (Mapbox.Unity.MeshGeneration.Data.VectorEntity)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_CurrentDistance()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object System.Collections.IEnumerator.get_Current()
        {
            return (object)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T System.Collections.Generic.IEnumerator<T>.get_Current()
        {
            return (object)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return (System.Collections.Generic.IEnumerator<T>)this;
        }
    
    }

}
