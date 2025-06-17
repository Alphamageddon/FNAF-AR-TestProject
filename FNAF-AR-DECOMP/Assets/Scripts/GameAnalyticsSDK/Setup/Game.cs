using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Game
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <ID>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <GameKey>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <SecretKey>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ID { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GameKey { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SecretKey { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ID()
        {
            return (int)this.<ID>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ID(int value)
        {
            this.<ID>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_GameKey()
        {
            return (string)this.<GameKey>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_GameKey(string value)
        {
            this.<GameKey>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_SecretKey()
        {
            return (string)this.<SecretKey>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_SecretKey(string value)
        {
            this.<SecretKey>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game(string name, int id, string gameKey, string secretKey)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<ID>k__BackingField = id;
            this.<GameKey>k__BackingField = val_1;
            this.<SecretKey>k__BackingField = secretKey;
        }
    
    }

}
