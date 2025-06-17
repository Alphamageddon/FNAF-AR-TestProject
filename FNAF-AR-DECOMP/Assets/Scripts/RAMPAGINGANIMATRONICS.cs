using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS : IMessage<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS>, IDeepCloneable<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS parts_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE essence_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PlushSuitDropChanceFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double plushSuitDropChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CPUDropChanceFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double cPUDropChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ModDropChanceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double modDropChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceOnLoseFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE essenceOnLose_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS Parts { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE Essence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PlushSuitDropChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CPUDropChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ModDropChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE EssenceOnLose { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<RAMPAGINGANIMATRONICS>)CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.EssenceOnLoseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CPU_DATA.Types.REWARDS.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS other)
    {
        ESSENCE val_5;
        ESSENCEONLOSE val_6;
        if(other.parts_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.parts_ = other.parts_.Clone();
        val_5 = other.essence_;
        this.essence_ = val_5.Clone();
        this.plushSuitDropChance_ = other.plushSuitDropChance_;
        this.cPUDropChance_ = other.cPUDropChance_;
        this.modDropChance_ = other.modDropChance_;
        val_6 = other.essenceOnLose_;
        this.essenceOnLose_ = val_6.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS Clone()
    {
        return (RAMPAGINGANIMATRONICS)new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS get_Parts()
    {
        return (PARTS)this.parts_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Parts(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS value)
    {
        this.parts_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE get_Essence()
    {
        return (ESSENCE)this.essence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Essence(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE value)
    {
        this.essence_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PlushSuitDropChance()
    {
        return (double)this.plushSuitDropChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PlushSuitDropChance(double value)
    {
        this.plushSuitDropChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CPUDropChance()
    {
        return (double)this.cPUDropChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CPUDropChance(double value)
    {
        this.cPUDropChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ModDropChance()
    {
        return (double)this.modDropChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ModDropChance(double value)
    {
        this.modDropChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE get_EssenceOnLose()
    {
        return (ESSENCEONLOSE)this.essenceOnLose_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceOnLose(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE value)
    {
        this.essenceOnLose_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        RAMPAGINGANIMATRONICS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS other)
    {
        var val_7;
        double val_8;
        var val_9;
        if(other == null)
        {
            goto label_17;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((System.Object.Equals(objA:  this.parts_, objB:  other.parts_)) != false) && ((System.Object.Equals(objA:  this.essence_, objB:  other.essence_)) != false))
        {
                val_8 = this.plushSuitDropChance_;
            val_7 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_7 & 1) != 0)
        {
                val_8 = this.cPUDropChance_;
            val_7 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_7 & 1) != 0)
        {
                val_8 = this.modDropChance_;
            val_7 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_7 & 1) != 0)
        {
                if((System.Object.Equals(objA:  this.essenceOnLose_, objB:  other.essenceOnLose_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        label_17:
        val_9 = 0;
        return (bool)val_9;
        label_2:
        val_9 = 1;
        return (bool)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_6;
        if(this.parts_ != null)
        {
                val_6 = this.parts_ ^ 1;
        }
        else
        {
                val_6 = 1;
        }
        
        if(this.essence_ != null)
        {
                val_6 = this.essence_ ^ val_6;
        }
        
        if(this.plushSuitDropChance_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.cPUDropChance_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.modDropChance_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.essenceOnLose_ != null)
        {
                val_6 = this.essenceOnLose_ ^ val_6;
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
        PARTS val_1;
        ESSENCE val_2;
        double val_3;
        double val_4;
        double val_5;
        ESSENCEONLOSE val_6;
        if(this.parts_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.parts_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.parts_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.essence_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.essence_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.essence_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.plushSuitDropChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.plushSuitDropChance_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.plushSuitDropChance_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.cPUDropChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.cPUDropChance_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.cPUDropChance_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.modDropChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.modDropChance_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.modDropChance_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.essenceOnLose_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.essenceOnLose_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.essenceOnLose_;
        }
        
            output.WriteMessage(value:  val_6);
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
        if(this.parts_ != null)
        {
                val_10 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.parts_)) + 1;
        }
        else
        {
                val_10 = 0;
        }
        
        ESSENCE val_9 = this.essence_;
        if(val_9 != null)
        {
                int val_3 = val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_9));
            val_10 = val_3 + 1;
        }
        
        val_3 = val_10 + 9;
        var val_4 = (this.plushSuitDropChance_ == 0f) ? (val_10) : (val_3);
        var val_5 = val_4 + 9;
        val_4 = (this.cPUDropChance_ == 0f) ? (val_4) : (val_5);
        val_5 = val_4 + 9;
        val_9 = (this.modDropChance_ == 0f) ? (val_4) : (val_5);
        if(this.essenceOnLose_ != null)
        {
                val_11 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.essenceOnLose_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields.CalculateSize() + val_11;
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS other)
    {
        ESSENCEONLOSE val_5;
        PARTS val_6;
        PARTS val_7;
        ESSENCE val_8;
        ESSENCE val_9;
        ESSENCEONLOSE val_10;
        if(other == null)
        {
                return;
        }
        
        val_6 = other.parts_;
        if(val_6 != null)
        {
                val_7 = this.parts_;
            if(val_7 == null)
        {
                CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS val_1 = null;
            val_7 = val_1;
            val_1 = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS();
            this.parts_ = val_7;
            val_6 = other.parts_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        val_8 = other.essence_;
        if(val_8 != null)
        {
                val_9 = this.essence_;
            if(val_9 == null)
        {
                CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE val_2 = null;
            val_9 = val_2;
            val_2 = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE();
            this.essence_ = val_9;
            val_8 = other.essence_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        if(other.plushSuitDropChance_ != 0f)
        {
                this.plushSuitDropChance_ = other.plushSuitDropChance_;
        }
        
        if(other.cPUDropChance_ != 0f)
        {
                this.cPUDropChance_ = other.cPUDropChance_;
        }
        
        if(other.modDropChance_ != 0f)
        {
                this.modDropChance_ = other.modDropChance_;
        }
        
        val_5 = other.essenceOnLose_;
        if(val_5 != null)
        {
                val_10 = this.essenceOnLose_;
            if(val_10 == null)
        {
                CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE val_3 = null;
            val_10 = val_3;
            val_3 = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE();
            this.essenceOnLose_ = val_10;
            val_5 = other.essenceOnLose_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ESSENCEONLOSE val_9;
        goto label_24;
        label_28:
        if(39068 > 25)
        {
            goto label_2;
        }
        
        if(39068 == 10)
        {
            goto label_3;
        }
        
        if(39068 == 18)
        {
            goto label_4;
        }
        
        if(39068 != 25)
        {
            goto label_10;
        }
        
        this.plushSuitDropChance_ = input.ReadDouble();
        goto label_24;
        label_2:
        if(39068 == 33)
        {
            goto label_8;
        }
        
        if(39068 == 41)
        {
            goto label_9;
        }
        
        if(39068 != 50)
        {
            goto label_10;
        }
        
        val_9 = this.essenceOnLose_;
        if(val_9 != null)
        {
            goto label_15;
        }
        
        CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE val_2 = null;
        val_9 = val_2;
        val_2 = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCEONLOSE();
        this.essenceOnLose_ = val_9;
        if(input != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_24;
        label_4:
        val_9 = this.essence_;
        if(val_9 != null)
        {
            goto label_15;
        }
        
        CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE val_4 = null;
        val_9 = val_4;
        val_4 = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.ESSENCE();
        this.essence_ = val_9;
        if(input != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_9:
        this.modDropChance_ = input.ReadDouble();
        goto label_24;
        label_3:
        val_9 = this.parts_;
        if(val_9 == null)
        {
            goto label_20;
        }
        
        label_15:
        if(input != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        input.ReadMessage(builder:  val_9);
        goto label_24;
        label_8:
        this.cPUDropChance_ = input.ReadDouble();
        goto label_24;
        label_20:
        this.parts_ = new CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.Types.PARTS();
        if(input != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_24:
        if(input.ReadTag() != 0)
        {
            goto label_28;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS()
    {
        null = null;
        CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.EssenceOnLoseFieldNumber = new Google.Protobuf.MessageParser<RAMPAGINGANIMATRONICS>(factory:  new System.Func<RAMPAGINGANIMATRONICS>(object:  CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.<>c.<>9, method:  RAMPAGINGANIMATRONICS CPU_DATA.Types.REWARDS.Types.RAMPAGINGANIMATRONICS.<>c::<.cctor>b__51_0()));
    }

}
