using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR : IMessage<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR>, IDeepCloneable<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int IntensityFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double intensity_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HexColorFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string hexColor_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Intensity { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string HexColor { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EYECOLOR>)CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.HexColorFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CPU_DATA.Types.VISUALSETTINGS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR()
    {
        this.hexColor_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR other)
    {
        if(other != null)
        {
                this.intensity_ = other.intensity_;
            this.hexColor_ = other.hexColor_;
        }
        else
        {
                this.intensity_ = 7.42422564692724E-317;
            this.hexColor_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR Clone()
    {
        return (EYECOLOR)new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Intensity()
    {
        return (double)this.intensity_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Intensity(double value)
    {
        this.intensity_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_HexColor()
    {
        return (string)this.hexColor_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HexColor(string value)
    {
        this.hexColor_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EYECOLOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR other)
    {
        var val_3;
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
                if((System.String.op_Inequality(a:  this.hexColor_, b:  other.hexColor_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_6:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.intensity_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        val_4 = 0;
        if(this.hexColor_.Length != 0)
        {
                val_3 = this.hexColor_ ^ val_3;
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
        double val_2;
        string val_3;
        if(this.intensity_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.intensity_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.intensity_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.hexColor_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.hexColor_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.hexColor_;
        }
        
            output.WriteString(value:  val_3);
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
        var val_6;
        if(this.hexColor_.Length != 0)
        {
                val_6 = (((this.intensity_ == 0f) ? 0 : 9) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.hexColor_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields.CalculateSize() + val_6;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.intensity_ != 0f)
        {
                this.intensity_ = other.intensity_;
        }
        
        if(other.hexColor_.Length != 0)
        {
                this.HexColor = other.hexColor_;
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
        this.intensity_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.HexColor = input.ReadString();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 9)
        {
            goto label_6;
        }
        
        if(val_4 == 18)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR()
    {
        null = null;
        CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.HexColorFieldNumber = new Google.Protobuf.MessageParser<EYECOLOR>(factory:  new System.Func<EYECOLOR>(object:  CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.<>c.<>9, method:  EYECOLOR CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR.<>c::<.cctor>b__30_0()));
    }

}
