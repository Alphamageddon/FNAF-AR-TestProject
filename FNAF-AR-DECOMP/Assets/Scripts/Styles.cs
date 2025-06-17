using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class Constants.GUI.Styles
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly UnityEngine.GUIStyle EDITOR_NOTE_STYLE;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly UnityEngine.GUIStyle EDITOR_TEXTURE_STYLE_DESCRIPTION_STYLE;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly UnityEngine.GUIStyle EDITOR_TEXTURE_THUMBNAIL_STYLE;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Constants.GUI.Styles()
    {
        var val_6;
        UnityEngine.GUIStyle val_1 = new UnityEngine.GUIStyle();
        if(val_1 != null)
        {
                val_1.wordWrap = true;
        }
        else
        {
                val_1.wordWrap = true;
        }
        
        val_6 = null;
        val_6 = null;
        val_1.normal.textColor = new UnityEngine.Color() {r = Constants.GUI.Colors.EDITOR_NOTE_COLOR, g = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_14, b = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_18, a = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_1C};
        Constants.GUI.Styles.EDITOR_NOTE_STYLE = val_1;
        UnityEngine.GUIStyle val_3 = new UnityEngine.GUIStyle();
        if(val_3 != null)
        {
                val_3.wordWrap = true;
        }
        else
        {
                val_3.wordWrap = true;
        }
        
        val_3.normal.textColor = new UnityEngine.Color() {r = Constants.GUI.Colors.EDITOR_TEXT_COLOR, g = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_4, b = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_8, a = Constants.GUI.Colors.EDITOR_TEXT_COLOR.__il2cppRuntimeField_C};
        Constants.GUI.Styles.EDITOR_TEXTURE_STYLE_DESCRIPTION_STYLE = val_3;
        UnityEngine.GUIStyle val_5 = new UnityEngine.GUIStyle();
        if(val_5 != null)
        {
                val_5.imagePosition = 2;
        }
        else
        {
                val_5.imagePosition = 2;
        }
        
        val_5.wordWrap = true;
        Constants.GUI.Styles.EDITOR_TEXTURE_THUMBNAIL_STYLE = val_5;
    }

}
