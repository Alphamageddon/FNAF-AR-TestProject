using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CircularBuffer<T> : ICircularBuffer<T>, IEnumerable<T>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private T[] _buffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _head;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _tail;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Count>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T Item { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircularBuffer<T>(int capacity)
        {
            if((capacity & 2147483648) == 0)
            {
                    mem[1152921519927643360] = __RuntimeMethodHiddenParam + 24 + 192;
                mem[1152921519927643368] = 0;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  "capacity", message:  "must be positive");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Count(int value)
        {
            mem[1152921519927875568] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item)
        {
            var val_1 = W23 + 1;
            mem[1152921519927987560] = val_1 - ((val_1 / (X22 + 24)) * (X22 + 24));
            var val_4 = X22 + (((long)(int)((W23 + 1) - (((W23 + 1) / X22 + 24) * X22 + 24))) << 4);
            mem2[0] = item.x;
            mem2[0] = item.y;
            if(this == ((long)(int)((W23 + 1) - (((W23 + 1) / X22 + 24) * X22 + 24)) + 24))
            {
                    Mapbox.Utils.CircularBuffer<T> val_6 = __RuntimeMethodHiddenParam + 24;
                val_6 = 1152921519927987537 - ((1152921519927987537 / val_6) * val_6);
                mem[1152921519927987564] = val_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T get_Item(int index)
        {
            if(((index & 2147483648) == 0) && (mem[69746712] > index))
            {
                    index = W23 - index;
                if(this < mem[69746712])
            {
                    return new Mapbox.Utils.Vector2d() {x = mem[-29667921120], y = mem[-29667921112]};
            }
            
                return new Mapbox.Utils.Vector2d() {x = mem[-29667921120], y = mem[-29667921112]};
            }
            
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException(paramName:  "index: "("index: ") + index.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int mod(int x, int m)
        {
            int val_1 = x / m;
            val_1 = x - (val_1 * m);
            val_1 = val_1 + m;
            return (int)val_1 - ((val_1 / m) * m);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            mem2[0] = this;
            return (System.Collections.Generic.IEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<T> GetEnumerable()
        {
            mem2[0] = this;
            return (System.Collections.Generic.IEnumerable<T>)__RuntimeMethodHiddenParam + 24 + 192 + 56;
        }
    
    }

}
