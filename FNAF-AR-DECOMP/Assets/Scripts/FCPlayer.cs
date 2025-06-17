using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCPlayer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maximumSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPlayerBooster boosterLeft;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPlayerBooster boosterRight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rigidbody rigidbody;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float targetHeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasReachedTargetHeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float currentHeight;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<FCPlayer> OnPlayerReachedHeight;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float CurrentHeight { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_CurrentHeight()
    {
        return (float)this.currentHeight;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CurrentHeight(float value)
    {
        this.currentHeight = value;
        if(this.targetHeight > value)
        {
                return;
        }
        
        if(this.hasReachedTargetHeight != false)
        {
                return;
        }
        
        this.hasReachedTargetHeight = true;
        if(this.OnPlayerReachedHeight == null)
        {
                return;
        }
        
        this.OnPlayerReachedHeight.Invoke(obj:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void add_OnPlayerReachedHeight(System.Action<FCPlayer> value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.OnPlayerReachedHeight, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnPlayerReachedHeight != 1152921519061593160);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void remove_OnPlayerReachedHeight(System.Action<FCPlayer> value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.OnPlayerReachedHeight, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.OnPlayerReachedHeight != 1152921519061729736);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        this.rigidbody = this.GetComponent<UnityEngine.Rigidbody>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.CurrentHeight = val_2.y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixedUpdate()
    {
        this.LimitVelocity();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LimitVelocity()
    {
        UnityEngine.Vector3 val_1 = this.rigidbody.velocity;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, maxLength:  this.maximumSpeed);
        this.rigidbody.velocity = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetBoosting(FCPlayer.BoostId boosterId, bool active)
    {
        (boosterId == 0) ? this.boosterLeft : this.boosterRight.Boosting = active;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ResetPosition()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.rigidbody.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.rigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPlayer()
    {
        this.targetHeight = 10f;
    }

}
