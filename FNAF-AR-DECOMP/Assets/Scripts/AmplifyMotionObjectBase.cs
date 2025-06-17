using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AmplifyMotionObjectBase : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool ApplyToChildren;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_applyToChildren;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotion.ObjectType m_type;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotion.MotionState> m_states;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_fixedStep;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_objectId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 m_lastPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int m_resetAtFrame;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool FixedStep { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int ObjectId { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotion.ObjectType Type { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool get_FixedStep()
    {
        return (bool)this.m_fixedStep;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int get_ObjectId()
    {
        return (int)this.m_objectId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotion.ObjectType get_Type()
    {
        return (AmplifyMotion.ObjectType)this.m_type;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void RegisterCamera(AmplifyMotionCamera camera)
    {
        UnityEngine.Camera val_1 = camera.GetComponent<UnityEngine.Camera>();
        int val_5 = this.gameObject.layer & 31;
        val_5 = 1 << val_5;
        val_5 = val_5 & val_1.cullingMask;
        if(val_5 == 0)
        {
                return;
        }
        
        if((this.m_states.ContainsKey(key:  val_1)) != false)
        {
                return;
        }
        
        AmplifyMotion.ObjectType val_12 = this.m_type;
        val_12 = val_12 - 1;
        if(val_12 <= 3)
        {
                var val_13 = 52948820 + ((this.m_type - 1)) << 2;
            val_13 = val_13 + 52948820;
        }
        else
        {
                System.Exception val_11 = new System.Exception(message:  "[AmplifyMotion] Invalid object type.");
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void UnregisterCamera(AmplifyMotionCamera camera)
    {
        System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotion.MotionState> val_6;
        AmplifyMotionObjectBase val_7;
        val_6 = camera;
        val_7 = this;
        AmplifyMotion.MotionState val_2 = 0;
        UnityEngine.Camera val_1 = val_6.GetComponent<UnityEngine.Camera>();
        if((this.m_states.TryGetValue(key:  val_1, value: out  val_2)) == false)
        {
                return;
        }
        
        val_6.UnregisterObject(obj:  this);
        val_6 = this.m_states;
        if((val_6.TryGetValue(key:  val_1, value: out  val_2)) != false)
        {
                val_6 = val_2;
        }
        
        val_7 = this.m_states;
        bool val_5 = val_7.Remove(key:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool InitializeType()
    {
        UnityEngine.GameObject val_16;
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        val_16 = this.gameObject;
        if((AmplifyMotionEffectBase.CanRegister(gameObj:  val_16, autoReg:  false)) == false)
        {
                return UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        }
        
        val_16 = this.GetComponent<UnityEngine.ParticleSystem>();
        if(val_16 == 0)
        {
            goto label_6;
        }
        
        label_26:
        this.m_type = 4;
        label_23:
        AmplifyMotionEffectBase.RegisterObject(obj:  this);
        return UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        label_6:
        if(val_1 == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        }
        
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_16;
        }
        
        goto label_26;
        label_16:
        if((System.Type.op_Equality(left:  val_1.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_23;
        }
        
        var val_15 = ((this.GetComponent<UnityEngine.Cloth>()) == 0) ? (2 + 1) : 2;
        goto label_26;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        UnityEngine.Object val_17;
        var val_20;
        var val_21;
        var val_22;
        bool val_1 = this.InitializeType();
        if(val_1 == false)
        {
            goto label_11;
        }
        
        if(this.m_type == 1)
        {
            goto label_2;
        }
        
        if(this.m_type != 3)
        {
            goto label_11;
        }
        
        this.m_fixedStep = false;
        goto label_11;
        label_2:
        val_17 = this.GetComponent<UnityEngine.Rigidbody>();
        if((val_17 != 0) && (val_17.interpolation == 0))
        {
                if(val_17.isKinematic != true)
        {
                this.m_fixedStep = true;
        }
        
        }
        
        label_11:
        if(this.m_applyToChildren == false)
        {
            goto label_50;
        }
        
        System.Collections.IEnumerator val_8 = this.gameObject.transform.GetEnumerator();
        label_34:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_20;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_20 = val_8.Current;
        if(val_20 != null)
        {
                val_20 = 0;
        }
        
        AmplifyMotionEffectBase.RegisterRecursivelyS(gameObj:  val_20.gameObject);
        goto label_34;
        label_20:
        val_21 = 0;
        val_22 = 151;
        val_17 = val_8;
        if(val_17 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_17.Dispose();
        }
        
        label_50:
        if(val_1 == true)
        {
                return;
        }
        
        this.enabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        AmplifyMotionEffectBase.UnregisterObject(obj:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void TryInitializeStates()
    {
        System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotion.MotionState> val_6 = this.m_states;
        Dictionary.Enumerator<TKey, TValue> val_1 = val_6.GetEnumerator();
        if((1563330840 & 1) == 0)
        {
                return;
        }
        
        do
        {
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            val_6;
            AmplifyMotionCamera val_3 = val_2.m_SubId1.Owner;
            if(val_3.m_initialized != false)
        {
                if(val_2.m_SubId1.Error != true)
        {
                bool val_5 = val_2.m_SubId1.Initialized;
        }
        
        }
        
        }
        while((1563330840 & 1) != 0);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(AmplifyMotionEffectBase.Instance != 0)
        {
                this.TryInitializeStates();
        }
        
        UnityEngine.Vector3 val_4 = this.transform.position;
        this.m_lastPosition = val_4;
        mem[1152921519055220244] = val_4.y;
        mem[1152921519055220248] = val_4.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(AmplifyMotionEffectBase.Instance == 0)
        {
                return;
        }
        
        this.TryInitializeStates();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void RecursiveResetMotionAtFrame(UnityEngine.Transform transform, AmplifyMotionObjectBase obj, int frame)
    {
        var val_11;
        var val_12;
        if(obj != 0)
        {
                obj.m_resetAtFrame = frame;
        }
        
        System.Collections.IEnumerator val_2 = transform.GetEnumerator();
        goto label_18;
        label_25:
        var val_11 = 0;
        val_11 = val_11 + 1;
        object val_4 = val_2.Current;
        AmplifyMotionObjectBase val_7 = 0.GetComponent<AmplifyMotionObjectBase>();
        label_18:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_25;
        }
        
        val_11 = 0;
        val_12 = 75;
        if(val_2 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_2.Dispose();
        }
        
        if( == 75)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ResetMotionNow()
    {
        AmplifyMotionObjectBase.RecursiveResetMotionAtFrame(transform:  this.transform, obj:  this, frame:  UnityEngine.Time.frameCount);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ResetMotionAtFrame(int frame)
    {
        AmplifyMotionObjectBase.RecursiveResetMotionAtFrame(transform:  this.transform, obj:  this, frame:  frame);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CheckTeleportReset(AmplifyMotionEffectBase inst)
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.m_lastPosition, y = V11.16B, z = V10.16B});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) <= inst.MinResetDeltaDistSqr)
        {
                return;
        }
        
        AmplifyMotionObjectBase.RecursiveResetMotionAtFrame(transform:  this.transform, obj:  this, frame:  inst.ResetFrameDelay + UnityEngine.Time.frameCount);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void OnUpdateTransform(AmplifyMotionEffectBase inst, UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer updateCB, bool starting)
    {
        UnityEngine.Camera val_10 = camera;
        AmplifyMotion.MotionState val_1 = 0;
        if((this.m_states.TryGetValue(key:  val_10 = camera, value: out  val_1)) != false)
        {
                val_10 = val_1;
            if(val_10.Error != true)
        {
                this.CheckTeleportReset(inst:  inst);
            if(this.m_resetAtFrame >= 1)
        {
                var val_5 = (UnityEngine.Time.frameCount >= this.m_resetAtFrame) ? 1 : 0;
        }
        else
        {
                val_10 = 0;
        }
        
            bool val_7 = val_10 | starting;
        }
        
        }
        
        UnityEngine.Vector3 val_9 = this.transform.position;
        this.m_lastPosition = val_9;
        mem[1152921519056008052] = val_9.y;
        mem[1152921519056008056] = val_9.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void OnRenderVectors(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer renderCB, float scale, AmplifyMotion.Quality quality)
    {
        if((this.m_states.TryGetValue(key:  camera, value: out  0)) == false)
        {
                return;
        }
        
        if(val_1.Error == true)
        {
                return;
        }
        
        if(this.m_resetAtFrame < 1)
        {
                return;
        }
        
        if(UnityEngine.Time.frameCount < this.m_resetAtFrame)
        {
                return;
        }
        
        this.m_resetAtFrame = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionObjectBase()
    {
        null = null;
        this.m_applyToChildren = AmplifyMotionObjectBase.ApplyToChildren;
        this.m_states = new System.Collections.Generic.Dictionary<UnityEngine.Camera, AmplifyMotion.MotionState>();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.m_lastPosition = val_2;
        mem[1152921519056290420] = val_2.y;
        mem[1152921519056290424] = val_2.z;
        this.m_resetAtFrame = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AmplifyMotionObjectBase()
    {
        AmplifyMotionObjectBase.ApplyToChildren = true;
    }

}
