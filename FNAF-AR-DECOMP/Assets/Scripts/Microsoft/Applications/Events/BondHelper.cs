using UnityEngine;

namespace Microsoft.Applications.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class BondHelper
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.DataModels.CsEvent objToSerialize, System.IO.MemoryStream outStream)
        {
            new Microsoft.Applications.Events.CompactBinaryProtocolWriter() = new Microsoft.Applications.Events.CompactBinaryProtocolWriter();
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  new Microsoft.Applications.Events.CompactBinaryProtocolWriter(), value:  objToSerialize, isBase:  false);
            T[] val_2 = (Microsoft.Applications.Events.CompactBinaryProtocolWriter)[1152921526147869600]._output.ToArray();
            int val_3 = (Microsoft.Applications.Events.CompactBinaryProtocolWriter)[1152921526147869600]._output.Count;
            if(outStream != null)
            {
                    return;
            }
        
        }
    
    }

}
