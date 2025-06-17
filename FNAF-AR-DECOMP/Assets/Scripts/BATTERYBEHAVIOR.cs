using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryStunDrainFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryStunDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryBaseDrainFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryBaseDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryBaseRechargeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryBaseRecharge_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ExtraBatteryPackBoostFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double extraBatteryPackBoost_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryShockDrainFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryShockDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightDrainFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ExtraBatteryPackTimerFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double extraBatteryPackTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceFlashlightDrainFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double essenceFlashlightDrain_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AllowedExtraBatteriesFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double allowedExtraBatteries_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryStunDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryBaseDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryBaseRecharge { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ExtraBatteryPackBoost { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryShockDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ExtraBatteryPackTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double EssenceFlashlightDrain { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double AllowedExtraBatteries { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BATTERYBEHAVIOR>)CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.AllowedExtraBatteriesFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR(ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR other)
    {
        if(other != null)
        {
                this.batteryStunDrain_ = other.batteryStunDrain_;
            this.batteryBaseDrain_ = other.batteryBaseDrain_;
            this.batteryBaseRecharge_ = other.batteryBaseRecharge_;
            this.extraBatteryPackBoost_ = other.extraBatteryPackBoost_;
            this.batteryShockDrain_ = other.batteryShockDrain_;
            this.flashlightDrain_ = other.flashlightDrain_;
            this.extraBatteryPackTimer_ = other.extraBatteryPackTimer_;
            this.essenceFlashlightDrain_ = other.essenceFlashlightDrain_;
            this.allowedExtraBatteries_ = other.allowedExtraBatteries_;
        }
        else
        {
                this.batteryStunDrain_ = 7.42422564692724E-317;
            this.batteryBaseDrain_ = 3.16202013338398E-322;
            this.batteryBaseRecharge_ = 3.41288492945375E-316;
            this.extraBatteryPackBoost_ = 1.33509863819657E-307;
            this.batteryShockDrain_ = 3.75487155418531E-308;
            this.flashlightDrain_ = 1.06099789553204E-313;
            this.extraBatteryPackTimer_ = 0;
            this.essenceFlashlightDrain_ = 0;
            this.allowedExtraBatteries_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR Clone()
    {
        return (BATTERYBEHAVIOR)new CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryStunDrain()
    {
        return (double)this.batteryStunDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryStunDrain(double value)
    {
        this.batteryStunDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryBaseDrain()
    {
        return (double)this.batteryBaseDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryBaseDrain(double value)
    {
        this.batteryBaseDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryBaseRecharge()
    {
        return (double)this.batteryBaseRecharge_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryBaseRecharge(double value)
    {
        this.batteryBaseRecharge_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ExtraBatteryPackBoost()
    {
        return (double)this.extraBatteryPackBoost_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ExtraBatteryPackBoost(double value)
    {
        this.extraBatteryPackBoost_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryShockDrain()
    {
        return (double)this.batteryShockDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryShockDrain(double value)
    {
        this.batteryShockDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightDrain()
    {
        return (double)this.flashlightDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightDrain(double value)
    {
        this.flashlightDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ExtraBatteryPackTimer()
    {
        return (double)this.extraBatteryPackTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ExtraBatteryPackTimer(double value)
    {
        this.extraBatteryPackTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_EssenceFlashlightDrain()
    {
        return (double)this.essenceFlashlightDrain_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceFlashlightDrain(double value)
    {
        this.essenceFlashlightDrain_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_AllowedExtraBatteries()
    {
        return (double)this.allowedExtraBatteries_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AllowedExtraBatteries(double value)
    {
        this.allowedExtraBatteries_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BATTERYBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR other)
    {
        var val_10;
        double val_11;
        var val_12;
        if(other == null)
        {
            goto label_38;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_11 = this.batteryStunDrain_;
        val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_10 & 1) != 0)
        {
                val_11 = this.batteryBaseDrain_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.batteryBaseRecharge_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.extraBatteryPackBoost_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.batteryShockDrain_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.flashlightDrain_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.extraBatteryPackTimer_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.essenceFlashlightDrain_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                val_11 = this.allowedExtraBatteries_;
            val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_10 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_38:
        val_12 = 0;
        return (bool)val_12;
        label_2:
        val_12 = 1;
        return (bool)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_10;
        if(this.batteryStunDrain_ == 0f)
        {
                val_10 = 1;
        }
        else
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.batteryBaseDrain_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.batteryBaseRecharge_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.extraBatteryPackBoost_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.batteryShockDrain_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.flashlightDrain_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.extraBatteryPackTimer_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.essenceFlashlightDrain_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this.allowedExtraBatteries_ != 0f)
        {
                val_10 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_10;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields ^ val_10;
        return (int)val_10;
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
        double val_3;
        double val_4;
        double val_5;
        double val_6;
        double val_7;
        double val_8;
        double val_9;
        if(this.batteryStunDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.batteryStunDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.batteryStunDrain_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.batteryBaseDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.batteryBaseDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.batteryBaseDrain_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.batteryBaseRecharge_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.batteryBaseRecharge_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.batteryBaseRecharge_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.extraBatteryPackBoost_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.extraBatteryPackBoost_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.extraBatteryPackBoost_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.batteryShockDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.batteryShockDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.batteryShockDrain_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.flashlightDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.flashlightDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.flashlightDrain_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.extraBatteryPackTimer_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.extraBatteryPackTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.extraBatteryPackTimer_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.essenceFlashlightDrain_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.essenceFlashlightDrain_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.essenceFlashlightDrain_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.allowedExtraBatteries_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_9 = this.allowedExtraBatteries_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_9 = this.allowedExtraBatteries_;
        }
        
            output.WriteDouble(value:  val_9);
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
        var val_1 = (this.batteryStunDrain_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.batteryBaseDrain_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryBaseRecharge_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.extraBatteryPackBoost_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryShockDrain_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.flashlightDrain_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.extraBatteryPackTimer_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.essenceFlashlightDrain_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.allowedExtraBatteries_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.batteryStunDrain_ != 0f)
        {
                this.batteryStunDrain_ = other.batteryStunDrain_;
        }
        
        if(other.batteryBaseDrain_ != 0f)
        {
                this.batteryBaseDrain_ = other.batteryBaseDrain_;
        }
        
        if(other.batteryBaseRecharge_ != 0f)
        {
                this.batteryBaseRecharge_ = other.batteryBaseRecharge_;
        }
        
        if(other.extraBatteryPackBoost_ != 0f)
        {
                this.extraBatteryPackBoost_ = other.extraBatteryPackBoost_;
        }
        
        if(other.batteryShockDrain_ != 0f)
        {
                this.batteryShockDrain_ = other.batteryShockDrain_;
        }
        
        if(other.flashlightDrain_ != 0f)
        {
                this.flashlightDrain_ = other.flashlightDrain_;
        }
        
        if(other.extraBatteryPackTimer_ != 0f)
        {
                this.extraBatteryPackTimer_ = other.extraBatteryPackTimer_;
        }
        
        if(other.essenceFlashlightDrain_ != 0f)
        {
                this.essenceFlashlightDrain_ = other.essenceFlashlightDrain_;
        }
        
        if(other.allowedExtraBatteries_ != 0f)
        {
                this.allowedExtraBatteries_ = other.allowedExtraBatteries_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_29;
        label_32:
        if(this > 33)
        {
            goto label_1;
        }
        
        if(this > 17)
        {
            goto label_2;
        }
        
        if(this == 9)
        {
            goto label_3;
        }
        
        if(this != 17)
        {
            goto label_18;
        }
        
        this.batteryBaseDrain_ = input.ReadDouble();
        goto label_29;
        label_1:
        if(this > 49)
        {
            goto label_7;
        }
        
        if(this == 41)
        {
            goto label_8;
        }
        
        if(this != 49)
        {
            goto label_18;
        }
        
        this.flashlightDrain_ = input.ReadDouble();
        goto label_29;
        label_2:
        if(this == 25)
        {
            goto label_12;
        }
        
        if(this != 33)
        {
            goto label_18;
        }
        
        this.extraBatteryPackBoost_ = input.ReadDouble();
        goto label_29;
        label_7:
        if(this == 57)
        {
            goto label_16;
        }
        
        if(this == 65)
        {
            goto label_17;
        }
        
        if(this != 73)
        {
            goto label_18;
        }
        
        this.allowedExtraBatteries_ = input.ReadDouble();
        goto label_29;
        label_18:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_29;
        label_3:
        this.batteryStunDrain_ = input.ReadDouble();
        goto label_29;
        label_8:
        this.batteryShockDrain_ = input.ReadDouble();
        goto label_29;
        label_12:
        this.batteryBaseRecharge_ = input.ReadDouble();
        goto label_29;
        label_16:
        this.extraBatteryPackTimer_ = input.ReadDouble();
        goto label_29;
        label_17:
        this.essenceFlashlightDrain_ = input.ReadDouble();
        label_29:
        if(input.ReadTag() != 0)
        {
            goto label_32;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.AllowedExtraBatteriesFieldNumber = new Google.Protobuf.MessageParser<BATTERYBEHAVIOR>(factory:  new System.Func<BATTERYBEHAVIOR>(object:  CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.<>c.<>9, method:  BATTERYBEHAVIOR CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR.<>c::<.cctor>b__65_0()));
    }

}
