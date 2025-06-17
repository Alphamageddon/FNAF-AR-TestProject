using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES : IMessage<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES>, IMessage, IEquatable<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES>, IDeepCloneable<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double essence_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctionFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunction_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryMultFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryMult_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RareRewardChanceFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rareRewardChance_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Essence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Malfunction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryMult { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RareRewardChance { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ESSENCEVALUES>)ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.RareRewardChanceFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ESSENCE_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES(ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES other)
    {
        if(other != null)
        {
                this.essence_ = other.essence_;
            this.malfunction_ = other.malfunction_;
            this.batteryMult_ = other.batteryMult_;
            this.rareRewardChance_ = other.rareRewardChance_;
        }
        else
        {
                this.essence_ = 7.42422564692724E-317;
            this.malfunction_ = 3.16202013338398E-322;
            this.batteryMult_ = 3.41288492945375E-316;
            this.rareRewardChance_ = 1.33509863819657E-307;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES Clone()
    {
        return (ESSENCEVALUES)new ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Essence()
    {
        return (double)this.essence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Essence(double value)
    {
        this.essence_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Malfunction()
    {
        return (double)this.malfunction_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Malfunction(double value)
    {
        this.malfunction_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryMult()
    {
        return (double)this.batteryMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryMult(double value)
    {
        this.batteryMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RareRewardChance()
    {
        return (double)this.rareRewardChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RareRewardChance(double value)
    {
        this.rareRewardChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ESSENCEVALUES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES other)
    {
        var val_5;
        double val_6;
        var val_7;
        if(other == null)
        {
            goto label_18;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_6 = this.essence_;
        val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_5 & 1) != 0)
        {
                val_6 = this.malfunction_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.batteryMult_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.rareRewardChance_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.essence_ == 0f)
        {
                val_5 = 1;
        }
        else
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.malfunction_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.batteryMult_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.rareRewardChance_ != 0f)
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
        double val_1;
        double val_2;
        double val_3;
        double val_4;
        if(this.essence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.essence_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.essence_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.malfunction_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.malfunction_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.malfunction_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.batteryMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.batteryMult_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.batteryMult_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.rareRewardChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.rareRewardChance_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.rareRewardChance_;
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
        var val_5;
        var val_1 = (this.essence_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.malfunction_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryMult_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.rareRewardChance_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.essence_ != 0f)
        {
                this.essence_ = other.essence_;
        }
        
        if(other.malfunction_ != 0f)
        {
                this.malfunction_ = other.malfunction_;
        }
        
        if(other.batteryMult_ != 0f)
        {
                this.batteryMult_ = other.batteryMult_;
        }
        
        if(other.rareRewardChance_ != 0f)
        {
                this.rareRewardChance_ = other.rareRewardChance_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
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
            goto label_7;
        }
        
        this.malfunction_ = input.ReadDouble();
        goto label_12;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this != 33)
        {
            goto label_7;
        }
        
        this.rareRewardChance_ = input.ReadDouble();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.essence_ = input.ReadDouble();
        goto label_12;
        label_6:
        this.batteryMult_ = input.ReadDouble();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES()
    {
        null = null;
        ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.RareRewardChanceFieldNumber = new Google.Protobuf.MessageParser<ESSENCEVALUES>(factory:  new System.Func<ESSENCEVALUES>(object:  ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.<>c.<>9, method:  ESSENCEVALUES ESSENCE_DATA.Types.ENTRY.Types.ESSENCEVALUES.<>c::<.cctor>b__40_0()));
    }

}
