using UnityEngine;

namespace Game.MasterData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.MasterData <_masterData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.DataDeserializer <_dataDeserializer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.GetAccessToData <_getAccessToData>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.GetAccessToData GetAccessToData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterData _masterData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.DataDeserializer _dataDeserializer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.GetAccessToData _getAccessToData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.GetAccessToData get_GetAccessToData()
        {
            return (Game.MasterData.GetAccessToData)this.<_getAccessToData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterData get__masterData()
        {
            return (Game.MasterData.MasterData)this.<_masterData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.DataDeserializer get__dataDeserializer()
        {
            return (Game.MasterData.DataDeserializer)this.<_dataDeserializer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.GetAccessToData get__getAccessToData()
        {
            return (Game.MasterData.GetAccessToData)this.<_getAccessToData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataDomain(Master.EventExposer eventExposer)
        {
            Game.MasterData.MasterData val_1 = new Game.MasterData.MasterData();
            this.<_masterData>k__BackingField = val_1;
            this.<_dataDeserializer>k__BackingField = new Game.MasterData.DataDeserializer(masterData:  val_1, eventExposer:  eventExposer);
            this.<_getAccessToData>k__BackingField = new Game.MasterData.GetAccessToData(masterData:  this.<_masterData>k__BackingField);
        }
    
    }

}
