using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TImpl _rootObject;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract string SceneName { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TImpl RootObject { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLoaded { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract string get_SceneName(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected TImpl get_RootObject()
        {
            return (object)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLoaded()
        {
            return UnityEngine.Object.op_Inequality(x:  this, y:  0);
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
        protected override void OnDestroy()
        {
            if((this & 1) != 0)
            {
                    UnityEngine.Object.Destroy(obj:  gameObject);
            }
            
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnLoaded()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator LoadCoroutine()
        {
            mem2[0] = this;
            return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 24 + 192 + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRSceneServiceBase<T, TImpl>()
        {
            if(this == null)
            {
                
            }
        
        }
    
    }

}
