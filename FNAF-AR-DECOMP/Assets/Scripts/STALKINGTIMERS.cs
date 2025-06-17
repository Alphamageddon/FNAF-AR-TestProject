using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.STALKINGTIMERS : IMessage<ProtoData.CPU_DATA.Types.STALKINGTIMERS>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.STALKINGTIMERS>, IDeepCloneable<ProtoData.CPU_DATA.Types.STALKINGTIMERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGTIMERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FunctioningFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING functioning_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGTIMERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING Functioning { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.STALKINGTIMERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<STALKINGTIMERS>)CPU_DATA.Types.STALKINGTIMERS.FunctioningFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.STALKINGTIMERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.STALKINGTIMERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.STALKINGTIMERS(ProtoData.CPU_DATA.Types.STALKINGTIMERS other)
    {
        if(other.functioning_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.functioning_ = other.functioning_.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGTIMERS Clone()
    {
        return (STALKINGTIMERS)new CPU_DATA.Types.STALKINGTIMERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING get_Functioning()
    {
        return (FUNCTIONING)this.functioning_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Functioning(ProtoData.CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING value)
    {
        this.functioning_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        STALKINGTIMERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.STALKINGTIMERS other)
    {
        var val_2;
        if(other == null)
        {
            goto label_2;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.functioning_, objB:  other.functioning_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_2:
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
        if(this.functioning_ != null)
        {
                val_2 = this.functioning_ ^ 1;
        }
        else
        {
                val_2 = 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_2;
        }
        
        val_2 = this._unknownFields ^ val_2;
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        FUNCTIONING val_1;
        if(this.functioning_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.functioning_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.functioning_;
        }
        
            output.WriteMessage(value:  val_1);
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
        FUNCTIONING val_3 = this.functioning_;
        if(val_3 != null)
        {
                val_3 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_3 = this.functioning_)) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + val_3;
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.STALKINGTIMERS other)
    {
        FUNCTIONING val_3;
        FUNCTIONING val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.functioning_;
        if(val_3 != null)
        {
                val_4 = this.functioning_;
            if(val_4 == null)
        {
                CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING val_1 = null;
            val_4 = val_1;
            val_1 = new CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING();
            this.functioning_ = val_4;
            val_3 = other.functioning_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_5;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_5;
        label_9:
        if(this.functioning_ == null)
        {
            goto label_3;
        }
        
        label_7:
        input.ReadMessage(builder:  this.functioning_);
        goto label_5;
        label_3:
        this.functioning_ = new CPU_DATA.Types.STALKINGTIMERS.Types.FUNCTIONING();
        if(input != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_5:
        uint val_3 = input.ReadTag();
        if(val_3 == 10)
        {
            goto label_9;
        }
        
        if(val_3 != 0)
        {
            goto label_10;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.STALKINGTIMERS()
    {
        null = null;
        CPU_DATA.Types.STALKINGTIMERS.FunctioningFieldNumber = new Google.Protobuf.MessageParser<STALKINGTIMERS>(factory:  new System.Func<STALKINGTIMERS>(object:  CPU_DATA.Types.STALKINGTIMERS.<>c.<>9, method:  STALKINGTIMERS CPU_DATA.Types.STALKINGTIMERS.<>c::<.cctor>b__26_0()));
    }

}
