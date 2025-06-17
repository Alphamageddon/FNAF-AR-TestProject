using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.ATTACKLOCALIZATION : IMessage<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION>, IDeepCloneable<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LossTextFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string lossText_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string LossText { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ATTACKLOCALIZATION>)CPU_DATA.Types.ATTACKLOCALIZATION.LossTextFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[9];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.ATTACKLOCALIZATION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.ATTACKLOCALIZATION()
    {
        this.lossText_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.ATTACKLOCALIZATION(ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION other)
    {
        if(other != null)
        {
                this.lossText_ = other.lossText_;
        }
        else
        {
                this.lossText_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION Clone()
    {
        return (ATTACKLOCALIZATION)new CPU_DATA.Types.ATTACKLOCALIZATION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_LossText()
    {
        return (string)this.lossText_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LossText(string value)
    {
        this.lossText_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ATTACKLOCALIZATION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION other)
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
        
        if((System.String.op_Inequality(a:  this.lossText_, b:  other.lossText_)) == false)
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
        if(this.lossText_.Length != 0)
        {
                val_3 = this.lossText_ ^ 1;
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
        if(this.lossText_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.lossText_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.lossText_;
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
        if(this.lossText_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.lossText_)) + 1;
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
    public void MergeFrom(ProtoData.CPU_DATA.Types.ATTACKLOCALIZATION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.lossText_.Length != 0)
        {
                this.LossText = other.lossText_;
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
        this.LossText = input.ReadString();
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
    private static CPU_DATA.Types.ATTACKLOCALIZATION()
    {
        null = null;
        CPU_DATA.Types.ATTACKLOCALIZATION.LossTextFieldNumber = new Google.Protobuf.MessageParser<ATTACKLOCALIZATION>(factory:  new System.Func<ATTACKLOCALIZATION>(object:  CPU_DATA.Types.ATTACKLOCALIZATION.<>c.<>9, method:  ATTACKLOCALIZATION CPU_DATA.Types.ATTACKLOCALIZATION.<>c::<.cctor>b__25_0()));
    }

}
