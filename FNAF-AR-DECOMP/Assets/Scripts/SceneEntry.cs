using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AmsMultiSceneSetup.SceneEntry
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsSceneReference scene;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool loadInEditor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CodingJar.MultiScene.AmsMultiSceneSetup.LoadMethod loadMethod;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AsyncOperation <asyncOp>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.AsyncOperation asyncOp { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.AsyncOperation get_asyncOp()
    {
        return (UnityEngine.AsyncOperation)this.<asyncOp>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_asyncOp(UnityEngine.AsyncOperation value)
    {
        this.<asyncOp>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return (string)System.String.Format(format:  "{0} loadInEditor: {1} loadMethod: {2}", arg0:  69734400, arg1:  this.loadInEditor, arg2:  this.loadMethod);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object obj)
    {
        var val_5;
        if(this != obj)
        {
                if(obj != null)
        {
                var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (AmsMultiSceneSetup.SceneEntry.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            if((this.scene & 1) != 0)
        {
                var val_2 = (this.loadInEditor == true) ? 1 : 0;
            val_2 = val_2 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (AmsMultiSceneSetup.SceneEntry.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 40) != 0) ? 1 : 0);
            var val_4 = ((this.<asyncOp>k__BackingField) == ((System.Object.__il2cppRuntimeField_typeHierarchy + (AmsMultiSceneSetup.SceneEntry.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 48)) ? 1 : 0;
            return (bool)val_5;
        }
        
        }
        
            val_5 = 0;
            return (bool)val_5;
        }
        
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        UnityEngine.XR.ARCore.ARCoreFaceRegion val_3 = this.loadMethod.region;
        int val_4 = this.loadInEditor.GetHashCode() << 1;
        val_4 = val_4 + (this.scene.GetHashCode() << 2);
        val_3 = val_4 + val_3;
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmsMultiSceneSetup.SceneEntry()
    {
    
    }

}
