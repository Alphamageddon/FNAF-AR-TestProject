using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
private class SRServiceManager.ServiceStub
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Func<object> Constructor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type InterfaceType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Func<System.Type> Selector;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type Type;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        object val_4;
        System.Type val_5;
        object val_6;
        val_4 = this.InterfaceType + " (";
        if((System.Type.op_Inequality(left:  this.Type, right:  0)) != false)
        {
                val_5 = this.Type;
            val_6 = "Type: ";
        }
        else
        {
                val_5 = this.Selector;
            if(val_5 != null)
        {
                val_6 = "Selector: ";
        }
        else
        {
                val_5 = this.Constructor;
            if(val_5 == null)
        {
                return val_4 + ")";
        }
        
            val_6 = "Constructor: ";
        }
        
        }
        
        val_4 = val_4 + val_6 + val_5;
        return val_4 + ")";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRServiceManager.ServiceStub()
    {
    
    }

}
