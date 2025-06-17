using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SetFogState : MonoBehaviour
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.RenderSettings.fog = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetFog(bool value)
    {
        UnityEngine.RenderSettings.fog = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SetFogState()
    {
    
    }

}
