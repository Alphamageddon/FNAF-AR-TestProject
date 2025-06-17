using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.FADESETTINGS : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeInFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double fadeIn_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeOutFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double fadeOut_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FadeIn { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FadeOut { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FADESETTINGS>)STATIC_DATA.Types.ENTRY.Types.FADESETTINGS.FadeOutFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.FADESETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.FADESETTINGS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.FADESETTINGS(ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS other)
    {
        if(other != null)
        {
                this.fadeIn_ = other.fadeIn_;
            this.fadeOut_ = other.fadeOut_;
        }
        else
        {
                this.fadeIn_ = 7.42422564692724E-317;
            this.fadeOut_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS Clone()
    {
        return (FADESETTINGS)new STATIC_DATA.Types.ENTRY.Types.FADESETTINGS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FadeIn()
    {
        return (double)this.fadeIn_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FadeIn(double value)
    {
        this.fadeIn_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FadeOut()
    {
        return (double)this.fadeOut_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FadeOut(double value)
    {
        this.fadeOut_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FADESETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS other)
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
        
        val_4 = this.fadeIn_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.fadeOut_;
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
        if(this.fadeIn_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.fadeOut_ != 0f)
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
        if(this.fadeIn_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.fadeIn_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.fadeIn_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.fadeOut_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.fadeOut_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.fadeOut_;
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
        var val_1 = (this.fadeIn_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.fadeOut_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.fadeIn_ != 0f)
        {
                this.fadeIn_ = other.fadeIn_;
        }
        
        if(other.fadeOut_ != 0f)
        {
                this.fadeOut_ = other.fadeOut_;
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
        this.fadeIn_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.fadeOut_ = input.ReadDouble();
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
    private static STATIC_DATA.Types.ENTRY.Types.FADESETTINGS()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS.FadeOutFieldNumber = new Google.Protobuf.MessageParser<FADESETTINGS>(factory:  new System.Func<FADESETTINGS>(object:  STATIC_DATA.Types.ENTRY.Types.FADESETTINGS.<>c.<>9, method:  FADESETTINGS STATIC_DATA.Types.ENTRY.Types.FADESETTINGS.<>c::<.cctor>b__30_0()));
    }

}
