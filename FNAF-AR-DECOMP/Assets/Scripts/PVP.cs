using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.PVP : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NotificationsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS notifications_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS Notifications { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PVP>)CONFIG_DATA.Types.ENTRY.Types.PVP.NotificationsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[11];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.PVP.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PVP()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.PVP(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP other)
    {
        if(other.notifications_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.notifications_ = other.notifications_.Clone();
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
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP Clone()
    {
        return (PVP)new CONFIG_DATA.Types.ENTRY.Types.PVP(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS get_Notifications()
    {
        return (NOTIFICATIONS)this.notifications_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Notifications(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS value)
    {
        this.notifications_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PVP val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP other)
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
        
        if((System.Object.Equals(objA:  this.notifications_, objB:  other.notifications_)) != false)
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
        if(this.notifications_ != null)
        {
                val_2 = this.notifications_ ^ 1;
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
        NOTIFICATIONS val_1;
        if(this.notifications_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.notifications_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.notifications_;
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
        NOTIFICATIONS val_3 = this.notifications_;
        if(val_3 != null)
        {
                val_3 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_3 = this.notifications_)) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + val_3;
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.PVP other)
    {
        NOTIFICATIONS val_3;
        NOTIFICATIONS val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.notifications_;
        if(val_3 != null)
        {
                val_4 = this.notifications_;
            if(val_4 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS val_1 = null;
            val_4 = val_1;
            val_1 = new CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS();
            this.notifications_ = val_4;
            val_3 = other.notifications_;
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
        if(this.notifications_ == null)
        {
            goto label_3;
        }
        
        label_7:
        input.ReadMessage(builder:  this.notifications_);
        goto label_5;
        label_3:
        this.notifications_ = new CONFIG_DATA.Types.ENTRY.Types.PVP.Types.NOTIFICATIONS();
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
    private static CONFIG_DATA.Types.ENTRY.Types.PVP()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.PVP.NotificationsFieldNumber = new Google.Protobuf.MessageParser<PVP>(factory:  new System.Func<PVP>(object:  CONFIG_DATA.Types.ENTRY.Types.PVP.<>c.<>9, method:  PVP CONFIG_DATA.Types.ENTRY.Types.PVP.<>c::<.cctor>b__26_0()));
    }

}
