using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EXPIRATION : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SuspendFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string suspend_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CountFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double count_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Suspend { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Count { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EXPIRATION>)DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.CountFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EXPIRATION()
    {
        this.suspend_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EXPIRATION(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION other)
    {
        if(other != null)
        {
                this.seconds_ = other.seconds_;
            this.suspend_ = other.suspend_;
            this.count_ = other.count_;
        }
        else
        {
                this.seconds_ = 7.42422564692724E-317;
            this.suspend_ = 64;
            this.count_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION Clone()
    {
        return (EXPIRATION)new DEVICES_DATA.Types.ENTRY.Types.EXPIRATION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Seconds()
    {
        return (double)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(double value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Suspend()
    {
        return (string)this.suspend_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Suspend(string value)
    {
        this.suspend_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Count()
    {
        return (double)this.count_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Count(double value)
    {
        this.count_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EXPIRATION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_11;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.seconds_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if(((val_4 & 1) != 0) && ((System.String.op_Inequality(a:  this.suspend_, b:  other.suspend_)) != true))
        {
                val_5 = this.count_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.seconds_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        val_5 = 0;
        if(this.suspend_.Length != 0)
        {
                val_4 = this.suspend_ ^ val_4;
        }
        
        if(this.count_ != 0f)
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
        double val_2;
        string val_3;
        double val_4;
        if(this.seconds_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.seconds_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.suspend_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.suspend_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.suspend_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.count_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_4 = this.count_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_4 = this.count_;
        }
        
            output.WriteDouble(value:  val_4);
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
        var val_8;
        if(this.suspend_.Length != 0)
        {
                int val_4 = ((this.seconds_ == 0f) ? 0 : 9) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.suspend_));
            val_7 = val_4 + 1;
        }
        
        val_4 = val_7 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + ((this.count_ == 0f) ? (val_7) : (val_4));
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EXPIRATION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.seconds_ != 0f)
        {
                this.seconds_ = other.seconds_;
        }
        
        if(other.suspend_.Length != 0)
        {
                this.Suspend = other.suspend_;
        }
        
        if(other.count_ != 0f)
        {
                this.count_ = other.count_;
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
        
        this.count_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.seconds_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.Suspend = input.ReadString();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.EXPIRATION()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.CountFieldNumber = new Google.Protobuf.MessageParser<EXPIRATION>(factory:  new System.Func<EXPIRATION>(object:  DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.<>c.<>9, method:  EXPIRATION DEVICES_DATA.Types.ENTRY.Types.EXPIRATION.<>c::<.cctor>b__35_0()));
    }

}
