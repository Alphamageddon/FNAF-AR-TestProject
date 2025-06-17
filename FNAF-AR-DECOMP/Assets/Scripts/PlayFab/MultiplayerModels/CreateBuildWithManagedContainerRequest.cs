using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateBuildWithManagedContainerRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.ContainerFlavor> ContainerFlavor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.AssetReferenceParams> GameAssetReferences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.GameCertificateReferenceParams> GameCertificateReferences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.InstrumentationConfiguration InstrumentationConfiguration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Metadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MultiplayerServerCountPerVm;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.Port> Ports;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.BuildRegionParams> RegionConfigurations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StartMultiplayerServerCommand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.AzureVmSize> VmSize;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateBuildWithManagedContainerRequest()
        {
        
        }
    
    }

}
