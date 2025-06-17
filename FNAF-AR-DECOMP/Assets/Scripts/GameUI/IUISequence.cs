using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IUISequence
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void StartSequence(GameUI.UISequenceData data); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateSequence(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsSequenceDone(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void TeardownSequence(); // 0
    
    }

}
