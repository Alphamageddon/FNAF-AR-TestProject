using UnityEngine;

namespace SharedTechAssets.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TechBootstrap_Config : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isRelease;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxDepthMap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxDirectedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxBoundedPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxSupportedPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxPlaneAwareMeshBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxObjectDetection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxSceneRecognition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxSemanticPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxSemanticVoxels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IxTrackedObjects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableDepthMapAugmentation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackedObjects_Voxels_Enabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoDownloadModels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string objectDetectionModelURL;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string depthEstimationModelURL;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sceneRecognitionModelURL;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<CVModels, string> modelURLs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool debug;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DepthModelRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool BoundedPlanesRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SupportedPlanesRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PlaneAwareMeshBlocksRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ObjDetectionRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SceneRecognitionRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SemanticPlanesRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SemanticVoxelsRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackedObjectsRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DownloadRequired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FeaturePointsRequired;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsDepthModelRequired()
        {
            if(this.IxDepthMap == true)
            {
                    return true;
            }
            
            if(this.IxDirectedPoints == false)
            {
                    return (bool)(this.EnableDepthMapAugmentation == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsBoundedPlanesRequired()
        {
            if(this.IxBoundedPlanes == true)
            {
                    return true;
            }
            
            if(this.IxSupportedPlanes == true)
            {
                    return true;
            }
            
            if(this.IxSemanticPlanes == true)
            {
                    return true;
            }
            
            if(this.IxPlaneAwareMeshBlocks == true)
            {
                    return true;
            }
            
            if(this.IxSemanticVoxels == false)
            {
                    return (bool)(this.IxTrackedObjects == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsSupportedPlanesRequired()
        {
            if(this.IxSupportedPlanes == true)
            {
                    return true;
            }
            
            if(this.IxSemanticPlanes == true)
            {
                    return true;
            }
            
            if(this.IxPlaneAwareMeshBlocks == true)
            {
                    return true;
            }
            
            if(this.IxSemanticVoxels == false)
            {
                    return (bool)(this.IxTrackedObjects == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsPlaneAwareMeshBlocksRequired()
        {
            if(this.IxPlaneAwareMeshBlocks == true)
            {
                    return true;
            }
            
            if(this.IxSemanticVoxels != false)
            {
                    return true;
            }
            
            if(this.IxTrackedObjects == false)
            {
                    return false;
            }
            
            return (bool)(this.TrackedObjects_Voxels_Enabled == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsObjDetectionRequired()
        {
            if(this.IxObjectDetection == true)
            {
                    return true;
            }
            
            if(this.IxSemanticPlanes == true)
            {
                    return true;
            }
            
            if(this.IxSemanticVoxels == false)
            {
                    return (bool)(this.IxTrackedObjects == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsSceneRecognitionRequired()
        {
            return (bool)this.IxSceneRecognition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsSemanticPlanesRequired()
        {
            if(this.IxSemanticPlanes == false)
            {
                    return (bool)(this.IxTrackedObjects == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsSemanticVoxelsRequired()
        {
            if(this.IxSemanticVoxels != false)
            {
                    return true;
            }
            
            if(this.IxTrackedObjects == false)
            {
                    return false;
            }
            
            return (bool)(this.TrackedObjects_Voxels_Enabled == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsTrackedObjectsRequired()
        {
            return (bool)this.IxTrackedObjects;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsDownloadRequired()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsFeaturePointsRequired()
        {
            if(this.IxSupportedPlanes == true)
            {
                    return true;
            }
            
            if(this.IxSemanticPlanes == true)
            {
                    return true;
            }
            
            if(this.IxPlaneAwareMeshBlocks == true)
            {
                    return true;
            }
            
            if(this.IxSemanticVoxels == false)
            {
                    return (bool)(this.IxTrackedObjects == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            bool val_5;
            bool val_6;
            bool val_7;
            bool val_8;
            bool val_9;
            if(this.IxDepthMap != true)
            {
                    if(this.IxDirectedPoints == false)
            {
                goto label_7;
            }
            
            }
            
            label_7:
            this.DepthModelRequired = true;
            if(this.IxBoundedPlanes == false)
            {
                goto label_2;
            }
            
            val_5 = true;
            this.BoundedPlanesRequired = val_5;
            if(this.IxSupportedPlanes == true)
            {
                goto label_6;
            }
            
            goto label_4;
            label_2:
            if(this.IxSupportedPlanes == false)
            {
                goto label_5;
            }
            
            val_5 = true;
            this.BoundedPlanesRequired = val_5;
            goto label_6;
            label_5:
            if((this.IxSemanticPlanes != true) && (this.IxPlaneAwareMeshBlocks != true))
            {
                    if(this.IxSemanticVoxels == false)
            {
                goto label_31;
            }
            
            }
            
            label_31:
            this.BoundedPlanesRequired = true;
            label_4:
            if((this.IxSemanticPlanes != true) && (this.IxPlaneAwareMeshBlocks != true))
            {
                    if(this.IxSemanticVoxels == false)
            {
                goto label_30;
            }
            
            }
            
            val_5 = 0;
            label_6:
            label_30:
            this.SupportedPlanesRequired = true;
            if(this.IxPlaneAwareMeshBlocks != true)
            {
                    if(this.IxSemanticVoxels == false)
            {
                goto label_15;
            }
            
            }
            
            label_28:
            val_6 = this.IxSemanticPlanes;
            this.PlaneAwareMeshBlocksRequired = true;
            if(this.IxObjectDetection == true)
            {
                goto label_18;
            }
            
            if(val_6 == false)
            {
                goto label_17;
            }
            
            val_6 = 1;
            goto label_18;
            label_15:
            if(this.IxTrackedObjects == false)
            {
                goto label_28;
            }
            
            goto label_28;
            label_17:
            if(this.IxSemanticVoxels == false)
            {
                goto label_29;
            }
            
            val_6 = 0;
            label_18:
            label_29:
            this.ObjDetectionRequired = true;
            this.SceneRecognitionRequired = this.IxSceneRecognition;
            if(val_6 != 0)
            {
                    val_7 = 1;
            }
            else
            {
                    val_7 = this.IxTrackedObjects;
            }
            
            val_8 = this.IxTrackedObjects;
            this.SemanticPlanesRequired = val_7;
            if(this.IxSemanticVoxels != false)
            {
                    val_9 = 1;
            }
            else
            {
                    if(val_8 != false)
            {
                    val_9 = this.TrackedObjects_Voxels_Enabled;
                val_8 = 1;
            }
            else
            {
                    val_9 = false;
            }
            
            }
            
            val_5 = val_5 | ((val_6 != 0) ? 1 : 0);
            val_5 = val_5 | ((this.IxPlaneAwareMeshBlocks == true) ? 1 : 0);
            this.SemanticVoxelsRequired = val_9;
            this.TrackedObjectsRequired = val_8;
            this.DownloadRequired = false;
            this.FeaturePointsRequired = (val_5 == 0) ? ((this.IxSemanticVoxels == false) ? (val_8) : (0 + 1)) : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TechBootstrap_Config()
        {
        
        }
    
    }

}
