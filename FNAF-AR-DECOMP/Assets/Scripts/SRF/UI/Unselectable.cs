using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _suspectedSelected;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
        {
            this._suspectedSelected = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._suspectedSelected == false)
            {
                    return;
            }
            
            if(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject == this.CachedGameObject)
            {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(selected:  0);
            }
            
            this._suspectedSelected = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Unselectable()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
