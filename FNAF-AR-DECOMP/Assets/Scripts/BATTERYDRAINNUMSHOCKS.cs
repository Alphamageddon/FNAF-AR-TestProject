using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainNumShocks0FieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainNumShocks0_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainNumShocks1FieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainNumShocks1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainNumShocks2FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainNumShocks2_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainNumShocks3FieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainNumShocks3_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainNumShocks0 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainNumShocks1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainNumShocks2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainNumShocks3 { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BATTERYDRAINNUMSHOCKS>)ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS.BatteryDrainNumShocks3FieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS other)
    {
        if(other != null)
        {
                this.batteryDrainNumShocks0_ = other.batteryDrainNumShocks0_;
            this.batteryDrainNumShocks1_ = other.batteryDrainNumShocks1_;
            this.batteryDrainNumShocks2_ = other.batteryDrainNumShocks2_;
            this.batteryDrainNumShocks3_ = other.batteryDrainNumShocks3_;
        }
        else
        {
                this.batteryDrainNumShocks0_ = 7.42422564692724E-317;
            this.batteryDrainNumShocks1_ = 3.16202013338398E-322;
            this.batteryDrainNumShocks2_ = 3.41288492945375E-316;
            this.batteryDrainNumShocks3_ = 1.33509863819657E-307;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS Clone()
    {
        return (BATTERYDRAINNUMSHOCKS)new ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainNumShocks0()
    {
        return (double)this.batteryDrainNumShocks0_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainNumShocks0(double value)
    {
        this.batteryDrainNumShocks0_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainNumShocks1()
    {
        return (double)this.batteryDrainNumShocks1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainNumShocks1(double value)
    {
        this.batteryDrainNumShocks1_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainNumShocks2()
    {
        return (double)this.batteryDrainNumShocks2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainNumShocks2(double value)
    {
        this.batteryDrainNumShocks2_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainNumShocks3()
    {
        return (double)this.batteryDrainNumShocks3_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainNumShocks3(double value)
    {
        this.batteryDrainNumShocks3_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BATTERYDRAINNUMSHOCKS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS other)
    {
        var val_5;
        double val_6;
        var val_7;
        if(other == null)
        {
            goto label_18;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_6 = this.batteryDrainNumShocks0_;
        val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_5 & 1) != 0)
        {
                val_6 = this.batteryDrainNumShocks1_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.batteryDrainNumShocks2_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.batteryDrainNumShocks3_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.batteryDrainNumShocks0_ == 0f)
        {
                val_5 = 1;
        }
        else
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.batteryDrainNumShocks1_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.batteryDrainNumShocks2_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.batteryDrainNumShocks3_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
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
        double val_1;
        double val_2;
        double val_3;
        double val_4;
        if(this.batteryDrainNumShocks0_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.batteryDrainNumShocks0_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.batteryDrainNumShocks0_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.batteryDrainNumShocks1_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.batteryDrainNumShocks1_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.batteryDrainNumShocks1_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.batteryDrainNumShocks2_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.batteryDrainNumShocks2_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.batteryDrainNumShocks2_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.batteryDrainNumShocks3_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.batteryDrainNumShocks3_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.batteryDrainNumShocks3_;
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
        var val_5;
        var val_1 = (this.batteryDrainNumShocks0_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.batteryDrainNumShocks1_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainNumShocks2_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.batteryDrainNumShocks3_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.batteryDrainNumShocks0_ != 0f)
        {
                this.batteryDrainNumShocks0_ = other.batteryDrainNumShocks0_;
        }
        
        if(other.batteryDrainNumShocks1_ != 0f)
        {
                this.batteryDrainNumShocks1_ = other.batteryDrainNumShocks1_;
        }
        
        if(other.batteryDrainNumShocks2_ != 0f)
        {
                this.batteryDrainNumShocks2_ = other.batteryDrainNumShocks2_;
        }
        
        if(other.batteryDrainNumShocks3_ != 0f)
        {
                this.batteryDrainNumShocks3_ = other.batteryDrainNumShocks3_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
        if(this > 17)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this != 17)
        {
            goto label_7;
        }
        
        this.batteryDrainNumShocks1_ = input.ReadDouble();
        goto label_12;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this != 33)
        {
            goto label_7;
        }
        
        this.batteryDrainNumShocks3_ = input.ReadDouble();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.batteryDrainNumShocks0_ = input.ReadDouble();
        goto label_12;
        label_6:
        this.batteryDrainNumShocks2_ = input.ReadDouble();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS.BatteryDrainNumShocks3FieldNumber = new Google.Protobuf.MessageParser<BATTERYDRAINNUMSHOCKS>(factory:  new System.Func<BATTERYDRAINNUMSHOCKS>(object:  ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS.<>c.<>9, method:  BATTERYDRAINNUMSHOCKS ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS.<>c::<.cctor>b__40_0()));
    }

}
