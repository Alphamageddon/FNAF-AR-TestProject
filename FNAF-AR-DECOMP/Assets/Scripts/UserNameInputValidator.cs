using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class UserNameInputValidator : TMP_InputValidator
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override char Validate(ref string text, ref int pos, char ch)
    {
        char val_7 = ch;
        if((System.Char.IsLetter(c:  val_7 = ch)) != true)
        {
                if((System.Char.IsNumber(c:  val_7)) == false)
        {
            goto label_6;
        }
        
        }
        
        if(pos != 0)
        {
                return (char)val_7;
        }
        
        if(((System.Char.ToUpper(c:  val_7, culture:  System.Globalization.CultureInfo.InvariantCulture)) & 65535) == val_7)
        {
                return (char)val_7;
        }
        
        return System.Char.ToUpper(c:  val_7, culture:  System.Globalization.CultureInfo.InvariantCulture);
        label_6:
        val_7 = 0;
        return (char)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UserNameInputValidator()
    {
    
    }

}
