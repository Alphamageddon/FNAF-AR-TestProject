using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF : IMessage<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF> _parser;
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
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF> Parser { get; }
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
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SELF>)ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF.Upgrade2FieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF other)
    {
        if(other != null)
        {
                this.notUpgraded_ = other.notUpgraded_;
            this.upgrade1_ = other.upgrade1_;
            this.upgrade2_ = other.upgrade2_;
        }
        else
        {
                this.notUpgraded_ = 7.42422564692724E-317;
            this.upgrade1_ = 3.16202013338398E-322;
            this.upgrade2_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF Clone()
    {
        return (SELF)new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF(other:  this);
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
    public override bool Equals(object other)
    {
        SELF val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.notUpgraded_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.upgrade1_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.upgrade2_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_14:
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
        if(this.notUpgraded_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.upgrade1_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.upgrade2_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
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
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.upgrade2_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF other)
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
        
        this.upgrade2_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.notUpgraded_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.upgrade1_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF()
    {
        null = null;
        ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF.Upgrade2FieldNumber = new Google.Protobuf.MessageParser<SELF>(factory:  new System.Func<SELF>(object:  ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF.<>c.<>9, method:  SELF ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF.<>c::<.cctor>b__35_0()));
    }

}
