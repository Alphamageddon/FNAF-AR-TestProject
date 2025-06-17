using UnityEngine;

namespace MoreMountains.NiceVibrations
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class MMVibrationManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long LightDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long MediumDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static long HeavyDuration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int LightAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int MediumAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int HeavyAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int _sdkVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _lightimpactPattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _lightimpactPatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _mediumimpactPattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _mediumimpactPatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _HeavyimpactPattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _HeavyimpactPatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _successPattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _successPatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _warningPattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _warningPatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static long[] _failurePattern;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int[] _failurePatternAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass UnityPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject CurrentActivity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject AndroidVibrator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass VibrationEffectClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject VibrationEffect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int DefaultAmplitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IntPtr AndroidVibrateMethodRawClass;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.jvalue[] AndroidVibrateMethodRawClassParameters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool iOSHapticsInitialized;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Android()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool iOS()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Vibrate()
        {
            null = null;
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrate(milliseconds:  MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Haptic(MoreMountains.NiceVibrations.HapticTypes type, bool defaultToRegularVibrate = False)
        {
            if(type > 6)
            {
                    return;
            }
            
            var val_1 = 52955592 + (type) << 2;
            val_1 = val_1 + 52955592;
            goto (52955592 + (type) << 2 + 52955592);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidVibrate(long milliseconds)
        {
            null = null;
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrateMethodRawClassParameters.__unknownFiledOffset_20 = milliseconds;
            UnityEngine.AndroidJNI.CallVoidMethod(obj:  MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator.GetRawObject(), methodID:  MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrateMethodRawClass, args:  MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrateMethodRawClassParameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidVibrate(long milliseconds, int amplitude)
        {
            var val_5 = null;
            if(MoreMountains.NiceVibrations.MMVibrationManager.AndroidSDKVersion() <= 25)
            {
                    MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrate(milliseconds:  milliseconds);
                return;
            }
            
            MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClassInitialization();
            object[] val_2 = new object[2];
            val_2[0] = milliseconds;
            val_2[1] = amplitude;
            MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createOneShot", args:  val_2);
            object[] val_4 = new object[1];
            val_4[0] = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect;
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator.Call(methodName:  "vibrate", args:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidVibrate(long[] pattern, int repeat)
        {
            var val_6;
            var val_7;
            UnityEngine.AndroidJavaObject val_8;
            object val_9;
            string val_10;
            System.Object[] val_11;
            val_6 = null;
            val_7 = null;
            if(MoreMountains.NiceVibrations.MMVibrationManager.AndroidSDKVersion() <= 25)
            {
                    val_7 = null;
                val_8 = MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator;
                object[] val_2 = new object[2];
                val_2[0] = pattern;
                val_9 = repeat;
                val_2[1] = val_9;
                val_10 = "vibrate";
                val_11 = val_2;
            }
            else
            {
                    MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClassInitialization();
                object[] val_3 = new object[2];
                val_3[0] = pattern;
                val_3[1] = repeat;
                MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createWaveform", args:  val_3);
                val_9 = MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator;
                object[] val_5 = new object[1];
                val_8 = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect;
                val_5[0] = val_8;
                val_10 = "vibrate";
                val_11 = val_5;
            }
            
            val_9.Call(methodName:  val_10, args:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidVibrate(long[] pattern, int[] amplitudes, int repeat)
        {
            var val_6;
            var val_7;
            UnityEngine.AndroidJavaObject val_8;
            object val_9;
            string val_10;
            System.Object[] val_11;
            val_6 = null;
            val_7 = null;
            if(MoreMountains.NiceVibrations.MMVibrationManager.AndroidSDKVersion() <= 25)
            {
                    val_7 = null;
                val_8 = MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator;
                object[] val_2 = new object[2];
                val_2[0] = pattern;
                val_9 = repeat;
                val_2[1] = val_9;
                val_10 = "vibrate";
                val_11 = val_2;
            }
            else
            {
                    MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClassInitialization();
                object[] val_3 = new object[3];
                val_3[0] = pattern;
                val_3[1] = amplitudes;
                val_3[2] = repeat;
                MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "createWaveform", args:  val_3);
                val_9 = MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator;
                object[] val_5 = new object[1];
                val_8 = MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffect;
                val_5[0] = val_8;
                val_10 = "vibrate";
                val_11 = val_5;
            }
            
            val_9.Call(methodName:  val_10, args:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidCancelVibrations()
        {
            null = null;
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator.Call(methodName:  "cancel", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void VibrationEffectClassInitialization()
        {
            UnityEngine.AndroidJavaClass val_2;
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClass != null)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.AndroidJavaClass(className:  "android.os.VibrationEffect");
            val_4 = null;
            val_4 = null;
            MoreMountains.NiceVibrations.MMVibrationManager.VibrationEffectClass = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int AndroidSDKVersion()
        {
            var val_6;
            int val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            val_7 = MoreMountains.NiceVibrations.MMVibrationManager._sdkVersion;
            if(val_7 != 1)
            {
                    val_7 = MoreMountains.NiceVibrations.MMVibrationManager._sdkVersion;
                return val_7;
            }
            
            string val_6 = "-";
            val_6 = (UnityEngine.SystemInfo.operatingSystem.IndexOf(value:  val_6)) + 1;
            val_8 = null;
            val_7 = System.Int32.Parse(s:  UnityEngine.SystemInfo.operatingSystem.Substring(startIndex:  val_6, length:  3));
            val_8 = null;
            MoreMountains.NiceVibrations.MMVibrationManager._sdkVersion = val_7;
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void InstantiateFeedbackGenerators()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ReleaseFeedbackGenerators()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SelectionHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SuccessHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void WarningHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void FailureHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void LightImpactHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void MediumImpactHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void HeavyImpactHaptic()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void iOSInitializeHaptics()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void iOSReleaseHaptics()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool HapticsSupported()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void iOSTriggerHaptics(MoreMountains.NiceVibrations.HapticTypes type, bool defaultToRegularVibrate = False)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string iOSSDKVersion()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static MMVibrationManager()
        {
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            MoreMountains.NiceVibrations.MMVibrationManager.LightDuration = 20;
            MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration = 40;
            MoreMountains.NiceVibrations.MMVibrationManager.HeavyDuration = 80;
            MoreMountains.NiceVibrations.MMVibrationManager.LightAmplitude = 40;
            MoreMountains.NiceVibrations.MMVibrationManager.MediumAmplitude = 120;
            MoreMountains.NiceVibrations.MMVibrationManager.HeavyAmplitude = 255;
            MoreMountains.NiceVibrations.MMVibrationManager._sdkVersion = 0;
            long[] val_1 = new long[2];
            val_1[1] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._lightimpactPattern = val_1;
            int[] val_2 = new int[2];
            val_2[0] = MoreMountains.NiceVibrations.MMVibrationManager.LightAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._lightimpactPatternAmplitude = val_2;
            long[] val_3 = new long[2];
            val_3[1] = MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._mediumimpactPattern = val_3;
            int[] val_4 = new int[2];
            val_4[0] = MoreMountains.NiceVibrations.MMVibrationManager.MediumAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._mediumimpactPatternAmplitude = val_4;
            long[] val_5 = new long[2];
            val_5[1] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._HeavyimpactPattern = val_5;
            int[] val_6 = new int[2];
            val_6[0] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._HeavyimpactPatternAmplitude = val_6;
            long[] val_7 = new long[4];
            val_20 = val_7.Length;
            if(val_20 <= 1)
            {
                    val_20 = val_7.Length;
            }
            
            val_7[1] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            if(val_20 <= 2)
            {
                    val_20 = val_7.Length;
            }
            
            val_7[2] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            val_7[3] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._successPattern = val_7;
            int[] val_8 = new int[4];
            val_21 = val_8.Length;
            if(val_21 <= 1)
            {
                    val_21 = val_8.Length;
            }
            
            val_8[0] = MoreMountains.NiceVibrations.MMVibrationManager.LightAmplitude;
            val_8[1] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._successPatternAmplitude = val_8;
            long[] val_9 = new long[4];
            val_22 = val_9.Length;
            if(val_22 <= 1)
            {
                    val_22 = val_9.Length;
            }
            
            val_9[1] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyDuration;
            if(val_22 <= 2)
            {
                    val_22 = val_9.Length;
            }
            
            val_9[2] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            val_9[3] = MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._warningPattern = val_9;
            int[] val_10 = new int[4];
            val_23 = val_10.Length;
            if(val_23 <= 1)
            {
                    val_23 = val_10.Length;
            }
            
            val_10[0] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyAmplitude;
            val_10[1] = MoreMountains.NiceVibrations.MMVibrationManager.MediumAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._warningPatternAmplitude = val_10;
            long[] val_11 = new long[8];
            val_24 = val_11.Length;
            if(val_24 <= 1)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[1] = MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration;
            if(val_24 <= 2)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[2] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            if(val_24 <= 3)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[3] = MoreMountains.NiceVibrations.MMVibrationManager.MediumDuration;
            if(val_24 <= 4)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[4] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            if(val_24 <= 5)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[5] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyDuration;
            if(val_24 <= 6)
            {
                    val_24 = val_11.Length;
            }
            
            val_11[6] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            val_11[7] = MoreMountains.NiceVibrations.MMVibrationManager.LightDuration;
            MoreMountains.NiceVibrations.MMVibrationManager._failurePattern = val_11;
            int[] val_12 = new int[8];
            val_25 = val_12.Length;
            if(val_25 <= 1)
            {
                    val_25 = val_12.Length;
            }
            
            val_12[0] = MoreMountains.NiceVibrations.MMVibrationManager.MediumAmplitude;
            if(val_25 <= 3)
            {
                    val_25 = val_12.Length;
            }
            
            val_12[1] = MoreMountains.NiceVibrations.MMVibrationManager.MediumAmplitude;
            if(val_25 <= 5)
            {
                    val_25 = val_12.Length;
            }
            
            val_12[2] = MoreMountains.NiceVibrations.MMVibrationManager.HeavyAmplitude;
            val_12[3] = MoreMountains.NiceVibrations.MMVibrationManager.LightAmplitude;
            MoreMountains.NiceVibrations.MMVibrationManager._failurePatternAmplitude = val_12;
            UnityEngine.AndroidJavaClass val_13 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer");
            MoreMountains.NiceVibrations.MMVibrationManager.UnityPlayer = val_13;
            MoreMountains.NiceVibrations.MMVibrationManager.CurrentActivity = val_13.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
            object[] val_15 = new object[1];
            val_15[0] = "vibrator";
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator = MoreMountains.NiceVibrations.MMVibrationManager.CurrentActivity.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSystemService", args:  val_15);
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrateMethodRawClass = UnityEngine.AndroidJNIHelper.GetMethodID(javaClass:  MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrator.GetRawClass(), methodName:  "vibrate", signature:  "(J)V", isStatic:  false);
            MoreMountains.NiceVibrations.MMVibrationManager.AndroidVibrateMethodRawClassParameters = new UnityEngine.jvalue[1];
            MoreMountains.NiceVibrations.MMVibrationManager.iOSHapticsInitialized = false;
        }
    
    }

}
