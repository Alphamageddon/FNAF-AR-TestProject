using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int IsEnabledFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isEnabled_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UseFinalRewardDialogFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool useFinalRewardDialog_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EnabledPlacementsFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string enabledPlacements_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsEnabled { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseFinalRewardDialog { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string EnabledPlacements { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<TAPJOY>)CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.EnabledPlacementsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ADS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY()
    {
        this.enabledPlacements_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY other)
    {
        if(other != null)
        {
                this.isEnabled_ = other.isEnabled_;
            this.useFinalRewardDialog_ = other.useFinalRewardDialog_;
            this.enabledPlacements_ = other.enabledPlacements_;
        }
        else
        {
                this.isEnabled_ = false;
            this.useFinalRewardDialog_ = false;
            this.enabledPlacements_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY Clone()
    {
        return (TAPJOY)new CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsEnabled()
    {
        return (bool)this.isEnabled_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_IsEnabled(bool value)
    {
        this.isEnabled_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseFinalRewardDialog()
    {
        return (bool)this.useFinalRewardDialog_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseFinalRewardDialog(bool value)
    {
        this.useFinalRewardDialog_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_EnabledPlacements()
    {
        return (string)this.enabledPlacements_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EnabledPlacements(string value)
    {
        this.enabledPlacements_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        TAPJOY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY other)
    {
        var val_6;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        var val_1 = (this.isEnabled_ == true) ? 1 : 0;
        val_1 = val_1 ^ ((other.isEnabled_ == true) ? 1 : 0);
        if((val_1 & 1) == 0)
        {
                var val_3 = (this.useFinalRewardDialog_ == true) ? 1 : 0;
            val_3 = val_3 ^ ((other.useFinalRewardDialog_ == true) ? 1 : 0);
            if((val_3 & 1) == 0)
        {
                if((System.String.op_Inequality(a:  this.enabledPlacements_, b:  other.enabledPlacements_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_3:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        val_4 = 1;
        if(this.isEnabled_ != false)
        {
                val_4 = val_4.GetHashCode() ^ 1;
        }
        
        if(this.useFinalRewardDialog_ != false)
        {
                val_4 = 1.GetHashCode() ^ val_4;
        }
        
        val_5 = 0;
        if(this.enabledPlacements_.Length != 0)
        {
                val_4 = this.enabledPlacements_ ^ val_4;
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
        bool val_4;
        bool val_5;
        string val_6;
        if(this.isEnabled_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_4 = this.isEnabled_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_4 = this.isEnabled_;
        }
        
            output.WriteBool(value:  (val_4 == true) ? 1 : 0);
        }
        
        if(this.useFinalRewardDialog_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_5 = this.useFinalRewardDialog_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_5 = this.useFinalRewardDialog_;
        }
        
            output.WriteBool(value:  (val_5 == true) ? 1 : 0);
        }
        
        if(this.enabledPlacements_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_6 = this.enabledPlacements_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_6 = this.enabledPlacements_;
        }
        
            output.WriteString(value:  val_6);
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
        bool val_7 = this.isEnabled_;
        val_7 = val_7 << 1;
        if(this.enabledPlacements_.Length != 0)
        {
                val_7 = (((this.useFinalRewardDialog_ == true) ? (val_7 + 2) : (val_7)) | 1) + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.enabledPlacements_));
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.isEnabled_ != false)
        {
                this.isEnabled_ = other.isEnabled_;
        }
        
        if(other.useFinalRewardDialog_ != false)
        {
                this.useFinalRewardDialog_ = other.useFinalRewardDialog_;
        }
        
        if(other.enabledPlacements_.Length != 0)
        {
                this.EnabledPlacements = other.enabledPlacements_;
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
        if(val_2 <= 15)
        {
            goto label_2;
        }
        
        if(val_2 == 16)
        {
            goto label_3;
        }
        
        if(val_2 != 26)
        {
            goto label_12;
        }
        
        this.EnabledPlacements = input.ReadString();
        goto label_11;
        label_2:
        if(val_2 != 8)
        {
            goto label_7;
        }
        
        this.isEnabled_ = input.ReadBool();
        goto label_11;
        label_3:
        this.useFinalRewardDialog_ = input.ReadBool();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.EnabledPlacementsFieldNumber = new Google.Protobuf.MessageParser<TAPJOY>(factory:  new System.Func<TAPJOY>(object:  CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.<>c.<>9, method:  TAPJOY CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY.<>c::<.cctor>b__35_0()));
    }

}
