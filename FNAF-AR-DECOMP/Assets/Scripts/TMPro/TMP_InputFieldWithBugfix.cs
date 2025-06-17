using UnityEngine;

namespace TMPro
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_InputFieldWithBugfix : TMP_InputField
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Append(char input)
        {
            var val_26;
            if(this.readOnly == true)
            {
                    return;
            }
            
            val_26 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "Insert", bindingAttr:  36);
            if(UnityEngine.TouchScreenKeyboard.isSupported == true)
            {
                    return;
            }
            
            if(this.onValidateInput == null)
            {
                goto label_7;
            }
            
            char val_11 = this.onValidateInput.Invoke(text:  this.text, charIndex:  this.stringPositionInternal, addedChar:  input);
            label_20:
            label_19:
            if((val_11 & 65535) == 0)
            {
                    return;
            }
            
            label_18:
            object[] val_13 = new object[1];
            val_13[0] = val_11;
            object val_14 = val_26.Invoke(obj:  this, parameters:  val_13);
            return;
            label_7:
            if(this.characterValidation != 8)
            {
                goto label_15;
            }
            
            if(((this.Validate(text:  this.text, pos:  this.stringPositionInternal, ch:  input)) & 65535) == 0)
            {
                    return;
            }
            
            object val_21 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "SendOnValueChanged", bindingAttr:  36).Invoke(obj:  this, parameters:  new object[0]);
            this.UpdateLabel();
            goto label_18;
            label_15:
            if(this.characterValidation == 0)
            {
                goto label_19;
            }
            
            char val_25 = this.Validate(text:  this.text, pos:  this.stringPositionInternal, ch:  input);
            goto label_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_InputFieldWithBugfix()
        {
        
        }
    
    }

}
