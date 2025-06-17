using UnityEngine;

namespace Systems.Guide.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IGuideArrow
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowWithTarget(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 canvasOffset, float rotation, float scaling); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Hide(); // 0
    
    }

}
