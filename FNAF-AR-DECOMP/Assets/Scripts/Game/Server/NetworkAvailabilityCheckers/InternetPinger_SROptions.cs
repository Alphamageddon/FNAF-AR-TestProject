using UnityEngine;

namespace Game.Server.NetworkAvailabilityCheckers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InternetPinger_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.NetworkAvailabilityCheckers.InternetPinger _internetPinger;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DelayBetweenPings { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxTimeForPing { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DelayBeforeRetry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TimesToRetry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DisablePinger { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InternetPinger_SROptions(Game.Server.NetworkAvailabilityCheckers.InternetPinger internetPinger)
        {
            this._internetPinger = internetPinger;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DelayBetweenPings()
        {
            if(this._internetPinger != null)
            {
                    return (float)this._internetPinger.DelayBetweenPings;
            }
            
            return (float)this._internetPinger.DelayBetweenPings;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DelayBetweenPings(float value)
        {
            this._internetPinger.DelayBetweenPings = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaxTimeForPing()
        {
            if(this._internetPinger != null)
            {
                    return (float)this._internetPinger.MaxTimeForPing;
            }
            
            return (float)this._internetPinger.MaxTimeForPing;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxTimeForPing(float value)
        {
            this._internetPinger.MaxTimeForPing = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DelayBeforeRetry()
        {
            if(this._internetPinger != null)
            {
                    return (float)this._internetPinger.DelayBeforeRetry;
            }
            
            return (float)this._internetPinger.DelayBeforeRetry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DelayBeforeRetry(float value)
        {
            this._internetPinger.DelayBeforeRetry = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_TimesToRetry()
        {
            if(this._internetPinger != null)
            {
                    return (int)this._internetPinger.TimesToRetry;
            }
            
            return (int)this._internetPinger.TimesToRetry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TimesToRetry(int value)
        {
            this._internetPinger.TimesToRetry = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_DisablePinger()
        {
            if(this._internetPinger != null)
            {
                    return (bool)this._internetPinger.disablePinger;
            }
            
            return (bool)this._internetPinger.disablePinger;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DisablePinger(bool value)
        {
            this._internetPinger.disablePinger = value;
        }
    
    }

}
