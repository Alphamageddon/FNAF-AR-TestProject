using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO : IMessage<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO>, IMessage, IEquatable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO>, IDeepCloneable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GuideActionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string guideAction_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ActionArgsFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string actionArgs_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string GuideAction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ActionArgs { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ACTIONINFO>)TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.ActionArgsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return TUTORIAL_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO()
    {
        this.guideAction_ = "";
        this.actionArgs_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO other)
    {
        if(other != null)
        {
                this.guideAction_ = other.guideAction_;
            this.actionArgs_ = other.actionArgs_;
        }
        else
        {
                this.guideAction_ = 15026800;
            this.actionArgs_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO Clone()
    {
        return (ACTIONINFO)new TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_GuideAction()
    {
        return (string)this.guideAction_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GuideAction(string value)
    {
        this.guideAction_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ActionArgs()
    {
        return (string)this.actionArgs_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ActionArgs(string value)
    {
        this.actionArgs_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ACTIONINFO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO other)
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
        
        if((System.String.op_Inequality(a:  this.guideAction_, b:  other.guideAction_)) != true)
        {
                if((System.String.op_Inequality(a:  this.actionArgs_, b:  other.actionArgs_)) == false)
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
        if(this.guideAction_.Length != 0)
        {
                val_3 = this.guideAction_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.actionArgs_.Length != 0)
        {
                val_3 = this.actionArgs_ ^ val_3;
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
        if(this.guideAction_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.guideAction_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.guideAction_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.actionArgs_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.actionArgs_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.actionArgs_;
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
        if(this.guideAction_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.guideAction_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.actionArgs_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.actionArgs_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.guideAction_.Length != 0)
        {
                this.GuideAction = other.guideAction_;
        }
        
        if(other.actionArgs_.Length != 0)
        {
                this.ActionArgs = other.actionArgs_;
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
        this.GuideAction = input.ReadString();
        goto label_3;
        label_7:
        this.ActionArgs = input.ReadString();
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
    private static TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO()
    {
        null = null;
        TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.ActionArgsFieldNumber = new Google.Protobuf.MessageParser<ACTIONINFO>(factory:  new System.Func<ACTIONINFO>(object:  TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.<>c.<>9, method:  ACTIONINFO TUTORIAL_DATA.Types.ENTRY.Types.ACTIONINFO.<>c::<.cctor>b__30_0()));
    }

}
