using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SetRechargeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double setRecharge_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SetRecharge { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SUPERSHOCKER>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.SetRechargeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER other)
    {
        if(other != null)
        {
                this.setRecharge_ = other.setRecharge_;
        }
        else
        {
                this.setRecharge_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER Clone()
    {
        return (SUPERSHOCKER)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SetRecharge()
    {
        return (double)this.setRecharge_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SetRecharge(double value)
    {
        this.setRecharge_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SUPERSHOCKER val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER other)
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
        if(this.setRecharge_ == 0f)
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
        if(this.setRecharge_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.setRecharge_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.setRecharge_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.setRecharge_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.setRecharge_ != 0f)
        {
                this.setRecharge_ = other.setRecharge_;
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
        this.setRecharge_ = input.ReadDouble();
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
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.SetRechargeFieldNumber = new Google.Protobuf.MessageParser<SUPERSHOCKER>(factory:  new System.Func<SUPERSHOCKER>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.<>c.<>9, method:  SUPERSHOCKER DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SUPERSHOCKER.<>c::<.cctor>b__25_0()));
    }

}
