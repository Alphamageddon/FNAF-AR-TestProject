using UnityEngine;

namespace Game.DailyChallenge
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IDailyChallengeDomain
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.DailyChallenge.Container.DailyChallengeContainer DailyChallengeContainer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.DailyChallenge.Container.DailyChallengeContainer get_DailyChallengeContainer(); // 0
    
    }

}
