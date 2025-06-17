using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PopDownData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION uIDISPLAYRESTRICTION;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool show;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float showTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string senderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string iconGroupId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string iconId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool showUnidentifiedOverlay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string audioId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float startTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PopDownData()
        {
            this.showTime = 5f;
        }
    
    }

}
