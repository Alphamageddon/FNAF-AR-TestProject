using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.EVENTBODY : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapNotifyIconFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string mapNotifyIcon_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapNotifyAudioFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string mapNotifyAudio_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MessageImageFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string messageImage_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisplayTextFromFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string displayTextFrom_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisplayTextToFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string displayTextTo_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisplayTextSubjectFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string displayTextSubject_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisplayTextBodyFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string displayTextBody_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD reward_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SendToAnimatronicInWarehouseFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string sendToAnimatronicInWarehouse_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TriggerFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER trigger_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TemplateBundleFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string templateBundle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TemplatePrefabFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string templatePrefab_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string MapNotifyIcon { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string MapNotifyAudio { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string MessageImage { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string DisplayTextFrom { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string DisplayTextTo { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string DisplayTextSubject { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string DisplayTextBody { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD Reward { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string SendToAnimatronicInWarehouse { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER Trigger { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string TemplateBundle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string TemplatePrefab { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EVENTBODY>)ALERT_DATA.Types.ENTRY.Types.EVENTBODY.TemplatePrefabFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY()
    {
        this.mapNotifyIcon_ = "";
        this.mapNotifyAudio_ = "";
        this.messageImage_ = "";
        this.displayTextFrom_ = "";
        this.displayTextTo_ = "";
        this.displayTextSubject_ = "";
        this.displayTextBody_ = "";
        this.sendToAnimatronicInWarehouse_ = "";
        this.templateBundle_ = "";
        this.templatePrefab_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY other)
    {
        REWARD val_4;
        TRIGGER val_5;
        if(other != null)
        {
                this.mapNotifyIcon_ = other.mapNotifyIcon_;
            this.mapNotifyAudio_ = other.mapNotifyAudio_;
            this.messageImage_ = other.messageImage_;
            this.displayTextFrom_ = other.displayTextFrom_;
            this.displayTextTo_ = other.displayTextTo_;
            this.displayTextSubject_ = other.displayTextSubject_;
            this.displayTextBody_ = other.displayTextBody_;
        }
        else
        {
                this.mapNotifyIcon_ = 15026800;
            this.mapNotifyAudio_ = 64;
            this.messageImage_ = 69077560;
            this.displayTextFrom_ = 0;
            this.displayTextTo_ = 4194311;
            this.displayTextSubject_ = 1;
            this.displayTextBody_ = 0;
        }
        
        val_4 = other.reward_;
        this.reward_ = val_4.Clone();
        this.sendToAnimatronicInWarehouse_ = other.sendToAnimatronicInWarehouse_;
        val_5 = other.trigger_;
        this.trigger_ = val_5.Clone();
        this.templateBundle_ = other.templateBundle_;
        this.templatePrefab_ = other.templatePrefab_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY Clone()
    {
        return (EVENTBODY)new ALERT_DATA.Types.ENTRY.Types.EVENTBODY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_MapNotifyIcon()
    {
        return (string)this.mapNotifyIcon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapNotifyIcon(string value)
    {
        this.mapNotifyIcon_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_MapNotifyAudio()
    {
        return (string)this.mapNotifyAudio_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapNotifyAudio(string value)
    {
        this.mapNotifyAudio_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_MessageImage()
    {
        return (string)this.messageImage_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MessageImage(string value)
    {
        this.messageImage_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_DisplayTextFrom()
    {
        return (string)this.displayTextFrom_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisplayTextFrom(string value)
    {
        this.displayTextFrom_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_DisplayTextTo()
    {
        return (string)this.displayTextTo_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisplayTextTo(string value)
    {
        this.displayTextTo_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_DisplayTextSubject()
    {
        return (string)this.displayTextSubject_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisplayTextSubject(string value)
    {
        this.displayTextSubject_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_DisplayTextBody()
    {
        return (string)this.displayTextBody_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisplayTextBody(string value)
    {
        this.displayTextBody_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD get_Reward()
    {
        return (REWARD)this.reward_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Reward(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD value)
    {
        this.reward_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_SendToAnimatronicInWarehouse()
    {
        return (string)this.sendToAnimatronicInWarehouse_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SendToAnimatronicInWarehouse(string value)
    {
        this.sendToAnimatronicInWarehouse_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER get_Trigger()
    {
        return (TRIGGER)this.trigger_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Trigger(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER value)
    {
        this.trigger_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_TemplateBundle()
    {
        return (string)this.templateBundle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TemplateBundle(string value)
    {
        this.templateBundle_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_TemplatePrefab()
    {
        return (string)this.templatePrefab_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TemplatePrefab(string value)
    {
        this.templatePrefab_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EVENTBODY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY other)
    {
        var val_13;
        if(other == null)
        {
            goto label_12;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((((((((((System.String.op_Inequality(a:  this.mapNotifyIcon_, b:  other.mapNotifyIcon_)) != true) && ((System.String.op_Inequality(a:  this.mapNotifyAudio_, b:  other.mapNotifyAudio_)) != true)) && ((System.String.op_Inequality(a:  this.messageImage_, b:  other.messageImage_)) != true)) && ((System.String.op_Inequality(a:  this.displayTextFrom_, b:  other.displayTextFrom_)) != true)) && ((System.String.op_Inequality(a:  this.displayTextTo_, b:  other.displayTextTo_)) != true)) && ((System.String.op_Inequality(a:  this.displayTextSubject_, b:  other.displayTextSubject_)) != true)) && ((System.String.op_Inequality(a:  this.displayTextBody_, b:  other.displayTextBody_)) != true)) && ((System.Object.Equals(objA:  this.reward_, objB:  other.reward_)) != false)) && ((System.String.op_Inequality(a:  this.sendToAnimatronicInWarehouse_, b:  other.sendToAnimatronicInWarehouse_)) != true)) && ((System.Object.Equals(objA:  this.trigger_, objB:  other.trigger_)) != false))
        {
                if((System.String.op_Inequality(a:  this.templateBundle_, b:  other.templateBundle_)) != true)
        {
                if((System.String.op_Inequality(a:  this.templatePrefab_, b:  other.templatePrefab_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_12:
        val_13 = 0;
        return (bool)val_13;
        label_1:
        val_13 = 1;
        return (bool)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(this.mapNotifyIcon_.Length != 0)
        {
                val_11 = this.mapNotifyIcon_ ^ 1;
        }
        else
        {
                val_11 = 1;
        }
        
        if(this.mapNotifyAudio_.Length != 0)
        {
                val_11 = this.mapNotifyAudio_ ^ val_11;
        }
        
        if(this.messageImage_.Length != 0)
        {
                val_11 = this.messageImage_ ^ val_11;
        }
        
        if(this.displayTextFrom_.Length != 0)
        {
                val_11 = this.displayTextFrom_ ^ val_11;
        }
        
        if(this.displayTextTo_.Length != 0)
        {
                val_11 = this.displayTextTo_ ^ val_11;
        }
        
        if(this.displayTextSubject_.Length != 0)
        {
                val_11 = this.displayTextSubject_ ^ val_11;
        }
        
        val_12 = 0;
        if(this.displayTextBody_.Length != 0)
        {
                val_11 = this.displayTextBody_ ^ val_11;
        }
        
        if(this.reward_ != null)
        {
                val_11 = this.reward_ ^ val_11;
        }
        
        val_13 = 0;
        if(this.sendToAnimatronicInWarehouse_.Length != 0)
        {
                val_11 = this.sendToAnimatronicInWarehouse_ ^ val_11;
        }
        
        if(this.trigger_ != null)
        {
                val_11 = this.trigger_ ^ val_11;
        }
        
        if(this.templateBundle_.Length != 0)
        {
                val_11 = this.templateBundle_ ^ val_11;
        }
        
        val_14 = 0;
        if(this.templatePrefab_.Length != 0)
        {
                val_11 = this.templatePrefab_ ^ val_11;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields ^ val_11;
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_11;
        string val_12;
        string val_13;
        string val_14;
        string val_15;
        string val_16;
        string val_17;
        REWARD val_18;
        string val_19;
        TRIGGER val_20;
        string val_21;
        string val_22;
        if(this.mapNotifyIcon_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_11 = this.mapNotifyIcon_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_11 = this.mapNotifyIcon_;
        }
        
            output.WriteString(value:  val_11);
        }
        
        if(this.mapNotifyAudio_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_12 = this.mapNotifyAudio_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_12 = this.mapNotifyAudio_;
        }
        
            output.WriteString(value:  val_12);
        }
        
        if(this.messageImage_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_13 = this.messageImage_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_13 = this.messageImage_;
        }
        
            output.WriteString(value:  val_13);
        }
        
        if(this.displayTextFrom_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_14 = this.displayTextFrom_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_14 = this.displayTextFrom_;
        }
        
            output.WriteString(value:  val_14);
        }
        
        if(this.displayTextTo_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_15 = this.displayTextTo_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_15 = this.displayTextTo_;
        }
        
            output.WriteString(value:  val_15);
        }
        
        if(this.displayTextSubject_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_16 = this.displayTextSubject_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_16 = this.displayTextSubject_;
        }
        
            output.WriteString(value:  val_16);
        }
        
        if(this.displayTextBody_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_17 = this.displayTextBody_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_17 = this.displayTextBody_;
        }
        
            output.WriteString(value:  val_17);
        }
        
        if(this.reward_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_18 = this.reward_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_18 = this.reward_;
        }
        
            output.WriteMessage(value:  val_18);
        }
        
        if(this.sendToAnimatronicInWarehouse_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_19 = this.sendToAnimatronicInWarehouse_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_19 = this.sendToAnimatronicInWarehouse_;
        }
        
            output.WriteString(value:  val_19);
        }
        
        if(this.trigger_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  82);
            val_20 = this.trigger_;
        }
        else
        {
                0.WriteRawTag(b1:  82);
            val_20 = this.trigger_;
        }
        
            output.WriteMessage(value:  val_20);
        }
        
        if(this.templateBundle_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  90);
            val_21 = this.templateBundle_;
        }
        else
        {
                0.WriteRawTag(b1:  90);
            val_21 = this.templateBundle_;
        }
        
            output.WriteString(value:  val_21);
        }
        
        if(this.templatePrefab_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  98);
            val_22 = this.templatePrefab_;
        }
        else
        {
                0.WriteRawTag(b1:  98);
            val_22 = this.templatePrefab_;
        }
        
            output.WriteString(value:  val_22);
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
        var val_35;
        if(this.mapNotifyIcon_.Length != 0)
        {
                val_35 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.mapNotifyIcon_)) + 1;
        }
        else
        {
                val_35 = 0;
        }
        
        if(this.mapNotifyAudio_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.mapNotifyAudio_))) + 1;
        }
        
        if(this.messageImage_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.messageImage_))) + 1;
        }
        
        if(this.displayTextFrom_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.displayTextFrom_))) + 1;
        }
        
        if(this.displayTextTo_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.displayTextTo_))) + 1;
        }
        
        if(this.displayTextSubject_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.displayTextSubject_))) + 1;
        }
        
        if(this.displayTextBody_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.displayTextBody_))) + 1;
        }
        
        if(this.reward_ != null)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.reward_))) + 1;
        }
        
        if(this.sendToAnimatronicInWarehouse_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.sendToAnimatronicInWarehouse_))) + 1;
        }
        
        if(this.trigger_ != null)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.trigger_))) + 1;
        }
        
        if(this.templateBundle_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.templateBundle_))) + 1;
        }
        
        if(this.templatePrefab_.Length != 0)
        {
                val_35 = (val_35 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.templatePrefab_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_35;
        }
        
        val_35 = this._unknownFields.CalculateSize() + val_35;
        return (int)val_35;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY other)
    {
        string val_14;
        REWARD val_15;
        REWARD val_16;
        TRIGGER val_17;
        TRIGGER val_18;
        if(other == null)
        {
                return;
        }
        
        if(other.mapNotifyIcon_.Length != 0)
        {
                this.MapNotifyIcon = other.mapNotifyIcon_;
        }
        
        if(other.mapNotifyAudio_.Length != 0)
        {
                this.MapNotifyAudio = other.mapNotifyAudio_;
        }
        
        if(other.messageImage_.Length != 0)
        {
                this.MessageImage = other.messageImage_;
        }
        
        if(other.displayTextFrom_.Length != 0)
        {
                this.DisplayTextFrom = other.displayTextFrom_;
        }
        
        if(other.displayTextTo_.Length != 0)
        {
                this.DisplayTextTo = other.displayTextTo_;
        }
        
        if(other.displayTextSubject_.Length != 0)
        {
                this.DisplayTextSubject = other.displayTextSubject_;
        }
        
        if(other.displayTextBody_.Length != 0)
        {
                this.DisplayTextBody = other.displayTextBody_;
        }
        
        val_15 = other.reward_;
        if(val_15 != null)
        {
                val_16 = this.reward_;
            if(val_16 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD val_8 = null;
            val_16 = val_8;
            val_8 = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD();
            this.reward_ = val_16;
            val_15 = other.reward_;
        }
        
            val_8.MergeFrom(other:  val_15);
        }
        
        if(other.sendToAnimatronicInWarehouse_.Length != 0)
        {
                this.SendToAnimatronicInWarehouse = other.sendToAnimatronicInWarehouse_;
        }
        
        val_17 = other.trigger_;
        if(val_17 != null)
        {
                val_18 = this.trigger_;
            if(val_18 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER val_10 = null;
            val_18 = val_10;
            val_10 = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER();
            this.trigger_ = val_18;
            val_17 = other.trigger_;
        }
        
            val_10.MergeFrom(other:  val_17);
        }
        
        if(other.templateBundle_.Length != 0)
        {
                this.TemplateBundle = other.templateBundle_;
        }
        
        val_14 = other.templatePrefab_;
        if(val_14.Length != 0)
        {
                this.TemplatePrefab = other.templatePrefab_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        REWARD val_15;
        goto label_43;
        label_47:
        if(18422 > 50)
        {
            goto label_2;
        }
        
        if(18422 > 26)
        {
            goto label_3;
        }
        
        if(18422 == 10)
        {
            goto label_4;
        }
        
        if(18422 == 18)
        {
            goto label_5;
        }
        
        if(18422 != 26)
        {
            goto label_22;
        }
        
        this.MessageImage = input.ReadString();
        goto label_43;
        label_2:
        if(18422 > 74)
        {
            goto label_9;
        }
        
        if(18422 == 58)
        {
            goto label_10;
        }
        
        if(18422 == 66)
        {
            goto label_11;
        }
        
        if(18422 != 74)
        {
            goto label_22;
        }
        
        this.SendToAnimatronicInWarehouse = input.ReadString();
        goto label_43;
        label_3:
        if(18422 == 34)
        {
            goto label_15;
        }
        
        if(18422 == 42)
        {
            goto label_16;
        }
        
        if(18422 != 50)
        {
            goto label_22;
        }
        
        this.DisplayTextSubject = input.ReadString();
        goto label_43;
        label_9:
        if(18422 == 82)
        {
            goto label_20;
        }
        
        if(18422 == 90)
        {
            goto label_21;
        }
        
        if(18422 != 98)
        {
            goto label_22;
        }
        
        this.TemplatePrefab = input.ReadString();
        goto label_43;
        label_22:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_43;
        label_5:
        this.MapNotifyAudio = input.ReadString();
        goto label_43;
        label_11:
        val_15 = this.reward_;
        if(val_15 != null)
        {
            goto label_28;
        }
        
        ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD val_7 = null;
        val_15 = val_7;
        val_7 = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD();
        this.reward_ = val_15;
        if(input != null)
        {
            goto label_44;
        }
        
        goto label_45;
        label_16:
        this.DisplayTextTo = input.ReadString();
        goto label_43;
        label_21:
        this.TemplateBundle = input.ReadString();
        goto label_43;
        label_4:
        this.MapNotifyIcon = input.ReadString();
        goto label_43;
        label_10:
        this.DisplayTextBody = input.ReadString();
        goto label_43;
        label_15:
        this.DisplayTextFrom = input.ReadString();
        goto label_43;
        label_20:
        val_15 = this.trigger_;
        if(val_15 == null)
        {
            goto label_41;
        }
        
        label_28:
        if(input != null)
        {
            goto label_44;
        }
        
        label_45:
        label_44:
        input.ReadMessage(builder:  val_15);
        goto label_43;
        label_41:
        this.trigger_ = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.TRIGGER();
        if(input != null)
        {
            goto label_44;
        }
        
        goto label_45;
        label_43:
        if(input.ReadTag() != 0)
        {
            goto label_47;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.EVENTBODY()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.EVENTBODY.TemplatePrefabFieldNumber = new Google.Protobuf.MessageParser<EVENTBODY>(factory:  new System.Func<EVENTBODY>(object:  ALERT_DATA.Types.ENTRY.Types.EVENTBODY.<>c.<>9, method:  EVENTBODY ALERT_DATA.Types.ENTRY.Types.EVENTBODY.<>c::<.cctor>b__81_0()));
    }

}
