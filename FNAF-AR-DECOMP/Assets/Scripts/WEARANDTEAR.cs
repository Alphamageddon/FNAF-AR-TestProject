using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR : IMessage<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR>, IMessage, IEquatable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR>, IDeepCloneable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WearAndTearFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double wearAndTear_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double WearAndTear { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<WEARANDTEAR>)WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR.WearAndTearFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return WEARANDTEAR_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR other)
    {
        if(other != null)
        {
                this.wearAndTear_ = other.wearAndTear_;
        }
        else
        {
                this.wearAndTear_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR Clone()
    {
        return (WEARANDTEAR)new WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_WearAndTear()
    {
        return (double)this.wearAndTear_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WearAndTear(double value)
    {
        this.wearAndTear_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        WEARANDTEAR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR other)
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
        if(this.wearAndTear_ == 0f)
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
        if(this.wearAndTear_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.wearAndTear_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.wearAndTear_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.wearAndTear_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.wearAndTear_ != 0f)
        {
                this.wearAndTear_ = other.wearAndTear_;
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
        this.wearAndTear_ = input.ReadDouble();
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
    private static WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR()
    {
        null = null;
        WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR.WearAndTearFieldNumber = new Google.Protobuf.MessageParser<WEARANDTEAR>(factory:  new System.Func<WEARANDTEAR>(object:  WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR.<>c.<>9, method:  WEARANDTEAR WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR.<>c::<.cctor>b__25_0()));
    }

}
