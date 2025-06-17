using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ISemanticVerticalPlaneAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnLabelTile(int id, UnityEngine.Vector2 key, string label, int predId, float confidence); // 0
    
    }

}
