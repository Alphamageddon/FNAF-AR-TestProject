using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.STALKINGEXITREQANIM : IMessage<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM>, IDeepCloneable<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StalkingExitReqAnimObjFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string stalkingExitReqAnimObj_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StalkingExitReqAnimPhaseFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM.Types.STALKINGEXITREQANIMPHASE stalkingExitReqAnimPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StalkingExitReqAnimLogicalFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.LOGICAL stalkingExitReqAnimLogical_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string StalkingExitReqAnimObj { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM.Types.STALKINGEXITREQANIMPHASE StalkingExitReqAnimPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.LOGICAL StalkingExitReqAnimLogical { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<STALKINGEXITREQANIM>)CPU_DATA.Types.STALKINGEXITREQANIM.StalkingExitReqAnimLogicalFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[6];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.STALKINGEXITREQANIM.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.STALKINGEXITREQANIM()
    {
        this.stalkingExitReqAnimObj_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.STALKINGEXITREQANIM(ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM other)
    {
        if(other != null)
        {
                this.stalkingExitReqAnimObj_ = other.stalkingExitReqAnimObj_;
            this.stalkingExitReqAnimPhase_ = other.stalkingExitReqAnimPhase_;
            this.stalkingExitReqAnimLogical_ = other.stalkingExitReqAnimLogical_;
        }
        else
        {
                this.stalkingExitReqAnimObj_ = 15026800;
            this.stalkingExitReqAnimPhase_ = 64;
            this.stalkingExitReqAnimLogical_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM Clone()
    {
        return (STALKINGEXITREQANIM)new CPU_DATA.Types.STALKINGEXITREQANIM(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_StalkingExitReqAnimObj()
    {
        return (string)this.stalkingExitReqAnimObj_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StalkingExitReqAnimObj(string value)
    {
        this.stalkingExitReqAnimObj_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM.Types.STALKINGEXITREQANIMPHASE get_StalkingExitReqAnimPhase()
    {
        return (STALKINGEXITREQANIMPHASE)this.stalkingExitReqAnimPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StalkingExitReqAnimPhase(ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM.Types.STALKINGEXITREQANIMPHASE value)
    {
        this.stalkingExitReqAnimPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.LOGICAL get_StalkingExitReqAnimLogical()
    {
        return (CPU_DATA.Types.LOGICAL)this.stalkingExitReqAnimLogical_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StalkingExitReqAnimLogical(ProtoData.CPU_DATA.Types.LOGICAL value)
    {
        this.stalkingExitReqAnimLogical_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        STALKINGEXITREQANIM val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM other)
    {
        var val_2;
        if(other == null)
        {
            goto label_4;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.String.op_Inequality(a:  this.stalkingExitReqAnimObj_, b:  other.stalkingExitReqAnimObj_)) != true) && (this.stalkingExitReqAnimPhase_ == other.stalkingExitReqAnimPhase_)) && (this.stalkingExitReqAnimLogical_ == other.stalkingExitReqAnimLogical_))
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_4:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        if(this.stalkingExitReqAnimObj_.Length != 0)
        {
                val_5 = this.stalkingExitReqAnimObj_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.stalkingExitReqAnimPhase_ != 0)
        {
                val_4 = 0;
            val_5 = this.stalkingExitReqAnimPhase_.region ^ val_5;
        }
        
        if(this.stalkingExitReqAnimLogical_ != 0)
        {
                val_4 = 0;
            val_5 = this.stalkingExitReqAnimLogical_.region ^ val_5;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields ^ val_5;
        return (int)val_5;
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
        STALKINGEXITREQANIMPHASE val_3;
        CPU_DATA.Types.LOGICAL val_4;
        if(this.stalkingExitReqAnimObj_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.stalkingExitReqAnimObj_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.stalkingExitReqAnimObj_;
        }
        
            output.WriteString(value:  val_2);
        }
        
        if(this.stalkingExitReqAnimPhase_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_3 = this.stalkingExitReqAnimPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_3 = this.stalkingExitReqAnimPhase_;
        }
        
            output.WriteEnum(value:  val_3);
        }
        
        if(this.stalkingExitReqAnimLogical_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  24);
            val_4 = this.stalkingExitReqAnimLogical_;
        }
        else
        {
                0.WriteRawTag(b1:  24);
            val_4 = this.stalkingExitReqAnimLogical_;
        }
        
            output.WriteEnum(value:  val_4);
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
        var val_8;
        if(this.stalkingExitReqAnimObj_.Length != 0)
        {
                val_8 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.stalkingExitReqAnimObj_)) + 1;
        }
        else
        {
                val_8 = 0;
        }
        
        if(this.stalkingExitReqAnimPhase_ != 0)
        {
                val_8 = (val_8 + (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  this.stalkingExitReqAnimPhase_))) + 1;
        }
        
        if(this.stalkingExitReqAnimLogical_ != 0)
        {
                val_8 = (val_8 + (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  this.stalkingExitReqAnimLogical_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.STALKINGEXITREQANIM other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.stalkingExitReqAnimObj_.Length != 0)
        {
                this.StalkingExitReqAnimObj = other.stalkingExitReqAnimObj_;
        }
        
        if(other.stalkingExitReqAnimPhase_ != 0)
        {
                this.stalkingExitReqAnimPhase_ = other.stalkingExitReqAnimPhase_;
        }
        
        if(other.stalkingExitReqAnimLogical_ != 0)
        {
                this.stalkingExitReqAnimLogical_ = other.stalkingExitReqAnimLogical_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 15)
        {
            goto label_2;
        }
        
        if(val_2 == 16)
        {
            goto label_3;
        }
        
        if(val_2 != 24)
        {
            goto label_12;
        }
        
        this.stalkingExitReqAnimLogical_ = input.ReadEnum();
        goto label_11;
        label_2:
        if(val_2 != 10)
        {
            goto label_7;
        }
        
        this.StalkingExitReqAnimObj = input.ReadString();
        goto label_11;
        label_3:
        this.stalkingExitReqAnimPhase_ = input.ReadEnum();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.STALKINGEXITREQANIM()
    {
        null = null;
        CPU_DATA.Types.STALKINGEXITREQANIM.StalkingExitReqAnimLogicalFieldNumber = new Google.Protobuf.MessageParser<STALKINGEXITREQANIM>(factory:  new System.Func<STALKINGEXITREQANIM>(object:  CPU_DATA.Types.STALKINGEXITREQANIM.<>c.<>9, method:  STALKINGEXITREQANIM CPU_DATA.Types.STALKINGEXITREQANIM.<>c::<.cctor>b__36_0()));
    }

}
