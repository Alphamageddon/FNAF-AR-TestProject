using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ObjectDetectionPeriodFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double objectDetectionPeriod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceTrailDurFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double essenceTrailDur_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceObjectDurFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double essenceObjectDur_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BaseDisplayChanceFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double baseDisplayChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HorizonModFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double horizonMod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HorizonBufferFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double horizonBuffer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ConfidenceFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double confidence_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GlobalCooldownFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double globalCooldown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CategoryCooldownFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double categoryCooldown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CategoryStreakbreakerFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double categoryStreakbreaker_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DistanceFromCameraFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double distanceFromCamera_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ARObjectToEssenceDelayFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double aRObjectToEssenceDelay_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int OverrideCooldownFieldNumber = 13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double overrideCooldown_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ObjectDetectionPeriod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double EssenceTrailDur { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double EssenceObjectDur { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BaseDisplayChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double HorizonMod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double HorizonBuffer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Confidence { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double GlobalCooldown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CategoryCooldown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CategoryStreakbreaker { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DistanceFromCamera { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ARObjectToEssenceDelay { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double OverrideCooldown { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DETECT>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.OverrideCooldownFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT other)
    {
        if(other != null)
        {
                this.objectDetectionPeriod_ = other.objectDetectionPeriod_;
            this.essenceTrailDur_ = other.essenceTrailDur_;
            this.essenceObjectDur_ = other.essenceObjectDur_;
            this.baseDisplayChance_ = other.baseDisplayChance_;
            this.horizonMod_ = other.horizonMod_;
            this.horizonBuffer_ = other.horizonBuffer_;
            this.confidence_ = other.confidence_;
            this.globalCooldown_ = other.globalCooldown_;
            this.categoryCooldown_ = other.categoryCooldown_;
            this.categoryStreakbreaker_ = other.categoryStreakbreaker_;
            this.distanceFromCamera_ = other.distanceFromCamera_;
            this.aRObjectToEssenceDelay_ = other.aRObjectToEssenceDelay_;
            this.overrideCooldown_ = other.overrideCooldown_;
        }
        else
        {
                this.objectDetectionPeriod_ = 7.42422564692724E-317;
            this.essenceTrailDur_ = 3.16202013338398E-322;
            this.essenceObjectDur_ = 3.41288492945375E-316;
            this.baseDisplayChance_ = 1.33509863819657E-307;
            this.horizonMod_ = 3.75487155418531E-308;
            this.horizonBuffer_ = 1.06099789553204E-313;
            this.confidence_ = 0;
            this.globalCooldown_ = 0;
            this.categoryCooldown_ = 0;
            this.categoryStreakbreaker_ = 3.09235747019914E-316;
            this.distanceFromCamera_ = 3.09235747019914E-316;
            this.aRObjectToEssenceDelay_ = 3.23790861658519E-319;
            this.overrideCooldown_ = 1.27319747462857E-313;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT Clone()
    {
        return (DETECT)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ObjectDetectionPeriod()
    {
        return (double)this.objectDetectionPeriod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ObjectDetectionPeriod(double value)
    {
        this.objectDetectionPeriod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_EssenceTrailDur()
    {
        return (double)this.essenceTrailDur_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceTrailDur(double value)
    {
        this.essenceTrailDur_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_EssenceObjectDur()
    {
        return (double)this.essenceObjectDur_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceObjectDur(double value)
    {
        this.essenceObjectDur_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BaseDisplayChance()
    {
        return (double)this.baseDisplayChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BaseDisplayChance(double value)
    {
        this.baseDisplayChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_HorizonMod()
    {
        return (double)this.horizonMod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HorizonMod(double value)
    {
        this.horizonMod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_HorizonBuffer()
    {
        return (double)this.horizonBuffer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HorizonBuffer(double value)
    {
        this.horizonBuffer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Confidence()
    {
        return (double)this.confidence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Confidence(double value)
    {
        this.confidence_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_GlobalCooldown()
    {
        return (double)this.globalCooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GlobalCooldown(double value)
    {
        this.globalCooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CategoryCooldown()
    {
        return (double)this.categoryCooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CategoryCooldown(double value)
    {
        this.categoryCooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CategoryStreakbreaker()
    {
        return (double)this.categoryStreakbreaker_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CategoryStreakbreaker(double value)
    {
        this.categoryStreakbreaker_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DistanceFromCamera()
    {
        return (double)this.distanceFromCamera_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DistanceFromCamera(double value)
    {
        this.distanceFromCamera_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ARObjectToEssenceDelay()
    {
        return (double)this.aRObjectToEssenceDelay_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ARObjectToEssenceDelay(double value)
    {
        this.aRObjectToEssenceDelay_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_OverrideCooldown()
    {
        return (double)this.overrideCooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_OverrideCooldown(double value)
    {
        this.overrideCooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DETECT val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT other)
    {
        var val_14;
        double val_15;
        var val_16;
        if(other == null)
        {
            goto label_54;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_15 = this.objectDetectionPeriod_;
        val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_14 & 1) == 0)
        {
            goto label_54;
        }
        
        val_15 = this.essenceTrailDur_;
        val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_14 & 1) == 0)
        {
            goto label_54;
        }
        
        val_15 = this.essenceObjectDur_;
        val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_14 & 1) == 0)
        {
            goto label_54;
        }
        
        val_15 = this.baseDisplayChance_;
        val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_14 & 1) != 0)
        {
                val_15 = this.horizonMod_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.horizonBuffer_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.confidence_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.globalCooldown_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.categoryCooldown_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.categoryStreakbreaker_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.distanceFromCamera_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.aRObjectToEssenceDelay_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
        {
                val_15 = this.overrideCooldown_;
            val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_14 & 1) != 0)
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
        
        label_54:
        val_16 = 0;
        return (bool)val_16;
        label_2:
        val_16 = 1;
        return (bool)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_14;
        if(this.objectDetectionPeriod_ == 0f)
        {
                val_14 = 1;
        }
        else
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.essenceTrailDur_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.essenceObjectDur_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.baseDisplayChance_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.horizonMod_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.horizonBuffer_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.confidence_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.globalCooldown_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.categoryCooldown_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.categoryStreakbreaker_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.distanceFromCamera_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.aRObjectToEssenceDelay_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this.overrideCooldown_ != 0f)
        {
                val_14 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_14;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_14;
        }
        
        val_14 = this._unknownFields ^ val_14;
        return (int)val_14;
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
        if(this.objectDetectionPeriod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.objectDetectionPeriod_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.objectDetectionPeriod_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.essenceTrailDur_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.essenceTrailDur_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.essenceTrailDur_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.essenceObjectDur_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.essenceObjectDur_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.essenceObjectDur_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.baseDisplayChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.baseDisplayChance_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.baseDisplayChance_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.horizonMod_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.horizonMod_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.horizonMod_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.horizonBuffer_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.horizonBuffer_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.horizonBuffer_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.confidence_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.confidence_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.confidence_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.globalCooldown_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.globalCooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.globalCooldown_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.categoryCooldown_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_9 = this.categoryCooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_9 = this.categoryCooldown_;
        }
        
            output.WriteDouble(value:  val_9);
        }
        
        if(this.categoryStreakbreaker_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  81);
            val_10 = this.categoryStreakbreaker_;
        }
        else
        {
                0.WriteRawTag(b1:  81);
            val_10 = this.categoryStreakbreaker_;
        }
        
            output.WriteDouble(value:  val_10);
        }
        
        if(this.distanceFromCamera_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  89);
            val_11 = this.distanceFromCamera_;
        }
        else
        {
                0.WriteRawTag(b1:  89);
            val_11 = this.distanceFromCamera_;
        }
        
            output.WriteDouble(value:  val_11);
        }
        
        if(this.aRObjectToEssenceDelay_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  97);
            val_12 = this.aRObjectToEssenceDelay_;
        }
        else
        {
                0.WriteRawTag(b1:  97);
            val_12 = this.aRObjectToEssenceDelay_;
        }
        
            output.WriteDouble(value:  val_12);
        }
        
        if(this.overrideCooldown_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  105);
            val_13 = this.overrideCooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  105);
            val_13 = this.overrideCooldown_;
        }
        
            output.WriteDouble(value:  val_13);
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
        var val_1 = (this.objectDetectionPeriod_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.essenceTrailDur_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.essenceObjectDur_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.baseDisplayChance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.horizonMod_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.horizonBuffer_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.confidence_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.globalCooldown_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.categoryCooldown_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.categoryStreakbreaker_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.distanceFromCamera_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.aRObjectToEssenceDelay_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.overrideCooldown_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.objectDetectionPeriod_ != 0f)
        {
                this.objectDetectionPeriod_ = other.objectDetectionPeriod_;
        }
        
        if(other.essenceTrailDur_ != 0f)
        {
                this.essenceTrailDur_ = other.essenceTrailDur_;
        }
        
        if(other.essenceObjectDur_ != 0f)
        {
                this.essenceObjectDur_ = other.essenceObjectDur_;
        }
        
        if(other.baseDisplayChance_ != 0f)
        {
                this.baseDisplayChance_ = other.baseDisplayChance_;
        }
        
        if(other.horizonMod_ != 0f)
        {
                this.horizonMod_ = other.horizonMod_;
        }
        
        if(other.horizonBuffer_ != 0f)
        {
                this.horizonBuffer_ = other.horizonBuffer_;
        }
        
        if(other.confidence_ != 0f)
        {
                this.confidence_ = other.confidence_;
        }
        
        if(other.globalCooldown_ != 0f)
        {
                this.globalCooldown_ = other.globalCooldown_;
        }
        
        if(other.categoryCooldown_ != 0f)
        {
                this.categoryCooldown_ = other.categoryCooldown_;
        }
        
        if(other.categoryStreakbreaker_ != 0f)
        {
                this.categoryStreakbreaker_ = other.categoryStreakbreaker_;
        }
        
        if(other.distanceFromCamera_ != 0f)
        {
                this.distanceFromCamera_ = other.distanceFromCamera_;
        }
        
        if(other.aRObjectToEssenceDelay_ != 0f)
        {
                this.aRObjectToEssenceDelay_ = other.aRObjectToEssenceDelay_;
        }
        
        if(other.overrideCooldown_ != 0f)
        {
                this.overrideCooldown_ = other.overrideCooldown_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_42;
        label_45:
        if(this > 49)
        {
            goto label_1;
        }
        
        if(this > 25)
        {
            goto label_2;
        }
        
        if(this == 9)
        {
            goto label_3;
        }
        
        if(this == 17)
        {
            goto label_4;
        }
        
        if(this != 25)
        {
            goto label_25;
        }
        
        this.essenceObjectDur_ = input.ReadDouble();
        goto label_42;
        label_1:
        if(this > 73)
        {
            goto label_8;
        }
        
        if(this == 57)
        {
            goto label_9;
        }
        
        if(this == 65)
        {
            goto label_10;
        }
        
        if(this != 73)
        {
            goto label_25;
        }
        
        this.categoryCooldown_ = input.ReadDouble();
        goto label_42;
        label_2:
        if(this == 33)
        {
            goto label_14;
        }
        
        if(this == 41)
        {
            goto label_15;
        }
        
        if(this != 49)
        {
            goto label_25;
        }
        
        this.horizonBuffer_ = input.ReadDouble();
        goto label_42;
        label_8:
        if(this > 89)
        {
            goto label_19;
        }
        
        if(this == 81)
        {
            goto label_20;
        }
        
        if(this != 89)
        {
            goto label_25;
        }
        
        this.distanceFromCamera_ = input.ReadDouble();
        goto label_42;
        label_19:
        if(this == 97)
        {
            goto label_24;
        }
        
        if(this != 105)
        {
            goto label_25;
        }
        
        this.overrideCooldown_ = input.ReadDouble();
        goto label_42;
        label_25:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_42;
        label_3:
        this.objectDetectionPeriod_ = input.ReadDouble();
        goto label_42;
        label_4:
        this.essenceTrailDur_ = input.ReadDouble();
        goto label_42;
        label_9:
        this.confidence_ = input.ReadDouble();
        goto label_42;
        label_10:
        this.globalCooldown_ = input.ReadDouble();
        goto label_42;
        label_14:
        this.baseDisplayChance_ = input.ReadDouble();
        goto label_42;
        label_15:
        this.horizonMod_ = input.ReadDouble();
        goto label_42;
        label_20:
        this.categoryStreakbreaker_ = input.ReadDouble();
        goto label_42;
        label_24:
        this.aRObjectToEssenceDelay_ = input.ReadDouble();
        label_42:
        if(input.ReadTag() != 0)
        {
            goto label_45;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.OverrideCooldownFieldNumber = new Google.Protobuf.MessageParser<DETECT>(factory:  new System.Func<DETECT>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.<>c.<>9, method:  DETECT CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT.<>c::<.cctor>b__85_0()));
    }

}
