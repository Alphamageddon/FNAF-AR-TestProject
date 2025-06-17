using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class WwiseObjectReference : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string objectName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private uint id;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string guid;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Guid Guid { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ObjectName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string DisplayName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint Id { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectType WwiseObjectType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Guid get_Guid()
    {
        var val_2;
        var val_3;
        System.Guid val_4;
        var val_5;
        val_2 = this;
        if((System.String.IsNullOrEmpty(value:  this.guid)) != false)
        {
                val_2 = 1152921504619999232;
            val_3 = null;
            val_3 = null;
            val_4 = System.Guid.Empty;
            return new System.Guid();
        }
        
        val_4 = 0;
        val_5 = 0;
        return new System.Guid();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ObjectName()
    {
        return (string)this.objectName;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual string get_DisplayName()
    {
        return (string)this.objectName;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_Id()
    {
        return (uint)this.id;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract WwiseObjectType get_WwiseObjectType(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected WwiseObjectReference()
    {
    
    }

}
