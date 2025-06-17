using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string logical;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int order;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string folderNameLocKey;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxData(ProtoData.INBOX_DATA.Types.ENTRY entry)
        {
            if(entry != null)
            {
                    this.logical = entry.InboxLogical;
            }
            else
            {
                    this.logical = 0.InboxLogical;
            }
            
            this.order = UnityEngine.Mathf.RoundToInt(f:  (float)entry.Order);
            this.folderNameLocKey = entry.DisplayFolderText;
        }
    
    }

}
