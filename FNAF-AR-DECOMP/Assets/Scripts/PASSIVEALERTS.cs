using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PassiveAlertPeriodSecFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double passiveAlertPeriodSec_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PassiveAlertCheckChanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double passiveAlertCheckChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PassiveAlertCooldownSecFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double passiveAlertCooldownSec_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PassiveAlertPeriodSec { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PassiveAlertCheckChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PassiveAlertCooldownSec { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PASSIVEALERTS>)CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.PassiveAlertCooldownSecFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS other)
    {
        if(other != null)
        {
                this.passiveAlertPeriodSec_ = other.passiveAlertPeriodSec_;
            this.passiveAlertCheckChance_ = other.passiveAlertCheckChance_;
            this.passiveAlertCooldownSec_ = other.passiveAlertCooldownSec_;
        }
        else
        {
                this.passiveAlertPeriodSec_ = 7.42422564692724E-317;
            this.passiveAlertCheckChance_ = 3.16202013338398E-322;
            this.passiveAlertCooldownSec_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS Clone()
    {
        return (PASSIVEALERTS)new CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PassiveAlertPeriodSec()
    {
        return (double)this.passiveAlertPeriodSec_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PassiveAlertPeriodSec(double value)
    {
        this.passiveAlertPeriodSec_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PassiveAlertCheckChance()
    {
        return (double)this.passiveAlertCheckChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PassiveAlertCheckChance(double value)
    {
        this.passiveAlertCheckChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PassiveAlertCooldownSec()
    {
        return (double)this.passiveAlertCooldownSec_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PassiveAlertCooldownSec(double value)
    {
        this.passiveAlertCooldownSec_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PASSIVEALERTS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS other)
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
        
        val_5 = this.passiveAlertPeriodSec_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.passiveAlertCheckChance_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.passiveAlertCooldownSec_;
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
        if(this.passiveAlertPeriodSec_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.passiveAlertCheckChance_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.passiveAlertCooldownSec_ != 0f)
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
        if(this.passiveAlertPeriodSec_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.passiveAlertPeriodSec_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.passiveAlertPeriodSec_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.passiveAlertCheckChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.passiveAlertCheckChance_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.passiveAlertCheckChance_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.passiveAlertCooldownSec_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.passiveAlertCooldownSec_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.passiveAlertCooldownSec_;
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
        var val_1 = (this.passiveAlertPeriodSec_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.passiveAlertCheckChance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.passiveAlertCooldownSec_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.passiveAlertPeriodSec_ != 0f)
        {
                this.passiveAlertPeriodSec_ = other.passiveAlertPeriodSec_;
        }
        
        if(other.passiveAlertCheckChance_ != 0f)
        {
                this.passiveAlertCheckChance_ = other.passiveAlertCheckChance_;
        }
        
        if(other.passiveAlertCooldownSec_ != 0f)
        {
                this.passiveAlertCooldownSec_ = other.passiveAlertCooldownSec_;
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
        
        this.passiveAlertCooldownSec_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.passiveAlertPeriodSec_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.passiveAlertCheckChance_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.PassiveAlertCooldownSecFieldNumber = new Google.Protobuf.MessageParser<PASSIVEALERTS>(factory:  new System.Func<PASSIVEALERTS>(object:  CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.<>c.<>9, method:  PASSIVEALERTS CONFIG_DATA.Types.ENTRY.Types.PASSIVEALERTS.<>c::<.cctor>b__35_0()));
    }

}
