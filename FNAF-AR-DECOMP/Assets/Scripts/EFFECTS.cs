using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.EFFECTS : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShearFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shear_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AudioFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double audio_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Shear { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Audio { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EFFECTS>)STATIC_DATA.Types.ENTRY.Types.EFFECTS.AudioFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.EFFECTS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.EFFECTS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.EFFECTS(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS other)
    {
        if(other != null)
        {
                this.shear_ = other.shear_;
            this.audio_ = other.audio_;
        }
        else
        {
                this.shear_ = 7.42422564692724E-317;
            this.audio_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS Clone()
    {
        return (EFFECTS)new STATIC_DATA.Types.ENTRY.Types.EFFECTS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Shear()
    {
        return (double)this.shear_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Shear(double value)
    {
        this.shear_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Audio()
    {
        return (double)this.audio_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Audio(double value)
    {
        this.audio_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EFFECTS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS other)
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
        
        val_4 = this.shear_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.audio_;
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
        if(this.shear_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.audio_ != 0f)
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
        if(this.shear_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.shear_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.shear_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.audio_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.audio_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.audio_;
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
        var val_1 = (this.shear_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.audio_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.shear_ != 0f)
        {
                this.shear_ = other.shear_;
        }
        
        if(other.audio_ != 0f)
        {
                this.audio_ = other.audio_;
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
        this.shear_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.audio_ = input.ReadDouble();
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
    private static STATIC_DATA.Types.ENTRY.Types.EFFECTS()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS.AudioFieldNumber = new Google.Protobuf.MessageParser<EFFECTS>(factory:  new System.Func<EFFECTS>(object:  STATIC_DATA.Types.ENTRY.Types.EFFECTS.<>c.<>9, method:  EFFECTS STATIC_DATA.Types.ENTRY.Types.EFFECTS.<>c::<.cctor>b__30_0()));
    }

}
