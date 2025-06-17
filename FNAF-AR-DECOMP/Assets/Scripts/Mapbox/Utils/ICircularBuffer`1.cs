using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ICircularBuffer<T>
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int Count { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T Item { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int get_Count(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Add(T item); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract T get_Item(int index); // 0
    
    }

}
