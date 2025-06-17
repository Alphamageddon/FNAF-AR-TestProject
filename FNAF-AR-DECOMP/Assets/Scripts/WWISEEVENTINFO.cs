using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO : IMessage<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO>, IMessage, IEquatable<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO>, IDeepCloneable<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NameFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string name_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Name { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<WWISEEVENTINFO>)AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.NameFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO()
    {
        this.name_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO other)
    {
        if(other != null)
        {
                this.name_ = other.name_;
        }
        else
        {
                this.name_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Clone()
    {
        return (WWISEEVENTINFO)new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Name()
    {
        return (string)this.name_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Name(string value)
    {
        this.name_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        WWISEEVENTINFO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO other)
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
        
        if((System.String.op_Inequality(a:  this.name_, b:  other.name_)) == false)
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
        if(this.name_.Length != 0)
        {
                val_3 = this.name_ ^ 1;
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
        if(this.name_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.name_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.name_;
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
        if(this.name_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.name_)) + 1;
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
    public void MergeFrom(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.name_.Length != 0)
        {
                this.Name = other.name_;
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
        this.Name = input.ReadString();
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
    private static AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO()
    {
        null = null;
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.NameFieldNumber = new Google.Protobuf.MessageParser<WWISEEVENTINFO>(factory:  new System.Func<WWISEEVENTINFO>(object:  AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.<>c.<>9, method:  WWISEEVENTINFO AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO.<>c::<.cctor>b__25_0()));
    }

}
