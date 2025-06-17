using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PeriodFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double period_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnChanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CooldownFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double cooldown_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Period { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Cooldown { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHANTASM>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.CooldownFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM other)
    {
        if(other != null)
        {
                this.period_ = other.period_;
            this.spawnChance_ = other.spawnChance_;
            this.cooldown_ = other.cooldown_;
        }
        else
        {
                this.period_ = 7.42422564692724E-317;
            this.spawnChance_ = 3.16202013338398E-322;
            this.cooldown_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM Clone()
    {
        return (PHANTASM)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Period()
    {
        return (double)this.period_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Period(double value)
    {
        this.period_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SpawnChance()
    {
        return (double)this.spawnChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnChance(double value)
    {
        this.spawnChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Cooldown()
    {
        return (double)this.cooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Cooldown(double value)
    {
        this.cooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHANTASM val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM other)
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
        
        val_5 = this.period_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.spawnChance_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.cooldown_;
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
        if(this.period_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.spawnChance_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.cooldown_ != 0f)
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
        if(this.period_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.period_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.period_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.spawnChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.spawnChance_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.spawnChance_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.cooldown_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.cooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.cooldown_;
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
        var val_1 = (this.period_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.spawnChance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.cooldown_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.period_ != 0f)
        {
                this.period_ = other.period_;
        }
        
        if(other.spawnChance_ != 0f)
        {
                this.spawnChance_ = other.spawnChance_;
        }
        
        if(other.cooldown_ != 0f)
        {
                this.cooldown_ = other.cooldown_;
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
        
        this.cooldown_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.period_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.spawnChance_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.CooldownFieldNumber = new Google.Protobuf.MessageParser<PHANTASM>(factory:  new System.Func<PHANTASM>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.<>c.<>9, method:  PHANTASM CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM.<>c::<.cctor>b__35_0()));
    }

}
