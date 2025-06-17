using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE : IMessage<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TrophyDescriptionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string trophyDescription_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FunctioningDropRateFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double functioningDropRate_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctioningDropRateFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunctioningDropRate_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string TrophyDescription { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FunctioningDropRate { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MalfunctioningDropRate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<RARE>)ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE.MalfunctioningDropRateFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.TROPHIES.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE()
    {
        this.trophyDescription_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE other)
    {
        if(other != null)
        {
                this.trophyDescription_ = other.trophyDescription_;
            this.functioningDropRate_ = other.functioningDropRate_;
            this.malfunctioningDropRate_ = other.malfunctioningDropRate_;
        }
        else
        {
                this.trophyDescription_ = 15026800;
            this.functioningDropRate_ = 3.16202013338398E-322;
            this.malfunctioningDropRate_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE Clone()
    {
        return (RARE)new ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_TrophyDescription()
    {
        return (string)this.trophyDescription_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TrophyDescription(string value)
    {
        this.trophyDescription_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FunctioningDropRate()
    {
        return (double)this.functioningDropRate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FunctioningDropRate(double value)
    {
        this.functioningDropRate_ = value;
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
        RARE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_11;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.String.op_Inequality(a:  this.trophyDescription_, b:  other.trophyDescription_)) != true)
        {
                val_5 = this.functioningDropRate_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.malfunctioningDropRate_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        if(this.trophyDescription_.Length != 0)
        {
                val_5 = this.trophyDescription_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.functioningDropRate_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.malfunctioningDropRate_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields ^ val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_2;
        double val_3;
        double val_4;
        if(this.trophyDescription_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.trophyDescription_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.trophyDescription_;
        }
        
            output.WriteString(value:  val_2);
        }
        
        if(this.functioningDropRate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_3 = this.functioningDropRate_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_3 = this.functioningDropRate_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.malfunctioningDropRate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_4 = this.malfunctioningDropRate_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_4 = this.malfunctioningDropRate_;
        }
        
            output.WriteDouble(value:  val_4);
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
        var val_7;
        var val_8;
        if(this.trophyDescription_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.trophyDescription_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        var val_3 = val_7 + 9;
        val_7 = (this.functioningDropRate_ == 0f) ? (val_7) : (val_3);
        val_3 = val_7 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + ((this.malfunctioningDropRate_ == 0f) ? (val_7) : (val_3));
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.trophyDescription_.Length != 0)
        {
                this.TrophyDescription = other.trophyDescription_;
        }
        
        if(other.functioningDropRate_ != 0f)
        {
                this.functioningDropRate_ = other.functioningDropRate_;
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
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.malfunctioningDropRate_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 10)
        {
            goto label_7;
        }
        
        this.TrophyDescription = input.ReadString();
        goto label_11;
        label_3:
        this.functioningDropRate_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE()
    {
        null = null;
        ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE.MalfunctioningDropRateFieldNumber = new Google.Protobuf.MessageParser<RARE>(factory:  new System.Func<RARE>(object:  ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE.<>c.<>9, method:  RARE ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE.<>c::<.cctor>b__35_0()));
    }

}
