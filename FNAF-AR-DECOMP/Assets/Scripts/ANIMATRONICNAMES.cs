using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ANIMATRONICNAMES : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DefaultFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string default_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Default { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ANIMATRONICNAMES>)PLUSHSUIT_DATA.Types.ANIMATRONICNAMES.DefaultFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.PLUSHSUIT_DATA.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ANIMATRONICNAMES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ANIMATRONICNAMES()
    {
        this.default_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ANIMATRONICNAMES(ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES other)
    {
        if(other != null)
        {
                this.default_ = other.default_;
        }
        else
        {
                this.default_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES Clone()
    {
        return (ANIMATRONICNAMES)new PLUSHSUIT_DATA.Types.ANIMATRONICNAMES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Default()
    {
        return (string)this.default_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Default(string value)
    {
        this.default_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ANIMATRONICNAMES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES other)
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
        
        if((System.String.op_Inequality(a:  this.default_, b:  other.default_)) == false)
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
        if(this.default_.Length != 0)
        {
                val_3 = this.default_ ^ 1;
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
        if(this.default_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.default_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.default_;
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
        if(this.default_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.default_)) + 1;
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
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ANIMATRONICNAMES other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.default_.Length != 0)
        {
                this.Default = other.default_;
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
        this.Default = input.ReadString();
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
    private static PLUSHSUIT_DATA.Types.ANIMATRONICNAMES()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ANIMATRONICNAMES.DefaultFieldNumber = new Google.Protobuf.MessageParser<ANIMATRONICNAMES>(factory:  new System.Func<ANIMATRONICNAMES>(object:  PLUSHSUIT_DATA.Types.ANIMATRONICNAMES.<>c.<>9, method:  ANIMATRONICNAMES PLUSHSUIT_DATA.Types.ANIMATRONICNAMES.<>c::<.cctor>b__25_0()));
    }

}
