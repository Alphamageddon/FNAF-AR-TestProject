using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ConsoleLogger_OptionsBootstrap : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ConsoleLogger_SROptions options;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_1.AddOptionContainer(container:  this.options);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_1.RemoveOptionContainer(container:  this.options);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ConsoleLogger_OptionsBootstrap()
    {
        this.options = new ConsoleLogger_SROptions();
    }

}
