using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class ISemanticGeometryHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string name;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SemanticsUpdate(UnityEngine.GameObject go, string label, int predId, UnityEngine.RaycastHit hit, float confidence); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetupDataHandler(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler handler); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ISemanticGeometryHandler()
        {
        
        }
    
    }

}
