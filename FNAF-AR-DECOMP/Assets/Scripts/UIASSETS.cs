using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PlushSuitIconFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string plushSuitIcon_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PortraitIconFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string portraitIcon_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PortraitIconFlatFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string portraitIconFlat_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PlushSuitSilhouetteIconFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string plushSuitSilhouetteIcon_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PlushSuitIcon { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PortraitIcon { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PortraitIconFlat { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PlushSuitSilhouetteIcon { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<UIASSETS>)PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS.PlushSuitSilhouetteIconFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return PLUSHSUIT_DATA.Types.ARTASSETS.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS()
    {
        this.plushSuitIcon_ = "";
        this.portraitIcon_ = "";
        this.portraitIconFlat_ = "";
        this.plushSuitSilhouetteIcon_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS other)
    {
        if(other != null)
        {
                this.plushSuitIcon_ = other.plushSuitIcon_;
            this.portraitIcon_ = other.portraitIcon_;
            this.portraitIconFlat_ = other.portraitIconFlat_;
            this.plushSuitSilhouetteIcon_ = other.plushSuitSilhouetteIcon_;
        }
        else
        {
                this.plushSuitIcon_ = 15026800;
            this.portraitIcon_ = 64;
            this.portraitIconFlat_ = 69077560;
            this.plushSuitSilhouetteIcon_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS Clone()
    {
        return (UIASSETS)new PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PlushSuitIcon()
    {
        return (string)this.plushSuitIcon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PlushSuitIcon(string value)
    {
        this.plushSuitIcon_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PortraitIcon()
    {
        return (string)this.portraitIcon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PortraitIcon(string value)
    {
        this.portraitIcon_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PortraitIconFlat()
    {
        return (string)this.portraitIconFlat_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PortraitIconFlat(string value)
    {
        this.portraitIconFlat_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PlushSuitSilhouetteIcon()
    {
        return (string)this.plushSuitSilhouetteIcon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PlushSuitSilhouetteIcon(string value)
    {
        this.plushSuitSilhouetteIcon_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        UIASSETS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS other)
    {
        var val_5;
        if(other == null)
        {
            goto label_4;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((System.String.op_Inequality(a:  this.plushSuitIcon_, b:  other.plushSuitIcon_)) != true) && ((System.String.op_Inequality(a:  this.portraitIcon_, b:  other.portraitIcon_)) != true))
        {
                if((System.String.op_Inequality(a:  this.portraitIconFlat_, b:  other.portraitIconFlat_)) != true)
        {
                if((System.String.op_Inequality(a:  this.plushSuitSilhouetteIcon_, b:  other.plushSuitSilhouetteIcon_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_4:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        var val_6;
        if(this.plushSuitIcon_.Length != 0)
        {
                val_5 = this.plushSuitIcon_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.portraitIcon_.Length != 0)
        {
                val_5 = this.portraitIcon_ ^ val_5;
        }
        
        if(this.portraitIconFlat_.Length != 0)
        {
                val_5 = this.portraitIconFlat_ ^ val_5;
        }
        
        val_6 = 0;
        if(this.plushSuitSilhouetteIcon_.Length != 0)
        {
                val_5 = this.plushSuitSilhouetteIcon_ ^ val_5;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields ^ val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_5;
        string val_6;
        string val_7;
        string val_8;
        if(this.plushSuitIcon_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_5 = this.plushSuitIcon_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_5 = this.plushSuitIcon_;
        }
        
            output.WriteString(value:  val_5);
        }
        
        if(this.portraitIcon_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_6 = this.portraitIcon_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_6 = this.portraitIcon_;
        }
        
            output.WriteString(value:  val_6);
        }
        
        if(this.portraitIconFlat_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_7 = this.portraitIconFlat_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_7 = this.portraitIconFlat_;
        }
        
            output.WriteString(value:  val_7);
        }
        
        if(this.plushSuitSilhouetteIcon_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_8 = this.plushSuitSilhouetteIcon_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_8 = this.plushSuitSilhouetteIcon_;
        }
        
            output.WriteString(value:  val_8);
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
        var val_13;
        if(this.plushSuitIcon_.Length != 0)
        {
                val_13 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.plushSuitIcon_)) + 1;
        }
        else
        {
                val_13 = 0;
        }
        
        if(this.portraitIcon_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.portraitIcon_))) + 1;
        }
        
        if(this.portraitIconFlat_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.portraitIconFlat_))) + 1;
        }
        
        if(this.plushSuitSilhouetteIcon_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.plushSuitSilhouetteIcon_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_13;
        }
        
        val_13 = this._unknownFields.CalculateSize() + val_13;
        return (int)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.plushSuitIcon_.Length != 0)
        {
                this.PlushSuitIcon = other.plushSuitIcon_;
        }
        
        if(other.portraitIcon_.Length != 0)
        {
                this.PortraitIcon = other.portraitIcon_;
        }
        
        if(other.portraitIconFlat_.Length != 0)
        {
                this.PortraitIconFlat = other.portraitIconFlat_;
        }
        
        if(other.plushSuitSilhouetteIcon_.Length != 0)
        {
                this.PlushSuitSilhouetteIcon = other.plushSuitSilhouetteIcon_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
        if(this > 18)
        {
            goto label_1;
        }
        
        if(this == 10)
        {
            goto label_2;
        }
        
        if(this != 18)
        {
            goto label_7;
        }
        
        this.PortraitIcon = input.ReadString();
        goto label_12;
        label_1:
        if(this == 26)
        {
            goto label_6;
        }
        
        if(this != 34)
        {
            goto label_7;
        }
        
        this.PlushSuitSilhouetteIcon = input.ReadString();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.PlushSuitIcon = input.ReadString();
        goto label_12;
        label_6:
        this.PortraitIconFlat = input.ReadString();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS.PlushSuitSilhouetteIconFieldNumber = new Google.Protobuf.MessageParser<UIASSETS>(factory:  new System.Func<UIASSETS>(object:  PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS.<>c.<>9, method:  UIASSETS PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS.<>c::<.cctor>b__40_0()));
    }

}
