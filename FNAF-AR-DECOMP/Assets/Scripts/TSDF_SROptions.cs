using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TSDF_SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private com.illumix.TSDF.TSDF_Manager tSDF;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float WeightThreshold { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float FPUpdate { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int BlockSize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int MaxBlocks { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.WeightSystem WeightSys { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int MaxWeight { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ThresholdTileRatio { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ThresholdSmoothRatio { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool HideMesh { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ShowParticles { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float CoarseResolution { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float CoarseSdfThreshold { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float CoarseMu { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.PostProcessing CoarsePostProcessingType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseMask { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool DisableFeaturePoints { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseBlockMask { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ShowColumns { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ChangesToUpdateBlock { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ShowProfiling { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnableRemoval { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AddFilter { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_SROptions(com.illumix.TSDF.TSDF_Manager tSDF)
    {
        this.tSDF = tSDF;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_WeightThreshold()
    {
        if(this.tSDF.config != null)
        {
                return (float)this.tSDF.config.weightThreshold;
        }
        
        return (float)this.tSDF.config.weightThreshold;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WeightThreshold(float value)
    {
        this.tSDF.config.weightThreshold = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ClearTSDF()
    {
        this.tSDF.ClearData();
        this.tSDF.SetupData();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_FPUpdate()
    {
        if(this.tSDF.config != null)
        {
                return (float)this.tSDF.config.updateTime;
        }
        
        return (float)this.tSDF.config.updateTime;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FPUpdate(float value)
    {
        this.tSDF.config.updateTime = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_BlockSize()
    {
        if(this.tSDF.config != null)
        {
                return (int)this.tSDF.config.blockSize;
        }
        
        return (int)this.tSDF.config.blockSize;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BlockSize(int value)
    {
        this.tSDF.config.blockSize = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_MaxBlocks()
    {
        if(this.tSDF.config != null)
        {
                return (int)this.tSDF.config.maxCoordsToUpdate;
        }
        
        return (int)this.tSDF.config.maxCoordsToUpdate;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxBlocks(int value)
    {
        this.tSDF.config.maxCoordsToUpdate = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.WeightSystem get_WeightSys()
    {
        if(this.tSDF.config != null)
        {
                return (TSDF_Config.WeightSystem)this.tSDF.config.weightSystem;
        }
        
        return (TSDF_Config.WeightSystem)this.tSDF.config.weightSystem;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WeightSys(TSDF_Config.WeightSystem value)
    {
        this.tSDF.config.weightSystem = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_MaxWeight()
    {
        if(this.tSDF.config != null)
        {
                return (int)this.tSDF.config.maxWeight;
        }
        
        return (int)this.tSDF.config.maxWeight;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxWeight(int value)
    {
        this.tSDF.config.maxWeight = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_ThresholdTileRatio()
    {
        if(this.tSDF.config != null)
        {
                return (float)this.tSDF.config.thresholdTileLayerRatio;
        }
        
        return (float)this.tSDF.config.thresholdTileLayerRatio;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThresholdTileRatio(float value)
    {
        this.tSDF.config.thresholdTileLayerRatio = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_ThresholdSmoothRatio()
    {
        if(this.tSDF.config != null)
        {
                return (float)this.tSDF.config.thresholdSmoothLayerRatio;
        }
        
        return (float)this.tSDF.config.thresholdSmoothLayerRatio;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThresholdSmoothRatio(float value)
    {
        this.tSDF.config.thresholdSmoothLayerRatio = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_HideMesh()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.hideMesh;
        }
        
        return (bool)this.tSDF.config.hideMesh;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HideMesh(bool value)
    {
        this.tSDF.config.hideMesh = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ShowParticles()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.showParticles;
        }
        
        return (bool)this.tSDF.config.showParticles;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShowParticles(bool value)
    {
        this.tSDF.config.showParticles = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_CoarseResolution()
    {
        if(this.tSDF.config != null)
        {
                return (float)this.tSDF.config.props;
        }
        
        return (float)this.tSDF.config.props;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CoarseResolution(float value)
    {
        this.tSDF.config.props = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_CoarseSdfThreshold()
    {
        if(this.tSDF.config != null)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CoarseSdfThreshold(float value)
    {
        mem2[0] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_CoarseMu()
    {
        if(this.tSDF.config != null)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CoarseMu(float value)
    {
        mem2[0] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TSDF_Config.PostProcessing get_CoarsePostProcessingType()
    {
        if(this.tSDF.config != null)
        {
                return 0;
        }
        
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CoarsePostProcessingType(TSDF_Config.PostProcessing value)
    {
        mem2[0] = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CountData()
    {
        this.tSDF.CountData();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseMask()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.useMask;
        }
        
        return (bool)this.tSDF.config.useMask;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseMask(bool value)
    {
        this.tSDF.config.useMask = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_DisableFeaturePoints()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.disableFeaturePoints;
        }
        
        return (bool)this.tSDF.config.disableFeaturePoints;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisableFeaturePoints(bool value)
    {
        this.tSDF.config.disableFeaturePoints = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseBlockMask()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.useBlockMask;
        }
        
        return (bool)this.tSDF.config.useBlockMask;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseBlockMask(bool value)
    {
        this.tSDF.config.useBlockMask = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ShowColumns()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.showColumns;
        }
        
        return (bool)this.tSDF.config.showColumns;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShowColumns(bool value)
    {
        this.tSDF.config.showColumns = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_ChangesToUpdateBlock()
    {
        if(this.tSDF.config != null)
        {
                return (int)this.tSDF.config.changesToUpdateSmoothLayer;
        }
        
        return (int)this.tSDF.config.changesToUpdateSmoothLayer;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChangesToUpdateBlock(int value)
    {
        this.tSDF.config.changesToUpdateSmoothLayer = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ShowProfiling()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.showTimeOutput;
        }
        
        return (bool)this.tSDF.config.showTimeOutput;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShowProfiling(bool value)
    {
        this.tSDF.config.showTimeOutput = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_EnableRemoval()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.smoothEnableRemoval;
        }
        
        return (bool)this.tSDF.config.smoothEnableRemoval;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EnableRemoval(bool value)
    {
        this.tSDF.config.smoothEnableRemoval = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_AddFilter()
    {
        if(this.tSDF.config != null)
        {
                return (bool)this.tSDF.config.smoothAddFilter;
        }
        
        return (bool)this.tSDF.config.smoothAddFilter;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AddFilter(bool value)
    {
        this.tSDF.config.smoothAddFilter = value;
    }

}
