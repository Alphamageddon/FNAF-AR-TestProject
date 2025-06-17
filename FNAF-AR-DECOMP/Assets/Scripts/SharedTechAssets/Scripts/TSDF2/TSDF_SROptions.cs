using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDF_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Manager tSDF;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float WeightThreshold { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FPUpdate { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BlockSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxWeight { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoarseResolution { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoarseSdfThreshold { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoarseMu { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseMask { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DisableFeaturePoints { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseBlockMask { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowProfiling { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TimeToClear { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_SROptions(SharedTechAssets.Scripts.TSDF2.TSDF_Manager tSDF)
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
        public int get_TimeToClear()
        {
            if(this.tSDF.config != null)
            {
                    return (int)this.tSDF.config.timeToDecay;
            }
            
            return (int)this.tSDF.config.timeToDecay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TimeToClear(int value)
        {
            this.tSDF.config.timeToDecay = value;
        }
    
    }

}
