using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<>c__DisplayClass41_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBolt <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBolt.LineRendererMesh currentLineRenderer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<>c__DisplayClass41_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <RenderGroup>b__0()
    {
        this.<>4__this.EnableCurrentLineRenderer();
        this.currentLineRenderer = this.<>4__this.GetOrCreateLineRenderer();
    }

}
