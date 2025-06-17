using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ReferredUser : PublicUser, IConvertableFromNative<GetSocialSdk.Core.ReferredUser>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime <InstallationDate>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <InstallationChannel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <InstallPlatform>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Reinstall>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <InstallSuspicious>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime InstallationDate { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string InstallationChannel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string InstallPlatform { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Reinstall { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InstallSuspicious { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime get_InstallationDate()
        {
            return (System.DateTime)this.<InstallationDate>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InstallationDate(System.DateTime value)
        {
            this.<InstallationDate>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_InstallationChannel()
        {
            return (string)this.<InstallationChannel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InstallationChannel(string value)
        {
            this.<InstallationChannel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_InstallPlatform()
        {
            return (string)this.<InstallPlatform>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InstallPlatform(string value)
        {
            this.<InstallPlatform>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Reinstall()
        {
            return (bool)this.<Reinstall>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Reinstall(bool value)
        {
            this.<Reinstall>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_InstallSuspicious()
        {
            return (bool)this.<InstallSuspicious>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InstallSuspicious(bool value)
        {
            this.<InstallSuspicious>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReferredUser()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ReferredUser(System.Collections.Generic.Dictionary<string, string> publicProperties, string id, string displayName, string avatarUrl, System.Collections.Generic.Dictionary<string, string> identities, System.DateTime installationDate, string installationChannel)
        {
            val_1 = new System.Object();
            mem[1152921526019140032] = val_1;
            mem[1152921526019140040] = displayName;
            mem[1152921526019140048] = avatarUrl;
            mem[1152921526019140056] = identities;
            mem[1152921526019140064] = publicProperties;
            this.<InstallationDate>k__BackingField = installationDate;
            this.<InstallationChannel>k__BackingField = installationChannel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[6];
            string val_2 = this.ToString();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.<InstallationDate>k__BackingField;
            val_1[2] = this.<InstallationChannel>k__BackingField;
            val_1[3] = this.<InstallPlatform>k__BackingField;
            val_1[4] = this.<Reinstall>k__BackingField;
            val_1[5] = this.<InstallSuspicious>k__BackingField;
            return (string)System.String.Format(format:  "{0}, InstallationDate: {1}, InstallationChannel: {2}, InstallPlatform: {3}, Reinstall: {4}, InstallSuspicious: {5}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.ReferredUser other)
        {
            if((other.Equals(other:  other)) == false)
            {
                    return false;
            }
            
            if((this.<InstallationDate>k__BackingField.Equals(value:  new System.DateTime() {dateData = other.<InstallationDate>k__BackingField})) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<InstallationChannel>k__BackingField, b:  other.<InstallationChannel>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<InstallPlatform>k__BackingField, b:  other.<InstallPlatform>k__BackingField)) == false)
            {
                    return false;
            }
            
            var val_5 = ((this.<Reinstall>k__BackingField) == true) ? 1 : 0;
            val_5 = val_5 ^ (((other.<Reinstall>k__BackingField) == true) ? 1 : 0);
            if((val_5 & 1) != 0)
            {
                    return false;
            }
            
            var val_7 = ((this.<InstallSuspicious>k__BackingField) == true) ? 1 : 0;
            val_7 = val_7 ^ (((other.<InstallSuspicious>k__BackingField) == true) ? 1 : 0);
            var val_9 = val_7 ^ 1;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj == null)
            {
                goto label_1;
            }
            
            if(this == obj)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            label_1:
            val_3 = 0;
            return (bool)this.Equals(other:  obj);
            label_2:
            val_3 = 1;
            return (bool)this.Equals(other:  obj);
            label_3:
            val_3 = this;
            return (bool)this.Equals(other:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            var val_8;
            var val_9;
            var val_10;
            int val_9 = this.GetHashCode();
            val_8 = 0;
            int val_8 = this.<InstallationDate>k__BackingField.GetHashCode();
            val_8 = val_8 ^ (val_9 * 397);
            val_9 = val_8 * 397;
            if((this.<InstallationChannel>k__BackingField) != null)
            {
                    val_9 = this.<InstallationChannel>k__BackingField;
            }
            else
            {
                    val_9 = 0;
            }
            
            val_9 = val_9 ^ val_9;
            if((this.<InstallPlatform>k__BackingField) != null)
            {
                    val_10 = this.<InstallPlatform>k__BackingField;
            }
            else
            {
                    val_10 = 0;
            }
            
            int val_6 = this.<InstallSuspicious>k__BackingField.GetHashCode();
            int val_7 = val_10 ^ (val_9 * 397);
            val_7 = val_7 * 397;
            val_7 = (this.<Reinstall>k__BackingField.GetHashCode()) ^ val_7;
            val_7 = val_7 * 397;
            val_6 = val_6 ^ val_7;
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ReferredUser ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            var val_17;
            var val_18 = this;
            if((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  ajo)) != false)
            {
                    val_18 = 0;
                return (GetSocialSdk.Core.ReferredUser)val_18;
            }
            
            GetSocialSdk.Core.PublicUser val_2 = this.ParseFromAJO(ajo:  ajo);
            System.DateTime val_5 = GetSocialSdk.Core.DateUtils.FromUnixTime(unixTime:  GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getInstallationDate", args:  System.Array.Empty<System.Object>()));
            this.<InstallationDate>k__BackingField = val_5;
            this.<InstallationChannel>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getInstallationChannel", args:  System.Array.Empty<System.Object>());
            this.<InstallPlatform>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getInstallPlatform", args:  System.Array.Empty<System.Object>());
            this.<Reinstall>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isReinstall", args:  System.Array.Empty<System.Object>());
            val_17 = 0;
            this.<InstallSuspicious>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isInstallSuspicious", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                ajo.Dispose();
            }
            
            if(147 == 147)
            {
                    return (GetSocialSdk.Core.ReferredUser)val_18;
            }
            
            if(val_17 == 0)
            {
                    return (GetSocialSdk.Core.ReferredUser)val_18;
            }
            
            return (GetSocialSdk.Core.ReferredUser)val_18;
        }
    
    }

}
