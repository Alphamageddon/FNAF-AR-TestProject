using UnityEngine;

namespace Game.DailyChallenge
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeDomainSROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.DailyChallengeDomain _dailyChallengeDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeDomainSROptions(Game.DailyChallenge.DailyChallengeDomain geoPositionObjectDomain)
        {
            this._dailyChallengeDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteDailyChallenges()
        {
            this._dailyChallengeDomain.CompleteDailyChallenges();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshDailyChallenge()
        {
            this._dailyChallengeDomain.RefreshDailyChallenges();
        }
    
    }

}
