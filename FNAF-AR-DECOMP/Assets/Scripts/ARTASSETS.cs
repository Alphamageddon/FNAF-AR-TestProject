using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ARTASSETS : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AudioFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO audio_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Animatronic3DFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D animatronic3D_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AnimatronicConfigLookupFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string animatronicConfigLookup_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UIFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS uI_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO Audio { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D Animatronic3D { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string AnimatronicConfigLookup { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS UI { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ARTASSETS>)PLUSHSUIT_DATA.Types.ARTASSETS.UIFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.PLUSHSUIT_DATA.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ARTASSETS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS()
    {
        this.animatronicConfigLookup_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS other)
    {
        ANIMATRONIC3D val_5;
        UIASSETS val_6;
        if(other.audio_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.audio_ = other.audio_.Clone();
        val_5 = other.animatronic3D_;
        this.animatronic3D_ = val_5.Clone();
        this.animatronicConfigLookup_ = other.animatronicConfigLookup_;
        val_6 = other.uI_;
        this.uI_ = val_6.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS Clone()
    {
        return (ARTASSETS)new PLUSHSUIT_DATA.Types.ARTASSETS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO get_Audio()
    {
        return (AUDIO)this.audio_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Audio(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO value)
    {
        this.audio_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D get_Animatronic3D()
    {
        return (ANIMATRONIC3D)this.animatronic3D_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Animatronic3D(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D value)
    {
        this.animatronic3D_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_AnimatronicConfigLookup()
    {
        return (string)this.animatronicConfigLookup_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AnimatronicConfigLookup(string value)
    {
        this.animatronicConfigLookup_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS get_UI()
    {
        return (UIASSETS)this.uI_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UI(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS value)
    {
        this.uI_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ARTASSETS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS other)
    {
        var val_5;
        if(other == null)
        {
            goto label_5;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.Object.Equals(objA:  this.audio_, objB:  other.audio_)) != false) && ((System.Object.Equals(objA:  this.animatronic3D_, objB:  other.animatronic3D_)) != false)) && ((System.String.op_Inequality(a:  this.animatronicConfigLookup_, b:  other.animatronicConfigLookup_)) != true))
        {
                if((System.Object.Equals(objA:  this.uI_, objB:  other.uI_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_5:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.audio_ != null)
        {
                val_3 = this.audio_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.animatronic3D_ != null)
        {
                val_3 = this.animatronic3D_ ^ val_3;
        }
        
        val_4 = 0;
        if(this.animatronicConfigLookup_.Length != 0)
        {
                val_3 = this.animatronicConfigLookup_ ^ val_3;
        }
        
        if(this.uI_ != null)
        {
                val_3 = this.uI_ ^ val_3;
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
        AUDIO val_2;
        ANIMATRONIC3D val_3;
        string val_4;
        UIASSETS val_5;
        if(this.audio_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.audio_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.audio_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.animatronic3D_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.animatronic3D_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.animatronic3D_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.animatronicConfigLookup_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.animatronicConfigLookup_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.animatronicConfigLookup_;
        }
        
            output.WriteString(value:  val_4);
        }
        
        if(this.uI_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_5 = this.uI_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_5 = this.uI_;
        }
        
            output.WriteMessage(value:  val_5);
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
        AUDIO val_10 = this.audio_;
        if(val_10 != null)
        {
                val_10 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_10 = this.audio_)) + 1;
        }
        
        if(this.animatronic3D_ != null)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.animatronic3D_))) + 1;
        }
        
        if(this.animatronicConfigLookup_.Length != 0)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.animatronicConfigLookup_))) + 1;
        }
        
        if(this.uI_ != null)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.uI_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + val_10;
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS other)
    {
        UIASSETS val_6;
        AUDIO val_7;
        AUDIO val_8;
        ANIMATRONIC3D val_9;
        ANIMATRONIC3D val_10;
        UIASSETS val_11;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.audio_;
        if(val_7 != null)
        {
                val_8 = this.audio_;
            if(val_8 == null)
        {
                PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO val_1 = null;
            val_8 = val_1;
            val_1 = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO();
            this.audio_ = val_8;
            val_7 = other.audio_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.animatronic3D_;
        if(val_9 != null)
        {
                val_10 = this.animatronic3D_;
            if(val_10 == null)
        {
                PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D val_2 = null;
            val_10 = val_2;
            val_2 = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D();
            this.animatronic3D_ = val_10;
            val_9 = other.animatronic3D_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        if(other.animatronicConfigLookup_.Length != 0)
        {
                this.AnimatronicConfigLookup = other.animatronicConfigLookup_;
        }
        
        val_6 = other.uI_;
        if(val_6 != null)
        {
                val_11 = this.uI_;
            if(val_11 == null)
        {
                PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS val_4 = null;
            val_11 = val_4;
            val_4 = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS();
            this.uI_ = val_11;
            val_6 = other.uI_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ANIMATRONIC3D val_7;
        goto label_18;
        label_22:
        if(597 > 18)
        {
            goto label_2;
        }
        
        if(597 == 10)
        {
            goto label_3;
        }
        
        if(597 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.animatronic3D_;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D val_1 = null;
        val_7 = val_1;
        val_1 = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D();
        this.animatronic3D_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        if(597 == 26)
        {
            goto label_8;
        }
        
        if(597 != 34)
        {
            goto label_9;
        }
        
        val_7 = this.uI_;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS val_2 = null;
        val_7 = val_2;
        val_2 = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.UIASSETS();
        this.uI_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        val_7 = this.audio_;
        if(val_7 == null)
        {
            goto label_14;
        }
        
        label_10:
        if(input != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        input.ReadMessage(builder:  val_7);
        goto label_18;
        label_8:
        this.AnimatronicConfigLookup = input.ReadString();
        goto label_18;
        label_14:
        this.audio_ = new PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO();
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_18:
        if(input.ReadTag() != 0)
        {
            goto label_22;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.ARTASSETS()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ARTASSETS.UIFieldNumber = new Google.Protobuf.MessageParser<ARTASSETS>(factory:  new System.Func<ARTASSETS>(object:  PLUSHSUIT_DATA.Types.ARTASSETS.<>c.<>9, method:  ARTASSETS PLUSHSUIT_DATA.Types.ARTASSETS.<>c::<.cctor>b__41_0()));
    }

}
