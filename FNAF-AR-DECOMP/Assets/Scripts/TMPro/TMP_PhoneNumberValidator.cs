using UnityEngine;

namespace TMPro
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TMP_PhoneNumberValidator : TMP_InputValidator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override char Validate(ref string text, ref int pos, char ch)
        {
            char val_15 = ch;
            UnityEngine.Debug.Log(message:  "Trying to validate...");
            int val_2 = text.Length + 1;
            if(val_2 < 1)
            {
                    return val_15;
            }
            
            var val_16 = 0;
            label_32:
            if(val_16 > 13)
            {
                goto label_5;
            }
            
            var val_15 = -11062952;
            val_15 = val_15 + 52945924;
            goto (-11062952 + 52945924);
            label_5:
            val_16 = val_16 + 1;
            if(val_2 != val_16)
            {
                goto label_32;
            }
            
            val_15 = val_15;
            return val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_PhoneNumberValidator()
        {
        
        }
    
    }

}
