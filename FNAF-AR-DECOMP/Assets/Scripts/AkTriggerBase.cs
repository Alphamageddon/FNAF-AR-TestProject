using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkTriggerBase : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerBase.Trigger triggerDelegate;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<uint, string> GetAllDerivedTypes()
    {
        var val_9;
        System.Collections.Generic.Dictionary<System.UInt32, System.String> val_1 = new System.Collections.Generic.Dictionary<System.UInt32, System.String>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_9 = 0;
        val_1.Add(key:  AkUtilities.ShortIDGenerator.Compute(in_name:  "Awake"), value:  "Awake");
        val_1.Add(key:  AkUtilities.ShortIDGenerator.Compute(in_name:  "Start"), value:  "Start");
        val_1.Add(key:  AkUtilities.ShortIDGenerator.Compute(in_name:  "Destroy"), value:  "Destroy");
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkTriggerBase()
    {
    
    }

}
