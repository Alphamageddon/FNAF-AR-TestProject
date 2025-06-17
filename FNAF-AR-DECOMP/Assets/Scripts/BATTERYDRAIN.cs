using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN : IMessage<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainGeneralFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainGeneral_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainFinalApproachFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainFinalApproach_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainInvisibleFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainInvisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainUnspottedFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainUnspotted_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainSpottedFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainSpotted_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainFizzlePreVisibleFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainFizzlePreVisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainFizzleVisibleFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainFizzleVisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainShockedFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainShocked_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainRepositionFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainReposition_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainNumShocksFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS batteryDrainNumShocks_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainCloakedFieldNumber = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainCloaked_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BatteryDrainDecloakedFieldNumber = 12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double batteryDrainDecloaked_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainGeneral { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainFinalApproach { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainInvisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainUnspotted { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainSpotted { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainFizzlePreVisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainFizzleVisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainShocked { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainReposition { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS BatteryDrainNumShocks { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainCloaked { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double BatteryDrainDecloaked { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BATTERYDRAIN>)ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.BatteryDrainDecloakedFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.BATTERY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN other)
    {
        BATTERYDRAINNUMSHOCKS val_3;
        if(other != null)
        {
                this.batteryDrainGeneral_ = other.batteryDrainGeneral_;
            this.batteryDrainFinalApproach_ = other.batteryDrainFinalApproach_;
            this.batteryDrainInvisible_ = other.batteryDrainInvisible_;
            this.batteryDrainUnspotted_ = other.batteryDrainUnspotted_;
            this.batteryDrainSpotted_ = other.batteryDrainSpotted_;
            this.batteryDrainFizzlePreVisible_ = other.batteryDrainFizzlePreVisible_;
            this.batteryDrainFizzleVisible_ = other.batteryDrainFizzleVisible_;
            this.batteryDrainShocked_ = other.batteryDrainShocked_;
            this.batteryDrainReposition_ = other.batteryDrainReposition_;
        }
        else
        {
                this.batteryDrainGeneral_ = 7.42422564692724E-317;
            this.batteryDrainFinalApproach_ = 3.16202013338398E-322;
            this.batteryDrainInvisible_ = 3.41288492945375E-316;
            this.batteryDrainUnspotted_ = 1.33509863819657E-307;
            this.batteryDrainSpotted_ = 3.75487155418531E-308;
            this.batteryDrainFizzlePreVisible_ = 1.06099789553204E-313;
            this.batteryDrainFizzleVisible_ = 0;
            this.batteryDrainShocked_ = 0;
            this.batteryDrainReposition_ = 0;
        }
        
        val_3 = other.batteryDrainNumShocks_;
        this.batteryDrainNumShocks_ = val_3.Clone();
        this.batteryDrainCloaked_ = other.batteryDrainCloaked_;
        this.batteryDrainDecloaked_ = other.batteryDrainDecloaked_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN Clone()
    {
        return (BATTERYDRAIN)new ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainGeneral()
    {
        return (double)this.batteryDrainGeneral_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainGeneral(double value)
    {
        this.batteryDrainGeneral_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainFinalApproach()
    {
        return (double)this.batteryDrainFinalApproach_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainFinalApproach(double value)
    {
        this.batteryDrainFinalApproach_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainInvisible()
    {
        return (double)this.batteryDrainInvisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainInvisible(double value)
    {
        this.batteryDrainInvisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainUnspotted()
    {
        return (double)this.batteryDrainUnspotted_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainUnspotted(double value)
    {
        this.batteryDrainUnspotted_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainSpotted()
    {
        return (double)this.batteryDrainSpotted_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainSpotted(double value)
    {
        this.batteryDrainSpotted_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainFizzlePreVisible()
    {
        return (double)this.batteryDrainFizzlePreVisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainFizzlePreVisible(double value)
    {
        this.batteryDrainFizzlePreVisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainFizzleVisible()
    {
        return (double)this.batteryDrainFizzleVisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainFizzleVisible(double value)
    {
        this.batteryDrainFizzleVisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainShocked()
    {
        return (double)this.batteryDrainShocked_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainShocked(double value)
    {
        this.batteryDrainShocked_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainReposition()
    {
        return (double)this.batteryDrainReposition_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainReposition(double value)
    {
        this.batteryDrainReposition_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS get_BatteryDrainNumShocks()
    {
        return (BATTERYDRAINNUMSHOCKS)this.batteryDrainNumShocks_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainNumShocks(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS value)
    {
        this.batteryDrainNumShocks_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainCloaked()
    {
        return (double)this.batteryDrainCloaked_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainCloaked(double value)
    {
        this.batteryDrainCloaked_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_BatteryDrainDecloaked()
    {
        return (double)this.batteryDrainDecloaked_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BatteryDrainDecloaked(double value)
    {
        this.batteryDrainDecloaked_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BATTERYDRAIN val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN other)
    {
        var val_13;
        double val_14;
        var val_15;
        if(other == null)
        {
            goto label_47;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_14 = this.batteryDrainGeneral_;
        val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_13 & 1) == 0)
        {
            goto label_47;
        }
        
        val_14 = this.batteryDrainFinalApproach_;
        val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainInvisible_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainUnspotted_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainSpotted_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainFizzlePreVisible_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainFizzleVisible_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainShocked_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainReposition_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if(((val_13 & 1) != 0) && ((System.Object.Equals(objA:  this.batteryDrainNumShocks_, objB:  other.batteryDrainNumShocks_)) != false))
        {
                val_14 = this.batteryDrainCloaked_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
        {
                val_14 = this.batteryDrainDecloaked_;
            val_13 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_13 & 1) != 0)
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
        
        }
        
        label_47:
        val_15 = 0;
        return (bool)val_15;
        label_2:
        val_15 = 1;
        return (bool)val_15;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_12;
        if(this.batteryDrainGeneral_ == 0f)
        {
                val_12 = 1;
        }
        else
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.batteryDrainFinalApproach_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainInvisible_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainUnspotted_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainSpotted_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainFizzlePreVisible_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainFizzleVisible_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainShocked_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainReposition_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainNumShocks_ != null)
        {
                val_12 = this.batteryDrainNumShocks_ ^ val_12;
        }
        
        if(this.batteryDrainCloaked_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this.batteryDrainDecloaked_ != 0f)
        {
                val_12 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_12;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_12;
        }
        
        val_12 = this._unknownFields ^ val_12;
        return (int)val_12;
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
        BATTERYDRAINNUMSHOCKS val_10;
        double val_11;
        double val_12;
        if(this.batteryDrainGeneral_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.batteryDrainGeneral_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.batteryDrainGeneral_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.batteryDrainFinalApproach_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.batteryDrainFinalApproach_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.batteryDrainFinalApproach_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.batteryDrainInvisible_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.batteryDrainInvisible_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.batteryDrainInvisible_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.batteryDrainUnspotted_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.batteryDrainUnspotted_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.batteryDrainUnspotted_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.batteryDrainSpotted_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.batteryDrainSpotted_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.batteryDrainSpotted_;
        }
        
            output.WriteDouble(value:  val_5);
        }
        
        if(this.batteryDrainFizzlePreVisible_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  49);
            val_6 = this.batteryDrainFizzlePreVisible_;
        }
        else
        {
                0.WriteRawTag(b1:  49);
            val_6 = this.batteryDrainFizzlePreVisible_;
        }
        
            output.WriteDouble(value:  val_6);
        }
        
        if(this.batteryDrainFizzleVisible_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.batteryDrainFizzleVisible_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.batteryDrainFizzleVisible_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.batteryDrainShocked_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  65);
            val_8 = this.batteryDrainShocked_;
        }
        else
        {
                0.WriteRawTag(b1:  65);
            val_8 = this.batteryDrainShocked_;
        }
        
            output.WriteDouble(value:  val_8);
        }
        
        if(this.batteryDrainReposition_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  73);
            val_9 = this.batteryDrainReposition_;
        }
        else
        {
                0.WriteRawTag(b1:  73);
            val_9 = this.batteryDrainReposition_;
        }
        
            output.WriteDouble(value:  val_9);
        }
        
        if(this.batteryDrainNumShocks_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  82);
            val_10 = this.batteryDrainNumShocks_;
        }
        else
        {
                0.WriteRawTag(b1:  82);
            val_10 = this.batteryDrainNumShocks_;
        }
        
            output.WriteMessage(value:  val_10);
        }
        
        if(this.batteryDrainCloaked_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  89);
            val_11 = this.batteryDrainCloaked_;
        }
        else
        {
                0.WriteRawTag(b1:  89);
            val_11 = this.batteryDrainCloaked_;
        }
        
            output.WriteDouble(value:  val_11);
        }
        
        if(this.batteryDrainDecloaked_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  97);
            val_12 = this.batteryDrainDecloaked_;
        }
        else
        {
                0.WriteRawTag(b1:  97);
            val_12 = this.batteryDrainDecloaked_;
        }
        
            output.WriteDouble(value:  val_12);
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
        var val_1 = (this.batteryDrainGeneral_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.batteryDrainFinalApproach_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainInvisible_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainUnspotted_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainSpotted_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainFizzlePreVisible_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainFizzleVisible_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.batteryDrainShocked_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this.batteryDrainNumShocks_ != null)
        {
                int val_5 = ((this.batteryDrainReposition_ == 0f) ? (val_1) : (val_2)) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.batteryDrainNumShocks_));
            val_9 = val_5 + 1;
        }
        
        val_5 = val_9 + 9;
        var val_6 = (this.batteryDrainCloaked_ == 0f) ? (val_9) : (val_5);
        val_2 = val_6 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + ((this.batteryDrainDecloaked_ == 0f) ? (val_6) : (val_2));
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN other)
    {
        BATTERYDRAINNUMSHOCKS val_3;
        BATTERYDRAINNUMSHOCKS val_4;
        if(other == null)
        {
                return;
        }
        
        if(other.batteryDrainGeneral_ != 0f)
        {
                this.batteryDrainGeneral_ = other.batteryDrainGeneral_;
        }
        
        if(other.batteryDrainFinalApproach_ != 0f)
        {
                this.batteryDrainFinalApproach_ = other.batteryDrainFinalApproach_;
        }
        
        if(other.batteryDrainInvisible_ != 0f)
        {
                this.batteryDrainInvisible_ = other.batteryDrainInvisible_;
        }
        
        if(other.batteryDrainUnspotted_ != 0f)
        {
                this.batteryDrainUnspotted_ = other.batteryDrainUnspotted_;
        }
        
        if(other.batteryDrainSpotted_ != 0f)
        {
                this.batteryDrainSpotted_ = other.batteryDrainSpotted_;
        }
        
        if(other.batteryDrainFizzlePreVisible_ != 0f)
        {
                this.batteryDrainFizzlePreVisible_ = other.batteryDrainFizzlePreVisible_;
        }
        
        if(other.batteryDrainFizzleVisible_ != 0f)
        {
                this.batteryDrainFizzleVisible_ = other.batteryDrainFizzleVisible_;
        }
        
        if(other.batteryDrainShocked_ != 0f)
        {
                this.batteryDrainShocked_ = other.batteryDrainShocked_;
        }
        
        if(other.batteryDrainReposition_ != 0f)
        {
                this.batteryDrainReposition_ = other.batteryDrainReposition_;
        }
        
        val_3 = other.batteryDrainNumShocks_;
        if(val_3 != null)
        {
                val_4 = this.batteryDrainNumShocks_;
            if(val_4 == null)
        {
                ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS val_1 = null;
            val_4 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS();
            this.batteryDrainNumShocks_ = val_4;
            val_3 = other.batteryDrainNumShocks_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        if(other.batteryDrainCloaked_ != 0f)
        {
                this.batteryDrainCloaked_ = other.batteryDrainCloaked_;
        }
        
        if(other.batteryDrainDecloaked_ != 0f)
        {
                this.batteryDrainDecloaked_ = other.batteryDrainDecloaked_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_42;
        label_46:
        if(8764 > 49)
        {
            goto label_2;
        }
        
        if(8764 > 25)
        {
            goto label_3;
        }
        
        if(8764 == 9)
        {
            goto label_4;
        }
        
        if(8764 == 17)
        {
            goto label_5;
        }
        
        if(8764 != 25)
        {
            goto label_22;
        }
        
        this.batteryDrainInvisible_ = input.ReadDouble();
        goto label_42;
        label_2:
        if(8764 > 73)
        {
            goto label_9;
        }
        
        if(8764 == 57)
        {
            goto label_10;
        }
        
        if(8764 == 65)
        {
            goto label_11;
        }
        
        if(8764 != 73)
        {
            goto label_22;
        }
        
        this.batteryDrainReposition_ = input.ReadDouble();
        goto label_42;
        label_3:
        if(8764 == 33)
        {
            goto label_15;
        }
        
        if(8764 == 41)
        {
            goto label_16;
        }
        
        if(8764 != 49)
        {
            goto label_22;
        }
        
        this.batteryDrainFizzlePreVisible_ = input.ReadDouble();
        goto label_42;
        label_9:
        if(8764 == 82)
        {
            goto label_20;
        }
        
        if(8764 == 89)
        {
            goto label_21;
        }
        
        if(8764 != 97)
        {
            goto label_22;
        }
        
        this.batteryDrainDecloaked_ = input.ReadDouble();
        goto label_42;
        label_22:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_42;
        label_5:
        this.batteryDrainFinalApproach_ = input.ReadDouble();
        goto label_42;
        label_11:
        this.batteryDrainShocked_ = input.ReadDouble();
        goto label_42;
        label_16:
        this.batteryDrainSpotted_ = input.ReadDouble();
        goto label_42;
        label_21:
        this.batteryDrainCloaked_ = input.ReadDouble();
        goto label_42;
        label_4:
        this.batteryDrainGeneral_ = input.ReadDouble();
        goto label_42;
        label_10:
        this.batteryDrainFizzleVisible_ = input.ReadDouble();
        goto label_42;
        label_15:
        this.batteryDrainUnspotted_ = input.ReadDouble();
        goto label_42;
        label_20:
        if(this.batteryDrainNumShocks_ == null)
        {
            goto label_40;
        }
        
        if(input != null)
        {
            goto label_43;
        }
        
        label_44:
        label_43:
        input.ReadMessage(builder:  this.batteryDrainNumShocks_);
        goto label_42;
        label_40:
        this.batteryDrainNumShocks_ = new ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.Types.BATTERYDRAINNUMSHOCKS();
        if(input != null)
        {
            goto label_43;
        }
        
        goto label_44;
        label_42:
        if(input.ReadTag() != 0)
        {
            goto label_46;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN()
    {
        null = null;
        ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.BatteryDrainDecloakedFieldNumber = new Google.Protobuf.MessageParser<BATTERYDRAIN>(factory:  new System.Func<BATTERYDRAIN>(object:  ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.<>c.<>9, method:  BATTERYDRAIN ANIMATRONIC_DATA.Types.BATTERY.Types.BATTERYDRAIN.<>c::<.cctor>b__81_0()));
    }

}
