using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
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
        public abstract T get_Item(int index); // 0
    
    }

}
