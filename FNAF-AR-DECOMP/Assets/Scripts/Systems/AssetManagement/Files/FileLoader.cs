using UnityEngine;

namespace Systems.AssetManagement.Files
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FileLoader : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadFileFromPath(Systems.AssetManagement.Files.FileLoadSettings settings)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  Systems.AssetManagement.Files.FileLoader.LoadFile(settings:  settings));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFileFromUri(string uri, System.Action<string, UnityEngine.Networking.DownloadHandler> successCallback, System.Action<string> failureCallback)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  Systems.AssetManagement.Files.FileLoader.DownloadFile(uri:  uri, successCallback:  successCallback, failureCallback:  failureCallback));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator LoadFile(Systems.AssetManagement.Files.FileLoadSettings settings)
        {
            .<>1__state = 0;
            .settings = settings;
            return (System.Collections.IEnumerator)new FileLoader.<LoadFile>d__3();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator DownloadFile(string uri, System.Action<string, UnityEngine.Networking.DownloadHandler> successCallback, System.Action<string> failureCallback)
        {
            FileLoader.<DownloadFile>d__4 val_1 = new FileLoader.<DownloadFile>d__4();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .uri = uri;
                .successCallback = successCallback;
            }
            else
            {
                    mem[32] = uri;
                mem[48] = successCallback;
            }
            
            .failureCallback = failureCallback;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FileLoader()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static FileLoader()
        {
            Systems.AssetManagement.Files.FileLoader.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
