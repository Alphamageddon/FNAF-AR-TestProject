using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkState : AkDragDropTriggerHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.State data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int valueIdInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int groupIdInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private byte[] valueGuidInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private byte[] groupGuidInternal;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AK.Wwise.BaseType WwiseType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int valueID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int groupID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] valueGuid { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] groupGuid { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AK.Wwise.BaseType get_WwiseType()
    {
        return (AK.Wwise.BaseType)this.data;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        this.data.SetValue();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_valueID()
    {
        if(this.data == null)
        {
                return (int)this.data;
        }
        
        return this.data.Id;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_groupID()
    {
        if(this.data == null)
        {
                return (int)this.data;
        }
        
        return this.data.GroupId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] get_valueGuid()
    {
        UnityEngine.Object val_3;
        AK.Wwise.State val_4;
        val_3 = this;
        val_4 = this.data;
        if(val_4 == null)
        {
                return (System.Byte[])val_4;
        }
        
        val_3 = val_4;
        val_4 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return (System.Byte[])val_4;
        }
        
        System.Guid val_2 = val_3.Guid;
        val_4;
        return (System.Byte[])val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] get_groupGuid()
    {
        UnityEngine.Object val_4;
        AK.Wwise.State val_5;
        val_4 = this;
        val_5 = this.data;
        if(val_5 == null)
        {
                return (System.Byte[])val_5;
        }
        
        val_4 = val_5.GroupWwiseObjectReference;
        val_5 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_4)) == false)
        {
                return (System.Byte[])val_5;
        }
        
        System.Guid val_3 = val_4.Guid;
        val_5;
        return (System.Byte[])val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkState()
    {
        this.data = new AK.Wwise.State();
    }

}
