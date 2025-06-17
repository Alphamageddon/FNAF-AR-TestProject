using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqMinOrdersFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double preconditionReqMinOrders_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqMaxOrdersFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double preconditionReqMaxOrders_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PreconditionReqMinOrders { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PreconditionReqMaxOrders { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ORDERNUMBER>)ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER.PreconditionReqMaxOrdersFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER other)
    {
        if(other != null)
        {
                this.preconditionReqMinOrders_ = other.preconditionReqMinOrders_;
            this.preconditionReqMaxOrders_ = other.preconditionReqMaxOrders_;
        }
        else
        {
                this.preconditionReqMinOrders_ = 7.42422564692724E-317;
            this.preconditionReqMaxOrders_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER Clone()
    {
        return (ORDERNUMBER)new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PreconditionReqMinOrders()
    {
        return (double)this.preconditionReqMinOrders_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqMinOrders(double value)
    {
        this.preconditionReqMinOrders_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PreconditionReqMaxOrders()
    {
        return (double)this.preconditionReqMaxOrders_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqMaxOrders(double value)
    {
        this.preconditionReqMaxOrders_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ORDERNUMBER val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER other)
    {
        var val_3;
        double val_4;
        var val_5;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_4 = this.preconditionReqMinOrders_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.preconditionReqMaxOrders_;
            val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_3 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.preconditionReqMinOrders_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.preconditionReqMaxOrders_ != 0f)
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_3;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields ^ val_3;
        return (int)val_3;
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
        double val_2;
        if(this.preconditionReqMinOrders_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.preconditionReqMinOrders_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.preconditionReqMinOrders_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.preconditionReqMaxOrders_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.preconditionReqMaxOrders_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.preconditionReqMaxOrders_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_5;
        var val_1 = (this.preconditionReqMinOrders_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.preconditionReqMaxOrders_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.preconditionReqMinOrders_ != 0f)
        {
                this.preconditionReqMinOrders_ = other.preconditionReqMinOrders_;
        }
        
        if(other.preconditionReqMaxOrders_ != 0f)
        {
                this.preconditionReqMaxOrders_ = other.preconditionReqMaxOrders_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_3;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_3;
        label_6:
        this.preconditionReqMinOrders_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.preconditionReqMaxOrders_ = input.ReadDouble();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 9)
        {
            goto label_6;
        }
        
        if(val_4 == 17)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER.PreconditionReqMaxOrdersFieldNumber = new Google.Protobuf.MessageParser<ORDERNUMBER>(factory:  new System.Func<ORDERNUMBER>(object:  ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER.<>c.<>9, method:  ORDERNUMBER ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER.<>c::<.cctor>b__30_0()));
    }

}
