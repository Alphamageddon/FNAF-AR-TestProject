using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STORE_DATA.Types.ENTRY.Types.COST : IMessage<ProtoData.STORE_DATA.Types.ENTRY.Types.COST>, IMessage, IEquatable<ProtoData.STORE_DATA.Types.ENTRY.Types.COST>, IDeepCloneable<ProtoData.STORE_DATA.Types.ENTRY.Types.COST>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.COST> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HardCurrencyFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double hardCurrency_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SoftCurrencyFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double softCurrency_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DiscountConditionFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string discountCondition_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.COST> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double HardCurrency { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SoftCurrency { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string DiscountCondition { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.COST> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<COST>)STORE_DATA.Types.ENTRY.Types.COST.DiscountConditionFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STORE_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STORE_DATA.Types.ENTRY.Types.COST.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.COST()
    {
        this.discountCondition_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.COST(ProtoData.STORE_DATA.Types.ENTRY.Types.COST other)
    {
        if(other != null)
        {
                this.hardCurrency_ = other.hardCurrency_;
            this.softCurrency_ = other.softCurrency_;
            this.discountCondition_ = other.discountCondition_;
        }
        else
        {
                this.hardCurrency_ = 7.42422564692724E-317;
            this.softCurrency_ = 3.16202013338398E-322;
            this.discountCondition_ = 69077560;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STORE_DATA.Types.ENTRY.Types.COST Clone()
    {
        return (COST)new STORE_DATA.Types.ENTRY.Types.COST(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_HardCurrency()
    {
        return (double)this.hardCurrency_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HardCurrency(double value)
    {
        this.hardCurrency_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SoftCurrency()
    {
        return (double)this.softCurrency_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SoftCurrency(double value)
    {
        this.softCurrency_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_DiscountCondition()
    {
        return (string)this.discountCondition_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DiscountCondition(string value)
    {
        this.discountCondition_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        COST val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STORE_DATA.Types.ENTRY.Types.COST other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.hardCurrency_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.softCurrency_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                if((System.String.op_Inequality(a:  this.discountCondition_, b:  other.discountCondition_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_10:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.hardCurrency_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.softCurrency_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        val_5 = 0;
        if(this.discountCondition_.Length != 0)
        {
                val_4 = this.discountCondition_ ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        double val_2;
        double val_3;
        string val_4;
        if(this.hardCurrency_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.hardCurrency_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.hardCurrency_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.softCurrency_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_3 = this.softCurrency_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_3 = this.softCurrency_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.discountCondition_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.discountCondition_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.discountCondition_;
        }
        
            output.WriteString(value:  val_4);
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
        var val_8;
        var val_1 = (this.hardCurrency_ == 0f) ? 0 : 9;
        if(this.discountCondition_.Length != 0)
        {
                val_8 = (((this.softCurrency_ == 0f) ? (val_1) : (val_1 + 9)) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.discountCondition_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STORE_DATA.Types.ENTRY.Types.COST other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.hardCurrency_ != 0f)
        {
                this.hardCurrency_ = other.hardCurrency_;
        }
        
        if(other.softCurrency_ != 0f)
        {
                this.softCurrency_ = other.softCurrency_;
        }
        
        if(other.discountCondition_.Length != 0)
        {
                this.DiscountCondition = other.discountCondition_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 34)
        {
            goto label_12;
        }
        
        this.DiscountCondition = input.ReadString();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.hardCurrency_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.softCurrency_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STORE_DATA.Types.ENTRY.Types.COST()
    {
        null = null;
        STORE_DATA.Types.ENTRY.Types.COST.DiscountConditionFieldNumber = new Google.Protobuf.MessageParser<COST>(factory:  new System.Func<COST>(object:  STORE_DATA.Types.ENTRY.Types.COST.<>c.<>9, method:  COST STORE_DATA.Types.ENTRY.Types.COST.<>c::<.cctor>b__35_0()));
    }

}
