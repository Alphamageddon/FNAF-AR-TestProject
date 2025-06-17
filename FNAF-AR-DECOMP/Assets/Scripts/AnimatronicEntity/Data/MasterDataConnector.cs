using UnityEngine;

namespace AnimatronicEntity.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> OnDataLoaded;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnDataLoaded(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataLoaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525044070576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnDataLoaded(System.Action<float> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataLoaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataLoaded != 1152921525044207152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataConnector(Game.MasterData.MasterDataDomain masterDataDomain, System.Action<float> callback)
        {
            masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void AnimatronicEntity.Data.MasterDataConnector::SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY configData)));
            this.add_OnDataLoaded(value:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetConfigData(ProtoData.CONFIG_DATA.Types.ENTRY configData)
        {
            if(configData == null)
            {
                goto label_2;
            }
            
            SCAVENGING val_1 = configData.Scavenging;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            double val_2 = val_1.Period;
            goto label_3;
            label_2:
            label_3:
            if(this.OnDataLoaded == null)
            {
                    return;
            }
            
            this.OnDataLoaded.Invoke(obj:  (float)0.South);
        }
    
    }

}
