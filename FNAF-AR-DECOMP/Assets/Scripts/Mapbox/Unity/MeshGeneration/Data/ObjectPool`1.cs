using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectPool<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<T> _objects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<T> _objectGenerator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectPool<T>(System.Func<T> objectGenerator)
        {
            if(objectGenerator != null)
            {
                    mem[1152921519770254480] = __RuntimeMethodHiddenParam + 24 + 192;
                mem[1152921519770254488] = objectGenerator;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "objectGenerator");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public T GetObject()
        {
            var val_2;
            if(X21 >= 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 24];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            }
            else
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 32];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Put(T item)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            if(X19 == 0)
            {
                
            }
        
        }
    
    }

}
