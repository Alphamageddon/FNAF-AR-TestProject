using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string sceneToLoad;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  this.sceneToLoad);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadExample()
        {
        
        }
    
    }

}
