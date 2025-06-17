using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachFrequencyFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double detachFrequency_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaximumDetachedFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maximumDetached_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectDistanceFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectDistance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectionScreenPointXFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectionScreenPointX_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectionScreenPointYFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectionScreenPointY_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectDistanceMoteFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectDistanceMote_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CollectDistanceThreatFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double collectDistanceThreat_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachFrequency { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaximumDetached { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectionScreenPointX { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectionScreenPointY { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectDistanceMote { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CollectDistanceThreat { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PARTICLEVACUUM>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.CollectDistanceThreatFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM other)
    {
        if(other != null)
        {
                this.detachFrequency_ = other.detachFrequency_;
            this.maximumDetached_ = other.maximumDetached_;
            this.collectDistance_ = other.collectDistance_;
            this.collectionScreenPointX_ = other.collectionScreenPointX_;
            this.collectionScreenPointY_ = other.collectionScreenPointY_;
            this.collectDistanceMote_ = other.collectDistanceMote_;
            this.collectDistanceThreat_ = other.collectDistanceThreat_;
        }
        else
        {
                this.detachFrequency_ = 7.42422564692724E-317;
            this.maximumDetached_ = 3.16202013338398E-322;
            this.collectDistance_ = 3.41288492945375E-316;
            this.collectionScreenPointX_ = 1.33509863819657E-307;
            this.collectionScreenPointY_ = 3.75487155418531E-308;
            this.collectDistanceMote_ = 1.06099789553204E-313;
            this.collectDistanceThreat_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM Clone()
    {
        return (PARTICLEVACUUM)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DetachFrequency()
    {
        return (double)this.detachFrequency_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachFrequency(double value)
    {
        this.detachFrequency_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaximumDetached()
    {
        return (double)this.maximumDetached_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaximumDetached(double value)
    {
        this.maximumDetached_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectDistance()
    {
        return (double)this.collectDistance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectDistance(double value)
    {
        this.collectDistance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectionScreenPointX()
    {
        return (double)this.collectionScreenPointX_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectionScreenPointX(double value)
    {
        this.collectionScreenPointX_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectionScreenPointY()
    {
        return (double)this.collectionScreenPointY_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectionScreenPointY(double value)
    {
        this.collectionScreenPointY_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectDistanceMote()
    {
        return (double)this.collectDistanceMote_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectDistanceMote(double value)
    {
        this.collectDistanceMote_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CollectDistanceThreat()
    {
        return (double)this.collectDistanceThreat_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CollectDistanceThreat(double value)
    {
        this.collectDistanceThreat_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PARTICLEVACUUM val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM other)
    {
        var val_8;
        double val_9;
        var val_10;
        if(other == null)
        {
            goto label_30;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_9 = this.detachFrequency_;
        val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_8 & 1) != 0)
        {
                val_9 = this.maximumDetached_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.collectDistance_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.collectionScreenPointX_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.collectionScreenPointY_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.collectDistanceMote_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                val_9 = this.collectDistanceThreat_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_30:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        val_10 = 1;
        return (bool)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_8;
        if(this.detachFrequency_ == 0f)
        {
                val_8 = 1;
        }
        else
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.maximumDetached_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.collectDistance_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.collectionScreenPointX_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.collectionScreenPointY_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.collectDistanceMote_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.collectDistanceThreat_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
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
        double val_5;
        double val_6;
        double val_7;
        if(this.detachFrequency_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.detachFrequency_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.detachFrequency_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.maximumDetached_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.maximumDetached_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.maximumDetached_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.collectDistance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_3 = this.collectDistance_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_3 = this.collectDistance_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.collectionScreenPointX_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_4 = this.collectionScreenPointX_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_4 = this.collectionScreenPointX_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.collectionScreenPointY_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_5 = this.collectionScreenPointY_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_5 = this.collectionScreenPointY_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.collectDistanceMote_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  81);
            val_6 = this.collectDistanceMote_;
        }
        else
        {
                0.WriteRawTag(b1:  81);
            val_6 = this.collectDistanceMote_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.collectDistanceThreat_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  89);
            val_7 = this.collectDistanceThreat_;
        }
        else
        {
                0.WriteRawTag(b1:  89);
            val_7 = this.collectDistanceThreat_;
        }
        
            output.WriteDouble(value:  val_7);
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
        var val_1 = (this.detachFrequency_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.maximumDetached_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.collectDistance_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.collectionScreenPointX_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.collectionScreenPointY_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.collectDistanceMote_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.collectDistanceThreat_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.detachFrequency_ != 0f)
        {
                this.detachFrequency_ = other.detachFrequency_;
        }
        
        if(other.maximumDetached_ != 0f)
        {
                this.maximumDetached_ = other.maximumDetached_;
        }
        
        if(other.collectDistance_ != 0f)
        {
                this.collectDistance_ = other.collectDistance_;
        }
        
        if(other.collectionScreenPointX_ != 0f)
        {
                this.collectionScreenPointX_ = other.collectionScreenPointX_;
        }
        
        if(other.collectionScreenPointY_ != 0f)
        {
                this.collectionScreenPointY_ = other.collectionScreenPointY_;
        }
        
        if(other.collectDistanceMote_ != 0f)
        {
                this.collectDistanceMote_ = other.collectDistanceMote_;
        }
        
        if(other.collectDistanceThreat_ != 0f)
        {
                this.collectDistanceThreat_ = other.collectDistanceThreat_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_22;
        label_25:
        if(this > 57)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this == 17)
        {
            goto label_3;
        }
        
        if(this != 57)
        {
            goto label_13;
        }
        
        this.collectDistance_ = input.ReadDouble();
        goto label_22;
        label_1:
        if(this > 73)
        {
            goto label_7;
        }
        
        if(this == 65)
        {
            goto label_8;
        }
        
        if(this != 73)
        {
            goto label_13;
        }
        
        this.collectionScreenPointY_ = input.ReadDouble();
        goto label_22;
        label_7:
        if(this == 81)
        {
            goto label_12;
        }
        
        if(this != 89)
        {
            goto label_13;
        }
        
        this.collectDistanceThreat_ = input.ReadDouble();
        goto label_22;
        label_13:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_22;
        label_2:
        this.detachFrequency_ = input.ReadDouble();
        goto label_22;
        label_3:
        this.maximumDetached_ = input.ReadDouble();
        goto label_22;
        label_8:
        this.collectionScreenPointX_ = input.ReadDouble();
        goto label_22;
        label_12:
        this.collectDistanceMote_ = input.ReadDouble();
        label_22:
        if(input.ReadTag() != 0)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.CollectDistanceThreatFieldNumber = new Google.Protobuf.MessageParser<PARTICLEVACUUM>(factory:  new System.Func<PARTICLEVACUUM>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.<>c.<>9, method:  PARTICLEVACUUM CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM.<>c::<.cctor>b__55_0()));
    }

}
