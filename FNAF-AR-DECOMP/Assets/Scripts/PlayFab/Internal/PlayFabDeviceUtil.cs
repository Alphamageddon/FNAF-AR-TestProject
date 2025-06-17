using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabDeviceUtil
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _needsAttribution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _gatherDeviceInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _gatherScreenTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void DoAttributeInstall(PlayFab.PlayFabApiSettings settings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            var val_6;
            if(PlayFab.Internal.PlayFabDeviceUtil._needsAttribution == false)
            {
                    return;
            }
            
            if((settings & 1) != 0)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  settings, b:  "Adid")) == false)
            {
                goto label_4;
            }
            
            .Adid = settings;
            if(instanceApi != null)
            {
                goto label_6;
            }
            
            goto label_10;
            label_4:
            if((System.String.op_Equality(a:  settings, b:  "Idfa")) != false)
            {
                    .Idfa = settings;
            }
            
            if(instanceApi == null)
            {
                goto label_10;
            }
            
            label_6:
            label_10:
            val_6 = 0;
            AttributeInstall(request:  new PlayFab.ClientModels.AttributeInstallRequest(), resultCallback:  new System.Action<PlayFab.ClientModels.AttributeInstallResult>(object:  0, method:  static System.Void PlayFab.Internal.PlayFabDeviceUtil::OnAttributeInstall(PlayFab.ClientModels.AttributeInstallResult result)), errorCallback:  0, customData:  settings, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnAttributeInstall(PlayFab.ClientModels.AttributeInstallResult result)
        {
            string val_3 = 0 + "_Successful";
            if(1 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SendDeviceInfoToPlayFab(PlayFab.PlayFabApiSettings settings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            var val_8;
            var val_11;
            if((settings & 1) != 0)
            {
                    return;
            }
            
            if(PlayFab.Internal.PlayFabDeviceUtil._gatherDeviceInfo == false)
            {
                    return;
            }
            
            val_8 = public static PlayFab.ISerializerPlugin PlayFab.PluginManager::GetPlugin<PlayFab.ISerializerPlugin>(PlayFab.PluginContract contract, string instanceName);
            PlayFab.ISerializerPlugin val_1 = PlayFab.PluginManager.GetPlugin<PlayFab.ISerializerPlugin>(contract:  0, instanceName:  "");
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_8 = 3;
            string val_5 = val_1.SerializeObject(obj:  new PlayFab.PlayFabDataGatherer());
            var val_10 = 0;
            val_10 = val_10 + 1;
            .Info = val_1;
            val_11 = 0;
            ReportDeviceInfo(request:  new PlayFab.ClientModels.DeviceInfoRequest(), resultCallback:  0, errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  0, method:  static System.Void PlayFab.Internal.PlayFabDeviceUtil::OnGatherFail(PlayFab.PlayFabError error)), customData:  settings, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnGatherFail(PlayFab.PlayFabError error)
        {
            UnityEngine.Debug.Log(message:  "OnGatherFail: "("OnGatherFail: ") + error.GenerateErrorReport());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnPlayFabLogin(PlayFab.SharedModels.PlayFabResultCommon result, PlayFab.PlayFabApiSettings settings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            var val_4;
            var val_5;
            PlayFab.ClientModels.UserSettings val_6;
            var val_7;
            string val_8;
            string val_9;
            string val_10;
            if(result == null)
            {
                    return;
            }
            
            val_4 = 0;
            val_5 = 0;
            val_6 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 96];
            val_6 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 96;
            val_7 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40];
            val_7 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40;
            val_8 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 80];
            val_8 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 80;
            val_7 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40];
            val_7 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40;
            val_9 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40 + 16 + 16];
            val_9 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40 + 16 + 16;
            val_10 = mem[(PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40 + 16 + 24];
            val_10 = (PlayFab.SharedModels.PlayFabResultCommon.__il2cppRuntimeField_typeHierarchy + (PlayFab.ClientModels.LoginResult.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? result : 0 + 40 + 16 + 24;
            PlayFab.Internal.PlayFabDeviceUtil._OnPlayFabLogin(settingsForUser:  val_6, playFabId:  val_8, entityId:  null, entityType:  null, settings:  settings, instanceApi:  instanceApi);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void _OnPlayFabLogin(PlayFab.ClientModels.UserSettings settingsForUser, string playFabId, string entityId, string entityType, PlayFab.PlayFabApiSettings settings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            PlayFab.Internal.PlayFabDeviceUtil._gatherScreenTime = false;
            PlayFab.Internal.PlayFabDeviceUtil._gatherDeviceInfo = false;
            PlayFab.Internal.PlayFabDeviceUtil._needsAttribution = false;
            if(settingsForUser != null)
            {
                    PlayFab.Internal.PlayFabDeviceUtil._needsAttribution = settingsForUser.NeedsAttribution;
                PlayFab.Internal.PlayFabDeviceUtil._gatherDeviceInfo = settingsForUser.GatherDeviceInfo;
                PlayFab.Internal.PlayFabDeviceUtil._gatherScreenTime = settingsForUser.GatherFocusInfo;
            }
            
            if((settings != null) && (settings != null))
            {
                    PlayFab.Internal.PlayFabDeviceUtil.DoAttributeInstall(settings:  settings, instanceApi:  instanceApi);
            }
            else
            {
                    PlayFab.Internal.PlayFabDeviceUtil.GetAdvertIdFromUnity(settings:  settings, instanceApi:  instanceApi);
            }
            
            PlayFab.Internal.PlayFabDeviceUtil.SendDeviceInfoToPlayFab(settings:  settings, instanceApi:  instanceApi);
            if((((System.String.IsNullOrEmpty(value:  entityId)) != true) && ((System.String.IsNullOrEmpty(value:  entityType)) != true)) && (PlayFab.Internal.PlayFabDeviceUtil._gatherScreenTime != false))
            {
                    PlayFab.Internal.PlayFabHttp.InitializeScreenTimeTracker(entityId:  entityId, entityType:  entityType, playFabUserId:  playFabId);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void GetAdvertIdFromUnity(PlayFab.PlayFabApiSettings settings, PlayFab.SharedModels.IPlayFabInstanceApi instanceApi)
        {
            PlayFabDeviceUtil.<>c__DisplayClass9_0 val_1 = new PlayFabDeviceUtil.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    .settings = settings;
            }
            else
            {
                    mem[16] = settings;
            }
            
            .instanceApi = instanceApi;
            bool val_3 = UnityEngine.Application.RequestAdvertisingIdentifierAsync(delegateMethod:  new Application.AdvertisingIdentifierCallback(object:  val_1, method:  System.Void PlayFabDeviceUtil.<>c__DisplayClass9_0::<GetAdvertIdFromUnity>b__0(string advertisingId, bool trackingEnabled, string error)));
        }
    
    }

}
