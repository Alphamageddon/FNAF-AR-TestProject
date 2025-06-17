using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NumAnimatronicsNormalFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double numAnimatronicsNormal_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NumAnimatronicsMalfunctioningFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double numAnimatronicsMalfunctioning_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NumAnimatronicsNormal { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NumAnimatronicsMalfunctioning { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<NUMANIMATRONICS>)CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.NumAnimatronicsMalfunctioningFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[13];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS other)
    {
        if(other != null)
        {
                this.numAnimatronicsNormal_ = other.numAnimatronicsNormal_;
            this.numAnimatronicsMalfunctioning_ = other.numAnimatronicsMalfunctioning_;
        }
        else
        {
                this.numAnimatronicsNormal_ = 7.42422564692724E-317;
            this.numAnimatronicsMalfunctioning_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS Clone()
    {
        return (NUMANIMATRONICS)new CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NumAnimatronicsNormal()
    {
        return (double)this.numAnimatronicsNormal_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NumAnimatronicsNormal(double value)
    {
        this.numAnimatronicsNormal_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NumAnimatronicsMalfunctioning()
    {
        return (double)this.numAnimatronicsMalfunctioning_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NumAnimatronicsMalfunctioning(double value)
    {
        this.numAnimatronicsMalfunctioning_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        NUMANIMATRONICS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS other)
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
        
        val_4 = this.numAnimatronicsNormal_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.numAnimatronicsMalfunctioning_;
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
        if(this.numAnimatronicsNormal_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.numAnimatronicsMalfunctioning_ != 0f)
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
        if(this.numAnimatronicsNormal_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.numAnimatronicsNormal_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.numAnimatronicsNormal_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.numAnimatronicsMalfunctioning_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.numAnimatronicsMalfunctioning_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.numAnimatronicsMalfunctioning_;
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
        var val_1 = (this.numAnimatronicsNormal_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.numAnimatronicsMalfunctioning_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.numAnimatronicsNormal_ != 0f)
        {
                this.numAnimatronicsNormal_ = other.numAnimatronicsNormal_;
        }
        
        if(other.numAnimatronicsMalfunctioning_ != 0f)
        {
                this.numAnimatronicsMalfunctioning_ = other.numAnimatronicsMalfunctioning_;
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
        this.numAnimatronicsNormal_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.numAnimatronicsMalfunctioning_ = input.ReadDouble();
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
    private static CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.NumAnimatronicsMalfunctioningFieldNumber = new Google.Protobuf.MessageParser<NUMANIMATRONICS>(factory:  new System.Func<NUMANIMATRONICS>(object:  CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.<>c.<>9, method:  NUMANIMATRONICS CONFIG_DATA.Types.ENTRY.Types.NUMANIMATRONICS.<>c::<.cctor>b__30_0()));
    }

}
