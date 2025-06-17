using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class EssenceVisualsParent.<>c__DisplayClass18_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.EssenceCollection.Visuals.EssenceVisualsParent <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string type;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Game.EssenceCollection.Visuals.EssenceVisual> essenceVisualCallback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EssenceVisualsParent.<>c__DisplayClass18_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <CreateNewEssence>b__0(UnityEngine.GameObject essenceVisualPrefab)
    {
        this.<>4__this.EssenceLoadSuccess(type:  this.type, essenceVisualPrefab:  essenceVisualPrefab, essenceVisualCallback:  this.essenceVisualCallback);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <CreateNewEssence>b__1()
    {
        0.EssenceLoadFailure(type:  this.type);
    }

}
