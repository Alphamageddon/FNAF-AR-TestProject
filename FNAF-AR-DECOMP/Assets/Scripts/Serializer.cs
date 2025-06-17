using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GA_MiniJSON.Serializer
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Text.StringBuilder builder;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GA_MiniJSON.Serializer()
    {
        this.builder = new System.Text.StringBuilder();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string Serialize(object obj)
    {
        object val_2;
        GA_MiniJSON.Serializer val_1 = new GA_MiniJSON.Serializer();
        if(val_1 != null)
        {
                val_2 = obj;
            val_1.SerializeValue(value:  val_2);
        }
        else
        {
                val_2 = obj;
            val_1.SerializeValue(value:  val_2);
        }
        
        if((GA_MiniJSON.Serializer)[1152921526129053296].builder == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SerializeValue(object value)
    {
        System.Text.StringBuilder val_4;
        string val_5;
        if(value == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        if(value == null)
        {
            goto label_4;
        }
        
        this.SerializeArray(anArray:  value);
        return;
        label_1:
        val_4 = this.builder;
        val_5 = "null";
        goto label_6;
        label_2:
        label_10:
        this.SerializeString(str:  value);
        return;
        label_3:
        val_4 = this.builder;
        val_5 = (null == 0) ? "false" : "true";
        label_6:
        System.Text.StringBuilder val_2 = val_4.Append(value:  val_5);
        return;
        label_4:
        if(value != null)
        {
                this.SerializeObject(obj:  value);
            return;
        }
        
        if(null != null)
        {
                this.SerializeOther(value:  value);
            return;
        }
        
        string val_3 = 0.CreateString(c:  '뀀', count:  1);
        goto label_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SerializeObject(System.Collections.IDictionary obj)
    {
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        var val_16 = 0;
        val_16 = val_16 + 1;
        var val_17 = 0;
        val_17 = val_17 + 1;
        System.Collections.IEnumerator val_5 = obj.Keys.GetEnumerator();
        label_32:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_15 = public System.Object System.Collections.IEnumerator::get_Current();
        object val_9 = val_5.Current;
        if((1 & 1) == 0)
        {
                val_15 = 44;
            System.Text.StringBuilder val_10 = this.builder.Append(value:  ',');
        }
        
        this.SerializeString(str:  val_9);
        val_16 = 0;
        System.Text.StringBuilder val_11 = this.builder.Append(value:  ':');
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_16 = 0;
        this.SerializeValue(value:  obj.Item[val_9]);
        goto label_32;
        label_17:
        val_18 = 0;
        val_19 = 122;
        if(val_5 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_5.Dispose();
        }
        
        System.Text.StringBuilder val_15 = this.builder.Append(value:  '}');
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SerializeArray(System.Collections.IList anArray)
    {
        var val_11;
        var val_12;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '[');
        var val_11 = 0;
        val_11 = val_11 + 1;
        System.Collections.IEnumerator val_3 = anArray.GetEnumerator();
        label_20:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        if((1 & 1) == 0)
        {
                System.Text.StringBuilder val_8 = this.builder.Append(value:  ',');
        }
        
        this.SerializeValue(value:  val_3.Current);
        goto label_20;
        label_12:
        val_11 = 0;
        val_12 = 85;
        if(val_3 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_3.Dispose();
        }
        
        System.Text.StringBuilder val_10 = this.builder.Append(value:  ']');
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SerializeString(string str)
    {
        System.Text.StringBuilder val_10;
        var val_11;
        string val_12;
        var val_13;
        val_10 = this.builder;
        System.Text.StringBuilder val_1 = val_10.Append(value:  '"');
        val_11 = 0;
        goto label_27;
        label_30:
        char val_10 = str.ToCharArray()[0];
        str.ToCharArray()[0] = val_10 - 8;
        if(str.ToCharArray()[0] > '')
        {
            goto label_5;
        }
        
        var val_11 = 52949788 + ((val_2[0x0][0] - 8)) << 2;
        val_11 = val_11 + 52949788;
        goto (52949788 + ((val_2[0x0][0] - 8)) << 2 + 52949788);
        label_5:
        if(val_10 == '\')
        {
            goto label_8;
        }
        
        if(val_10 != '"')
        {
            goto label_9;
        }
        
        val_10 = this.builder;
        val_12 = "\\\"";
        goto label_21;
        label_9:
        int val_3 = System.Convert.ToInt32(value:  val_10);
        if((val_3 - 32) <= 94)
        {
            goto label_15;
        }
        
        System.Text.StringBuilder val_5 = this.builder.Append(value:  "\\u");
        val_10 = this.builder;
        val_13 = val_3.ToString(format:  "x4");
        goto label_17;
        label_8:
        val_10 = this.builder;
        val_12 = "\\\\";
        label_21:
        label_17:
        System.Text.StringBuilder val_7 = val_10.Append(value:  val_12);
        label_28:
        val_11 = 1;
        goto label_27;
        label_15:
        System.Text.StringBuilder val_8 = this.builder.Append(value:  val_10);
        goto label_28;
        label_27:
        if(val_11 < val_2.Length)
        {
            goto label_30;
        }
        
        System.Text.StringBuilder val_9 = this.builder.Append(value:  '"');
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SerializeOther(object value)
    {
        object val_6;
        System.Text.StringBuilder val_7;
        val_6 = value;
        if(val_6 == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if((((((((null == null) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null))
        {
            goto label_10;
        }
        
        if(null != null)
        {
                if(null != null)
        {
            goto label_12;
        }
        
        }
        
        val_7 = this.builder;
        string val_2 = System.Convert.ToDouble(value:  val_6).ToString(format:  "R");
        goto label_15;
        label_1:
        label_12:
        this.SerializeString(str:  val_6);
        return;
        label_2:
        val_7 = this.builder;
        label_15:
        val_6 = null.ToString(format:  "R");
        System.Text.StringBuilder val_4 = val_7.Append(value:  val_6);
        return;
        label_10:
        System.Text.StringBuilder val_5 = this.builder.Append(value:  val_6);
    }

}
