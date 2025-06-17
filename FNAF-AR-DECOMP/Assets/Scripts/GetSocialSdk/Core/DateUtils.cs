using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DateUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.DateTime FromUnixTime(long unixTime)
        {
            System.DateTime val_1 = 0.AddSeconds(value:  (double)unixTime);
            return (System.DateTime)val_1.dateData;
        }
    
    }

}
