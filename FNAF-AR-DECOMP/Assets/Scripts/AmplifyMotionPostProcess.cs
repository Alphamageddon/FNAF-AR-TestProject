using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AmplifyMotionPostProcess : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AmplifyMotionEffectBase m_instance;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionEffectBase Instance { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionEffectBase get_Instance()
    {
        return (AmplifyMotionEffectBase)this.m_instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Instance(AmplifyMotionEffectBase value)
    {
        this.m_instance = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
    {
        if(this.m_instance == 0)
        {
                return;
        }
        
        this.m_instance.PostProcess(source:  source, destination:  destination);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionPostProcess()
    {
    
    }

}
