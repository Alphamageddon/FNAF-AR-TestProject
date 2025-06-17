using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR : IMessage<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR>, IMessage, IEquatable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR>, IDeepCloneable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StartingThreatPillsPerNodeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double startingThreatPillsPerNode_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxThreatPillsPerNodeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxThreatPillsPerNode_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinOrbitRadiusFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minOrbitRadius_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxOrbitRadiusFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxOrbitRadius_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinAngleSpeedDegreesFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minAngleSpeedDegrees_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxAngleSpeedDegreesFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxAngleSpeedDegrees_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ThreatPillLifetimeFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double threatPillLifetime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnTimeFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double StartingThreatPillsPerNode { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxThreatPillsPerNode { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinAngleSpeedDegrees { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxAngleSpeedDegrees { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ThreatPillLifetime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SPAWNBEHAVIOR>)ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR.SpawnTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR other)
    {
        if(other != null)
        {
                this.startingThreatPillsPerNode_ = other.startingThreatPillsPerNode_;
            this.maxThreatPillsPerNode_ = other.maxThreatPillsPerNode_;
            this.minOrbitRadius_ = other.minOrbitRadius_;
            this.maxOrbitRadius_ = other.maxOrbitRadius_;
            this.minAngleSpeedDegrees_ = other.minAngleSpeedDegrees_;
            this.maxAngleSpeedDegrees_ = other.maxAngleSpeedDegrees_;
            this.threatPillLifetime_ = other.threatPillLifetime_;
            this.spawnTime_ = other.spawnTime_;
        }
        else
        {
                this.startingThreatPillsPerNode_ = 7.42422564692724E-317;
            this.maxThreatPillsPerNode_ = 3.16202013338398E-322;
            this.minOrbitRadius_ = 3.41288492945375E-316;
            this.maxOrbitRadius_ = 1.33509863819657E-307;
            this.minAngleSpeedDegrees_ = 3.75487155418531E-308;
            this.maxAngleSpeedDegrees_ = 1.06099789553204E-313;
            this.threatPillLifetime_ = 0;
            this.spawnTime_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR Clone()
    {
        return (SPAWNBEHAVIOR)new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_StartingThreatPillsPerNode()
    {
        return (double)this.startingThreatPillsPerNode_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StartingThreatPillsPerNode(double value)
    {
        this.startingThreatPillsPerNode_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxThreatPillsPerNode()
    {
        return (double)this.maxThreatPillsPerNode_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxThreatPillsPerNode(double value)
    {
        this.maxThreatPillsPerNode_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinOrbitRadius()
    {
        return (double)this.minOrbitRadius_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinOrbitRadius(double value)
    {
        this.minOrbitRadius_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxOrbitRadius()
    {
        return (double)this.maxOrbitRadius_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxOrbitRadius(double value)
    {
        this.maxOrbitRadius_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinAngleSpeedDegrees()
    {
        return (double)this.minAngleSpeedDegrees_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinAngleSpeedDegrees(double value)
    {
        this.minAngleSpeedDegrees_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxAngleSpeedDegrees()
    {
        return (double)this.maxAngleSpeedDegrees_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxAngleSpeedDegrees(double value)
    {
        this.maxAngleSpeedDegrees_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ThreatPillLifetime()
    {
        return (double)this.threatPillLifetime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThreatPillLifetime(double value)
    {
        this.threatPillLifetime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SpawnTime()
    {
        return (double)this.spawnTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnTime(double value)
    {
        this.spawnTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SPAWNBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR other)
    {
        var val_9;
        double val_10;
        var val_11;
        if(other == null)
        {
            goto label_34;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_10 = this.startingThreatPillsPerNode_;
        val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_9 & 1) != 0)
        {
                val_10 = this.maxThreatPillsPerNode_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.minOrbitRadius_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.maxOrbitRadius_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.minAngleSpeedDegrees_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.maxAngleSpeedDegrees_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.threatPillLifetime_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
        {
                val_10 = this.spawnTime_;
            val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_9 & 1) != 0)
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
        
        label_34:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        val_11 = 1;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_9;
        if(this.startingThreatPillsPerNode_ == 0f)
        {
                val_9 = 1;
        }
        else
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.maxThreatPillsPerNode_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.minOrbitRadius_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.maxOrbitRadius_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.minAngleSpeedDegrees_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.maxAngleSpeedDegrees_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.threatPillLifetime_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this.spawnTime_ != 0f)
        {
                val_9 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_9;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields ^ val_9;
        return (int)val_9;
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
        double val_6;
        double val_7;
        double val_8;
        if(this.startingThreatPillsPerNode_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.startingThreatPillsPerNode_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.startingThreatPillsPerNode_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.maxThreatPillsPerNode_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.maxThreatPillsPerNode_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.maxThreatPillsPerNode_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.minOrbitRadius_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.minOrbitRadius_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.minOrbitRadius_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.maxOrbitRadius_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.maxOrbitRadius_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.maxOrbitRadius_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.minAngleSpeedDegrees_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.minAngleSpeedDegrees_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.minAngleSpeedDegrees_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.maxAngleSpeedDegrees_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.maxAngleSpeedDegrees_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.maxAngleSpeedDegrees_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.threatPillLifetime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.threatPillLifetime_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.threatPillLifetime_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.spawnTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.spawnTime_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.spawnTime_;
        }
        
            output.WriteDouble(value:  val_8);
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
        var val_1 = (this.startingThreatPillsPerNode_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.maxThreatPillsPerNode_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minAngleSpeedDegrees_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxAngleSpeedDegrees_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.threatPillLifetime_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.spawnTime_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.startingThreatPillsPerNode_ != 0f)
        {
                this.startingThreatPillsPerNode_ = other.startingThreatPillsPerNode_;
        }
        
        if(other.maxThreatPillsPerNode_ != 0f)
        {
                this.maxThreatPillsPerNode_ = other.maxThreatPillsPerNode_;
        }
        
        if(other.minOrbitRadius_ != 0f)
        {
                this.minOrbitRadius_ = other.minOrbitRadius_;
        }
        
        if(other.maxOrbitRadius_ != 0f)
        {
                this.maxOrbitRadius_ = other.maxOrbitRadius_;
        }
        
        if(other.minAngleSpeedDegrees_ != 0f)
        {
                this.minAngleSpeedDegrees_ = other.minAngleSpeedDegrees_;
        }
        
        if(other.maxAngleSpeedDegrees_ != 0f)
        {
                this.maxAngleSpeedDegrees_ = other.maxAngleSpeedDegrees_;
        }
        
        if(other.threatPillLifetime_ != 0f)
        {
                this.threatPillLifetime_ = other.threatPillLifetime_;
        }
        
        if(other.spawnTime_ != 0f)
        {
                this.spawnTime_ = other.spawnTime_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_26;
        label_29:
        if(this > 33)
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
            goto label_17;
        }
        
        this.maxThreatPillsPerNode_ = input.ReadDouble();
        goto label_26;
        label_1:
        if(this > 49)
        {
            goto label_7;
        }
        
        if(this == 41)
        {
            goto label_8;
        }
        
        if(this != 49)
        {
            goto label_17;
        }
        
        this.maxAngleSpeedDegrees_ = input.ReadDouble();
        goto label_26;
        label_2:
        if(this == 25)
        {
            goto label_12;
        }
        
        if(this != 33)
        {
            goto label_17;
        }
        
        this.maxOrbitRadius_ = input.ReadDouble();
        goto label_26;
        label_7:
        if(this == 57)
        {
            goto label_16;
        }
        
        if(this != 65)
        {
            goto label_17;
        }
        
        this.spawnTime_ = input.ReadDouble();
        goto label_26;
        label_17:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_26;
        label_3:
        this.startingThreatPillsPerNode_ = input.ReadDouble();
        goto label_26;
        label_8:
        this.minAngleSpeedDegrees_ = input.ReadDouble();
        goto label_26;
        label_12:
        this.minOrbitRadius_ = input.ReadDouble();
        goto label_26;
        label_16:
        this.threatPillLifetime_ = input.ReadDouble();
        label_26:
        if(input.ReadTag() != 0)
        {
            goto label_29;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR()
    {
        null = null;
        ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR.SpawnTimeFieldNumber = new Google.Protobuf.MessageParser<SPAWNBEHAVIOR>(factory:  new System.Func<SPAWNBEHAVIOR>(object:  ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR.<>c.<>9, method:  SPAWNBEHAVIOR ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR.<>c::<.cctor>b__60_0()));
    }

}
