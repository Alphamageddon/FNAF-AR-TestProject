using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IObservable<T>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Subscribe(Mapbox.Utils.IObserver<T> observer); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Unsubscribe(Mapbox.Utils.IObserver<T> observer); // 0
    
    }

}
