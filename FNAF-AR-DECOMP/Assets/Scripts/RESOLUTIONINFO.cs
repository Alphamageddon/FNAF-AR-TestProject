using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO : IMessage<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO>, IMessage, IEquatable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO>, IDeepCloneable<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GuideResolutionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string guideResolution_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ResolutionArgsFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string resolutionArgs_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string GuideResolution { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ResolutionArgs { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<RESOLUTIONINFO>)TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.ResolutionArgsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return TUTORIAL_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO()
    {
        this.guideResolution_ = "";
        this.resolutionArgs_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO other)
    {
        if(other != null)
        {
                this.guideResolution_ = other.guideResolution_;
            this.resolutionArgs_ = other.resolutionArgs_;
        }
        else
        {
                this.guideResolution_ = 15026800;
            this.resolutionArgs_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO Clone()
    {
        return (RESOLUTIONINFO)new TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_GuideResolution()
    {
        return (string)this.guideResolution_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GuideResolution(string value)
    {
        this.guideResolution_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ResolutionArgs()
    {
        return (string)this.resolutionArgs_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ResolutionArgs(string value)
    {
        this.resolutionArgs_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        RESOLUTIONINFO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO other)
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
        
        if((System.String.op_Inequality(a:  this.guideResolution_, b:  other.guideResolution_)) != true)
        {
                if((System.String.op_Inequality(a:  this.resolutionArgs_, b:  other.resolutionArgs_)) == false)
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
        if(this.guideResolution_.Length != 0)
        {
                val_3 = this.guideResolution_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.resolutionArgs_.Length != 0)
        {
                val_3 = this.resolutionArgs_ ^ val_3;
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
        if(this.guideResolution_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.guideResolution_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.guideResolution_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.resolutionArgs_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.resolutionArgs_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.resolutionArgs_;
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
        if(this.guideResolution_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.guideResolution_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.resolutionArgs_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.resolutionArgs_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.guideResolution_.Length != 0)
        {
                this.GuideResolution = other.guideResolution_;
        }
        
        if(other.resolutionArgs_.Length != 0)
        {
                this.ResolutionArgs = other.resolutionArgs_;
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
        this.GuideResolution = input.ReadString();
        goto label_3;
        label_7:
        this.ResolutionArgs = input.ReadString();
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
    private static TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO()
    {
        null = null;
        TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.ResolutionArgsFieldNumber = new Google.Protobuf.MessageParser<RESOLUTIONINFO>(factory:  new System.Func<RESOLUTIONINFO>(object:  TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.<>c.<>9, method:  RESOLUTIONINFO TUTORIAL_DATA.Types.ENTRY.Types.RESOLUTIONINFO.<>c::<.cctor>b__30_0()));
    }

}
