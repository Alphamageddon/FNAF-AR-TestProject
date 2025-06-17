using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM : IMessage<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM>, IMessage, IEquatable<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM>, IDeepCloneable<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LogicalFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string logical_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TypeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string type_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int QtyFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double qty_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Logical { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Type { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Qty { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ITEM>)STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.QtyFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STORE_DATA.Types.ENTRY.Types.CONTENTS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM()
    {
        this.logical_ = "";
        this.type_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM(ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM other)
    {
        if(other != null)
        {
                this.logical_ = other.logical_;
            this.type_ = other.type_;
            this.qty_ = other.qty_;
        }
        else
        {
                this.logical_ = 15026800;
            this.type_ = 64;
            this.qty_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM Clone()
    {
        return (ITEM)new STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM(other:  this);
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
    public string get_Type()
    {
        return (string)this.type_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Type(string value)
    {
        this.type_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Qty()
    {
        return (double)this.qty_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Qty(double value)
    {
        this.qty_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ITEM val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM other)
    {
        var val_4;
        if(other == null)
        {
            goto label_8;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((System.String.op_Inequality(a:  this.logical_, b:  other.logical_)) != true) && ((System.String.op_Inequality(a:  this.type_, b:  other.type_)) != true))
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_8:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.logical_.Length != 0)
        {
                val_4 = this.logical_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        val_5 = 0;
        if(this.type_.Length != 0)
        {
                val_4 = this.type_ ^ val_4;
        }
        
        if(this.qty_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
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
        double val_5;
        if(this.logical_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.logical_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.logical_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.type_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.type_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.type_;
        }
        
            output.WriteString(value:  val_4);
        }
        
        if(this.qty_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_5 = this.qty_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_5 = this.qty_;
        }
        
            output.WriteDouble(value:  val_5);
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
        var val_9;
        var val_10;
        if(this.logical_.Length != 0)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.logical_)) + 1;
        }
        else
        {
                val_9 = 0;
        }
        
        if(this.type_.Length != 0)
        {
                int val_5 = val_9 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.type_));
            val_9 = val_5 + 1;
        }
        
        val_5 = val_9 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + ((this.qty_ == 0f) ? (val_9) : (val_5));
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.logical_.Length != 0)
        {
                this.Logical = other.logical_;
        }
        
        if(other.type_.Length != 0)
        {
                this.Type = other.type_;
        }
        
        if(other.qty_ != 0f)
        {
                this.qty_ = other.qty_;
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
        if(val_2 <= 17)
        {
            goto label_2;
        }
        
        if(val_2 == 18)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.qty_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 10)
        {
            goto label_7;
        }
        
        this.Logical = input.ReadString();
        goto label_11;
        label_3:
        this.Type = input.ReadString();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM()
    {
        null = null;
        STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.QtyFieldNumber = new Google.Protobuf.MessageParser<ITEM>(factory:  new System.Func<ITEM>(object:  STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.<>c.<>9, method:  ITEM STORE_DATA.Types.ENTRY.Types.CONTENTS.Types.ITEM.<>c::<.cctor>b__35_0()));
    }

}
