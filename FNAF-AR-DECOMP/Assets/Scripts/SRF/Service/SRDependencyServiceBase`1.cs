using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract System.Type[] Dependencies { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLoaded { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract System.Type[] get_Dependencies(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLoaded()
        {
            return (bool)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Log(string msg, UnityEngine.Object target)
        {
            UnityEngine.Debug.Log(message:  msg, context:  target);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            if(this != null)
            {
                    this.Start();
            }
            else
            {
                    this.Start();
            }
            
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnLoaded()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator LoadDependencies()
        {
            mem2[0] = this;
            return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRDependencyServiceBase<T>()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
