using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RarityBonusFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rarityBonus_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RarityBonus { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EMFMETER>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.RarityBonusFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER other)
    {
        if(other != null)
        {
                this.rarityBonus_ = other.rarityBonus_;
        }
        else
        {
                this.rarityBonus_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER Clone()
    {
        return (EMFMETER)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RarityBonus()
    {
        return (double)this.rarityBonus_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RarityBonus(double value)
    {
        this.rarityBonus_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EMFMETER val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER other)
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
        if(this.rarityBonus_ == 0f)
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
        if(this.rarityBonus_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.rarityBonus_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.rarityBonus_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.rarityBonus_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.rarityBonus_ != 0f)
        {
                this.rarityBonus_ = other.rarityBonus_;
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
        this.rarityBonus_ = input.ReadDouble();
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
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.RarityBonusFieldNumber = new Google.Protobuf.MessageParser<EMFMETER>(factory:  new System.Func<EMFMETER>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.<>c.<>9, method:  EMFMETER DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EMFMETER.<>c::<.cctor>b__25_0()));
    }

}
