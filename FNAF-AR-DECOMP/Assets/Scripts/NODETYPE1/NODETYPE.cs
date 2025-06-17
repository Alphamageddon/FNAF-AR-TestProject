using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE : IMessage<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE>, IMessage, IEquatable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE>, IDeepCloneable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LogicalFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string logical_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SelectionWeightFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double selectionWeight_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HasMoteFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool hasMote_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NodeLifetimeFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double nodeLifetime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PrefabFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string prefab_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EMFMeterFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string eMFMeter_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Logical { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double SelectionWeight { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool HasMote { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double NodeLifetime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Prefab { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string EMFMeter { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<NODETYPE>)ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE.EMFMeterFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ESSENCE_TYPES_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE()
    {
        this.logical_ = "";
        this.prefab_ = "";
        this.eMFMeter_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE other)
    {
        if(other != null)
        {
                this.logical_ = other.logical_;
            this.selectionWeight_ = other.selectionWeight_;
            this.hasMote_ = other.hasMote_;
            this.nodeLifetime_ = other.nodeLifetime_;
            this.prefab_ = other.prefab_;
            this.eMFMeter_ = other.eMFMeter_;
        }
        else
        {
                this.logical_ = 15026800;
            this.selectionWeight_ = 3.16202013338398E-322;
            this.hasMote_ = false;
            this.nodeLifetime_ = 1.33509863819657E-307;
            this.prefab_ = 4194311;
            this.eMFMeter_ = 1;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE Clone()
    {
        return (NODETYPE)new ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Logical()
    {
        return (string)this.logical_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Logical(string value)
    {
        this.logical_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_SelectionWeight()
    {
        return (double)this.selectionWeight_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SelectionWeight(double value)
    {
        this.selectionWeight_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_HasMote()
    {
        return (bool)this.hasMote_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HasMote(bool value)
    {
        this.hasMote_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_NodeLifetime()
    {
        return (double)this.nodeLifetime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NodeLifetime(double value)
    {
        this.nodeLifetime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Prefab()
    {
        return (string)this.prefab_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Prefab(string value)
    {
        this.prefab_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_EMFMeter()
    {
        return (string)this.eMFMeter_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EMFMeter(string value)
    {
        this.eMFMeter_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        NODETYPE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE other)
    {
        var val_8;
        double val_9;
        var val_10;
        if(other == null)
        {
            goto label_13;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.String.op_Inequality(a:  this.logical_, b:  other.logical_)) != true)
        {
                val_9 = this.selectionWeight_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                var val_3 = (this.hasMote_ == true) ? 1 : 0;
            val_3 = val_3 ^ ((other.hasMote_ == true) ? 1 : 0);
            if((val_3 & 1) == 0)
        {
                val_9 = this.nodeLifetime_;
            val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_8 & 1) != 0)
        {
                if((System.String.op_Inequality(a:  this.prefab_, b:  other.prefab_)) != true)
        {
                if((System.String.op_Inequality(a:  this.eMFMeter_, b:  other.eMFMeter_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_13:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        val_10 = 1;
        return (bool)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = 0;
        if(this.logical_.Length != 0)
        {
                val_8 = this.logical_ ^ 1;
        }
        else
        {
                val_8 = 1;
        }
        
        if(this.selectionWeight_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.hasMote_ != false)
        {
                val_7 = 0;
            val_8 = 1.GetHashCode() ^ val_8;
        }
        
        if(this.nodeLifetime_ != 0f)
        {
                val_8 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_8;
        }
        
        if(this.prefab_.Length != 0)
        {
                val_8 = this.prefab_ ^ val_8;
        }
        
        val_9 = 0;
        if(this.eMFMeter_.Length != 0)
        {
                val_8 = this.eMFMeter_ ^ val_8;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields ^ val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_5;
        double val_6;
        bool val_7;
        double val_8;
        string val_9;
        string val_10;
        if(this.logical_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_5 = this.logical_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_5 = this.logical_;
        }
        
            output.WriteString(value:  val_5);
        }
        
        if(this.selectionWeight_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_6 = this.selectionWeight_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_6 = this.selectionWeight_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.hasMote_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  24);
            val_7 = this.hasMote_;
        }
        else
        {
                0.WriteRawTag(b1:  24);
            val_7 = this.hasMote_;
        }
        
            output.WriteBool(value:  (val_7 == true) ? 1 : 0);
        }
        
        if(this.nodeLifetime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_8 = this.nodeLifetime_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_8 = this.nodeLifetime_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.prefab_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_9 = this.prefab_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_9 = this.prefab_;
        }
        
            output.WriteString(value:  val_9);
        }
        
        if(this.eMFMeter_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_10 = this.eMFMeter_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_10 = this.eMFMeter_;
        }
        
            output.WriteString(value:  val_10);
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
        var val_13;
        var val_14;
        if(this.logical_.Length != 0)
        {
                val_13 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.logical_)) + 1;
        }
        else
        {
                val_13 = 0;
        }
        
        var val_3 = val_13 + 9;
        val_13 = (this.selectionWeight_ == 0f) ? (val_13) : (val_3);
        val_3 = val_13 + 2;
        val_13 = (this.hasMote_ == true) ? (val_3) : (val_13);
        val_3 = val_13 + 9;
        if(this.prefab_.Length != 0)
        {
                val_14 = (((this.nodeLifetime_ == 0f) ? (val_13) : (val_3)) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.prefab_))) + 1;
        }
        
        if(this.eMFMeter_.Length != 0)
        {
                val_14 = (val_14 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.eMFMeter_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_14;
        }
        
        val_14 = this._unknownFields.CalculateSize() + val_14;
        return (int)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.logical_.Length != 0)
        {
                this.Logical = other.logical_;
        }
        
        if(other.selectionWeight_ != 0f)
        {
                this.selectionWeight_ = other.selectionWeight_;
        }
        
        if(other.hasMote_ != false)
        {
                this.hasMote_ = other.hasMote_;
        }
        
        if(other.nodeLifetime_ != 0f)
        {
                this.nodeLifetime_ = other.nodeLifetime_;
        }
        
        if(other.prefab_.Length != 0)
        {
                this.Prefab = other.prefab_;
        }
        
        if(other.eMFMeter_.Length != 0)
        {
                this.EMFMeter = other.eMFMeter_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_18;
        label_21:
        if(this > 24)
        {
            goto label_1;
        }
        
        if(this == 10)
        {
            goto label_2;
        }
        
        if(this == 17)
        {
            goto label_3;
        }
        
        if(this != 24)
        {
            goto label_9;
        }
        
        this.hasMote_ = input.ReadBool();
        goto label_18;
        label_1:
        if(this == 33)
        {
            goto label_7;
        }
        
        if(this == 42)
        {
            goto label_8;
        }
        
        if(this != 50)
        {
            goto label_9;
        }
        
        this.EMFMeter = input.ReadString();
        goto label_18;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        this.selectionWeight_ = input.ReadDouble();
        goto label_18;
        label_8:
        this.Prefab = input.ReadString();
        goto label_18;
        label_2:
        this.Logical = input.ReadString();
        goto label_18;
        label_7:
        this.nodeLifetime_ = input.ReadDouble();
        label_18:
        if(input.ReadTag() != 0)
        {
            goto label_21;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE()
    {
        null = null;
        ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE.EMFMeterFieldNumber = new Google.Protobuf.MessageParser<NODETYPE>(factory:  new System.Func<NODETYPE>(object:  ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE.<>c.<>9, method:  NODETYPE ESSENCE_TYPES_DATA.Types.ENTRY.Types.NODETYPE.<>c::<.cctor>b__50_0()));
    }

}
