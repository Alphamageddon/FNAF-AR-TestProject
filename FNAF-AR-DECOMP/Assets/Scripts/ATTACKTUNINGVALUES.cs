using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnDistanceFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE spawnDistance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CircleParametersFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS circleParameters_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseParametersFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS pauseParameters_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChargeParametersFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS chargeParameters_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockWindowFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW shockWindow_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int InitialPauseParametersFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE initialPauseParameters_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WaitForCameraTimeFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double waitForCameraTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnAngleFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE spawnAngle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywireParametersFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS haywireParameters_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DisruptionParametersFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS disruptionParameters_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE SpawnDistance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS CircleParameters { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS PauseParameters { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS ChargeParameters { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW ShockWindow { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE InitialPauseParameters { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double WaitForCameraTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE SpawnAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS HaywireParameters { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS DisruptionParameters { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ATTACKTUNINGVALUES>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.DisruptionParametersFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[16];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES other)
    {
        CIRCLEPARAMETERS val_11;
        PAUSEPARAMETERS val_12;
        CHARGEPARAMETERS val_13;
        SHOCKWINDOW val_14;
        INITIALPAUSE val_15;
        SPAWNANGLE val_16;
        HAYWIREPARAMETERS val_17;
        DISRUPTIONPARAMETERS val_18;
        if(other.spawnDistance_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        this.spawnDistance_ = other.spawnDistance_.Clone();
        val_11 = other.circleParameters_;
        this.circleParameters_ = val_11.Clone();
        val_12 = other.pauseParameters_;
        this.pauseParameters_ = val_12.Clone();
        val_13 = other.chargeParameters_;
        this.chargeParameters_ = val_13.Clone();
        val_14 = other.shockWindow_;
        this.shockWindow_ = val_14.Clone();
        val_15 = other.initialPauseParameters_;
        this.initialPauseParameters_ = val_15.Clone();
        this.waitForCameraTime_ = other.waitForCameraTime_;
        val_16 = other.spawnAngle_;
        this.spawnAngle_ = val_16.Clone();
        val_17 = other.haywireParameters_;
        this.haywireParameters_ = val_17.Clone();
        val_18 = other.disruptionParameters_;
        this.disruptionParameters_ = val_18.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES Clone()
    {
        return (ATTACKTUNINGVALUES)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE get_SpawnDistance()
    {
        return (SPAWNDISTANCE)this.spawnDistance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnDistance(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE value)
    {
        this.spawnDistance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS get_CircleParameters()
    {
        return (CIRCLEPARAMETERS)this.circleParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CircleParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS value)
    {
        this.circleParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS get_PauseParameters()
    {
        return (PAUSEPARAMETERS)this.pauseParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PauseParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS value)
    {
        this.pauseParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS get_ChargeParameters()
    {
        return (CHARGEPARAMETERS)this.chargeParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChargeParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS value)
    {
        this.chargeParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW get_ShockWindow()
    {
        return (SHOCKWINDOW)this.shockWindow_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShockWindow(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW value)
    {
        this.shockWindow_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE get_InitialPauseParameters()
    {
        return (INITIALPAUSE)this.initialPauseParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_InitialPauseParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE value)
    {
        this.initialPauseParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_WaitForCameraTime()
    {
        return (double)this.waitForCameraTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WaitForCameraTime(double value)
    {
        this.waitForCameraTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE get_SpawnAngle()
    {
        return (SPAWNANGLE)this.spawnAngle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnAngle(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE value)
    {
        this.spawnAngle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS get_HaywireParameters()
    {
        return (HAYWIREPARAMETERS)this.haywireParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HaywireParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS value)
    {
        this.haywireParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS get_DisruptionParameters()
    {
        return (DISRUPTIONPARAMETERS)this.disruptionParameters_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DisruptionParameters(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS value)
    {
        this.disruptionParameters_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ATTACKTUNINGVALUES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES other)
    {
        var val_11;
        if(other == null)
        {
            goto label_15;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((((((((System.Object.Equals(objA:  this.spawnDistance_, objB:  other.spawnDistance_)) != false) && ((System.Object.Equals(objA:  this.circleParameters_, objB:  other.circleParameters_)) != false)) && ((System.Object.Equals(objA:  this.pauseParameters_, objB:  other.pauseParameters_)) != false)) && ((System.Object.Equals(objA:  this.chargeParameters_, objB:  other.chargeParameters_)) != false)) && ((System.Object.Equals(objA:  this.shockWindow_, objB:  other.shockWindow_)) != false)) && ((System.Object.Equals(objA:  this.initialPauseParameters_, objB:  other.initialPauseParameters_)) != false)) && ((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)) && ((System.Object.Equals(objA:  this.spawnAngle_, objB:  other.spawnAngle_)) != false)) && ((System.Object.Equals(objA:  this.haywireParameters_, objB:  other.haywireParameters_)) != false))
        {
                if((System.Object.Equals(objA:  this.disruptionParameters_, objB:  other.disruptionParameters_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_15:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        val_11 = 1;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.spawnDistance_ != null)
        {
                val_4 = this.spawnDistance_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.circleParameters_ != null)
        {
                val_4 = this.circleParameters_ ^ val_4;
        }
        
        if(this.pauseParameters_ != null)
        {
                val_4 = this.pauseParameters_ ^ val_4;
        }
        
        if(this.chargeParameters_ != null)
        {
                val_4 = this.chargeParameters_ ^ val_4;
        }
        
        if(this.shockWindow_ != null)
        {
                val_4 = this.shockWindow_ ^ val_4;
        }
        
        if(this.initialPauseParameters_ != null)
        {
                val_4 = this.initialPauseParameters_ ^ val_4;
        }
        
        if(this.waitForCameraTime_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.spawnAngle_ != null)
        {
                val_4 = this.spawnAngle_ ^ val_4;
        }
        
        if(this.haywireParameters_ != null)
        {
                val_4 = this.haywireParameters_ ^ val_4;
        }
        
        if(this.disruptionParameters_ != null)
        {
                val_4 = this.disruptionParameters_ ^ val_4;
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
        SPAWNDISTANCE val_1;
        CIRCLEPARAMETERS val_2;
        PAUSEPARAMETERS val_3;
        CHARGEPARAMETERS val_4;
        SHOCKWINDOW val_5;
        INITIALPAUSE val_6;
        double val_7;
        SPAWNANGLE val_8;
        HAYWIREPARAMETERS val_9;
        DISRUPTIONPARAMETERS val_10;
        if(this.spawnDistance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.spawnDistance_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.spawnDistance_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.circleParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.circleParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.circleParameters_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.pauseParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.pauseParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.pauseParameters_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.chargeParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.chargeParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.chargeParameters_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.shockWindow_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.shockWindow_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.shockWindow_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.initialPauseParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.initialPauseParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.initialPauseParameters_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.waitForCameraTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  57);
            val_7 = this.waitForCameraTime_;
        }
        else
        {
                0.WriteRawTag(b1:  57);
            val_7 = this.waitForCameraTime_;
        }
        
            output.WriteDouble(value:  val_7);
        }
        
        if(this.spawnAngle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_8 = this.spawnAngle_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_8 = this.spawnAngle_;
        }
        
            output.WriteMessage(value:  val_8);
        }
        
        if(this.haywireParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_9 = this.haywireParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_9 = this.haywireParameters_;
        }
        
            output.WriteMessage(value:  val_9);
        }
        
        if(this.disruptionParameters_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  82);
            val_10 = this.disruptionParameters_;
        }
        else
        {
                0.WriteRawTag(b1:  82);
            val_10 = this.disruptionParameters_;
        }
        
            output.WriteMessage(value:  val_10);
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
        Google.Protobuf.IMessage val_20;
        var val_21;
        var val_22;
        val_20 = 783;
        if(this.spawnDistance_ != null)
        {
                val_20 = this.spawnDistance_;
            val_21 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20)) + 1;
        }
        else
        {
                val_21 = 0;
        }
        
        if(this.circleParameters_ != null)
        {
                val_20 = this.circleParameters_;
            val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20))) + 1;
        }
        
        if(this.pauseParameters_ != null)
        {
                val_20 = this.pauseParameters_;
            val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20))) + 1;
        }
        
        if(this.chargeParameters_ != null)
        {
                val_20 = this.chargeParameters_;
            val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20))) + 1;
        }
        
        if(this.shockWindow_ != null)
        {
                val_20 = this.shockWindow_;
            val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20))) + 1;
        }
        
        INITIALPAUSE val_19 = this.initialPauseParameters_;
        if(val_19 != null)
        {
                val_20 = val_19;
            int val_11 = val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_20));
            val_21 = val_11 + 1;
        }
        
        val_11 = val_21 + 9;
        val_19 = (this.waitForCameraTime_ == 0f) ? (val_21) : (val_11);
        if(this.spawnAngle_ != null)
        {
                val_22 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.spawnAngle_))) + 1;
        }
        
        if(this.haywireParameters_ != null)
        {
                val_22 = (val_22 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.haywireParameters_))) + 1;
        }
        
        if(this.disruptionParameters_ != null)
        {
                val_22 = (val_22 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.disruptionParameters_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_22;
        }
        
        val_22 = this._unknownFields.CalculateSize() + val_22;
        return (int)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES other)
    {
        DISRUPTIONPARAMETERS val_11;
        SPAWNDISTANCE val_12;
        SPAWNDISTANCE val_13;
        CIRCLEPARAMETERS val_14;
        CIRCLEPARAMETERS val_15;
        PAUSEPARAMETERS val_16;
        PAUSEPARAMETERS val_17;
        CHARGEPARAMETERS val_18;
        CHARGEPARAMETERS val_19;
        SHOCKWINDOW val_20;
        SHOCKWINDOW val_21;
        INITIALPAUSE val_22;
        INITIALPAUSE val_23;
        SPAWNANGLE val_24;
        SPAWNANGLE val_25;
        HAYWIREPARAMETERS val_26;
        HAYWIREPARAMETERS val_27;
        DISRUPTIONPARAMETERS val_28;
        if(other == null)
        {
                return;
        }
        
        val_12 = other.spawnDistance_;
        if(val_12 != null)
        {
                val_13 = this.spawnDistance_;
            if(val_13 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE val_1 = null;
            val_13 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE();
            this.spawnDistance_ = val_13;
            val_12 = other.spawnDistance_;
        }
        
            val_1.MergeFrom(other:  val_12);
        }
        
        val_14 = other.circleParameters_;
        if(val_14 != null)
        {
                val_15 = this.circleParameters_;
            if(val_15 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS val_2 = null;
            val_15 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS();
            this.circleParameters_ = val_15;
            val_14 = other.circleParameters_;
        }
        
            val_2.MergeFrom(other:  val_14);
        }
        
        val_16 = other.pauseParameters_;
        if(val_16 != null)
        {
                val_17 = this.pauseParameters_;
            if(val_17 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS val_3 = null;
            val_17 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS();
            this.pauseParameters_ = val_17;
            val_16 = other.pauseParameters_;
        }
        
            val_3.MergeFrom(other:  val_16);
        }
        
        val_18 = other.chargeParameters_;
        if(val_18 != null)
        {
                val_19 = this.chargeParameters_;
            if(val_19 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS val_4 = null;
            val_19 = val_4;
            val_4 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS();
            this.chargeParameters_ = val_19;
            val_18 = other.chargeParameters_;
        }
        
            val_4.MergeFrom(other:  val_18);
        }
        
        val_20 = other.shockWindow_;
        if(val_20 != null)
        {
                val_21 = this.shockWindow_;
            if(val_21 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW val_5 = null;
            val_21 = val_5;
            val_5 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW();
            this.shockWindow_ = val_21;
            val_20 = other.shockWindow_;
        }
        
            val_5.MergeFrom(other:  val_20);
        }
        
        val_22 = other.initialPauseParameters_;
        if(val_22 != null)
        {
                val_23 = this.initialPauseParameters_;
            if(val_23 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE val_6 = null;
            val_23 = val_6;
            val_6 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE();
            this.initialPauseParameters_ = val_23;
            val_22 = other.initialPauseParameters_;
        }
        
            val_6.MergeFrom(other:  val_22);
        }
        
        if(other.waitForCameraTime_ != 0f)
        {
                this.waitForCameraTime_ = other.waitForCameraTime_;
        }
        
        val_24 = other.spawnAngle_;
        if(val_24 != null)
        {
                val_25 = this.spawnAngle_;
            if(val_25 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE val_7 = null;
            val_25 = val_7;
            val_7 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE();
            this.spawnAngle_ = val_25;
            val_24 = other.spawnAngle_;
        }
        
            val_7.MergeFrom(other:  val_24);
        }
        
        val_26 = other.haywireParameters_;
        if(val_26 != null)
        {
                val_27 = this.haywireParameters_;
            if(val_27 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS val_8 = null;
            val_27 = val_8;
            val_8 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS();
            this.haywireParameters_ = val_27;
            val_26 = other.haywireParameters_;
        }
        
            val_8.MergeFrom(other:  val_26);
        }
        
        val_11 = other.disruptionParameters_;
        if(val_11 != null)
        {
                val_28 = this.disruptionParameters_;
            if(val_28 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS val_9 = null;
            val_28 = val_9;
            val_9 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS();
            this.disruptionParameters_ = val_28;
            val_11 = other.disruptionParameters_;
        }
        
            val_9.MergeFrom(other:  val_11);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        CIRCLEPARAMETERS val_13;
        goto label_44;
        label_48:
        if(788 > 42)
        {
            goto label_2;
        }
        
        if(788 > 18)
        {
            goto label_3;
        }
        
        if(788 == 10)
        {
            goto label_4;
        }
        
        if(788 != 18)
        {
            goto label_22;
        }
        
        val_13 = this.circleParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS val_1 = null;
        val_13 = val_1;
        val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS();
        this.circleParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_2:
        if(788 > 57)
        {
            goto label_9;
        }
        
        if(788 == 50)
        {
            goto label_10;
        }
        
        if(788 != 57)
        {
            goto label_22;
        }
        
        this.waitForCameraTime_ = input.ReadDouble();
        goto label_44;
        label_3:
        if(788 == 26)
        {
            goto label_14;
        }
        
        if(788 == 34)
        {
            goto label_15;
        }
        
        if(788 != 42)
        {
            goto label_22;
        }
        
        val_13 = this.shockWindow_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW val_3 = null;
        val_13 = val_3;
        val_3 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SHOCKWINDOW();
        this.shockWindow_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_9:
        if(788 == 66)
        {
            goto label_20;
        }
        
        if(788 == 74)
        {
            goto label_21;
        }
        
        if(788 != 82)
        {
            goto label_22;
        }
        
        val_13 = this.disruptionParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS val_4 = null;
        val_13 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.DISRUPTIONPARAMETERS();
        this.disruptionParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_22:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_44;
        label_4:
        val_13 = this.spawnDistance_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE val_6 = null;
        val_13 = val_6;
        val_6 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNDISTANCE();
        this.spawnDistance_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_10:
        val_13 = this.initialPauseParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE val_7 = null;
        val_13 = val_7;
        val_7 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE();
        this.initialPauseParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_15:
        val_13 = this.chargeParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS val_8 = null;
        val_13 = val_8;
        val_8 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CHARGEPARAMETERS();
        this.chargeParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_21:
        val_13 = this.haywireParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS val_9 = null;
        val_13 = val_9;
        val_9 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.HAYWIREPARAMETERS();
        this.haywireParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_14:
        val_13 = this.pauseParameters_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS val_10 = null;
        val_13 = val_10;
        val_10 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS();
        this.pauseParameters_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_20:
        val_13 = this.spawnAngle_;
        if(val_13 == null)
        {
            goto label_42;
        }
        
        label_39:
        if(input != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        input.ReadMessage(builder:  val_13);
        goto label_44;
        label_42:
        this.spawnAngle_ = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.SPAWNANGLE();
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        if(input.ReadTag() != 0)
        {
            goto label_48;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.DisruptionParametersFieldNumber = new Google.Protobuf.MessageParser<ATTACKTUNINGVALUES>(factory:  new System.Func<ATTACKTUNINGVALUES>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.<>c.<>9, method:  ATTACKTUNINGVALUES ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.<>c::<.cctor>b__71_0()));
    }

}
