using UnityEngine;

namespace Game.AttackSequence.Encounters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EncounterResult
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EncounterType EncounterType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CpuId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlushSuitId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AnimatronicAudioId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PlayerDidWin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int OldCurrentStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int OldBestStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NewCurrentStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NewBestStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurrentRemnant;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EncounterResult()
        {
        
        }
    
    }

}
