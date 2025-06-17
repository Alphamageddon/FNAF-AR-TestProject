using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PluginContractKeyComparator : EqualityComparer<PlayFab.PluginContractKey>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(PlayFab.PluginContractKey x, PlayFab.PluginContractKey y)
        {
            if(x._pluginContract != y._pluginContract)
            {
                    return false;
            }
            
            if(x._pluginName != null)
            {
                    return x._pluginName.Equals(value:  y._pluginName);
            }
            
            return x._pluginName.Equals(value:  y._pluginName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode(PlayFab.PluginContractKey obj)
        {
            string val_1 = obj._pluginName;
            val_1 = val_1 + obj._pluginContract;
            return (int)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PluginContractKeyComparator()
        {
        
        }
    
    }

}
