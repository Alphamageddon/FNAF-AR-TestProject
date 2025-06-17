using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DisableAnimator : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableAnimator;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Animator animator;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.animator = this.GetComponent<UnityEngine.Animator>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.animator == 0)
        {
                return;
        }
        
        if(this.EnableAnimator != false)
        {
                return;
        }
        
        this.animator.enabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DisableAnimator()
    {
        this.EnableAnimator = true;
    }

}
