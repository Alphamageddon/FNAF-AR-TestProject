using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InitialDisplayNameSaver
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string InitialPlayerNameKey = "InitialPlayerNameKey";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SaveNameForNewPlayer(Systems.Server.ServerResponse response, Systems.Server.ChangeDisplayNameRequester changeDisplayNameRequester)
        {
            if((response.ScriptData.GetString(key:  "newPlayerName")) == null)
            {
                    return;
            }
            
            string val_4 = response.ScriptData.GetString(key:  "newPlayerName");
            var val_6 = 0;
            val_6 = val_6 + 1;
            changeDisplayNameRequester.ChangeDisplayName(displayName:  val_4);
            UnityEngine.PlayerPrefs.SetString(key:  "InitialPlayerNameKey", value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InitialDisplayNameSaver()
        {
        
        }
    
    }

}
