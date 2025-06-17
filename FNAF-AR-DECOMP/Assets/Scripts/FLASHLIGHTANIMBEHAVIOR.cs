using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR : IMessage<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOnTimerMultFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightOnTimerMult_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightFlickerTimerMultFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightFlickerTimerMult_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOffTimerMultFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightOffTimerMult_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOffShtickMultFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightOffShtickMult_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightONRepositionValueFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightONRepositionValue_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightONIncreaseRateFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightONIncreaseRate_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOFFDecreaseRateFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightOFFDecreaseRate_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightOnTimerMult { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightFlickerTimerMult { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightOffTimerMult { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightOffShtickMult { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightONRepositionValue { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightONIncreaseRate { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightOFFDecreaseRate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FLASHLIGHTANIMBEHAVIOR>)ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR.FlashlightOFFDecreaseRateFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[13];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR(ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR other)
    {
        if(other != null)
        {
                this.flashlightOnTimerMult_ = other.flashlightOnTimerMult_;
            this.flashlightFlickerTimerMult_ = other.flashlightFlickerTimerMult_;
            this.flashlightOffTimerMult_ = other.flashlightOffTimerMult_;
            this.flashlightOffShtickMult_ = other.flashlightOffShtickMult_;
            this.flashlightONRepositionValue_ = other.flashlightONRepositionValue_;
            this.flashlightONIncreaseRate_ = other.flashlightONIncreaseRate_;
            this.flashlightOFFDecreaseRate_ = other.flashlightOFFDecreaseRate_;
        }
        else
        {
                this.flashlightOnTimerMult_ = 7.42422564692724E-317;
            this.flashlightFlickerTimerMult_ = 3.16202013338398E-322;
            this.flashlightOffTimerMult_ = 3.41288492945375E-316;
            this.flashlightOffShtickMult_ = 1.33509863819657E-307;
            this.flashlightONRepositionValue_ = 3.75487155418531E-308;
            this.flashlightONIncreaseRate_ = 1.06099789553204E-313;
            this.flashlightOFFDecreaseRate_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR Clone()
    {
        return (FLASHLIGHTANIMBEHAVIOR)new ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightOnTimerMult()
    {
        return (double)this.flashlightOnTimerMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOnTimerMult(double value)
    {
        this.flashlightOnTimerMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightFlickerTimerMult()
    {
        return (double)this.flashlightFlickerTimerMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightFlickerTimerMult(double value)
    {
        this.flashlightFlickerTimerMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightOffTimerMult()
    {
        return (double)this.flashlightOffTimerMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOffTimerMult(double value)
    {
        this.flashlightOffTimerMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightOffShtickMult()
    {
        return (double)this.flashlightOffShtickMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOffShtickMult(double value)
    {
        this.flashlightOffShtickMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightONRepositionValue()
    {
        return (double)this.flashlightONRepositionValue_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightONRepositionValue(double value)
    {
        this.flashlightONRepositionValue_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightONIncreaseRate()
    {
        return (double)this.flashlightONIncreaseRate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightONIncreaseRate(double value)
    {
        this.flashlightONIncreaseRate_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightOFFDecreaseRate()
    {
        return (double)this.flashlightOFFDecreaseRate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOFFDecreaseRate(double value)
    {
        this.flashlightOFFDecreaseRate_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FLASHLIGHTANIMBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR other)
    {
        var val_8;
        double val_9;
        var val_10;
        if(other == null)
        {
            goto label_30;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_9 = this.flashlightOnTimerMult_;
        val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightFlickerTimerMult_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightOffTimerMult_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightOffShtickMult_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightONRepositionValue_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightONIncreaseRate_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.flashlightOFFDecreaseRate_;
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
        
        label_30:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        val_10 = 1;
        return (bool)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_8;
        if(this.flashlightOnTimerMult_ == 0f)
        {
                val_8 = 1;
        }
        else
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.flashlightFlickerTimerMult_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.flashlightOffTimerMult_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.flashlightOffShtickMult_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.flashlightONRepositionValue_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.flashlightONIncreaseRate_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.flashlightOFFDecreaseRate_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
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
        double val_1;
        double val_2;
        double val_3;
        double val_4;
        double val_5;
        double val_6;
        double val_7;
        if(this.flashlightOnTimerMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.flashlightOnTimerMult_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.flashlightOnTimerMult_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.flashlightFlickerTimerMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.flashlightFlickerTimerMult_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.flashlightFlickerTimerMult_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.flashlightOffTimerMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.flashlightOffTimerMult_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.flashlightOffTimerMult_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.flashlightOffShtickMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.flashlightOffShtickMult_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.flashlightOffShtickMult_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.flashlightONRepositionValue_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.flashlightONRepositionValue_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.flashlightONRepositionValue_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.flashlightONIncreaseRate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.flashlightONIncreaseRate_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.flashlightONIncreaseRate_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.flashlightOFFDecreaseRate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.flashlightOFFDecreaseRate_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.flashlightOFFDecreaseRate_;
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
        var val_5;
        var val_1 = (this.flashlightOnTimerMult_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.flashlightFlickerTimerMult_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.flashlightOffTimerMult_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.flashlightOffShtickMult_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.flashlightONRepositionValue_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.flashlightONIncreaseRate_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.flashlightOFFDecreaseRate_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.flashlightOnTimerMult_ != 0f)
        {
                this.flashlightOnTimerMult_ = other.flashlightOnTimerMult_;
        }
        
        if(other.flashlightFlickerTimerMult_ != 0f)
        {
                this.flashlightFlickerTimerMult_ = other.flashlightFlickerTimerMult_;
        }
        
        if(other.flashlightOffTimerMult_ != 0f)
        {
                this.flashlightOffTimerMult_ = other.flashlightOffTimerMult_;
        }
        
        if(other.flashlightOffShtickMult_ != 0f)
        {
                this.flashlightOffShtickMult_ = other.flashlightOffShtickMult_;
        }
        
        if(other.flashlightONRepositionValue_ != 0f)
        {
                this.flashlightONRepositionValue_ = other.flashlightONRepositionValue_;
        }
        
        if(other.flashlightONIncreaseRate_ != 0f)
        {
                this.flashlightONIncreaseRate_ = other.flashlightONIncreaseRate_;
        }
        
        if(other.flashlightOFFDecreaseRate_ != 0f)
        {
                this.flashlightOFFDecreaseRate_ = other.flashlightOFFDecreaseRate_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_22;
        label_25:
        if(this > 25)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this == 17)
        {
            goto label_3;
        }
        
        if(this != 25)
        {
            goto label_13;
        }
        
        this.flashlightOffTimerMult_ = input.ReadDouble();
        goto label_22;
        label_1:
        if(this > 41)
        {
            goto label_7;
        }
        
        if(this == 33)
        {
            goto label_8;
        }
        
        if(this != 41)
        {
            goto label_13;
        }
        
        this.flashlightONRepositionValue_ = input.ReadDouble();
        goto label_22;
        label_7:
        if(this == 49)
        {
            goto label_12;
        }
        
        if(this != 57)
        {
            goto label_13;
        }
        
        this.flashlightOFFDecreaseRate_ = input.ReadDouble();
        goto label_22;
        label_13:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_22;
        label_2:
        this.flashlightOnTimerMult_ = input.ReadDouble();
        goto label_22;
        label_3:
        this.flashlightFlickerTimerMult_ = input.ReadDouble();
        goto label_22;
        label_8:
        this.flashlightOffShtickMult_ = input.ReadDouble();
        goto label_22;
        label_12:
        this.flashlightONIncreaseRate_ = input.ReadDouble();
        label_22:
        if(input.ReadTag() != 0)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR()
    {
        null = null;
        ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR.FlashlightOFFDecreaseRateFieldNumber = new Google.Protobuf.MessageParser<FLASHLIGHTANIMBEHAVIOR>(factory:  new System.Func<FLASHLIGHTANIMBEHAVIOR>(object:  ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR.<>c.<>9, method:  FLASHLIGHTANIMBEHAVIOR ANIMATRONIC_DATA.Types.FLASHLIGHTANIMBEHAVIOR.<>c::<.cctor>b__55_0()));
    }

}
