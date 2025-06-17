using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqHasCompletedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string preconditionReqHasCompleted_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionReqHasNotCompletedFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string preconditionReqHasNotCompleted_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PreconditionReqHasCompleted { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PreconditionReqHasNotCompleted { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PRECONDITIONLOGICALCOMPLETIONS>)ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS.PreconditionReqHasNotCompletedFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS()
    {
        this.preconditionReqHasCompleted_ = "";
        this.preconditionReqHasNotCompleted_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS other)
    {
        if(other != null)
        {
                this.preconditionReqHasCompleted_ = other.preconditionReqHasCompleted_;
            this.preconditionReqHasNotCompleted_ = other.preconditionReqHasNotCompleted_;
        }
        else
        {
                this.preconditionReqHasCompleted_ = 15026800;
            this.preconditionReqHasNotCompleted_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS Clone()
    {
        return (PRECONDITIONLOGICALCOMPLETIONS)new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PreconditionReqHasCompleted()
    {
        return (string)this.preconditionReqHasCompleted_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqHasCompleted(string value)
    {
        this.preconditionReqHasCompleted_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PreconditionReqHasNotCompleted()
    {
        return (string)this.preconditionReqHasNotCompleted_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionReqHasNotCompleted(string value)
    {
        this.preconditionReqHasNotCompleted_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PRECONDITIONLOGICALCOMPLETIONS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS other)
    {
        var val_3;
        if(other == null)
        {
            goto label_2;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.String.op_Inequality(a:  this.preconditionReqHasCompleted_, b:  other.preconditionReqHasCompleted_)) != true)
        {
                if((System.String.op_Inequality(a:  this.preconditionReqHasNotCompleted_, b:  other.preconditionReqHasNotCompleted_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_1:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.preconditionReqHasCompleted_.Length != 0)
        {
                val_3 = this.preconditionReqHasCompleted_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.preconditionReqHasNotCompleted_.Length != 0)
        {
                val_3 = this.preconditionReqHasNotCompleted_ ^ val_3;
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
        string val_3;
        string val_4;
        if(this.preconditionReqHasCompleted_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.preconditionReqHasCompleted_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.preconditionReqHasCompleted_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.preconditionReqHasNotCompleted_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.preconditionReqHasNotCompleted_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.preconditionReqHasNotCompleted_;
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
        var val_7;
        if(this.preconditionReqHasCompleted_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.preconditionReqHasCompleted_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.preconditionReqHasNotCompleted_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.preconditionReqHasNotCompleted_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.preconditionReqHasCompleted_.Length != 0)
        {
                this.PreconditionReqHasCompleted = other.preconditionReqHasCompleted_;
        }
        
        if(other.preconditionReqHasNotCompleted_.Length != 0)
        {
                this.PreconditionReqHasNotCompleted = other.preconditionReqHasNotCompleted_;
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
        this.PreconditionReqHasCompleted = input.ReadString();
        goto label_3;
        label_7:
        this.PreconditionReqHasNotCompleted = input.ReadString();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
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
    private static ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS.PreconditionReqHasNotCompletedFieldNumber = new Google.Protobuf.MessageParser<PRECONDITIONLOGICALCOMPLETIONS>(factory:  new System.Func<PRECONDITIONLOGICALCOMPLETIONS>(object:  ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS.<>c.<>9, method:  PRECONDITIONLOGICALCOMPLETIONS ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS.Types.PRECONDITIONLOGICALCOMPLETIONS.<>c::<.cctor>b__30_0()));
    }

}
