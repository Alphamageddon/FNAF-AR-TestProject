using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameObjectClicked : IButtonClick
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <buttonClicked>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button <button>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool buttonClicked { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button button { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_buttonClicked()
        {
            return (bool)this.<buttonClicked>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_buttonClicked(bool value)
        {
            this.<buttonClicked>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button get_button()
        {
            return (UnityEngine.UI.Button)this.<button>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_button(UnityEngine.UI.Button value)
        {
            this.<button>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameObjectClicked(UnityEngine.GameObject gameObject)
        {
            UnityEngine.UI.Button val_10;
            this.<buttonClicked>k__BackingField = false;
            UnityEngine.UI.Button val_1 = gameObject.GetComponent<UnityEngine.UI.Button>();
            this.<button>k__BackingField = val_1;
            if(val_1 != 0)
            {
                goto label_8;
            }
            
            GameUI.IllumixButton val_3 = gameObject.GetComponent<GameUI.IllumixButton>();
            this.<button>k__BackingField = val_3;
            if(val_3 != 0)
            {
                goto label_8;
            }
            
            val_10 = gameObject.AddComponent<UnityEngine.UI.Button>();
            this.<button>k__BackingField = val_10;
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_8:
            val_10 = this.<button>k__BackingField;
            if(val_10 != null)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            val_10.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(GameUI.GameObjectClicked).__il2cppRuntimeField_1B0));
            this.<button>k__BackingField.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(GameUI.GameObjectClicked).__il2cppRuntimeField_1B0));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ButtonClick()
        {
            this.<buttonClicked>k__BackingField = true;
        }
    
    }

}
