using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class OptionsTabController.CategoryInstance
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SRDebugger.UI.Other.CategoryGroup <CategoryGroup>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> Options;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.UI.Other.CategoryGroup CategoryGroup { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SRDebugger.UI.Other.CategoryGroup get_CategoryGroup()
    {
        return (SRDebugger.UI.Other.CategoryGroup)this.<CategoryGroup>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_CategoryGroup(SRDebugger.UI.Other.CategoryGroup value)
    {
        this.<CategoryGroup>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public OptionsTabController.CategoryInstance(SRDebugger.UI.Other.CategoryGroup group)
    {
        this.Options = new System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase>();
        this.<CategoryGroup>k__BackingField = group;
    }

}
