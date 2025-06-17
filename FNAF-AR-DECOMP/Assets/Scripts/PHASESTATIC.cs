using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.PHASESTATIC : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BaseAngleFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS baseAngle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BaseEffectsFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS baseEffects_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AngleFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS angle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EffectsFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS effects_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightAngleFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS flashlightAngle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightEffectsFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS flashlightEffects_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS BaseAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS BaseEffects { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS Angle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS Effects { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS FlashlightAngle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS FlashlightEffects { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHASESTATIC>)STATIC_DATA.Types.ENTRY.Types.PHASESTATIC.FlashlightEffectsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.PHASESTATIC.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.PHASESTATIC()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.PHASESTATIC(ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC other)
    {
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_8;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_10;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_11;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_12;
        if(other.baseAngle_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        this.baseAngle_ = other.baseAngle_.Clone();
        val_8 = other.baseEffects_;
        this.baseEffects_ = val_8.Clone();
        val_9 = other.angle_;
        this.angle_ = val_9.Clone();
        val_10 = other.effects_;
        this.effects_ = val_10.Clone();
        val_11 = other.flashlightAngle_;
        this.flashlightAngle_ = val_11.Clone();
        val_12 = other.flashlightEffects_;
        this.flashlightEffects_ = val_12.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC Clone()
    {
        return (PHASESTATIC)new STATIC_DATA.Types.ENTRY.Types.PHASESTATIC(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_BaseAngle()
    {
        return (RANGESETTINGS)this.baseAngle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BaseAngle(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.baseAngle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS get_BaseEffects()
    {
        return (EFFECTS)this.baseEffects_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BaseEffects(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS value)
    {
        this.baseEffects_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_Angle()
    {
        return (RANGESETTINGS)this.angle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Angle(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.angle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS get_Effects()
    {
        return (EFFECTS)this.effects_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Effects(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS value)
    {
        this.effects_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_FlashlightAngle()
    {
        return (RANGESETTINGS)this.flashlightAngle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightAngle(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.flashlightAngle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS get_FlashlightEffects()
    {
        return (EFFECTS)this.flashlightEffects_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightEffects(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS value)
    {
        this.flashlightEffects_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHASESTATIC val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC other)
    {
        var val_7;
        if(other == null)
        {
            goto label_7;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((((System.Object.Equals(objA:  this.baseAngle_, objB:  other.baseAngle_)) != false) && ((System.Object.Equals(objA:  this.baseEffects_, objB:  other.baseEffects_)) != false)) && ((System.Object.Equals(objA:  this.angle_, objB:  other.angle_)) != false)) && ((System.Object.Equals(objA:  this.effects_, objB:  other.effects_)) != false)) && ((System.Object.Equals(objA:  this.flashlightAngle_, objB:  other.flashlightAngle_)) != false))
        {
                if((System.Object.Equals(objA:  this.flashlightEffects_, objB:  other.flashlightEffects_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_7:
        val_7 = 0;
        return (bool)val_7;
        label_1:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.baseAngle_ != null)
        {
                val_3 = this.baseAngle_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.baseEffects_ != null)
        {
                val_3 = this.baseEffects_ ^ val_3;
        }
        
        if(this.angle_ != null)
        {
                val_3 = this.angle_ ^ val_3;
        }
        
        if(this.effects_ != null)
        {
                val_3 = this.effects_ ^ val_3;
        }
        
        if(this.flashlightAngle_ != null)
        {
                val_3 = this.flashlightAngle_ ^ val_3;
        }
        
        if(this.flashlightEffects_ != null)
        {
                val_3 = this.flashlightEffects_ ^ val_3;
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
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_2;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_4;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_5;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_6;
        if(this.baseAngle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.baseAngle_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.baseAngle_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.baseEffects_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.baseEffects_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.baseEffects_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.angle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.angle_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.angle_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.effects_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.effects_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.effects_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.flashlightAngle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.flashlightAngle_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.flashlightAngle_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.flashlightEffects_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.flashlightEffects_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.flashlightEffects_;
        }
        
            output.WriteMessage(value:  val_6);
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
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_13 = this.baseAngle_;
        if(val_13 != null)
        {
                val_13 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_13 = this.baseAngle_)) + 1;
        }
        
        if(this.baseEffects_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.baseEffects_))) + 1;
        }
        
        if(this.angle_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.angle_))) + 1;
        }
        
        if(this.effects_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.effects_))) + 1;
        }
        
        if(this.flashlightAngle_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightAngle_))) + 1;
        }
        
        if(this.flashlightEffects_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightEffects_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_13;
        }
        
        val_13 = this._unknownFields.CalculateSize() + val_13;
        return (int)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC other)
    {
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_8;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_10;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_11;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_12;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_13;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_14;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_15;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_16;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_17;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_18;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_19;
        if(other == null)
        {
                return;
        }
        
        val_9 = other.baseAngle_;
        if(val_9 != null)
        {
                val_10 = this.baseAngle_;
            if(val_10 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1 = null;
            val_10 = val_1;
            val_1 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.baseAngle_ = val_10;
            val_9 = other.baseAngle_;
        }
        
            val_1.MergeFrom(other:  val_9);
        }
        
        val_11 = other.baseEffects_;
        if(val_11 != null)
        {
                val_12 = this.baseEffects_;
            if(val_12 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.EFFECTS val_2 = null;
            val_12 = val_2;
            val_2 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
            this.baseEffects_ = val_12;
            val_11 = other.baseEffects_;
        }
        
            val_2.MergeFrom(other:  val_11);
        }
        
        val_13 = other.angle_;
        if(val_13 != null)
        {
                val_14 = this.angle_;
            if(val_14 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3 = null;
            val_14 = val_3;
            val_3 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.angle_ = val_14;
            val_13 = other.angle_;
        }
        
            val_3.MergeFrom(other:  val_13);
        }
        
        val_15 = other.effects_;
        if(val_15 != null)
        {
                val_16 = this.effects_;
            if(val_16 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.EFFECTS val_4 = null;
            val_16 = val_4;
            val_4 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
            this.effects_ = val_16;
            val_15 = other.effects_;
        }
        
            val_4.MergeFrom(other:  val_15);
        }
        
        val_17 = other.flashlightAngle_;
        if(val_17 != null)
        {
                val_18 = this.flashlightAngle_;
            if(val_18 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_5 = null;
            val_18 = val_5;
            val_5 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.flashlightAngle_ = val_18;
            val_17 = other.flashlightAngle_;
        }
        
            val_5.MergeFrom(other:  val_17);
        }
        
        val_8 = other.flashlightEffects_;
        if(val_8 != null)
        {
                val_19 = this.flashlightEffects_;
            if(val_19 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.EFFECTS val_6 = null;
            val_19 = val_6;
            val_6 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
            this.flashlightEffects_ = val_19;
            val_8 = other.flashlightEffects_;
        }
        
            val_6.MergeFrom(other:  val_8);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9;
        goto label_27;
        label_31:
        if(35333 > 26)
        {
            goto label_2;
        }
        
        if(35333 == 10)
        {
            goto label_3;
        }
        
        if(35333 == 18)
        {
            goto label_4;
        }
        
        if(35333 != 26)
        {
            goto label_11;
        }
        
        val_9 = this.angle_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1 = null;
        val_9 = val_1;
        val_1 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.angle_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_2:
        if(35333 == 34)
        {
            goto label_9;
        }
        
        if(35333 == 42)
        {
            goto label_10;
        }
        
        if(35333 != 50)
        {
            goto label_11;
        }
        
        val_9 = this.flashlightEffects_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_2 = null;
        val_9 = val_2;
        val_2 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
        this.flashlightEffects_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_11:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_27;
        label_4:
        val_9 = this.baseEffects_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_4 = null;
        val_9 = val_4;
        val_4 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
        this.baseEffects_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_10:
        val_9 = this.flashlightAngle_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_5 = null;
        val_9 = val_5;
        val_5 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.flashlightAngle_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_3:
        val_9 = this.baseAngle_;
        if(val_9 != null)
        {
            goto label_22;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_6 = null;
        val_9 = val_6;
        val_6 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.baseAngle_ = val_9;
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_9:
        val_9 = this.effects_;
        if(val_9 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(input != null)
        {
            goto label_28;
        }
        
        label_29:
        label_28:
        input.ReadMessage(builder:  val_9);
        goto label_27;
        label_25:
        this.effects_ = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
        if(input != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_27:
        if(input.ReadTag() != 0)
        {
            goto label_31;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STATIC_DATA.Types.ENTRY.Types.PHASESTATIC()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.PHASESTATIC.FlashlightEffectsFieldNumber = new Google.Protobuf.MessageParser<PHASESTATIC>(factory:  new System.Func<PHASESTATIC>(object:  STATIC_DATA.Types.ENTRY.Types.PHASESTATIC.<>c.<>9, method:  PHASESTATIC STATIC_DATA.Types.ENTRY.Types.PHASESTATIC.<>c::<.cctor>b__50_0()));
    }

}
