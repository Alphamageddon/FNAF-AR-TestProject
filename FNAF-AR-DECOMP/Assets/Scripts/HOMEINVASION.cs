using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double min_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double max_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic1FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic2FieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic2_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic3FieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic3_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic4FieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic4_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic5FieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic5_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic6FieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic6_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic7FieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic7_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic8FieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronic8_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Min { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Max { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic3 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic4 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic5 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic6 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic7 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Animatronic8 { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<HOMEINVASION>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.Animatronic8FieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION()
    {
        this.animatronic1_ = "";
        this.animatronic2_ = "";
        this.animatronic3_ = "";
        this.animatronic4_ = "";
        this.animatronic5_ = "";
        this.animatronic6_ = "";
        this.animatronic7_ = "";
        this.animatronic8_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION other)
    {
        if(other != null)
        {
                this.min_ = other.min_;
            this.max_ = other.max_;
            this.animatronic1_ = other.animatronic1_;
            this.animatronic2_ = other.animatronic2_;
            this.animatronic3_ = other.animatronic3_;
            this.animatronic4_ = other.animatronic4_;
            this.animatronic5_ = other.animatronic5_;
            this.animatronic6_ = other.animatronic6_;
            this.animatronic7_ = other.animatronic7_;
            this.animatronic8_ = other.animatronic8_;
        }
        else
        {
                this.min_ = 7.42422564692724E-317;
            this.max_ = 3.16202013338398E-322;
            this.animatronic1_ = 69077560;
            this.animatronic2_ = 0;
            this.animatronic3_ = 4194311;
            this.animatronic4_ = 1;
            this.animatronic5_ = 0;
            this.animatronic6_ = 0;
            this.animatronic7_ = 0;
            this.animatronic8_ = 62590012;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION Clone()
    {
        return (HOMEINVASION)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Min()
    {
        return (double)this.min_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Min(double value)
    {
        this.min_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Max()
    {
        return (double)this.max_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Max(double value)
    {
        this.max_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic1()
    {
        return (string)this.animatronic1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic1(string value)
    {
        this.animatronic1_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic2()
    {
        return (string)this.animatronic2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic2(string value)
    {
        this.animatronic2_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic3()
    {
        return (string)this.animatronic3_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic3(string value)
    {
        this.animatronic3_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic4()
    {
        return (string)this.animatronic4_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic4(string value)
    {
        this.animatronic4_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic5()
    {
        return (string)this.animatronic5_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic5(string value)
    {
        this.animatronic5_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic6()
    {
        return (string)this.animatronic6_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic6(string value)
    {
        this.animatronic6_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic7()
    {
        return (string)this.animatronic7_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic7(string value)
    {
        this.animatronic7_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Animatronic8()
    {
        return (string)this.animatronic8_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic8(string value)
    {
        this.animatronic8_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        HOMEINVASION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION other)
    {
        var val_11;
        double val_12;
        var val_13;
        if(other == null)
        {
            goto label_17;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_12 = this.min_;
        val_11 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_11 & 1) != 0)
        {
                val_12 = this.max_;
            val_11 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((((((((val_11 & 1) != 0) && ((System.String.op_Inequality(a:  this.animatronic1_, b:  other.animatronic1_)) != true)) && ((System.String.op_Inequality(a:  this.animatronic2_, b:  other.animatronic2_)) != true)) && ((System.String.op_Inequality(a:  this.animatronic3_, b:  other.animatronic3_)) != true)) && ((System.String.op_Inequality(a:  this.animatronic4_, b:  other.animatronic4_)) != true)) && ((System.String.op_Inequality(a:  this.animatronic5_, b:  other.animatronic5_)) != true)) && ((System.String.op_Inequality(a:  this.animatronic6_, b:  other.animatronic6_)) != true))
        {
                if((System.String.op_Inequality(a:  this.animatronic7_, b:  other.animatronic7_)) != true)
        {
                if((System.String.op_Inequality(a:  this.animatronic8_, b:  other.animatronic8_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_17:
        val_13 = 0;
        return (bool)val_13;
        label_2:
        val_13 = 1;
        return (bool)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_11;
        var val_12;
        if(this.min_ == 0f)
        {
                val_11 = 1;
        }
        else
        {
                val_11 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.max_ != 0f)
        {
                val_11 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_11;
        }
        
        if(this.animatronic1_.Length != 0)
        {
                val_11 = this.animatronic1_ ^ val_11;
        }
        
        if(this.animatronic2_.Length != 0)
        {
                val_11 = this.animatronic2_ ^ val_11;
        }
        
        if(this.animatronic3_.Length != 0)
        {
                val_11 = this.animatronic3_ ^ val_11;
        }
        
        if(this.animatronic4_.Length != 0)
        {
                val_11 = this.animatronic4_ ^ val_11;
        }
        
        if(this.animatronic5_.Length != 0)
        {
                val_11 = this.animatronic5_ ^ val_11;
        }
        
        if(this.animatronic6_.Length != 0)
        {
                val_11 = this.animatronic6_ ^ val_11;
        }
        
        if(this.animatronic7_.Length != 0)
        {
                val_11 = this.animatronic7_ ^ val_11;
        }
        
        val_12 = 0;
        if(this.animatronic8_.Length != 0)
        {
                val_11 = this.animatronic8_ ^ val_11;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields ^ val_11;
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        double val_9;
        double val_10;
        string val_11;
        string val_12;
        string val_13;
        string val_14;
        string val_15;
        string val_16;
        string val_17;
        string val_18;
        if(this.min_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_9 = this.min_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_9 = this.min_;
        }
        
            output.WriteDouble(value:  val_9);
        }
        
        if(this.max_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_10 = this.max_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_10 = this.max_;
        }
        
            output.WriteDouble(value:  val_10);
        }
        
        if(this.animatronic1_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_11 = this.animatronic1_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_11 = this.animatronic1_;
        }
        
            output.WriteString(value:  val_11);
        }
        
        if(this.animatronic2_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_12 = this.animatronic2_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_12 = this.animatronic2_;
        }
        
            output.WriteString(value:  val_12);
        }
        
        if(this.animatronic3_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_13 = this.animatronic3_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_13 = this.animatronic3_;
        }
        
            output.WriteString(value:  val_13);
        }
        
        if(this.animatronic4_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_14 = this.animatronic4_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_14 = this.animatronic4_;
        }
        
            output.WriteString(value:  val_14);
        }
        
        if(this.animatronic5_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_15 = this.animatronic5_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_15 = this.animatronic5_;
        }
        
            output.WriteString(value:  val_15);
        }
        
        if(this.animatronic6_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_16 = this.animatronic6_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_16 = this.animatronic6_;
        }
        
            output.WriteString(value:  val_16);
        }
        
        if(this.animatronic7_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_17 = this.animatronic7_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_17 = this.animatronic7_;
        }
        
            output.WriteString(value:  val_17);
        }
        
        if(this.animatronic8_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  82);
            val_18 = this.animatronic8_;
        }
        else
        {
                0.WriteRawTag(b1:  82);
            val_18 = this.animatronic8_;
        }
        
            output.WriteString(value:  val_18);
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
        var val_29;
        var val_1 = (this.min_ == 0f) ? 0 : 9;
        if(this.animatronic1_.Length != 0)
        {
                val_29 = (((this.max_ == 0f) ? (val_1) : (val_1 + 9)) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic1_))) + 1;
        }
        
        if(this.animatronic2_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic2_))) + 1;
        }
        
        if(this.animatronic3_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic3_))) + 1;
        }
        
        if(this.animatronic4_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic4_))) + 1;
        }
        
        if(this.animatronic5_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic5_))) + 1;
        }
        
        if(this.animatronic6_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic6_))) + 1;
        }
        
        if(this.animatronic7_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic7_))) + 1;
        }
        
        if(this.animatronic8_.Length != 0)
        {
                val_29 = (val_29 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronic8_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_29;
        }
        
        val_29 = this._unknownFields.CalculateSize() + val_29;
        return (int)val_29;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.min_ != 0f)
        {
                this.min_ = other.min_;
        }
        
        if(other.max_ != 0f)
        {
                this.max_ = other.max_;
        }
        
        if(other.animatronic1_.Length != 0)
        {
                this.Animatronic1 = other.animatronic1_;
        }
        
        if(other.animatronic2_.Length != 0)
        {
                this.Animatronic2 = other.animatronic2_;
        }
        
        if(other.animatronic3_.Length != 0)
        {
                this.Animatronic3 = other.animatronic3_;
        }
        
        if(other.animatronic4_.Length != 0)
        {
                this.Animatronic4 = other.animatronic4_;
        }
        
        if(other.animatronic5_.Length != 0)
        {
                this.Animatronic5 = other.animatronic5_;
        }
        
        if(other.animatronic6_.Length != 0)
        {
                this.Animatronic6 = other.animatronic6_;
        }
        
        if(other.animatronic7_.Length != 0)
        {
                this.Animatronic7 = other.animatronic7_;
        }
        
        if(other.animatronic8_.Length != 0)
        {
                this.Animatronic8 = other.animatronic8_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_32;
        label_35:
        if(this > 42)
        {
            goto label_1;
        }
        
        if(this > 17)
        {
            goto label_2;
        }
        
        if(this == 9)
        {
            goto label_3;
        }
        
        if(this != 17)
        {
            goto label_19;
        }
        
        this.max_ = input.ReadDouble();
        goto label_32;
        label_1:
        if(this > 58)
        {
            goto label_7;
        }
        
        if(this == 50)
        {
            goto label_8;
        }
        
        if(this != 58)
        {
            goto label_19;
        }
        
        this.Animatronic5 = input.ReadString();
        goto label_32;
        label_2:
        if(this == 26)
        {
            goto label_12;
        }
        
        if(this == 34)
        {
            goto label_13;
        }
        
        if(this != 42)
        {
            goto label_19;
        }
        
        this.Animatronic3 = input.ReadString();
        goto label_32;
        label_7:
        if(this == 66)
        {
            goto label_17;
        }
        
        if(this == 74)
        {
            goto label_18;
        }
        
        if(this != 82)
        {
            goto label_19;
        }
        
        this.Animatronic8 = input.ReadString();
        goto label_32;
        label_19:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_32;
        label_3:
        this.min_ = input.ReadDouble();
        goto label_32;
        label_8:
        this.Animatronic4 = input.ReadString();
        goto label_32;
        label_12:
        this.Animatronic1 = input.ReadString();
        goto label_32;
        label_13:
        this.Animatronic2 = input.ReadString();
        goto label_32;
        label_17:
        this.Animatronic6 = input.ReadString();
        goto label_32;
        label_18:
        this.Animatronic7 = input.ReadString();
        label_32:
        if(input.ReadTag() != 0)
        {
            goto label_35;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.Animatronic8FieldNumber = new Google.Protobuf.MessageParser<HOMEINVASION>(factory:  new System.Func<HOMEINVASION>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.<>c.<>9, method:  HOMEINVASION DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.HOMEINVASION.<>c::<.cctor>b__70_0()));
    }

}
