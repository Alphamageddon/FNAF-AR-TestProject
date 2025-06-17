using UnityEngine;

namespace Microsoft.Applications.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Utils
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly long TICKS_AT_1970;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long MsFrom1970()
        {
            var val_5;
            System.DateTime val_1 = System.DateTime.UtcNow;
            val_5 = null;
            val_5 = null;
            long val_5 = Microsoft.Applications.Events.Utils.TICKS_AT_1970;
            val_5 = val_1.dateData.Ticks - val_5;
            return (long)(val_5 >> 11) + (val_5 >> 63);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long TimestampNowTicks()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return (long)val_1.dateData.Ticks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string TenantID(string tenant)
        {
            var val_3;
            int val_4;
            val_3 = tenant;
            int val_1 = val_3.IndexOf(value:  "-", comparisonType:  4);
            if(val_1 >= 1)
            {
                    string val_2 = val_3.Substring(startIndex:  0, length:  val_1);
                return (string)val_4;
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utils()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Utils()
        {
            Microsoft.Applications.Events.Utils.TICKS_AT_1970 = 0.Ticks;
        }
    
    }

}
