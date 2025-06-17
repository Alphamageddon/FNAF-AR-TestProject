using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.SURGE.Types.SETTINGS : IMessage<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CooldownFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE cooldown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ActivationFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE activation_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CancelTimeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double cancelTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CancelActionFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string cancelAction_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainRateBaseFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainRateBase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainRateCancelFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainRateCancel_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BlinkDurationFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double blinkDuration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaskLightFadeTimeFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maskLightFadeTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HapticCueFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string hapticCue_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Cooldown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE Activation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CancelTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string CancelAction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainRateBase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainRateCancel { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BlinkDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaskLightFadeTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string HapticCue { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SETTINGS>)ATTACK_DATA.Types.SURGE.Types.SETTINGS.HapticCueFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.SURGE.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.SURGE.Types.SETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.SURGE.Types.SETTINGS()
    {
        this.cancelAction_ = "";
        this.hapticCue_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.SURGE.Types.SETTINGS(ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS other)
    {
        ATTACK_DATA.Types.CHANCE val_4;
        if(other.cooldown_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.cooldown_ = other.cooldown_.Clone();
        val_4 = other.activation_;
        this.activation_ = val_4.Clone();
        this.cancelTime_ = other.cancelTime_;
        this.cancelAction_ = other.cancelAction_;
        this.batteryDrainRateBase_ = other.batteryDrainRateBase_;
        this.batteryDrainRateCancel_ = other.batteryDrainRateCancel_;
        this.blinkDuration_ = other.blinkDuration_;
        this.maskLightFadeTime_ = other.maskLightFadeTime_;
        this.hapticCue_ = other.hapticCue_;
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
    public ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS Clone()
    {
        return (SETTINGS)new ATTACK_DATA.Types.SURGE.Types.SETTINGS(other:  this);
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
    public double get_CancelTime()
    {
        return (double)this.cancelTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CancelTime(double value)
    {
        this.cancelTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_CancelAction()
    {
        return (string)this.cancelAction_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CancelAction(string value)
    {
        this.cancelAction_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainRateBase()
    {
        return (double)this.batteryDrainRateBase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainRateBase(double value)
    {
        this.batteryDrainRateBase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainRateCancel()
    {
        return (double)this.batteryDrainRateCancel_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainRateCancel(double value)
    {
        this.batteryDrainRateCancel_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BlinkDuration()
    {
        return (double)this.blinkDuration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BlinkDuration(double value)
    {
        this.blinkDuration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaskLightFadeTime()
    {
        return (double)this.maskLightFadeTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaskLightFadeTime(double value)
    {
        this.maskLightFadeTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_HapticCue()
    {
        return (string)this.hapticCue_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HapticCue(string value)
    {
        this.hapticCue_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS other)
    {
        var val_10;
        double val_11;
        var val_12;
        if(other == null)
        {
            goto label_25;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((System.Object.Equals(objA:  this.cooldown_, objB:  other.cooldown_)) != false) && ((System.Object.Equals(objA:  this.activation_, objB:  other.activation_)) != false))
        {
                val_11 = this.cancelTime_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if(((val_10 & 1) != 0) && ((System.String.op_Inequality(a:  this.cancelAction_, b:  other.cancelAction_)) != true))
        {
                val_11 = this.batteryDrainRateBase_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.batteryDrainRateCancel_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.blinkDuration_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.maskLightFadeTime_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                if((System.String.op_Inequality(a:  this.hapticCue_, b:  other.hapticCue_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_25:
        val_12 = 0;
        return (bool)val_12;
        label_2:
        val_12 = 1;
        return (bool)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_10;
        var val_11;
        var val_12;
        if(this.cooldown_ != null)
        {
                val_10 = this.cooldown_ ^ 1;
        }
        else
        {
                val_10 = 1;
        }
        
        if(this.activation_ != null)
        {
                val_10 = this.activation_ ^ val_10;
        }
        
        if(this.cancelTime_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        val_11 = 0;
        if(this.cancelAction_.Length != 0)
        {
                val_10 = this.cancelAction_ ^ val_10;
        }
        
        if(this.batteryDrainRateBase_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.batteryDrainRateCancel_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.blinkDuration_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.maskLightFadeTime_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        val_12 = 0;
        if(this.hapticCue_.Length != 0)
        {
                val_10 = this.hapticCue_ ^ val_10;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields ^ val_10;
        return (int)val_10;
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
        ATTACK_DATA.Types.CHANCE val_4;
        double val_5;
        string val_6;
        double val_7;
        double val_8;
        double val_9;
        double val_10;
        string val_11;
        if(this.cooldown_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.cooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.cooldown_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.activation_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.activation_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.activation_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.cancelTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_5 = this.cancelTime_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_5 = this.cancelTime_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.cancelAction_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_6 = this.cancelAction_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_6 = this.cancelAction_;
        }
        
            output.WriteString(value:  val_6);
        }
        
        if(this.batteryDrainRateBase_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_7 = this.batteryDrainRateBase_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_7 = this.batteryDrainRateBase_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.batteryDrainRateCancel_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_8 = this.batteryDrainRateCancel_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_8 = this.batteryDrainRateCancel_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.blinkDuration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_9 = this.blinkDuration_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_9 = this.blinkDuration_;
        }
        
            output.WriteDouble(value:  val_9);
        }
        
        if(this.maskLightFadeTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_10 = this.maskLightFadeTime_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_10 = this.maskLightFadeTime_;
        }
        
            output.WriteDouble(value:  val_10);
        }
        
        if(this.hapticCue_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_11 = this.hapticCue_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_11 = this.hapticCue_;
        }
        
            output.WriteString(value:  val_11);
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
        if(this.cooldown_ != null)
        {
                val_14 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cooldown_)) + 1;
        }
        else
        {
                val_14 = 0;
        }
        
        if(this.activation_ != null)
        {
                int val_3 = val_14 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.activation_));
            val_14 = val_3 + 1;
        }
        
        val_3 = val_14 + 9;
        val_14 = (this.cancelTime_ == 0f) ? (val_14) : (val_3);
        if(this.cancelAction_.Length != 0)
        {
                string val_13 = this.cancelAction_;
            int val_6 = val_14 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  val_13));
            val_15 = val_6 + 1;
        }
        
        val_6 = val_15 + 9;
        var val_7 = (this.batteryDrainRateBase_ == 0f) ? (val_15) : (val_6);
        var val_8 = val_7 + 9;
        val_7 = (this.batteryDrainRateCancel_ == 0f) ? (val_7) : (val_8);
        val_8 = val_7 + 9;
        val_7 = (this.blinkDuration_ == 0f) ? (val_7) : (val_8);
        val_8 = val_7 + 9;
        val_13 = (this.maskLightFadeTime_ == 0f) ? (val_7) : (val_8);
        if(this.hapticCue_.Length != 0)
        {
                val_16 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.hapticCue_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_16;
        }
        
        val_16 = this._unknownFields.CalculateSize() + val_16;
        return (int)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.SURGE.Types.SETTINGS other)
    {
        string val_6;
        ATTACK_DATA.Types.RANGE val_7;
        ATTACK_DATA.Types.RANGE val_8;
        ATTACK_DATA.Types.CHANCE val_9;
        ATTACK_DATA.Types.CHANCE val_10;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.cooldown_;
        if(val_7 != null)
        {
                val_8 = this.cooldown_;
            if(val_8 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_8 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.cooldown_ = val_8;
            val_7 = other.cooldown_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.activation_;
        if(val_9 != null)
        {
                val_10 = this.activation_;
            if(val_10 == null)
        {
                ATTACK_DATA.Types.CHANCE val_2 = null;
            val_10 = val_2;
            val_2 = new ATTACK_DATA.Types.CHANCE();
            this.activation_ = val_10;
            val_9 = other.activation_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        if(other.cancelTime_ != 0f)
        {
                this.cancelTime_ = other.cancelTime_;
        }
        
        if(other.cancelAction_.Length != 0)
        {
                this.CancelAction = other.cancelAction_;
        }
        
        if(other.batteryDrainRateBase_ != 0f)
        {
                this.batteryDrainRateBase_ = other.batteryDrainRateBase_;
        }
        
        if(other.batteryDrainRateCancel_ != 0f)
        {
                this.batteryDrainRateCancel_ = other.batteryDrainRateCancel_;
        }
        
        if(other.blinkDuration_ != 0f)
        {
                this.blinkDuration_ = other.blinkDuration_;
        }
        
        if(other.maskLightFadeTime_ != 0f)
        {
                this.maskLightFadeTime_ = other.maskLightFadeTime_;
        }
        
        val_6 = other.hapticCue_;
        if(val_6.Length != 0)
        {
                this.HapticCue = other.hapticCue_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.CHANCE val_12;
        goto label_34;
        label_38:
        if(41544 > 34)
        {
            goto label_2;
        }
        
        if(41544 > 18)
        {
            goto label_3;
        }
        
        if(41544 == 10)
        {
            goto label_4;
        }
        
        if(41544 != 18)
        {
            goto label_20;
        }
        
        val_12 = this.activation_;
        if(val_12 != null)
        {
            goto label_6;
        }
        
        ATTACK_DATA.Types.CHANCE val_1 = null;
        val_12 = val_1;
        val_1 = new ATTACK_DATA.Types.CHANCE();
        this.activation_ = val_12;
        if(input != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_2:
        if(41544 > 49)
        {
            goto label_9;
        }
        
        if(41544 == 41)
        {
            goto label_10;
        }
        
        if(41544 != 49)
        {
            goto label_20;
        }
        
        this.batteryDrainRateCancel_ = input.ReadDouble();
        goto label_34;
        label_3:
        if(41544 == 25)
        {
            goto label_14;
        }
        
        if(41544 != 34)
        {
            goto label_20;
        }
        
        this.CancelAction = input.ReadString();
        goto label_34;
        label_9:
        if(41544 == 57)
        {
            goto label_18;
        }
        
        if(41544 == 65)
        {
            goto label_19;
        }
        
        if(41544 != 74)
        {
            goto label_20;
        }
        
        this.HapticCue = input.ReadString();
        goto label_34;
        label_20:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_34;
        label_4:
        val_12 = this.cooldown_;
        if(val_12 == null)
        {
            goto label_24;
        }
        
        label_6:
        if(input != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        input.ReadMessage(builder:  val_12);
        goto label_34;
        label_10:
        this.batteryDrainRateBase_ = input.ReadDouble();
        goto label_34;
        label_14:
        this.cancelTime_ = input.ReadDouble();
        goto label_34;
        label_19:
        this.maskLightFadeTime_ = input.ReadDouble();
        goto label_34;
        label_18:
        this.blinkDuration_ = input.ReadDouble();
        goto label_34;
        label_24:
        this.cooldown_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        if(input.ReadTag() != 0)
        {
            goto label_38;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.SURGE.Types.SETTINGS()
    {
        null = null;
        ATTACK_DATA.Types.SURGE.Types.SETTINGS.HapticCueFieldNumber = new Google.Protobuf.MessageParser<SETTINGS>(factory:  new System.Func<SETTINGS>(object:  ATTACK_DATA.Types.SURGE.Types.SETTINGS.<>c.<>9, method:  SETTINGS ATTACK_DATA.Types.SURGE.Types.SETTINGS.<>c::<.cctor>b__65_0()));
    }

}
