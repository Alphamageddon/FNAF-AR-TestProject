using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
internal class DeflateManager.Config
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int GoodLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int MaxLazy;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int NiceLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal int MaxChainLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Ionic.Zlib.DeflateFlavor Flavor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Ionic.Zlib.DeflateManager.Config[] Table;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DeflateManager.Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, Ionic.Zlib.DeflateFlavor flavor)
    {
        this.GoodLength = goodLength;
        this.MaxLazy = maxLazy;
        this.NiceLength = niceLength;
        this.MaxChainLength = maxChainLength;
        this.Flavor = flavor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Ionic.Zlib.DeflateManager.Config Lookup(Ionic.Zlib.CompressionLevel level)
    {
        null = null;
        DeflateManager.Config[] val_1 = DeflateManager.Config.Table + (((long)(int)(level)) << 3);
        return (DeflateManager.Config)(DeflateManager.Config.Table + ((long)(int)(level)) << 3) + 32;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DeflateManager.Config()
    {
        DeflateManager.Config[] val_1 = new DeflateManager.Config[10];
        DeflateManager.Config val_2 = new DeflateManager.Config();
        .GoodLength = 0;
        .MaxLazy = 0;
        .NiceLength = 0;
        .MaxChainLength = 0;
        .Flavor = 0;
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
        .Flavor = 1;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 17179869192;
        .MaxChainLength = 4;
        val_1[1] = new DeflateManager.Config();
        .Flavor = 1;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 34359738384;
        .MaxChainLength = 8;
        val_1[2] = new DeflateManager.Config();
        .Flavor = 1;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 137438953504;
        .MaxChainLength = 32;
        val_1[3] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 68719476752;
        .MaxChainLength = 16;
        val_1[4] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 137438953504;
        .MaxChainLength = 32;
        val_1[5] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 549755814016;
        .MaxChainLength = 128;
        val_1[6] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 1099511627904;
        .MaxChainLength = 256;
        val_1[7] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 4398046511362;
        .MaxChainLength = 1024;
        val_1[8] = new DeflateManager.Config();
        .Flavor = 2;
        .GoodLength = ;
        .MaxLazy = ;
        .NiceLength = 17592186044674;
        .MaxChainLength = 4096;
        val_1[9] = new DeflateManager.Config();
        DeflateManager.Config.Table = val_1;
    }

}
