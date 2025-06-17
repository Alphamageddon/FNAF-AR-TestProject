using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsDescriptionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string partsDescription_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PartsDescription { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PLAYERFACINGTEXT>)CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.PartsDescriptionFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[14];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT()
    {
        this.partsDescription_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT other)
    {
        if(other != null)
        {
                this.partsDescription_ = other.partsDescription_;
        }
        else
        {
                this.partsDescription_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT Clone()
    {
        return (PLAYERFACINGTEXT)new CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PartsDescription()
    {
        return (string)this.partsDescription_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PartsDescription(string value)
    {
        this.partsDescription_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PLAYERFACINGTEXT val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT other)
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
        
        if((System.String.op_Inequality(a:  this.partsDescription_, b:  other.partsDescription_)) == false)
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
        if(this.partsDescription_.Length != 0)
        {
                val_3 = this.partsDescription_ ^ 1;
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
        if(this.partsDescription_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.partsDescription_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.partsDescription_;
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
        if(this.partsDescription_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.partsDescription_)) + 1;
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
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.partsDescription_.Length != 0)
        {
                this.PartsDescription = other.partsDescription_;
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
        this.PartsDescription = input.ReadString();
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
    private static CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.PartsDescriptionFieldNumber = new Google.Protobuf.MessageParser<PLAYERFACINGTEXT>(factory:  new System.Func<PLAYERFACINGTEXT>(object:  CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.<>c.<>9, method:  PLAYERFACINGTEXT CONFIG_DATA.Types.ENTRY.Types.PLAYERFACINGTEXT.<>c::<.cctor>b__25_0()));
    }

}
