using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WinLose_Rotate : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float speed;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        this.transform.Rotate(xAngle:  0f, yAngle:  0f, zAngle:  this.speed);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WinLose_Rotate()
    {
        this.speed = 5f;
    }

}
