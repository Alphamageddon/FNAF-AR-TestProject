using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShuffleBag<T> : IEnumerable<T>, IEnumerable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Rand _rand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<T> _items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _index;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Count()
        {
            if(X19 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShuffleBag<T>()
        {
            null = null;
            mem[1152921519521004976] = Dest.Math.Rand.Instance;
            mem[1152921519521004984] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShuffleBag<T>(int capacity)
        {
            null = null;
            mem[1152921519521116976] = Dest.Math.Rand.Instance;
            mem[1152921519521116984] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShuffleBag<T>(Dest.Math.Rand rand)
        {
            mem[1152921519521233072] = rand;
            mem[1152921519521233080] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShuffleBag<T>(Dest.Math.Rand rand, int capacity)
        {
            mem[1152921519521353264] = rand;
            mem[1152921519521353272] = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(T item, uint count = 1)
        {
            goto label_0;
            label_2:
            0 = 1;
            label_0:
            if(0 < count)
            {
                goto label_2;
            }
            
            mem[1152921519521473472] = X23 - 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T NextItem()
        {
            if(W22 > 0)
            {
                    int val_2 = X21.NextInt(max:  W22 + 1);
                var val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 48;
                val_4 = val_4 - 1;
                mem[1152921519521589568] = val_4;
                return (object)X21;
            }
            
            mem[1152921519521589568] = X21 - 1;
            if(X21 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            mem[1152921519521701568] = X20 - 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            mem[1152921519521813568] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            mem2[0] = this;
            return (System.Collections.Generic.IEnumerator<T>)__RuntimeMethodHiddenParam + 24 + 192 + 64;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
