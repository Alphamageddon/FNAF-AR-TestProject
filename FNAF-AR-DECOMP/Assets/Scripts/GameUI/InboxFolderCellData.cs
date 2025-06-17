using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxFolderCellData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string folderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string folderLocKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numEmailsInFolder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> SelectFolderDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> DeleteFolderDelegate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isCurrentFolder;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxFolderCellData()
        {
        
        }
    
    }

}
