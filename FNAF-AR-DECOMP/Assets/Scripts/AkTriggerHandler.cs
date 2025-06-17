using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkTriggerHandler : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AWAKE_TRIGGER_ID = 1151176110;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int START_TRIGGER_ID = 1281810935;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DESTROY_TRIGGER_ID = -358577003;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MAX_NB_TRIGGERS = 32;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<uint, string> triggerTypes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool didDestroy;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> triggerList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useOtherObject;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void HandleEvent(UnityEngine.GameObject in_gameObject); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected virtual void Awake()
    {
        AkTriggerHandler val_7 = this;
        mem[1152921519469136096] = val_7;
        mem[1152921519469136104] = typeof(AkTriggerHandler).__il2cppRuntimeField_170;
        mem[1152921519469136080] = typeof(AkTriggerHandler).__il2cppRuntimeField_170;
        this.RegisterTriggers(in_triggerList:  this.triggerList, in_delegate:  new AkTriggerBase.Trigger());
        if((this.triggerList.Contains(item:  1151176110)) == false)
        {
                return;
        }
        
        val_7 = ???;
        goto typeof(AkTriggerHandler).__il2cppRuntimeField_168;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected virtual void Start()
    {
        if((this.triggerList.Contains(item:  1281810935)) == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(AkTriggerHandler).__il2cppRuntimeField_168;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected virtual void OnDestroy()
    {
        if(this.didDestroy != false)
        {
                return;
        }
        
        this.DoDestroy();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DoDestroy()
    {
        AkTriggerHandler val_7 = this;
        mem[1152921519469504864] = val_7;
        mem[1152921519469504872] = typeof(AkTriggerHandler).__il2cppRuntimeField_170;
        mem[1152921519469504848] = typeof(AkTriggerHandler).__il2cppRuntimeField_170;
        this.UnregisterTriggers(in_triggerList:  this.triggerList, in_delegate:  new AkTriggerBase.Trigger());
        this.didDestroy = true;
        if((this.triggerList.Contains(item:  -358577003)) == false)
        {
                return;
        }
        
        val_7 = ???;
        goto typeof(AkTriggerHandler).__il2cppRuntimeField_168;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void RegisterTriggers(System.Collections.Generic.List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
    {
        var val_3;
        var val_25;
        var val_26;
        System.Collections.Generic.Dictionary<System.UInt32, System.String> val_27;
        System.Type val_28;
        UnityEngine.Object val_29;
        System.Type val_30;
        var val_31;
        var val_32;
        List.Enumerator<T> val_1 = in_triggerList.GetEnumerator();
        val_25 = "Awake";
        goto label_9;
        label_30:
        val_26 = null;
        int val_5 = System.String.alignConst;
        val_26 = null;
        val_27 = AkTriggerHandler.triggerTypes;
        if(((((val_27.TryGetValue(key:  val_3.region, value: out  val_5)) == false) || ((System.String.op_Equality(a:  val_5, b:  "Awake")) == true)) || ((System.String.op_Equality(a:  val_5, b:  "Start")) == true)) || ((System.String.op_Equality(a:  val_5, b:  "Destroy")) == true))
        {
            goto label_9;
        }
        
        val_28 = System.Type.GetType(typeName:  val_5);
        if(val_28 == null)
        {
                val_28 = System.Type.GetType(typeName:  val_5);
        }
        
        val_29 = this.GetComponent(type:  val_28);
        if(val_29 != null)
        {
                val_29 = 0;
        }
        
        if(val_29 != 0)
        {
            goto label_18;
        }
        
        val_27 = val_5;
        val_30 = System.Type.GetType(typeName:  val_27);
        if(val_30 == null)
        {
                val_30 = System.Type.GetType(typeName:  val_27);
        }
        
        val_31 = this.gameObject.AddComponent(componentType:  val_30);
        if(val_31 == null)
        {
            goto label_26;
        }
        
        goto label_26;
        label_18:
        if(val_29 != 0)
        {
            goto label_27;
        }
        
        label_26:
        val_31 = 0;
        label_27:
        if(((System.Delegate.Combine(a:  15026800, b:  in_delegate)) != null) && (null != null))
        {
                val_32 = 0;
        }
        
        mem[24] = val_32;
        label_9:
        if((1977878096 & 1) != 0)
        {
            goto label_30;
        }
        
        long val_23 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519469626960});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void UnregisterTriggers(System.Collections.Generic.List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
    {
        var val_3;
        var val_19;
        var val_20;
        System.Type val_21;
        UnityEngine.Object val_22;
        List.Enumerator<T> val_1 = in_triggerList.GetEnumerator();
        val_19 = "Start";
        goto label_24;
        label_25:
        val_20 = null;
        int val_5 = System.String.alignConst;
        val_20 = null;
        if(((((AkTriggerHandler.triggerTypes.TryGetValue(key:  val_3.region, value: out  val_5)) == false) || ((System.String.op_Equality(a:  val_5, b:  "Awake")) == true)) || ((System.String.op_Equality(a:  val_5, b:  "Start")) == true)) || ((System.String.op_Equality(a:  val_5, b:  "Destroy")) == true))
        {
            goto label_24;
        }
        
        val_21 = System.Type.GetType(typeName:  val_5);
        if(val_21 == null)
        {
                val_21 = System.Type.GetType(typeName:  val_5);
        }
        
        val_22 = this.GetComponent(type:  val_21);
        if(val_22 != null)
        {
                val_22 = 0;
        }
        
        if(val_22 == 0)
        {
            goto label_24;
        }
        
        System.Delegate val_16 = System.Delegate.Remove(source:  15026800, value:  in_delegate);
        if(val_16 != null)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        mem[24] = 0;
        UnityEngine.Object.Destroy(obj:  val_22);
        goto label_24;
        label_21:
        mem[24] = val_16;
        label_24:
        if((1978063840 & 1) != 0)
        {
            goto label_25;
        }
        
        long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519469812704});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkTriggerHandler()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_1.Add(item:  1281810935);
        this.triggerList = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkTriggerHandler()
    {
        AkTriggerHandler.triggerTypes = AkTriggerBase.GetAllDerivedTypes();
    }

}
