using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public struct AmsSceneReference
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string editorAssetGUID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string name;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _path;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.SceneManagement.Scene scene { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isLoaded { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string editorPath { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string runtimePath { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsSceneReference(UnityEngine.SceneManagement.Scene scene)
    {
        string val_1 = scene.m_Handle.path;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsSceneReference(string scenePath)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object obj)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        if(this._path == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.SceneManagement.Scene get_scene()
    {
        string val_1 = this._path;
        val_1 = val_1 & 4294967295;
        return (UnityEngine.SceneManagement.Scene)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsValid()
    {
        return (bool)this._path.IsValid();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_isLoaded()
    {
        return (bool)this._path.isLoaded;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_editorPath()
    {
        return (string)this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_editorPath(string value)
    {
        mem[1152921519069810016] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_runtimePath()
    {
        mem2[0] = mem[this._path];
        mem2[0] = this._path.m_stringLength;
        mem2[0] = mem[this._path + 24];
        return (string)this._path.m_stringLength;
    }

}
