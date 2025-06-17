using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class AkBankManager.DecodableBankHandle : AkBankManager.BankHandle
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly bool decodeBank;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly string decodedBankPath;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly bool saveDecodedBank;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkBankManager.DecodableBankHandle(string name, bool save)
    {
        string val_17;
        string val_18;
        this.decodeBank = true;
        this = new System.Object();
        mem[1152921519389010960] = name;
        this.saveDecodedBank = save;
        string val_3 = name + ".bnk";
        val_17 = AkSoundEngineController.GetDecodedBankFullPath();
        string val_6 = System.IO.Path.Combine(path1:  val_17, path2:  AkSoundEngine.GetCurrentLanguage());
        this.decodedBankPath = val_6;
        string val_7 = System.IO.Path.Combine(path1:  val_6, path2:  val_3);
        val_18 = val_7;
        if((System.IO.File.Exists(path:  val_7)) != true)
        {
                this.decodedBankPath = val_17;
            string val_9 = System.IO.Path.Combine(path1:  val_17, path2:  val_3);
            val_18 = val_9;
            if((System.IO.File.Exists(path:  val_9)) == false)
        {
                return;
        }
        
        }
        
        System.DateTime val_11 = System.IO.File.GetLastWriteTime(path:  val_18);
        val_17 = val_11.dateData;
        System.DateTime val_14 = System.IO.File.GetLastWriteTime(path:  System.IO.Path.Combine(path1:  AkBasePathGetter.GetSoundbankBasePath(), path2:  val_3));
        this.decodeBank = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_17}, t2:  new System.DateTime() {dateData = val_14.dateData});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override AKRESULT DoLoadBank()
    {
        string val_10;
        var val_11;
        val_10 = this;
        if(this.decodeBank != false)
        {
                return AkSoundEngine.LoadAndDecodeBank(in_pszString:  69738496, in_bSaveDecodedBank:  (this.saveDecodedBank == true) ? 1 : 0, out_bankID: out  1152921519389188504);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.decodedBankPath)) != true)
        {
                val_11 = AkSoundEngine.SetBasePath(in_pszBasePath:  this.decodedBankPath);
            if(val_11 != 1)
        {
                return (AKRESULT)val_11;
        }
        
        }
        
        val_11 = AkSoundEngine.LoadBank(in_pszString:  X21, in_memPoolId:  0, out_bankID: out  1152921519389188504);
        if((System.String.IsNullOrEmpty(value:  this.decodedBankPath)) == true)
        {
                return (AKRESULT)val_11;
        }
        
        val_10 = AkBasePathGetter.GetSoundbankBasePath();
        AKRESULT val_9 = AkSoundEngine.SetBasePath(in_pszBasePath:  val_10);
        return (AKRESULT)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void UnloadBank()
    {
        if(this.decodeBank != false)
        {
                if(this.saveDecodedBank == false)
        {
            goto label_2;
        }
        
        }
        
        this.UnloadBank();
        return;
        label_2:
        AKRESULT val_1 = AkSoundEngine.PrepareBank(in_PreparationType:  1, in_bankID:  1897584384);
    }

}
