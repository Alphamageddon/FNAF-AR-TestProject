using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCPlayerBooster : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float boostStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rigidbody targetRigidbody;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem boostParticles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isBoosting;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Boosting { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Boosting()
    {
        return (bool)this.isBoosting;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Boosting(bool value)
    {
        this.isBoosting = value;
        EmissionModule val_2 = this.boostParticles.emission;
        val_2.m_ParticleSystem.enabled = this.isBoosting;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixedUpdate()
    {
        this.ApplyBoostIfNecessary();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ApplyBoostIfNecessary()
    {
        if(this.isBoosting == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.forward;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  -1f);
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.boostStrength);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  UnityEngine.Time.fixedDeltaTime);
        this.targetRigidbody.AddForceAtPosition(force:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, mode:  5);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCPlayerBooster()
    {
    
    }

}
