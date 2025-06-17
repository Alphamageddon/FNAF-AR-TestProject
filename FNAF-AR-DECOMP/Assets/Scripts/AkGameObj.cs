using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkGameObj : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObjListenerList m_listeners;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isEnvironmentAware;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isStaticObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Collider m_Collider;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObjEnvironmentData m_envData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObjPositionData m_posData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkGameObjPositionOffsetData m_positionOffsetData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isRegistered;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObjPosOffsetData m_posOffsetData;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int AK_NUM_LISTENERS = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int listenerMask;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsUsingDefaultListeners { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAudioListener> ListenerList { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsUsingDefaultListeners()
    {
        if(this.m_listeners != null)
        {
                return (bool)this.m_listeners.useDefaultListeners;
        }
        
        return (bool)this.m_listeners.useDefaultListeners;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetUseDefaultListeners(bool useDefault)
    {
        useDefault = useDefault;
        this.m_listeners.SetUseDefaultListeners(useDefault:  useDefault);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkAudioListener> get_ListenerList()
    {
        if(this.m_listeners != null)
        {
                return 0;
        }
        
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void AddListener(AkAudioListener listener)
    {
        if(this.m_listeners == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void RemoveListener(AkAudioListener listener)
    {
        if(this.m_listeners == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Register()
    {
        if(this.isRegistered != false)
        {
                return 1;
        }
        
        this.isRegistered = true;
        return AkSoundEngine.RegisterGameObj(gameObject:  this.gameObject, name:  this.gameObject.name);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        float val_11;
        float val_12;
        if(this.isStaticObject != true)
        {
                this.m_posData = new AkGameObjPositionData();
        }
        
        this.m_Collider = this.GetComponent<UnityEngine.Collider>();
        if(this.Register() != 1)
        {
                return;
        }
        
        val_11 = V2.16B;
        val_12 = V2.16B;
        AKRESULT val_5 = AkSoundEngine.SetObjectPosition(gameObject:  this.gameObject, position:  new UnityEngine.Vector3() {x = ???, y = V1.16B, z = val_11}, forward:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, up:  new UnityEngine.Vector3() {x = V0.16B, y = val_12, z = ???});
        if(this.isEnvironmentAware != false)
        {
                this.m_envData = new AkGameObjEnvironmentData();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Collider)) != false)
        {
                this.m_envData.AddAkEnvironment(environmentCollider:  this.m_Collider, gameObjectCollider:  null);
        }
        
            UnityEngine.Vector3 val_10 = this.transform.position;
            val_12 = val_10.x;
            val_11 = val_10.z;
            this.m_envData.UpdateAuxSend(gameObject:  this.gameObject, position:  new UnityEngine.Vector3() {x = val_12, y = val_10.y, z = val_11});
        }
        
        this.m_listeners.Init(akGameObj:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CheckStaticStatus()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        this.enabled = (this.isStaticObject == false) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        goto label_2;
        label_8:
        if((val_2[0x0][0] + 32.Contains(item:  -358577003)) != false)
        {
                this.gameObject.GetComponents<AkTriggerHandler>()[0].DoDestroy();
        }
        
        0 = 1;
        label_2:
        if(0 < val_2.Length)
        {
            goto label_8;
        }
        
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        AKRESULT val_6 = AkSoundEngine.UnregisterGameObj(gameObject:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.GameObject val_9;
        UnityEngine.GameObject val_10;
        UnityEngine.Vector3 val_11;
        float val_12;
        val_9 = this;
        if(this.m_envData != null)
        {
                val_10 = this.gameObject;
            UnityEngine.Vector3 val_3 = this.transform.position;
            this.m_envData.UpdateAuxSend(gameObject:  val_10, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        
        bool val_9 = this.isStaticObject;
        val_9 = val_9 + 3;
        var val_10 = ~val_9;
        val_10 = val_10 & 3;
        if(val_10 != 0)
        {
                return;
        }
        
        val_10 = this.m_posData;
        val_11 = this.m_posData.position;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_11, y = V15.16B, z = V14.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) != false)
        {
                val_10 = this.m_posData;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.m_posData.forward, y = val_11, z = V14.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) != false)
        {
                val_10 = this.m_posData;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.m_posData.up, y = val_11, z = V14.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == true)
        {
                return;
        }
        
        }
        
        }
        
        this.m_posData.position = val_3;
        mem2[0] = val_3.y;
        mem2[0] = val_3.z;
        val_12 = val_3.y;
        mem2[0] = val_3.z;
        this.m_posData.forward = val_3;
        mem2[0] = val_3.y;
        this.m_posData.up = val_3;
        mem2[0] = val_12;
        mem2[0] = val_3.z;
        val_9 = this.gameObject;
        AKRESULT val_8 = AkSoundEngine.SetObjectPosition(gameObject:  val_9, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, forward:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, up:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_3.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual UnityEngine.Vector3 GetPosition()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.m_positionOffsetData == null)
        {
                return val_1.position;
        }
        
        label_9:
        UnityEngine.Quaternion val_2 = val_1.rotation;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = this.m_positionOffsetData.positionOffset, y = V12.16B, z = V13.16B});
        UnityEngine.Vector3 val_5 = this.transform.position;
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        label_1:
        if(this.m_positionOffsetData != null)
        {
            goto label_9;
        }
        
        return val_1.position;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual UnityEngine.Vector3 GetForward()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.forward;
        }
        
        return val_1.forward;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual UnityEngine.Vector3 GetUpward()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.up;
        }
        
        return val_1.up;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(this.isEnvironmentAware == false)
        {
                return;
        }
        
        if(this.m_envData == null)
        {
                return;
        }
        
        this.m_envData.AddAkEnvironment(environmentCollider:  other, gameObjectCollider:  null);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        if(this.isEnvironmentAware == false)
        {
                return;
        }
        
        if(this.m_envData == null)
        {
                return;
        }
        
        this.m_envData.RemoveAkEnvironment(environmentCollider:  other, gameObjectCollider:  this.m_Collider);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkGameObj()
    {
        this.m_listeners = new AkGameObjListenerList();
        this.isEnvironmentAware = true;
        this.listenerMask = true;
    }

}
