using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO : IMessage<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO>, IMessage, IEquatable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO>, IDeepCloneable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GuideConditionsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string guideConditions_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ConditionArgsFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string conditionArgs_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string GuideConditions { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ConditionArgs { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CONDITIONINFO>)TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.ConditionArgsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return TUTORIAL_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO()
    {
        this.guideConditions_ = "";
        this.conditionArgs_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO other)
    {
        if(other != null)
        {
                this.guideConditions_ = other.guideConditions_;
            this.conditionArgs_ = other.conditionArgs_;
        }
        else
        {
                this.guideConditions_ = 15026800;
            this.conditionArgs_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO Clone()
    {
        return (CONDITIONINFO)new TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_GuideConditions()
    {
        return (string)this.guideConditions_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GuideConditions(string value)
    {
        this.guideConditions_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ConditionArgs()
    {
        return (string)this.conditionArgs_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ConditionArgs(string value)
    {
        this.conditionArgs_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CONDITIONINFO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO other)
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
        
        if((System.String.op_Inequality(a:  this.guideConditions_, b:  other.guideConditions_)) != true)
        {
                if((System.String.op_Inequality(a:  this.conditionArgs_, b:  other.conditionArgs_)) == false)
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
        if(this.guideConditions_.Length != 0)
        {
                val_3 = this.guideConditions_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.conditionArgs_.Length != 0)
        {
                val_3 = this.conditionArgs_ ^ val_3;
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
        if(this.guideConditions_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.guideConditions_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.guideConditions_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.conditionArgs_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.conditionArgs_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.conditionArgs_;
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
        if(this.guideConditions_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.guideConditions_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.conditionArgs_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.conditionArgs_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.guideConditions_.Length != 0)
        {
                this.GuideConditions = other.guideConditions_;
        }
        
        if(other.conditionArgs_.Length != 0)
        {
                this.ConditionArgs = other.conditionArgs_;
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
        this.GuideConditions = input.ReadString();
        goto label_3;
        label_7:
        this.ConditionArgs = input.ReadString();
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
    private static TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO()
    {
        null = null;
        TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.ConditionArgsFieldNumber = new Google.Protobuf.MessageParser<CONDITIONINFO>(factory:  new System.Func<CONDITIONINFO>(object:  TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.<>c.<>9, method:  CONDITIONINFO TUTORIAL_DATA.Types.ENTRY.Types.CONDITIONINFO.<>c::<.cctor>b__30_0()));
    }

}
