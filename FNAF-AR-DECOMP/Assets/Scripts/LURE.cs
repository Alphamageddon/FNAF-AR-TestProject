using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE> _parser;
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
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AnimatronicLuredFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronicLured_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Min { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Max { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AnimatronicLured { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<LURE>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.AnimatronicLuredFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE()
    {
        this.animatronicLured_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE other)
    {
        if(other != null)
        {
                this.min_ = other.min_;
            this.max_ = other.max_;
            this.animatronicLured_ = other.animatronicLured_;
        }
        else
        {
                this.min_ = 7.42422564692724E-317;
            this.max_ = 3.16202013338398E-322;
            this.animatronicLured_ = 69077560;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE Clone()
    {
        return (LURE)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE(other:  this);
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
    public string get_AnimatronicLured()
    {
        return (string)this.animatronicLured_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AnimatronicLured(string value)
    {
        this.animatronicLured_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        LURE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.min_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.max_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                if((System.String.op_Inequality(a:  this.animatronicLured_, b:  other.animatronicLured_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_10:
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
        var val_5;
        if(this.min_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.max_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        val_5 = 0;
        if(this.animatronicLured_.Length != 0)
        {
                val_4 = this.animatronicLured_ ^ val_4;
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
        double val_2;
        double val_3;
        string val_4;
        if(this.min_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.min_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.min_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.max_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_3 = this.max_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_3 = this.max_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.animatronicLured_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.animatronicLured_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.animatronicLured_;
        }
        
            output.WriteString(value:  val_4);
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
        var val_8;
        var val_1 = (this.min_ == 0f) ? 0 : 9;
        if(this.animatronicLured_.Length != 0)
        {
                val_8 = (((this.max_ == 0f) ? (val_1) : (val_1 + 9)) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronicLured_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE other)
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
        
        if(other.animatronicLured_.Length != 0)
        {
                this.AnimatronicLured = other.animatronicLured_;
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
        
        if(val_2 != 26)
        {
            goto label_12;
        }
        
        this.AnimatronicLured = input.ReadString();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.min_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.max_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.AnimatronicLuredFieldNumber = new Google.Protobuf.MessageParser<LURE>(factory:  new System.Func<LURE>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.<>c.<>9, method:  LURE DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.LURE.<>c::<.cctor>b__35_0()));
    }

}
