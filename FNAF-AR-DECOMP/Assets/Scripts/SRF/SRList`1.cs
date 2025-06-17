using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T[] _buffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.EqualityComparer<T> _equalityComparer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.ObjectModel.ReadOnlyCollection<T> _readOnlyWrapper;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T[] Buffer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.EqualityComparer<T> EqualityComparer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsReadOnly { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Item { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRList<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRList<T>(int capacity)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRList<T>(System.Collections.Generic.IEnumerable<T> source)
        {
            if(this != null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T[] get_Buffer()
        {
            return (T[])this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Buffer(T[] value)
        {
            mem[1152921520180238576] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.EqualityComparer<T> get_EqualityComparer()
        {
            var val_1;
            if(this != null)
            {
                    return (System.Collections.Generic.EqualityComparer<T>)val_1;
            }
            
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            mem[1152921520180387456] = val_1;
            return (System.Collections.Generic.EqualityComparer<T>)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Count(int value)
        {
            mem[1152921520180611448] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            mem2[0] = this;
            return (System.Collections.Generic.IEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 40;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item)
        {
            if(this != null)
            {
                    if(this != (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                goto label_5;
            }
            
            }
            
            label_5:
            mem[1152921507334834432] = item;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Contains(T item)
        {
            var val_1 = this;
            if(this == null)
            {
                    return (bool)val_1;
            }
            
            var val_1 = 0;
            label_9:
            if(val_1 >= this)
            {
                goto label_3;
            }
            
            val_1 = val_1 + 1;
            if((this & 1) == 0)
            {
                goto label_9;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_3:
            val_1 = 0;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(T[] array, int arrayIndex)
        {
            this.CopyTo(array:  array, index:  arrayIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Remove(T item)
        {
            var val_1 = this;
            if(this == null)
            {
                    return (bool)val_1;
            }
            
            if((this & 2147483648) == 0)
            {
                    val_1 = 1;
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsReadOnly()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IndexOf(T item)
        {
            var val_1;
            if(this == null)
            {
                    return 0;
            }
            
            val_1 = 0;
            goto label_2;
            label_10:
            if((this & 1) != 0)
            {
                    return 0;
            }
            
            val_1 = 1;
            label_2:
            if(val_1 < this)
            {
                goto label_10;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Insert(int index, T item)
        {
            int val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = item;
            if(this != null)
            {
                    if(this != (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                goto label_5;
            }
            
            }
            
            label_5:
            val_3 = this;
            if(val_3 <= index)
            {
                goto label_9;
            }
            
            val_4 = this;
            goto label_10;
            label_17:
            long val_2 = -1604886433;
            val_2 = val_2 + 1;
            val_4 = val_2 - 1;
            mem[1152921513762284032] = mem[1152921513762284028];
            label_10:
            val_3 = this;
            if(val_4 > index)
            {
                goto label_17;
            }
            
            SRF.SRList<T> val_1 = val_3 + (((long)(int)(index)) << 2);
            mem2[0] = val_2;
            val_2 = 1152921520181829729;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 88];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 88;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 136;
            label_9:
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 136];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 136;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveAt(int index)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = index;
            if(this == null)
            {
                    return;
            }
            
            if(this <= val_6)
            {
                    return;
            }
            
            if(this != null)
            {
                
            }
            
            val_7 = 0;
            val_8 = (this + (((long)(int)(index)) << 3)) + 32;
            goto label_9;
            label_17:
            var val_5 = (long)val_6 + 1;
            SRF.SRList<T> val_3 = this + (((long)(int)((index + 1))) << 3);
            val_5 = val_5 - 1;
            val_8 = (this + (((long)(int)(index)) << 3)) + 32;
            val_6 = val_5 + 1;
            label_9:
            mem2[0] = this;
            if(val_6 < this)
            {
                goto label_17;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Item(int index)
        {
            if(this != null)
            {
                    SRF.SRList<T> val_1 = this + (((long)(int)(index)) << 3);
                return (SRDebugger.Profiler.ProfilerCameraListener)this;
            }
            
            System.IndexOutOfRangeException val_2 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Item(int index, T value)
        {
            if(this != null)
            {
                    SRF.SRList<T> val_1 = this + (((long)(int)(index)) << 2);
                mem2[0] = value;
                return;
            }
            
            System.IndexOutOfRangeException val_2 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeforeSerialize()
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(1152921505343392448 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(1152921505343392448 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = 1152921505343392448;
            UnityEngine.Debug.Log(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[OnBeforeSerialize] Count: {0}", args:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAfterDeserialize()
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(1152921505343392448 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(1152921505343392448 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = 1152921505343392448;
            UnityEngine.Debug.Log(message:  SRF.SRFStringExtensions.Fmt(formatString:  "[OnAfterDeserialize] Count: {0}", args:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddRange(System.Collections.Generic.IEnumerable<T> range)
        {
            var val_13;
            var val_15;
            var val_17;
            var val_18;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = range;
            label_20:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_13.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 160;
            if(this != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_12:
            val_17 = 0;
            val_18 = 43;
            if(val_13 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_13.Dispose();
            }
            
            if( == 43)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_13 = ???;
            val_18 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear(bool clean)
        {
            if(clean == false)
            {
                    return;
            }
            
            this = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 144;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clean()
        {
            var val_2;
            if(this == null)
            {
                    return;
            }
            
            val_2 = this;
            goto label_3;
            label_7:
            var val_1 = X21 + (-6415640640);
            val_2 = 1152921520182806001;
            mem2[0] = 0;
            label_3:
            if(val_2 < (X21 + 24))
            {
                goto label_7;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
        {
            var val_1;
            if(X21 != 0)
            {
                    return (System.Collections.ObjectModel.ReadOnlyCollection<T>)val_1;
            }
            
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 176;
            mem[1152921520182918040] = val_1;
            return (System.Collections.ObjectModel.ReadOnlyCollection<T>)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Expand()
        {
            var val_3;
            if(this != null)
            {
                    val_3 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished << 1, b:  32);
            }
            else
            {
                    val_3 = 32;
            }
            
            if((this != null) && (this >= 1))
            {
                    this.CopyTo(array:  __RuntimeMethodHiddenParam + 24 + 192, index:  0);
            }
            
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trim()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = this;
            if(val_10 < 1)
            {
                goto label_1;
            }
            
            val_11 = val_10;
            if(val_11 >= (__RuntimeMethodHiddenParam + 24 + 192 + 64))
            {
                    return;
            }
            
            val_12 = __RuntimeMethodHiddenParam + 24 + 192;
            val_13 = 0;
            goto label_8;
            label_15:
            var val_1 = val_12 + 0;
            val_13 = 1;
            mem2[0] = SRF.SRList<T>.__il2cppRuntimeField_byval_arg;
            label_8:
            val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_14 = __RuntimeMethodHiddenParam + 24 + 192;
            if(val_13 < val_10)
            {
                goto label_15;
            }
            
            goto label_16;
            label_1:
            val_12 = __RuntimeMethodHiddenParam + 24 + 192;
            val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192];
            val_14 = __RuntimeMethodHiddenParam + 24 + 192;
            label_16:
            val_10 = ???;
            val_11 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Sort(System.Comparison<T> comparer)
        {
            var val_1;
            var val_5 = 1;
            label_23:
            val_1 = 0;
            if(val_5 >= this)
            {
                goto label_1;
            }
            
            var val_1 = val_5 - 1;
            SRF.SRList<T> val_2 = this + (((long)(int)((1 - 1))) << 3);
            if(comparer >= 1)
            {
                    SRF.SRList<T> val_3 = this + (((long)(int)((1 - 1))) << 3);
                mem[1152921520743099160] = this;
                SRF.SRList<T> val_4 = this + (((long)(int)((1 - 1))) << 3);
                mem2[0] = val_1;
                val_1 = 1;
            }
            
            val_5 = val_5 + 1;
            goto label_23;
            label_1:
            if((val_1 & 1) != 0)
            {
                goto label_23;
            }
        
        }
    
    }

}
