using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SimpleJsonInstance.PlayFabSimpleJsonCuztomization : PocoJsonSerializerStrategy
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override object DeserializeObject(object value, System.Type type)
    {
        long val_5;
        object val_21;
        var val_22;
        var val_23;
        var val_24;
        val_21 = value;
        if(val_21 == null)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        if(null != null)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        if((System.Type.op_Inequality(left:  System.Nullable.GetUnderlyingType(nullableType:  type), right:  0)) != false)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        if(((PlayFab.WsaReflectionExtensions.GetTypeInfo(type:  type)) & 1) != 0)
        {
                if(null != null)
        {
                val_21 = 0;
        }
        
            object val_6 = System.Enum.Parse(enumType:  type, value:  val_21, ignoreCase:  true);
            return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_15;
        }
        
        val_22 = null;
        val_22 = null;
        if((System.DateTime.TryParseExact(s:  val_21, formats:  PlayFab.Internal.PlayFabUtil._defaultDateTimeFormats, provider:  System.Globalization.CultureInfo.InvariantCulture, style:  PlayFab.Internal.PlayFabUtil.DateTimeStyles, result: out  new System.DateTime())) == false)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        val_23 = null;
        val_5 = 0;
        goto label_23;
        label_15:
        if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_26;
        }
        
        val_24 = null;
        val_24 = null;
        if((System.DateTimeOffset.TryParseExact(input:  val_21, formats:  PlayFab.Internal.PlayFabUtil._defaultDateTimeFormats, formatProvider:  System.Globalization.CultureInfo.InvariantCulture, styles:  PlayFab.Internal.PlayFabUtil.DateTimeStyles, result: out  new System.DateTimeOffset() {m_dateTime = new System.DateTime()})) == false)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        val_23 = null;
        val_5 = 0;
        label_23:
        return (object)this.DeserializeObject(value:  val_21, type:  type);
        label_26:
        if((System.Type.op_Equality(left:  type, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        if((System.Double.TryParse(s:  val_21, result: out  double val_17 = 1.28823578942162E-231)) == false)
        {
                return (object)this.DeserializeObject(value:  val_21, type:  type);
        }
        
        System.TimeSpan val_19 = System.TimeSpan.FromSeconds(value:  0);
        val_5 = val_19._ticks;
        return (object)this.DeserializeObject(value:  val_21, type:  type);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override bool TrySerializeKnownTypes(object input, out object output)
    {
        var val_9;
        var val_10;
        var val_11;
        if(((PlayFab.WsaReflectionExtensions.GetTypeInfo(type:  input.GetType())) & 1) == 0)
        {
            goto label_3;
        }
        
        label_24:
        output = input;
        val_9 = 1;
        return (bool)this.TrySerializeKnownTypes(input:  input, output: out  object val_3 = output);
        label_3:
        if(input == null)
        {
            goto label_6;
        }
        
        if(null == null)
        {
            goto label_7;
        }
        
        if(null == null)
        {
            goto label_8;
        }
        
        if(null == null)
        {
            goto label_9;
        }
        
        label_6:
        val_9 = this;
        return (bool)this.TrySerializeKnownTypes(input:  input, output: out  val_3);
        label_7:
        val_10 = null;
        val_10 = null;
        System.Globalization.CultureInfo val_6 = System.Globalization.CultureInfo.InvariantCulture;
        goto label_24;
        label_8:
        val_11 = null;
        val_11 = null;
        System.Globalization.CultureInfo val_7 = System.Globalization.CultureInfo.InvariantCulture;
        goto label_24;
        label_9:
        double val_8 = null.TotalSeconds;
        goto label_24;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SimpleJsonInstance.PlayFabSimpleJsonCuztomization()
    {
    
    }

}
