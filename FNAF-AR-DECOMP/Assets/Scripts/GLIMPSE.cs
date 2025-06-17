using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.GLIMPSE : IMessage<ProtoData.ATTACK_DATA.Types.GLIMPSE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.GLIMPSE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.GLIMPSE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.GLIMPSE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CooldownFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE cooldown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DistanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE distance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CloakDelayTimeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE cloakDelayTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ExpireTimeFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE expireTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HalfAngleDeadZoneFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE halfAngleDeadZone_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HalfAngleTeleportFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE halfAngleTeleport_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PhaseDurationFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE phaseDuration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RepositionDelayFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE repositionDelay_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.GLIMPSE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Cooldown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Distance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE CloakDelayTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE ExpireTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE HalfAngleDeadZone { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE HalfAngleTeleport { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE PhaseDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE RepositionDelay { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.GLIMPSE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<GLIMPSE>)ATTACK_DATA.Types.GLIMPSE.RepositionDelayFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[6];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.GLIMPSE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.GLIMPSE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.GLIMPSE(ProtoData.ATTACK_DATA.Types.GLIMPSE other)
    {
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.RANGE val_12;
        ATTACK_DATA.Types.RANGE val_13;
        ATTACK_DATA.Types.RANGE val_14;
        ATTACK_DATA.Types.RANGE val_15;
        ATTACK_DATA.Types.RANGE val_16;
        if(other.cooldown_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        this.cooldown_ = other.cooldown_.Clone();
        val_10 = other.distance_;
        this.distance_ = val_10.Clone();
        val_11 = other.cloakDelayTime_;
        this.cloakDelayTime_ = val_11.Clone();
        val_12 = other.expireTime_;
        this.expireTime_ = val_12.Clone();
        val_13 = other.halfAngleDeadZone_;
        this.halfAngleDeadZone_ = val_13.Clone();
        val_14 = other.halfAngleTeleport_;
        this.halfAngleTeleport_ = val_14.Clone();
        val_15 = other.phaseDuration_;
        this.phaseDuration_ = val_15.Clone();
        val_16 = other.repositionDelay_;
        this.repositionDelay_ = val_16.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.GLIMPSE Clone()
    {
        return (GLIMPSE)new ATTACK_DATA.Types.GLIMPSE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Cooldown()
    {
        return (RANGE)this.cooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Cooldown(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.cooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Distance()
    {
        return (RANGE)this.distance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Distance(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.distance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_CloakDelayTime()
    {
        return (RANGE)this.cloakDelayTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CloakDelayTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.cloakDelayTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_ExpireTime()
    {
        return (RANGE)this.expireTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ExpireTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.expireTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_HalfAngleDeadZone()
    {
        return (RANGE)this.halfAngleDeadZone_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HalfAngleDeadZone(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.halfAngleDeadZone_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_HalfAngleTeleport()
    {
        return (RANGE)this.halfAngleTeleport_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HalfAngleTeleport(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.halfAngleTeleport_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_PhaseDuration()
    {
        return (RANGE)this.phaseDuration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PhaseDuration(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.phaseDuration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_RepositionDelay()
    {
        return (RANGE)this.repositionDelay_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RepositionDelay(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.repositionDelay_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        GLIMPSE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.GLIMPSE other)
    {
        var val_9;
        if(other == null)
        {
            goto label_9;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((((((System.Object.Equals(objA:  this.cooldown_, objB:  other.cooldown_)) != false) && ((System.Object.Equals(objA:  this.distance_, objB:  other.distance_)) != false)) && ((System.Object.Equals(objA:  this.cloakDelayTime_, objB:  other.cloakDelayTime_)) != false)) && ((System.Object.Equals(objA:  this.expireTime_, objB:  other.expireTime_)) != false)) && ((System.Object.Equals(objA:  this.halfAngleDeadZone_, objB:  other.halfAngleDeadZone_)) != false)) && ((System.Object.Equals(objA:  this.halfAngleTeleport_, objB:  other.halfAngleTeleport_)) != false)) && ((System.Object.Equals(objA:  this.phaseDuration_, objB:  other.phaseDuration_)) != false))
        {
                if((System.Object.Equals(objA:  this.repositionDelay_, objB:  other.repositionDelay_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_9:
        val_9 = 0;
        return (bool)val_9;
        label_1:
        val_9 = 1;
        return (bool)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.cooldown_ != null)
        {
                val_3 = this.cooldown_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.distance_ != null)
        {
                val_3 = this.distance_ ^ val_3;
        }
        
        if(this.cloakDelayTime_ != null)
        {
                val_3 = this.cloakDelayTime_ ^ val_3;
        }
        
        if(this.expireTime_ != null)
        {
                val_3 = this.expireTime_ ^ val_3;
        }
        
        if(this.halfAngleDeadZone_ != null)
        {
                val_3 = this.halfAngleDeadZone_ ^ val_3;
        }
        
        if(this.halfAngleTeleport_ != null)
        {
                val_3 = this.halfAngleTeleport_ ^ val_3;
        }
        
        if(this.phaseDuration_ != null)
        {
                val_3 = this.phaseDuration_ ^ val_3;
        }
        
        if(this.repositionDelay_ != null)
        {
                val_3 = this.repositionDelay_ ^ val_3;
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
        ATTACK_DATA.Types.RANGE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        ATTACK_DATA.Types.RANGE val_8;
        if(this.cooldown_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.cooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.cooldown_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.distance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.distance_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.distance_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.cloakDelayTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.cloakDelayTime_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.cloakDelayTime_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.expireTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.expireTime_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.expireTime_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.halfAngleDeadZone_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.halfAngleDeadZone_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.halfAngleDeadZone_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.halfAngleTeleport_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.halfAngleTeleport_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.halfAngleTeleport_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.phaseDuration_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_7 = this.phaseDuration_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_7 = this.phaseDuration_;
        }
        
            output.WriteMessage(value:  val_7);
        }
        
        if(this.repositionDelay_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_8 = this.repositionDelay_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_8 = this.repositionDelay_;
        }
        
            output.WriteMessage(value:  val_8);
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
        ATTACK_DATA.Types.RANGE val_17 = this.cooldown_;
        if(val_17 != null)
        {
                val_17 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_17 = this.cooldown_)) + 1;
        }
        
        if(this.distance_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.distance_))) + 1;
        }
        
        if(this.cloakDelayTime_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cloakDelayTime_))) + 1;
        }
        
        if(this.expireTime_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.expireTime_))) + 1;
        }
        
        if(this.halfAngleDeadZone_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.halfAngleDeadZone_))) + 1;
        }
        
        if(this.halfAngleTeleport_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.halfAngleTeleport_))) + 1;
        }
        
        if(this.phaseDuration_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.phaseDuration_))) + 1;
        }
        
        if(this.repositionDelay_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.repositionDelay_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_17;
        }
        
        val_17 = this._unknownFields.CalculateSize() + val_17;
        return (int)val_17;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.GLIMPSE other)
    {
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.RANGE val_12;
        ATTACK_DATA.Types.RANGE val_13;
        ATTACK_DATA.Types.RANGE val_14;
        ATTACK_DATA.Types.RANGE val_15;
        ATTACK_DATA.Types.RANGE val_16;
        ATTACK_DATA.Types.RANGE val_17;
        ATTACK_DATA.Types.RANGE val_18;
        ATTACK_DATA.Types.RANGE val_19;
        ATTACK_DATA.Types.RANGE val_20;
        ATTACK_DATA.Types.RANGE val_21;
        ATTACK_DATA.Types.RANGE val_22;
        ATTACK_DATA.Types.RANGE val_23;
        ATTACK_DATA.Types.RANGE val_24;
        ATTACK_DATA.Types.RANGE val_25;
        if(other == null)
        {
                return;
        }
        
        val_11 = other.cooldown_;
        if(val_11 != null)
        {
                val_12 = this.cooldown_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_12 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.cooldown_ = val_12;
            val_11 = other.cooldown_;
        }
        
            val_1.MergeFrom(other:  val_11);
        }
        
        val_13 = other.distance_;
        if(val_13 != null)
        {
                val_14 = this.distance_;
            if(val_14 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_14 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.distance_ = val_14;
            val_13 = other.distance_;
        }
        
            val_2.MergeFrom(other:  val_13);
        }
        
        val_15 = other.cloakDelayTime_;
        if(val_15 != null)
        {
                val_16 = this.cloakDelayTime_;
            if(val_16 == null)
        {
                ATTACK_DATA.Types.RANGE val_3 = null;
            val_16 = val_3;
            val_3 = new ATTACK_DATA.Types.RANGE();
            this.cloakDelayTime_ = val_16;
            val_15 = other.cloakDelayTime_;
        }
        
            val_3.MergeFrom(other:  val_15);
        }
        
        val_17 = other.expireTime_;
        if(val_17 != null)
        {
                val_18 = this.expireTime_;
            if(val_18 == null)
        {
                ATTACK_DATA.Types.RANGE val_4 = null;
            val_18 = val_4;
            val_4 = new ATTACK_DATA.Types.RANGE();
            this.expireTime_ = val_18;
            val_17 = other.expireTime_;
        }
        
            val_4.MergeFrom(other:  val_17);
        }
        
        val_19 = other.halfAngleDeadZone_;
        if(val_19 != null)
        {
                val_20 = this.halfAngleDeadZone_;
            if(val_20 == null)
        {
                ATTACK_DATA.Types.RANGE val_5 = null;
            val_20 = val_5;
            val_5 = new ATTACK_DATA.Types.RANGE();
            this.halfAngleDeadZone_ = val_20;
            val_19 = other.halfAngleDeadZone_;
        }
        
            val_5.MergeFrom(other:  val_19);
        }
        
        val_21 = other.halfAngleTeleport_;
        if(val_21 != null)
        {
                val_22 = this.halfAngleTeleport_;
            if(val_22 == null)
        {
                ATTACK_DATA.Types.RANGE val_6 = null;
            val_22 = val_6;
            val_6 = new ATTACK_DATA.Types.RANGE();
            this.halfAngleTeleport_ = val_22;
            val_21 = other.halfAngleTeleport_;
        }
        
            val_6.MergeFrom(other:  val_21);
        }
        
        val_23 = other.phaseDuration_;
        if(val_23 != null)
        {
                val_24 = this.phaseDuration_;
            if(val_24 == null)
        {
                ATTACK_DATA.Types.RANGE val_7 = null;
            val_24 = val_7;
            val_7 = new ATTACK_DATA.Types.RANGE();
            this.phaseDuration_ = val_24;
            val_23 = other.phaseDuration_;
        }
        
            val_7.MergeFrom(other:  val_23);
        }
        
        val_10 = other.repositionDelay_;
        if(val_10 != null)
        {
                val_25 = this.repositionDelay_;
            if(val_25 == null)
        {
                ATTACK_DATA.Types.RANGE val_8 = null;
            val_25 = val_8;
            val_8 = new ATTACK_DATA.Types.RANGE();
            this.repositionDelay_ = val_25;
            val_10 = other.repositionDelay_;
        }
        
            val_8.MergeFrom(other:  val_10);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_11;
        goto label_37;
        label_41:
        if(23902 > 34)
        {
            goto label_2;
        }
        
        if(23902 > 18)
        {
            goto label_3;
        }
        
        if(23902 == 10)
        {
            goto label_4;
        }
        
        if(23902 != 18)
        {
            goto label_21;
        }
        
        val_11 = this.distance_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_1 = null;
        val_11 = val_1;
        val_1 = new ATTACK_DATA.Types.RANGE();
        this.distance_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_2:
        if(23902 > 50)
        {
            goto label_9;
        }
        
        if(23902 == 42)
        {
            goto label_10;
        }
        
        if(23902 != 50)
        {
            goto label_21;
        }
        
        val_11 = this.halfAngleTeleport_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_11 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.halfAngleTeleport_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_3:
        if(23902 == 26)
        {
            goto label_15;
        }
        
        if(23902 != 34)
        {
            goto label_21;
        }
        
        val_11 = this.expireTime_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_3 = null;
        val_11 = val_3;
        val_3 = new ATTACK_DATA.Types.RANGE();
        this.expireTime_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_9:
        if(23902 == 58)
        {
            goto label_20;
        }
        
        if(23902 != 66)
        {
            goto label_21;
        }
        
        val_11 = this.repositionDelay_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_4 = null;
        val_11 = val_4;
        val_4 = new ATTACK_DATA.Types.RANGE();
        this.repositionDelay_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_21:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_37;
        label_4:
        val_11 = this.cooldown_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_6 = null;
        val_11 = val_6;
        val_6 = new ATTACK_DATA.Types.RANGE();
        this.cooldown_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_10:
        val_11 = this.halfAngleDeadZone_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_7 = null;
        val_11 = val_7;
        val_7 = new ATTACK_DATA.Types.RANGE();
        this.halfAngleDeadZone_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_15:
        val_11 = this.cloakDelayTime_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ATTACK_DATA.Types.RANGE val_8 = null;
        val_11 = val_8;
        val_8 = new ATTACK_DATA.Types.RANGE();
        this.cloakDelayTime_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_20:
        val_11 = this.phaseDuration_;
        if(val_11 == null)
        {
            goto label_35;
        }
        
        label_32:
        if(input != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        input.ReadMessage(builder:  val_11);
        goto label_37;
        label_35:
        this.phaseDuration_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_37:
        if(input.ReadTag() != 0)
        {
            goto label_41;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.GLIMPSE()
    {
        null = null;
        ATTACK_DATA.Types.GLIMPSE.RepositionDelayFieldNumber = new Google.Protobuf.MessageParser<GLIMPSE>(factory:  new System.Func<GLIMPSE>(object:  ATTACK_DATA.Types.GLIMPSE.<>c.<>9, method:  GLIMPSE ATTACK_DATA.Types.GLIMPSE.<>c::<.cctor>b__60_0()));
    }

}
