using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.BATTERY.Types.HAYWIRE : IMessage<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockDrainFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shockDrain_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShockDrain { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<HAYWIRE>)ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.ShockDrainFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.BATTERY.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY.Types.HAYWIRE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY.Types.HAYWIRE(ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE other)
    {
        if(other != null)
        {
                this.shockDrain_ = other.shockDrain_;
        }
        else
        {
                this.shockDrain_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE Clone()
    {
        return (HAYWIRE)new ATTACK_DATA.Types.BATTERY.Types.HAYWIRE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShockDrain()
    {
        return (double)this.shockDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShockDrain(double value)
    {
        this.shockDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        HAYWIRE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE other)
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
        if(this.shockDrain_ == 0f)
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
        if(this.shockDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.shockDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.shockDrain_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.shockDrain_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.shockDrain_ != 0f)
        {
                this.shockDrain_ = other.shockDrain_;
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
        this.shockDrain_ = input.ReadDouble();
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
    private static ATTACK_DATA.Types.BATTERY.Types.HAYWIRE()
    {
        null = null;
        ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.ShockDrainFieldNumber = new Google.Protobuf.MessageParser<HAYWIRE>(factory:  new System.Func<HAYWIRE>(object:  ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.<>c.<>9, method:  HAYWIRE ATTACK_DATA.Types.BATTERY.Types.HAYWIRE.<>c::<.cctor>b__25_0()));
    }

}
