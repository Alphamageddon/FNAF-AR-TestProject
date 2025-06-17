using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SendAnimatronicV2Requester.<>c__DisplayClass0_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.Server.SendAnimatronicV2Params parameters;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.Server.SendAnimatronicV2Callbacks callbacks;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SendAnimatronicV2Requester.<>c__DisplayClass0_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <SendAnimatronic>g__OnAnimatronicSent|0(Systems.Server.ServerResponse response)
    {
        AnimatronicEntity.Data.WorkshopEntry val_4 = Game.Server.Processors.ServerProcessors.ProcessWorkshopDataEntry(entry:  response.ScriptData.GetServerDataList(key:  "WarehouseDataV2").Item[this.parameters.slotId]);
        Game.Server.SendAnimatronicV2ResponseData val_5 = new Game.Server.SendAnimatronicV2ResponseData();
        if(val_5 != null)
        {
                .workshopEntry = val_4;
        }
        else
        {
                mem[16] = val_4;
        }
        
        .slotId = this.parameters.slotId;
        this.callbacks.successCallback.Invoke(obj:  val_5);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <SendAnimatronic>g__OnError|1(Systems.Server.ServerData serverData)
    {
        this.callbacks.errorCallback.Invoke(obj:  serverData.JSON);
    }

}
