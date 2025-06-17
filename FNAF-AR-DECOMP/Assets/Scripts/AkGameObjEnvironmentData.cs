using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkGameObjEnvironmentData
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkEnvironment> activeEnvironments;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkEnvironment> activeEnvironmentsFromPortals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkEnvironmentPortal> activePortals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly AkAuxSendArray auxSendValues;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 lastPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasEnvironmentListChanged;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasActivePortalListChanged;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasSentZero;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddHighestPriorityEnvironmentsFromPortals(UnityEngine.Vector3 position)
    {
        var val_10;
        System.Collections.Generic.List<AkEnvironmentPortal> val_11;
        var val_12;
        System.Collections.Generic.List<AkEnvironment> val_13;
        val_10 = 0;
        goto label_1;
        label_22:
        val_11 = 0;
        do
        {
            AkEnvironmentPortal val_1 = this.activePortals.Item[0];
            AkEnvironment val_10 = val_1.environments[val_11];
            if(val_10 != 0)
        {
                val_12 = null;
            val_13 = this.activeEnvironmentsFromPortals;
            val_12 = null;
            if((val_13.BinarySearch(item:  val_10, comparer:  AkEnvironment.s_compareByPriority)) <= 3)
        {
                val_13 = this.auxSendValues;
            bool val_7 = val_13.Add(in_AuxBusID:  val_1.environments[0x0][0].data.Id, in_fValue:  this.activePortals.Item[0].GetAuxSendValueForPosition(in_position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, index:  0));
            if(this.auxSendValues.isFull == true)
        {
                return;
        }
        
        }
        
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 < 1);
        
        val_10 = 1;
        label_1:
        val_11 = this.activePortals;
        if(val_10 < val_11.Count)
        {
            goto label_22;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddHighestPriorityEnvironments(UnityEngine.Vector3 position)
    {
        int val_9;
        var val_10;
        AkAuxSendArray val_11;
        if(this.auxSendValues.isFull == true)
        {
                return;
        }
        
        val_9 = this.auxSendValues.m_Count;
        if(val_9 >= this.activeEnvironments.Count)
        {
                return;
        }
        
        val_10 = 0;
        goto label_6;
        label_19:
        val_9 = this.activeEnvironments.Item[0];
        uint val_4 = val_3.data.Id;
        if(val_10 != 0)
        {
                if(val_3.isDefault == true)
        {
            goto label_13;
        }
        
        }
        
        val_11 = this.auxSendValues;
        if((val_11.Contains(in_AuxBusID:  val_4)) != true)
        {
                val_11 = this.auxSendValues;
            bool val_6 = val_11.Add(in_AuxBusID:  val_4, in_fValue:  1f);
            if(val_3.excludeOthers == true)
        {
                return;
        }
        
            val_9 = this.auxSendValues;
            if(val_9.isFull == true)
        {
                return;
        }
        
        }
        
        label_13:
        val_10 = 1;
        label_6:
        val_9 = this.activeEnvironments;
        if(val_10 < val_9.Count)
        {
            goto label_19;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateAuxSend(UnityEngine.GameObject gameObject, UnityEngine.Vector3 position)
    {
        AkAuxSendArray val_4;
        if((this.hasEnvironmentListChanged != true) && (this.hasActivePortalListChanged != true))
        {
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.lastPosition, y = V11.16B, z = V12.16B}, rhs:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z})) == true)
        {
                return;
        }
        
        }
        
        this.auxSendValues.m_Count = 0;
        this.AddHighestPriorityEnvironmentsFromPortals(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        this.AddHighestPriorityEnvironments(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        val_4 = this.auxSendValues;
        if(this.hasSentZero != false)
        {
                if(this.auxSendValues.m_Count == 0)
        {
            goto label_9;
        }
        
        }
        
        val_4 = this.auxSendValues;
        AKRESULT val_2 = AkSoundEngine.SetEmitterAuxSendValues(in_gameObjectID:  gameObject, in_pAuxSends:  val_4, in_uNumAux:  this.auxSendValues.m_Count);
        label_9:
        this.lastPosition = position;
        mem[1152921519442895684] = position.y;
        mem[1152921519442895688] = position.z;
        this.hasSentZero = (this.auxSendValues.m_Count == 0) ? 1 : 0;
        this.hasEnvironmentListChanged = false;
        this.hasActivePortalListChanged = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void TryAddEnvironment(AkEnvironment env)
    {
        var val_4;
        var val_5;
        var val_6;
        if(env == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = this.activeEnvironmentsFromPortals.BinarySearch(item:  env, comparer:  AkEnvironment.s_compareByPriority);
        if((val_4 & 2147483648) == 0)
        {
                return;
        }
        
        this.activeEnvironmentsFromPortals.Insert(index:  ~val_4, item:  env);
        val_6 = null;
        val_6 = null;
        val_4 = this.activeEnvironments.BinarySearch(item:  env, comparer:  AkEnvironment.s_compareBySelectionAlgorithm);
        if((val_4 & 2147483648) != 0)
        {
                this.activeEnvironments.Insert(index:  ~val_4, item:  env);
        }
        
        this.hasEnvironmentListChanged = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RemoveEnvironment(AkEnvironment env)
    {
        bool val_1 = this.activeEnvironmentsFromPortals.Remove(item:  env);
        bool val_2 = this.activeEnvironments.Remove(item:  env);
        this.hasEnvironmentListChanged = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAkEnvironment(UnityEngine.Collider environmentCollider, UnityEngine.Collider gameObjectCollider)
    {
        AkEnvironmentPortal val_1 = environmentCollider.GetComponent<AkEnvironmentPortal>();
        if(val_1 != 0)
        {
                this.activePortals.Add(item:  val_1);
            var val_5 = 0;
            this.hasActivePortalListChanged = true;
            do
        {
            this.TryAddEnvironment(env:  val_1.environments[val_5]);
            val_5 = val_5 + 1;
        }
        while(val_5 != 2);
        
            return;
        }
        
        this.TryAddEnvironment(env:  environmentCollider.GetComponent<AkEnvironment>());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool AkEnvironmentBelongsToActivePortals(AkEnvironment env)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_11:
        var val_5 = 0;
        label_9:
        AkEnvironmentPortal val_1 = this.activePortals.Item[0];
        if(env == val_1.environments[val_5])
        {
            goto label_8;
        }
        
        val_5 = val_5 + 1;
        if(val_5 < 1)
        {
            goto label_9;
        }
        
        val_4 = 1;
        label_1:
        if(val_4 < this.activePortals.Count)
        {
            goto label_11;
        }
        
        val_5 = 0;
        return (bool)val_5;
        label_8:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void RemoveAkEnvironment(UnityEngine.Collider environmentCollider, UnityEngine.Collider gameObjectCollider)
    {
        AkEnvironmentPortal val_1 = environmentCollider.GetComponent<AkEnvironmentPortal>();
        if(val_1 != 0)
        {
                var val_15 = 0;
            do
        {
            AkEnvironment val_14 = val_1.environments[val_15];
            if(val_14 != 0)
        {
                UnityEngine.Bounds val_4 = gameObjectCollider.bounds;
            UnityEngine.Bounds val_7 = val_1.environments[0x0][0].<Collider>k__BackingField.bounds;
            if((1952098048 & 1) == 0)
        {
                this.RemoveEnvironment(env:  val_14);
        }
        
        }
        
            val_15 = val_15 + 1;
        }
        while(val_15 != 2);
        
            bool val_10 = this.activePortals.Remove(item:  val_1);
            this.hasActivePortalListChanged = true;
            return;
        }
        
        AkEnvironment val_11 = environmentCollider.GetComponent<AkEnvironment>();
        if(val_11 == 0)
        {
                return;
        }
        
        if((this.AkEnvironmentBelongsToActivePortals(env:  val_11)) == true)
        {
                return;
        }
        
        this.RemoveEnvironment(env:  val_11);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkGameObjEnvironmentData()
    {
        this.activeEnvironments = new System.Collections.Generic.List<AkEnvironment>();
        this.activeEnvironmentsFromPortals = new System.Collections.Generic.List<AkEnvironment>();
        this.activePortals = new System.Collections.Generic.List<AkEnvironmentPortal>();
        this.auxSendValues = new AkAuxSendArray();
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.lastPosition = val_5;
        mem[1152921519444063172] = val_5.y;
        mem[1152921519444063176] = val_5.z;
        this.hasEnvironmentListChanged = true;
        this.hasActivePortalListChanged = true;
    }

}
