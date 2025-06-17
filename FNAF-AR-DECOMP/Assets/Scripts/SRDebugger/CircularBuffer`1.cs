using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly T[] _buffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _end;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _start;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Capacity { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFull { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEmpty { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Item { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircularBuffer<T>(int capacity)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircularBuffer<T>(int capacity, T[] items)
        {
            string val_5;
            string val_6;
            var val_7;
            if(capacity <= 0)
            {
                goto label_2;
            }
            
            if(items == null)
            {
                goto label_3;
            }
            
            if(items.Length > capacity)
            {
                goto label_4;
            }
            
            mem[1152921520791335328] = __RuntimeMethodHiddenParam + 24 + 192;
            System.Array.Copy(sourceArray:  items, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192, length:  items.Length);
            mem[1152921520791335340] = items.Length;
            mem[1152921520791335344] = 0;
            mem[1152921520791335336] = (items.Length == capacity) ? 0 : items.Length;
            return;
            label_2:
            val_5 = "Circular buffer cannot have negative or zero capacity.";
            val_6 = "capacity";
            goto label_7;
            label_3:
            System.ArgumentNullException val_2 = null;
            val_7 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "items");
            goto label_8;
            label_4:
            System.ArgumentException val_3 = null;
            val_5 = "Too many items to fit circular buffer";
            val_6 = "items";
            label_7:
            val_7 = val_3;
            val_3 = new System.ArgumentException(message:  val_5, paramName:  val_6);
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Capacity()
        {
            if(X19 != 0)
            {
                    return (int)X19 + 24;
            }
            
            return (int)X19 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsFull()
        {
            return (bool)(this == this) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsEmpty()
        {
            return (bool)(this == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Item(int index)
        {
            if((this & 1) != 0)
            {
                goto label_2;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 32) <= index)
            {
                goto label_3;
            }
            
            int val_1 = index + (-7957933440);
            return (SRDebugger.Services.ConsoleEntry)(index + -7957933440) + 32;
            label_2:
            string val_2 = System.String.Format(format:  "Cannot access index {0}. Buffer is empty", arg0:  index);
            goto label_6;
            label_3:
            label_6:
            System.IndexOutOfRangeException val_4 = new System.IndexOutOfRangeException(message:  System.String.Format(format:  "Cannot access index {0}. Buffer size is {1}", arg0:  index, arg1:  __RuntimeMethodHiddenParam + 24 + 192 + 32));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Item(int index, T value)
        {
            if((this & 1) != 0)
            {
                goto label_2;
            }
            
            if((value.UpdateTime + 192 + 32) <= index)
            {
                goto label_3;
            }
            
            int val_1 = index + (-31826414080);
            mem2[0] = V0.16B;
            mem2[0] = V1.16B;
            mem2[0] = V2.16B;
            mem2[0] = V3.16B;
            return;
            label_2:
            string val_2 = System.String.Format(format:  "Cannot access index {0}. Buffer is empty", arg0:  index);
            goto label_6;
            label_3:
            label_6:
            System.IndexOutOfRangeException val_4 = new System.IndexOutOfRangeException(message:  System.String.Format(format:  "Cannot access index {0}. Buffer size is {1}", arg0:  index, arg1:  value.UpdateTime + 192 + 32));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            mem[1152921520792281384] = 0;
            mem[1152921520792281392] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            mem2[0] = this;
            return (System.Collections.Generic.IEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Front()
        {
            var val_1 = __RuntimeMethodHiddenParam + (-9223371907368611712);
            return (SRDebugger.Services.ConsoleEntry)(__RuntimeMethodHiddenParam + -9223371907368611712) + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Back()
        {
            SRDebugger.Services.ProfilerFrame val_0;
            if(==0)
            {
                goto label_2;
            }
            
            label_6:
            var val_1 = __RuntimeMethodHiddenParam + 2231893984;
            return val_0;
            label_2:
            if(__RuntimeMethodHiddenParam != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PushBack(T item)
        {
            var val_1 = X25 + ((X24) << 3);
            mem2[0] = item;
            var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 88;
            if((this & 1) != 0)
            {
                    mem[1152921520792853616] = val_2;
                return;
            }
            
            val_2 = val_2 + 1;
            mem[1152921520792853612] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PushFront(T item)
        {
            if((this & 1) != 0)
            {
                    mem[1152921520792973752] = 1152921520793005728;
                mem[1152922038750053824] = V0.16B;
                mem[1152922038750053832] = V1.16B;
                mem[1152922038750053840] = V2.16B;
                mem[1152922038750053848] = V3.16B;
                return;
            }
            
            mem[1152922038749061824] = V0.16B;
            mem[1152922038749061832] = V1.16B;
            mem[1152922038749061840] = V2.16B;
            mem[1152922038749061848] = V3.16B;
            mem[1152921520792973756] = 1152922038749061793;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopBack()
        {
            var val_1 = __RuntimeMethodHiddenParam + 517959775488;
            mem2[0] = 0;
            mem2[0] = 0;
            val_1 = val_1 - 1;
            mem[1152921520793089964] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopFront()
        {
            var val_1 = X23 + ((X22) << 3);
            mem2[0] = 0;
            var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 88;
            val_2 = val_2 - 1;
            mem[1152921520793201964] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T[] ToArray()
        {
            var val_3;
            System.Array val_4;
            mem2[0] = this;
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 104 + 24];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 104 + 24;
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 120;
            if(val_3 <= 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 104 + 24];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 104 + 24;
            }
            
            mem2[0] = this;
            mem2[0] = val_4;
            if(val_3 < 1)
            {
                    return (T[])__RuntimeMethodHiddenParam + 24 + 192;
            }
            
            do
            {
                var val_1 = (__RuntimeMethodHiddenParam + 24 + 192 + 104) + 0;
                val_4 = (__RuntimeMethodHiddenParam + 24 + 192 + 104 + 0) + 32.emailUIDataHandler;
                System.Array.Copy(sourceArray:  val_4, sourceIndex:  -351133216, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192, destinationIndex:  0, length:  -351133216);
            }
            while((0 + 1) < (__RuntimeMethodHiddenParam + 24 + 192 + 104 + 24));
            
            return (T[])__RuntimeMethodHiddenParam + 24 + 192;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  message);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Increment(ref int index)
        {
            int val_1 = index + 1;
            index = val_1;
            if(val_1 != this)
            {
                    return;
            }
            
            index = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Decrement(ref int index)
        {
            int val_1 = index;
            if(val_1 == 0)
            {
                    val_1 = this;
                index = val_1;
            }
            
            index = 1152921522921971135;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int InternalIndex(int index)
        {
            int val_1 = index;
            var val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            val_1 = this - val_1;
            if(val_1 <= val_1)
            {
                    var val_2 = this;
                val_1 = val_1 - val_2;
            }
            
            val_2 = val_1 + W22;
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.ArraySegment<T> ArrayOne()
        {
            var val_3;
            var val_1 = W8 - W19;
            if()
            {
                
            }
            else
            {
                    val_3 = W19;
                var val_2 = (X20 + 24) - val_3;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.ArraySegment<T> ArrayTwo()
        {
            if(W9 >= W3)
            {
                    return 0;
            }
            
            return 0;
        }
    
    }

}
