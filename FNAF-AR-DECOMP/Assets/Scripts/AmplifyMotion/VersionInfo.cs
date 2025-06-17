using UnityEngine;

namespace AmplifyMotion
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VersionInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const byte Major = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const byte Minor = 9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const byte Release = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string StageSuffix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string TrialSuffix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_major;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_minor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_release;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Number { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string StaticToString()
        {
            var val_3 = null;
            return (string)System.String.Format(format:  "{0}.{1}.{2}", arg0:  1, arg1:  9, arg2:  0)(System.String.Format(format:  "{0}.{1}.{2}", arg0:  1, arg1:  9, arg2:  0)) + AmplifyMotion.VersionInfo.StageSuffix + AmplifyMotion.VersionInfo.TrialSuffix;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            var val_3 = null;
            return (string)System.String.Format(format:  "{0}.{1}.{2}", arg0:  this.m_major, arg1:  this.m_minor, arg2:  this.m_release)(System.String.Format(format:  "{0}.{1}.{2}", arg0:  this.m_major, arg1:  this.m_minor, arg2:  this.m_release)) + AmplifyMotion.VersionInfo.StageSuffix + AmplifyMotion.VersionInfo.TrialSuffix;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Number()
        {
            int val_2 = this.m_major;
            val_2 = val_2 * 100;
            val_2 = val_2 + (this.m_minor * 10);
            return (int)val_2 + this.m_release;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VersionInfo()
        {
            this.m_major = 1;
            this.m_minor = 9;
            this.m_release = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private VersionInfo(byte major, byte minor, byte release)
        {
            this.m_major = major & 255;
            this.m_minor = minor & 255;
            this.m_release = release & 255;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static AmplifyMotion.VersionInfo Current()
        {
            .m_major = 1;
            .m_minor = 9;
            .m_release = 0;
            return (AmplifyMotion.VersionInfo)new AmplifyMotion.VersionInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Matches(AmplifyMotion.VersionInfo version)
        {
            var val_2;
            if((version.m_major == 1) && (version.m_minor == 9))
            {
                    var val_1 = (version.m_release == 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static VersionInfo()
        {
            AmplifyMotion.VersionInfo.StageSuffix = "_dev001";
            AmplifyMotion.VersionInfo.TrialSuffix = "";
        }
    
    }

}
