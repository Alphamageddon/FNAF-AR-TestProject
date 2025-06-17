using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface GSRequestGenerator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GameSparks.Core.GSRequestData GenerateStringFromChunk(AnimatronicEntity.SaveGameChunk chunk); // 0
    
    }

}
