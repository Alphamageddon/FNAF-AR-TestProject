using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AttachmentLinkToStoreCell : MonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToStore(string sectionToGoTo = "None")
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            GameUI.Domain val_2 = val_1.gameUIDomain;
            val_2.gameUIData.illumixButtonBlackBoard = sectionToGoTo;
            val_1.theGameDomain.gameDisplayChanger.RequestDisplayChange(displayType:  3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToDeviceSection()
        {
            this.GoToStore(sectionToGoTo:  "Device");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToLureSection()
        {
            this.GoToStore(sectionToGoTo:  "Lure");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToMiniPackSection()
        {
            this.GoToStore(sectionToGoTo:  "MiniPack");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToPackSection()
        {
            this.GoToStore(sectionToGoTo:  "Pack");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AttachmentLinkToStoreCell()
        {
        
        }
    
    }

}
