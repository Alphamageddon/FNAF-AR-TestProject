using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.MAPNODES : IMessage<ProtoData.CPU_DATA.Types.MAPNODES>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.MAPNODES>, IDeepCloneable<ProtoData.CPU_DATA.Types.MAPNODES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.MAPNODES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NodeTravelTimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME nodeTravelTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NodePathMinFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN nodePathMin_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.MAPNODES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME NodeTravelTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN NodePathMin { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.MAPNODES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MAPNODES>)CPU_DATA.Types.MAPNODES.NodePathMinFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.MAPNODES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.MAPNODES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.MAPNODES(ProtoData.CPU_DATA.Types.MAPNODES other)
    {
        NODEPATHMIN val_4;
        if(other.nodeTravelTime_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.nodeTravelTime_ = other.nodeTravelTime_.Clone();
        val_4 = other.nodePathMin_;
        this.nodePathMin_ = val_4.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.MAPNODES Clone()
    {
        return (MAPNODES)new CPU_DATA.Types.MAPNODES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME get_NodeTravelTime()
    {
        return (NODETRAVELTIME)this.nodeTravelTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NodeTravelTime(ProtoData.CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME value)
    {
        this.nodeTravelTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN get_NodePathMin()
    {
        return (NODEPATHMIN)this.nodePathMin_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NodePathMin(ProtoData.CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN value)
    {
        this.nodePathMin_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MAPNODES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.MAPNODES other)
    {
        var val_3;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.nodeTravelTime_, objB:  other.nodeTravelTime_)) != false)
        {
                if((System.Object.Equals(objA:  this.nodePathMin_, objB:  other.nodePathMin_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_3:
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
        if(this.nodeTravelTime_ != null)
        {
                val_3 = this.nodeTravelTime_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.nodePathMin_ != null)
        {
                val_3 = this.nodePathMin_ ^ val_3;
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
        NODETRAVELTIME val_1;
        NODEPATHMIN val_2;
        if(this.nodeTravelTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.nodeTravelTime_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.nodeTravelTime_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.nodePathMin_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.nodePathMin_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.nodePathMin_;
        }
        
            output.WriteMessage(value:  val_2);
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
        NODETRAVELTIME val_5 = this.nodeTravelTime_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.nodeTravelTime_)) + 1;
        }
        
        if(this.nodePathMin_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.nodePathMin_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.MAPNODES other)
    {
        NODEPATHMIN val_4;
        NODETRAVELTIME val_5;
        NODETRAVELTIME val_6;
        NODEPATHMIN val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.nodeTravelTime_;
        if(val_5 != null)
        {
                val_6 = this.nodeTravelTime_;
            if(val_6 == null)
        {
                CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME val_1 = null;
            val_6 = val_1;
            val_1 = new CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME();
            this.nodeTravelTime_ = val_6;
            val_5 = other.nodeTravelTime_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.nodePathMin_;
        if(val_4 != null)
        {
                val_7 = this.nodePathMin_;
            if(val_7 == null)
        {
                CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN val_2 = null;
            val_7 = val_2;
            val_2 = new CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN();
            this.nodePathMin_ = val_7;
            val_4 = other.nodePathMin_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        NODETRAVELTIME val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.nodeTravelTime_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME val_2 = null;
        val_5 = val_2;
        val_2 = new CPU_DATA.Types.MAPNODES.Types.NODETRAVELTIME();
        this.nodeTravelTime_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.nodePathMin_;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(input != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        input.ReadMessage(builder:  val_5);
        goto label_8;
        label_6:
        this.nodePathMin_ = new CPU_DATA.Types.MAPNODES.Types.NODEPATHMIN();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_8:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_12;
        }
        
        if(val_4 == 18)
        {
            goto label_13;
        }
        
        if(val_4 != 0)
        {
            goto label_14;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.MAPNODES()
    {
        null = null;
        CPU_DATA.Types.MAPNODES.NodePathMinFieldNumber = new Google.Protobuf.MessageParser<MAPNODES>(factory:  new System.Func<MAPNODES>(object:  CPU_DATA.Types.MAPNODES.<>c.<>9, method:  MAPNODES CPU_DATA.Types.MAPNODES.<>c::<.cctor>b__31_0()));
    }

}
