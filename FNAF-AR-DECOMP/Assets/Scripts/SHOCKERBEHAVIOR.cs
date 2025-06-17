using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockerCooldownTimerFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shockerCooldownTimer_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShockerCooldownTimer { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SHOCKERBEHAVIOR>)CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.ShockerCooldownTimerFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR other)
    {
        if(other != null)
        {
                this.shockerCooldownTimer_ = other.shockerCooldownTimer_;
        }
        else
        {
                this.shockerCooldownTimer_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR Clone()
    {
        return (SHOCKERBEHAVIOR)new CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShockerCooldownTimer()
    {
        return (double)this.shockerCooldownTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShockerCooldownTimer(double value)
    {
        this.shockerCooldownTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SHOCKERBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR other)
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
        if(this.shockerCooldownTimer_ == 0f)
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
        if(this.shockerCooldownTimer_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.shockerCooldownTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.shockerCooldownTimer_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.shockerCooldownTimer_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.shockerCooldownTimer_ != 0f)
        {
                this.shockerCooldownTimer_ = other.shockerCooldownTimer_;
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
        this.shockerCooldownTimer_ = input.ReadDouble();
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
    private static CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.ShockerCooldownTimerFieldNumber = new Google.Protobuf.MessageParser<SHOCKERBEHAVIOR>(factory:  new System.Func<SHOCKERBEHAVIOR>(object:  CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.<>c.<>9, method:  SHOCKERBEHAVIOR CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR.<>c::<.cctor>b__25_0()));
    }

}
