using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoryboardHookUnityEngineUIButton : StoryboardHook
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button button;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type AutoAddComponentType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Reset()
        {
            this.Reset();
            this.button = this.GetComponent<UnityEngine.UI.Button>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type get_AutoAddComponentType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Connect(System.Action<P7.CanvasFlow.StoryboardHook> invokeTransition)
        {
            StoryboardHookUnityEngineUIButton.<>c__DisplayClass4_0 val_1 = new StoryboardHookUnityEngineUIButton.<>c__DisplayClass4_0();
            if(val_1 != null)
            {
                    .invokeTransition = invokeTransition;
            }
            else
            {
                    mem[16] = invokeTransition;
            }
            
            .<>4__this = this;
            this.button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void StoryboardHookUnityEngineUIButton.<>c__DisplayClass4_0::<Connect>b__0()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoryboardHookUnityEngineUIButton()
        {
        
        }
    
    }

}
