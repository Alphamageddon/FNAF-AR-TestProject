using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionActiveAnimatronicFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string preconditionActiveAnimatronic_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionAnimatronicMalfunctioningFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONANIMATRONICMALFUNCTIONING preconditionAnimatronicMalfunctioning_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionLogicalCompletionsFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS preconditionLogicalCompletions_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DateTimeRangeFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE dateTimeRange_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int OrderNumberFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER orderNumber_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TokenNumberFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER tokenNumber_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PreconditionActiveAnimatronic { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONANIMATRONICMALFUNCTIONING PreconditionAnimatronicMalfunctioning { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS PreconditionLogicalCompletions { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE DateTimeRange { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER OrderNumber { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER TokenNumber { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PRECONDITIONREQUIREMENTS>)ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.TokenNumberFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS()
    {
        this.preconditionActiveAnimatronic_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS other)
    {
        PRECONDITIONLOGICALCOMPLETIONS val_6;
        DATETIMERANGE val_7;
        ORDERNUMBER val_8;
        TOKENNUMBER val_9;
        if(other != null)
        {
                this.preconditionActiveAnimatronic_ = other.preconditionActiveAnimatronic_;
            this.preconditionAnimatronicMalfunctioning_ = other.preconditionAnimatronicMalfunctioning_;
        }
        else
        {
                this.preconditionActiveAnimatronic_ = 15026800;
            this.preconditionAnimatronicMalfunctioning_ = 64;
        }
        
        val_6 = other.preconditionLogicalCompletions_;
        this.preconditionLogicalCompletions_ = val_6.Clone();
        val_7 = other.dateTimeRange_;
        this.dateTimeRange_ = val_7.Clone();
        val_8 = other.orderNumber_;
        this.orderNumber_ = val_8.Clone();
        val_9 = other.tokenNumber_;
        this.tokenNumber_ = val_9.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS Clone()
    {
        return (PRECONDITIONREQUIREMENTS)new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PreconditionActiveAnimatronic()
    {
        return (string)this.preconditionActiveAnimatronic_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionActiveAnimatronic(string value)
    {
        this.preconditionActiveAnimatronic_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONANIMATRONICMALFUNCTIONING get_PreconditionAnimatronicMalfunctioning()
    {
        return (PRECONDITIONANIMATRONICMALFUNCTIONING)this.preconditionAnimatronicMalfunctioning_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionAnimatronicMalfunctioning(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONANIMATRONICMALFUNCTIONING value)
    {
        this.preconditionAnimatronicMalfunctioning_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS get_PreconditionLogicalCompletions()
    {
        return (PRECONDITIONLOGICALCOMPLETIONS)this.preconditionLogicalCompletions_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionLogicalCompletions(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS value)
    {
        this.preconditionLogicalCompletions_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE get_DateTimeRange()
    {
        return (DATETIMERANGE)this.dateTimeRange_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DateTimeRange(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE value)
    {
        this.dateTimeRange_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER get_OrderNumber()
    {
        return (ORDERNUMBER)this.orderNumber_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_OrderNumber(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER value)
    {
        this.orderNumber_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER get_TokenNumber()
    {
        return (TOKENNUMBER)this.tokenNumber_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TokenNumber(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER value)
    {
        this.tokenNumber_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PRECONDITIONREQUIREMENTS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS other)
    {
        var val_6;
        if(other == null)
        {
            goto label_7;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((((System.String.op_Inequality(a:  this.preconditionActiveAnimatronic_, b:  other.preconditionActiveAnimatronic_)) != true) && (this.preconditionAnimatronicMalfunctioning_ == other.preconditionAnimatronicMalfunctioning_)) && ((System.Object.Equals(objA:  this.preconditionLogicalCompletions_, objB:  other.preconditionLogicalCompletions_)) != false)) && ((System.Object.Equals(objA:  this.dateTimeRange_, objB:  other.dateTimeRange_)) != false)) && ((System.Object.Equals(objA:  this.orderNumber_, objB:  other.orderNumber_)) != false))
        {
                if((System.Object.Equals(objA:  this.tokenNumber_, objB:  other.tokenNumber_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_7:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        val_3 = 0;
        if(this.preconditionActiveAnimatronic_.Length != 0)
        {
                val_4 = this.preconditionActiveAnimatronic_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.preconditionAnimatronicMalfunctioning_ != 0)
        {
                val_3 = 0;
            val_4 = this.preconditionAnimatronicMalfunctioning_.region ^ val_4;
        }
        
        if(this.preconditionLogicalCompletions_ != null)
        {
                val_4 = this.preconditionLogicalCompletions_ ^ val_4;
        }
        
        if(this.dateTimeRange_ != null)
        {
                val_4 = this.dateTimeRange_ ^ val_4;
        }
        
        if(this.orderNumber_ != null)
        {
                val_4 = this.orderNumber_ ^ val_4;
        }
        
        if(this.tokenNumber_ != null)
        {
                val_4 = this.tokenNumber_ ^ val_4;
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
        string val_2;
        PRECONDITIONANIMATRONICMALFUNCTIONING val_3;
        PRECONDITIONLOGICALCOMPLETIONS val_4;
        DATETIMERANGE val_5;
        ORDERNUMBER val_6;
        TOKENNUMBER val_7;
        if(this.preconditionActiveAnimatronic_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.preconditionActiveAnimatronic_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.preconditionActiveAnimatronic_;
        }
        
            output.WriteString(value:  val_2);
        }
        
        if(this.preconditionAnimatronicMalfunctioning_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_3 = this.preconditionAnimatronicMalfunctioning_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_3 = this.preconditionAnimatronicMalfunctioning_;
        }
        
            output.WriteEnum(value:  val_3);
        }
        
        if(this.preconditionLogicalCompletions_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.preconditionLogicalCompletions_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.preconditionLogicalCompletions_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.dateTimeRange_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_5 = this.dateTimeRange_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_5 = this.dateTimeRange_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.orderNumber_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_6 = this.orderNumber_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_6 = this.orderNumber_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.tokenNumber_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_7 = this.tokenNumber_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_7 = this.tokenNumber_;
        }
        
            output.WriteMessage(value:  val_7);
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
        var val_14;
        if(this.preconditionActiveAnimatronic_.Length != 0)
        {
                val_14 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.preconditionActiveAnimatronic_)) + 1;
        }
        else
        {
                val_14 = 0;
        }
        
        if(this.preconditionAnimatronicMalfunctioning_ != 0)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  this.preconditionAnimatronicMalfunctioning_))) + 1;
        }
        
        if(this.preconditionLogicalCompletions_ != null)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.preconditionLogicalCompletions_))) + 1;
        }
        
        if(this.dateTimeRange_ != null)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.dateTimeRange_))) + 1;
        }
        
        if(this.orderNumber_ != null)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.orderNumber_))) + 1;
        }
        
        if(this.tokenNumber_ != null)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.tokenNumber_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_14;
        }
        
        val_14 = this._unknownFields.CalculateSize() + val_14;
        return (int)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS other)
    {
        TOKENNUMBER val_7;
        PRECONDITIONLOGICALCOMPLETIONS val_8;
        PRECONDITIONLOGICALCOMPLETIONS val_9;
        DATETIMERANGE val_10;
        DATETIMERANGE val_11;
        ORDERNUMBER val_12;
        ORDERNUMBER val_13;
        TOKENNUMBER val_14;
        if(other == null)
        {
                return;
        }
        
        if(other.preconditionActiveAnimatronic_.Length != 0)
        {
                this.PreconditionActiveAnimatronic = other.preconditionActiveAnimatronic_;
        }
        
        if(other.preconditionAnimatronicMalfunctioning_ != 0)
        {
                this.preconditionAnimatronicMalfunctioning_ = other.preconditionAnimatronicMalfunctioning_;
        }
        
        val_8 = other.preconditionLogicalCompletions_;
        if(val_8 != null)
        {
                val_9 = this.preconditionLogicalCompletions_;
            if(val_9 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS val_2 = null;
            val_9 = val_2;
            val_2 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS();
            this.preconditionLogicalCompletions_ = val_9;
            val_8 = other.preconditionLogicalCompletions_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        val_10 = other.dateTimeRange_;
        if(val_10 != null)
        {
                val_11 = this.dateTimeRange_;
            if(val_11 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE val_3 = null;
            val_11 = val_3;
            val_3 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE();
            this.dateTimeRange_ = val_11;
            val_10 = other.dateTimeRange_;
        }
        
            val_3.MergeFrom(other:  val_10);
        }
        
        val_12 = other.orderNumber_;
        if(val_12 != null)
        {
                val_13 = this.orderNumber_;
            if(val_13 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER val_4 = null;
            val_13 = val_4;
            val_4 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER();
            this.orderNumber_ = val_13;
            val_12 = other.orderNumber_;
        }
        
            val_4.MergeFrom(other:  val_12);
        }
        
        val_7 = other.tokenNumber_;
        if(val_7 != null)
        {
                val_14 = this.tokenNumber_;
            if(val_14 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER val_5 = null;
            val_14 = val_5;
            val_5 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER();
            this.tokenNumber_ = val_14;
            val_7 = other.tokenNumber_;
        }
        
            val_5.MergeFrom(other:  val_7);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        PRECONDITIONLOGICALCOMPLETIONS val_9;
        goto label_25;
        label_29:
        if(35477 > 26)
        {
            goto label_2;
        }
        
        if(35477 == 10)
        {
            goto label_3;
        }
        
        if(35477 == 16)
        {
            goto label_4;
        }
        
        if(35477 != 26)
        {
            goto label_11;
        }
        
        val_9 = this.preconditionLogicalCompletions_;
        if(val_9 != null)
        {
            goto label_18;
        }
        
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS val_1 = null;
        val_9 = val_1;
        val_1 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS();
        this.preconditionLogicalCompletions_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_2:
        if(35477 == 34)
        {
            goto label_9;
        }
        
        if(35477 == 42)
        {
            goto label_10;
        }
        
        if(35477 != 50)
        {
            goto label_11;
        }
        
        val_9 = this.tokenNumber_;
        if(val_9 != null)
        {
            goto label_18;
        }
        
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER val_2 = null;
        val_9 = val_2;
        val_2 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.TOKENNUMBER();
        this.tokenNumber_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_11:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_25;
        label_4:
        this.preconditionAnimatronicMalfunctioning_ = input.ReadEnum();
        goto label_25;
        label_10:
        val_9 = this.orderNumber_;
        if(val_9 != null)
        {
            goto label_18;
        }
        
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER val_5 = null;
        val_9 = val_5;
        val_5 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.ORDERNUMBER();
        this.orderNumber_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_3:
        this.PreconditionActiveAnimatronic = input.ReadString();
        goto label_25;
        label_9:
        val_9 = this.dateTimeRange_;
        if(val_9 == null)
        {
            goto label_23;
        }
        
        label_18:
        if(input != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        input.ReadMessage(builder:  val_9);
        goto label_25;
        label_23:
        this.dateTimeRange_ = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE();
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_25:
        if(input.ReadTag() != 0)
        {
            goto label_29;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS()
    {
        if(((97 & 2) != 0) && (1398166618 == 0))
        {
                35480 = null;
        }
        
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.TokenNumberFieldNumber = new Google.Protobuf.MessageParser<PRECONDITIONREQUIREMENTS>(factory:  new System.Func<PRECONDITIONREQUIREMENTS>(object:  ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.<>c.<>9, method:  PRECONDITIONREQUIREMENTS ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.<>c::<.cctor>b__51_0()));
    }

}
