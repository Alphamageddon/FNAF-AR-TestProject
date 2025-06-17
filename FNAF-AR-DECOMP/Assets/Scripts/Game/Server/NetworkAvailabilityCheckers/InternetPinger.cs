using UnityEngine;

namespace Game.Server.NetworkAvailabilityCheckers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InternetPinger : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DelayBetweenPings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxTimeForPing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DelayBeforeRetry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TimesToRetry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool disablePinger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.NetworkAvailabilityCheckers.InternetPinger_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float timeTaken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int numRetries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool connectionIsOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool verbose;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator ConnectionTest()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new InternetPinger.<ConnectionTest>d__11();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ConnectionTest());
            Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
            this._eventExposer = val_3.eventExposer;
            Game.Server.NetworkAvailabilityCheckers.InternetPinger_SROptions val_4 = new Game.Server.NetworkAvailabilityCheckers.InternetPinger_SROptions();
            ._internetPinger = this;
            this._srOptions = val_4;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Internet Pinger Settings", sectionMenuObject:  val_4, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InternetPinger()
        {
            this.DelayBetweenPings = 0f;
            this.MaxTimeForPing = 1f;
            this.DelayBeforeRetry = 1f;
            this.TimesToRetry = 3;
            this.disablePinger = true;
            this.connectionIsOn = true;
        }
    
    }

}
