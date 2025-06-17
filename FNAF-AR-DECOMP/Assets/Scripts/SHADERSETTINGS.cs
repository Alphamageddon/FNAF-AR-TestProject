using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShearFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shear_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shake_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AudioFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double audio_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Shear { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Shake { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Audio { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SHADERSETTINGS>)STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS.AudioFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS(ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS other)
    {
        if(other != null)
        {
                this.shear_ = other.shear_;
            this.shake_ = other.shake_;
            this.audio_ = other.audio_;
        }
        else
        {
                this.shear_ = 7.42422564692724E-317;
            this.shake_ = 3.16202013338398E-322;
            this.audio_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS Clone()
    {
        return (SHADERSETTINGS)new STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS(other:  this);
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
    public double get_Shake()
    {
        return (double)this.shake_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Shake(double value)
    {
        this.shake_ = value;
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
        SHADERSETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.shear_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.shake_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.audio_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_14:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.shear_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.shake_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.audio_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
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
        double val_3;
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
        
        if(this.shake_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.shake_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.shake_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.audio_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.audio_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.audio_;
        }
        
            output.WriteDouble(value:  val_3);
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
        var val_2 = val_1 + 9;
        val_1 = (this.shake_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.audio_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.shear_ != 0f)
        {
                this.shear_ = other.shear_;
        }
        
        if(other.shake_ != 0f)
        {
                this.shake_ = other.shake_;
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
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.audio_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.shear_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.shake_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS.AudioFieldNumber = new Google.Protobuf.MessageParser<SHADERSETTINGS>(factory:  new System.Func<SHADERSETTINGS>(object:  STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS.<>c.<>9, method:  SHADERSETTINGS STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS.<>c::<.cctor>b__35_0()));
    }

}
