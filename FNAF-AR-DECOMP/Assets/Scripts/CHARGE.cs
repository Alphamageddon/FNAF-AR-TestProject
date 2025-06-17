using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.CHARGE : IMessage<ProtoData.ATTACK_DATA.Types.CHARGE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.CHARGE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.CHARGE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockWindowFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE shockWindow_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NextPhaseFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE nextPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ForceShutdownFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool forceShutdown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UseFeintDistanceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool useFeintDistance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int JumpscareDelayChanceFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE jumpscareDelayChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int JumpscareDelayTimeFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE jumpscareDelayTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SkipDelayedJumpscareChanceFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE skipDelayedJumpscareChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxShockWindowFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxShockWindow_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE ShockWindow { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE NextPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ForceShutdown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseFeintDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE JumpscareDelayChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE JumpscareDelayTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE SkipDelayedJumpscareChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxShockWindow { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CHARGE>)ATTACK_DATA.Types.CHARGE.MaxShockWindowFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[7];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.CHARGE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CHARGE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CHARGE(ProtoData.ATTACK_DATA.Types.CHARGE other)
    {
        ATTACK_DATA.Types.RANGE val_8;
        NEXTPHASE val_9;
        ATTACK_DATA.Types.CHANCE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.CHANCE val_12;
        if(other.seconds_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        this.seconds_ = other.seconds_.Clone();
        val_8 = other.shockWindow_;
        this.shockWindow_ = val_8.Clone();
        val_9 = other.nextPhase_;
        this.nextPhase_ = val_9.Clone();
        this.forceShutdown_ = other.forceShutdown_;
        this.useFeintDistance_ = other.useFeintDistance_;
        val_10 = other.jumpscareDelayChance_;
        this.jumpscareDelayChance_ = val_10.Clone();
        val_11 = other.jumpscareDelayTime_;
        this.jumpscareDelayTime_ = val_11.Clone();
        val_12 = other.skipDelayedJumpscareChance_;
        this.skipDelayedJumpscareChance_ = val_12.Clone();
        this.maxShockWindow_ = other.maxShockWindow_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHARGE Clone()
    {
        return (CHARGE)new ATTACK_DATA.Types.CHARGE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Seconds()
    {
        return (RANGE)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_ShockWindow()
    {
        return (RANGE)this.shockWindow_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShockWindow(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.shockWindow_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE get_NextPhase()
    {
        return (NEXTPHASE)this.nextPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NextPhase(ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE value)
    {
        this.nextPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ForceShutdown()
    {
        return (bool)this.forceShutdown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ForceShutdown(bool value)
    {
        this.forceShutdown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseFeintDistance()
    {
        return (bool)this.useFeintDistance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseFeintDistance(bool value)
    {
        this.useFeintDistance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_JumpscareDelayChance()
    {
        return (CHANCE)this.jumpscareDelayChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_JumpscareDelayChance(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.jumpscareDelayChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_JumpscareDelayTime()
    {
        return (RANGE)this.jumpscareDelayTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_JumpscareDelayTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.jumpscareDelayTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_SkipDelayedJumpscareChance()
    {
        return (CHANCE)this.skipDelayedJumpscareChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SkipDelayedJumpscareChance(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.skipDelayedJumpscareChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxShockWindow()
    {
        return (double)this.maxShockWindow_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxShockWindow(double value)
    {
        this.maxShockWindow_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CHARGE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.CHARGE other)
    {
        var val_12;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false) && ((System.Object.Equals(objA:  this.shockWindow_, objB:  other.shockWindow_)) != false)) && ((System.Object.Equals(objA:  this.nextPhase_, objB:  other.nextPhase_)) != false))
        {
                var val_4 = (this.forceShutdown_ == true) ? 1 : 0;
            val_4 = val_4 ^ ((other.forceShutdown_ == true) ? 1 : 0);
            if((val_4 & 1) == 0)
        {
                var val_6 = (this.useFeintDistance_ == true) ? 1 : 0;
            val_6 = val_6 ^ ((other.useFeintDistance_ == true) ? 1 : 0);
            if(((((val_6 & 1) == 0) && ((System.Object.Equals(objA:  this.jumpscareDelayChance_, objB:  other.jumpscareDelayChance_)) != false)) && ((System.Object.Equals(objA:  this.jumpscareDelayTime_, objB:  other.jumpscareDelayTime_)) != false)) && ((System.Object.Equals(objA:  this.skipDelayedJumpscareChance_, objB:  other.skipDelayedJumpscareChance_)) != false))
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_14:
        val_12 = 0;
        return (bool)val_12;
        label_2:
        val_12 = 1;
        return (bool)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        var val_6;
        if(this.seconds_ != null)
        {
                val_6 = this.seconds_ ^ 1;
        }
        else
        {
                val_6 = 1;
        }
        
        if(this.shockWindow_ != null)
        {
                val_6 = this.shockWindow_ ^ val_6;
        }
        
        if(this.nextPhase_ != null)
        {
                val_6 = this.nextPhase_ ^ val_6;
        }
        
        if(this.forceShutdown_ != false)
        {
                val_5 = 0;
            val_6 = 1.GetHashCode() ^ val_6;
        }
        
        if(this.useFeintDistance_ != false)
        {
                val_5 = 0;
            val_6 = 1.GetHashCode() ^ val_6;
        }
        
        if(this.jumpscareDelayChance_ != null)
        {
                val_6 = this.jumpscareDelayChance_ ^ val_6;
        }
        
        if(this.jumpscareDelayTime_ != null)
        {
                val_6 = this.jumpscareDelayTime_ ^ val_6;
        }
        
        if(this.skipDelayedJumpscareChance_ != null)
        {
                val_6 = this.skipDelayedJumpscareChance_ ^ val_6;
        }
        
        if(this.maxShockWindow_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields ^ val_6;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        ATTACK_DATA.Types.RANGE val_3;
        ATTACK_DATA.Types.RANGE val_4;
        NEXTPHASE val_5;
        bool val_6;
        bool val_7;
        ATTACK_DATA.Types.CHANCE val_8;
        ATTACK_DATA.Types.RANGE val_9;
        ATTACK_DATA.Types.CHANCE val_10;
        double val_11;
        if(this.seconds_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.seconds_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.shockWindow_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.shockWindow_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.shockWindow_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.nextPhase_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_5 = this.nextPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_5 = this.nextPhase_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.forceShutdown_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  32);
            val_6 = this.forceShutdown_;
        }
        else
        {
                0.WriteRawTag(b1:  32);
            val_6 = this.forceShutdown_;
        }
        
            output.WriteBool(value:  (val_6 == true) ? 1 : 0);
        }
        
        if(this.useFeintDistance_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  40);
            val_7 = this.useFeintDistance_;
        }
        else
        {
                0.WriteRawTag(b1:  40);
            val_7 = this.useFeintDistance_;
        }
        
            output.WriteBool(value:  (val_7 == true) ? 1 : 0);
        }
        
        if(this.jumpscareDelayChance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_8 = this.jumpscareDelayChance_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_8 = this.jumpscareDelayChance_;
        }
        
            output.WriteMessage(value:  val_8);
        }
        
        if(this.jumpscareDelayTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_9 = this.jumpscareDelayTime_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_9 = this.jumpscareDelayTime_;
        }
        
            output.WriteMessage(value:  val_9);
        }
        
        if(this.skipDelayedJumpscareChance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_10 = this.skipDelayedJumpscareChance_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_10 = this.skipDelayedJumpscareChance_;
        }
        
            output.WriteMessage(value:  val_10);
        }
        
        if(this.maxShockWindow_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_11 = this.maxShockWindow_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_11 = this.maxShockWindow_;
        }
        
            output.WriteDouble(value:  val_11);
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
        var val_17;
        var val_18;
        var val_19;
        if(this.seconds_ != null)
        {
                val_17 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.seconds_)) + 1;
        }
        else
        {
                val_17 = 0;
        }
        
        if(this.shockWindow_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.shockWindow_))) + 1;
        }
        
        if(this.nextPhase_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.nextPhase_))) + 1;
        }
        
        int val_6 = val_17 + 2;
        var val_7 = (this.forceShutdown_ == true) ? (val_6) : (val_17);
        val_6 = val_7 + 2;
        val_17 = (this.useFeintDistance_ == true) ? (val_6) : (val_7);
        if(this.jumpscareDelayChance_ != null)
        {
                val_18 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.jumpscareDelayChance_))) + 1;
        }
        
        if(this.jumpscareDelayTime_ != null)
        {
                val_18 = (val_18 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.jumpscareDelayTime_))) + 1;
        }
        
        if(this.skipDelayedJumpscareChance_ != null)
        {
                int val_13 = val_18 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.skipDelayedJumpscareChance_));
            val_18 = val_13 + 1;
        }
        
        val_13 = val_18 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_19;
        }
        
        val_19 = this._unknownFields.CalculateSize() + ((this.maxShockWindow_ == 0f) ? (val_18) : (val_13));
        return (int)val_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.CHARGE other)
    {
        ATTACK_DATA.Types.CHANCE val_8;
        ATTACK_DATA.Types.RANGE val_9;
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.RANGE val_12;
        NEXTPHASE val_13;
        NEXTPHASE val_14;
        ATTACK_DATA.Types.CHANCE val_15;
        ATTACK_DATA.Types.CHANCE val_16;
        ATTACK_DATA.Types.RANGE val_17;
        ATTACK_DATA.Types.RANGE val_18;
        ATTACK_DATA.Types.CHANCE val_19;
        if(other == null)
        {
                return;
        }
        
        val_9 = other.seconds_;
        if(val_9 != null)
        {
                val_10 = this.seconds_;
            if(val_10 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_10 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.seconds_ = val_10;
            val_9 = other.seconds_;
        }
        
            val_1.MergeFrom(other:  val_9);
        }
        
        val_11 = other.shockWindow_;
        if(val_11 != null)
        {
                val_12 = this.shockWindow_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_12 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.shockWindow_ = val_12;
            val_11 = other.shockWindow_;
        }
        
            val_2.MergeFrom(other:  val_11);
        }
        
        val_13 = other.nextPhase_;
        if(val_13 != null)
        {
                val_14 = this.nextPhase_;
            if(val_14 == null)
        {
                ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE val_3 = null;
            val_14 = val_3;
            val_3 = new ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE();
            this.nextPhase_ = val_14;
            val_13 = other.nextPhase_;
        }
        
            val_3.MergeFrom(other:  val_13);
        }
        
        if(other.forceShutdown_ != false)
        {
                this.forceShutdown_ = other.forceShutdown_;
        }
        
        if(other.useFeintDistance_ != false)
        {
                this.useFeintDistance_ = other.useFeintDistance_;
        }
        
        val_15 = other.jumpscareDelayChance_;
        if(val_15 != null)
        {
                val_16 = this.jumpscareDelayChance_;
            if(val_16 == null)
        {
                ATTACK_DATA.Types.CHANCE val_4 = null;
            val_16 = val_4;
            val_4 = new ATTACK_DATA.Types.CHANCE();
            this.jumpscareDelayChance_ = val_16;
            val_15 = other.jumpscareDelayChance_;
        }
        
            val_4.MergeFrom(other:  val_15);
        }
        
        val_17 = other.jumpscareDelayTime_;
        if(val_17 != null)
        {
                val_18 = this.jumpscareDelayTime_;
            if(val_18 == null)
        {
                ATTACK_DATA.Types.RANGE val_5 = null;
            val_18 = val_5;
            val_5 = new ATTACK_DATA.Types.RANGE();
            this.jumpscareDelayTime_ = val_18;
            val_17 = other.jumpscareDelayTime_;
        }
        
            val_5.MergeFrom(other:  val_17);
        }
        
        val_8 = other.skipDelayedJumpscareChance_;
        if(val_8 != null)
        {
                val_19 = this.skipDelayedJumpscareChance_;
            if(val_19 == null)
        {
                ATTACK_DATA.Types.CHANCE val_6 = null;
            val_19 = val_6;
            val_6 = new ATTACK_DATA.Types.CHANCE();
            this.skipDelayedJumpscareChance_ = val_19;
            val_8 = other.skipDelayedJumpscareChance_;
        }
        
            val_6.MergeFrom(other:  val_8);
        }
        
        if(other.maxShockWindow_ != 0f)
        {
                this.maxShockWindow_ = other.maxShockWindow_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_14;
        goto label_38;
        label_42:
        if(10136 > 32)
        {
            goto label_2;
        }
        
        if(10136 > 18)
        {
            goto label_3;
        }
        
        if(10136 == 10)
        {
            goto label_4;
        }
        
        if(10136 != 18)
        {
            goto label_21;
        }
        
        val_14 = this.shockWindow_;
        if(val_14 != null)
        {
            goto label_33;
        }
        
        ATTACK_DATA.Types.RANGE val_1 = null;
        val_14 = val_1;
        val_1 = new ATTACK_DATA.Types.RANGE();
        this.shockWindow_ = val_14;
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_2:
        if(10136 > 50)
        {
            goto label_9;
        }
        
        if(10136 == 40)
        {
            goto label_10;
        }
        
        if(10136 != 50)
        {
            goto label_21;
        }
        
        val_14 = this.jumpscareDelayChance_;
        if(val_14 != null)
        {
            goto label_33;
        }
        
        ATTACK_DATA.Types.CHANCE val_2 = null;
        val_14 = val_2;
        val_2 = new ATTACK_DATA.Types.CHANCE();
        this.jumpscareDelayChance_ = val_14;
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_3:
        if(10136 == 26)
        {
            goto label_15;
        }
        
        if(10136 != 32)
        {
            goto label_21;
        }
        
        this.forceShutdown_ = input.ReadBool();
        goto label_38;
        label_9:
        if(10136 == 58)
        {
            goto label_19;
        }
        
        if(10136 == 66)
        {
            goto label_20;
        }
        
        if(10136 != 73)
        {
            goto label_21;
        }
        
        this.maxShockWindow_ = input.ReadDouble();
        goto label_38;
        label_21:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_38;
        label_4:
        val_14 = this.seconds_;
        if(val_14 != null)
        {
            goto label_33;
        }
        
        ATTACK_DATA.Types.RANGE val_7 = null;
        val_14 = val_7;
        val_7 = new ATTACK_DATA.Types.RANGE();
        this.seconds_ = val_14;
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_10:
        this.useFeintDistance_ = input.ReadBool();
        goto label_38;
        label_15:
        val_14 = this.nextPhase_;
        if(val_14 != null)
        {
            goto label_33;
        }
        
        ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE val_10 = null;
        val_14 = val_10;
        val_10 = new ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE();
        this.nextPhase_ = val_14;
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_20:
        val_14 = this.skipDelayedJumpscareChance_;
        if(val_14 != null)
        {
            goto label_33;
        }
        
        ATTACK_DATA.Types.CHANCE val_11 = null;
        val_14 = val_11;
        val_11 = new ATTACK_DATA.Types.CHANCE();
        this.skipDelayedJumpscareChance_ = val_14;
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_19:
        val_14 = this.jumpscareDelayTime_;
        if(val_14 == null)
        {
            goto label_36;
        }
        
        label_33:
        if(input != null)
        {
            goto label_39;
        }
        
        label_40:
        label_39:
        input.ReadMessage(builder:  val_14);
        goto label_38;
        label_36:
        this.jumpscareDelayTime_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_39;
        }
        
        goto label_40;
        label_38:
        if(input.ReadTag() != 0)
        {
            goto label_42;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.CHARGE()
    {
        null = null;
        ATTACK_DATA.Types.CHARGE.MaxShockWindowFieldNumber = new Google.Protobuf.MessageParser<CHARGE>(factory:  new System.Func<CHARGE>(object:  ATTACK_DATA.Types.CHARGE.<>c.<>9, method:  CHARGE ATTACK_DATA.Types.CHARGE.<>c::<.cctor>b__66_0()));
    }

}
