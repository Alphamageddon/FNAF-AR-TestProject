using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public enum GuideCondition
    {
        // Fields
        NONE = 0
        ,ENTITY_SAME_ROOM = 1
        ,ENTITY_APPROACHING = 2
        ,ENTITY_STALKING = 3
        ,PLAYER_STREAK_AT_LEAST = 4
        ,GUIDE_INTEGER_GREATER_THAN = 5
        ,GUIDE_INTEGER_LESS_THAN = 6
        ,GUIDE_TIMESPAN_GREATER_THAN = 7
        ,GUIDE_TIMESPAN_LESS_THAN = 8
        ,CHECK_ACTIVE_SEASON_GROUP = 9
        ,STARTER_PACK_NOT_OWNED = 10
        
    
    }

}
