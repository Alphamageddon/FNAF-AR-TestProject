using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GuideVisualizerElement : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Image _background;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TextMeshProUGUI _caption;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Image Background { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI Caption { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Image get_Background()
    {
        return (UnityEngine.UI.Image)this._background;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI get_Caption()
    {
        return (TMPro.TextMeshProUGUI)this._caption;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GuideVisualizerElement()
    {
    
    }

}
