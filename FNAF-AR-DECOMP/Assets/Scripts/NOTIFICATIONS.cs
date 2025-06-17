using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ToTargetOnFailFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string toTargetOnFail_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ToTargetOnSuccFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string toTargetOnSucc_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ToSenderOnFailFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string toSenderOnFail_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ToSenderOnSuccFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string toSenderOnSucc_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ToTargetOnFail { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ToTargetOnSucc { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ToSenderOnFail { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string ToSenderOnSucc { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<NOTIFICATIONS>)CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.ToSenderOnSuccFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.PVP.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS()
    {
        this.toTargetOnFail_ = "";
        this.toTargetOnSucc_ = "";
        this.toSenderOnFail_ = "";
        this.toSenderOnSucc_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS other)
    {
        if(other != null)
        {
                this.toTargetOnFail_ = other.toTargetOnFail_;
            this.toTargetOnSucc_ = other.toTargetOnSucc_;
            this.toSenderOnFail_ = other.toSenderOnFail_;
            this.toSenderOnSucc_ = other.toSenderOnSucc_;
        }
        else
        {
                this.toTargetOnFail_ = 15026800;
            this.toTargetOnSucc_ = 64;
            this.toSenderOnFail_ = 69077560;
            this.toSenderOnSucc_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS Clone()
    {
        return (NOTIFICATIONS)new CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ToTargetOnFail()
    {
        return (string)this.toTargetOnFail_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ToTargetOnFail(string value)
    {
        this.toTargetOnFail_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ToTargetOnSucc()
    {
        return (string)this.toTargetOnSucc_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ToTargetOnSucc(string value)
    {
        this.toTargetOnSucc_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ToSenderOnFail()
    {
        return (string)this.toSenderOnFail_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ToSenderOnFail(string value)
    {
        this.toSenderOnFail_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_ToSenderOnSucc()
    {
        return (string)this.toSenderOnSucc_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ToSenderOnSucc(string value)
    {
        this.toSenderOnSucc_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        NOTIFICATIONS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS other)
    {
        var val_5;
        if(other == null)
        {
            goto label_4;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((System.String.op_Inequality(a:  this.toTargetOnFail_, b:  other.toTargetOnFail_)) != true) && ((System.String.op_Inequality(a:  this.toTargetOnSucc_, b:  other.toTargetOnSucc_)) != true))
        {
                if((System.String.op_Inequality(a:  this.toSenderOnFail_, b:  other.toSenderOnFail_)) != true)
        {
                if((System.String.op_Inequality(a:  this.toSenderOnSucc_, b:  other.toSenderOnSucc_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_4:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        var val_6;
        if(this.toTargetOnFail_.Length != 0)
        {
                val_5 = this.toTargetOnFail_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.toTargetOnSucc_.Length != 0)
        {
                val_5 = this.toTargetOnSucc_ ^ val_5;
        }
        
        if(this.toSenderOnFail_.Length != 0)
        {
                val_5 = this.toSenderOnFail_ ^ val_5;
        }
        
        val_6 = 0;
        if(this.toSenderOnSucc_.Length != 0)
        {
                val_5 = this.toSenderOnSucc_ ^ val_5;
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
        string val_5;
        string val_6;
        string val_7;
        string val_8;
        if(this.toTargetOnFail_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_5 = this.toTargetOnFail_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_5 = this.toTargetOnFail_;
        }
        
            output.WriteString(value:  val_5);
        }
        
        if(this.toTargetOnSucc_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_6 = this.toTargetOnSucc_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_6 = this.toTargetOnSucc_;
        }
        
            output.WriteString(value:  val_6);
        }
        
        if(this.toSenderOnFail_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_7 = this.toSenderOnFail_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_7 = this.toSenderOnFail_;
        }
        
            output.WriteString(value:  val_7);
        }
        
        if(this.toSenderOnSucc_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_8 = this.toSenderOnSucc_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_8 = this.toSenderOnSucc_;
        }
        
            output.WriteString(value:  val_8);
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
        if(this.toTargetOnFail_.Length != 0)
        {
                val_13 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.toTargetOnFail_)) + 1;
        }
        else
        {
                val_13 = 0;
        }
        
        if(this.toTargetOnSucc_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.toTargetOnSucc_))) + 1;
        }
        
        if(this.toSenderOnFail_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.toSenderOnFail_))) + 1;
        }
        
        if(this.toSenderOnSucc_.Length != 0)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.toSenderOnSucc_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_13;
        }
        
        val_13 = this._unknownFields.CalculateSize() + val_13;
        return (int)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.toTargetOnFail_.Length != 0)
        {
                this.ToTargetOnFail = other.toTargetOnFail_;
        }
        
        if(other.toTargetOnSucc_.Length != 0)
        {
                this.ToTargetOnSucc = other.toTargetOnSucc_;
        }
        
        if(other.toSenderOnFail_.Length != 0)
        {
                this.ToSenderOnFail = other.toSenderOnFail_;
        }
        
        if(other.toSenderOnSucc_.Length != 0)
        {
                this.ToSenderOnSucc = other.toSenderOnSucc_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
        if(this > 18)
        {
            goto label_1;
        }
        
        if(this == 10)
        {
            goto label_2;
        }
        
        if(this != 18)
        {
            goto label_7;
        }
        
        this.ToTargetOnSucc = input.ReadString();
        goto label_12;
        label_1:
        if(this == 26)
        {
            goto label_6;
        }
        
        if(this != 34)
        {
            goto label_7;
        }
        
        this.ToSenderOnSucc = input.ReadString();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.ToTargetOnFail = input.ReadString();
        goto label_12;
        label_6:
        this.ToSenderOnFail = input.ReadString();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.ToSenderOnSuccFieldNumber = new Google.Protobuf.MessageParser<NOTIFICATIONS>(factory:  new System.Func<NOTIFICATIONS>(object:  CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.<>c.<>9, method:  NOTIFICATIONS CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS.<>c::<.cctor>b__40_0()));
    }

}
