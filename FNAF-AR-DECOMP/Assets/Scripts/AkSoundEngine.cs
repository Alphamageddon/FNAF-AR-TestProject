using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkSoundEngine
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SIMD_ALIGNMENT = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_BUFFER_ALIGNMENT = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_PATH = 260;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_PLUGINID = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_UNIQUE_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_RTPC_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_LISTENER_INDEX = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_PLAYING_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_DEFAULT_SWITCH_STATE = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_INVALID_POOL_ID = -1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_DEFAULT_POOL_ID = -1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_AUX_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_FILE_ID = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_DEVICE_ID = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_BANK_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_CHANNELMASK = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_MIXER_FX_SLOT = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const ulong AK_DEFAULT_LISTENER_OBJ = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_DEFAULT_PRIORITY = 50;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_MIN_PRIORITY = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_MAX_PRIORITY = 100;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AKCOMPANYID_AUDIOKINETIC = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const uint AK_LISTENERS_MASK_ALL = 4294967295;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NULL = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_LANGUAGE_NAME_SIZE = 32;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_PLUGINDEV_MIN = 64;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_PLUGINDEV_MAX = 255;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_MCDSP = 256;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_WAVEARTS = 257;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_PHONETICARTS = 258;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_IZOTOPE = 259;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_CRANKCASEAUDIO = 261;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_IOSONO = 262;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_AUROTECHNOLOGIES = 263;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_DOLBY = 264;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_TWOBIGEARS = 265;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_OCULUS = 266;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_BLUERIPPLESOUND = 267;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_ENZIEN = 268;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_KROTOS = 269;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_NURULIZE = 270;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_SUPERPOWERED = 271;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_GOOGLE = 272;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCOMPANYID_VISISONICS = 277;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_BANK = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_PCM = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_ADPCM = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_XMA = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_VORBIS = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_WIIADPCM = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_PCMEX = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_EXTERNAL_SOURCE = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_XWMA = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_AAC = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_FILE_PACKAGE = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_ATRAC9 = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_VAG = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_PROFILERCAPTURE = 14;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_ANALYSISFILE = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_MIDI = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_OPUSNX = 17;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_CAF = 18;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKCODECID_AKOPUS = 19;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKPLUGINID_METER = 129;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKPLUGINID_RECORDER = 132;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKEXTENSIONID_SPATIALAUDIO = 800;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AKEXTENSIONID_EVENTMGRTHREAD = 900;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_VAG = 65531;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_AT9 = 65532;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_VORBIS = 65535;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_AAC = 43712;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_OPUSNX = 12345;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_WAVE_FORMAT_OPUS = 12352;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WAVE_FORMAT_XMA2 = 358;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_PANNER_NUM_STORAGE_BITS = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPAT_NUM_STORAGE_BITS = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_BITS_METERING_FLAGS = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_OS_STRUCT_ALIGN = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_64B_OS_STRUCT_ALIGN = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const bool AK_ASYNC_OPEN_DEFAULT = False;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_INVALID = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_SYSEX = 240;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_EVENT_TYPE_META = 255;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_3_COARSE = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_VOLUME_COARSE = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BALANCE_COARSE = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_9_COARSE = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EXPRESSION_COARSE = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_14_COARSE = 14;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_15_COARSE = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GEN_SLIDER_1 = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GEN_SLIDER_2 = 17;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GEN_SLIDER_3 = 18;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GEN_SLIDER_4 = 19;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_20_COARSE = 20;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_21_COARSE = 21;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_22_COARSE = 22;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_23_COARSE = 23;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_24_COARSE = 24;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_25_COARSE = 25;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_26_COARSE = 26;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_27_COARSE = 27;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_28_COARSE = 28;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_29_COARSE = 29;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_30_COARSE = 30;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_31_COARSE = 31;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BANK_SELECT_FINE = 32;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_3_FINE = 35;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PORTAMENTO_FINE = 37;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_VOLUME_FINE = 39;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_BALANCE_FINE = 40;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_9_FINE = 41;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PAN_POSITION_FINE = 42;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EXPRESSION_FINE = 43;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_14_FINE = 46;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_15_FINE = 47;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_20_FINE = 52;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_21_FINE = 53;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_22_FINE = 54;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_23_FINE = 55;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_24_FINE = 56;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_25_FINE = 57;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_26_FINE = 58;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_27_FINE = 59;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_28_FINE = 60;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_29_FINE = 61;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_30_FINE = 62;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CTRL_31_FINE = 63;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_HOLD_PEDAL = 64;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOFT_PEDAL = 67;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_LEGATO_PEDAL = 68;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_VARIATION = 70;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_TIMBRE = 71;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_CTRL_6 = 75;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_CTRL_7 = 76;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_CTRL_8 = 77;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_CTRL_9 = 78;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_SOUND_CTRL_10 = 79;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_REVERB_LEVEL = 91;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_TREMOLO_LEVEL = 92;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CHORUS_LEVEL = 93;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_CELESTE_LEVEL = 94;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_PHASER_LEVEL = 95;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_NON_REGISTER_FINE = 99;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_ALL_SOUND_OFF = 120;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_ALL_NOTES_OFF = 123;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_OMNI_MODE_OFF = 124;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_OMNI_MODE_ON = 125;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_FRONT_LEFT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_FRONT_RIGHT = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_FRONT_CENTER = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_LOW_FREQUENCY = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_BACK_LEFT = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_BACK_RIGHT = 32;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_BACK_CENTER = 256;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SIDE_LEFT = 512;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SIDE_RIGHT = 1024;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_TOP = 2048;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_MONO = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_0POINT1 = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_1POINT1 = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_STEREO = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_2POINT1 = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_3STEREO = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_3POINT1 = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_4 = 1539;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_4POINT1 = 1547;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_5 = 1543;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_5POINT1 = 1551;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_6 = 1587;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_6POINT1 = 1595;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_7 = 1591;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_7POINT1 = 1599;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_SURROUND = 259;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DPL2 = 1539;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_222 = 22019;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_8 = 185859;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_9 = 185863;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_10 = 187911;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_11 = 196103;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_FRONT_LEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_FRONT_RIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_CENTER = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_0_LFE = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_1_CENTER = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_1_LFE = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_2_LEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_2_RIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_2_LFE = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_3_LEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_3_RIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_3_CENTER = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_3_LFE = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_4_FRONTLEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_4_FRONTRIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_4_REARLEFT = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_4_REARRIGHT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_4_LFE = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_FRONTLEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_FRONTRIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_CENTER = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_REARLEFT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_REARRIGHT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_5_LFE = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_FRONTLEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_FRONTRIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_REARLEFT = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_REARRIGHT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_SIDELEFT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_SIDERIGHT = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_6_LFE = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_FRONTLEFT = 0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_FRONTRIGHT = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_CENTER = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_REARLEFT = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_REARRIGHT = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_SIDELEFT = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_SIDERIGHT = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_IDX_SETUP_7_LFE = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_0_1 = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_1_0_CENTER = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_1_1_CENTER = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_2_0 = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_2_1 = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_3_0 = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_3_1 = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_FRONT = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_4_0 = 1539;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_4_1 = 1547;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_5_0 = 1543;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_5_1 = 1551;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_6_0 = 1587;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_6_1 = 1595;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_7_0 = 1591;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_7_1 = 1599;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_STANDARD_MAX_NUM_CHANNELS = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_NUM_SAMPLED_SPHERE_POINTS = 32;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_NUM_TEXTURE = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_REFLECT_ORDER = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_REFLECTION_PATH_LENGTH = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_DEFAULT_MOVEMENT_THRESHOLD = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_SA_EPSILON = 0.001;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_SA_DIFFRACTION_EPSILON = 0.1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const double AK_SA_PLANE_THICKNESS_RATIO = 0.005;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkSoundEngine.GameObjectHashFunction gameObjectHash;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const string Deprecation_2019_1_1 = "This functionality is deprecated as of Wwise v2019.1.1 and will be removed in a future release.";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.HashSet<ulong> RegisteredGameObjects;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint AK_SOUNDBANK_VERSION { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ushort AK_INT { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ushort AK_FLOAT { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte AK_INTERLEAVED { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte AK_NONINTERLEAVED { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint AK_LE_NATIVE_BITSPERSAMPLE { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint AK_LE_NATIVE_SAMPLETYPE { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint AK_LE_NATIVE_INTERLEAVE { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte AK_INVALID_MIDI_CHANNEL { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte AK_INVALID_MIDI_NOTE { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float kDefaultMaxPathLength { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint kDefaultDiffractionMaxEdges { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint kDefaultDiffractionMaxPaths { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float kMaxDiffraction { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint kListenerDiffractionMaxEdges { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint kListenerDiffractionMaxPaths { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint kPortalToPortalDiffractionMaxPaths { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int g_SpatialAudioPoolId { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkSoundEngine.GameObjectHashFunction GameObjectHash { set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_AK_SOUNDBANK_VERSION()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_SOUNDBANK_VERSION_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ushort get_AK_INT()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_INT_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ushort get_AK_FLOAT()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_FLOAT_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte get_AK_INTERLEAVED()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_INTERLEAVED_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte get_AK_NONINTERLEAVED()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_NONINTERLEAVED_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_AK_LE_NATIVE_BITSPERSAMPLE()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_AK_LE_NATIVE_SAMPLETYPE()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_LE_NATIVE_SAMPLETYPE_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_AK_LE_NATIVE_INTERLEAVE()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_LE_NATIVE_INTERLEAVE_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
    {
        IntPtr val_8;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_8 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_8 == null)
        {
            goto label_10;
        }
        
        label_9:
        val_8 = System.IntPtr.op_Explicit(value:  val_8.GetHashCode());
        label_10:
        uint val_7 = AkSoundEnginePINVOKE.CSharp_DynamicSequenceOpen__SWIG_0(jarg1:  val_1, jarg2:  val_2, jarg3:  System.IntPtr.op_Explicit(value:  1), jarg4:  val_8, jarg5:  in_eDynamicSequenceType);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_7);
        return val_7;
        label_3:
        if(val_8 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
    {
        IntPtr val_8;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_8 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_8 == null)
        {
            goto label_10;
        }
        
        label_9:
        val_8 = System.IntPtr.op_Explicit(value:  val_8.GetHashCode());
        label_10:
        uint val_7 = AkSoundEnginePINVOKE.CSharp_DynamicSequenceOpen__SWIG_1(jarg1:  val_1, jarg2:  val_2, jarg3:  System.IntPtr.op_Explicit(value:  1), jarg4:  val_8);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_7);
        return val_7;
        label_3:
        if(val_8 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint DynamicSequenceOpen(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        uint val_2 = AkSoundEnginePINVOKE.CSharp_DynamicSequenceOpen__SWIG_2(jarg1:  val_1);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_2);
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceClose(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceClose(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePlay__SWIG_0(jarg1:  in_playingID, jarg2:  in_uTransitionDuration, jarg3:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePlay__SWIG_1(jarg1:  in_playingID, jarg2:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePlay(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePlay__SWIG_2(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePause__SWIG_0(jarg1:  in_playingID, jarg2:  in_uTransitionDuration, jarg3:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePause__SWIG_1(jarg1:  in_playingID, jarg2:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequencePause(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequencePause__SWIG_2(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceResume__SWIG_0(jarg1:  in_playingID, jarg2:  in_uTransitionDuration, jarg3:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceResume__SWIG_1(jarg1:  in_playingID, jarg2:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceResume(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceResume__SWIG_2(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceStop__SWIG_0(jarg1:  in_playingID, jarg2:  in_uTransitionDuration, jarg3:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceStop__SWIG_1(jarg1:  in_playingID, jarg2:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceStop(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceStop__SWIG_2(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceBreak(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceBreak(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceGetPauseTimes(jarg1:  in_playingID, jarg2: out  1152921519099920144, jarg3: out  1152921519099924176);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID)
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_DynamicSequenceLockPlaylist(jarg1:  in_playingID);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkPlaylist)val_4;
        }
        
        AkPlaylist val_3 = null;
        val_4 = val_3;
        val_3 = new AkPlaylist(cPtr:  val_1, cMemoryOwn:  false);
        return (AkPlaylist)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_DynamicSequenceUnlockPlaylist(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsInitialized()
    {
        return AkSoundEnginePINVOKE.CSharp_IsInitialized();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings)
    {
        return AkSoundEnginePINVOKE.CSharp_GetAudioSettings(jarg1:  AkAudioSettings.getCPtr(obj:  out_audioSettings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput)
    {
        return (AkChannelConfig)new AkChannelConfig(cPtr:  AkSoundEnginePINVOKE.CSharp_GetSpeakerConfiguration__SWIG_0(jarg1:  in_idOutput), cMemoryOwn:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkChannelConfig GetSpeakerConfiguration()
    {
        return (AkChannelConfig)new AkChannelConfig(cPtr:  AkSoundEnginePINVOKE.CSharp_GetSpeakerConfiguration__SWIG_1(), cMemoryOwn:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput)
    {
        return AkSoundEnginePINVOKE.CSharp_GetPanningRule__SWIG_0(jarg1: out  1152921519100748992, jarg2:  in_idOutput);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPanningRule(out int out_ePanningRule)
    {
        return AkSoundEnginePINVOKE.CSharp_GetPanningRule__SWIG_1(jarg1: out  1152921519100869024);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput)
    {
        return AkSoundEnginePINVOKE.CSharp_SetPanningRule__SWIG_0(jarg1:  in_ePanningRule, jarg2:  in_idOutput);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule)
    {
        return AkSoundEnginePINVOKE.CSharp_SetPanningRule__SWIG_1(jarg1:  in_ePanningRule);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput)
    {
        return AkSoundEnginePINVOKE.CSharp_GetSpeakerAngles__SWIG_0(jarg1:  io_pfSpeakerAngles, jarg2: ref  1152921519101307216, jarg3: out  3.458374E+19f, jarg4:  in_idOutput);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle)
    {
        return AkSoundEnginePINVOKE.CSharp_GetSpeakerAngles__SWIG_1(jarg1:  io_pfSpeakerAngles, jarg2: ref  1152921519101509072, jarg3: out  3.502763E+19f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput)
    {
        return AkSoundEnginePINVOKE.CSharp_SetSpeakerAngles__SWIG_0(jarg1:  in_pfSpeakerAngles, jarg2:  in_uNumAngles, jarg3:  in_fHeightAngle, jarg4:  in_idOutput);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle)
    {
        return AkSoundEnginePINVOKE.CSharp_SetSpeakerAngles__SWIG_1(jarg1:  in_pfSpeakerAngles, jarg2:  in_uNumAngles, jarg3:  in_fHeightAngle);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB)
    {
        return AkSoundEnginePINVOKE.CSharp_SetVolumeThreshold(jarg1:  in_fVolumeThresholdDB);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMaxNumVoicesLimit(jarg1:  in_maxNumberVoices);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RenderAudio(bool in_bAllowSyncRender)
    {
        return AkSoundEnginePINVOKE.CSharp_RenderAudio__SWIG_0(jarg1:  in_bAllowSyncRender);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RenderAudio()
    {
        return AkSoundEnginePINVOKE.CSharp_RenderAudio__SWIG_1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterPluginDLL(string in_DllName)
    {
        return AkSoundEnginePINVOKE.CSharp_RegisterPluginDLL(jarg1:  in_DllName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetIDFromString(string in_pszString)
    {
        return AkSoundEnginePINVOKE.CSharp_GetIDFromString(jarg1:  in_pszString);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
    {
        IntPtr val_9;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_9 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_9 = System.IntPtr.op_Explicit(value:  val_9.GetHashCode());
        label_11:
        uint val_8 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_0(jarg1:  in_eventID, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_9, jarg6:  in_cExternals, jarg7:  in_pExternalSources.GetBuffer(), jarg8:  in_PlayingID);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_8);
        return val_8;
        label_3:
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
    {
        IntPtr val_9;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_9 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_9 = System.IntPtr.op_Explicit(value:  val_9.GetHashCode());
        label_11:
        uint val_8 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_1(jarg1:  in_eventID, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_9, jarg6:  in_cExternals, jarg7:  in_pExternalSources.GetBuffer());
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_8);
        return val_8;
        label_3:
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
    {
        IntPtr val_8;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_8 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_8 == null)
        {
            goto label_10;
        }
        
        label_9:
        val_8 = System.IntPtr.op_Explicit(value:  val_8.GetHashCode());
        label_10:
        uint val_7 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_2(jarg1:  in_eventID, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_8);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_7);
        return val_7;
        label_3:
        if(val_8 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        uint val_2 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_3(jarg1:  in_eventID, jarg2:  val_1);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_2);
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
    {
        IntPtr val_9;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_9 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_9 = System.IntPtr.op_Explicit(value:  val_9.GetHashCode());
        label_11:
        uint val_8 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_4(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_9, jarg6:  in_cExternals, jarg7:  in_pExternalSources.GetBuffer(), jarg8:  in_PlayingID);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_8);
        return val_8;
        label_3:
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
    {
        IntPtr val_9;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_9 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_9 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_9 = System.IntPtr.op_Explicit(value:  val_9.GetHashCode());
        label_11:
        uint val_8 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_5(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_9, jarg6:  in_cExternals, jarg7:  in_pExternalSources.GetBuffer());
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_8);
        return val_8;
        label_3:
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
    {
        IntPtr val_8;
        uint val_2 = in_uFlags;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        val_8 = AkCallbackManager.EventCallbackPackage.Create(in_cb:  in_pfnCallback, in_cookie:  in_pCookie, io_Flags: ref  val_2);
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        if(val_8 == null)
        {
            goto label_10;
        }
        
        label_9:
        val_8 = System.IntPtr.op_Explicit(value:  val_8.GetHashCode());
        label_10:
        uint val_7 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_6(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  val_2, jarg4:  System.IntPtr.op_Explicit(value:  1), jarg5:  val_8);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_7);
        return val_7;
        label_3:
        if(val_8 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        uint val_2 = AkSoundEnginePINVOKE.CSharp_PostEvent__SWIG_7(jarg1:  in_pszEventName, jarg2:  val_1);
        AkCallbackManager.SetLastAddedPlayingID(in_playingID:  val_2);
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_0(jarg1:  in_eventID, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration, jarg5:  in_eFadeCurve, jarg6:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_1(jarg1:  in_eventID, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_2(jarg1:  in_eventID, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_3(jarg1:  in_eventID, jarg2:  in_ActionType, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType)
    {
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_4(jarg1:  in_eventID, jarg2:  in_ActionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_5(jarg1:  in_pszEventName, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration, jarg5:  in_eFadeCurve, jarg6:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_6(jarg1:  in_pszEventName, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID, int in_uTransitionDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_7(jarg1:  in_pszEventName, jarg2:  in_ActionType, jarg3:  val_1, jarg4:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_8(jarg1:  in_pszEventName, jarg2:  in_ActionType, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType)
    {
        return AkSoundEnginePINVOKE.CSharp_ExecuteActionOnEvent__SWIG_9(jarg1:  in_pszEventName, jarg2:  in_ActionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostMIDIOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostMIDIOnEvent(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_pPosts.m_Buffer, jarg4:  in_uNumPosts);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StopMIDIOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_StopMIDIOnEvent__SWIG_0(jarg1:  in_eventID, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StopMIDIOnEvent(uint in_eventID)
    {
        return AkSoundEnginePINVOKE.CSharp_StopMIDIOnEvent__SWIG_1(jarg1:  in_eventID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StopMIDIOnEvent()
    {
        return AkSoundEnginePINVOKE.CSharp_StopMIDIOnEvent__SWIG_2();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority)
    {
        return AkSoundEnginePINVOKE.CSharp_PinEventInStreamCache__SWIG_0(jarg1:  in_eventID, jarg2:  in_uActivePriority, jarg3:  in_uInactivePriority);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority)
    {
        return AkSoundEnginePINVOKE.CSharp_PinEventInStreamCache__SWIG_1(jarg1:  in_pszEventName, jarg2:  in_uActivePriority, jarg3:  in_uInactivePriority);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnpinEventInStreamCache(uint in_eventID)
    {
        return AkSoundEnginePINVOKE.CSharp_UnpinEventInStreamCache__SWIG_0(jarg1:  in_eventID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnpinEventInStreamCache(string in_pszEventName)
    {
        return AkSoundEnginePINVOKE.CSharp_UnpinEventInStreamCache__SWIG_1(jarg1:  in_pszEventName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
    {
        return AkSoundEnginePINVOKE.CSharp_GetBufferStatusForPinnedEvent__SWIG_0(jarg1:  in_eventID, jarg2: out  5.355828E+19f, jarg3: out  1152921519106154768);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
    {
        return AkSoundEnginePINVOKE.CSharp_GetBufferStatusForPinnedEvent__SWIG_1(jarg1:  in_pszEventName, jarg2: out  5.415783E+19f, jarg3: out  1152921519106291088);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_0(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_iPosition, jarg4:  in_bSeekToNearestMarker, jarg5:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_1(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_iPosition, jarg4:  in_bSeekToNearestMarker);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, int in_iPosition)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_2(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_iPosition);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_3(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_iPosition, jarg4:  in_bSeekToNearestMarker, jarg5:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_4(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_iPosition, jarg4:  in_bSeekToNearestMarker);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, int in_iPosition)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_5(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_iPosition);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_6(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_fPercent, jarg4:  in_bSeekToNearestMarker, jarg5:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_7(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_fPercent, jarg4:  in_bSeekToNearestMarker);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, float in_fPercent)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_8(jarg1:  in_eventID, jarg2:  val_1, jarg3:  in_fPercent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_9(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_fPercent, jarg4:  in_bSeekToNearestMarker, jarg5:  in_PlayingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bSeekToNearestMarker = in_bSeekToNearestMarker;
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_10(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_fPercent, jarg4:  in_bSeekToNearestMarker);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SeekOnEvent(string in_pszEventName, UnityEngine.GameObject in_gameObjectID, float in_fPercent)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SeekOnEvent__SWIG_11(jarg1:  in_pszEventName, jarg2:  val_1, jarg3:  in_fPercent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void CancelEventCallbackCookie(object in_pCookie)
    {
        AkCallbackManager.RemoveEventCallbackCookie(in_cookie:  in_pCookie);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void CancelEventCallbackGameObject(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        AkSoundEnginePINVOKE.CSharp_CancelEventCallbackGameObject(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void CancelEventCallback(uint in_playingID)
    {
        AkCallbackManager.RemoveEventCallback(in_playingID:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate)
    {
        in_bExtrapolate = in_bExtrapolate;
        return AkSoundEnginePINVOKE.CSharp_GetSourcePlayPosition__SWIG_0(jarg1:  in_PlayingID, jarg2: out  1152921519108254992, jarg3:  in_bExtrapolate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition)
    {
        return AkSoundEnginePINVOKE.CSharp_GetSourcePlayPosition__SWIG_1(jarg1:  in_PlayingID, jarg2: out  1152921519108375040);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering)
    {
        return AkSoundEnginePINVOKE.CSharp_GetSourceStreamBuffering(jarg1:  in_PlayingID, jarg2: out  1152921519108499120, jarg3: out  1152921519108503152);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void StopAll(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        AkSoundEnginePINVOKE.CSharp_StopAll__SWIG_0(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void StopAll()
    {
        AkSoundEnginePINVOKE.CSharp_StopAll__SWIG_1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        AkSoundEnginePINVOKE.CSharp_StopPlayingID__SWIG_0(jarg1:  in_playingID, jarg2:  in_uTransitionDuration, jarg3:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration)
    {
        AkSoundEnginePINVOKE.CSharp_StopPlayingID__SWIG_1(jarg1:  in_playingID, jarg2:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void StopPlayingID(uint in_playingID)
    {
        AkSoundEnginePINVOKE.CSharp_StopPlayingID__SWIG_2(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
    {
        AkSoundEnginePINVOKE.CSharp_ExecuteActionOnPlayingID__SWIG_0(jarg1:  in_ActionType, jarg2:  in_playingID, jarg3:  in_uTransitionDuration, jarg4:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration)
    {
        AkSoundEnginePINVOKE.CSharp_ExecuteActionOnPlayingID__SWIG_1(jarg1:  in_ActionType, jarg2:  in_playingID, jarg3:  in_uTransitionDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID)
    {
        AkSoundEnginePINVOKE.CSharp_ExecuteActionOnPlayingID__SWIG_2(jarg1:  in_ActionType, jarg2:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetRandomSeed(uint in_uSeed)
    {
        AkSoundEnginePINVOKE.CSharp_SetRandomSeed(jarg1:  in_uSeed);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void MuteBackgroundMusic(bool in_bMute)
    {
        AkSoundEnginePINVOKE.CSharp_MuteBackgroundMusic(jarg1:  in_bMute);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool GetBackgroundMusicMute()
    {
        return AkSoundEnginePINVOKE.CSharp_GetBackgroundMusicMute();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SendPluginCustomGameData(uint in_busID, UnityEngine.GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_busObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_busObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SendPluginCustomGameData(jarg1:  in_busID, jarg2:  val_1, jarg3:  in_eType, jarg4:  in_uCompanyID, jarg5:  in_uPluginID, jarg6:  in_pData, jarg7:  in_uSizeInBytes);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnregisterAllGameObj()
    {
        return AkSoundEnginePINVOKE.CSharp_UnregisterAllGameObj();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMultiplePositions__SWIG_0(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  in_pPositions.m_Buffer, jarg3:  in_NumPositions, jarg4:  in_eMultiPositionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMultiplePositions__SWIG_1(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  in_pPositions.m_Buffer, jarg3:  in_NumPositions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMultiplePositions__SWIG_2(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  in_pPositions.m_Buffer, jarg3:  in_NumPositions, jarg4:  in_eMultiPositionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMultiplePositions(UnityEngine.GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMultiplePositions__SWIG_3(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  in_pPositions.m_Buffer, jarg3:  in_NumPositions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetScalingFactor(UnityEngine.GameObject in_GameObjectID, float in_fAttenuationScalingFactor)
    {
        return AkSoundEnginePINVOKE.CSharp_SetScalingFactor(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  in_fAttenuationScalingFactor);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ClearBanks()
    {
        return AkSoundEnginePINVOKE.CSharp_ClearBanks();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBankLoadIOSettings(jarg1:  in_fThroughput, jarg2:  in_priority);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(string in_pszString, int in_memPoolId, out uint out_bankID)
    {
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_0(jarg1:  in_pszString, jarg2:  in_memPoolId, jarg3: out  1152921519111027056);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(uint in_bankID, int in_memPoolId)
    {
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_1(jarg1:  in_bankID, jarg2:  in_memPoolId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID)
    {
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_2(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3: out  1152921519111259120);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, int in_uPoolForBankMedia, out uint out_bankID)
    {
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_3(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3:  in_uPoolForBankMedia, jarg4: out  1152921519111379184);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID)
    {
        IntPtr val_5;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_5 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_4(jarg1:  in_pszString, jarg2:  0, jarg3:  val_5 = 0, jarg4:  in_memPoolId, jarg5: out  1152921519111527936);
        }
        
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_4(jarg1:  in_pszString, jarg2:  0, jarg3:  val_5, jarg4:  in_memPoolId, jarg5: out  1152921519111527936);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_5(jarg1:  in_bankID, jarg2:  0, jarg3:  val_4 = 0, jarg4:  in_memPoolId);
        }
        
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_5(jarg1:  in_bankID, jarg2:  0, jarg3:  val_4, jarg4:  in_memPoolId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
    {
        IntPtr val_5;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_5 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_6(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3:  0, jarg4:  val_5 = 0, jarg5: out  1152921519111809184);
        }
        
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_6(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3:  0, jarg4:  val_5, jarg5: out  1152921519111809184);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_uPoolForBankMedia, out uint out_bankID)
    {
        IntPtr val_5;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_5 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_7(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3:  0, jarg4:  val_5 = 0, jarg5:  in_uPoolForBankMedia, jarg6: out  1152921519111953856);
        }
        
        return AkSoundEnginePINVOKE.CSharp_LoadBank__SWIG_7(jarg1:  in_pInMemoryBankPtr, jarg2:  in_uInMemoryBankSize, jarg3:  0, jarg4:  val_5, jarg5:  in_uPoolForBankMedia, jarg6: out  1152921519111953856);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_0(jarg1:  in_pszString, jarg2:  in_pInMemoryBankPtr, jarg3: out  1152921519112086224);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr)
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_1(jarg1:  in_pszString, jarg2:  in_pInMemoryBankPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_2(jarg1:  in_bankID, jarg2:  in_pInMemoryBankPtr, jarg3: out  1152921519112326480);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr)
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_3(jarg1:  in_bankID, jarg2:  in_pInMemoryBankPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_4(jarg1:  in_pszString, jarg2:  in_pInMemoryBankPtr, jarg3:  0, jarg4:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_4(jarg1:  in_pszString, jarg2:  in_pInMemoryBankPtr, jarg3:  0, jarg4:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_5(jarg1:  in_bankID, jarg2:  in_pInMemoryBankPtr, jarg3:  0, jarg4:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_UnloadBank__SWIG_5(jarg1:  in_bankID, jarg2:  in_pInMemoryBankPtr, jarg3:  0, jarg4:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void CancelBankCallbackCookie(object in_pCookie)
    {
        AkCallbackManager.RemoveBankCallback(in_cookie:  in_pCookie);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_0(jarg1:  in_PreparationType, jarg2:  in_pszString, jarg3:  in_uFlags);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_1(jarg1:  in_PreparationType, jarg2:  in_pszString);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_2(jarg1:  in_PreparationType, jarg2:  in_bankID, jarg3:  in_uFlags);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_3(jarg1:  in_PreparationType, jarg2:  in_bankID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_4(jarg1:  in_PreparationType, jarg2:  in_pszString, jarg3:  0, jarg4:  val_4 = 0, jarg5:  in_uFlags);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_4(jarg1:  in_PreparationType, jarg2:  in_pszString, jarg3:  0, jarg4:  val_4, jarg5:  in_uFlags);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_5(jarg1:  in_PreparationType, jarg2:  in_pszString, jarg3:  0, jarg4:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_5(jarg1:  in_PreparationType, jarg2:  in_pszString, jarg3:  0, jarg4:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_6(jarg1:  in_PreparationType, jarg2:  in_bankID, jarg3:  0, jarg4:  val_4 = 0, jarg5:  in_uFlags);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_6(jarg1:  in_PreparationType, jarg2:  in_bankID, jarg3:  0, jarg4:  val_4, jarg5:  in_uFlags);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_7(jarg1:  in_PreparationType, jarg2:  in_bankID, jarg3:  0, jarg4:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareBank__SWIG_7(jarg1:  in_PreparationType, jarg2:  in_bankID, jarg3:  0, jarg4:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ClearPreparedEvents()
    {
        return AkSoundEnginePINVOKE.CSharp_ClearPreparedEvents();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent)
    {
        var val_17;
        var val_18;
        IntPtr val_19;
        System.Char[] val_20;
        val_17 = 0;
        val_18 = 0;
        goto label_1;
        label_5:
        in_ppszString[0] = val_18 + in_ppszString[0].Length;
        val_18 = in_ppszString[0] + 1;
        val_17 = 1;
        label_1:
        if(val_17 < in_ppszString.Length)
        {
            goto label_5;
        }
        
        IntPtr val_4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  (val_18 << 1) + 2);
        System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_4, val:  in_ppszString.Length);
        long val_5 = val_4.ToInt64();
        val_5 = val_5 + 2;
        IntPtr val_6 = System.IntPtr.op_Explicit(value:  val_5);
        if(in_ppszString.Length >= 1)
        {
                do
        {
            string val_19 = in_ppszString[0];
            if(val_19 != null)
        {
                val_19 = val_6;
            val_20 = val_19.ToCharArray();
        }
        else
        {
                val_19 = val_6;
            val_20 = 0.ToCharArray();
        }
        
            System.Runtime.InteropServices.Marshal.Copy(source:  val_20, startIndex:  0, destination:  val_19, length:  val_19.Length);
            val_18 = val_6.ToInt64();
            int val_11 = val_19.Length;
            val_11 = val_18 + ((val_11 << 1) << );
            IntPtr val_13 = System.IntPtr.op_Explicit(value:  val_11);
            System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_13, val:  0);
            long val_14 = val_13.ToInt64();
            val_14 = val_14 + 2;
            IntPtr val_15 = System.IntPtr.op_Explicit(value:  val_14);
        }
        while((0 + 1) < in_ppszString.Length);
        
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_4);
        if(199 == 199)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_0(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent);
        }
        
        if(0 == 0)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_0(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent);
        }
        
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_0(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_1(jarg1:  in_PreparationType, jarg2:  in_pEventID, jarg3:  in_uNumEvent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        var val_20;
        var val_21;
        IntPtr val_22;
        System.Char[] val_23;
        IntPtr val_24;
        val_20 = 0;
        val_21 = 0;
        goto label_1;
        label_5:
        in_ppszString[0] = val_21 + in_ppszString[0].Length;
        val_21 = in_ppszString[0] + 1;
        val_20 = 1;
        label_1:
        if(val_20 < in_ppszString.Length)
        {
            goto label_5;
        }
        
        IntPtr val_4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  (val_21 << 1) + 2);
        System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_4, val:  in_ppszString.Length);
        long val_5 = val_4.ToInt64();
        val_5 = val_5 + 2;
        IntPtr val_6 = System.IntPtr.op_Explicit(value:  val_5);
        if(in_ppszString.Length >= 1)
        {
                do
        {
            string val_22 = in_ppszString[0];
            if(val_22 != null)
        {
                val_22 = val_6;
            val_23 = val_22.ToCharArray();
        }
        else
        {
                val_22 = val_6;
            val_23 = 0.ToCharArray();
        }
        
            System.Runtime.InteropServices.Marshal.Copy(source:  val_23, startIndex:  0, destination:  val_22, length:  val_22.Length);
            val_20 = val_6.ToInt64();
            int val_11 = val_22.Length;
            val_11 = val_20 + ((val_11 << 1) << );
            IntPtr val_13 = System.IntPtr.op_Explicit(value:  val_11);
            System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_13, val:  0);
            long val_14 = val_13.ToInt64();
            val_14 = val_14 + 2;
            IntPtr val_15 = System.IntPtr.op_Explicit(value:  val_14);
        }
        while((0 + 1) < in_ppszString.Length);
        
        }
        
        AkCallbackManager.BankCallbackPackage val_17 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_17 != null)
        {
                val_24 = System.IntPtr.op_Explicit(value:  val_17.GetHashCode());
        }
        else
        {
                val_24 = 0;
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_4);
        if(236 == 236)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_2(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent, jarg4:  0, jarg5:  val_24);
        }
        
        if(0 == 0)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_2(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent, jarg4:  0, jarg5:  val_24);
        }
        
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_2(jarg1:  in_PreparationType, jarg2:  val_4, jarg3:  in_uNumEvent, jarg4:  0, jarg5:  val_24);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_3(jarg1:  in_PreparationType, jarg2:  in_pEventID, jarg3:  in_uNumEvent, jarg4:  0, jarg5:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareEvent__SWIG_3(jarg1:  in_PreparationType, jarg2:  in_pEventID, jarg3:  in_uNumEvent, jarg4:  0, jarg5:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMedia(jarg1:  in_pSourceSettings.GetBuffer(), jarg2:  in_uNumSourceSettings);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
    {
        return AkSoundEnginePINVOKE.CSharp_UnsetMedia(jarg1:  in_pSourceSettings.GetBuffer(), jarg2:  in_uNumSourceSettings);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs)
    {
        var val_17;
        var val_18;
        IntPtr val_19;
        System.Char[] val_20;
        val_17 = 0;
        val_18 = 0;
        goto label_1;
        label_5:
        in_ppszGameSyncName[0] = val_18 + in_ppszGameSyncName[0].Length;
        val_18 = in_ppszGameSyncName[0] + 1;
        val_17 = 1;
        label_1:
        if(val_17 < in_ppszGameSyncName.Length)
        {
            goto label_5;
        }
        
        IntPtr val_4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  (val_18 << 1) + 2);
        System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_4, val:  in_ppszGameSyncName.Length);
        long val_5 = val_4.ToInt64();
        val_5 = val_5 + 2;
        IntPtr val_6 = System.IntPtr.op_Explicit(value:  val_5);
        if(in_ppszGameSyncName.Length >= 1)
        {
                do
        {
            string val_19 = in_ppszGameSyncName[0];
            if(val_19 != null)
        {
                val_19 = val_6;
            val_20 = val_19.ToCharArray();
        }
        else
        {
                val_19 = val_6;
            val_20 = 0.ToCharArray();
        }
        
            System.Runtime.InteropServices.Marshal.Copy(source:  val_20, startIndex:  0, destination:  val_19, length:  val_19.Length);
            val_17 = val_6.ToInt64();
            int val_11 = val_19.Length;
            val_11 = val_17 + ((val_11 << 1) << );
            IntPtr val_13 = System.IntPtr.op_Explicit(value:  val_11);
            System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_13, val:  0);
            long val_14 = val_13.ToInt64();
            val_14 = val_14 + 2;
            IntPtr val_15 = System.IntPtr.op_Explicit(value:  val_14);
        }
        while((0 + 1) < in_ppszGameSyncName.Length);
        
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_4);
        if(202 == 202)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_0(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs);
        }
        
        if(0 == 0)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_0(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs);
        }
        
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_0(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs)
    {
        return AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_1(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_GroupID, jarg4:  in_paGameSyncID, jarg5:  in_uNumGameSyncs);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        var val_20;
        var val_21;
        IntPtr val_22;
        System.Char[] val_23;
        IntPtr val_24;
        val_20 = 0;
        val_21 = 0;
        goto label_1;
        label_5:
        in_ppszGameSyncName[0] = val_21 + in_ppszGameSyncName[0].Length;
        val_21 = in_ppszGameSyncName[0] + 1;
        val_20 = 1;
        label_1:
        if(val_20 < in_ppszGameSyncName.Length)
        {
            goto label_5;
        }
        
        IntPtr val_4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(cb:  (val_21 << 1) + 2);
        System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_4, val:  in_ppszGameSyncName.Length);
        long val_5 = val_4.ToInt64();
        val_5 = val_5 + 2;
        IntPtr val_6 = System.IntPtr.op_Explicit(value:  val_5);
        if(in_ppszGameSyncName.Length >= 1)
        {
                do
        {
            string val_22 = in_ppszGameSyncName[0];
            if(val_22 != null)
        {
                val_22 = val_6;
            val_23 = val_22.ToCharArray();
        }
        else
        {
                val_22 = val_6;
            val_23 = 0.ToCharArray();
        }
        
            System.Runtime.InteropServices.Marshal.Copy(source:  val_23, startIndex:  0, destination:  val_22, length:  val_22.Length);
            int val_11 = val_22.Length;
            val_11 = val_6.ToInt64() + ((val_11 << 1) << );
            IntPtr val_13 = System.IntPtr.op_Explicit(value:  val_11);
            System.Runtime.InteropServices.Marshal.WriteInt16(ptr:  val_13, val:  0);
            long val_14 = val_13.ToInt64();
            val_14 = val_14 + 2;
            IntPtr val_15 = System.IntPtr.op_Explicit(value:  val_14);
        }
        while((0 + 1) < in_ppszGameSyncName.Length);
        
        }
        
        AkCallbackManager.BankCallbackPackage val_17 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_17 != null)
        {
                val_24 = System.IntPtr.op_Explicit(value:  val_17.GetHashCode());
        }
        else
        {
                val_24 = 0;
        }
        
        System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal:  val_4);
        if(240 == 240)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_2(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs, jarg6:  0, jarg7:  val_24);
        }
        
        if(0 == 0)
        {
                return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_2(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs, jarg6:  0, jarg7:  val_24);
        }
        
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_2(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_pszGroupName, jarg4:  val_4, jarg5:  in_uNumGameSyncs, jarg6:  0, jarg7:  val_24);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
    {
        IntPtr val_4;
        AkCallbackManager.BankCallbackPackage val_1 = new AkCallbackManager.BankCallbackPackage(in_cb:  in_pfnBankCallback, in_cookie:  in_pCookie);
        if(val_1 != null)
        {
                val_4 = System.IntPtr.op_Explicit(value:  val_1.GetHashCode());
            return AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_3(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_GroupID, jarg4:  in_paGameSyncID, jarg5:  in_uNumGameSyncs, jarg6:  0, jarg7:  val_4 = 0);
        }
        
        return AkSoundEnginePINVOKE.CSharp_PrepareGameSyncs__SWIG_3(jarg1:  in_PreparationType, jarg2:  in_eGameSyncType, jarg3:  in_GroupID, jarg4:  in_paGameSyncID, jarg5:  in_uNumGameSyncs, jarg6:  0, jarg7:  val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AddListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_emitterGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_emitterGameObj, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_listenerGameObj, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_AddListener(jarg1:  val_1, jarg2:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveListener(UnityEngine.GameObject in_emitterGameObj, UnityEngine.GameObject in_listenerGameObj)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_emitterGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_emitterGameObj, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_listenerGameObj, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_RemoveListener(jarg1:  val_1, jarg2:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AddDefaultListener(UnityEngine.GameObject in_listenerGameObj)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_listenerGameObj, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_AddDefaultListener(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveDefaultListener(UnityEngine.GameObject in_listenerGameObj)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_listenerGameObj, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_RemoveDefaultListener(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetListenersToDefault(UnityEngine.GameObject in_emitterGameObj)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_emitterGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_emitterGameObj, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetListenersToDefault(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_uListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_uListenerID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetListenerSpatialization__SWIG_0(jarg1:  val_1, jarg2:  in_bSpatialized, jarg3:  AkChannelConfig.getCPtr(obj:  in_channelConfig), jarg4:  in_pVolumeOffsets);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetListenerSpatialization(UnityEngine.GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_uListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_uListenerID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetListenerSpatialization__SWIG_1(jarg1:  val_1, jarg2:  in_bSpatialized, jarg3:  AkChannelConfig.getCPtr(obj:  in_channelConfig));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_0(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve, jarg6:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_1(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_2(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_3(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_4(jarg1:  in_rtpcID, jarg2:  in_value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_5(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve, jarg6:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_6(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_7(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  val_1, jarg4:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_8(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValue__SWIG_9(jarg1:  in_pszRtpcName, jarg2:  in_value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_0(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve, jarg6:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_1(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_2(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_3(jarg1:  in_rtpcID, jarg2:  in_value, jarg3:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_4(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve, jarg6:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_5(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration, jarg5:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_6(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  in_playingID, jarg4:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetRTPCValueByPlayingID__SWIG_7(jarg1:  in_pszRtpcName, jarg2:  in_value, jarg3:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_0(jarg1:  in_rtpcID, jarg2:  val_1, jarg3:  in_uValueChangeDuration, jarg4:  in_eFadeCurve, jarg5:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_1(jarg1:  in_rtpcID, jarg2:  val_1, jarg3:  in_uValueChangeDuration, jarg4:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_2(jarg1:  in_rtpcID, jarg2:  val_1, jarg3:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_3(jarg1:  in_rtpcID, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(uint in_rtpcID)
    {
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_4(jarg1:  in_rtpcID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        in_bBypassInternalValueInterpolation = in_bBypassInternalValueInterpolation;
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_5(jarg1:  in_pszRtpcName, jarg2:  val_1, jarg3:  in_uValueChangeDuration, jarg4:  in_eFadeCurve, jarg5:  in_bBypassInternalValueInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_6(jarg1:  in_pszRtpcName, jarg2:  val_1, jarg3:  in_uValueChangeDuration, jarg4:  in_eFadeCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, int in_uValueChangeDuration)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_7(jarg1:  in_pszRtpcName, jarg2:  val_1, jarg3:  in_uValueChangeDuration);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_8(jarg1:  in_pszRtpcName, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ResetRTPCValue(string in_pszRtpcName)
    {
        return AkSoundEnginePINVOKE.CSharp_ResetRTPCValue__SWIG_9(jarg1:  in_pszRtpcName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetSwitch__SWIG_0(jarg1:  in_switchGroup, jarg2:  in_switchState, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetSwitch__SWIG_1(jarg1:  in_pszSwitchGroup, jarg2:  in_pszSwitchState, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostTrigger(uint in_triggerID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostTrigger__SWIG_0(jarg1:  in_triggerID, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostTrigger(string in_pszTrigger, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostTrigger__SWIG_1(jarg1:  in_pszTrigger, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetState(uint in_stateGroup, uint in_state)
    {
        return AkSoundEnginePINVOKE.CSharp_SetState__SWIG_0(jarg1:  in_stateGroup, jarg2:  in_state);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetState(string in_pszStateGroup, string in_pszState)
    {
        return AkSoundEnginePINVOKE.CSharp_SetState__SWIG_1(jarg1:  in_pszStateGroup, jarg2:  in_pszState);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetGameObjectAuxSendValues(jarg1:  val_1, jarg2:  in_aAuxSendValues.GetBuffer(), jarg3:  in_uNumSendValues);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetGameObjectOutputBusVolume(UnityEngine.GameObject in_emitterObjID, UnityEngine.GameObject in_listenerObjID, float in_fControlValue)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_emitterObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_emitterObjID, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_listenerObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_listenerObjID, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_SetGameObjectOutputBusVolume(jarg1:  val_1, jarg2:  val_2, jarg3:  in_fControlValue);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetActorMixerEffect(jarg1:  in_audioNodeID, jarg2:  in_uFXIndex, jarg3:  in_shareSetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusEffect__SWIG_0(jarg1:  in_audioNodeID, jarg2:  in_uFXIndex, jarg3:  in_shareSetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusEffect__SWIG_1(jarg1:  in_pszBusName, jarg2:  in_uFXIndex, jarg3:  in_shareSetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMixer__SWIG_0(jarg1:  in_audioNodeID, jarg2:  in_shareSetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetMixer__SWIG_1(jarg1:  in_pszBusName, jarg2:  in_shareSetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusConfig__SWIG_0(jarg1:  in_audioNodeID, jarg2:  AkChannelConfig.getCPtr(obj:  in_channelConfig));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusConfig__SWIG_1(jarg1:  in_pszBusName, jarg2:  AkChannelConfig.getCPtr(obj:  in_channelConfig));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_EmitterID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_EmitterID, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_ListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_ListenerID, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_SetObjectObstructionAndOcclusion(jarg1:  val_1, jarg2:  val_2, jarg3:  in_fObstructionLevel, jarg4:  in_fOcclusionLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetMultipleObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_EmitterID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_EmitterID, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_uListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_uListenerID, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_SetMultipleObstructionAndOcclusion(jarg1:  val_1, jarg2:  val_2, jarg3:  in_fObstructionOcclusionValues.GetBuffer(), jarg4:  in_uNumOcclusionObstruction);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StartOutputCapture(string in_CaptureFileName)
    {
        return AkSoundEnginePINVOKE.CSharp_StartOutputCapture(jarg1:  in_CaptureFileName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StopOutputCapture()
    {
        return AkSoundEnginePINVOKE.CSharp_StopOutputCapture();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AddOutputCaptureMarker(string in_MarkerText)
    {
        return AkSoundEnginePINVOKE.CSharp_AddOutputCaptureMarker(jarg1:  in_MarkerText);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StartProfilerCapture(string in_CaptureFileName)
    {
        return AkSoundEnginePINVOKE.CSharp_StartProfilerCapture(jarg1:  in_CaptureFileName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT StopProfilerCapture()
    {
        return AkSoundEnginePINVOKE.CSharp_StopProfilerCapture();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveOutput(ulong in_idOutput)
    {
        return AkSoundEnginePINVOKE.CSharp_RemoveOutput(jarg1:  in_idOutput);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId)
    {
        AkOutputSettings val_2 = in_Settings;
        if(val_2 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_ReplaceOutput__SWIG_0(jarg1:  val_2 = in_Settings.swigCPtr, jarg2:  in_outputDeviceId, jarg3: out  1152921519124019152);
        }
        
        return AkSoundEnginePINVOKE.CSharp_ReplaceOutput__SWIG_0(jarg1:  val_2, jarg2:  in_outputDeviceId, jarg3: out  1152921519124019152);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId)
    {
        AkOutputSettings val_1 = in_Settings;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_ReplaceOutput__SWIG_1(jarg1:  val_1 = in_Settings.swigCPtr, jarg2:  in_outputDeviceId);
        }
        
        return AkSoundEnginePINVOKE.CSharp_ReplaceOutput__SWIG_1(jarg1:  val_1, jarg2:  in_outputDeviceId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong GetOutputID(uint in_idShareset, uint in_idDevice)
    {
        return AkSoundEnginePINVOKE.CSharp_GetOutputID__SWIG_0(jarg1:  in_idShareset, jarg2:  in_idDevice);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong GetOutputID(string in_szShareSet, uint in_idDevice)
    {
        return AkSoundEnginePINVOKE.CSharp_GetOutputID__SWIG_1(jarg1:  in_szShareSet, jarg2:  in_idDevice);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusDevice__SWIG_0(jarg1:  in_idBus, jarg2:  in_idNewDevice);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBusDevice__SWIG_1(jarg1:  in_BusName, jarg2:  in_DeviceName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume)
    {
        return AkSoundEnginePINVOKE.CSharp_SetOutputVolume(jarg1:  in_idOutput, jarg2:  in_fVolume);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice)
    {
        return AkSoundEnginePINVOKE.CSharp_GetDeviceSpatialAudioSupport(jarg1:  in_idDevice);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT Suspend(bool in_bRenderAnyway)
    {
        return AkSoundEnginePINVOKE.CSharp_Suspend__SWIG_0(jarg1:  in_bRenderAnyway);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT Suspend()
    {
        return AkSoundEnginePINVOKE.CSharp_Suspend__SWIG_1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT WakeupFromSuspend()
    {
        return AkSoundEnginePINVOKE.CSharp_WakeupFromSuspend();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetBufferTick()
    {
        return AkSoundEnginePINVOKE.CSharp_GetBufferTick();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte get_AK_INVALID_MIDI_CHANNEL()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_INVALID_MIDI_CHANNEL_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte get_AK_INVALID_MIDI_NOTE()
    {
        return AkSoundEnginePINVOKE.CSharp_AK_INVALID_MIDI_NOTE_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate)
    {
        AkSegmentInfo val_1 = out_segmentInfo;
        if(val_1 != null)
        {
                val_1 = out_segmentInfo.swigCPtr;
        }
        
        in_bExtrapolate = in_bExtrapolate;
        return AkSoundEnginePINVOKE.CSharp_GetPlayingSegmentInfo__SWIG_0(jarg1:  in_PlayingID, jarg2:  val_1, jarg3:  in_bExtrapolate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo)
    {
        AkSegmentInfo val_1 = out_segmentInfo;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_GetPlayingSegmentInfo__SWIG_1(jarg1:  in_PlayingID, jarg2:  val_1 = out_segmentInfo.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_GetPlayingSegmentInfo__SWIG_1(jarg1:  in_PlayingID, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        in_bIsBus = in_bIsBus;
        return AkSoundEnginePINVOKE.CSharp_PostCode__SWIG_0(jarg1:  in_eError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1, jarg5:  in_audioNodeID, jarg6:  in_bIsBus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostCode__SWIG_1(jarg1:  in_eError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1, jarg5:  in_audioNodeID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostCode__SWIG_2(jarg1:  in_eError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_PostCode__SWIG_3(jarg1:  in_eError, jarg2:  in_eErrorLevel, jarg3:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel)
    {
        return AkSoundEnginePINVOKE.CSharp_PostCode__SWIG_4(jarg1:  in_eError, jarg2:  in_eErrorLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        in_bIsBus = in_bIsBus;
        return AkSoundEnginePINVOKE.CSharp_PostString__SWIG_0(jarg1:  in_pszError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1, jarg5:  in_audioNodeID, jarg6:  in_bIsBus);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID, uint in_audioNodeID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostString__SWIG_1(jarg1:  in_pszError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1, jarg5:  in_audioNodeID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, UnityEngine.GameObject in_gameObjID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_PostString__SWIG_2(jarg1:  in_pszError, jarg2:  in_eErrorLevel, jarg3:  in_playingID, jarg4:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_PostString__SWIG_3(jarg1:  in_pszError, jarg2:  in_eErrorLevel, jarg3:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel)
    {
        return AkSoundEnginePINVOKE.CSharp_PostString__SWIG_4(jarg1:  in_pszError, jarg2:  in_eErrorLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetTimeStamp()
    {
        return AkSoundEnginePINVOKE.CSharp_GetTimeStamp();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetNumNonZeroBits(uint in_uWord)
    {
        return AkSoundEnginePINVOKE.CSharp_GetNumNonZeroBits(jarg1:  in_uWord);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties)
    {
        AkSoundEnginePINVOKE.CSharp_AkGetDefaultHighPriorityThreadProperties(jarg1:  AkThreadProperties.getCPtr(obj:  out_threadProperties));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence)
    {
        return AkSoundEnginePINVOKE.CSharp_ResolveDialogueEvent__SWIG_0(jarg1:  in_eventID, jarg2:  in_aArgumentValues, jarg3:  in_uNumArguments, jarg4:  in_idSequence);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments)
    {
        return AkSoundEnginePINVOKE.CSharp_ResolveDialogueEvent__SWIG_1(jarg1:  in_eventID, jarg2:  in_aArgumentValues, jarg3:  in_uNumArguments);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue)
    {
        return AkSoundEnginePINVOKE.CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(jarg1:  in_eventID, jarg2:  in_uPropID, jarg3: out  1152921519127917008);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue)
    {
        return AkSoundEnginePINVOKE.CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(jarg1:  in_eventID, jarg2:  in_uPropID, jarg3: out  3.130796E+20f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPosition(UnityEngine.GameObject in_GameObjectID, AkTransform out_rPosition)
    {
        return AkSoundEnginePINVOKE.CSharp_GetPosition(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  AkTransform.getCPtr(obj:  out_rPosition));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetListenerPosition(UnityEngine.GameObject in_uIndex, AkTransform out_rPosition)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_uIndex);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_uIndex, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetListenerPosition(jarg1:  val_1, jarg2:  AkTransform.getCPtr(obj:  out_rPosition));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetRTPCValue(uint in_rtpcID, UnityEngine.GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetRTPCValue__SWIG_0(jarg1:  in_rtpcID, jarg2:  val_1, jarg3:  in_playingID, jarg4: out  3.267694E+20f, jarg5: ref  1152921519128430208);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetRTPCValue(string in_pszRtpcName, UnityEngine.GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetRTPCValue__SWIG_1(jarg1:  in_pszRtpcName, jarg2:  val_1, jarg3:  in_playingID, jarg4: out  3.318562E+20f, jarg5: ref  1152921519128574784);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSwitch(uint in_switchGroup, UnityEngine.GameObject in_gameObjectID, out uint out_rSwitchState)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetSwitch__SWIG_0(jarg1:  in_switchGroup, jarg2:  val_1, jarg3: out  1152921519128703056);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, UnityEngine.GameObject in_GameObj, out uint out_rSwitchState)
    {
        return AkSoundEnginePINVOKE.CSharp_GetSwitch__SWIG_1(jarg1:  in_pstrSwitchGroupName, jarg2:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObj), jarg3: out  1152921519128839504);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetState(uint in_stateGroup, out uint out_rState)
    {
        return AkSoundEnginePINVOKE.CSharp_GetState__SWIG_0(jarg1:  in_stateGroup, jarg2: out  1152921519128959552);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState)
    {
        return AkSoundEnginePINVOKE.CSharp_GetState__SWIG_1(jarg1:  in_pstrStateGroupName, jarg2: out  1152921519129087776);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetGameObjectAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetGameObjectAuxSendValues(jarg1:  val_1, jarg2:  out_paAuxSendValues.GetBuffer(), jarg3: ref  1152921519129224208);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetGameObjectDryLevelValue(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, out float out_rfControlValue)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_EmitterID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_EmitterID, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_ListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_ListenerID, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_GetGameObjectDryLevelValue(jarg1:  val_1, jarg2:  val_2, jarg3: out  3.59649E+20f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetObjectObstructionAndOcclusion(UnityEngine.GameObject in_EmitterID, UnityEngine.GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_EmitterID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_EmitterID, id:  val_1);
        ulong val_2 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_ListenerID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_ListenerID, id:  val_2);
        return AkSoundEnginePINVOKE.CSharp_GetObjectObstructionAndOcclusion(jarg1:  val_1, jarg2:  val_2, jarg3: out  3.645917E+20f, jarg4: out  3.647336E+20f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
    {
        return AkSoundEnginePINVOKE.CSharp_QueryAudioObjectIDs__SWIG_0(jarg1:  in_eventID, jarg2: ref  1152921519129630352, jarg3:  out_aObjectInfos.GetBuffer());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
    {
        return AkSoundEnginePINVOKE.CSharp_QueryAudioObjectIDs__SWIG_1(jarg1:  in_pszEventName, jarg2: ref  1152921519129766800, jarg3:  out_aObjectInfos.GetBuffer());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo)
    {
        AkPositioningInfo val_1 = out_rPositioningInfo;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_GetPositioningInfo(jarg1:  in_ObjectID, jarg2:  val_1 = out_rPositioningInfo.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_GetPositioningInfo(jarg1:  in_ObjectID, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool GetIsGameObjectActive(UnityEngine.GameObject in_GameObjId)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjId);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_GameObjId, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetIsGameObjectActive(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float GetMaxRadius(UnityEngine.GameObject in_GameObjId)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjId);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_GameObjId, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetMaxRadius(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetEventIDFromPlayingID(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_GetEventIDFromPlayingID(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong GetGameObjectFromPlayingID(uint in_playingID)
    {
        return AkSoundEnginePINVOKE.CSharp_GetGameObjectFromPlayingID(jarg1:  in_playingID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetPlayingIDsFromGameObject(UnityEngine.GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjId);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_GameObjId, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_GetPlayingIDsFromGameObject(jarg1:  val_1, jarg2: ref  1152921519130520592, jarg3:  out_aPlayingIDs);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue)
    {
        return AkSoundEnginePINVOKE.CSharp_GetCustomPropertyValue__SWIG_0(jarg1:  in_ObjectID, jarg2:  in_uPropID, jarg3: out  1152921519130677520);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue)
    {
        return AkSoundEnginePINVOKE.CSharp_GetCustomPropertyValue__SWIG_1(jarg1:  in_ObjectID, jarg2:  in_uPropID, jarg3: out  4.102064E+20f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(jarg1: ref  1152921519130917632);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(jarg1: ref  1152921519131037664);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(jarg1: ref  1152921519131157696);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte ChannelMaskToNumChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_ChannelMaskToNumChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint ChannelMaskFromNumChannels(uint in_uNumChannels)
    {
        return AkSoundEnginePINVOKE.CSharp_ChannelMaskFromNumChannels(jarg1:  in_uNumChannels);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_ChannelBitToIndex(jarg1:  in_uChannelBit, jarg2:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasSurroundChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_HasSurroundChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_HasStrictlyOnePairOfSurroundChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasSideAndRearChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_HasSideAndRearChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasHeightChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_HasHeightChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint BackToSideChannels(uint in_uChannelMask)
    {
        return AkSoundEnginePINVOKE.CSharp_BackToSideChannels(jarg1:  in_uChannelMask);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx)
    {
        return AkSoundEnginePINVOKE.CSharp_StdChannelIndexToDisplayIndex(jarg1:  in_eOrdering, jarg2:  in_uChannelMask, jarg3:  in_uChannelIdx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float get_kDefaultMaxPathLength()
    {
        return AkSoundEnginePINVOKE.CSharp_kDefaultMaxPathLength_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_kDefaultDiffractionMaxEdges()
    {
        return AkSoundEnginePINVOKE.CSharp_kDefaultDiffractionMaxEdges_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_kDefaultDiffractionMaxPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_kDefaultDiffractionMaxPaths_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float get_kMaxDiffraction()
    {
        return AkSoundEnginePINVOKE.CSharp_kMaxDiffraction_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_kListenerDiffractionMaxEdges()
    {
        return AkSoundEnginePINVOKE.CSharp_kListenerDiffractionMaxEdges_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_kListenerDiffractionMaxPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_kListenerDiffractionMaxPaths_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint get_kPortalToPortalDiffractionMaxPaths()
    {
        return AkSoundEnginePINVOKE.CSharp_kPortalToPortalDiffractionMaxPaths_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_g_SpatialAudioPoolId(int value)
    {
        AkSoundEnginePINVOKE.CSharp_g_SpatialAudioPoolId_set(jarg1:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int get_g_SpatialAudioPoolId()
    {
        return AkSoundEnginePINVOKE.CSharp_g_SpatialAudioPoolId_get();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetPoolID()
    {
        return AkSoundEnginePINVOKE.CSharp_GetPoolID();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterEmitter(UnityEngine.GameObject in_gameObjectID, AkEmitterSettings in_settings)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_RegisterEmitter(jarg1:  val_1, jarg2:  AkEmitterSettings.getCPtr(obj:  in_settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnregisterEmitter(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_UnregisterEmitter(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetEmitterAuxSendValues(UnityEngine.GameObject in_gameObjectID, AkAuxSendArray in_pAuxSends, uint in_uNumAux)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetEmitterAuxSendValues(jarg1:  val_1, jarg2:  in_pAuxSends.GetBuffer(), jarg3:  in_uNumAux);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetImageSource__SWIG_0(jarg1:  in_srcID, jarg2:  AkImageSourceSettings.getCPtr(obj:  in_info), jarg3:  in_AuxBusID, jarg4:  in_roomID, jarg5:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID)
    {
        return AkSoundEnginePINVOKE.CSharp_SetImageSource__SWIG_1(jarg1:  in_srcID, jarg2:  AkImageSourceSettings.getCPtr(obj:  in_info), jarg3:  in_AuxBusID, jarg4:  in_roomID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_RemoveImageSource__SWIG_0(jarg1:  in_srcID, jarg2:  in_AuxBusID, jarg3:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID)
    {
        return AkSoundEnginePINVOKE.CSharp_RemoveImageSource__SWIG_1(jarg1:  in_srcID, jarg2:  in_AuxBusID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveGeometry(ulong in_SetID)
    {
        return AkSoundEnginePINVOKE.CSharp_RemoveGeometry(jarg1:  in_SetID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryReflectionPaths(UnityEngine.GameObject in_gameObjectID, AkVector out_listenerPos, AkVector out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_QueryReflectionPaths(jarg1:  val_1, jarg2:  AkVector.getCPtr(obj:  out_listenerPos), jarg3:  AkVector.getCPtr(obj:  out_emitterPos), jarg4:  out_aPaths.GetBuffer(), jarg5: out  1152921519134417472);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemoveRoom(ulong in_RoomID)
    {
        return AkSoundEnginePINVOKE.CSharp_RemoveRoom(jarg1:  in_RoomID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RemovePortal(ulong in_PortalID)
    {
        return AkSoundEnginePINVOKE.CSharp_RemovePortal(jarg1:  in_PortalID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetGameObjectInRoom(UnityEngine.GameObject in_gameObjectID, ulong in_CurrentRoomID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetGameObjectInRoom(jarg1:  val_1, jarg2:  in_CurrentRoomID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetEmitterObstructionAndOcclusion(UnityEngine.GameObject in_gameObjectID, float in_fObstruction, float in_fOcclusion)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetEmitterObstructionAndOcclusion(jarg1:  val_1, jarg2:  in_fObstruction, jarg3:  in_fOcclusion);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion)
    {
        return AkSoundEnginePINVOKE.CSharp_SetPortalObstructionAndOcclusion(jarg1:  in_PortalID, jarg2:  in_fObstruction, jarg3:  in_fOcclusion);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction)
    {
        return AkSoundEnginePINVOKE.CSharp_QueryWetDiffraction(jarg1:  in_portal, jarg2: out  5.62074E+20f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetFastPathSettings(AkInitSettings in_settings, AkPlatformInitSettings in_pfSettings)
    {
        AkPlatformInitSettings val_2 = in_pfSettings;
        if(val_2 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_GetFastPathSettings(jarg1:  AkInitSettings.getCPtr(obj:  in_settings), jarg2:  val_2 = in_pfSettings.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_GetFastPathSettings(jarg1:  AkInitSettings.getCPtr(obj:  in_settings), jarg2:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger)
    {
        AkSoundEnginePINVOKE.CSharp_SetErrorLogger__SWIG_0(jarg1:  logger);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetErrorLogger()
    {
        AkSoundEnginePINVOKE.CSharp_SetErrorLogger__SWIG_1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat)
    {
        AkSoundEnginePINVOKE.CSharp_SetAudioInputCallbacks(jarg1:  getAudioSamples, jarg2:  getAudioFormat);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT Init(AkInitializationSettings settings)
    {
        AkInitializationSettings val_1 = settings;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_Init(jarg1:  val_1 = settings.swigCPtr);
        }
        
        return AkSoundEnginePINVOKE.CSharp_Init(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings)
    {
        return AkSoundEnginePINVOKE.CSharp_InitSpatialAudio(jarg1:  AkSpatialAudioInitSettings.getCPtr(obj:  settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT InitCommunication(AkCommunicationSettings settings)
    {
        return AkSoundEnginePINVOKE.CSharp_InitCommunication(jarg1:  AkCommunicationSettings.getCPtr(obj:  settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Term()
    {
        AkSoundEnginePINVOKE.CSharp_Term();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterGameObjInternal(UnityEngine.GameObject in_GameObj)
    {
        return AkSoundEnginePINVOKE.CSharp_RegisterGameObjInternal(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObj));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnregisterGameObjInternal(UnityEngine.GameObject in_GameObj)
    {
        return AkSoundEnginePINVOKE.CSharp_UnregisterGameObjInternal(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObj));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterGameObjInternal_WithName(UnityEngine.GameObject in_GameObj, string in_pszObjName)
    {
        return AkSoundEnginePINVOKE.CSharp_RegisterGameObjInternal_WithName(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObj), jarg2:  in_pszObjName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetBasePath(string in_pszBasePath)
    {
        return AkSoundEnginePINVOKE.CSharp_SetBasePath(jarg1:  in_pszBasePath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath)
    {
        return AkSoundEnginePINVOKE.CSharp_SetCurrentLanguage(jarg1:  in_pszAudioSrcPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID, int in_memPoolID)
    {
        return AkSoundEnginePINVOKE.CSharp_LoadFilePackage(jarg1:  in_pszFilePackageName, jarg2: out  1152921519136812848, jarg3:  in_memPoolID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AddBasePath(string in_pszBasePath)
    {
        return AkSoundEnginePINVOKE.CSharp_AddBasePath(jarg1:  in_pszBasePath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetGameName(string in_GameName)
    {
        return AkSoundEnginePINVOKE.CSharp_SetGameName(jarg1:  in_GameName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetDecodedBankPath(string in_DecodedPath)
    {
        return AkSoundEnginePINVOKE.CSharp_SetDecodedBankPath(jarg1:  in_DecodedPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, out uint out_bankID)
    {
        in_bSaveDecodedBank = in_bSaveDecodedBank;
        return AkSoundEnginePINVOKE.CSharp_LoadAndDecodeBank(jarg1:  in_pszString, jarg2:  in_bSaveDecodedBank, jarg3: out  1152921519137301680);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT LoadAndDecodeBankFromMemory(IntPtr in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, out uint out_bankID)
    {
        in_bSaveDecodedBank = in_bSaveDecodedBank;
        in_bIsLanguageSpecific = in_bIsLanguageSpecific;
        return AkSoundEnginePINVOKE.CSharp_LoadAndDecodeBankFromMemory(jarg1:  in_BankData, jarg2:  in_BankDataSize, jarg3:  in_bSaveDecodedBank, jarg4:  in_DecodedBankName, jarg5:  in_bIsLanguageSpecific, jarg6: out  1152921519137429952);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetCurrentLanguage()
    {
        return AkSoundEngine.StringFromIntPtrOSString(ptr:  AkSoundEnginePINVOKE.CSharp_GetCurrentLanguage());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadFilePackage(uint in_uPackageID)
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadFilePackage(jarg1:  in_uPackageID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnloadAllFilePackages()
    {
        return AkSoundEnginePINVOKE.CSharp_UnloadAllFilePackages();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetObjectPosition(UnityEngine.GameObject in_GameObjectID, float PosX, float PosY, float PosZ, float FrontX, float FrontY, float FrontZ, float TopX, float TopY, float TopZ)
    {
        return AkSoundEnginePINVOKE.CSharp_SetObjectPosition(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_GameObjectID), jarg2:  PosX, jarg3:  PosY, jarg4:  PosZ, jarg5:  FrontX, jarg6:  FrontY, jarg7:  FrontZ, jarg8:  TopX, jarg9:  TopY, jarg10:  TopZ);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate)
    {
        in_bExtrapolate = in_bExtrapolate;
        return AkSoundEnginePINVOKE.CSharp_GetSourceMultiplePlayPositions(jarg1:  in_PlayingID, jarg2:  out_audioNodeID, jarg3:  out_mediaID, jarg4:  out_msTime, jarg5: ref  1152921519138227424, jarg6:  in_bExtrapolate);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetListeners(UnityEngine.GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_emitterGameObj);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_emitterGameObj, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_SetListeners(jarg1:  val_1, jarg2:  in_pListenerGameObjs, jarg3:  in_uNumListeners);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners)
    {
        return AkSoundEnginePINVOKE.CSharp_SetDefaultListeners(jarg1:  in_pListenerObjs, jarg2:  in_uNumListeners);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners)
    {
        AkOutputSettings val_2 = in_Settings;
        if(val_2 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AddOutput(jarg1:  val_2 = in_Settings.swigCPtr, jarg2: out  1152921519138772208, jarg3:  in_pListenerIDs, jarg4:  in_uNumListeners);
        }
        
        return AkSoundEnginePINVOKE.CSharp_AddOutput(jarg1:  val_2, jarg2: out  1152921519138772208, jarg3:  in_pListenerIDs, jarg4:  in_uNumListeners);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings)
    {
        AkSoundEnginePINVOKE.CSharp_GetDefaultStreamSettings(jarg1:  AkStreamMgrSettings.getCPtr(obj:  out_settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings)
    {
        AkSoundEnginePINVOKE.CSharp_GetDefaultDeviceSettings(jarg1:  AkDeviceSettings.getCPtr(obj:  out_settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetDefaultMusicSettings(AkMusicSettings out_settings)
    {
        AkMusicSettings val_1 = out_settings;
        if(val_1 != null)
        {
                val_1 = out_settings.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_GetDefaultMusicSettings(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetDefaultInitSettings(AkInitSettings out_settings)
    {
        AkSoundEnginePINVOKE.CSharp_GetDefaultInitSettings(jarg1:  AkInitSettings.getCPtr(obj:  out_settings));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings)
    {
        AkPlatformInitSettings val_1 = out_settings;
        if(val_1 != null)
        {
                val_1 = out_settings.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_GetDefaultPlatformInitSettings(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetMajorMinorVersion()
    {
        return AkSoundEnginePINVOKE.CSharp_GetMajorMinorVersion();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint GetSubminorBuildVersion()
    {
        return AkSoundEnginePINVOKE.CSharp_GetSubminorBuildVersion();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryIndirectPaths(UnityEngine.GameObject in_gameObjectID, AkPathParams arg1, AkReflectionPathInfoArray paths, uint numPaths)
    {
        AkPathParams val_3 = arg1;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        if(val_3 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_QueryIndirectPaths(jarg1:  val_1, jarg2:  val_3 = arg1.swigCPtr, jarg3:  paths.GetBuffer(), jarg4:  numPaths);
        }
        
        return AkSoundEnginePINVOKE.CSharp_QueryIndirectPaths(jarg1:  val_1, jarg2:  val_3, jarg3:  paths.GetBuffer(), jarg4:  numPaths);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT QueryDiffractionPaths(UnityEngine.GameObject in_gameObjectID, AkPathParams arg1, AkDiffractionPathInfoArray paths, uint numPaths)
    {
        AkPathParams val_3 = arg1;
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        if(val_3 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_QueryDiffractionPaths(jarg1:  val_1, jarg2:  val_3 = arg1.swigCPtr, jarg3:  paths.GetBuffer(), jarg4:  numPaths);
        }
        
        return AkSoundEnginePINVOKE.CSharp_QueryDiffractionPaths(jarg1:  val_1, jarg2:  val_3, jarg3:  paths.GetBuffer(), jarg4:  numPaths);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRoomPortal(ulong in_PortalID, AkTransform Transform, AkVector Extent, bool bEnabled, ulong FrontRoom, ulong BackRoom)
    {
        bEnabled = bEnabled;
        return AkSoundEnginePINVOKE.CSharp_SetRoomPortal(jarg1:  in_PortalID, jarg2:  AkTransform.getCPtr(obj:  Transform), jarg3:  AkVector.getCPtr(obj:  Extent), jarg4:  bEnabled, jarg5:  FrontRoom, jarg6:  BackRoom);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, string in_pName)
    {
        AkRoomParams val_1 = in_roomParams;
        if(val_1 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_SetRoom(jarg1:  in_RoomID, jarg2:  val_1 = in_roomParams.swigCPtr, jarg3:  in_pName);
        }
        
        return AkSoundEnginePINVOKE.CSharp_SetRoom(jarg1:  in_RoomID, jarg2:  val_1, jarg3:  in_pName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_RegisterSpatialAudioListener(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnregisterSpatialAudioListener(UnityEngine.GameObject in_gameObjectID)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_UnregisterSpatialAudioListener(jarg1:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, AkVertexArray Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, ulong RoomID, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges)
    {
        return AkSoundEnginePINVOKE.CSharp_SetGeometry(jarg1:  in_GeomSetID, jarg2:  Triangles.GetBuffer(), jarg3:  NumTriangles, jarg4:  Vertices.GetBuffer(), jarg5:  NumVertices, jarg6:  Surfaces.GetBuffer(), jarg7:  NumSurfaces, jarg8:  RoomID, jarg9:  EnableDiffraction, jarg10:  EnableDiffractionOnBoundaryEdges);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string StringFromIntPtrString(IntPtr ptr)
    {
        return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(ptr:  ptr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string StringFromIntPtrWString(IntPtr ptr)
    {
        return System.Runtime.InteropServices.Marshal.PtrToStringUni(ptr:  ptr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string StringFromIntPtrOSString(IntPtr ptr)
    {
        return AkSoundEngine.StringFromIntPtrString(ptr:  ptr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ulong InternalGameObjectHash(UnityEngine.GameObject gameObject)
    {
        var val_3;
        if(gameObject == 0)
        {
                val_3 = 0;
            return (ulong)val_3;
        }
        
        val_3 = (long)gameObject.GetInstanceID();
        return (ulong)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_GameObjectHash(AkSoundEngine.GameObjectHashFunction value)
    {
        AkSoundEngine.GameObjectHashFunction val_2;
        var val_3;
        val_2 = value;
        if(val_2 == null)
        {
                AkSoundEngine.GameObjectHashFunction val_1 = null;
            val_2 = val_1;
            val_1 = new AkSoundEngine.GameObjectHashFunction(object:  0, method:  static System.UInt64 AkSoundEngine::InternalGameObjectHash(UnityEngine.GameObject gameObject));
        }
        
        val_3 = null;
        val_3 = null;
        AkSoundEngine.Deprecation_2019_1_1 = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static ulong GetAkGameObjectID(UnityEngine.GameObject gameObject)
    {
        null = null;
        if(AkSoundEngine.Deprecation_2019_1_1 != null)
        {
                return AkSoundEngine.Deprecation_2019_1_1.Invoke(gameObject:  gameObject);
        }
        
        return AkSoundEngine.Deprecation_2019_1_1.Invoke(gameObject:  gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject);
        int val_2 = AkSoundEnginePINVOKE.CSharp_RegisterGameObjInternal(jarg1:  val_1);
        AkSoundEngine.PostRegisterGameObjUserHook(result:  val_2, gameObject:  0, id:  val_1);
        return (AKRESULT)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT RegisterGameObj(UnityEngine.GameObject gameObject, string name)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject);
        int val_2 = AkSoundEnginePINVOKE.CSharp_RegisterGameObjInternal_WithName(jarg1:  val_1, jarg2:  name);
        AkSoundEngine.PostRegisterGameObjUserHook(result:  val_2, gameObject:  name, id:  val_1);
        return (AKRESULT)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT UnregisterGameObj(UnityEngine.GameObject gameObject)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject);
        int val_2 = AkSoundEnginePINVOKE.CSharp_UnregisterGameObjInternal(jarg1:  val_1);
        AkSoundEngine.PostUnregisterGameObjUserHook(result:  val_2, gameObject:  0, id:  val_1);
        return (AKRESULT)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Transform transform)
    {
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        if(transform != null)
        {
                UnityEngine.Vector3 val_2 = transform.position;
            UnityEngine.Vector3 val_3 = transform.position;
            val_20 = val_3.y;
            UnityEngine.Vector3 val_4 = transform.position;
            val_21 = val_4.z;
            UnityEngine.Vector3 val_5 = transform.forward;
            val_22 = val_5.x;
            UnityEngine.Vector3 val_6 = transform.forward;
            val_23 = val_6.y;
            UnityEngine.Vector3 val_7 = transform.forward;
            val_24 = val_7.z;
            UnityEngine.Vector3 val_8 = transform.up;
            val_25 = val_8.x;
            UnityEngine.Vector3 val_9 = transform.up;
            val_26 = val_9.y;
        }
        else
        {
                UnityEngine.Vector3 val_10 = 0.position;
            UnityEngine.Vector3 val_11 = 0.position;
            val_20 = val_11.y;
            UnityEngine.Vector3 val_12 = 0.position;
            val_21 = val_12.z;
            UnityEngine.Vector3 val_13 = 0.forward;
            val_22 = val_13.x;
            UnityEngine.Vector3 val_14 = 0.forward;
            val_23 = val_14.y;
            UnityEngine.Vector3 val_15 = 0.forward;
            val_24 = val_15.z;
            UnityEngine.Vector3 val_16 = 0.up;
            val_25 = val_16.x;
            UnityEngine.Vector3 val_17 = 0.up;
            val_26 = val_17.y;
        }
        
        UnityEngine.Vector3 val_18 = transform.up;
        return (AKRESULT)AkSoundEnginePINVOKE.CSharp_SetObjectPosition(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject), jarg2:  val_10.x, jarg3:  val_20, jarg4:  val_21, jarg5:  val_22, jarg6:  val_23, jarg7:  val_24, jarg8:  val_25, jarg9:  val_26, jarg10:  val_18.z);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT SetObjectPosition(UnityEngine.GameObject gameObject, UnityEngine.Vector3 position, UnityEngine.Vector3 forward, UnityEngine.Vector3 up)
    {
        float val_1;
        return AkSoundEnginePINVOKE.CSharp_SetObjectPosition(jarg1:  AkSoundEngine.GetAkGameObjectID(gameObject:  gameObject), jarg2:  position.x, jarg3:  position.y, jarg4:  position.z, jarg5:  forward.x, jarg6:  forward.y, jarg7:  forward.z, jarg8:  up.x, jarg9:  val_1, jarg10:  up.y);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint eventId, UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
    {
        uint val_2 = numSources;
        if(val_2 >= 2)
        {
                UnityEngine.Debug.LogError(message:  "WwiseUnity: This version of PostEvent only sends 1 external source to the sound engine.");
            val_2 = 1;
        }
        
        AkExternalSourceInfoArray val_1 = new AkExternalSourceInfoArray(count:  1);
        if(val_2 == 0)
        {
                return AkSoundEngine.PostEvent(in_eventID:  eventId, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1, in_PlayingID:  playingId);
        }
        
        val_1.set_Item(index:  0, value:  externalSources);
        return AkSoundEngine.PostEvent(in_eventID:  eventId, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1, in_PlayingID:  playingId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(uint eventId, UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
    {
        if(numSources >= 2)
        {
                UnityEngine.Debug.LogError(message:  "WwiseUnity: This version of PostEvent only sends 1 external source to the sound engine.");
        }
        else
        {
                if(numSources == 0)
        {
                return AkSoundEngine.PostEvent(in_eventID:  eventId, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie);
        }
        
        }
        
        AkExternalSourceInfoArray val_1 = new AkExternalSourceInfoArray(count:  1);
        val_1.set_Item(index:  0, value:  externalSources);
        return AkSoundEngine.PostEvent(in_eventID:  eventId, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string eventName, UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
    {
        uint val_2 = numSources;
        if(val_2 >= 2)
        {
                UnityEngine.Debug.LogError(message:  "WwiseUnity: This version of PostEvent only sends 1 external source to the sound engine.");
            val_2 = 1;
        }
        
        AkExternalSourceInfoArray val_1 = new AkExternalSourceInfoArray(count:  1);
        if(val_2 == 0)
        {
                return AkSoundEngine.PostEvent(in_pszEventName:  eventName, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1, in_PlayingID:  playingId);
        }
        
        val_1.set_Item(index:  0, value:  externalSources);
        return AkSoundEngine.PostEvent(in_pszEventName:  eventName, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1, in_PlayingID:  playingId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint PostEvent(string eventName, UnityEngine.GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
    {
        if(numSources >= 2)
        {
                UnityEngine.Debug.LogError(message:  "WwiseUnity: This version of PostEvent only sends 1 external source to the sound engine.");
        }
        else
        {
                if(numSources == 0)
        {
                return AkSoundEngine.PostEvent(in_pszEventName:  eventName, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie);
        }
        
        }
        
        AkExternalSourceInfoArray val_1 = new AkExternalSourceInfoArray(count:  1);
        val_1.set_Item(index:  0, value:  externalSources);
        return AkSoundEngine.PostEvent(in_pszEventName:  eventName, in_gameObjectID:  gameObject, in_uFlags:  flags, in_pfnCallback:  callback, in_pCookie:  cookie, in_cExternals:  1, in_pExternalSources:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void PreGameObjectAPICall(UnityEngine.GameObject gameObject, ulong id)
    {
        AkSoundEngine.PreGameObjectAPICallUserHook(gameObject:  gameObject, id:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void PreGameObjectAPICallUserHook(UnityEngine.GameObject gameObject, ulong id)
    {
        var val_3;
        if((AkSoundEngine.IsInRegisteredList(id:  id)) == true)
        {
                return;
        }
        
        val_3 = null;
        if(AkSoundEngine.IsInitialized() == false)
        {
                return;
        }
        
        AkSoundEngine.AutoRegister(gameObject:  gameObject, id:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void PostRegisterGameObjUserHook(AKRESULT result, UnityEngine.GameObject gameObject, ulong id)
    {
        var val_2;
        if(result != 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        bool val_1 = AkSoundEngine.RegisteredGameObjects.Add(item:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void PostUnregisterGameObjUserHook(AKRESULT result, UnityEngine.GameObject gameObject, ulong id)
    {
        var val_2;
        if(result != 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        bool val_1 = AkSoundEngine.RegisteredGameObjects.Remove(item:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void AutoRegister(UnityEngine.GameObject gameObject, ulong id)
    {
        if(gameObject != 0)
        {
                if(gameObject.activeInHierarchy != false)
        {
                if((gameObject.GetComponent<AkGameObj>()) != 0)
        {
                return;
        }
        
            AkGameObj val_5 = gameObject.AddComponent<AkGameObj>();
            return;
        }
        
        }
        
        AkSoundEngine.AutoObject val_6 = new AkSoundEngine.AutoObject(go:  gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool IsInRegisteredList(ulong id)
    {
        null = null;
        if(AkSoundEngine.RegisteredGameObjects != null)
        {
                return AkSoundEngine.RegisteredGameObjects.Contains(item:  id);
        }
        
        return AkSoundEngine.RegisteredGameObjects.Contains(item:  id);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsGameObjectRegistered(UnityEngine.GameObject in_gameObject)
    {
        return AkSoundEngine.IsInRegisteredList(id:  AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObject));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSoundEngine()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkSoundEngine()
    {
        AkSoundEngine.Deprecation_2019_1_1 = new AkSoundEngine.GameObjectHashFunction(object:  0, method:  static System.UInt64 AkSoundEngine::InternalGameObjectHash(UnityEngine.GameObject gameObject));
        AkSoundEngine.RegisteredGameObjects = new System.Collections.Generic.HashSet<System.UInt64>();
    }

}
