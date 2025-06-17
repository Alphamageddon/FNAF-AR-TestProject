using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StandardSystemInformationService : ISystemInformationService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.IList<SRDebugger.InfoEntry>> _info;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StandardSystemInformationService()
        {
            this._info = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IList<SRDebugger.InfoEntry>>();
            this.CreateDefaultSet();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<string> GetCategories()
        {
            if(this._info != null)
            {
                    return this._info.Keys;
            }
            
            return this._info.Keys;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IList<SRDebugger.InfoEntry> GetInfo(string category)
        {
            string val_6;
            var val_7;
            val_6 = category;
            System.Collections.Generic.IList<SRDebugger.InfoEntry> val_1 = 0;
            if((this._info.TryGetValue(key:  val_6, value: out  val_1)) != false)
            {
                    val_7 = val_1;
                return (System.Collections.Generic.IList<SRDebugger.InfoEntry>)new SRDebugger.InfoEntry[0];
            }
            
            object[] val_3 = new object[1];
            val_3[0] = val_6;
            val_6 = SRF.SRFStringExtensions.Fmt(formatString:  "[SystemInformationService] Category not found: {0}", args:  val_3);
            UnityEngine.Debug.LogError(message:  val_6);
            return (System.Collections.Generic.IList<SRDebugger.InfoEntry>)new SRDebugger.InfoEntry[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add(SRDebugger.InfoEntry info, string category = "Default")
        {
            var val_10;
            var val_11;
            .info = info;
            if((this._info.TryGetValue(key:  category, value: out  0)) != true)
            {
                    System.Collections.Generic.List<SRDebugger.InfoEntry> val_4 = new System.Collections.Generic.List<SRDebugger.InfoEntry>();
                this._info.Add(key:  category, value:  val_4);
            }
            
            val_10 = public static System.Boolean System.Linq.Enumerable::Any<SRDebugger.InfoEntry>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
            if((System.Linq.Enumerable.Any<SRDebugger.InfoEntry>(source:  val_4, predicate:  new System.Func<SRDebugger.InfoEntry, System.Boolean>(object:  new StandardSystemInformationService.<>c__DisplayClass4_0(), method:  System.Boolean StandardSystemInformationService.<>c__DisplayClass4_0::<Add>b__0(SRDebugger.InfoEntry p)))) == true)
            {
                goto label_5;
            }
            
            System.Collections.Generic.List<T> val_11 = val_4;
            if((public System.Void System.Func<SRDebugger.InfoEntry, System.Boolean>::.ctor(object object, IntPtr method)) == 0)
            {
                goto label_7;
            }
            
            var val_9 = 0;
            var val_7 = X11 + 8;
            label_9:
            if(((X11 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_9 = val_9 + 1;
            val_7 = val_7 + 16;
            if(val_9 < 1152921523003358048)
            {
                goto label_9;
            }
            
            label_7:
            val_10 = 2;
            goto label_10;
            label_8:
            var val_10 = val_7;
            val_10 = val_10 + 2;
            val_11 = val_11 + val_10;
            val_11 = val_11 + 296;
            label_10:
            val_4.Add(item:  null);
            return;
            label_5:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "An InfoEntry object with the same title already exists in that category.", paramName:  "info");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> CreateReport(bool includePrivate = False)
        {
            var val_5;
            var val_18;
            var val_19;
            var val_20;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._info.GetEnumerator();
            val_18 = 0;
            val_19 = 0;
            label_44:
            if((1216842944 & 1) == 0)
            {
                goto label_45;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            ulong val_22 = val_6.m_SubId1;
            if((val_6.m_SubId1 + 286) == 0)
            {
                goto label_7;
            }
            
            var val_20 = val_6.m_SubId1 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_6:
            if(((val_6.m_SubId1 + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (val_6.m_SubId1 + 286))
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            val_22 = val_22 + (((val_6.m_SubId1 + 176 + 8)) << 4);
            val_20 = val_22 + 296;
            label_7:
            System.Collections.Generic.IEnumerator<T> val_8 = val_6.m_SubId1.GetEnumerator();
            label_25:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            T val_12 = val_8.Current;
            if(val_12.IsPrivate != false)
            {
                    if(includePrivate == false)
            {
                goto label_25;
            }
            
            }
            
            null.Add(key:  val_12.Title, value:  val_12.Value);
            goto label_25;
            label_13:
            if(val_8 == null)
            {
                
            }
            else
            {
                    var val_25 = 0;
                val_25 = val_25 + 1;
                val_8.Dispose();
            }
            
            if(((114 == 0) ? 114 : 114) == 114)
            {
                
            }
            else
            {
                    if( != false)
            {
                
            }
            
            }
            
            val_1.Add(key:  val_6.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.IList<SRDebugger.InfoEntry>>::get_Key()), value:  null);
            goto label_44;
            label_45:
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523003559104});
            if( == false)
            {
                    return val_1;
            }
            
            if(114 == 0)
            {
                    return val_1;
            }
            
            if(114 == 153)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateDefaultSet()
        {
            var val_125;
            System.Func<System.Object> val_127;
            var val_128;
            System.Func<System.Object> val_130;
            var val_131;
            System.Func<System.Object> val_133;
            var val_134;
            System.Func<System.Object> val_136;
            var val_137;
            System.Func<System.Object> val_139;
            var val_140;
            System.Func<System.Object> val_142;
            var val_143;
            System.Func<System.Object> val_145;
            var val_146;
            System.Func<System.Object> val_148;
            UnityEngine.Object val_149;
            UnityEngine.SystemLanguage val_150;
            var val_151;
            SRDebugger.InfoEntry[] val_1 = new SRDebugger.InfoEntry[7];
            val_1[0] = SRDebugger.InfoEntry.Create(name:  "Operating System", value:  UnityEngine.SystemInfo.operatingSystem, isPrivate:  false);
            val_1[1] = SRDebugger.InfoEntry.Create(name:  "Device Name", value:  UnityEngine.SystemInfo.deviceName, isPrivate:  true);
            val_1[2] = SRDebugger.InfoEntry.Create(name:  "Device Type", value:  UnityEngine.SystemInfo.deviceType, isPrivate:  false);
            val_1[3] = SRDebugger.InfoEntry.Create(name:  "Device Model", value:  UnityEngine.SystemInfo.deviceModel, isPrivate:  false);
            val_1[4] = SRDebugger.InfoEntry.Create(name:  "CPU Type", value:  UnityEngine.SystemInfo.processorType, isPrivate:  false);
            val_1[5] = SRDebugger.InfoEntry.Create(name:  "CPU Count", value:  UnityEngine.SystemInfo.processorCount, isPrivate:  false);
            val_1[6] = SRDebugger.InfoEntry.Create(name:  "System Memory", value:  SRFileUtil.GetBytesReadable(i:  UnityEngine.SystemInfo.systemMemorySize), isPrivate:  false);
            this._info.Add(key:  "System", value:  val_1);
            SRDebugger.InfoEntry[] val_17 = new SRDebugger.InfoEntry[9];
            val_17[0] = SRDebugger.InfoEntry.Create(name:  "Version", value:  UnityEngine.Application.unityVersion, isPrivate:  false);
            val_17[1] = SRDebugger.InfoEntry.Create(name:  "Debug", value:  UnityEngine.Debug.isDebugBuild, isPrivate:  false);
            val_17[2] = SRDebugger.InfoEntry.Create(name:  "Unity Pro", value:  UnityEngine.Application.HasProLicense(), isPrivate:  false);
            object[] val_26 = new object[2];
            val_26[0] = (UnityEngine.Application.genuine != true) ? "Yes" : "No";
            val_26[1] = (UnityEngine.Application.genuineCheckAvailable != true) ? "Trusted" : "Untrusted";
            val_17[3] = SRDebugger.InfoEntry.Create(name:  "Genuine", value:  SRF.SRFStringExtensions.Fmt(formatString:  "{0} ({1})", args:  val_26), isPrivate:  false);
            UnityEngine.SystemLanguage val_33 = UnityEngine.Application.systemLanguage;
            val_17[4] = SRDebugger.InfoEntry.Create(name:  "System Language", value:  val_33, isPrivate:  false);
            val_17[5] = SRDebugger.InfoEntry.Create(name:  "Platform", value:  UnityEngine.Application.platform, isPrivate:  false);
            val_17[6] = SRDebugger.InfoEntry.Create(name:  "IL2CPP", value:  "Yes", isPrivate:  false);
            val_17[7] = SRDebugger.InfoEntry.Create(name:  "Application Version", value:  UnityEngine.Application.version, isPrivate:  false);
            val_17[8] = SRDebugger.InfoEntry.Create(name:  "SRDebugger Version", value:  "1.7.1", isPrivate:  false);
            this._info.Add(key:  "Unity", value:  val_17);
            SRDebugger.InfoEntry[] val_41 = new SRDebugger.InfoEntry[4];
            val_125 = null;
            val_125 = null;
            val_127 = StandardSystemInformationService.<>c.<>9__6_0;
            if(val_127 == null)
            {
                    System.Func<System.Object> val_42 = null;
                val_127 = val_42;
                val_42 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_0());
                StandardSystemInformationService.<>c.<>9__6_0 = val_127;
            }
            
            val_41[0] = SRDebugger.InfoEntry.Create(name:  "Resolution", getter:  val_42, isPrivate:  false);
            val_128 = null;
            val_128 = null;
            val_130 = StandardSystemInformationService.<>c.<>9__6_1;
            if(val_130 == null)
            {
                    System.Func<System.Object> val_44 = null;
                val_130 = val_44;
                val_44 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_1());
                StandardSystemInformationService.<>c.<>9__6_1 = val_130;
            }
            
            val_41[1] = SRDebugger.InfoEntry.Create(name:  "DPI", getter:  val_44, isPrivate:  false);
            val_131 = null;
            val_131 = null;
            val_133 = StandardSystemInformationService.<>c.<>9__6_2;
            if(val_133 == null)
            {
                    System.Func<System.Object> val_46 = null;
                val_133 = val_46;
                val_46 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_2());
                StandardSystemInformationService.<>c.<>9__6_2 = val_133;
            }
            
            val_41[2] = SRDebugger.InfoEntry.Create(name:  "Fullscreen", getter:  val_46, isPrivate:  false);
            val_134 = null;
            val_134 = null;
            val_136 = StandardSystemInformationService.<>c.<>9__6_3;
            if(val_136 == null)
            {
                    System.Func<System.Object> val_48 = null;
                val_136 = val_48;
                val_48 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_3());
                StandardSystemInformationService.<>c.<>9__6_3 = val_136;
            }
            
            val_41[3] = SRDebugger.InfoEntry.Create(name:  "Orientation", getter:  val_48, isPrivate:  false);
            this._info.Add(key:  "Display", value:  val_41);
            SRDebugger.InfoEntry[] val_50 = new SRDebugger.InfoEntry[4];
            val_137 = null;
            val_137 = null;
            val_139 = StandardSystemInformationService.<>c.<>9__6_4;
            if(val_139 == null)
            {
                    System.Func<System.Object> val_51 = null;
                val_139 = val_51;
                val_51 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_4());
                StandardSystemInformationService.<>c.<>9__6_4 = val_139;
            }
            
            val_50[0] = SRDebugger.InfoEntry.Create(name:  "Play Time", getter:  val_51, isPrivate:  false);
            val_140 = null;
            val_140 = null;
            val_142 = StandardSystemInformationService.<>c.<>9__6_5;
            if(val_142 == null)
            {
                    System.Func<System.Object> val_53 = null;
                val_142 = val_53;
                val_53 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_5());
                StandardSystemInformationService.<>c.<>9__6_5 = val_142;
            }
            
            val_50[1] = SRDebugger.InfoEntry.Create(name:  "Level Play Time", getter:  val_53, isPrivate:  false);
            val_143 = null;
            val_143 = null;
            val_145 = StandardSystemInformationService.<>c.<>9__6_6;
            if(val_145 == null)
            {
                    System.Func<System.Object> val_55 = null;
                val_145 = val_55;
                val_55 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_6());
                StandardSystemInformationService.<>c.<>9__6_6 = val_145;
            }
            
            val_50[2] = SRDebugger.InfoEntry.Create(name:  "Current Level", getter:  val_55, isPrivate:  false);
            val_146 = null;
            val_146 = null;
            val_148 = StandardSystemInformationService.<>c.<>9__6_7;
            if(val_148 == null)
            {
                    System.Func<System.Object> val_57 = null;
                val_148 = val_57;
                val_57 = new System.Func<System.Object>(object:  StandardSystemInformationService.<>c.__il2cppRuntimeField_static_fields, method:  System.Object StandardSystemInformationService.<>c::<CreateDefaultSet>b__6_7());
                StandardSystemInformationService.<>c.<>9__6_7 = val_148;
            }
            
            val_50[3] = SRDebugger.InfoEntry.Create(name:  "Quality Level", getter:  val_57, isPrivate:  false);
            this._info.Add(key:  "Runtime", value:  val_50);
            val_149 = UnityEngine.Resources.Load(path:  "UnityCloudBuildManifest.json");
            if(val_149 != null)
            {
                    val_149 = 0;
            }
            
            if(val_149 == 0)
            {
                goto label_140;
            }
            
            string val_62 = val_149.text;
            if(val_62 == null)
            {
                goto label_140;
            }
            
            object val_63 = Json.Parser.Parse(jsonString:  val_62);
            if(val_63 == null)
            {
                goto label_140;
            }
            
            System.Collections.Generic.List<SRDebugger.InfoEntry> val_65 = new System.Collections.Generic.List<SRDebugger.InfoEntry>(capacity:  val_63.Count);
            Dictionary.Enumerator<TKey, TValue> val_66 = val_63.GetEnumerator();
            label_145:
            if((1217433232 & 1) == 0)
            {
                goto label_141;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_69 = val_33.trackableId;
            if(val_69.m_SubId1 == 0)
            {
                goto label_145;
            }
            
            val_65.Add(item:  SRDebugger.InfoEntry.Create(name:  SRDebugger.Services.Implementation.StandardSystemInformationService.GetCloudManifestPrettyName(name:  val_69.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Object>::get_Key())), value:  val_69.m_SubId1, isPrivate:  false));
            goto label_145;
            label_141:
            val_150 = 0;
            val_151 = 1;
            long val_73 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523004149392});
            this._info.Add(key:  "Build", value:  val_65);
            label_140:
            SRDebugger.InfoEntry[] val_74 = new SRDebugger.InfoEntry[4];
            val_74[0] = SRDebugger.InfoEntry.Create(name:  "Location", value:  UnityEngine.SystemInfo.supportsLocationService, isPrivate:  false);
            val_74[1] = SRDebugger.InfoEntry.Create(name:  "Accelerometer", value:  UnityEngine.SystemInfo.supportsAccelerometer, isPrivate:  false);
            val_74[2] = SRDebugger.InfoEntry.Create(name:  "Gyroscope", value:  UnityEngine.SystemInfo.supportsGyroscope, isPrivate:  false);
            val_74[3] = SRDebugger.InfoEntry.Create(name:  "Vibration", value:  UnityEngine.SystemInfo.supportsVibration, isPrivate:  false);
            this._info.Add(key:  "Features", value:  val_74);
            SRDebugger.InfoEntry[] val_87 = new SRDebugger.InfoEntry[13];
            val_87[0] = SRDebugger.InfoEntry.Create(name:  "Device Name", value:  UnityEngine.SystemInfo.graphicsDeviceName, isPrivate:  false);
            val_87[1] = SRDebugger.InfoEntry.Create(name:  "Device Vendor", value:  UnityEngine.SystemInfo.graphicsDeviceVendor, isPrivate:  false);
            val_87[2] = SRDebugger.InfoEntry.Create(name:  "Device Version", value:  UnityEngine.SystemInfo.graphicsDeviceVersion, isPrivate:  false);
            val_87[3] = SRDebugger.InfoEntry.Create(name:  "Max Tex Size", value:  UnityEngine.SystemInfo.maxTextureSize, isPrivate:  false);
            val_87[4] = SRDebugger.InfoEntry.Create(name:  "NPOT Support", value:  UnityEngine.SystemInfo.npotSupport, isPrivate:  false);
            object[] val_98 = new object[2];
            val_98[0] = (UnityEngine.SystemInfo.supportsRenderTextures != true) ? "Yes" : "No";
            val_98[1] = UnityEngine.SystemInfo.supportedRenderTargetCount;
            val_87[5] = SRDebugger.InfoEntry.Create(name:  "Render Textures", value:  SRF.SRFStringExtensions.Fmt(formatString:  "{0} ({1})", args:  val_98), isPrivate:  false);
            val_87[6] = SRDebugger.InfoEntry.Create(name:  "3D Textures", value:  UnityEngine.SystemInfo.supports3DTextures, isPrivate:  false);
            val_87[7] = SRDebugger.InfoEntry.Create(name:  "Compute Shaders", value:  UnityEngine.SystemInfo.supportsComputeShaders, isPrivate:  false);
            val_87[8] = SRDebugger.InfoEntry.Create(name:  "Image Effects", value:  UnityEngine.SystemInfo.supportsImageEffects, isPrivate:  false);
            val_87[9] = SRDebugger.InfoEntry.Create(name:  "Cubemaps", value:  UnityEngine.SystemInfo.supportsRenderToCubemap, isPrivate:  false);
            val_87[10] = SRDebugger.InfoEntry.Create(name:  "Shadows", value:  UnityEngine.SystemInfo.supportsShadows, isPrivate:  false);
            val_87[11] = SRDebugger.InfoEntry.Create(name:  "Stencil", value:  UnityEngine.SystemInfo.supportsStencil, isPrivate:  false);
            val_87[12] = SRDebugger.InfoEntry.Create(name:  "Sparse Textures", value:  UnityEngine.SystemInfo.supportsSparseTextures, isPrivate:  false);
            this._info.Add(key:  "Graphics", value:  val_87);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetCloudManifestPrettyName(string name)
        {
            var val_8;
            if((System.String.op_Equality(a:  name, b:  "scmCommitId")) != false)
            {
                    val_8 = "Commit";
                return (string)val_8;
            }
            
            if((System.String.op_Equality(a:  name, b:  "scmBranch")) != false)
            {
                    val_8 = "Branch";
                return (string)val_8;
            }
            
            if((System.String.op_Equality(a:  name, b:  "cloudBuildTargetName")) != false)
            {
                    val_8 = "Build Target";
                return (string)val_8;
            }
            
            if((System.String.op_Equality(a:  name, b:  "buildStartTime")) == false)
            {
                    return name.Substring(startIndex:  0, length:  1).ToUpper()(name.Substring(startIndex:  0, length:  1).ToUpper()) + name.Substring(startIndex:  1)(name.Substring(startIndex:  1));
            }
            
            val_8 = "Build Date";
            return (string)val_8;
        }
    
    }

}
