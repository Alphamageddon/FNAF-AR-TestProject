using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DisableableButtonChildCell : MonoBehaviour, IDisableableChildCell
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ClassName = "DisableableButtonChildCell";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _target;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ChildCellDisabler _disabler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            GameUI.ChildCellDisabler val_7;
            this._target.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DisableableButtonChildCell::OnClicked()));
            UnityEngine.Transform val_4 = this.transform.parent;
            if(val_4 != null)
            {
                    val_7 = val_4.GetComponent<GameUI.ChildCellDisabler>();
            }
            else
            {
                    val_7 = 0;
            }
            
            this._disabler = val_7;
            if(val_7 == 0)
            {
                    ConsoleLogger.LogError(className:  "DisableableButtonChildCell", functionName:  "Invoke", logString:  "Attempt to invoke childCellDisabler that is already in a disabled state");
            }
            
            if(this._disabler == null)
            {
                    return;
            }
            
            this._disabler.OnChildAdded(child:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(this._disabler == null)
            {
                    return;
            }
            
            this._disabler.OnChildRemoved(child:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateEnableState(bool state)
        {
            state = state;
            this._target.enabled = state;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClicked()
        {
            if(this._disabler == null)
            {
                    return;
            }
            
            this._disabler.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DisableableButtonChildCell()
        {
        
        }
    
    }

}
