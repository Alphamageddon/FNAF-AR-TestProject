using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LookAwayFlagFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool lookAwayFlag_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool batteryDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainAmtFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainAmt_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkingChanceFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double walkingChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkingChanceModFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double walkingChanceMod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkingPctTriggerFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE walkingPctTrigger_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkingAddToMaxFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool walkingAddToMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkingRespectMaxFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool walkingRespectMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseChanceFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double pauseChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseChanceModFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double pauseChanceMod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PausePctTriggerFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE pausePctTrigger_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseAddToMaxFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool pauseAddToMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseRespectMaxFieldNumber = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool pauseRespectMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChargeFeintChanceFieldNumber = 14;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chargeFeintChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChargeFeintChanceModFieldNumber = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chargeFeintChanceMod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChargeFeintAddToMaxFieldNumber = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool chargeFeintAddToMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChargeFeintRespectMaxFieldNumber = 17;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool chargeFeintRespectMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywireTimerFieldNumber = 18;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE haywireTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywireLookTimerFieldNumber = 19;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double haywireLookTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxHaywireCountFieldNumber = 20;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxHaywireCount_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool LookAwayFlag { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool BatteryDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainAmt { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double WalkingChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double WalkingChanceMod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE WalkingPctTrigger { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool WalkingAddToMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool WalkingRespectMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PauseChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PauseChanceMod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE PausePctTrigger { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool PauseAddToMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool PauseRespectMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ChargeFeintChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ChargeFeintChanceMod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ChargeFeintAddToMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ChargeFeintRespectMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE HaywireTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double HaywireLookTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxHaywireCount { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<HAYWIREPARAMETERS>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.MaxHaywireCountFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor.NestedTypes.Item[7];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS other)
    {
        HAYWIRERANGE val_5;
        HAYWIRERANGE val_6;
        HAYWIRERANGE val_7;
        if(other != null)
        {
                this.lookAwayFlag_ = other.lookAwayFlag_;
            this.batteryDrain_ = other.batteryDrain_;
            this.batteryDrainAmt_ = other.batteryDrainAmt_;
            this.walkingChance_ = other.walkingChance_;
            this.walkingChanceMod_ = other.walkingChanceMod_;
        }
        else
        {
                this.lookAwayFlag_ = false;
            this.batteryDrain_ = false;
            this.batteryDrainAmt_ = 3.16202013338398E-322;
            this.walkingChance_ = 3.41288492945375E-316;
            this.walkingChanceMod_ = 1.33509863819657E-307;
        }
        
        val_5 = other.walkingPctTrigger_;
        this.walkingPctTrigger_ = val_5.Clone();
        this.walkingAddToMax_ = other.walkingAddToMax_;
        this.walkingRespectMax_ = other.walkingRespectMax_;
        this.pauseChance_ = other.pauseChance_;
        this.pauseChanceMod_ = other.pauseChanceMod_;
        val_6 = other.pausePctTrigger_;
        this.pausePctTrigger_ = val_6.Clone();
        this.pauseAddToMax_ = other.pauseAddToMax_;
        this.pauseRespectMax_ = other.pauseRespectMax_;
        this.chargeFeintChance_ = other.chargeFeintChance_;
        this.chargeFeintChanceMod_ = other.chargeFeintChanceMod_;
        this.chargeFeintAddToMax_ = other.chargeFeintAddToMax_;
        this.chargeFeintRespectMax_ = other.chargeFeintRespectMax_;
        val_7 = other.haywireTimer_;
        this.haywireTimer_ = val_7.Clone();
        this.haywireLookTimer_ = other.haywireLookTimer_;
        this.maxHaywireCount_ = other.maxHaywireCount_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS Clone()
    {
        return (HAYWIREPARAMETERS)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_LookAwayFlag()
    {
        return (bool)this.lookAwayFlag_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LookAwayFlag(bool value)
    {
        this.lookAwayFlag_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_BatteryDrain()
    {
        return (bool)this.batteryDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrain(bool value)
    {
        this.batteryDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainAmt()
    {
        return (double)this.batteryDrainAmt_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainAmt(double value)
    {
        this.batteryDrainAmt_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_WalkingChance()
    {
        return (double)this.walkingChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WalkingChance(double value)
    {
        this.walkingChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_WalkingChanceMod()
    {
        return (double)this.walkingChanceMod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WalkingChanceMod(double value)
    {
        this.walkingChanceMod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE get_WalkingPctTrigger()
    {
        return (HAYWIRERANGE)this.walkingPctTrigger_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WalkingPctTrigger(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE value)
    {
        this.walkingPctTrigger_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_WalkingAddToMax()
    {
        return (bool)this.walkingAddToMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WalkingAddToMax(bool value)
    {
        this.walkingAddToMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_WalkingRespectMax()
    {
        return (bool)this.walkingRespectMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WalkingRespectMax(bool value)
    {
        this.walkingRespectMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PauseChance()
    {
        return (double)this.pauseChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PauseChance(double value)
    {
        this.pauseChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PauseChanceMod()
    {
        return (double)this.pauseChanceMod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PauseChanceMod(double value)
    {
        this.pauseChanceMod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE get_PausePctTrigger()
    {
        return (HAYWIRERANGE)this.pausePctTrigger_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PausePctTrigger(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE value)
    {
        this.pausePctTrigger_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_PauseAddToMax()
    {
        return (bool)this.pauseAddToMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PauseAddToMax(bool value)
    {
        this.pauseAddToMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_PauseRespectMax()
    {
        return (bool)this.pauseRespectMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PauseRespectMax(bool value)
    {
        this.pauseRespectMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ChargeFeintChance()
    {
        return (double)this.chargeFeintChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChargeFeintChance(double value)
    {
        this.chargeFeintChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ChargeFeintChanceMod()
    {
        return (double)this.chargeFeintChanceMod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChargeFeintChanceMod(double value)
    {
        this.chargeFeintChanceMod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ChargeFeintAddToMax()
    {
        return (bool)this.chargeFeintAddToMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChargeFeintAddToMax(bool value)
    {
        this.chargeFeintAddToMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ChargeFeintRespectMax()
    {
        return (bool)this.chargeFeintRespectMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChargeFeintRespectMax(bool value)
    {
        this.chargeFeintRespectMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE get_HaywireTimer()
    {
        return (HAYWIRERANGE)this.haywireTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HaywireTimer(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE value)
    {
        this.haywireTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_HaywireLookTimer()
    {
        return (double)this.haywireLookTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HaywireLookTimer(double value)
    {
        this.haywireLookTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxHaywireCount()
    {
        return (double)this.maxHaywireCount_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxHaywireCount(double value)
    {
        this.maxHaywireCount_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        HAYWIREPARAMETERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS other)
    {
        var val_29;
        double val_30;
        var val_31;
        if(other == null)
        {
            goto label_49;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        var val_1 = (this.lookAwayFlag_ == true) ? 1 : 0;
        val_1 = val_1 ^ ((other.lookAwayFlag_ == true) ? 1 : 0);
        if((val_1 & 1) != 0)
        {
            goto label_49;
        }
        
        var val_3 = (this.batteryDrain_ == true) ? 1 : 0;
        val_3 = val_3 ^ ((other.batteryDrain_ == true) ? 1 : 0);
        if((val_3 & 1) != 0)
        {
            goto label_49;
        }
        
        val_30 = this.batteryDrainAmt_;
        val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_29 & 1) == 0)
        {
            goto label_49;
        }
        
        val_30 = this.walkingChance_;
        val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_29 & 1) == 0)
        {
            goto label_49;
        }
        
        val_30 = this.walkingChanceMod_;
        val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if(((val_29 & 1) == 0) || ((System.Object.Equals(objA:  this.walkingPctTrigger_, objB:  other.walkingPctTrigger_)) == false))
        {
            goto label_49;
        }
        
        var val_9 = (this.walkingAddToMax_ == true) ? 1 : 0;
        val_9 = val_9 ^ ((other.walkingAddToMax_ == true) ? 1 : 0);
        if((val_9 & 1) != 0)
        {
            goto label_49;
        }
        
        var val_11 = (this.walkingRespectMax_ == true) ? 1 : 0;
        val_11 = val_11 ^ ((other.walkingRespectMax_ == true) ? 1 : 0);
        if((val_11 & 1) != 0)
        {
            goto label_49;
        }
        
        val_30 = this.pauseChance_;
        val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_29 & 1) != 0)
        {
                val_30 = this.pauseChanceMod_;
            val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if(((val_29 & 1) != 0) && ((System.Object.Equals(objA:  this.pausePctTrigger_, objB:  other.pausePctTrigger_)) != false))
        {
                var val_16 = (this.pauseAddToMax_ == true) ? 1 : 0;
            val_16 = val_16 ^ ((other.pauseAddToMax_ == true) ? 1 : 0);
            if((val_16 & 1) == 0)
        {
                var val_18 = (this.pauseRespectMax_ == true) ? 1 : 0;
            val_18 = val_18 ^ ((other.pauseRespectMax_ == true) ? 1 : 0);
            if((val_18 & 1) == 0)
        {
                val_30 = this.chargeFeintChance_;
            val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_29 & 1) != 0)
        {
                val_30 = this.chargeFeintChanceMod_;
            val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_29 & 1) != 0)
        {
                var val_22 = (this.chargeFeintAddToMax_ == true) ? 1 : 0;
            val_22 = val_22 ^ ((other.chargeFeintAddToMax_ == true) ? 1 : 0);
            if((val_22 & 1) == 0)
        {
                var val_24 = (this.chargeFeintRespectMax_ == true) ? 1 : 0;
            val_24 = val_24 ^ ((other.chargeFeintRespectMax_ == true) ? 1 : 0);
            if(((val_24 & 1) == 0) && ((System.Object.Equals(objA:  this.haywireTimer_, objB:  other.haywireTimer_)) != false))
        {
                val_30 = this.haywireLookTimer_;
            val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_29 & 1) != 0)
        {
                val_30 = this.maxHaywireCount_;
            val_29 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_29 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_49:
        val_31 = 0;
        return (bool)val_31;
        label_2:
        val_31 = 1;
        return (bool)val_31;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_18;
        var val_19;
        val_18 = 1;
        if(this.lookAwayFlag_ != false)
        {
                val_19 = 0;
            val_18 = val_18.GetHashCode() ^ 1;
        }
        
        if(this.batteryDrain_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.batteryDrainAmt_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.walkingChance_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.walkingChanceMod_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.walkingPctTrigger_ != null)
        {
                val_18 = this.walkingPctTrigger_ ^ val_18;
        }
        
        if(this.walkingAddToMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.walkingRespectMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.pauseChance_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.pauseChanceMod_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.pausePctTrigger_ != null)
        {
                val_18 = this.pausePctTrigger_ ^ val_18;
        }
        
        if(this.pauseAddToMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.pauseRespectMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.chargeFeintChance_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.chargeFeintChanceMod_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.chargeFeintAddToMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.chargeFeintRespectMax_ != false)
        {
                val_19 = 0;
            val_18 = 1.GetHashCode() ^ val_18;
        }
        
        if(this.haywireTimer_ != null)
        {
                val_18 = this.haywireTimer_ ^ val_18;
        }
        
        if(this.haywireLookTimer_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxHaywireCount_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_18;
        }
        
        val_18 = this._unknownFields ^ val_18;
        return (int)val_18;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        bool val_9;
        bool val_10;
        double val_11;
        double val_12;
        double val_13;
        HAYWIRERANGE val_14;
        bool val_15;
        bool val_16;
        double val_17;
        double val_18;
        HAYWIRERANGE val_19;
        bool val_20;
        bool val_21;
        double val_22;
        double val_23;
        bool val_24;
        bool val_25;
        HAYWIRERANGE val_26;
        double val_27;
        double val_28;
        if(this.lookAwayFlag_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_9 = this.lookAwayFlag_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_9 = this.lookAwayFlag_;
        }
        
            output.WriteBool(value:  (val_9 == true) ? 1 : 0);
        }
        
        if(this.batteryDrain_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_10 = this.batteryDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_10 = this.batteryDrain_;
        }
        
            output.WriteBool(value:  (val_10 == true) ? 1 : 0);
        }
        
        if(this.batteryDrainAmt_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_11 = this.batteryDrainAmt_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_11 = this.batteryDrainAmt_;
        }
        
            output.WriteDouble(value:  val_11);
        }
        
        if(this.walkingChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_12 = this.walkingChance_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_12 = this.walkingChance_;
        }
        
            output.WriteDouble(value:  val_12);
        }
        
        if(this.walkingChanceMod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_13 = this.walkingChanceMod_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_13 = this.walkingChanceMod_;
        }
        
            output.WriteDouble(value:  val_13);
        }
        
        if(this.walkingPctTrigger_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_14 = this.walkingPctTrigger_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_14 = this.walkingPctTrigger_;
        }
        
            output.WriteMessage(value:  val_14);
        }
        
        if(this.walkingAddToMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  56);
            val_15 = this.walkingAddToMax_;
        }
        else
        {
                0.WriteRawTag(b1:  56);
            val_15 = this.walkingAddToMax_;
        }
        
            output.WriteBool(value:  (val_15 == true) ? 1 : 0);
        }
        
        if(this.walkingRespectMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  64);
            val_16 = this.walkingRespectMax_;
        }
        else
        {
                0.WriteRawTag(b1:  64);
            val_16 = this.walkingRespectMax_;
        }
        
            output.WriteBool(value:  (val_16 == true) ? 1 : 0);
        }
        
        if(this.pauseChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_17 = this.pauseChance_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_17 = this.pauseChance_;
        }
        
            output.WriteDouble(value:  val_17);
        }
        
        if(this.pauseChanceMod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  81);
            val_18 = this.pauseChanceMod_;
        }
        else
        {
                0.WriteRawTag(b1:  81);
            val_18 = this.pauseChanceMod_;
        }
        
            output.WriteDouble(value:  val_18);
        }
        
        if(this.pausePctTrigger_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  90);
            val_19 = this.pausePctTrigger_;
        }
        else
        {
                0.WriteRawTag(b1:  90);
            val_19 = this.pausePctTrigger_;
        }
        
            output.WriteMessage(value:  val_19);
        }
        
        if(this.pauseAddToMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  96);
            val_20 = this.pauseAddToMax_;
        }
        else
        {
                0.WriteRawTag(b1:  96);
            val_20 = this.pauseAddToMax_;
        }
        
            output.WriteBool(value:  (val_20 == true) ? 1 : 0);
        }
        
        if(this.pauseRespectMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  104);
            val_21 = this.pauseRespectMax_;
        }
        else
        {
                0.WriteRawTag(b1:  104);
            val_21 = this.pauseRespectMax_;
        }
        
            output.WriteBool(value:  (val_21 == true) ? 1 : 0);
        }
        
        if(this.chargeFeintChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  113);
            val_22 = this.chargeFeintChance_;
        }
        else
        {
                0.WriteRawTag(b1:  113);
            val_22 = this.chargeFeintChance_;
        }
        
            output.WriteDouble(value:  val_22);
        }
        
        if(this.chargeFeintChanceMod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  121);
            val_23 = this.chargeFeintChanceMod_;
        }
        else
        {
                0.WriteRawTag(b1:  121);
            val_23 = this.chargeFeintChanceMod_;
        }
        
            output.WriteDouble(value:  val_23);
        }
        
        if(this.chargeFeintAddToMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  128, b2:  1);
            val_24 = this.chargeFeintAddToMax_;
        }
        else
        {
                0.WriteRawTag(b1:  128, b2:  1);
            val_24 = this.chargeFeintAddToMax_;
        }
        
            output.WriteBool(value:  (val_24 == true) ? 1 : 0);
        }
        
        if(this.chargeFeintRespectMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  136, b2:  1);
            val_25 = this.chargeFeintRespectMax_;
        }
        else
        {
                0.WriteRawTag(b1:  136, b2:  1);
            val_25 = this.chargeFeintRespectMax_;
        }
        
            output.WriteBool(value:  (val_25 == true) ? 1 : 0);
        }
        
        if(this.haywireTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  146, b2:  1);
            val_26 = this.haywireTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  146, b2:  1);
            val_26 = this.haywireTimer_;
        }
        
            output.WriteMessage(value:  val_26);
        }
        
        if(this.haywireLookTimer_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  153, b2:  1);
            val_27 = this.haywireLookTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  153, b2:  1);
            val_27 = this.haywireLookTimer_;
        }
        
            output.WriteDouble(value:  val_27);
        }
        
        if(this.maxHaywireCount_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  161, b2:  1);
            val_28 = this.maxHaywireCount_;
        }
        else
        {
                0.WriteRawTag(b1:  161, b2:  1);
            val_28 = this.maxHaywireCount_;
        }
        
            output.WriteDouble(value:  val_28);
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
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        bool val_19 = this.lookAwayFlag_;
        val_19 = val_19 << 1;
        val_19 = (this.batteryDrain_ == true) ? (val_19 + 2) : (val_19);
        var val_2 = val_19 | 9;
        val_19 = (this.batteryDrainAmt_ == 0f) ? (val_19) : (val_2);
        val_2 = val_19 + 9;
        val_19 = (this.walkingChance_ == 0f) ? (val_19) : (val_2);
        val_2 = val_19 + 9;
        if(this.walkingPctTrigger_ != null)
        {
                val_20 = (((this.walkingChanceMod_ == 0f) ? (val_19) : (val_2)) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.walkingPctTrigger_))) + 1;
        }
        
        val_2 = val_20 + 2;
        var val_6 = (this.walkingAddToMax_ == true) ? (val_2) : (val_20);
        var val_8 = (this.walkingRespectMax_ == true) ? (val_6 + 2) : (val_6);
        val_6 = val_8 + 9;
        val_8 = (this.pauseChance_ == 0f) ? (val_8) : (val_6);
        val_6 = val_8 + 9;
        val_20 = (this.pauseChanceMod_ == 0f) ? (val_8) : (val_6);
        if(this.pausePctTrigger_ != null)
        {
                val_21 = (val_20 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.pausePctTrigger_))) + 1;
        }
        
        val_6 = val_21 + 2;
        var val_11 = (this.pauseAddToMax_ == true) ? (val_6) : (val_21);
        val_6 = val_11 + 2;
        val_11 = (this.pauseRespectMax_ == true) ? (val_6) : (val_11);
        var val_12 = val_11 + 9;
        val_11 = (this.chargeFeintChance_ == 0f) ? (val_11) : (val_12);
        val_12 = val_11 + 9;
        val_11 = (this.chargeFeintChanceMod_ == 0f) ? (val_11) : (val_12);
        var val_13 = val_11 + 3;
        val_11 = (this.chargeFeintAddToMax_ == true) ? (val_13) : (val_11);
        val_13 = val_11 + 3;
        val_21 = (this.chargeFeintRespectMax_ == true) ? (val_13) : (val_11);
        if(this.haywireTimer_ != null)
        {
                int val_15 = val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.haywireTimer_));
            val_22 = val_15 + 2;
        }
        
        val_15 = val_22 + 10;
        var val_16 = (this.haywireLookTimer_ == 0f) ? (val_22) : (val_15);
        val_13 = val_16 + 10;
        var val_17 = (this.maxHaywireCount_ == 0f) ? (val_16) : (val_13);
        if(this._unknownFields == null)
        {
                return (int)val_23;
        }
        
        val_23 = this._unknownFields.CalculateSize();
        return (int)val_23;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS other)
    {
        HAYWIRERANGE val_5;
        HAYWIRERANGE val_6;
        HAYWIRERANGE val_7;
        HAYWIRERANGE val_8;
        HAYWIRERANGE val_9;
        HAYWIRERANGE val_10;
        if(other == null)
        {
                return;
        }
        
        if(other.lookAwayFlag_ != false)
        {
                this.lookAwayFlag_ = other.lookAwayFlag_;
        }
        
        if(other.batteryDrain_ != false)
        {
                this.batteryDrain_ = other.batteryDrain_;
        }
        
        if(other.batteryDrainAmt_ != 0f)
        {
                this.batteryDrainAmt_ = other.batteryDrainAmt_;
        }
        
        if(other.walkingChance_ != 0f)
        {
                this.walkingChance_ = other.walkingChance_;
        }
        
        if(other.walkingChanceMod_ != 0f)
        {
                this.walkingChanceMod_ = other.walkingChanceMod_;
        }
        
        val_6 = other.walkingPctTrigger_;
        if(val_6 != null)
        {
                val_7 = this.walkingPctTrigger_;
            if(val_7 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE val_1 = null;
            val_7 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
            this.walkingPctTrigger_ = val_7;
            val_6 = other.walkingPctTrigger_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        if(other.walkingAddToMax_ != false)
        {
                this.walkingAddToMax_ = other.walkingAddToMax_;
        }
        
        if(other.walkingRespectMax_ != false)
        {
                this.walkingRespectMax_ = other.walkingRespectMax_;
        }
        
        if(other.pauseChance_ != 0f)
        {
                this.pauseChance_ = other.pauseChance_;
        }
        
        if(other.pauseChanceMod_ != 0f)
        {
                this.pauseChanceMod_ = other.pauseChanceMod_;
        }
        
        val_8 = other.pausePctTrigger_;
        if(val_8 != null)
        {
                val_9 = this.pausePctTrigger_;
            if(val_9 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE val_2 = null;
            val_9 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
            this.pausePctTrigger_ = val_9;
            val_8 = other.pausePctTrigger_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        if(other.pauseAddToMax_ != false)
        {
                this.pauseAddToMax_ = other.pauseAddToMax_;
        }
        
        if(other.pauseRespectMax_ != false)
        {
                this.pauseRespectMax_ = other.pauseRespectMax_;
        }
        
        if(other.chargeFeintChance_ != 0f)
        {
                this.chargeFeintChance_ = other.chargeFeintChance_;
        }
        
        if(other.chargeFeintChanceMod_ != 0f)
        {
                this.chargeFeintChanceMod_ = other.chargeFeintChanceMod_;
        }
        
        if(other.chargeFeintAddToMax_ != false)
        {
                this.chargeFeintAddToMax_ = other.chargeFeintAddToMax_;
        }
        
        if(other.chargeFeintRespectMax_ != false)
        {
                this.chargeFeintRespectMax_ = other.chargeFeintRespectMax_;
        }
        
        val_5 = other.haywireTimer_;
        if(val_5 != null)
        {
                val_10 = this.haywireTimer_;
            if(val_10 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE val_3 = null;
            val_10 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
            this.haywireTimer_ = val_10;
            val_5 = other.haywireTimer_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        if(other.haywireLookTimer_ != 0f)
        {
                this.haywireLookTimer_ = other.haywireLookTimer_;
        }
        
        if(other.maxHaywireCount_ != 0f)
        {
                this.maxHaywireCount_ = other.maxHaywireCount_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        HAYWIRERANGE val_31;
        goto label_72;
        label_76:
        if(25474 > 81)
        {
            goto label_2;
        }
        
        if(25474 > 41)
        {
            goto label_3;
        }
        
        if(25474 > 16)
        {
            goto label_4;
        }
        
        if(25474 == 8)
        {
            goto label_5;
        }
        
        if(25474 != 16)
        {
            goto label_42;
        }
        
        this.batteryDrain_ = input.ReadBool();
        goto label_72;
        label_2:
        if(25474 > 121)
        {
            goto label_9;
        }
        
        if(25474 > 96)
        {
            goto label_10;
        }
        
        if(25474 == 90)
        {
            goto label_11;
        }
        
        if(25474 != 96)
        {
            goto label_42;
        }
        
        this.pauseAddToMax_ = input.ReadBool();
        goto label_72;
        label_3:
        if(25474 > 56)
        {
            goto label_15;
        }
        
        if(25474 == 50)
        {
            goto label_16;
        }
        
        if(25474 != 56)
        {
            goto label_42;
        }
        
        this.walkingAddToMax_ = input.ReadBool();
        goto label_72;
        label_9:
        if(25474 > 136)
        {
            goto label_20;
        }
        
        if(25474 == 128)
        {
            goto label_21;
        }
        
        if(25474 != 136)
        {
            goto label_42;
        }
        
        this.chargeFeintRespectMax_ = input.ReadBool();
        goto label_72;
        label_4:
        if(25474 == 25)
        {
            goto label_25;
        }
        
        if(25474 == 33)
        {
            goto label_26;
        }
        
        if(25474 != 41)
        {
            goto label_42;
        }
        
        this.walkingChanceMod_ = input.ReadDouble();
        goto label_72;
        label_10:
        if(25474 == 104)
        {
            goto label_30;
        }
        
        if(25474 == 113)
        {
            goto label_31;
        }
        
        if(25474 != 121)
        {
            goto label_42;
        }
        
        this.chargeFeintChanceMod_ = input.ReadDouble();
        goto label_72;
        label_15:
        if(25474 == 64)
        {
            goto label_35;
        }
        
        if(25474 == 73)
        {
            goto label_36;
        }
        
        if(25474 != 81)
        {
            goto label_42;
        }
        
        this.pauseChanceMod_ = input.ReadDouble();
        goto label_72;
        label_20:
        if(25474 == 146)
        {
            goto label_40;
        }
        
        if(25474 == 153)
        {
            goto label_41;
        }
        
        if(25474 != 161)
        {
            goto label_42;
        }
        
        this.maxHaywireCount_ = input.ReadDouble();
        goto label_72;
        label_42:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_72;
        label_5:
        this.lookAwayFlag_ = input.ReadBool();
        goto label_72;
        label_11:
        val_31 = this.pausePctTrigger_;
        if(val_31 != null)
        {
            goto label_51;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE val_16 = null;
        val_31 = val_16;
        val_16 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
        this.pausePctTrigger_ = val_31;
        if(input != null)
        {
            goto label_73;
        }
        
        goto label_74;
        label_16:
        val_31 = this.walkingPctTrigger_;
        if(val_31 != null)
        {
            goto label_51;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE val_17 = null;
        val_31 = val_17;
        val_17 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
        this.walkingPctTrigger_ = val_31;
        if(input != null)
        {
            goto label_73;
        }
        
        goto label_74;
        label_21:
        this.chargeFeintAddToMax_ = input.ReadBool();
        goto label_72;
        label_25:
        this.batteryDrainAmt_ = input.ReadDouble();
        goto label_72;
        label_26:
        this.walkingChance_ = input.ReadDouble();
        goto label_72;
        label_30:
        this.pauseRespectMax_ = input.ReadBool();
        goto label_72;
        label_31:
        this.chargeFeintChance_ = input.ReadDouble();
        goto label_72;
        label_35:
        this.walkingRespectMax_ = input.ReadBool();
        goto label_72;
        label_36:
        this.pauseChance_ = input.ReadDouble();
        goto label_72;
        label_40:
        val_31 = this.haywireTimer_;
        if(val_31 == null)
        {
            goto label_68;
        }
        
        label_51:
        if(input != null)
        {
            goto label_73;
        }
        
        label_74:
        label_73:
        input.ReadMessage(builder:  val_31);
        goto label_72;
        label_41:
        this.haywireLookTimer_ = input.ReadDouble();
        goto label_72;
        label_68:
        this.haywireTimer_ = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.Types.HAYWIRERANGE();
        if(input != null)
        {
            goto label_73;
        }
        
        goto label_74;
        label_72:
        if(input.ReadTag() != 0)
        {
            goto label_76;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.MaxHaywireCountFieldNumber = new Google.Protobuf.MessageParser<HAYWIREPARAMETERS>(factory:  new System.Func<HAYWIREPARAMETERS>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.<>c.<>9, method:  HAYWIREPARAMETERS ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS.<>c::<.cctor>b__121_0()));
    }

}
