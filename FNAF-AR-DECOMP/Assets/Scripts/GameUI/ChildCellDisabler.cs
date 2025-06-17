using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChildCellDisabler : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ClassName = "ChildCellDisabler";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _disableTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.IDisableableChildCell> _children;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDisabling;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnChildAdded(GameUI.IDisableableChildCell child)
        {
            this._children.Add(item:  child);
            var val_3 = 0;
            val_3 = val_3 + 1;
            public System.Void System.Collections.Generic.List<GameUI.IDisableableChildCell>::Add(GameUI.IDisableableChildCell item) = 0;
            child.UpdateEnableState(state:  (this._isDisabling == false) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnChildRemoved(GameUI.IDisableableChildCell child)
        {
            bool val_1 = this._children.Remove(item:  child);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Invoke()
        {
            var val_6;
            var val_7;
            if(this._isDisabling != false)
            {
                    ConsoleLogger.LogError(className:  "ChildCellDisabler", functionName:  "Invoke", logString:  "Attempt to invoke childCellDisabler that is already in a disabled state");
            }
            
            this._isDisabling = true;
            val_6 = 0;
            goto label_4;
            label_12:
            val_7 = public GameUI.IDisableableChildCell System.Collections.Generic.List<GameUI.IDisableableChildCell>::get_Item(int index);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 0;
            this._children.Item[0].UpdateEnableState(state:  false);
            val_6 = 1;
            label_4:
            if(val_6 < this._children.Count)
            {
                goto label_12;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.WaitThenReenable(delay:  this._disableTime));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator WaitThenReenable(float delay)
        {
            ChildCellDisabler.<WaitThenReenable>d__7 val_1 = new ChildCellDisabler.<WaitThenReenable>d__7();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .delay = delay;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChildCellDisabler()
        {
            this._children = new System.Collections.Generic.List<GameUI.IDisableableChildCell>();
        }
    
    }

}
