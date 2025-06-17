using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MoteLifetimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double moteLifetime_;
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
    public const int MaxVisibleMotesPerEssenceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxVisibleMotesPerEssence_;
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
    public const int StartingNumberOfMotesFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double startingNumberOfMotes_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxMotesPerEssenceFieldNumber = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxMotesPerEssence_;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectFlushBatchTimeFieldNumber = 18;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectFlushBatchTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectTimeToWaitToSeeIfMoreMotesComingInFieldNumber = 19;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectTimeToWaitToSeeIfMoreMotesComingIn_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MoteLifetime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxOrbitRadius { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SpawnTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxVisibleMotesPerEssence { get; set; }
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
    public double StartingNumberOfMotes { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxMotesPerEssence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinimumDetachedSpeed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaximumDetachedSpeed { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedAcceleration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedDeceleration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectFlushBatchTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectTimeToWaitToSeeIfMoreMotesComingIn { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MOTES>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.CollectTimeToWaitToSeeIfMoreMotesComingInFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES other)
    {
        if(other != null)
        {
                this.moteLifetime_ = other.moteLifetime_;
            this.minOrbitRadius_ = other.minOrbitRadius_;
            this.maxOrbitRadius_ = other.maxOrbitRadius_;
            this.spawnTime_ = other.spawnTime_;
            this.maxVisibleMotesPerEssence_ = other.maxVisibleMotesPerEssence_;
            this.minAngleSpeedDegrees_ = other.minAngleSpeedDegrees_;
            this.maxAngleSpeedDegrees_ = other.maxAngleSpeedDegrees_;
            this.maxDegradeMultiplier_ = other.maxDegradeMultiplier_;
            this.minDegradeMultiplier_ = other.minDegradeMultiplier_;
            this.minDegradeDistance_ = other.minDegradeDistance_;
            this.maxDegradeDistance_ = other.maxDegradeDistance_;
            this.startingNumberOfMotes_ = other.startingNumberOfMotes_;
            this.maxMotesPerEssence_ = other.maxMotesPerEssence_;
            this.minimumDetachedSpeed_ = other.minimumDetachedSpeed_;
            this.maximumDetachedSpeed_ = other.maximumDetachedSpeed_;
            this.detachedAcceleration_ = other.detachedAcceleration_;
            this.detachedDeceleration_ = other.detachedDeceleration_;
            this.collectFlushBatchTime_ = other.collectFlushBatchTime_;
            this.collectTimeToWaitToSeeIfMoreMotesComingIn_ = other.collectTimeToWaitToSeeIfMoreMotesComingIn_;
        }
        else
        {
                this.moteLifetime_ = 7.42422564692724E-317;
            this.minOrbitRadius_ = 3.16202013338398E-322;
            this.maxOrbitRadius_ = 3.41288492945375E-316;
            this.spawnTime_ = 1.33509863819657E-307;
            this.maxVisibleMotesPerEssence_ = 3.75487155418531E-308;
            this.minAngleSpeedDegrees_ = 1.06099789553204E-313;
            this.maxAngleSpeedDegrees_ = 0;
            this.maxDegradeMultiplier_ = 0;
            this.minDegradeMultiplier_ = 0;
            this.minDegradeDistance_ = 3.09235747019914E-316;
            this.maxDegradeDistance_ = 3.09235747019914E-316;
            this.startingNumberOfMotes_ = 3.23790861658519E-319;
            this.maxMotesPerEssence_ = 1.27319747462857E-313;
            this.minimumDetachedSpeed_ = 3.0924050981274E-316;
            this.maximumDetachedSpeed_ = 3.09564300674398E-316;
            this.detachedAcceleration_ = 3.09564300674398E-316;
            this.detachedDeceleration_ = 3.20458487690449E-317;
            this.collectFlushBatchTime_ = 3.64380133100703E-317;
            this.collectTimeToWaitToSeeIfMoreMotesComingIn_ = 3.23790861658519E-319;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES Clone()
    {
        return (MOTES)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MoteLifetime()
    {
        return (double)this.moteLifetime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MoteLifetime(double value)
    {
        this.moteLifetime_ = value;
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
    public double get_MaxVisibleMotesPerEssence()
    {
        return (double)this.maxVisibleMotesPerEssence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxVisibleMotesPerEssence(double value)
    {
        this.maxVisibleMotesPerEssence_ = value;
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
    public double get_StartingNumberOfMotes()
    {
        return (double)this.startingNumberOfMotes_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StartingNumberOfMotes(double value)
    {
        this.startingNumberOfMotes_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxMotesPerEssence()
    {
        return (double)this.maxMotesPerEssence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxMotesPerEssence(double value)
    {
        this.maxMotesPerEssence_ = value;
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
    public double get_CollectFlushBatchTime()
    {
        return (double)this.collectFlushBatchTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectFlushBatchTime(double value)
    {
        this.collectFlushBatchTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectTimeToWaitToSeeIfMoreMotesComingIn()
    {
        return (double)this.collectTimeToWaitToSeeIfMoreMotesComingIn_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectTimeToWaitToSeeIfMoreMotesComingIn(double value)
    {
        this.collectTimeToWaitToSeeIfMoreMotesComingIn_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MOTES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES other)
    {
        var val_20;
        double val_21;
        var val_22;
        if(other == null)
        {
            goto label_78;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_21 = this.moteLifetime_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.minOrbitRadius_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.maxOrbitRadius_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.spawnTime_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.maxVisibleMotesPerEssence_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.minAngleSpeedDegrees_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.maxAngleSpeedDegrees_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.maxDegradeMultiplier_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.minDegradeMultiplier_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) == 0)
        {
            goto label_78;
        }
        
        val_21 = this.minDegradeDistance_;
        val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_20 & 1) != 0)
        {
                val_21 = this.maxDegradeDistance_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.startingNumberOfMotes_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.maxMotesPerEssence_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.minimumDetachedSpeed_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.maximumDetachedSpeed_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.detachedAcceleration_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.detachedDeceleration_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.collectFlushBatchTime_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
        {
                val_21 = this.collectTimeToWaitToSeeIfMoreMotesComingIn_;
            val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_20 & 1) != 0)
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
        
        label_78:
        val_22 = 0;
        return (bool)val_22;
        label_2:
        val_22 = 1;
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_20;
        if(this.moteLifetime_ == 0f)
        {
                val_20 = 1;
        }
        else
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.minOrbitRadius_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxOrbitRadius_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.spawnTime_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxVisibleMotesPerEssence_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.minAngleSpeedDegrees_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxAngleSpeedDegrees_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxDegradeMultiplier_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.minDegradeMultiplier_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.minDegradeDistance_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxDegradeDistance_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.startingNumberOfMotes_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maxMotesPerEssence_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.minimumDetachedSpeed_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.maximumDetachedSpeed_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.detachedAcceleration_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.detachedDeceleration_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.collectFlushBatchTime_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this.collectTimeToWaitToSeeIfMoreMotesComingIn_ != 0f)
        {
                val_20 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_20;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_20;
        }
        
        val_20 = this._unknownFields ^ val_20;
        return (int)val_20;
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
        double val_18;
        double val_19;
        if(this.moteLifetime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.moteLifetime_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.moteLifetime_;
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
        
        if(this.maxVisibleMotesPerEssence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.maxVisibleMotesPerEssence_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.maxVisibleMotesPerEssence_;
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
        
        if(this.startingNumberOfMotes_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  97);
            val_12 = this.startingNumberOfMotes_;
        }
        else
        {
                0.WriteRawTag(b1:  97);
            val_12 = this.startingNumberOfMotes_;
        }
        
            output.WriteDouble(value:  val_12);
        }
        
        if(this.maxMotesPerEssence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  105);
            val_13 = this.maxMotesPerEssence_;
        }
        else
        {
                0.WriteRawTag(b1:  105);
            val_13 = this.maxMotesPerEssence_;
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
        
        if(this.collectFlushBatchTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  145, b2:  1);
            val_18 = this.collectFlushBatchTime_;
        }
        else
        {
                0.WriteRawTag(b1:  145, b2:  1);
            val_18 = this.collectFlushBatchTime_;
        }
        
            output.WriteDouble(value:  val_18);
        }
        
        if(this.collectTimeToWaitToSeeIfMoreMotesComingIn_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  153, b2:  1);
            val_19 = this.collectTimeToWaitToSeeIfMoreMotesComingIn_;
        }
        else
        {
                0.WriteRawTag(b1:  153, b2:  1);
            val_19 = this.collectTimeToWaitToSeeIfMoreMotesComingIn_;
        }
        
            output.WriteDouble(value:  val_19);
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
        var val_1 = (this.moteLifetime_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.minOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxOrbitRadius_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.spawnTime_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxVisibleMotesPerEssence_ == 0f) ? (val_1) : (val_2);
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
        val_1 = (this.startingNumberOfMotes_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maxMotesPerEssence_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.minimumDetachedSpeed_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.maximumDetachedSpeed_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        val_1 = (this.detachedAcceleration_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        val_1 = (this.detachedDeceleration_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        val_1 = (this.collectFlushBatchTime_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 10;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.collectTimeToWaitToSeeIfMoreMotesComingIn_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.moteLifetime_ != 0f)
        {
                this.moteLifetime_ = other.moteLifetime_;
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
        
        if(other.maxVisibleMotesPerEssence_ != 0f)
        {
                this.maxVisibleMotesPerEssence_ = other.maxVisibleMotesPerEssence_;
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
        
        if(other.startingNumberOfMotes_ != 0f)
        {
                this.startingNumberOfMotes_ = other.startingNumberOfMotes_;
        }
        
        if(other.maxMotesPerEssence_ != 0f)
        {
                this.maxMotesPerEssence_ = other.maxMotesPerEssence_;
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
        
        if(other.collectFlushBatchTime_ != 0f)
        {
                this.collectFlushBatchTime_ = other.collectFlushBatchTime_;
        }
        
        if(other.collectTimeToWaitToSeeIfMoreMotesComingIn_ != 0f)
        {
                this.collectTimeToWaitToSeeIfMoreMotesComingIn_ = other.collectTimeToWaitToSeeIfMoreMotesComingIn_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_63;
        label_66:
        if(this > 73)
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
            goto label_40;
        }
        
        this.minOrbitRadius_ = input.ReadDouble();
        goto label_63;
        label_1:
        if(this > 113)
        {
            goto label_8;
        }
        
        if(this > 89)
        {
            goto label_9;
        }
        
        if(this == 81)
        {
            goto label_10;
        }
        
        if(this != 89)
        {
            goto label_40;
        }
        
        this.maxDegradeDistance_ = input.ReadDouble();
        goto label_63;
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
            goto label_40;
        }
        
        this.minAngleSpeedDegrees_ = input.ReadDouble();
        goto label_63;
        label_8:
        if(this > 129)
        {
            goto label_19;
        }
        
        if(this == 121)
        {
            goto label_20;
        }
        
        if(this != 129)
        {
            goto label_40;
        }
        
        this.detachedAcceleration_ = input.ReadDouble();
        goto label_63;
        label_3:
        if(this == 25)
        {
            goto label_24;
        }
        
        if(this != 33)
        {
            goto label_40;
        }
        
        this.spawnTime_ = input.ReadDouble();
        goto label_63;
        label_9:
        if(this == 97)
        {
            goto label_28;
        }
        
        if(this == 105)
        {
            goto label_29;
        }
        
        if(this != 113)
        {
            goto label_40;
        }
        
        this.minimumDetachedSpeed_ = input.ReadDouble();
        goto label_63;
        label_14:
        if(this == 57)
        {
            goto label_33;
        }
        
        if(this == 65)
        {
            goto label_34;
        }
        
        if(this != 73)
        {
            goto label_40;
        }
        
        this.minDegradeMultiplier_ = input.ReadDouble();
        goto label_63;
        label_19:
        if(this == 137)
        {
            goto label_38;
        }
        
        if(this == 145)
        {
            goto label_39;
        }
        
        if(this != 153)
        {
            goto label_40;
        }
        
        this.collectTimeToWaitToSeeIfMoreMotesComingIn_ = input.ReadDouble();
        goto label_63;
        label_40:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_63;
        label_4:
        this.moteLifetime_ = input.ReadDouble();
        goto label_63;
        label_10:
        this.minDegradeDistance_ = input.ReadDouble();
        goto label_63;
        label_15:
        this.maxVisibleMotesPerEssence_ = input.ReadDouble();
        goto label_63;
        label_20:
        this.maximumDetachedSpeed_ = input.ReadDouble();
        goto label_63;
        label_24:
        this.maxOrbitRadius_ = input.ReadDouble();
        goto label_63;
        label_28:
        this.startingNumberOfMotes_ = input.ReadDouble();
        goto label_63;
        label_29:
        this.maxMotesPerEssence_ = input.ReadDouble();
        goto label_63;
        label_33:
        this.maxAngleSpeedDegrees_ = input.ReadDouble();
        goto label_63;
        label_34:
        this.maxDegradeMultiplier_ = input.ReadDouble();
        goto label_63;
        label_38:
        this.detachedDeceleration_ = input.ReadDouble();
        goto label_63;
        label_39:
        this.collectFlushBatchTime_ = input.ReadDouble();
        label_63:
        if(input.ReadTag() != 0)
        {
            goto label_66;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.CollectTimeToWaitToSeeIfMoreMotesComingInFieldNumber = new Google.Protobuf.MessageParser<MOTES>(factory:  new System.Func<MOTES>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.<>c.<>9, method:  MOTES CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES.<>c::<.cctor>b__115_0()));
    }

}
