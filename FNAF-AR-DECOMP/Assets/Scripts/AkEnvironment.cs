using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEnvironment : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MAX_NB_ENVIRONMENTS = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkEnvironment.AkEnvironment_CompareByPriority s_compareByPriority;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool excludeOthers;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isDefault;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.AuxBus data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Collider <Collider>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int priority;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int auxBusIdInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private byte[] valueGuidInternal;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Collider Collider { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int m_auxBusID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] valueGuid { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Collider get_Collider()
    {
        return (UnityEngine.Collider)this.<Collider>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Collider(UnityEngine.Collider value)
    {
        this.<Collider>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetAuxSendValueForPosition(UnityEngine.Vector3 in_position)
    {
        return 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Awake()
    {
        this.<Collider>k__BackingField = this.GetComponent<UnityEngine.Collider>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_m_auxBusID()
    {
        if(this.data == null)
        {
                return (int)this.data;
        }
        
        return this.data.Id;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] get_valueGuid()
    {
        UnityEngine.Object val_3;
        AK.Wwise.AuxBus val_4;
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
    public uint GetAuxBusID()
    {
        if(this.data != null)
        {
                return this.data.Id;
        }
        
        return this.data.Id;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Collider GetCollider()
    {
        return (UnityEngine.Collider)this.<Collider>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEnvironment()
    {
        this.data = new AK.Wwise.AuxBus();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkEnvironment()
    {
        AkEnvironment.s_compareByPriority = new AkEnvironment.AkEnvironment_CompareByPriority();
        AkEnvironment.s_compareBySelectionAlgorithm = new AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm();
    }

}
