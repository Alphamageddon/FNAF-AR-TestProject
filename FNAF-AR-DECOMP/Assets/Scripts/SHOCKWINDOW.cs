using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double min_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double max_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Min { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Max { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SHOCKWINDOW>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW.MaxFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW other)
    {
        if(other != null)
        {
                this.min_ = other.min_;
            this.max_ = other.max_;
        }
        else
        {
                this.min_ = 7.42422564692724E-317;
            this.max_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW Clone()
    {
        return (SHOCKWINDOW)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Min()
    {
        return (double)this.min_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Min(double value)
    {
        this.min_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Max()
    {
        return (double)this.max_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Max(double value)
    {
        this.max_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SHOCKWINDOW val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW other)
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
        
        val_4 = this.min_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.max_;
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
        if(this.min_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.max_ != 0f)
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
        if(this.min_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.min_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.min_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.max_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.max_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.max_;
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
        var val_1 = (this.min_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.max_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.min_ != 0f)
        {
                this.min_ = other.min_;
        }
        
        if(other.max_ != 0f)
        {
                this.max_ = other.max_;
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
        this.min_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.max_ = input.ReadDouble();
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
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW.MaxFieldNumber = new Google.Protobuf.MessageParser<SHOCKWINDOW>(factory:  new System.Func<SHOCKWINDOW>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW.<>c.<>9, method:  SHOCKWINDOW ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW.<>c::<.cctor>b__30_0()));
    }

}
