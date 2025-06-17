using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LightningBolt.<>c__DisplayClass48_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBolt <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 start;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 end;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBoltParameters parameters;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningLightParameters lp;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int startGroupIndex;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DigitalRuby.ThunderAndLightning.LightningBoltQualitySetting quality;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningBolt.<>c__DisplayClass48_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <RenderLightningBolt>b__0()
    {
        UnityEngine.Vector3 val_2;
        float val_3;
        float val_4;
        UnityEngine.Vector3 val_5;
        DigitalRuby.ThunderAndLightning.LightningBoltParameters val_6;
        float val_7;
        float val_8;
        float val_9;
        DigitalRuby.ThunderAndLightning.LightningBoltParameters val_10;
        val_2 = this.start;
        val_5 = this.end;
        val_6 = this.parameters;
        if(val_6 == null)
        {
            goto label_1;
        }
        
        val_9 = this.parameters.TrunkWidth;
        val_10 = val_6;
        goto label_4;
        label_1:
        val_10 = this.parameters;
        val_9 = this.parameters.TrunkWidth;
        if(val_10 == null)
        {
            goto label_3;
        }
        
        val_6 = val_10;
        val_2 = val_2;
        goto label_4;
        label_3:
        val_6 = this.parameters;
        val_2 = val_2;
        if(val_6 == null)
        {
            goto label_5;
        }
        
        label_4:
        if((this.<>4__this) == null)
        {
                val_3 = V9.16B;
            val_4 = V10.16B;
            val_5 = val_5;
            val_8 = V12.16B;
            val_7 = ???;
        }
        
        this.<>4__this.RenderParticleSystems(start:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, end:  new UnityEngine.Vector3() {x = val_5, y = val_7, z = val_8}, trunkWidth:  val_9, lifeTime:  this.parameters.LifeTime, delaySeconds:  this.parameters.delaySeconds);
        if(this.lp == null)
        {
                return;
        }
        
        this.<>4__this.CreateLightsForGroup(group:  this.<>4__this.segmentGroups.Item[this.startGroupIndex], lp:  this.lp, quality:  this.quality, maxLights:  this.parameters.maxLights);
        return;
        label_5:
    }

}
