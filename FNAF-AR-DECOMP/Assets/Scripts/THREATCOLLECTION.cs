using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ThreatPercentPerThreatPillFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double threatPercentPerThreatPill_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DropPerSecondFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double dropPerSecond_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ConsecutiveThreatPercentMultFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double consecutiveThreatPercentMult_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ThreatPercentPerThreatPill { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DropPerSecond { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ConsecutiveThreatPercentMult { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<THREATCOLLECTION>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.ConsecutiveThreatPercentMultFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[7];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION other)
    {
        if(other != null)
        {
                this.threatPercentPerThreatPill_ = other.threatPercentPerThreatPill_;
            this.dropPerSecond_ = other.dropPerSecond_;
            this.consecutiveThreatPercentMult_ = other.consecutiveThreatPercentMult_;
        }
        else
        {
                this.threatPercentPerThreatPill_ = 7.42422564692724E-317;
            this.dropPerSecond_ = 3.16202013338398E-322;
            this.consecutiveThreatPercentMult_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION Clone()
    {
        return (THREATCOLLECTION)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ThreatPercentPerThreatPill()
    {
        return (double)this.threatPercentPerThreatPill_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThreatPercentPerThreatPill(double value)
    {
        this.threatPercentPerThreatPill_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DropPerSecond()
    {
        return (double)this.dropPerSecond_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DropPerSecond(double value)
    {
        this.dropPerSecond_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ConsecutiveThreatPercentMult()
    {
        return (double)this.consecutiveThreatPercentMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ConsecutiveThreatPercentMult(double value)
    {
        this.consecutiveThreatPercentMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        THREATCOLLECTION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION other)
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
        
        val_5 = this.threatPercentPerThreatPill_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.dropPerSecond_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.consecutiveThreatPercentMult_;
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
        if(this.threatPercentPerThreatPill_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.dropPerSecond_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.consecutiveThreatPercentMult_ != 0f)
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
        if(this.threatPercentPerThreatPill_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.threatPercentPerThreatPill_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.threatPercentPerThreatPill_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.dropPerSecond_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.dropPerSecond_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.dropPerSecond_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.consecutiveThreatPercentMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.consecutiveThreatPercentMult_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.consecutiveThreatPercentMult_;
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
        var val_1 = (this.threatPercentPerThreatPill_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.dropPerSecond_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.consecutiveThreatPercentMult_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.threatPercentPerThreatPill_ != 0f)
        {
                this.threatPercentPerThreatPill_ = other.threatPercentPerThreatPill_;
        }
        
        if(other.dropPerSecond_ != 0f)
        {
                this.dropPerSecond_ = other.dropPerSecond_;
        }
        
        if(other.consecutiveThreatPercentMult_ != 0f)
        {
                this.consecutiveThreatPercentMult_ = other.consecutiveThreatPercentMult_;
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
        
        this.consecutiveThreatPercentMult_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.threatPercentPerThreatPill_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.dropPerSecond_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.ConsecutiveThreatPercentMultFieldNumber = new Google.Protobuf.MessageParser<THREATCOLLECTION>(factory:  new System.Func<THREATCOLLECTION>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.<>c.<>9, method:  THREATCOLLECTION CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION.<>c::<.cctor>b__35_0()));
    }

}
