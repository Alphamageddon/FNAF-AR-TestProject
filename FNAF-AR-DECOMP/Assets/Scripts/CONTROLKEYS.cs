using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.CONTROLKEYS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TotalNumberOfControlKeysFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double totalNumberOfControlKeys_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NumberToTakeControlOfAnimatronicFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double numberToTakeControlOfAnimatronic_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NumberToGetUpgrade1BenefitsFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double numberToGetUpgrade1Benefits_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NumberToGetUpgrade2BenefitsFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double numberToGetUpgrade2Benefits_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctioningDropRateFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunctioningDropRate_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double TotalNumberOfControlKeys { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NumberToTakeControlOfAnimatronic { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NumberToGetUpgrade1Benefits { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NumberToGetUpgrade2Benefits { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MalfunctioningDropRate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CONTROLKEYS>)ANIMATRONIC_DATA.Types.CONTROLKEYS.MalfunctioningDropRateFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.CONTROLKEYS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.CONTROLKEYS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.CONTROLKEYS(ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS other)
    {
        if(other != null)
        {
                this.totalNumberOfControlKeys_ = other.totalNumberOfControlKeys_;
            this.numberToTakeControlOfAnimatronic_ = other.numberToTakeControlOfAnimatronic_;
            this.numberToGetUpgrade1Benefits_ = other.numberToGetUpgrade1Benefits_;
            this.numberToGetUpgrade2Benefits_ = other.numberToGetUpgrade2Benefits_;
            this.malfunctioningDropRate_ = other.malfunctioningDropRate_;
        }
        else
        {
                this.totalNumberOfControlKeys_ = 7.42422564692724E-317;
            this.numberToTakeControlOfAnimatronic_ = 3.16202013338398E-322;
            this.numberToGetUpgrade1Benefits_ = 3.41288492945375E-316;
            this.numberToGetUpgrade2Benefits_ = 1.33509863819657E-307;
            this.malfunctioningDropRate_ = 3.75487155418531E-308;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS Clone()
    {
        return (CONTROLKEYS)new ANIMATRONIC_DATA.Types.CONTROLKEYS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_TotalNumberOfControlKeys()
    {
        return (double)this.totalNumberOfControlKeys_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TotalNumberOfControlKeys(double value)
    {
        this.totalNumberOfControlKeys_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NumberToTakeControlOfAnimatronic()
    {
        return (double)this.numberToTakeControlOfAnimatronic_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NumberToTakeControlOfAnimatronic(double value)
    {
        this.numberToTakeControlOfAnimatronic_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NumberToGetUpgrade1Benefits()
    {
        return (double)this.numberToGetUpgrade1Benefits_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NumberToGetUpgrade1Benefits(double value)
    {
        this.numberToGetUpgrade1Benefits_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NumberToGetUpgrade2Benefits()
    {
        return (double)this.numberToGetUpgrade2Benefits_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NumberToGetUpgrade2Benefits(double value)
    {
        this.numberToGetUpgrade2Benefits_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MalfunctioningDropRate()
    {
        return (double)this.malfunctioningDropRate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MalfunctioningDropRate(double value)
    {
        this.malfunctioningDropRate_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CONTROLKEYS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS other)
    {
        var val_6;
        double val_7;
        var val_8;
        if(other == null)
        {
            goto label_22;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_7 = this.totalNumberOfControlKeys_;
        val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_6 & 1) != 0)
        {
                val_7 = this.numberToTakeControlOfAnimatronic_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.numberToGetUpgrade1Benefits_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.numberToGetUpgrade2Benefits_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.malfunctioningDropRate_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        label_22:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 1;
        return (bool)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_6;
        if(this.totalNumberOfControlKeys_ == 0f)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.numberToTakeControlOfAnimatronic_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.numberToGetUpgrade1Benefits_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.numberToGetUpgrade2Benefits_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.malfunctioningDropRate_ != 0f)
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
        double val_1;
        double val_2;
        double val_3;
        double val_4;
        double val_5;
        if(this.totalNumberOfControlKeys_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.totalNumberOfControlKeys_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.totalNumberOfControlKeys_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.numberToTakeControlOfAnimatronic_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.numberToTakeControlOfAnimatronic_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.numberToTakeControlOfAnimatronic_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.numberToGetUpgrade1Benefits_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.numberToGetUpgrade1Benefits_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.numberToGetUpgrade1Benefits_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.numberToGetUpgrade2Benefits_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.numberToGetUpgrade2Benefits_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.numberToGetUpgrade2Benefits_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.malfunctioningDropRate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.malfunctioningDropRate_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.malfunctioningDropRate_;
        }
        
            output.WriteDouble(value:  val_5);
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
        var val_1 = (this.totalNumberOfControlKeys_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.numberToTakeControlOfAnimatronic_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.numberToGetUpgrade1Benefits_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.numberToGetUpgrade2Benefits_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.malfunctioningDropRate_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.CONTROLKEYS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.totalNumberOfControlKeys_ != 0f)
        {
                this.totalNumberOfControlKeys_ = other.totalNumberOfControlKeys_;
        }
        
        if(other.numberToTakeControlOfAnimatronic_ != 0f)
        {
                this.numberToTakeControlOfAnimatronic_ = other.numberToTakeControlOfAnimatronic_;
        }
        
        if(other.numberToGetUpgrade1Benefits_ != 0f)
        {
                this.numberToGetUpgrade1Benefits_ = other.numberToGetUpgrade1Benefits_;
        }
        
        if(other.numberToGetUpgrade2Benefits_ != 0f)
        {
                this.numberToGetUpgrade2Benefits_ = other.numberToGetUpgrade2Benefits_;
        }
        
        if(other.malfunctioningDropRate_ != 0f)
        {
                this.malfunctioningDropRate_ = other.malfunctioningDropRate_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_15;
        label_18:
        if(this > 17)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this != 17)
        {
            goto label_8;
        }
        
        this.numberToTakeControlOfAnimatronic_ = input.ReadDouble();
        goto label_15;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this == 33)
        {
            goto label_7;
        }
        
        if(this != 41)
        {
            goto label_8;
        }
        
        this.malfunctioningDropRate_ = input.ReadDouble();
        goto label_15;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_15;
        label_2:
        this.totalNumberOfControlKeys_ = input.ReadDouble();
        goto label_15;
        label_7:
        this.numberToGetUpgrade2Benefits_ = input.ReadDouble();
        goto label_15;
        label_6:
        this.numberToGetUpgrade1Benefits_ = input.ReadDouble();
        label_15:
        if(input.ReadTag() != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.CONTROLKEYS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.CONTROLKEYS.MalfunctioningDropRateFieldNumber = new Google.Protobuf.MessageParser<CONTROLKEYS>(factory:  new System.Func<CONTROLKEYS>(object:  ANIMATRONIC_DATA.Types.CONTROLKEYS.<>c.<>9, method:  CONTROLKEYS ANIMATRONIC_DATA.Types.CONTROLKEYS.<>c::<.cctor>b__45_0()));
    }

}
