using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH : IMessage<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH>, IDeepCloneable<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NotUpgradedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double notUpgraded_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NotUpgraded { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MAPSPEEDMPH>)CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.NotUpgradedFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CPU_DATA.Types.SPEEDMPH.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH(ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH other)
    {
        if(other != null)
        {
                this.notUpgraded_ = other.notUpgraded_;
        }
        else
        {
                this.notUpgraded_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH Clone()
    {
        return (MAPSPEEDMPH)new CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NotUpgraded()
    {
        return (double)this.notUpgraded_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NotUpgraded(double value)
    {
        this.notUpgraded_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MAPSPEEDMPH val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH other)
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
        if(this.notUpgraded_ == 0f)
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
        if(this.notUpgraded_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.notUpgraded_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.notUpgraded_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.notUpgraded_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.notUpgraded_ != 0f)
        {
                this.notUpgraded_ = other.notUpgraded_;
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
        this.notUpgraded_ = input.ReadDouble();
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
    private static CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH()
    {
        null = null;
        CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.NotUpgradedFieldNumber = new Google.Protobuf.MessageParser<MAPSPEEDMPH>(factory:  new System.Func<MAPSPEEDMPH>(object:  CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.<>c.<>9, method:  MAPSPEEDMPH CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH.<>c::<.cctor>b__25_0()));
    }

}
