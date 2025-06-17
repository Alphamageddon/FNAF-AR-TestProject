using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateBuildWithCustomContainerResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.ContainerFlavor> ContainerFlavor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ContainerRunCommand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> CreationTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.ContainerImageReference CustomGameContainerImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.AssetReference> GameAssetReferences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.GameCertificateReference> GameCertificateReferences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MultiplayerServerCountPerVm;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.Port> Ports;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.BuildRegion> RegionConfigurations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.AzureVmSize> VmSize;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateBuildWithCustomContainerResponse()
        {
        
        }
    
    }

}
