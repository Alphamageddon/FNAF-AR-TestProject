using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public enum GuideEvent
    {
        // Fields
        IMMEDIATE = 0
        ,EVERY_SECOND = 1
        ,SCREEN_OPENED = 2
        ,SCREEN_CLOSING = 3
        ,UI_CLICK = 4
        ,ANIMATRONIC_SHOCKED = 5
        ,ANIMATRONIC_ATTACK_WINDOW_CLOSED = 6
        ,ANIMATRONIC_PHASE_COMPLETED = 7
        ,ANIMATRONIC_RETURNED_WITH_WEAR = 8
        ,TUTORIAL_REWARDS_TRIGGERED = 9
        ,STARTUP_TASK_COMPLETED = 10
        ,ENCOUNTER_STARTED = 11
        ,ENCOUNTER_ENDED = 12
        ,ANIMATRONIC_DEFEATED = 13
        ,PLAYER_MAX_STREAK_REACHED = 14
        ,UNIQUE_REMNANT_COUNT_REACHED = 15
        ,UNIQUE_MOD_COUNT_REACHED = 16
        ,UNIQUE_CPU_COUNT_REACHED = 17
        ,UNIQUE_PLUSHSUIT_COUNT_REACHED = 18
        
    
    }

}
