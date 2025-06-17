using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisruptionTimerFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE disruptionTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChanceToDisruptFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chanceToDisrupt_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisruptChanceModifierFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double disruptChanceModifier_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisruptionRampUpTimerFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double disruptionRampUpTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeDurationFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shakeDuration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeMagnitudeFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shakeMagnitude_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeGraceTimeFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shakeGraceTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE DisruptionTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ChanceToDisrupt { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DisruptChanceModifier { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DisruptionRampUpTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShakeDuration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShakeMagnitude { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShakeGraceTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DISRUPTIONPARAMETERS>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.ShakeGraceTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor.NestedTypes.Item[8];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS other)
    {
        if(other.disruptionTimer_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.disruptionTimer_ = other.disruptionTimer_.Clone();
        this.chanceToDisrupt_ = other.chanceToDisrupt_;
        this.disruptChanceModifier_ = other.disruptChanceModifier_;
        this.disruptionRampUpTimer_ = other.disruptionRampUpTimer_;
        this.shakeDuration_ = other.shakeDuration_;
        this.shakeMagnitude_ = other.shakeMagnitude_;
        this.shakeGraceTime_ = other.shakeGraceTime_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS Clone()
    {
        return (DISRUPTIONPARAMETERS)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE get_DisruptionTimer()
    {
        return (DISRUPTIONRANGE)this.disruptionTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisruptionTimer(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE value)
    {
        this.disruptionTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ChanceToDisrupt()
    {
        return (double)this.chanceToDisrupt_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChanceToDisrupt(double value)
    {
        this.chanceToDisrupt_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DisruptChanceModifier()
    {
        return (double)this.disruptChanceModifier_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisruptChanceModifier(double value)
    {
        this.disruptChanceModifier_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DisruptionRampUpTimer()
    {
        return (double)this.disruptionRampUpTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisruptionRampUpTimer(double value)
    {
        this.disruptionRampUpTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShakeDuration()
    {
        return (double)this.shakeDuration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShakeDuration(double value)
    {
        this.shakeDuration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShakeMagnitude()
    {
        return (double)this.shakeMagnitude_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShakeMagnitude(double value)
    {
        this.shakeMagnitude_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShakeGraceTime()
    {
        return (double)this.shakeGraceTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShakeGraceTime(double value)
    {
        this.shakeGraceTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DISRUPTIONPARAMETERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS other)
    {
        var val_8;
        double val_9;
        var val_10;
        if(other == null)
        {
            goto label_27;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.Object.Equals(objA:  this.disruptionTimer_, objB:  other.disruptionTimer_)) != false)
        {
                val_9 = this.chanceToDisrupt_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.disruptChanceModifier_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.disruptionRampUpTimer_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.shakeDuration_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.shakeMagnitude_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.shakeGraceTime_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_27:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        val_10 = 1;
        return (bool)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_9;
        if(this.disruptionTimer_ != null)
        {
                val_9 = this.disruptionTimer_ ^ 1;
        }
        else
        {
                val_9 = 1;
        }
        
        if(this.chanceToDisrupt_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.disruptChanceModifier_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.disruptionRampUpTimer_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.shakeDuration_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.shakeMagnitude_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.shakeGraceTime_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields ^ val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        DISRUPTIONRANGE val_1;
        double val_2;
        double val_3;
        double val_4;
        double val_5;
        double val_6;
        double val_7;
        if(this.disruptionTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.disruptionTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.disruptionTimer_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.chanceToDisrupt_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.chanceToDisrupt_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.chanceToDisrupt_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.disruptChanceModifier_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.disruptChanceModifier_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.disruptChanceModifier_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.disruptionRampUpTimer_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.disruptionRampUpTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.disruptionRampUpTimer_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.shakeDuration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.shakeDuration_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.shakeDuration_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.shakeMagnitude_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.shakeMagnitude_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.shakeMagnitude_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.shakeGraceTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.shakeGraceTime_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.shakeGraceTime_;
        }
        
            output.WriteDouble(value:  val_7);
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
        var val_6;
        var val_7;
        if(this.disruptionTimer_ != null)
        {
                val_6 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.disruptionTimer_)) + 1;
        }
        else
        {
                val_6 = 0;
        }
        
        var val_2 = val_6 + 9;
        val_6 = (this.chanceToDisrupt_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        val_6 = (this.disruptChanceModifier_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        val_6 = (this.disruptionRampUpTimer_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        val_6 = (this.shakeDuration_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        val_6 = (this.shakeMagnitude_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + ((this.shakeGraceTime_ == 0f) ? (val_6) : (val_2));
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS other)
    {
        DISRUPTIONRANGE val_3;
        DISRUPTIONRANGE val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.disruptionTimer_;
        if(val_3 != null)
        {
                val_4 = this.disruptionTimer_;
            if(val_4 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE val_1 = null;
            val_4 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE();
            this.disruptionTimer_ = val_4;
            val_3 = other.disruptionTimer_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        if(other.chanceToDisrupt_ != 0f)
        {
                this.chanceToDisrupt_ = other.chanceToDisrupt_;
        }
        
        if(other.disruptChanceModifier_ != 0f)
        {
                this.disruptChanceModifier_ = other.disruptChanceModifier_;
        }
        
        if(other.disruptionRampUpTimer_ != 0f)
        {
                this.disruptionRampUpTimer_ = other.disruptionRampUpTimer_;
        }
        
        if(other.shakeDuration_ != 0f)
        {
                this.shakeDuration_ = other.shakeDuration_;
        }
        
        if(other.shakeMagnitude_ != 0f)
        {
                this.shakeMagnitude_ = other.shakeMagnitude_;
        }
        
        if(other.shakeGraceTime_ != 0f)
        {
                this.shakeGraceTime_ = other.shakeGraceTime_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_26;
        label_30:
        if(13335 > 25)
        {
            goto label_2;
        }
        
        if(13335 == 10)
        {
            goto label_3;
        }
        
        if(13335 == 17)
        {
            goto label_4;
        }
        
        if(13335 != 25)
        {
            goto label_14;
        }
        
        this.disruptChanceModifier_ = input.ReadDouble();
        goto label_26;
        label_2:
        if(13335 > 41)
        {
            goto label_8;
        }
        
        if(13335 == 33)
        {
            goto label_9;
        }
        
        if(13335 != 41)
        {
            goto label_14;
        }
        
        this.shakeDuration_ = input.ReadDouble();
        goto label_26;
        label_8:
        if(13335 == 49)
        {
            goto label_13;
        }
        
        if(13335 != 57)
        {
            goto label_14;
        }
        
        this.shakeGraceTime_ = input.ReadDouble();
        goto label_26;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_26;
        label_4:
        this.chanceToDisrupt_ = input.ReadDouble();
        goto label_26;
        label_3:
        if(this.disruptionTimer_ == null)
        {
            goto label_20;
        }
        
        label_28:
        input.ReadMessage(builder:  this.disruptionTimer_);
        goto label_26;
        label_9:
        this.disruptionRampUpTimer_ = input.ReadDouble();
        goto label_26;
        label_13:
        this.shakeMagnitude_ = input.ReadDouble();
        goto label_26;
        label_20:
        this.disruptionTimer_ = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.Types.DISRUPTIONRANGE();
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_26:
        if(input.ReadTag() != 0)
        {
            goto label_30;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.ShakeGraceTimeFieldNumber = new Google.Protobuf.MessageParser<DISRUPTIONPARAMETERS>(factory:  new System.Func<DISRUPTIONPARAMETERS>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.<>c.<>9, method:  DISRUPTIONPARAMETERS ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS.<>c::<.cctor>b__56_0()));
    }

}
