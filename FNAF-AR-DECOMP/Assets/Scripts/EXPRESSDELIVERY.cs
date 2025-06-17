using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CostFazCoinsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double costFazCoins_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CostFazCoins { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EXPRESSDELIVERY>)CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.CostFazCoinsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[17];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY(ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY other)
    {
        if(other != null)
        {
                this.costFazCoins_ = other.costFazCoins_;
        }
        else
        {
                this.costFazCoins_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY Clone()
    {
        return (EXPRESSDELIVERY)new CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CostFazCoins()
    {
        return (double)this.costFazCoins_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CostFazCoins(double value)
    {
        this.costFazCoins_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EXPRESSDELIVERY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY other)
    {
        var val_2;
        if(other == null)
        {
            goto label_6;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_6:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        if(this.costFazCoins_ == 0f)
        {
                val_2 = 1;
        }
        else
        {
                val_2 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_2;
        }
        
        val_2 = this._unknownFields ^ val_2;
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        double val_1;
        if(this.costFazCoins_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.costFazCoins_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.costFazCoins_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this._unknownFields == null)
        {
                return;
        }
        
        this._unknownFields.WriteTo(output:  output);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CalculateSize()
    {
        var val_3;
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + ((this.costFazCoins_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.costFazCoins_ != 0f)
        {
                this.costFazCoins_ = other.costFazCoins_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_1;
        label_5:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_1;
        label_4:
        this.costFazCoins_ = input.ReadDouble();
        label_1:
        uint val_3 = input.ReadTag();
        if(val_3 == 9)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.CostFazCoinsFieldNumber = new Google.Protobuf.MessageParser<EXPRESSDELIVERY>(factory:  new System.Func<EXPRESSDELIVERY>(object:  CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.<>c.<>9, method:  EXPRESSDELIVERY CONFIG_DATA.Types.ENTRY.Types.EXPRESSDELIVERY.<>c::<.cctor>b__25_0()));
    }

}
