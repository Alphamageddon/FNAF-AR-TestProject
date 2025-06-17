using UnityEngine;

namespace Systems.Guide.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITutorialScrim
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ConfigureBlocking(bool isBlocking); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ConfigureMasking(bool isMasking); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ConfigureHighlight(UnityEngine.UI.Image targetElement); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ConfigureTapOverride(System.Action onTapAction); // 0
    
    }

}
