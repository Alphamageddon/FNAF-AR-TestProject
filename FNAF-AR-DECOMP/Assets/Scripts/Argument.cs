using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class Check.Argument
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void IsNotNull(object argument, string argumentName, string message)
    {
        string val_2 = message;
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(argument == null)
        {
            goto label_2;
        }
        
        return;
        label_1:
        val_2 = System.String.Format(format:  "{0} must not be null", arg0:  argumentName);
        if(argument != null)
        {
                return;
        }
        
        label_2:
        UnityEngine.Debug.LogWarning(message:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void IsStrNotNullOrEmpty(string argument, string argumentName, string message)
    {
        string val_3 = message;
        if(val_3 == null)
        {
                val_3 = System.String.Format(format:  "{0} must not be null or empty", arg0:  argumentName);
        }
        
        if((System.String.IsNullOrEmpty(value:  argument)) == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  val_3);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void IsNotNegative(int argument, string argumentName)
    {
        if((argument & 2147483648) == 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  argumentName + " must not be negative.");
    }

}
