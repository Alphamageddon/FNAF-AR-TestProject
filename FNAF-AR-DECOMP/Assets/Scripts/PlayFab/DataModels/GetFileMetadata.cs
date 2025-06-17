using UnityEngine;

namespace PlayFab.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetFileMetadata : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Checksum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DownloadUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime LastModified;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Size;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetFileMetadata()
        {
        
        }
    
    }

}
