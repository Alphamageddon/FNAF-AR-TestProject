using UnityEngine;

namespace SRF.Service
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRServiceBase<T> : SRMonoBehaviourEx
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            goto __RuntimeMethodHiddenParam + 24 + 192;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            this.OnDestroy();
            goto __RuntimeMethodHiddenParam + 24 + 192 + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRServiceBase<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
