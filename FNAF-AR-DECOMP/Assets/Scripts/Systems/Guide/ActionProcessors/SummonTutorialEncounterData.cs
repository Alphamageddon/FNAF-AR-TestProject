using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SummonTutorialEncounterData : IActionData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string cpuId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string plushSuitId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string, string, AnimatronicEntity.SaveGameChunk> callback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SummonTutorialEncounterData(string cpuId, string plushSuitId)
        {
            val_1 = new System.Object();
            this.isDone = false;
            this.cpuId = cpuId;
            this.plushSuitId = val_1;
        }
    
    }

}
