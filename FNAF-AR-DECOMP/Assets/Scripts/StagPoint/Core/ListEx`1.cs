using UnityEngine;

namespace StagPoint.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ListEx<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Queue<object> pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DEFAULT_CAPACITY = 128;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T[] items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isElementTypeValueType;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int Capacity { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsReadOnly { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Item { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal T[] Items { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClearPool()
        {
            var val_2;
            var val_3;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            __RuntimeMethodHiddenParam + 24 + 192 + 184.Clear();
            __RuntimeMethodHiddenParam + 24 + 192 + 184.TrimExcess();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            if(48 == 48)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.Core.ListEx<T> Obtain()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_5 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_6 & 1) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184.Count) == 0)
            {
                goto label_22;
            }
            
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_7 & 1) == 0)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            object val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 184.Dequeue();
            if(val_3 == null)
            {
                goto label_36;
            }
            
            val_8 = val_3;
            if(val_8 != null)
            {
                goto label_38;
            }
            
            label_36:
            val_8 = 0;
            goto label_38;
            label_22:
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
            val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_9 = __RuntimeMethodHiddenParam + 24 + 294;
            val_10 = __RuntimeMethodHiddenParam + 24;
            if((val_9 & 1) == 0)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 24];
                val_10 = __RuntimeMethodHiddenParam + 24;
                val_9 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_9 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            label_38:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            if(64 == 64)
            {
                    return (StagPoint.Core.ListEx<T>)val_8;
            }
            
            if(0 == 0)
            {
                    return (StagPoint.Core.ListEx<T>)val_8;
            }
            
            return (StagPoint.Core.ListEx<T>)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static StagPoint.Core.ListEx<T> Obtain(int capacity)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            val_3 = __RuntimeMethodHiddenParam + 24;
            if((val_2 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24];
                val_3 = __RuntimeMethodHiddenParam + 24;
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 294;
            val_5 = __RuntimeMethodHiddenParam + 24;
            if((val_4 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24];
                val_5 = __RuntimeMethodHiddenParam + 24;
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 294];
                val_4 = __RuntimeMethodHiddenParam + 24 + 294;
            }
            
            if((val_4 & 1) != 0)
            {
                    return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 24;
            }
            
            return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Release()
        {
            var val_2;
            var val_3;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_2 & 1) == 0)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184, lockTaken: ref  val_1);
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            }
            
            __RuntimeMethodHiddenParam + 24 + 192 + 184.Enqueue(item:  this);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 24 + 192 + 184);
            }
            
            if(45 == 45)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ListEx<T>()
        {
            mem[1152921520166628192] = __RuntimeMethodHiddenParam + 24 + 192 + 48;
            mem[1152921520166628204] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 56}).IsValueType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ListEx<T>(System.Collections.Generic.IList<T> listToClone)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ListEx<T>(int capacity)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int get_Capacity()
        {
            if(X19 != 0)
            {
                    return (int)X19 + 24;
            }
            
            return (int)X19 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsReadOnly()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Item(int index)
        {
            if(((index & 2147483648) == 0) && (0 >= index))
            {
                    StagPoint.Core.ListEx<T> val_1 = this + (((long)(int)(index)) << 3);
                return 0;
            }
            
            System.IndexOutOfRangeException val_2 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Item(int index, T value)
        {
            if(((index & 2147483648) == 0) && (0 >= index))
            {
                    StagPoint.Core.ListEx<T> val_1 = this + (((long)(int)(index)) << 3);
                mem2[0] = value;
                return;
            }
            
            System.IndexOutOfRangeException val_2 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal T[] get_Items()
        {
            return (T[])this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Enqueue(T item)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  X19, lockTaken: ref  val_1);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  X19);
            }
            
            if(36 == 36)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Dequeue()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  69746688, lockTaken: ref  val_1);
            if(true == 0)
            {
                goto label_1;
            }
            
            label_13:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  69746688);
            }
            
            if(63 == 63)
            {
                    return (object)X22 + 32;
            }
            
            if(0 == 0)
            {
                    return (object)X22 + 32;
            }
            
            return (object)X22 + 32;
            label_1:
            new System.IndexOutOfRangeException() = new System.IndexOutOfRangeException();
            if(0 != 1)
            {
                goto label_12;
            }
            
            goto label_13;
            label_12:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Pop()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  69746688, lockTaken: ref  val_1);
            if(W22 == 0)
            {
                goto label_1;
            }
            
            var val_3 = X21 + (((long)(int)((W22 - 1))) << 3);
            var val_4 = X25 + (((long)(int)((W22 - 1))) << 3);
            mem2[0] = 0;
            mem[1152921520167925736] = W22 - 1;
            label_15:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  69746688);
            }
            
            if(93 == 93)
            {
                    return (object)(X21 + ((long)(int)((W22 - 1))) << 3) + 32;
            }
            
            if(0 == 0)
            {
                    return (object)(X21 + ((long)(int)((W22 - 1))) << 3) + 32;
            }
            
            return (object)(X21 + ((long)(int)((W22 - 1))) << 3) + 32;
            label_1:
            new System.IndexOutOfRangeException() = new System.IndexOutOfRangeException();
            if(0 != 1)
            {
                goto label_14;
            }
            
            goto label_15;
            label_14:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<T> Clone()
        {
            System.Array.Copy(sourceArray:  X21, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 8 + 16, destinationIndex:  0, length:  0);
            mem2[0] = this;
            return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reverse()
        {
            System.Array.Reverse(array:  X8, index:  0, length:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Sort()
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 96;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Sort(System.Collections.Generic.IComparer<T> comparer)
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 96;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Sort(System.Comparison<T> comparison)
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = comparison;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 112 + 294];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 112 + 294;
            if((val_11 & 1) == 0)
            {
                    val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 112 + 294];
                val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 112 + 294;
            }
            
            val_9 = val_10;
            val_10 = 61;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            label_16:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9.Dispose();
            label_17:
            if(61 == 61)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
            return;
            label_1:
            if(0 != 1)
            {
                goto label_15;
            }
            
            if((new System.ArgumentNullException(paramName:  "comparison")) != null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EnsureCapacity(int Size)
        {
            var val_9;
            var val_10;
            val_9 = this;
            val_10 = Size;
            if((X22 + 24) >= val_10)
            {
                    return;
            }
            
            val_9 = ???;
            var val_2 = (val_10 < 0) ? (val_10 + 127) : (val_10);
            val_2 = val_2 & 4294967168;
            Size = val_2 + 128;
            val_10 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 120;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShrinkTo(int Size)
        {
            Size = Size - 1;
            int val_1 = W22 - Size;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 128;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddRange(StagPoint.Core.ListEx<T> list)
        {
            var val_1 = W23 + W20;
            var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            System.Array.Copy(sourceArray:  this, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 32, destinationIndex:  0, length:  W20);
            val_2 = val_2 + W20;
            mem[1152921520168855656] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddRange(System.Collections.Generic.IList<T> list)
        {
            var val_7;
            var val_8;
            var val_6 = 0;
            val_6 = val_6 + 1;
            System.Collections.Generic.IList<T> val_2 = W23 + list;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 32];
            val_8 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            if(list < 1)
            {
                    return;
            }
            
            do
            {
                mem[1152921520168975848] = W25 + 1;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = 0;
                val_7 = 0 + 1;
                var val_5 = X26 + ((X25) << 3);
                mem2[0] = list;
            }
            while(val_7 != list);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddRange(T[] list)
        {
            int val_1 = W23 + list.Length;
            int val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            System.Array.Copy(sourceArray:  list, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 32, destinationIndex:  0, length:  list.Length);
            val_2 = val_2 + list.Length;
            mem[1152921520169128808] = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IndexOf(T item)
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 152;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Insert(int index, T item)
        {
            var val_1 = W23 + 1;
            if()
            {
                    System.Array.Copy(sourceArray:  this, sourceIndex:  index, destinationArray:  this, destinationIndex:  index + 1, length:  (__RuntimeMethodHiddenParam + 24 + 192 + 32) - index);
            }
            
            var val_4 = __RuntimeMethodHiddenParam + (((long)(int)(index)) << 3);
            mem2[0] = item;
            val_4 = val_4 + 1;
            mem[1152921520169401960] = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InsertRange(int index, T[] array)
        {
            var val_6;
            if(array != null)
            {
                    if(((index & 2147483648) == 0) && (true >= index))
            {
                    int val_1 = true + array.Length;
                if(true > index)
            {
                    int val_6 = array.Length;
                System.Array.Copy(sourceArray:  this, sourceIndex:  index, destinationArray:  this, destinationIndex:  val_6 + index, length:  true - index);
            }
            
                array.CopyTo(array:  index, index:  index);
                val_6 = val_6 + array.Length;
                mem[1152921520169564216] = val_6;
                return;
            }
            
                System.ArgumentOutOfRangeException val_4 = null;
                val_6 = val_4;
                val_4 = new System.ArgumentOutOfRangeException(paramName:  "index");
            }
            else
            {
                    System.ArgumentNullException val_5 = null;
                val_6 = val_5;
                val_5 = new System.ArgumentNullException(paramName:  "items");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InsertRange(int index, StagPoint.Core.ListEx<T> list)
        {
            var val_6;
            bool val_6 = true;
            if(list != null)
            {
                    if(((index & 2147483648) == 0) && (val_6 >= index))
            {
                    var val_1 = (__RuntimeMethodHiddenParam + 24 + 192) + val_6;
                int val_2 = val_6 - index;
                if(val_6 > index)
            {
                    System.Array.Copy(sourceArray:  this, sourceIndex:  index, destinationArray:  this, destinationIndex:  val_6 + index, length:  val_2);
            }
            
                System.Array.Copy(sourceArray:  this, sourceIndex:  0, destinationArray:  this, destinationIndex:  index, length:  val_2);
                val_6 = (__RuntimeMethodHiddenParam + 24 + 192) + val_6;
                mem[1152921520169734584] = val_6;
                return;
            }
            
                System.ArgumentOutOfRangeException val_4 = null;
                val_6 = val_4;
                val_4 = new System.ArgumentOutOfRangeException(paramName:  "index");
            }
            else
            {
                    System.ArgumentNullException val_5 = null;
                val_6 = val_5;
                val_5 = new System.ArgumentNullException(paramName:  "items");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveAll(System.Predicate<T> predicate)
        {
            if(W8 < 1)
            {
                    return;
            }
            
            label_7:
            label_5:
            var val_1 = X23 + 0;
            if((predicate & 1) == 0)
            {
                goto label_4;
            }
            
            if(0 < (__RuntimeMethodHiddenParam + 24 + 192 + 80))
            {
                goto label_5;
            }
            
            return;
            label_4:
            if((0 + 1) < W9)
            {
                goto label_7;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveAt(int index)
        {
            var val_3;
            if(true > index)
            {
                    val_3 = true - 1;
                mem[1152921520169984184] = val_3;
                if(true > index)
            {
                    index = index + 1;
                System.Array.Copy(sourceArray:  30602, sourceIndex:  index, destinationArray:  30602, destinationIndex:  index, length:  val_3 - index);
            }
            
                StagPoint.Core.ListEx<T> val_2 = this + (((long)(int)((true - 1))) << 3);
                mem2[0] = 0;
                return;
            }
            
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveRange(int index, int length)
        {
            int val_1 = index | length;
            if(((val_1 & 2147483648) == 0) && ((val_1 - index) >= length))
            {
                    if(val_1 < 1)
            {
                    return;
            }
            
                val_1 = val_1 - length;
                mem[1152921520170105400] = val_1;
                if(val_1 > 1)
            {
                    index = length + index;
                System.Array.Copy(sourceArray:  30603, sourceIndex:  index, destinationArray:  30603, destinationIndex:  index, length:  val_1 - index);
            }
            
                if(val_1 != 0)
            {
                    return;
            }
            
                System.Array.Clear(array:  30603, index:  index, length:  length);
                return;
            }
            
            System.ArgumentOutOfRangeException val_4 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item)
        {
            var val_1 = W22 + 1;
            mem[1152921520170225592] = __RuntimeMethodHiddenParam + 1;
            var val_3 = X22 + ((__RuntimeMethodHiddenParam) << 3);
            mem2[0] = item;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item0, T item1)
        {
            var val_1 = W23 + 2;
            mem[1152921520170349880] = __RuntimeMethodHiddenParam + 1;
            var val_3 = X23 + ((__RuntimeMethodHiddenParam) << 3);
            mem2[0] = item0;
            mem[1152921520170349880] = item0 + 1;
            var val_5 = __RuntimeMethodHiddenParam + ((item0) << 3);
            mem2[0] = item1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item0, T item1, T item2)
        {
            var val_1 = W24 + 3;
            mem[1152921520170482360] = __RuntimeMethodHiddenParam + 1;
            var val_3 = X24 + ((__RuntimeMethodHiddenParam) << 3);
            mem2[0] = item0;
            mem[1152921520170482360] = item0 + 1;
            var val_5 = __RuntimeMethodHiddenParam + ((item0) << 3);
            mem2[0] = item1;
            mem[1152921520170482360] = item1 + 1;
            object val_7 = item0 + ((item1) << 3);
            mem2[0] = item2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            if(W8 == 0)
            {
                    System.Array.Clear(array:  X20, index:  0, length:  X20 + 24);
            }
            
            mem[1152921520170606648] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TrimExcess()
        {
            goto __RuntimeMethodHiddenParam + 24 + 192 + 120;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Contains(T item)
        {
            var val_3;
            var val_4;
            var val_5;
            if(item == null)
            {
                goto label_0;
            }
            
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 176;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 176) < 1)
            {
                goto label_8;
            }
            
            val_4 = 0;
            label_6:
            var val_1 = X22 + 0;
            if((val_3 & 1) != 0)
            {
                goto label_11;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < val_3)
            {
                goto label_6;
            }
            
            goto label_8;
            label_0:
            if(W8 < 1)
            {
                goto label_8;
            }
            
            var val_3 = 0;
            label_12:
            var val_2 = X21 + 0;
            if(((X21 + 0) + 32) == 0)
            {
                goto label_11;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < ((X21 + 0) + 32))
            {
                goto label_12;
            }
            
            label_8:
            val_5 = 0;
            return (bool)val_5;
            label_11:
            val_5 = 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(T[] array)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(T[] array, int arrayIndex)
        {
            System.Array.Copy(sourceArray:  X9, sourceIndex:  0, destinationArray:  array, destinationIndex:  arrayIndex, length:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CopyTo(int sourceIndex, T[] dest, int destIndex, int length)
        {
            string val_6;
            var val_7;
            if((length + sourceIndex) > true)
            {
                goto label_1;
            }
            
            if(dest == null)
            {
                goto label_2;
            }
            
            if((length + destIndex) > dest.Length)
            {
                goto label_3;
            }
            
            System.Array.Copy(sourceArray:  30593, sourceIndex:  sourceIndex, destinationArray:  dest, destinationIndex:  destIndex, length:  length);
            return;
            label_1:
            val_6 = "sourceIndex";
            goto label_4;
            label_2:
            System.ArgumentNullException val_3 = null;
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "dest");
            goto label_5;
            label_3:
            System.IndexOutOfRangeException val_4 = null;
            val_6 = "destIndex";
            label_4:
            val_7 = val_4;
            val_4 = new System.IndexOutOfRangeException(message:  val_6);
            label_5:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Remove(T item)
        {
            var val_1;
            if(this != 1)
            {
                    val_1 = 1;
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<T> ToList()
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 216) != 0)
            {
                    return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 24 + 192 + 216;
            }
            
            return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 24 + 192 + 216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T[] ToArray()
        {
            System.Array.Copy(sourceArray:  __RuntimeMethodHiddenParam + 24 + 192 + 48 + 294, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 24 + 192 + 48, destinationIndex:  0, length:  0);
            return (T[])__RuntimeMethodHiddenParam + 24 + 192 + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T[] ToArray(int index, int length)
        {
            if((__RuntimeMethodHiddenParam + 24 + 192 + 48 + 294) < 1)
            {
                    return (T[])__RuntimeMethodHiddenParam + 24 + 192 + 48;
            }
            
            return (T[])__RuntimeMethodHiddenParam + 24 + 192 + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<T> GetRange(int index, int length)
        {
            if(this != null)
            {
                    return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
            }
            
            return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Any(System.Func<T, bool> predicate)
        {
            var val_2;
            var val_3;
            if(W8 < 1)
            {
                goto label_0;
            }
            
            val_2 = 0;
            label_5:
            var val_1 = X22 + 0;
            if((predicate & 1) != 0)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (__RuntimeMethodHiddenParam + 24 + 192 + 256))
            {
                goto label_5;
            }
            
            label_0:
            val_3 = 0;
            return (bool)val_3;
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T First()
        {
            if(true != 0)
            {
                    if(true != 0)
            {
                    return 0;
            }
            
                return 0;
            }
            
            System.IndexOutOfRangeException val_1 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T FirstOrDefault()
        {
            if(W8 < 1)
            {
                    return 0;
            }
            
            if((X19 + 24) != 0)
            {
                    return (object)X19 + 32;
            }
            
            return (object)X19 + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T FirstOrDefault(System.Func<T, bool> predicate)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = __RuntimeMethodHiddenParam;
            if(W8 < 1)
            {
                goto label_0;
            }
            
            val_4 = 0;
            label_5:
            var val_1 = X22 + 0;
            if((predicate & 1) != 0)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < (__RuntimeMethodHiddenParam + 24 + 192 + 256))
            {
                goto label_5;
            }
            
            label_0:
            val_5 = 0;
            return (object)val_5;
            label_4:
            var val_2 = val_3 + 0;
            val_5 = mem[(__RuntimeMethodHiddenParam + 0) + 32];
            val_5 = (__RuntimeMethodHiddenParam + 0) + 32;
            return (object)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Last()
        {
            if(!=0)
            {
                    if(69746687 < true)
            {
                    return 0;
            }
            
                return 0;
            }
            
            System.IndexOutOfRangeException val_1 = new System.IndexOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T LastOrDefault()
        {
            var val_3;
            if(W20 != 0)
            {
                    var val_1 = W20 - 1;
                var val_2 = X19 + (((long)(int)((W20 - 1))) << 3);
                val_3 = mem[(X19 + ((long)(int)((W20 - 1))) << 3) + 32];
                val_3 = (X19 + ((long)(int)((W20 - 1))) << 3) + 32;
                return (object)val_3;
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T LastOrDefault(System.Func<T, bool> predicate)
        {
            var val_2;
            if(W8 >= 1)
            {
                    var val_3 = 0;
                val_2 = 0;
                do
            {
                var val_1 = X23 + 0;
                if((predicate & 1) != 0)
            {
                    val_2 = mem[(val_2 + 0) + 32];
                val_2 = (val_2 + 0) + 32;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < (val_2 + 0));
            
                return (object)val_2;
            }
            
            val_2 = 0;
            return (object)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<T> Where(System.Func<T, bool> predicate)
        {
            var val_3;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 88) < 1)
            {
                    return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
            }
            
            var val_3 = 0;
            do
            {
                var val_1 = X23 + 0;
                val_3 = mem[(X23 + 0) + 32];
                val_3 = (X23 + 0) + 32;
                if((predicate & 1) != 0)
            {
                    var val_2 = val_3 + 0;
                val_3 = mem[((X23 + 0) + 32 + 0) + 32];
                val_3 = ((X23 + 0) + 32 + 0) + 32;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < (__RuntimeMethodHiddenParam + 24 + 192 + 72));
            
            return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Matching(System.Func<T, bool> predicate)
        {
            var val_3 = 0;
            if(W8 < 1)
            {
                    return (int)val_3;
            }
            
            var val_3 = 0;
            do
            {
                var val_1 = X23 + 0;
                val_3 = val_3 + 1;
                val_3 = val_3 + (predicate & 1);
            }
            while(val_3 < (__RuntimeMethodHiddenParam + 24 + 192 + 256));
            
            return (int)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<TResult> Select<TResult>(System.Func<T, TResult> selector)
        {
            var val_2;
            if((__RuntimeMethodHiddenParam + 48 + 8) < 1)
            {
                    return (StagPoint.Core.ListEx<TResult>)__RuntimeMethodHiddenParam + 48;
            }
            
            var val_2 = 0;
            do
            {
                var val_1 = X23 + 0;
                val_2 = selector;
                val_2 = val_2 + 1;
            }
            while(val_2 < (__RuntimeMethodHiddenParam + 48 + 24));
            
            return (StagPoint.Core.ListEx<TResult>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<T> Concat(StagPoint.Core.ListEx<T> list)
        {
            var val_1 = W24 + W23;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 8) == 0)
            {
                    return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
            }
            
            return (StagPoint.Core.ListEx<T>)__RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StagPoint.Core.ListEx<TResult> Convert<TResult>()
        {
            if((__RuntimeMethodHiddenParam + 48 + 8) < 1)
            {
                    return (StagPoint.Core.ListEx<TResult>)__RuntimeMethodHiddenParam + 48;
            }
            
            var val_5 = 0;
            label_13:
            var val_1 = X22 + 0;
            object val_3 = System.Convert.ChangeType(value:  (X22 + 0) + 32, conversionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 16}));
            if(val_3 != null)
            {
                    if(val_3 != null)
            {
                goto label_12;
            }
            
            }
            
            label_12:
            val_5 = val_5 + 1;
            if(val_5 < (__RuntimeMethodHiddenParam + 48))
            {
                goto label_13;
            }
            
            return (StagPoint.Core.ListEx<TResult>)__RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ForEach(System.Action<T> action)
        {
            goto label_0;
            label_5:
            var val_1 = X22 + 0;
            0 = 1;
            label_0:
            if(0 < this)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 296 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 296 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 296 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 296 + 294;
            }
            
            if(((val_1 & 512) != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 296 + 216) == 0))
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 296 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 296 + 294;
            if((val_1 & 1) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 296 + 294];
                val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 296 + 294;
            }
            
            if(((val_1 & 512) != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 296 + 216) == 0))
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ListEx<T>()
        {
            mem2[0] = new System.Collections.Generic.Queue<System.Object>(capacity:  1024);
        }
    
    }

}
