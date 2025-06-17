using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS : IMessage<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ActivationFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE activation_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TriggerPercentFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE triggerPercent_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AddToMaxFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool addToMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UseMaxFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool useMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GoToCircleFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE goToCircle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GoToPauseFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE goToPause_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TeleportToCameraFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool teleportToCamera_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AllowedHalfAngleFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double allowedHalfAngle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ForceCircleAfterPauseFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool forceCircleAfterPause_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE Activation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE TriggerPercent { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AddToMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE GoToCircle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE GoToPause { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool TeleportToCamera { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double AllowedHalfAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ForceCircleAfterPause { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHASESETTINGS>)ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.ForceCircleAfterPauseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.HAYWIRE.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS other)
    {
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.CHANCE val_7;
        ATTACK_DATA.Types.CHANCE val_8;
        if(other.activation_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.activation_ = other.activation_.Clone();
        val_6 = other.triggerPercent_;
        this.triggerPercent_ = val_6.Clone();
        this.addToMax_ = other.addToMax_;
        this.useMax_ = other.useMax_;
        val_7 = other.goToCircle_;
        this.goToCircle_ = val_7.Clone();
        val_8 = other.goToPause_;
        this.goToPause_ = val_8.Clone();
        this.teleportToCamera_ = other.teleportToCamera_;
        this.allowedHalfAngle_ = other.allowedHalfAngle_;
        this.forceCircleAfterPause_ = other.forceCircleAfterPause_;
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
    public ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS Clone()
    {
        return (PHASESETTINGS)new ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_Activation()
    {
        return (CHANCE)this.activation_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Activation(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.activation_ = value;
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
    public bool get_AddToMax()
    {
        return (bool)this.addToMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AddToMax(bool value)
    {
        this.addToMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseMax()
    {
        return (bool)this.useMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseMax(bool value)
    {
        this.useMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_GoToCircle()
    {
        return (CHANCE)this.goToCircle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GoToCircle(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.goToCircle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_GoToPause()
    {
        return (CHANCE)this.goToPause_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GoToPause(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.goToPause_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_TeleportToCamera()
    {
        return (bool)this.teleportToCamera_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TeleportToCamera(bool value)
    {
        this.teleportToCamera_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_AllowedHalfAngle()
    {
        return (double)this.allowedHalfAngle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AllowedHalfAngle(double value)
    {
        this.allowedHalfAngle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ForceCircleAfterPause()
    {
        return (bool)this.forceCircleAfterPause_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ForceCircleAfterPause(bool value)
    {
        this.forceCircleAfterPause_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHASESETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS other)
    {
        var val_14;
        if(other == null)
        {
            goto label_13;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((System.Object.Equals(objA:  this.activation_, objB:  other.activation_)) != false) && ((System.Object.Equals(objA:  this.triggerPercent_, objB:  other.triggerPercent_)) != false))
        {
                var val_3 = (this.addToMax_ == true) ? 1 : 0;
            val_3 = val_3 ^ ((other.addToMax_ == true) ? 1 : 0);
            if((val_3 & 1) == 0)
        {
                var val_5 = (this.useMax_ == true) ? 1 : 0;
            val_5 = val_5 ^ ((other.useMax_ == true) ? 1 : 0);
            if((((val_5 & 1) == 0) && ((System.Object.Equals(objA:  this.goToCircle_, objB:  other.goToCircle_)) != false)) && ((System.Object.Equals(objA:  this.goToPause_, objB:  other.goToPause_)) != false))
        {
                var val_9 = (this.teleportToCamera_ == true) ? 1 : 0;
            val_9 = val_9 ^ ((other.teleportToCamera_ == true) ? 1 : 0);
            if((val_9 & 1) == 0)
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                var val_12 = (this.forceCircleAfterPause_ == true) ? 1 : 0;
            val_12 = val_12 ^ ((other.forceCircleAfterPause_ == true) ? 1 : 0);
            if((val_12 & 1) == 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_13:
        val_14 = 0;
        return (bool)val_14;
        label_2:
        val_14 = 1;
        return (bool)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_7;
        var val_8;
        if(this.activation_ != null)
        {
                val_8 = this.activation_ ^ 1;
        }
        else
        {
                val_8 = 1;
        }
        
        if(this.triggerPercent_ != null)
        {
                val_8 = this.triggerPercent_ ^ val_8;
        }
        
        if(this.addToMax_ != false)
        {
                val_7 = 0;
            val_8 = 1.GetHashCode() ^ val_8;
        }
        
        if(this.useMax_ != false)
        {
                val_7 = 0;
            val_8 = 1.GetHashCode() ^ val_8;
        }
        
        if(this.goToCircle_ != null)
        {
                val_8 = this.goToCircle_ ^ val_8;
        }
        
        if(this.goToPause_ != null)
        {
                val_8 = this.goToPause_ ^ val_8;
        }
        
        if(this.teleportToCamera_ != false)
        {
                val_7 = 0;
            val_8 = 1.GetHashCode() ^ val_8;
        }
        
        if(this.allowedHalfAngle_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.forceCircleAfterPause_ != false)
        {
                val_7 = 0;
            val_8 = 1.GetHashCode() ^ val_8;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields ^ val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        ATTACK_DATA.Types.CHANCE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        bool val_7;
        bool val_8;
        ATTACK_DATA.Types.CHANCE val_9;
        ATTACK_DATA.Types.CHANCE val_10;
        bool val_11;
        double val_12;
        bool val_13;
        if(this.activation_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_5 = this.activation_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_5 = this.activation_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.triggerPercent_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_6 = this.triggerPercent_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_6 = this.triggerPercent_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.addToMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  24);
            val_7 = this.addToMax_;
        }
        else
        {
                0.WriteRawTag(b1:  24);
            val_7 = this.addToMax_;
        }
        
            output.WriteBool(value:  (val_7 == true) ? 1 : 0);
        }
        
        if(this.useMax_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  32);
            val_8 = this.useMax_;
        }
        else
        {
                0.WriteRawTag(b1:  32);
            val_8 = this.useMax_;
        }
        
            output.WriteBool(value:  (val_8 == true) ? 1 : 0);
        }
        
        if(this.goToCircle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_9 = this.goToCircle_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_9 = this.goToCircle_;
        }
        
            output.WriteMessage(value:  val_9);
        }
        
        if(this.goToPause_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_10 = this.goToPause_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_10 = this.goToPause_;
        }
        
            output.WriteMessage(value:  val_10);
        }
        
        if(this.teleportToCamera_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  56);
            val_11 = this.teleportToCamera_;
        }
        else
        {
                0.WriteRawTag(b1:  56);
            val_11 = this.teleportToCamera_;
        }
        
            output.WriteBool(value:  (val_11 == true) ? 1 : 0);
        }
        
        if(this.allowedHalfAngle_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_12 = this.allowedHalfAngle_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_12 = this.allowedHalfAngle_;
        }
        
            output.WriteDouble(value:  val_12);
        }
        
        if(this.forceCircleAfterPause_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  72);
            val_13 = this.forceCircleAfterPause_;
        }
        else
        {
                0.WriteRawTag(b1:  72);
            val_13 = this.forceCircleAfterPause_;
        }
        
            output.WriteBool(value:  (val_13 == true) ? 1 : 0);
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
        var val_15;
        var val_16;
        if(this.activation_ != null)
        {
                val_14 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.activation_)) + 1;
        }
        else
        {
                val_14 = 0;
        }
        
        if(this.triggerPercent_ != null)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.triggerPercent_))) + 1;
        }
        
        int val_4 = val_14 + 2;
        var val_5 = (this.addToMax_ == true) ? (val_4) : (val_14);
        val_4 = val_5 + 2;
        val_14 = (this.useMax_ == true) ? (val_4) : (val_5);
        if(this.goToCircle_ != null)
        {
                val_15 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.goToCircle_))) + 1;
        }
        
        if(this.goToPause_ != null)
        {
                val_15 = (val_15 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.goToPause_))) + 1;
        }
        
        val_4 = val_15 + 2;
        var val_10 = (this.teleportToCamera_ == true) ? (val_4) : (val_15);
        val_4 = val_10 + 9;
        val_10 = (this.allowedHalfAngle_ == 0f) ? (val_10) : (val_4);
        val_4 = val_10 + 2;
        if(this._unknownFields == null)
        {
                return (int)val_16;
        }
        
        val_16 = this._unknownFields.CalculateSize() + ((this.forceCircleAfterPause_ == true) ? (val_4) : (val_10));
        return (int)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS other)
    {
        ATTACK_DATA.Types.CHANCE val_6;
        ATTACK_DATA.Types.CHANCE val_7;
        ATTACK_DATA.Types.CHANCE val_8;
        ATTACK_DATA.Types.RANGE val_9;
        ATTACK_DATA.Types.RANGE val_10;
        ATTACK_DATA.Types.CHANCE val_11;
        ATTACK_DATA.Types.CHANCE val_12;
        ATTACK_DATA.Types.CHANCE val_13;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.activation_;
        if(val_7 != null)
        {
                val_8 = this.activation_;
            if(val_8 == null)
        {
                ATTACK_DATA.Types.CHANCE val_1 = null;
            val_8 = val_1;
            val_1 = new ATTACK_DATA.Types.CHANCE();
            this.activation_ = val_8;
            val_7 = other.activation_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.triggerPercent_;
        if(val_9 != null)
        {
                val_10 = this.triggerPercent_;
            if(val_10 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_10 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.triggerPercent_ = val_10;
            val_9 = other.triggerPercent_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        if(other.addToMax_ != false)
        {
                this.addToMax_ = other.addToMax_;
        }
        
        if(other.useMax_ != false)
        {
                this.useMax_ = other.useMax_;
        }
        
        val_11 = other.goToCircle_;
        if(val_11 != null)
        {
                val_12 = this.goToCircle_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.CHANCE val_3 = null;
            val_12 = val_3;
            val_3 = new ATTACK_DATA.Types.CHANCE();
            this.goToCircle_ = val_12;
            val_11 = other.goToCircle_;
        }
        
            val_3.MergeFrom(other:  val_11);
        }
        
        val_6 = other.goToPause_;
        if(val_6 != null)
        {
                val_13 = this.goToPause_;
            if(val_13 == null)
        {
                ATTACK_DATA.Types.CHANCE val_4 = null;
            val_13 = val_4;
            val_4 = new ATTACK_DATA.Types.CHANCE();
            this.goToPause_ = val_13;
            val_6 = other.goToPause_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        if(other.teleportToCamera_ != false)
        {
                this.teleportToCamera_ = other.teleportToCamera_;
        }
        
        if(other.allowedHalfAngle_ != 0f)
        {
                this.allowedHalfAngle_ = other.allowedHalfAngle_;
        }
        
        if(other.forceCircleAfterPause_ != false)
        {
                this.forceCircleAfterPause_ = other.forceCircleAfterPause_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_16;
        goto label_36;
        label_40:
        if(35323 > 32)
        {
            goto label_2;
        }
        
        if(35323 > 18)
        {
            goto label_3;
        }
        
        if(35323 == 10)
        {
            goto label_4;
        }
        
        if(35323 != 18)
        {
            goto label_21;
        }
        
        val_16 = this.triggerPercent_;
        if(val_16 != null)
        {
            goto label_25;
        }
        
        ATTACK_DATA.Types.RANGE val_1 = null;
        val_16 = val_1;
        val_1 = new ATTACK_DATA.Types.RANGE();
        this.triggerPercent_ = val_16;
        if(input != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_2:
        if(35323 > 50)
        {
            goto label_9;
        }
        
        if(35323 == 42)
        {
            goto label_10;
        }
        
        if(35323 != 50)
        {
            goto label_21;
        }
        
        val_16 = this.goToPause_;
        if(val_16 != null)
        {
            goto label_25;
        }
        
        ATTACK_DATA.Types.CHANCE val_2 = null;
        val_16 = val_2;
        val_2 = new ATTACK_DATA.Types.CHANCE();
        this.goToPause_ = val_16;
        if(input != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_3:
        if(35323 == 24)
        {
            goto label_15;
        }
        
        if(35323 != 32)
        {
            goto label_21;
        }
        
        this.useMax_ = input.ReadBool();
        goto label_36;
        label_9:
        if(35323 == 56)
        {
            goto label_19;
        }
        
        if(35323 == 65)
        {
            goto label_20;
        }
        
        if(35323 != 72)
        {
            goto label_21;
        }
        
        this.forceCircleAfterPause_ = input.ReadBool();
        goto label_36;
        label_21:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_36;
        label_4:
        val_16 = this.activation_;
        if(val_16 != null)
        {
            goto label_25;
        }
        
        ATTACK_DATA.Types.CHANCE val_8 = null;
        val_16 = val_8;
        val_8 = new ATTACK_DATA.Types.CHANCE();
        this.activation_ = val_16;
        if(input != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_10:
        val_16 = this.goToCircle_;
        if(val_16 == null)
        {
            goto label_28;
        }
        
        label_25:
        if(input != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        input.ReadMessage(builder:  val_16);
        goto label_36;
        label_15:
        this.addToMax_ = input.ReadBool();
        goto label_36;
        label_20:
        this.allowedHalfAngle_ = input.ReadDouble();
        goto label_36;
        label_19:
        this.teleportToCamera_ = input.ReadBool();
        goto label_36;
        label_28:
        this.goToCircle_ = new ATTACK_DATA.Types.CHANCE();
        if(input != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_36:
        if(input.ReadTag() != 0)
        {
            goto label_40;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS()
    {
        null = null;
        ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.ForceCircleAfterPauseFieldNumber = new Google.Protobuf.MessageParser<PHASESETTINGS>(factory:  new System.Func<PHASESETTINGS>(object:  ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.<>c.<>9, method:  PHASESETTINGS ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS.<>c::<.cctor>b__65_0()));
    }

}
