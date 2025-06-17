using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCFollowCamera : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform target;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        this.transform.LookAt(target:  this.target);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCFollowCamera()
    {
    
    }

}
