using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class FormatNumber
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string ToKMB(decimal num)
    {
        int val_9;
        string val_10;
        val_9 = num.lo;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == true)
        {
            goto label_3;
        }
        
        val_9 = num.flags;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_9, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_10 = "0,,,.###B";
        return (string)num.flags.ToString(format:  val_10 = "0,.#K");
        label_6:
        val_9 = num.flags;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_9, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == true)
        {
            goto label_10;
        }
        
        val_9 = num.flags;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_9, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == false)
        {
            goto label_13;
        }
        
        label_10:
        val_10 = "0,,.##M";
        return (string)num.flags.ToString(format:  val_10);
        label_13:
        val_9 = num.flags;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_9, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == true)
        {
            goto label_17;
        }
        
        val_9 = num.flags;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_9, hi = num.hi, lo = val_9, mid = num.mid}, d2:  new System.Decimal())) == false)
        {
            goto label_20;
        }
        
        label_17:
        return (string)num.flags.ToString(format:  val_10);
        label_20:
        string val_8 = num.flags.ToString();
        return (string)num.flags.ToString(format:  val_10);
    }

}
