using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.FLASHLIGHTREPOSITION : IMessage<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int IncreaseTimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double increaseTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DecreaseTimeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double decreaseTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double IncreaseTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DecreaseTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FLASHLIGHTREPOSITION>)ATTACK_DATA.Types.FLASHLIGHTREPOSITION.DecreaseTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[12];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.FLASHLIGHTREPOSITION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FLASHLIGHTREPOSITION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FLASHLIGHTREPOSITION(ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION other)
    {
        if(other != null)
        {
                this.increaseTime_ = other.increaseTime_;
            this.decreaseTime_ = other.decreaseTime_;
        }
        else
        {
                this.increaseTime_ = 7.42422564692724E-317;
            this.decreaseTime_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION Clone()
    {
        return (FLASHLIGHTREPOSITION)new ATTACK_DATA.Types.FLASHLIGHTREPOSITION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_IncreaseTime()
    {
        return (double)this.increaseTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_IncreaseTime(double value)
    {
        this.increaseTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DecreaseTime()
    {
        return (double)this.decreaseTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DecreaseTime(double value)
    {
        this.decreaseTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FLASHLIGHTREPOSITION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION other)
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
        
        val_4 = this.increaseTime_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.decreaseTime_;
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
        if(this.increaseTime_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.decreaseTime_ != 0f)
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
        if(this.increaseTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.increaseTime_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.increaseTime_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.decreaseTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.decreaseTime_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.decreaseTime_;
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
        var val_1 = (this.increaseTime_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.decreaseTime_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.FLASHLIGHTREPOSITION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.increaseTime_ != 0f)
        {
                this.increaseTime_ = other.increaseTime_;
        }
        
        if(other.decreaseTime_ != 0f)
        {
                this.decreaseTime_ = other.decreaseTime_;
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
        this.increaseTime_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.decreaseTime_ = input.ReadDouble();
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
    private static ATTACK_DATA.Types.FLASHLIGHTREPOSITION()
    {
        null = null;
        ATTACK_DATA.Types.FLASHLIGHTREPOSITION.DecreaseTimeFieldNumber = new Google.Protobuf.MessageParser<FLASHLIGHTREPOSITION>(factory:  new System.Func<FLASHLIGHTREPOSITION>(object:  ATTACK_DATA.Types.FLASHLIGHTREPOSITION.<>c.<>9, method:  FLASHLIGHTREPOSITION ATTACK_DATA.Types.FLASHLIGHTREPOSITION.<>c::<.cctor>b__30_0()));
    }

}
