using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqStartDateTimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.WellKnownTypes.Timestamp preconditionReqStartDateTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqEndDateTimeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.WellKnownTypes.Timestamp preconditionReqEndDateTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp PreconditionReqStartDateTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp PreconditionReqEndDateTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DATETIMERANGE>)ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE.PreconditionReqEndDateTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE other)
    {
        Google.Protobuf.WellKnownTypes.Timestamp val_4;
        if(other.preconditionReqStartDateTime_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.preconditionReqStartDateTime_ = other.preconditionReqStartDateTime_.Clone();
        val_4 = other.preconditionReqEndDateTime_;
        this.preconditionReqEndDateTime_ = val_4.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE Clone()
    {
        return (DATETIMERANGE)new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp get_PreconditionReqStartDateTime()
    {
        return (Google.Protobuf.WellKnownTypes.Timestamp)this.preconditionReqStartDateTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqStartDateTime(Google.Protobuf.WellKnownTypes.Timestamp value)
    {
        this.preconditionReqStartDateTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp get_PreconditionReqEndDateTime()
    {
        return (Google.Protobuf.WellKnownTypes.Timestamp)this.preconditionReqEndDateTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqEndDateTime(Google.Protobuf.WellKnownTypes.Timestamp value)
    {
        this.preconditionReqEndDateTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DATETIMERANGE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE other)
    {
        var val_3;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.preconditionReqStartDateTime_, objB:  other.preconditionReqStartDateTime_)) != false)
        {
                if((System.Object.Equals(objA:  this.preconditionReqEndDateTime_, objB:  other.preconditionReqEndDateTime_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_1:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.preconditionReqStartDateTime_ != null)
        {
                val_3 = this.preconditionReqStartDateTime_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.preconditionReqEndDateTime_ != null)
        {
                val_3 = this.preconditionReqEndDateTime_ ^ val_3;
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
        Google.Protobuf.WellKnownTypes.Timestamp val_1;
        Google.Protobuf.WellKnownTypes.Timestamp val_2;
        if(this.preconditionReqStartDateTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.preconditionReqStartDateTime_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.preconditionReqStartDateTime_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.preconditionReqEndDateTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.preconditionReqEndDateTime_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.preconditionReqEndDateTime_;
        }
        
            output.WriteMessage(value:  val_2);
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
        Google.Protobuf.WellKnownTypes.Timestamp val_5 = this.preconditionReqStartDateTime_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.preconditionReqStartDateTime_)) + 1;
        }
        
        if(this.preconditionReqEndDateTime_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.preconditionReqEndDateTime_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE other)
    {
        Google.Protobuf.WellKnownTypes.Timestamp val_4;
        Google.Protobuf.WellKnownTypes.Timestamp val_5;
        Google.Protobuf.WellKnownTypes.Timestamp val_6;
        Google.Protobuf.WellKnownTypes.Timestamp val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.preconditionReqStartDateTime_;
        if(val_5 != null)
        {
                val_6 = this.preconditionReqStartDateTime_;
            if(val_6 == null)
        {
                Google.Protobuf.WellKnownTypes.Timestamp val_1 = null;
            val_6 = val_1;
            val_1 = new Google.Protobuf.WellKnownTypes.Timestamp();
            this.preconditionReqStartDateTime_ = val_6;
            val_5 = other.preconditionReqStartDateTime_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.preconditionReqEndDateTime_;
        if(val_4 != null)
        {
                val_7 = this.preconditionReqEndDateTime_;
            if(val_7 == null)
        {
                Google.Protobuf.WellKnownTypes.Timestamp val_2 = null;
            val_7 = val_2;
            val_2 = new Google.Protobuf.WellKnownTypes.Timestamp();
            this.preconditionReqEndDateTime_ = val_7;
            val_4 = other.preconditionReqEndDateTime_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        Google.Protobuf.WellKnownTypes.Timestamp val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.preconditionReqStartDateTime_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        Google.Protobuf.WellKnownTypes.Timestamp val_2 = null;
        val_5 = val_2;
        val_2 = new Google.Protobuf.WellKnownTypes.Timestamp();
        this.preconditionReqStartDateTime_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.preconditionReqEndDateTime_;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(input != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        input.ReadMessage(builder:  val_5);
        goto label_8;
        label_6:
        this.preconditionReqEndDateTime_ = new Google.Protobuf.WellKnownTypes.Timestamp();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_8:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_12;
        }
        
        if(val_4 == 18)
        {
            goto label_13;
        }
        
        if(val_4 != 0)
        {
            goto label_14;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE.PreconditionReqEndDateTimeFieldNumber = new Google.Protobuf.MessageParser<DATETIMERANGE>(factory:  new System.Func<DATETIMERANGE>(object:  ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE.<>c.<>9, method:  DATETIMERANGE ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.DATETIMERANGE.<>c::<.cctor>b__30_0()));
    }

}
