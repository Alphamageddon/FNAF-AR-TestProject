using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SaveGameContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SAVEGAME_KEY_TIME = "Time";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SAVEGAME_KEY_ENTITIES = "AnimatronicEntities";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string SAVEGAME_KEY_STATS = "AnimatronicStats";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, object> saveGamePieces;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SaveGameContainer()
        {
            this.saveGamePieces = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
    
    }

}
