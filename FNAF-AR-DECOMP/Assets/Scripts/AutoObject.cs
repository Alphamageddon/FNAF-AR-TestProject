using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class AkSoundEngine.AutoObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly UnityEngine.GameObject gameObject;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkSoundEngine.AutoObject(UnityEngine.GameObject go)
    {
        string val_5;
        this.gameObject = go;
        if(go != 0)
        {
                val_5 = "AkAutoObject for " + this.gameObject.name;
        }
        else
        {
                val_5 = "AkAutoObject";
        }
        
        AKRESULT val_4 = AkSoundEngine.RegisterGameObj(gameObject:  go, name:  val_5);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        AKRESULT val_1 = AkSoundEngine.UnregisterGameObj(gameObject:  this.gameObject);
        this.Finalize();
        if((1 & 1) != 0)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        this = ???;
    }

}
