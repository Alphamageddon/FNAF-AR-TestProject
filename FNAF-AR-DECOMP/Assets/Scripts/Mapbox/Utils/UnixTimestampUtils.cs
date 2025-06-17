using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class UnixTimestampUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double To(System.DateTime date)
        {
            System.TimeSpan val_1 = date.dateData.Subtract(value:  new System.DateTime());
            return (double)val_1._ticks.TotalSeconds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.DateTime From(double timestamp)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  timestamp);
            return -1853653208;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.DateTime FromMilliseconds(double timestamp)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  timestamp);
            return -1853541208;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.DateTime From(long timestamp)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromTicks(value:  timestamp);
            return -1853429208;
        }
    
    }

}
