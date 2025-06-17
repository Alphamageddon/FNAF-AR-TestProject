using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<>c__DisplayClass44_2
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform transform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBolt.<>c__DisplayClass44_1 CS$<>8__locals2;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<>c__DisplayClass44_2()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ProcessAllLightningParameters>b__0()
    {
        if((this.CS$<>8__locals2) != null)
        {
            goto label_6;
        }
        
        this.CS$<>8__locals2 = this.CS$<>8__locals2;
        if((this.CS$<>8__locals2) == null)
        {
            goto label_7;
        }
        
        label_6:
        UnityEngine.Coroutine val_2 = this.CS$<>8__locals2.CS$<>8__locals1.dependenciesRef.StartCoroutine.Invoke(arg:  DigitalRuby.ThunderAndLightning.LightningBolt.NotifyBolt(dependencies:  this.CS$<>8__locals2.CS$<>8__locals1.dependenciesRef, p:  this.CS$<>8__locals2.parameters, transform:  this.transform, start:  new UnityEngine.Vector3() {x = this.CS$<>8__locals2.parameters.Start, y = V9.16B, z = V10.16B}, end:  new UnityEngine.Vector3() {x = this.CS$<>8__locals2.parameters.End, y = V11.16B, z = V12.16B}));
        return;
        label_7:
    }

}
