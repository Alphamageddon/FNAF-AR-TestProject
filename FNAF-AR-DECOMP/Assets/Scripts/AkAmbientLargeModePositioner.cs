using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAmbientLargeModePositioner : MonoBehaviour
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 Position { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 Forward { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 Up { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 get_Position()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.position;
        }
        
        return val_1.position;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 get_Forward()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.forward;
        }
        
        return val_1.forward;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 get_Up()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.up;
        }
        
        return val_1.up;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAmbientLargeModePositioner()
    {
    
    }

}
