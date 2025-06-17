using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FeaturePointModifier_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FeaturePointModifier featurePointModifier;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ShowDebugVisuals { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FeaturePointModifier_SROptions(FeaturePointModifier pointCloudModifier)
    {
        this.featurePointModifier = pointCloudModifier;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ShowDebugVisuals()
    {
        if(this.featurePointModifier.config != null)
        {
                return (bool)this.featurePointModifier.config.showDebugVisuals;
        }
        
        return (bool)this.featurePointModifier.config.showDebugVisuals;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShowDebugVisuals(bool value)
    {
        this.featurePointModifier.config.showDebugVisuals = value;
    }

}
