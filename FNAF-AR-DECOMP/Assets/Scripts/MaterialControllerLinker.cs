using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MaterialControllerLinker : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnimatronicMaterialController[] Controllers;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AnimatronicMaterialController source;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AnimatronicMaterialController[] destinations;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _controllerNotNull;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        AnimatronicMaterialController[] val_3;
        if(this.Controllers == null)
        {
                return;
        }
        
        val_3 = this.Controllers;
        if(this.Controllers.Length == 0)
        {
                val_3 = this.Controllers;
        }
        
        this.source = this.Controllers[0];
        this.destinations = System.Linq.Enumerable.ToArray<AnimatronicMaterialController>(source:  System.Linq.Enumerable.Skip<AnimatronicMaterialController>(source:  val_3, count:  1));
        this._controllerNotNull = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_5;
        if(this._controllerNotNull == false)
        {
                return;
        }
        
        val_5 = 0;
        goto label_1;
        label_15:
        AnimatronicMaterialController val_5 = this.destinations[0];
        if(this.source.IsColorOverriden() != false)
        {
                UnityEngine.Color val_2 = this.source.GetEyeColorOverride();
            val_5.StartEyeColorOverride(color:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        }
        else
        {
                val_5.EndEyeColorOverride();
        }
        
        this.destinations[0x0][0].eyeGlowMultiplier = this.source.eyeGlowMultiplier;
        val_5.SetEyeGlow(eyeGlowEnabled:  this.source.IsGlowing());
        this.destinations[0x0][0].wearAndTearPercentage = this.source.wearAndTearPercentage;
        val_5 = 1;
        this.destinations[0x0][0].offset = this.source.offset;
        label_1:
        if(val_5 < this.destinations.Length)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaterialControllerLinker()
    {
    
    }

}
