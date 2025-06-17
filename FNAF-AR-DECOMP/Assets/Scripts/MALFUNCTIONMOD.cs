using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD : IMessage<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD>, IMessage, IEquatable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD>, IDeepCloneable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunction_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Malfunction { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MALFUNCTIONMOD>)WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD.MalfunctionFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return WEARANDTEAR_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD other)
    {
        if(other != null)
        {
                this.malfunction_ = other.malfunction_;
        }
        else
        {
                this.malfunction_ = 7.42422564692724E-317;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD Clone()
    {
        return (MALFUNCTIONMOD)new WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Malfunction()
    {
        return (double)this.malfunction_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Malfunction(double value)
    {
        this.malfunction_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MALFUNCTIONMOD val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD other)
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
        if(this.malfunction_ == 0f)
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
        if(this.malfunction_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.malfunction_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.malfunction_;
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
        
        val_3 = this._unknownFields.CalculateSize() + ((this.malfunction_ == 0f) ? 0 : 9);
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.malfunction_ != 0f)
        {
                this.malfunction_ = other.malfunction_;
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
        this.malfunction_ = input.ReadDouble();
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
    private static WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD()
    {
        null = null;
        WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD.MalfunctionFieldNumber = new Google.Protobuf.MessageParser<MALFUNCTIONMOD>(factory:  new System.Func<MALFUNCTIONMOD>(object:  WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD.<>c.<>9, method:  MALFUNCTIONMOD WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD.<>c::<.cctor>b__25_0()));
    }

}
