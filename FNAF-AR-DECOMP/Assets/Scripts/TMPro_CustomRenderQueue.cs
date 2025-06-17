using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TMPro_CustomRenderQueue : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int RenderQueue;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.GetComponent<TMPro.TextMeshProUGUI>().renderQueue = this.RenderQueue;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro_CustomRenderQueue()
    {
        this.RenderQueue = 6000;
    }

}
