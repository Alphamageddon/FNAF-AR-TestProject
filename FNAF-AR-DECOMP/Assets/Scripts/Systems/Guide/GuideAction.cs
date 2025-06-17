using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public enum GuideAction
    {
        // Fields
        DELAY = 0
        ,SHOW_ALERT = 1
        ,OPEN_POPUP = 2
        ,INSTANTIATE_PREFAB = 3
        ,INVOKE_AUDIO = 4
        ,TOGGLE_BATTERY = 5
        ,TOGGLE_EMF = 6
        ,TOGGLE_EXTRA_BATTERY = 7
        ,TOGGLE_FLASHLIGHT = 8
        ,TOGGLE_REMNANT = 9
        ,TOGGLE_SHOCKER = 10
        ,TOGGLE_RETURN_TO_MAP = 11
        ,POINT_AT_ELEMENT = 12
        ,DISMISS_POINTER = 13
        ,ZOOM_MAP = 14
        ,SHOW_SCRIM = 15
        ,HIDE_SCRIM = 16
        ,ALLOW_TAP = 17
        ,ALLOW_CAMERA_PERMISSION = 18
        ,EMULATE_BUTTON = 19
        ,DISABLE_BUTTON = 20
        ,ENABLE_BUTTON = 21
        ,POINT_AT_MAP_ELEMENT = 22
        ,DISMISS_MAP_POINTER = 23
        ,SUMMON_TUTORIAL_ENCOUNTER = 24
        ,SIMULATE_ENCOUNTER_LOSS = 25
        ,SIMULATE_ENCOUNTER_WON = 26
        ,SAVE_STEP = 27
        ,SET_FEATURE_FLAGS = 28
        ,EVENT_RESOLUTION_MAPPING = 29
        ,SEND_INBOX_MESSAGE = 30
        ,QUERY = 31
        ,OPEN_URI = 32
        ,OPEN_PLATFORM_I_A_URI = 33
        ,SAVE_GUIDE_TIMESTAMP = 34
        ,SAVE_GUIDE_INTEGER = 35
        ,CLEAR_GUIDE_DATA = 36
        ,SHOW_GENERIC_DIALOGUE = 37
        ,REQUEST_PUSHNOTIFICATION = 38
        ,SHOW_BOTTOM_BAR = 39
        ,FORCE_RESTART = 40
        
    
    }

}
