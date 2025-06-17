using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TitleNewsItem : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Body;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NewsId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Timestamp;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TitleNewsItem()
        {
        
        }
    
    }

}
