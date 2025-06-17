using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ThreatPillLifetimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double threatPillLifetime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinOrbitRadiusFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minOrbitRadius_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxOrbitRadiusFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxOrbitRadius_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnTimeFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double spawnTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxVisibleThreatPillsPerEssenceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxVisibleThreatPillsPerEssence_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinAngleSpeedDegreesFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minAngleSpeedDegrees_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxAngleSpeedDegreesFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxAngleSpeedDegrees_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxDegradeMultiplierFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxDegradeMultiplier_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinDegradeMultiplierFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minDegradeMultiplier_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinDegradeDistanceFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minDegradeDistance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxDegradeDistanceFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxDegradeDistance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StartingNumberOfThreatPillsFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double startingNumberOfThreatPills_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxThreatPillsPerEssenceFieldNumber = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxThreatPillsPerEssence_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinimumDetachedSpeedFieldNumber = 14;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minimumDetachedSpeed_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaximumDetachedSpeedFieldNumber = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maximumDetachedSpeed_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachedAccelerationFieldNumber = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double detachedAcceleration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachedDecelerationFieldNumber = 17;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double detachedDeceleration_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ThreatPillLifetime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxVisibleThreatPillsPerEssence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinAngleSpeedDegrees { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxAngleSpeedDegrees { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxDegradeMultiplier { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinDegradeMultiplier { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinDegradeDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxDegradeDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double StartingNumberOfThreatPills { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxThreatPillsPerEssence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinimumDetachedSpeed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaximumDetachedSpeed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedAcceleration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedDeceleration { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<THREATPILLS>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.DetachedDecelerationFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[6];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS other)
    {
        if(other != null)
        {
                this.threatPillLifetime_ = other.threatPillLifetime_;
            this.minOrbitRadius_ = other.minOrbitRadius_;
            this.maxOrbitRadius_ = other.maxOrbitRadius_;
            this.spawnTime_ = other.spawnTime_;
            this.maxVisibleThreatPillsPerEssence_ = other.maxVisibleThreatPillsPerEssence_;
            this.minAngleSpeedDegrees_ = other.minAngleSpeedDegrees_;
            this.maxAngleSpeedDegrees_ = other.maxAngleSpeedDegrees_;
            this.maxDegradeMultiplier_ = other.maxDegradeMultiplier_;
            this.minDegradeMultiplier_ = other.minDegradeMultiplier_;
            this.minDegradeDistance_ = other.minDegradeDistance_;
            this.maxDegradeDistance_ = other.maxDegradeDistance_;
            this.startingNumberOfThreatPills_ = other.startingNumberOfThreatPills_;
            this.maxThreatPillsPerEssence_ = other.maxThreatPillsPerEssence_;
            this.minimumDetachedSpeed_ = other.minimumDetachedSpeed_;
            this.maximumDetachedSpeed_ = other.maximumDetachedSpeed_;
            this.detachedAcceleration_ = other.detachedAcceleration_;
            this.detachedDeceleration_ = other.detachedDeceleration_;
        }
        else
        {
                this.threatPillLifetime_ = 7.42422564692724E-317;
            this.minOrbitRadius_ = 3.16202013338398E-322;
            this.maxOrbitRadius_ = 3.41288492945375E-316;
            this.spawnTime_ = 1.33509863819657E-307;
            this.maxVisibleThreatPillsPerEssence_ = 3.75487155418531E-308;
            this.minAngleSpeedDegrees_ = 1.06099789553204E-313;
            this.maxAngleSpeedDegrees_ = 0;
            this.maxDegradeMultiplier_ = 0;
            this.minDegradeMultiplier_ = 0;
            this.minDegradeDistance_ = 3.09235747019914E-316;
            this.maxDegradeDistance_ = 3.09235747019914E-316;
            this.startingNumberOfThreatPills_ = 3.23790861658519E-319;
            this.maxThreatPillsPerEssence_ = 1.27319747462857E-313;
            this.minimumDetachedSpeed_ = 3.0924050981274E-316;
            this.maximumDetachedSpeed_ = 3.09564300674398E-316;
            this.detachedAcceleration_ = 3.09564300674398E-316;
            this.detachedDeceleration_ = 3.20458487690449E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS Clone()
    {
        return (THREATPILLS)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS(other:  this);
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
    public double get_MaxVisibleThreatPillsPerEssence()
    {
        return (double)this.maxVisibleThreatPillsPerEssence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxVisibleThreatPillsPerEssence(double value)
    {
        this.maxVisibleThreatPillsPerEssence_ = value;
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
    public double get_MaxDegradeMultiplier()
    {
        return (double)this.maxDegradeMultiplier_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxDegradeMultiplier(double value)
    {
        this.maxDegradeMultiplier_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinDegradeMultiplier()
    {
        return (double)this.minDegradeMultiplier_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinDegradeMultiplier(double value)
    {
        this.minDegradeMultiplier_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinDegradeDistance()
    {
        return (double)this.minDegradeDistance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinDegradeDistance(double value)
    {
        this.minDegradeDistance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxDegradeDistance()
    {
        return (double)this.maxDegradeDistance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxDegradeDistance(double value)
    {
        this.maxDegradeDistance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_StartingNumberOfThreatPills()
    {
        return (double)this.startingNumberOfThreatPills_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StartingNumberOfThreatPills(double value)
    {
        this.startingNumberOfThreatPills_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxThreatPillsPerEssence()
    {
        return (double)this.maxThreatPillsPerEssence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxThreatPillsPerEssence(double value)
    {
        this.maxThreatPillsPerEssence_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinimumDetachedSpeed()
    {
        return (double)this.minimumDetachedSpeed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinimumDetachedSpeed(double value)
    {
        this.minimumDetachedSpeed_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaximumDetachedSpeed()
    {
        return (double)this.maximumDetachedSpeed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaximumDetachedSpeed(double value)
    {
        this.maximumDetachedSpeed_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DetachedAcceleration()
    {
        return (double)this.detachedAcceleration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachedAcceleration(double value)
    {
        this.detachedAcceleration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DetachedDeceleration()
    {
        return (double)this.detachedDeceleration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachedDeceleration(double value)
    {
        this.detachedDeceleration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        THREATPILLS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS other)
    {
        var val_18;
        double val_19;
        var val_20;
        if(other == null)
        {
            goto label_70;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_19 = this.threatPillLifetime_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.minOrbitRadius_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.maxOrbitRadius_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.spawnTime_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.maxVisibleThreatPillsPerEssence_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.minAngleSpeedDegrees_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.maxAngleSpeedDegrees_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) == 0)
        {
            goto label_70;
        }
        
        val_19 = this.maxDegradeMultiplier_;
        val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_18 & 1) != 0)
        {
                val_19 = this.minDegradeMultiplier_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.minDegradeDistance_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.maxDegradeDistance_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.startingNumberOfThreatPills_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.maxThreatPillsPerEssence_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.minimumDetachedSpeed_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.maximumDetachedSpeed_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.detachedAcceleration_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
        {
                val_19 = this.detachedDeceleration_;
            val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_18 & 1) != 0)
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
        
        }
        
        }
        
        label_70:
        val_20 = 0;
        return (bool)val_20;
        label_2:
        val_20 = 1;
        return (bool)val_20;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_18;
        if(this.threatPillLifetime_ == 0f)
        {
                val_18 = 1;
        }
        else
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.minOrbitRadius_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxOrbitRadius_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.spawnTime_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxVisibleThreatPillsPerEssence_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.minAngleSpeedDegrees_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxAngleSpeedDegrees_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxDegradeMultiplier_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.minDegradeMultiplier_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.minDegradeDistance_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxDegradeDistance_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.startingNumberOfThreatPills_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maxThreatPillsPerEssence_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.minimumDetachedSpeed_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.maximumDetachedSpeed_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.detachedAcceleration_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this.detachedDeceleration_ != 0f)
        {
                val_18 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_18;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_18;
        }
        
        val_18 = this._unknownFields ^ val_18;
        return (int)val_18;
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
        double val_9;
        double val_10;
        double val_11;
        double val_12;
        double val_13;
        double val_14;
        double val_15;
        double val_16;
        double val_17;
        if(this.threatPillLifetime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.threatPillLifetime_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.threatPillLifetime_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.minOrbitRadius_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.minOrbitRadius_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.minOrbitRadius_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.maxOrbitRadius_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.maxOrbitRadius_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.maxOrbitRadius_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.spawnTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.spawnTime_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.spawnTime_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.maxVisibleThreatPillsPerEssence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.maxVisibleThreatPillsPerEssence_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.maxVisibleThreatPillsPerEssence_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.minAngleSpeedDegrees_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.minAngleSpeedDegrees_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.minAngleSpeedDegrees_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.maxAngleSpeedDegrees_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.maxAngleSpeedDegrees_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.maxAngleSpeedDegrees_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.maxDegradeMultiplier_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.maxDegradeMultiplier_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.maxDegradeMultiplier_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.minDegradeMultiplier_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_9 = this.minDegradeMultiplier_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_9 = this.minDegradeMultiplier_;
        }
        
            output.WriteDouble(value:  val_9);
        }
        
        if(this.minDegradeDistance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  81);
            val_10 = this.minDegradeDistance_;
        }
        else
        {
                0.WriteRawTag(b1:  81);
            val_10 = this.minDegradeDistance_;
        }
        
            output.WriteDouble(value:  val_10);
        }
        
        if(this.maxDegradeDistance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  89);
            val_11 = this.maxDegradeDistance_;
        }
        else
        {
                0.WriteRawTag(b1:  89);
            val_11 = this.maxDegradeDistance_;
        }
        
            output.WriteDouble(value:  val_11);
        }
        
        if(this.startingNumberOfThreatPills_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  97);
            val_12 = this.startingNumberOfThreatPills_;
        }
        else
        {
                0.WriteRawTag(b1:  97);
            val_12 = this.startingNumberOfThreatPills_;
        }
        
            output.WriteDouble(value:  val_12);
        }
        
        if(this.maxThreatPillsPerEssence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  105);
            val_13 = this.maxThreatPillsPerEssence_;
        }
        else
        {
                0.WriteRawTag(b1:  105);
            val_13 = this.maxThreatPillsPerEssence_;
        }
        
            output.WriteDouble(value:  val_13);
        }
        
        if(this.minimumDetachedSpeed_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  113);
            val_14 = this.minimumDetachedSpeed_;
        }
        else
        {
                0.WriteRawTag(b1:  113);
            val_14 = this.minimumDetachedSpeed_;
        }
        
            output.WriteDouble(value:  val_14);
        }
        
        if(this.maximumDetachedSpeed_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  121);
            val_15 = this.maximumDetachedSpeed_;
        }
        else
        {
                0.WriteRawTag(b1:  121);
            val_15 = this.maximumDetachedSpeed_;
        }
        
            output.WriteDouble(value:  val_15);
        }
        
        if(this.detachedAcceleration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  129, b2:  1);
            val_16 = this.detachedAcceleration_;
        }
        else
        {
                0.WriteRawTag(b1:  129, b2:  1);
            val_16 = this.detachedAcceleration_;
        }
        
            output.WriteDouble(value:  val_16);
        }
        
        if(this.detachedDeceleration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  137, b2:  1);
            val_17 = this.detachedDeceleration_;
        }
        else
        {
                0.WriteRawTag(b1:  137, b2:  1);
            val_17 = this.detachedDeceleration_;
        }
        
            output.WriteDouble(value:  val_17);
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
        var val_1 = (this.threatPillLifetime_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.minOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.spawnTime_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxVisibleThreatPillsPerEssence_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minAngleSpeedDegrees_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxAngleSpeedDegrees_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxDegradeMultiplier_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minDegradeMultiplier_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minDegradeDistance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxDegradeDistance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.startingNumberOfThreatPills_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxThreatPillsPerEssence_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minimumDetachedSpeed_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maximumDetachedSpeed_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        val_1 = (this.detachedAcceleration_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.detachedDeceleration_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.threatPillLifetime_ != 0f)
        {
                this.threatPillLifetime_ = other.threatPillLifetime_;
        }
        
        if(other.minOrbitRadius_ != 0f)
        {
                this.minOrbitRadius_ = other.minOrbitRadius_;
        }
        
        if(other.maxOrbitRadius_ != 0f)
        {
                this.maxOrbitRadius_ = other.maxOrbitRadius_;
        }
        
        if(other.spawnTime_ != 0f)
        {
                this.spawnTime_ = other.spawnTime_;
        }
        
        if(other.maxVisibleThreatPillsPerEssence_ != 0f)
        {
                this.maxVisibleThreatPillsPerEssence_ = other.maxVisibleThreatPillsPerEssence_;
        }
        
        if(other.minAngleSpeedDegrees_ != 0f)
        {
                this.minAngleSpeedDegrees_ = other.minAngleSpeedDegrees_;
        }
        
        if(other.maxAngleSpeedDegrees_ != 0f)
        {
                this.maxAngleSpeedDegrees_ = other.maxAngleSpeedDegrees_;
        }
        
        if(other.maxDegradeMultiplier_ != 0f)
        {
                this.maxDegradeMultiplier_ = other.maxDegradeMultiplier_;
        }
        
        if(other.minDegradeMultiplier_ != 0f)
        {
                this.minDegradeMultiplier_ = other.minDegradeMultiplier_;
        }
        
        if(other.minDegradeDistance_ != 0f)
        {
                this.minDegradeDistance_ = other.minDegradeDistance_;
        }
        
        if(other.maxDegradeDistance_ != 0f)
        {
                this.maxDegradeDistance_ = other.maxDegradeDistance_;
        }
        
        if(other.startingNumberOfThreatPills_ != 0f)
        {
                this.startingNumberOfThreatPills_ = other.startingNumberOfThreatPills_;
        }
        
        if(other.maxThreatPillsPerEssence_ != 0f)
        {
                this.maxThreatPillsPerEssence_ = other.maxThreatPillsPerEssence_;
        }
        
        if(other.minimumDetachedSpeed_ != 0f)
        {
                this.minimumDetachedSpeed_ = other.minimumDetachedSpeed_;
        }
        
        if(other.maximumDetachedSpeed_ != 0f)
        {
                this.maximumDetachedSpeed_ = other.maximumDetachedSpeed_;
        }
        
        if(other.detachedAcceleration_ != 0f)
        {
                this.detachedAcceleration_ = other.detachedAcceleration_;
        }
        
        if(other.detachedDeceleration_ != 0f)
        {
                this.detachedDeceleration_ = other.detachedDeceleration_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_57;
        label_60:
        if(this > 65)
        {
            goto label_1;
        }
        
        if(this > 33)
        {
            goto label_2;
        }
        
        if(this > 17)
        {
            goto label_3;
        }
        
        if(this == 9)
        {
            goto label_4;
        }
        
        if(this != 17)
        {
            goto label_38;
        }
        
        this.minOrbitRadius_ = input.ReadDouble();
        goto label_57;
        label_1:
        if(this > 97)
        {
            goto label_8;
        }
        
        if(this > 81)
        {
            goto label_9;
        }
        
        if(this == 73)
        {
            goto label_10;
        }
        
        if(this != 81)
        {
            goto label_38;
        }
        
        this.minDegradeDistance_ = input.ReadDouble();
        goto label_57;
        label_2:
        if(this > 49)
        {
            goto label_14;
        }
        
        if(this == 41)
        {
            goto label_15;
        }
        
        if(this != 49)
        {
            goto label_38;
        }
        
        this.minAngleSpeedDegrees_ = input.ReadDouble();
        goto label_57;
        label_8:
        if(this > 113)
        {
            goto label_19;
        }
        
        if(this == 105)
        {
            goto label_20;
        }
        
        if(this != 113)
        {
            goto label_38;
        }
        
        this.minimumDetachedSpeed_ = input.ReadDouble();
        goto label_57;
        label_3:
        if(this == 25)
        {
            goto label_24;
        }
        
        if(this != 33)
        {
            goto label_38;
        }
        
        this.spawnTime_ = input.ReadDouble();
        goto label_57;
        label_9:
        if(this == 89)
        {
            goto label_28;
        }
        
        if(this != 97)
        {
            goto label_38;
        }
        
        this.startingNumberOfThreatPills_ = input.ReadDouble();
        goto label_57;
        label_14:
        if(this == 57)
        {
            goto label_32;
        }
        
        if(this != 65)
        {
            goto label_38;
        }
        
        this.maxDegradeMultiplier_ = input.ReadDouble();
        goto label_57;
        label_19:
        if(this == 121)
        {
            goto label_36;
        }
        
        if(this == 129)
        {
            goto label_37;
        }
        
        if(this != 137)
        {
            goto label_38;
        }
        
        this.detachedDeceleration_ = input.ReadDouble();
        goto label_57;
        label_38:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_57;
        label_4:
        this.threatPillLifetime_ = input.ReadDouble();
        goto label_57;
        label_10:
        this.minDegradeMultiplier_ = input.ReadDouble();
        goto label_57;
        label_15:
        this.maxVisibleThreatPillsPerEssence_ = input.ReadDouble();
        goto label_57;
        label_20:
        this.maxThreatPillsPerEssence_ = input.ReadDouble();
        goto label_57;
        label_24:
        this.maxOrbitRadius_ = input.ReadDouble();
        goto label_57;
        label_28:
        this.maxDegradeDistance_ = input.ReadDouble();
        goto label_57;
        label_32:
        this.maxAngleSpeedDegrees_ = input.ReadDouble();
        goto label_57;
        label_36:
        this.maximumDetachedSpeed_ = input.ReadDouble();
        goto label_57;
        label_37:
        this.detachedAcceleration_ = input.ReadDouble();
        label_57:
        if(input.ReadTag() != 0)
        {
            goto label_60;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.DetachedDecelerationFieldNumber = new Google.Protobuf.MessageParser<THREATPILLS>(factory:  new System.Func<THREATPILLS>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.<>c.<>9, method:  THREATPILLS CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS.<>c::<.cctor>b__105_0()));
    }

}
