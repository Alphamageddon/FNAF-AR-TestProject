using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.STATUS : IMessage<ProtoData.PLUSHSUIT_DATA.Types.STATUS>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.STATUS>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.STATUS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.STATUS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LiveStateFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.PLUSHSUIT_DATA.Types.STATUS.Types.LIVESTATE liveState_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AvailableDateFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.WellKnownTypes.Timestamp availableDate_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.STATUS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.STATUS.Types.LIVESTATE LiveState { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp AvailableDate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.STATUS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<STATUS>)PLUSHSUIT_DATA.Types.STATUS.AvailableDateFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.PLUSHSUIT_DATA.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.STATUS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.STATUS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.STATUS(ProtoData.PLUSHSUIT_DATA.Types.STATUS other)
    {
        Google.Protobuf.WellKnownTypes.Timestamp val_3;
        if(other != null)
        {
                this.liveState_ = other.liveState_;
        }
        else
        {
                this.liveState_ = 15026800;
        }
        
        val_3 = other.availableDate_;
        this.availableDate_ = val_3.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.STATUS Clone()
    {
        return (STATUS)new PLUSHSUIT_DATA.Types.STATUS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.STATUS.Types.LIVESTATE get_LiveState()
    {
        return (LIVESTATE)this.liveState_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LiveState(ProtoData.PLUSHSUIT_DATA.Types.STATUS.Types.LIVESTATE value)
    {
        this.liveState_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Google.Protobuf.WellKnownTypes.Timestamp get_AvailableDate()
    {
        return (Google.Protobuf.WellKnownTypes.Timestamp)this.availableDate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AvailableDate(Google.Protobuf.WellKnownTypes.Timestamp value)
    {
        this.availableDate_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        STATUS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.STATUS other)
    {
        var val_2;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(this.liveState_ == other.liveState_)
        {
                if((System.Object.Equals(objA:  this.availableDate_, objB:  other.availableDate_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_3:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.liveState_ != 0)
        {
                val_3 = 0;
            val_4 = this.liveState_.region ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.availableDate_ != null)
        {
                val_4 = this.availableDate_ ^ val_4;
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
        LIVESTATE val_1;
        Google.Protobuf.WellKnownTypes.Timestamp val_2;
        if(this.liveState_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_1 = this.liveState_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_1 = this.liveState_;
        }
        
            output.WriteEnum(value:  val_1);
        }
        
        if(this.availableDate_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.availableDate_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.availableDate_;
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
        LIVESTATE val_5 = this.liveState_;
        if(val_5 != 0)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  val_5 = this.liveState_)) + 1;
        }
        
        if(this.availableDate_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.availableDate_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.STATUS other)
    {
        Google.Protobuf.WellKnownTypes.Timestamp val_3;
        Google.Protobuf.WellKnownTypes.Timestamp val_4;
        if(other == null)
        {
                return;
        }
        
        if(other.liveState_ != 0)
        {
                this.liveState_ = other.liveState_;
        }
        
        val_3 = other.availableDate_;
        if(val_3 != null)
        {
                val_4 = this.availableDate_;
            if(val_4 == null)
        {
                Google.Protobuf.WellKnownTypes.Timestamp val_1 = null;
            val_4 = val_1;
            val_1 = new Google.Protobuf.WellKnownTypes.Timestamp();
            this.availableDate_ = val_4;
            val_3 = other.availableDate_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_7;
        label_13:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_7;
        label_11:
        this.liveState_ = input.ReadEnum();
        goto label_7;
        label_12:
        if(this.availableDate_ == null)
        {
            goto label_5;
        }
        
        label_9:
        input.ReadMessage(builder:  this.availableDate_);
        goto label_7;
        label_5:
        this.availableDate_ = new Google.Protobuf.WellKnownTypes.Timestamp();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_7:
        uint val_4 = input.ReadTag();
        if(val_4 == 8)
        {
            goto label_11;
        }
        
        if(val_4 == 18)
        {
            goto label_12;
        }
        
        if(val_4 != 0)
        {
            goto label_13;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.STATUS()
    {
        null = null;
        PLUSHSUIT_DATA.Types.STATUS.AvailableDateFieldNumber = new Google.Protobuf.MessageParser<STATUS>(factory:  new System.Func<STATUS>(object:  PLUSHSUIT_DATA.Types.STATUS.<>c.<>9, method:  STATUS PLUSHSUIT_DATA.Types.STATUS.<>c::<.cctor>b__31_0()));
    }

}
