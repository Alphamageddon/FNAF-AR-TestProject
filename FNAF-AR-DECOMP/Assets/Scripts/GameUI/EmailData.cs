using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EmailData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TIME_FORMAT = "{0:HH:mm:ss}";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DATE_FORMAT = "MM/dd/yyyy";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string logical;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string recipientString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string fromString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string subjectString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string messageString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime receivedDateTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 rewardDataV3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.AudioItem audioItem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ImageItem imageItem;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isRead;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> tokens;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string templateBundle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string templatePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetTimeStamp()
        {
            var val_2 = (this.receivedDateTime.Day < 1) ? "{0:HH:mm:ss}" : "MM/dd/yyyy";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EmailData()
        {
            System.DateTime val_1 = System.DateTime.Now;
            this.receivedDateTime = val_1;
            this.id = System.String.alignConst;
            this.tags = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
