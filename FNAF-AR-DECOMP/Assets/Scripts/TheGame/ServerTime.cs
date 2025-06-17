using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ServerTime
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long serverOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool initialized;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetServerTime(long serverTime)
        {
            System.DateTimeOffset val_1 = System.DateTimeOffset.UtcNow;
            TheGame.ServerTime.serverOffset = 0;
            if()
            {
                    TheGame.ServerTime.serverOffset = val_1.m_dateTime.dateData.ToUnixTimeSeconds() - serverTime;
            }
            
            TheGame.ServerTime.initialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long GetCurrentTime()
        {
            if(TheGame.ServerTime.initialized != false)
            {
                    System.DateTimeOffset val_1 = System.DateTimeOffset.UtcNow;
                long val_2 = val_1.m_dateTime.dateData.ToUnixTimeSeconds();
                val_2 = val_2 - TheGame.ServerTime.serverOffset;
                return (long)val_2;
            }
            
            System.Exception val_3 = new System.Exception();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsInitialized()
        {
            return (bool)TheGame.ServerTime.initialized;
        }
    
    }

}
