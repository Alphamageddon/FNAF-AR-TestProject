using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DepthObjectManager_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DepthObjectManager depthObjectManager;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager.Representation Representation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int UpdateFrequency { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool SingleMap { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool FilterFP { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int Radius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ShowSpheres { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DepthToggle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float FPDeviation { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager_SROptions(DepthObjectManager depthObjectManager)
    {
        this.depthObjectManager = depthObjectManager;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthObjectManager.Representation get_Representation()
    {
        if(this.depthObjectManager.config != null)
        {
                return (DepthObjectManager.Representation)this.depthObjectManager.config.representation;
        }
        
        return (DepthObjectManager.Representation)this.depthObjectManager.config.representation;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Representation(DepthObjectManager.Representation value)
    {
        this.depthObjectManager.config.representation = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_UpdateFrequency()
    {
        if(this.depthObjectManager.config != null)
        {
                return (int)this.depthObjectManager.config.updateFrequency;
        }
        
        return (int)this.depthObjectManager.config.updateFrequency;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UpdateFrequency(int value)
    {
        this.depthObjectManager.config.updateFrequency = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_SingleMap()
    {
        if(this.depthObjectManager.config != null)
        {
                return (bool)this.depthObjectManager.config.onlyOneMap;
        }
        
        return (bool)this.depthObjectManager.config.onlyOneMap;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SingleMap(bool value)
    {
        this.depthObjectManager.config.onlyOneMap = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_FilterFP()
    {
        if(this.depthObjectManager.config != null)
        {
                return (bool)this.depthObjectManager.config.filterNearFP;
        }
        
        return (bool)this.depthObjectManager.config.filterNearFP;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FilterFP(bool value)
    {
        this.depthObjectManager.config.filterNearFP = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_Radius()
    {
        if(this.depthObjectManager.config != null)
        {
                return (int)this.depthObjectManager.config.radius;
        }
        
        return (int)this.depthObjectManager.config.radius;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Radius(int value)
    {
        this.depthObjectManager.config.radius = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ShowSpheres()
    {
        if(this.depthObjectManager.config != null)
        {
                return (bool)this.depthObjectManager.config.showSpheres;
        }
        
        return (bool)this.depthObjectManager.config.showSpheres;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShowSpheres(bool value)
    {
        this.depthObjectManager.config.showSpheres = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_DepthToggle()
    {
        if(this.depthObjectManager.config != null)
        {
                return (bool)this.depthObjectManager.config.enableDepthMap;
        }
        
        return (bool)this.depthObjectManager.config.enableDepthMap;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DepthToggle(bool value)
    {
        this.depthObjectManager.config.enableDepthMap = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_FPDeviation()
    {
        if(this.depthObjectManager.config != null)
        {
                return (float)this.depthObjectManager.config.fpDeviationThreshold;
        }
        
        return (float)this.depthObjectManager.config.fpDeviationThreshold;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FPDeviation(float value)
    {
        this.depthObjectManager.config.fpDeviationThreshold = value;
    }

}
