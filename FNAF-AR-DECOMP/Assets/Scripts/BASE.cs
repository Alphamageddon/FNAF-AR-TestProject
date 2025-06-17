using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.BATTERY.Types.BASE : IMessage<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BaseDrainFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double baseDrain_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BaseDrain { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BASE>)ATTACK_DATA.Types.BATTERY.Types.BASE.BaseDrainFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.BATTERY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.BATTERY.Types.BASE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY.Types.BASE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY.Types.BASE(ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE other)
    {
        if(other != null)
        {
                this.baseDrain_ = other.baseDrain_;
        }
        else
        {
                this.baseDrain_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE Clone()
    {
        return (BASE)new ATTACK_DATA.Types.BATTERY.Types.BASE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BaseDrain()
    {
        return (double)this.baseDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BaseDrain(double value)
    {
        this.baseDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BASE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE other)
    {
        var val_2;
        if(other == null)
        {
            goto label_6;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_6:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        if(this.baseDrain_ == 0f)
        {
                val_2 = 1;
        }
        else
        {
                val_2 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_2;
        }
        
        val_2 = this._unknownFields ^ val_2;
        return (int)val_2;
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
        if(this.baseDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.baseDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.baseDrain_;
        }
        
            output.WriteDouble(value:  val_1);
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
        var val_3;
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + ((this.baseDrain_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.baseDrain_ != 0f)
        {
                this.baseDrain_ = other.baseDrain_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_1;
        label_5:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_1;
        label_4:
        this.baseDrain_ = input.ReadDouble();
        label_1:
        uint val_3 = input.ReadTag();
        if(val_3 == 9)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.BATTERY.Types.BASE()
    {
        null = null;
        ATTACK_DATA.Types.BATTERY.Types.BASE.BaseDrainFieldNumber = new Google.Protobuf.MessageParser<BASE>(factory:  new System.Func<BASE>(object:  ATTACK_DATA.Types.BATTERY.Types.BASE.<>c.<>9, method:  BASE ATTACK_DATA.Types.BATTERY.Types.BASE.<>c::<.cctor>b__25_0()));
    }

}
