using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF : IMessage<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF>, IMessage, IEquatable<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF>, IDeepCloneable<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RemnantCollectedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double remnantCollected_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockWindowIncreaseFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shockWindowIncrease_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RemnantCollected { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShockWindowIncrease { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<REMNANTDEBUFF>)REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.ShockWindowIncreaseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.REMNANT_DEBUFF_DATA.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF(ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF other)
    {
        if(other != null)
        {
                this.remnantCollected_ = other.remnantCollected_;
            this.shockWindowIncrease_ = other.shockWindowIncrease_;
        }
        else
        {
                this.remnantCollected_ = 7.42422564692724E-317;
            this.shockWindowIncrease_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF Clone()
    {
        return (REMNANTDEBUFF)new REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RemnantCollected()
    {
        return (double)this.remnantCollected_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RemnantCollected(double value)
    {
        this.remnantCollected_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShockWindowIncrease()
    {
        return (double)this.shockWindowIncrease_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShockWindowIncrease(double value)
    {
        this.shockWindowIncrease_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        REMNANTDEBUFF val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF other)
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
        
        val_4 = this.remnantCollected_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.shockWindowIncrease_;
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
        if(this.remnantCollected_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.shockWindowIncrease_ != 0f)
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
        if(this.remnantCollected_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.remnantCollected_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.remnantCollected_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.shockWindowIncrease_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.shockWindowIncrease_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.shockWindowIncrease_;
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
        var val_1 = (this.remnantCollected_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.shockWindowIncrease_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.remnantCollected_ != 0f)
        {
                this.remnantCollected_ = other.remnantCollected_;
        }
        
        if(other.shockWindowIncrease_ != 0f)
        {
                this.shockWindowIncrease_ = other.shockWindowIncrease_;
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
        this.remnantCollected_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.shockWindowIncrease_ = input.ReadDouble();
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
    private static REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF()
    {
        null = null;
        REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.ShockWindowIncreaseFieldNumber = new Google.Protobuf.MessageParser<REMNANTDEBUFF>(factory:  new System.Func<REMNANTDEBUFF>(object:  REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.<>c.<>9, method:  REMNANTDEBUFF REMNANT_DEBUFF_DATA.Types.REMNANTDEBUFF.<>c::<.cctor>b__30_0()));
    }

}
