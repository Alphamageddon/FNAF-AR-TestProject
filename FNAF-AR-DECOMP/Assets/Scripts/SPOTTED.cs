using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED : IMessage<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NotUpgradedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double notUpgraded_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade1FieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double upgrade1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade2FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double upgrade2_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double min_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double max_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NotUpgraded { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Upgrade1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Upgrade2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Min { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Max { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SPOTTED>)ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED.MaxFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED other)
    {
        if(other != null)
        {
                this.notUpgraded_ = other.notUpgraded_;
            this.upgrade1_ = other.upgrade1_;
            this.upgrade2_ = other.upgrade2_;
            this.min_ = other.min_;
            this.max_ = other.max_;
        }
        else
        {
                this.notUpgraded_ = 7.42422564692724E-317;
            this.upgrade1_ = 3.16202013338398E-322;
            this.upgrade2_ = 3.41288492945375E-316;
            this.min_ = 1.33509863819657E-307;
            this.max_ = 3.75487155418531E-308;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED Clone()
    {
        return (SPOTTED)new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NotUpgraded()
    {
        return (double)this.notUpgraded_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NotUpgraded(double value)
    {
        this.notUpgraded_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Upgrade1()
    {
        return (double)this.upgrade1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade1(double value)
    {
        this.upgrade1_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Upgrade2()
    {
        return (double)this.upgrade2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade2(double value)
    {
        this.upgrade2_ = value;
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
    public override bool Equals(object other)
    {
        SPOTTED val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED other)
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
        
        val_7 = this.notUpgraded_;
        val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_6 & 1) != 0)
        {
                val_7 = this.upgrade1_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.upgrade2_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.min_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.max_;
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
        if(this.notUpgraded_ == 0f)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.upgrade1_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.upgrade2_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.min_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.max_ != 0f)
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
        if(this.notUpgraded_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.notUpgraded_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.notUpgraded_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.upgrade1_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.upgrade1_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.upgrade1_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.upgrade2_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.upgrade2_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.upgrade2_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.min_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.min_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.min_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.max_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.max_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.max_;
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
        var val_1 = (this.notUpgraded_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.upgrade1_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.upgrade2_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.min_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.max_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.notUpgraded_ != 0f)
        {
                this.notUpgraded_ = other.notUpgraded_;
        }
        
        if(other.upgrade1_ != 0f)
        {
                this.upgrade1_ = other.upgrade1_;
        }
        
        if(other.upgrade2_ != 0f)
        {
                this.upgrade2_ = other.upgrade2_;
        }
        
        if(other.min_ != 0f)
        {
                this.min_ = other.min_;
        }
        
        if(other.max_ != 0f)
        {
                this.max_ = other.max_;
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
        
        this.upgrade1_ = input.ReadDouble();
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
        
        this.max_ = input.ReadDouble();
        goto label_15;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_15;
        label_2:
        this.notUpgraded_ = input.ReadDouble();
        goto label_15;
        label_7:
        this.min_ = input.ReadDouble();
        goto label_15;
        label_6:
        this.upgrade2_ = input.ReadDouble();
        label_15:
        if(input.ReadTag() != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED()
    {
        null = null;
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED.MaxFieldNumber = new Google.Protobuf.MessageParser<SPOTTED>(factory:  new System.Func<SPOTTED>(object:  ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED.<>c.<>9, method:  SPOTTED ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED.<>c::<.cctor>b__45_0()));
    }

}
