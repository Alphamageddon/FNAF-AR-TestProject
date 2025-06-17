using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PlushSuitDescriptionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string plushSuitDescription_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PlushSuitDescription { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ANIMPLAYERFACINGTEXT>)PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT.PlushSuitDescriptionFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.PLUSHSUIT_DATA.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT()
    {
        this.plushSuitDescription_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT(ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT other)
    {
        if(other != null)
        {
                this.plushSuitDescription_ = other.plushSuitDescription_;
        }
        else
        {
                this.plushSuitDescription_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT Clone()
    {
        return (ANIMPLAYERFACINGTEXT)new PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PlushSuitDescription()
    {
        return (string)this.plushSuitDescription_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PlushSuitDescription(string value)
    {
        this.plushSuitDescription_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ANIMPLAYERFACINGTEXT val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT other)
    {
        var val_2;
        if(other == null)
        {
            goto label_0;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.String.op_Inequality(a:  this.plushSuitDescription_, b:  other.plushSuitDescription_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_0:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        if(this.plushSuitDescription_.Length != 0)
        {
                val_3 = this.plushSuitDescription_ ^ 1;
        }
        else
        {
                val_3 = 1;
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
        string val_2;
        if(this.plushSuitDescription_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.plushSuitDescription_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.plushSuitDescription_;
        }
        
            output.WriteString(value:  val_2);
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
        var val_4;
        if(this.plushSuitDescription_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.plushSuitDescription_)) + 1;
        }
        else
        {
                val_4 = 0;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields.CalculateSize() + val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.plushSuitDescription_.Length != 0)
        {
                this.PlushSuitDescription = other.plushSuitDescription_;
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
        this.PlushSuitDescription = input.ReadString();
        label_1:
        uint val_3 = input.ReadTag();
        if(val_3 == 10)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT.PlushSuitDescriptionFieldNumber = new Google.Protobuf.MessageParser<ANIMPLAYERFACINGTEXT>(factory:  new System.Func<ANIMPLAYERFACINGTEXT>(object:  PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT.<>c.<>9, method:  ANIMPLAYERFACINGTEXT PLUSHSUIT_DATA.Types.ANIMPLAYERFACINGTEXT.<>c::<.cctor>b__25_0()));
    }

}
