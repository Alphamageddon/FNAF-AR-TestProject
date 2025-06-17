using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRDebuggerInit : SRMonoBehaviourEx
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            if(SRDebugger.Settings.Instance.IsEnabled == false)
            {
                    return;
            }
            
            SRDebug.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            UnityEngine.Object.Destroy(obj:  this.CachedGameObject);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebuggerInit()
        {
        
        }
    
    }

}
