using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PluginManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<PlayFab.PluginContractKey, PlayFab.IPlayFabPlugin> plugins;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly PlayFab.PluginManager Instance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PluginManager()
        {
            this.plugins = new System.Collections.Generic.Dictionary<PlayFab.PluginContractKey, PlayFab.IPlayFabPlugin>(comparer:  new PlayFab.PluginContractKeyComparator());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T GetPlugin<T>(PlayFab.PluginContract contract, string instanceName = "")
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            PlayFab.IPlayFabPlugin val_1 = PlayFab.PluginManager.Instance.GetPluginInternal(contract:  contract, instanceName:  instanceName);
            if(val_1 != null)
            {
                    val_4 = val_1;
                if(val_4 != null)
            {
                    return (PlayFab.ISerializerPlugin)val_4;
            }
            
            }
            
            val_4 = 0;
            return (PlayFab.ISerializerPlugin)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetPlugin(PlayFab.IPlayFabPlugin plugin, PlayFab.PluginContract contract, string instanceName = "")
        {
            null = null;
            PlayFab.PluginManager.Instance.SetPluginInternal(plugin:  plugin, contract:  contract, instanceName:  instanceName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.IPlayFabPlugin GetPluginInternal(PlayFab.PluginContract contract, string instanceName)
        {
            bool val_2 = this.plugins.TryGetValue(key:  new PlayFab.PluginContractKey() {_pluginContract = contract, _pluginName = instanceName}, value: out  0);
            if(val_2 == true)
            {
                    return (PlayFab.IPlayFabPlugin)val_4;
            }
            
            if(contract == 1)
            {
                goto label_3;
            }
            
            if(contract != 0)
            {
                goto label_4;
            }
            
            PlayFab.IPlayFabPlugin val_3 = this.CreatePlugin<PlayFab.Json.SimpleJsonInstance>();
            goto label_5;
            label_3:
            PlayFab.ITransportPlugin val_4 = val_2.CreatePlayFabTransportPlugin();
            label_5:
            this.plugins.set_Item(key:  new PlayFab.PluginContractKey() {_pluginContract = contract, _pluginName = instanceName}, value:  val_4);
            return (PlayFab.IPlayFabPlugin)val_4;
            label_4:
            System.ArgumentException val_5 = new System.ArgumentException(message:  "This contract is not supported", paramName:  "contract");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetPluginInternal(PlayFab.IPlayFabPlugin plugin, PlayFab.PluginContract contract, string instanceName)
        {
            if(plugin != null)
            {
                    this.plugins.set_Item(key:  new PlayFab.PluginContractKey() {_pluginContract = contract, _pluginName = instanceName}, value:  plugin);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "plugin", message:  "Plugin instance cannot be null");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.IPlayFabPlugin CreatePlugin<T>()
        {
            IntPtr val_4;
            var val_5;
            val_4 = mem[__RuntimeMethodHiddenParam + 48];
            val_4 = __RuntimeMethodHiddenParam + 48;
            object val_2 = System.Activator.CreateInstance(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_4}));
            if(val_2 == null)
            {
                    return (PlayFab.IPlayFabPlugin)val_5;
            }
            
            val_5 = val_2;
            val_4 = null;
            if(val_5 != null)
            {
                    return (PlayFab.IPlayFabPlugin)val_5;
            }
            
            val_5 = 0;
            return (PlayFab.IPlayFabPlugin)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.ITransportPlugin CreatePlayFabTransportPlugin()
        {
            var val_4;
            if(PlayFab.PlayFabSettings.RequestType == 1)
            {
                    PlayFab.Internal.PlayFabWebRequest val_2 = null;
                val_4 = val_2;
                val_2 = new PlayFab.Internal.PlayFabWebRequest();
                if(val_4 != null)
            {
                    return (PlayFab.ITransportPlugin)val_4;
            }
            
            }
            
            PlayFab.Internal.PlayFabUnityHttp val_3 = null;
            val_4 = val_3;
            val_3 = new PlayFab.Internal.PlayFabUnityHttp();
            return (PlayFab.ITransportPlugin)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PluginManager()
        {
            PlayFab.PluginManager.Instance = new PlayFab.PluginManager();
        }
    
    }

}
