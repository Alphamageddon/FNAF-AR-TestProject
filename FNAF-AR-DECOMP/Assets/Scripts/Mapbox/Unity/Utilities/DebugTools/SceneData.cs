using UnityEngine;

namespace Mapbox.Unity.Utilities.DebugTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SceneData : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ScenePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D Image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.TextAsset Text;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SceneData()
        {
        
        }
    
    }

}
