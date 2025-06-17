using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ShowVisual : AREnvironmentSetupSequence
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject[] visualsToControl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool showOrHide;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Init()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void StartSequence()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void UpdateSequence()
    {
        if(this.visualsToControl == null)
        {
                return;
        }
        
        if(this.visualsToControl.Length < 1)
        {
                return;
        }
        
        do
        {
            this.visualsToControl[0].SetActive(value:  (this.showOrHide == true) ? 1 : 0);
        }
        while((0 + 1) < this.visualsToControl.Length);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool IsSequenceDone()
    {
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void EndSequence()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShowVisual()
    {
    
    }

}
