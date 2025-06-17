using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.CIRCLE : IMessage<ProtoData.ATTACK_DATA.Types.CIRCLE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.CIRCLE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.CIRCLE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CIRCLE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DegreesPerSecondFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE degreesPerSecond_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NextPhaseFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE nextPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FootstepSpeedScalarFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE footstepSpeedScalar_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChangeSpeedFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE changeSpeed_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TriggerPercentFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE triggerPercent_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CIRCLE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE DegreesPerSecond { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE NextPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE FootstepSpeedScalar { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE ChangeSpeed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE TriggerPercent { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CIRCLE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CIRCLE>)ATTACK_DATA.Types.CIRCLE.TriggerPercentFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.CIRCLE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CIRCLE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CIRCLE(ProtoData.ATTACK_DATA.Types.CIRCLE other)
    {
        ATTACK_DATA.Types.RANGE val_8;
        NEXTPHASE val_9;
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.CHANCE val_11;
        ATTACK_DATA.Types.RANGE val_12;
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
        val_8 = other.degreesPerSecond_;
        this.degreesPerSecond_ = val_8.Clone();
        val_9 = other.nextPhase_;
        this.nextPhase_ = val_9.Clone();
        val_10 = other.footstepSpeedScalar_;
        this.footstepSpeedScalar_ = val_10.Clone();
        val_11 = other.changeSpeed_;
        this.changeSpeed_ = val_11.Clone();
        val_12 = other.triggerPercent_;
        this.triggerPercent_ = val_12.Clone();
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
    public ProtoData.ATTACK_DATA.Types.CIRCLE Clone()
    {
        return (CIRCLE)new ATTACK_DATA.Types.CIRCLE(other:  this);
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
    public ProtoData.ATTACK_DATA.Types.RANGE get_DegreesPerSecond()
    {
        return (RANGE)this.degreesPerSecond_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DegreesPerSecond(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.degreesPerSecond_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE get_NextPhase()
    {
        return (NEXTPHASE)this.nextPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NextPhase(ProtoData.ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE value)
    {
        this.nextPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_FootstepSpeedScalar()
    {
        return (RANGE)this.footstepSpeedScalar_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FootstepSpeedScalar(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.footstepSpeedScalar_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_ChangeSpeed()
    {
        return (CHANCE)this.changeSpeed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChangeSpeed(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.changeSpeed_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_TriggerPercent()
    {
        return (RANGE)this.triggerPercent_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TriggerPercent(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.triggerPercent_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CIRCLE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.CIRCLE other)
    {
        var val_7;
        if(other == null)
        {
            goto label_7;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false) && ((System.Object.Equals(objA:  this.degreesPerSecond_, objB:  other.degreesPerSecond_)) != false)) && ((System.Object.Equals(objA:  this.nextPhase_, objB:  other.nextPhase_)) != false)) && ((System.Object.Equals(objA:  this.footstepSpeedScalar_, objB:  other.footstepSpeedScalar_)) != false)) && ((System.Object.Equals(objA:  this.changeSpeed_, objB:  other.changeSpeed_)) != false))
        {
                if((System.Object.Equals(objA:  this.triggerPercent_, objB:  other.triggerPercent_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_7:
        val_7 = 0;
        return (bool)val_7;
        label_1:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.seconds_ != null)
        {
                val_3 = this.seconds_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.degreesPerSecond_ != null)
        {
                val_3 = this.degreesPerSecond_ ^ val_3;
        }
        
        if(this.nextPhase_ != null)
        {
                val_3 = this.nextPhase_ ^ val_3;
        }
        
        if(this.footstepSpeedScalar_ != null)
        {
                val_3 = this.footstepSpeedScalar_ ^ val_3;
        }
        
        if(this.changeSpeed_ != null)
        {
                val_3 = this.changeSpeed_ ^ val_3;
        }
        
        if(this.triggerPercent_ != null)
        {
                val_3 = this.triggerPercent_ ^ val_3;
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
        NEXTPHASE val_3;
        ATTACK_DATA.Types.RANGE val_4;
        ATTACK_DATA.Types.CHANCE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        if(this.seconds_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.degreesPerSecond_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.degreesPerSecond_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.degreesPerSecond_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.nextPhase_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.nextPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.nextPhase_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.footstepSpeedScalar_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.footstepSpeedScalar_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.footstepSpeedScalar_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.changeSpeed_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.changeSpeed_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.changeSpeed_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.triggerPercent_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.triggerPercent_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.triggerPercent_;
        }
        
            output.WriteMessage(value:  val_6);
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
        ATTACK_DATA.Types.RANGE val_13 = this.seconds_;
        if(val_13 != null)
        {
                val_13 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_13 = this.seconds_)) + 1;
        }
        
        if(this.degreesPerSecond_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.degreesPerSecond_))) + 1;
        }
        
        if(this.nextPhase_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.nextPhase_))) + 1;
        }
        
        if(this.footstepSpeedScalar_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.footstepSpeedScalar_))) + 1;
        }
        
        if(this.changeSpeed_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.changeSpeed_))) + 1;
        }
        
        if(this.triggerPercent_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.triggerPercent_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_13;
        }
        
        val_13 = this._unknownFields.CalculateSize() + val_13;
        return (int)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.CIRCLE other)
    {
        ATTACK_DATA.Types.RANGE val_8;
        ATTACK_DATA.Types.RANGE val_9;
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.RANGE val_11;
        ATTACK_DATA.Types.RANGE val_12;
        NEXTPHASE val_13;
        NEXTPHASE val_14;
        ATTACK_DATA.Types.RANGE val_15;
        ATTACK_DATA.Types.RANGE val_16;
        ATTACK_DATA.Types.CHANCE val_17;
        ATTACK_DATA.Types.CHANCE val_18;
        ATTACK_DATA.Types.RANGE val_19;
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
        
        val_11 = other.degreesPerSecond_;
        if(val_11 != null)
        {
                val_12 = this.degreesPerSecond_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_12 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.degreesPerSecond_ = val_12;
            val_11 = other.degreesPerSecond_;
        }
        
            val_2.MergeFrom(other:  val_11);
        }
        
        val_13 = other.nextPhase_;
        if(val_13 != null)
        {
                val_14 = this.nextPhase_;
            if(val_14 == null)
        {
                ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE val_3 = null;
            val_14 = val_3;
            val_3 = new ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE();
            this.nextPhase_ = val_14;
            val_13 = other.nextPhase_;
        }
        
            val_3.MergeFrom(other:  val_13);
        }
        
        val_15 = other.footstepSpeedScalar_;
        if(val_15 != null)
        {
                val_16 = this.footstepSpeedScalar_;
            if(val_16 == null)
        {
                ATTACK_DATA.Types.RANGE val_4 = null;
            val_16 = val_4;
            val_4 = new ATTACK_DATA.Types.RANGE();
            this.footstepSpeedScalar_ = val_16;
            val_15 = other.footstepSpeedScalar_;
        }
        
            val_4.MergeFrom(other:  val_15);
        }
        
        val_17 = other.changeSpeed_;
        if(val_17 != null)
        {
                val_18 = this.changeSpeed_;
            if(val_18 == null)
        {
                ATTACK_DATA.Types.CHANCE val_5 = null;
            val_18 = val_5;
            val_5 = new ATTACK_DATA.Types.CHANCE();
            this.changeSpeed_ = val_18;
            val_17 = other.changeSpeed_;
        }
        
            val_5.MergeFrom(other:  val_17);
        }
        
        val_8 = other.triggerPercent_;
        if(val_8 != null)
        {
                val_19 = this.triggerPercent_;
            if(val_19 == null)
        {
                ATTACK_DATA.Types.RANGE val_6 = null;
            val_19 = val_6;
            val_6 = new ATTACK_DATA.Types.RANGE();
            this.triggerPercent_ = val_19;
            val_8 = other.triggerPercent_;
        }
        
            val_6.MergeFrom(other:  val_8);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        NEXTPHASE val_9;
        goto label_27;
        label_31:
        if(10155 > 26)
        {
            goto label_2;
        }
        
        if(10155 == 10)
        {
            goto label_3;
        }
        
        if(10155 == 18)
        {
            goto label_4;
        }
        
        if(10155 != 26)
        {
            goto label_11;
        }
        
        val_9 = this.nextPhase_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE val_1 = null;
        val_9 = val_1;
        val_1 = new ATTACK_DATA.Types.CIRCLE.Types.NEXTPHASE();
        this.nextPhase_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_2:
        if(10155 == 34)
        {
            goto label_9;
        }
        
        if(10155 == 42)
        {
            goto label_10;
        }
        
        if(10155 != 50)
        {
            goto label_11;
        }
        
        val_9 = this.triggerPercent_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_9 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.triggerPercent_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_11:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_27;
        label_4:
        val_9 = this.degreesPerSecond_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        ATTACK_DATA.Types.RANGE val_4 = null;
        val_9 = val_4;
        val_4 = new ATTACK_DATA.Types.RANGE();
        this.degreesPerSecond_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_10:
        val_9 = this.changeSpeed_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        ATTACK_DATA.Types.CHANCE val_5 = null;
        val_9 = val_5;
        val_5 = new ATTACK_DATA.Types.CHANCE();
        this.changeSpeed_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_3:
        val_9 = this.seconds_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        ATTACK_DATA.Types.RANGE val_6 = null;
        val_9 = val_6;
        val_6 = new ATTACK_DATA.Types.RANGE();
        this.seconds_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_9:
        val_9 = this.footstepSpeedScalar_;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(input != null)
        {
            goto label_28;
        }
        
        label_29:
        label_28:
        input.ReadMessage(builder:  val_9);
        goto label_27;
        label_25:
        this.footstepSpeedScalar_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_27:
        if(input.ReadTag() != 0)
        {
            goto label_31;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.CIRCLE()
    {
        null = null;
        ATTACK_DATA.Types.CIRCLE.TriggerPercentFieldNumber = new Google.Protobuf.MessageParser<CIRCLE>(factory:  new System.Func<CIRCLE>(object:  ATTACK_DATA.Types.CIRCLE.<>c.<>9, method:  CIRCLE ATTACK_DATA.Types.CIRCLE.<>c::<.cctor>b__51_0()));
    }

}
