using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryBonusFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryBonus_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDurFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDur_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryActivateFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryActivate_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryBonus { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDur { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryActivate { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<EXTRABATTERY>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.BatteryActivateFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY other)
    {
        if(other != null)
        {
                this.batteryBonus_ = other.batteryBonus_;
            this.batteryDur_ = other.batteryDur_;
            this.batteryActivate_ = other.batteryActivate_;
        }
        else
        {
                this.batteryBonus_ = 7.42422564692724E-317;
            this.batteryDur_ = 3.16202013338398E-322;
            this.batteryActivate_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY Clone()
    {
        return (EXTRABATTERY)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryBonus()
    {
        return (double)this.batteryBonus_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryBonus(double value)
    {
        this.batteryBonus_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDur()
    {
        return (double)this.batteryDur_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDur(double value)
    {
        this.batteryDur_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryActivate()
    {
        return (double)this.batteryActivate_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryActivate(double value)
    {
        this.batteryActivate_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        EXTRABATTERY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.batteryBonus_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.batteryDur_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.batteryActivate_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_14:
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
        if(this.batteryBonus_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.batteryDur_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.batteryActivate_ != 0f)
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
        double val_1;
        double val_2;
        double val_3;
        if(this.batteryBonus_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.batteryBonus_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.batteryBonus_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.batteryDur_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.batteryDur_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.batteryDur_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.batteryActivate_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.batteryActivate_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.batteryActivate_;
        }
        
            output.WriteDouble(value:  val_3);
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
        var val_1 = (this.batteryBonus_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.batteryDur_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.batteryActivate_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.batteryBonus_ != 0f)
        {
                this.batteryBonus_ = other.batteryBonus_;
        }
        
        if(other.batteryDur_ != 0f)
        {
                this.batteryDur_ = other.batteryDur_;
        }
        
        if(other.batteryActivate_ != 0f)
        {
                this.batteryActivate_ = other.batteryActivate_;
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
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.batteryActivate_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.batteryBonus_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.batteryDur_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.BatteryActivateFieldNumber = new Google.Protobuf.MessageParser<EXTRABATTERY>(factory:  new System.Func<EXTRABATTERY>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.<>c.<>9, method:  EXTRABATTERY DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY.<>c::<.cctor>b__35_0()));
    }

}
