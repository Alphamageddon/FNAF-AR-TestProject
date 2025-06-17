using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO : IMessage<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO>, IMessage, IEquatable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO>, IDeepCloneable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GuideEventsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string guideEvents_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EventArgsFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string eventArgs_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string GuideEvents { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string EventArgs { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EVENTINFO>)TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.EventArgsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return TUTORIAL_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO()
    {
        this.guideEvents_ = "";
        this.eventArgs_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO other)
    {
        if(other != null)
        {
                this.guideEvents_ = other.guideEvents_;
            this.eventArgs_ = other.eventArgs_;
        }
        else
        {
                this.guideEvents_ = 15026800;
            this.eventArgs_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO Clone()
    {
        return (EVENTINFO)new TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_GuideEvents()
    {
        return (string)this.guideEvents_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GuideEvents(string value)
    {
        this.guideEvents_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_EventArgs()
    {
        return (string)this.eventArgs_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EventArgs(string value)
    {
        this.eventArgs_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EVENTINFO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO other)
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
        
        if((System.String.op_Inequality(a:  this.guideEvents_, b:  other.guideEvents_)) != true)
        {
                if((System.String.op_Inequality(a:  this.eventArgs_, b:  other.eventArgs_)) == false)
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
        if(this.guideEvents_.Length != 0)
        {
                val_3 = this.guideEvents_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.eventArgs_.Length != 0)
        {
                val_3 = this.eventArgs_ ^ val_3;
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
        if(this.guideEvents_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.guideEvents_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.guideEvents_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.eventArgs_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.eventArgs_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.eventArgs_;
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
        if(this.guideEvents_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.guideEvents_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.eventArgs_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.eventArgs_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.guideEvents_.Length != 0)
        {
                this.GuideEvents = other.guideEvents_;
        }
        
        if(other.eventArgs_.Length != 0)
        {
                this.EventArgs = other.eventArgs_;
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
        this.GuideEvents = input.ReadString();
        goto label_3;
        label_7:
        this.EventArgs = input.ReadString();
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
    private static TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO()
    {
        null = null;
        TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.EventArgsFieldNumber = new Google.Protobuf.MessageParser<EVENTINFO>(factory:  new System.Func<EVENTINFO>(object:  TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.<>c.<>9, method:  EVENTINFO TUTORIAL_DATA.Types.ENTRY.Types.EVENTINFO.<>c::<.cctor>b__30_0()));
    }

}
