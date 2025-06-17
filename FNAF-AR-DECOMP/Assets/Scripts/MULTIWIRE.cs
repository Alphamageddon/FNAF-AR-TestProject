using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE : IMessage<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CountFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE count_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HalfAngleFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE halfAngle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LocateTimeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE locateTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HiddenTimeFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE hiddenTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Count { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE HalfAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE LocateTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE HiddenTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MULTIWIRE>)ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.HiddenTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.HAYWIRE.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE other)
    {
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        ATTACK_DATA.Types.RANGE val_8;
        if(other.count_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.count_ = other.count_.Clone();
        val_6 = other.halfAngle_;
        this.halfAngle_ = val_6.Clone();
        val_7 = other.locateTime_;
        this.locateTime_ = val_7.Clone();
        val_8 = other.hiddenTime_;
        this.hiddenTime_ = val_8.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE Clone()
    {
        return (MULTIWIRE)new ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Count()
    {
        return (RANGE)this.count_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Count(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.count_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_HalfAngle()
    {
        return (RANGE)this.halfAngle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HalfAngle(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.halfAngle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_LocateTime()
    {
        return (RANGE)this.locateTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LocateTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.locateTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_HiddenTime()
    {
        return (RANGE)this.hiddenTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HiddenTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.hiddenTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MULTIWIRE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE other)
    {
        var val_5;
        if(other == null)
        {
            goto label_5;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.Object.Equals(objA:  this.count_, objB:  other.count_)) != false) && ((System.Object.Equals(objA:  this.halfAngle_, objB:  other.halfAngle_)) != false)) && ((System.Object.Equals(objA:  this.locateTime_, objB:  other.locateTime_)) != false))
        {
                if((System.Object.Equals(objA:  this.hiddenTime_, objB:  other.hiddenTime_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_5:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.count_ != null)
        {
                val_3 = this.count_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.halfAngle_ != null)
        {
                val_3 = this.halfAngle_ ^ val_3;
        }
        
        if(this.locateTime_ != null)
        {
                val_3 = this.locateTime_ ^ val_3;
        }
        
        if(this.hiddenTime_ != null)
        {
                val_3 = this.hiddenTime_ ^ val_3;
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
        ATTACK_DATA.Types.RANGE val_1;
        ATTACK_DATA.Types.RANGE val_2;
        ATTACK_DATA.Types.RANGE val_3;
        ATTACK_DATA.Types.RANGE val_4;
        if(this.count_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.count_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.count_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.halfAngle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.halfAngle_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.halfAngle_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.locateTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.locateTime_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.locateTime_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.hiddenTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.hiddenTime_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.hiddenTime_;
        }
        
            output.WriteMessage(value:  val_4);
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
        ATTACK_DATA.Types.RANGE val_9 = this.count_;
        if(val_9 != null)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_9 = this.count_)) + 1;
        }
        
        if(this.halfAngle_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.halfAngle_))) + 1;
        }
        
        if(this.locateTime_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.locateTime_))) + 1;
        }
        
        if(this.hiddenTime_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.hiddenTime_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE other)
    {
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        ATTACK_DATA.Types.RANGE val_8;
        ATTACK_DATA.Types.RANGE val_9;
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.RANGE val_12;
        ATTACK_DATA.Types.RANGE val_13;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.count_;
        if(val_7 != null)
        {
                val_8 = this.count_;
            if(val_8 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_8 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.count_ = val_8;
            val_7 = other.count_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.halfAngle_;
        if(val_9 != null)
        {
                val_10 = this.halfAngle_;
            if(val_10 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_10 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.halfAngle_ = val_10;
            val_9 = other.halfAngle_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        val_11 = other.locateTime_;
        if(val_11 != null)
        {
                val_12 = this.locateTime_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.RANGE val_3 = null;
            val_12 = val_3;
            val_3 = new ATTACK_DATA.Types.RANGE();
            this.locateTime_ = val_12;
            val_11 = other.locateTime_;
        }
        
            val_3.MergeFrom(other:  val_11);
        }
        
        val_6 = other.hiddenTime_;
        if(val_6 != null)
        {
                val_13 = this.hiddenTime_;
            if(val_13 == null)
        {
                ATTACK_DATA.Types.RANGE val_4 = null;
            val_13 = val_4;
            val_4 = new ATTACK_DATA.Types.RANGE();
            this.hiddenTime_ = val_13;
            val_6 = other.hiddenTime_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_7;
        goto label_19;
        label_23:
        if(31989 > 18)
        {
            goto label_2;
        }
        
        if(31989 == 10)
        {
            goto label_3;
        }
        
        if(31989 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.halfAngle_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.RANGE val_1 = null;
        val_7 = val_1;
        val_1 = new ATTACK_DATA.Types.RANGE();
        this.halfAngle_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_2:
        if(31989 == 26)
        {
            goto label_8;
        }
        
        if(31989 != 34)
        {
            goto label_9;
        }
        
        val_7 = this.hiddenTime_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_7 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.hiddenTime_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_19;
        label_3:
        val_7 = this.count_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.RANGE val_4 = null;
        val_7 = val_4;
        val_4 = new ATTACK_DATA.Types.RANGE();
        this.count_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_8:
        val_7 = this.locateTime_;
        if(val_7 == null)
        {
            goto label_17;
        }
        
        label_14:
        if(input != null)
        {
            goto label_20;
        }
        
        label_21:
        label_20:
        input.ReadMessage(builder:  val_7);
        goto label_19;
        label_17:
        this.locateTime_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        if(input.ReadTag() != 0)
        {
            goto label_23;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE()
    {
        null = null;
        ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.HiddenTimeFieldNumber = new Google.Protobuf.MessageParser<MULTIWIRE>(factory:  new System.Func<MULTIWIRE>(object:  ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.<>c.<>9, method:  MULTIWIRE ATTACK_DATA.Types.HAYWIRE.Types.MULTIWIRE.<>c::<.cctor>b__40_0()));
    }

}
