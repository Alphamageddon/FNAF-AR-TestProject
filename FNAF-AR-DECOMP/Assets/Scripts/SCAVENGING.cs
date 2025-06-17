using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.SCAVENGING : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxDeployedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxDeployed_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PeriodFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double period_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctionFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunction_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WearAndTearChanceFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double wearAndTearChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WearAndTearDamageFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE wearAndTearDamage_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RareRewardChanceFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rareRewardChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PlushSuitChanceFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double plushSuitChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CommonRewardChanceFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double commonRewardChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS parts_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxDeployed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Period { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Malfunction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double WearAndTearChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE WearAndTearDamage { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RareRewardChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PlushSuitChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CommonRewardChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS Parts { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SCAVENGING>)CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.PartsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[9];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.SCAVENGING()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.SCAVENGING(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING other)
    {
        WEARANDTEARDAMAGE val_4;
        PARTS val_5;
        if(other != null)
        {
                this.maxDeployed_ = other.maxDeployed_;
            this.period_ = other.period_;
            this.malfunction_ = other.malfunction_;
            this.wearAndTearChance_ = other.wearAndTearChance_;
        }
        else
        {
                this.maxDeployed_ = 7.42422564692724E-317;
            this.period_ = 3.16202013338398E-322;
            this.malfunction_ = 3.41288492945375E-316;
            this.wearAndTearChance_ = 1.33509863819657E-307;
        }
        
        val_4 = other.wearAndTearDamage_;
        this.wearAndTearDamage_ = val_4.Clone();
        this.rareRewardChance_ = other.rareRewardChance_;
        this.plushSuitChance_ = other.plushSuitChance_;
        this.commonRewardChance_ = other.commonRewardChance_;
        val_5 = other.parts_;
        this.parts_ = val_5.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING Clone()
    {
        return (SCAVENGING)new CONFIG_DATA.Types.ENTRY.Types.SCAVENGING(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxDeployed()
    {
        return (double)this.maxDeployed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxDeployed(double value)
    {
        this.maxDeployed_ = value;
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
    public double get_WearAndTearChance()
    {
        return (double)this.wearAndTearChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WearAndTearChance(double value)
    {
        this.wearAndTearChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE get_WearAndTearDamage()
    {
        return (WEARANDTEARDAMAGE)this.wearAndTearDamage_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WearAndTearDamage(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE value)
    {
        this.wearAndTearDamage_ = value;
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
    public double get_PlushSuitChance()
    {
        return (double)this.plushSuitChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PlushSuitChance(double value)
    {
        this.plushSuitChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CommonRewardChance()
    {
        return (double)this.commonRewardChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CommonRewardChance(double value)
    {
        this.commonRewardChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS get_Parts()
    {
        return (PARTS)this.parts_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Parts(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS value)
    {
        this.parts_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SCAVENGING val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING other)
    {
        var val_10;
        double val_11;
        var val_12;
        if(other == null)
        {
            goto label_32;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_11 = this.maxDeployed_;
        val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_10 & 1) != 0)
        {
                val_11 = this.period_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.malfunction_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.wearAndTearChance_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if(((val_10 & 1) != 0) && ((System.Object.Equals(objA:  this.wearAndTearDamage_, objB:  other.wearAndTearDamage_)) != false))
        {
                val_11 = this.rareRewardChance_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.plushSuitChance_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.commonRewardChance_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                if((System.Object.Equals(objA:  this.parts_, objB:  other.parts_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_32:
        val_12 = 0;
        return (bool)val_12;
        label_2:
        val_12 = 1;
        return (bool)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_8;
        if(this.maxDeployed_ == 0f)
        {
                val_8 = 1;
        }
        else
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.period_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.malfunction_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.wearAndTearChance_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.wearAndTearDamage_ != null)
        {
                val_8 = this.wearAndTearDamage_ ^ val_8;
        }
        
        if(this.rareRewardChance_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.plushSuitChance_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.commonRewardChance_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.parts_ != null)
        {
                val_8 = this.parts_ ^ val_8;
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
        WEARANDTEARDAMAGE val_5;
        double val_6;
        double val_7;
        double val_8;
        PARTS val_9;
        if(this.maxDeployed_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.maxDeployed_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.maxDeployed_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.period_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.period_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.period_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.malfunction_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.malfunction_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.malfunction_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.wearAndTearChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.wearAndTearChance_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.wearAndTearChance_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.wearAndTearDamage_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.wearAndTearDamage_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.wearAndTearDamage_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.rareRewardChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.rareRewardChance_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.rareRewardChance_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.plushSuitChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.plushSuitChance_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.plushSuitChance_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.commonRewardChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.commonRewardChance_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.commonRewardChance_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.parts_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_9 = this.parts_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_9 = this.parts_;
        }
        
            output.WriteMessage(value:  val_9);
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
        var val_10;
        var val_11;
        WEARANDTEARDAMAGE val_10 = this.wearAndTearDamage_;
        var val_1 = (this.maxDeployed_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.period_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.malfunction_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(val_10 != null)
        {
                int val_5 = ((this.wearAndTearChance_ == 0f) ? (val_1) : (val_2)) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_10));
            val_10 = val_5 + 1;
        }
        
        val_5 = val_10 + 9;
        var val_6 = (this.rareRewardChance_ == 0f) ? (val_10) : (val_5);
        val_2 = val_6 + 9;
        val_6 = (this.plushSuitChance_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        val_10 = (this.commonRewardChance_ == 0f) ? (val_6) : (val_2);
        if(this.parts_ != null)
        {
                val_11 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.parts_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields.CalculateSize() + val_11;
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SCAVENGING other)
    {
        PARTS val_4;
        WEARANDTEARDAMAGE val_5;
        WEARANDTEARDAMAGE val_6;
        PARTS val_7;
        if(other == null)
        {
                return;
        }
        
        if(other.maxDeployed_ != 0f)
        {
                this.maxDeployed_ = other.maxDeployed_;
        }
        
        if(other.period_ != 0f)
        {
                this.period_ = other.period_;
        }
        
        if(other.malfunction_ != 0f)
        {
                this.malfunction_ = other.malfunction_;
        }
        
        if(other.wearAndTearChance_ != 0f)
        {
                this.wearAndTearChance_ = other.wearAndTearChance_;
        }
        
        val_5 = other.wearAndTearDamage_;
        if(val_5 != null)
        {
                val_6 = this.wearAndTearDamage_;
            if(val_6 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE val_1 = null;
            val_6 = val_1;
            val_1 = new CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE();
            this.wearAndTearDamage_ = val_6;
            val_5 = other.wearAndTearDamage_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        if(other.rareRewardChance_ != 0f)
        {
                this.rareRewardChance_ = other.rareRewardChance_;
        }
        
        if(other.plushSuitChance_ != 0f)
        {
                this.plushSuitChance_ = other.plushSuitChance_;
        }
        
        if(other.commonRewardChance_ != 0f)
        {
                this.commonRewardChance_ = other.commonRewardChance_;
        }
        
        val_4 = other.parts_;
        if(val_4 != null)
        {
                val_7 = this.parts_;
            if(val_7 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS val_2 = null;
            val_7 = val_2;
            val_2 = new CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS();
            this.parts_ = val_7;
            val_4 = other.parts_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        PARTS val_12;
        goto label_34;
        label_38:
        if(41400 > 33)
        {
            goto label_2;
        }
        
        if(41400 > 17)
        {
            goto label_3;
        }
        
        if(41400 == 9)
        {
            goto label_4;
        }
        
        if(41400 != 17)
        {
            goto label_19;
        }
        
        this.period_ = input.ReadDouble();
        goto label_34;
        label_2:
        if(41400 > 49)
        {
            goto label_8;
        }
        
        if(41400 == 42)
        {
            goto label_9;
        }
        
        if(41400 != 49)
        {
            goto label_19;
        }
        
        this.rareRewardChance_ = input.ReadDouble();
        goto label_34;
        label_3:
        if(41400 == 25)
        {
            goto label_13;
        }
        
        if(41400 != 33)
        {
            goto label_19;
        }
        
        this.wearAndTearChance_ = input.ReadDouble();
        goto label_34;
        label_8:
        if(41400 == 57)
        {
            goto label_17;
        }
        
        if(41400 == 65)
        {
            goto label_18;
        }
        
        if(41400 != 74)
        {
            goto label_19;
        }
        
        val_12 = this.parts_;
        if(val_12 != null)
        {
            goto label_20;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS val_4 = null;
        val_12 = val_4;
        val_4 = new CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.PARTS();
        this.parts_ = val_12;
        if(input != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_19:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_34;
        label_4:
        this.maxDeployed_ = input.ReadDouble();
        goto label_34;
        label_9:
        val_12 = this.wearAndTearDamage_;
        if(val_12 == null)
        {
            goto label_26;
        }
        
        label_20:
        if(input != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        input.ReadMessage(builder:  val_12);
        goto label_34;
        label_13:
        this.malfunction_ = input.ReadDouble();
        goto label_34;
        label_18:
        this.commonRewardChance_ = input.ReadDouble();
        goto label_34;
        label_17:
        this.plushSuitChance_ = input.ReadDouble();
        goto label_34;
        label_26:
        this.wearAndTearDamage_ = new CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.Types.WEARANDTEARDAMAGE();
        if(input != null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        if(input.ReadTag() != 0)
        {
            goto label_38;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.SCAVENGING()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.PartsFieldNumber = new Google.Protobuf.MessageParser<SCAVENGING>(factory:  new System.Func<SCAVENGING>(object:  CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.<>c.<>9, method:  SCAVENGING CONFIG_DATA.Types.ENTRY.Types.SCAVENGING.<>c::<.cctor>b__66_0()));
    }

}
