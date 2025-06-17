using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameSparksUnity : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksSettings settings;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        GameSparks.Platforms.DefaultPlatform val_2 = this.gameObject.AddComponent<GameSparks.Platforms.DefaultPlatform>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnGUI()
    {
        UnityEngine.GUILayoutOption[] val_9;
        var val_10 = null;
        if(GameSparksSettings.PreviewBuild == false)
        {
                return;
        }
        
        int val_2 = UnityEngine.Screen.width;
        int val_3 = UnityEngine.Screen.height;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Space(pixels:  10f);
        UnityEngine.GUILayoutOption[] val_6 = new UnityEngine.GUILayoutOption[2];
        val_9 = val_6;
        val_9[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_9[1] = UnityEngine.GUILayout.Height(height:  25f);
        UnityEngine.GUILayout.Label(text:  "GameSparks Preview mode", options:  val_6);
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndVertical();
        UnityEngine.GUILayout.EndArea();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksUnity()
    {
    
    }

}
