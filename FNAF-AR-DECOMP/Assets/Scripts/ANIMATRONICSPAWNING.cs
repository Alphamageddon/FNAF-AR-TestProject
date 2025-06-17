using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnPeriodFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnPeriod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnChanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnMaxDeployedFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnMaxDeployed_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapSpawnPeriodFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double mapSpawnPeriod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapSpawnChanceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double mapSpawnChance_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnPeriod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnMaxDeployed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MapSpawnPeriod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MapSpawnChance { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ANIMATRONICSPAWNING>)CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.MapSpawnChanceFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[7];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING other)
    {
        if(other != null)
        {
                this.spawnPeriod_ = other.spawnPeriod_;
            this.spawnChance_ = other.spawnChance_;
            this.spawnMaxDeployed_ = other.spawnMaxDeployed_;
            this.mapSpawnPeriod_ = other.mapSpawnPeriod_;
            this.mapSpawnChance_ = other.mapSpawnChance_;
        }
        else
        {
                this.spawnPeriod_ = 7.42422564692724E-317;
            this.spawnChance_ = 3.16202013338398E-322;
            this.spawnMaxDeployed_ = 3.41288492945375E-316;
            this.mapSpawnPeriod_ = 1.33509863819657E-307;
            this.mapSpawnChance_ = 3.75487155418531E-308;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING Clone()
    {
        return (ANIMATRONICSPAWNING)new CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SpawnPeriod()
    {
        return (double)this.spawnPeriod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnPeriod(double value)
    {
        this.spawnPeriod_ = value;
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
    public double get_SpawnMaxDeployed()
    {
        return (double)this.spawnMaxDeployed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnMaxDeployed(double value)
    {
        this.spawnMaxDeployed_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MapSpawnPeriod()
    {
        return (double)this.mapSpawnPeriod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapSpawnPeriod(double value)
    {
        this.mapSpawnPeriod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MapSpawnChance()
    {
        return (double)this.mapSpawnChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapSpawnChance(double value)
    {
        this.mapSpawnChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ANIMATRONICSPAWNING val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING other)
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
        
        val_7 = this.spawnPeriod_;
        val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_6 & 1) != 0)
        {
                val_7 = this.spawnChance_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.spawnMaxDeployed_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.mapSpawnPeriod_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.mapSpawnChance_;
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
        if(this.spawnPeriod_ == 0f)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.spawnChance_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.spawnMaxDeployed_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.mapSpawnPeriod_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.mapSpawnChance_ != 0f)
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
        if(this.spawnPeriod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.spawnPeriod_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.spawnPeriod_;
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
        
        if(this.spawnMaxDeployed_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.spawnMaxDeployed_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.spawnMaxDeployed_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.mapSpawnPeriod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.mapSpawnPeriod_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.mapSpawnPeriod_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.mapSpawnChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.mapSpawnChance_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.mapSpawnChance_;
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
        var val_1 = (this.spawnPeriod_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.spawnChance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.spawnMaxDeployed_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.mapSpawnPeriod_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.mapSpawnChance_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.spawnPeriod_ != 0f)
        {
                this.spawnPeriod_ = other.spawnPeriod_;
        }
        
        if(other.spawnChance_ != 0f)
        {
                this.spawnChance_ = other.spawnChance_;
        }
        
        if(other.spawnMaxDeployed_ != 0f)
        {
                this.spawnMaxDeployed_ = other.spawnMaxDeployed_;
        }
        
        if(other.mapSpawnPeriod_ != 0f)
        {
                this.mapSpawnPeriod_ = other.mapSpawnPeriod_;
        }
        
        if(other.mapSpawnChance_ != 0f)
        {
                this.mapSpawnChance_ = other.mapSpawnChance_;
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
        
        this.spawnChance_ = input.ReadDouble();
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
        
        this.mapSpawnChance_ = input.ReadDouble();
        goto label_15;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_15;
        label_2:
        this.spawnPeriod_ = input.ReadDouble();
        goto label_15;
        label_7:
        this.mapSpawnPeriod_ = input.ReadDouble();
        goto label_15;
        label_6:
        this.spawnMaxDeployed_ = input.ReadDouble();
        label_15:
        if(input.ReadTag() != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.MapSpawnChanceFieldNumber = new Google.Protobuf.MessageParser<ANIMATRONICSPAWNING>(factory:  new System.Func<ANIMATRONICSPAWNING>(object:  CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.<>c.<>9, method:  ANIMATRONICSPAWNING CONFIG_DATA.Types.ENTRY.Types.ANIMATRONICSPAWNING.<>c::<.cctor>b__45_0()));
    }

}
