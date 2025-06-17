using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxDeleteFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxDelete_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxSetToReadFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maxSetToRead_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxDelete { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaxSetToRead { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<INBOXBATCHLIMITS>)CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.MaxSetToReadFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[18];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS other)
    {
        if(other != null)
        {
                this.maxDelete_ = other.maxDelete_;
            this.maxSetToRead_ = other.maxSetToRead_;
        }
        else
        {
                this.maxDelete_ = 7.42422564692724E-317;
            this.maxSetToRead_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS Clone()
    {
        return (INBOXBATCHLIMITS)new CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxDelete()
    {
        return (double)this.maxDelete_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxDelete(double value)
    {
        this.maxDelete_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaxSetToRead()
    {
        return (double)this.maxSetToRead_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaxSetToRead(double value)
    {
        this.maxSetToRead_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        INBOXBATCHLIMITS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS other)
    {
        var val_3;
        double val_4;
        var val_5;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_4 = this.maxDelete_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.maxSetToRead_;
            val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_3 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.maxDelete_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.maxSetToRead_ != 0f)
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_3;
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
        double val_1;
        double val_2;
        if(this.maxDelete_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.maxDelete_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.maxDelete_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.maxSetToRead_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.maxSetToRead_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.maxSetToRead_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_5;
        var val_1 = (this.maxDelete_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.maxSetToRead_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.maxDelete_ != 0f)
        {
                this.maxDelete_ = other.maxDelete_;
        }
        
        if(other.maxSetToRead_ != 0f)
        {
                this.maxSetToRead_ = other.maxSetToRead_;
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
        this.maxDelete_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.maxSetToRead_ = input.ReadDouble();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 9)
        {
            goto label_6;
        }
        
        if(val_4 == 17)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.MaxSetToReadFieldNumber = new Google.Protobuf.MessageParser<INBOXBATCHLIMITS>(factory:  new System.Func<INBOXBATCHLIMITS>(object:  CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.<>c.<>9, method:  INBOXBATCHLIMITS CONFIG_DATA.Types.ENTRY.Types.INBOXBATCHLIMITS.<>c::<.cctor>b__30_0()));
    }

}
