using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkBank : AkTriggerHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.Bank data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool decodeBank;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool loadAsynchronous;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool saveDecodedBank;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> unloadTriggerList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string bankNameInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private byte[] valueGuidInternal;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string bankName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] valueGuid { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Awake()
    {
        this.Awake();
        this.RegisterTriggers(in_triggerList:  this.unloadTriggerList, in_delegate:  new AkTriggerBase.Trigger(object:  this, method:  public System.Void AkBank::UnloadBank(UnityEngine.GameObject in_gameObject)));
        if((this.unloadTriggerList.Contains(item:  1151176110)) == false)
        {
                return;
        }
        
        this.data.Unload();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
        if((this.unloadTriggerList.Contains(item:  1281810935)) == false)
        {
                return;
        }
        
        this.data.Unload();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        if(this.loadAsynchronous != false)
        {
                this.data.LoadAsync(callback:  0);
            return;
        }
        
        this.data.Load(decodeBank:  (this.decodeBank == true) ? 1 : 0, saveDecodedBank:  (this.saveDecodedBank == true) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UnloadBank(UnityEngine.GameObject in_gameObject)
    {
        this.data.Unload();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void OnDestroy()
    {
        this.OnDestroy();
        this.UnregisterTriggers(in_triggerList:  this.unloadTriggerList, in_delegate:  new AkTriggerBase.Trigger(object:  this, method:  public System.Void AkBank::UnloadBank(UnityEngine.GameObject in_gameObject)));
        if((this.unloadTriggerList.Contains(item:  -358577003)) == false)
        {
                return;
        }
        
        this.data.Unload();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_bankName()
    {
        if(this.data == null)
        {
                return (string)System.String.alignConst;
        }
        
        this = ???;
        goto typeof(AK.Wwise.Bank).__il2cppRuntimeField_198;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] get_valueGuid()
    {
        UnityEngine.Object val_3;
        AK.Wwise.Bank val_4;
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
    public AkBank()
    {
        this.data = new AK.Wwise.Bank();
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        val_2.Add(item:  -358577003);
        this.unloadTriggerList = val_2;
    }

}
