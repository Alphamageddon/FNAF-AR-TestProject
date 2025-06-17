using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SetScreenResolution : MonoBehaviour
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        int val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
        val_3 = val_3 >> 1;
        UnityEngine.Screen.SetResolution(width:  val_3, height:  ((val_2 < 0) ? (val_2 + 1) : (val_2)) >> 1, fullscreen:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SetScreenResolution()
    {
    
    }

}
