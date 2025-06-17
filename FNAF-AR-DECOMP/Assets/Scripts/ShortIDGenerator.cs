using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkUtilities.ShortIDGenerator
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const uint s_prime32 = 16777619;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const uint s_offsetBasis32 = 2166136261;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static byte s_hashSize;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static uint s_mask;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte HashSize { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkUtilities.ShortIDGenerator()
    {
        AkUtilities.ShortIDGenerator.HashSize = 32;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static byte get_HashSize()
    {
        null = null;
        return (byte)AkUtilities.ShortIDGenerator.s_hashSize;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void set_HashSize(byte value)
    {
        null = null;
        AkUtilities.ShortIDGenerator.s_hashSize = value;
        byte val_1 = AkUtilities.ShortIDGenerator.s_hashSize;
        val_1 = val_1 & 31;
        val_1 = 1 << val_1;
        val_1 = val_1 - 1;
        AkUtilities.ShortIDGenerator.s_mask = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static uint Compute(string in_name)
    {
        var val_4;
        var val_5;
        var val_6;
        byte val_8;
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        string val_2 = in_name.ToLower();
        val_4 = 0;
        val_5 = 2166095872;
        val_5 = 33052;
        goto label_3;
        label_6:
        val_4 = 1;
        label_3:
        if(val_4 < val_1.dataItem)
        {
            goto label_6;
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = AkUtilities.ShortIDGenerator.s_hashSize;
        if(val_8 == 32)
        {
                return (uint)(((36342608889142559 ^ System.Text.Encoding.__il2cppRuntimeField_byval_arg) >> (AkUtilities.ShortIDGenerator.s_hashSize & 31)) ^ (AkUtilities.ShortIDGenerator.s_mask & (36342608889142559 ^ System.Text;
        }
        
        val_8 = AkUtilities.ShortIDGenerator.s_hashSize;
        val_8 = val_8 & 31;
        val_8 = (36342608889142559 ^ System.Text.Encoding.__il2cppRuntimeField_byval_arg) >> val_8;
        return (uint)(((36342608889142559 ^ System.Text.Encoding.__il2cppRuntimeField_byval_arg) >> (AkUtilities.ShortIDGenerator.s_hashSize & 31)) ^ (AkUtilities.ShortIDGenerator.s_mask & (36342608889142559 ^ System.Text;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkUtilities.ShortIDGenerator()
    {
    
    }

}
