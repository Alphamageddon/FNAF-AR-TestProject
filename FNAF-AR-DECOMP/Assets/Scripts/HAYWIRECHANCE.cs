using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE : IMessage<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE>, IMessage, IEquatable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE>, IDeepCloneable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChanceFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ModifierFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double modifier_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Chance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Modifier { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<HAYWIRECHANCE>)WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE.ModifierFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE other)
    {
        if(other != null)
        {
                this.chance_ = other.chance_;
            this.modifier_ = other.modifier_;
        }
        else
        {
                this.chance_ = 7.42422564692724E-317;
            this.modifier_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE Clone()
    {
        return (HAYWIRECHANCE)new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Chance()
    {
        return (double)this.chance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Chance(double value)
    {
        this.chance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Modifier()
    {
        return (double)this.modifier_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Modifier(double value)
    {
        this.modifier_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        HAYWIRECHANCE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE other)
    {
        var val_3;
        double val_4;
        var val_5;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_4 = this.chance_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.modifier_;
            val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_3 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.chance_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.modifier_ != 0f)
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_3;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields ^ val_3;
        return (int)val_3;
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
        if(this.chance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.chance_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.chance_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.modifier_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.modifier_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.modifier_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_1 = (this.chance_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.modifier_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.chance_ != 0f)
        {
                this.chance_ = other.chance_;
        }
        
        if(other.modifier_ != 0f)
        {
                this.modifier_ = other.modifier_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_3;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_3;
        label_6:
        this.chance_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.modifier_ = input.ReadDouble();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 9)
        {
            goto label_6;
        }
        
        if(val_4 == 17)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE()
    {
        null = null;
        WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE.ModifierFieldNumber = new Google.Protobuf.MessageParser<HAYWIRECHANCE>(factory:  new System.Func<HAYWIRECHANCE>(object:  WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE.<>c.<>9, method:  HAYWIRECHANCE WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE.<>c::<.cctor>b__30_0()));
    }

}
