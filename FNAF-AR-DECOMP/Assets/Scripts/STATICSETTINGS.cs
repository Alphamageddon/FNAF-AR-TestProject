using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StartsActiveFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool startsActive_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AngleRangeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS angleRange_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DistanceRangeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS distanceRange_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CooldownFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS cooldown_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeSettingsFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS fadeSettings_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DurationFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS duration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShaderSettingsFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS shaderSettings_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightAdditiveFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC flashlightAdditive_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightAngleRangeFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS flashlightAngleRange_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool StartsActive { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS AngleRange { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS DistanceRange { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS Cooldown { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS FadeSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS Duration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS ShaderSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC FlashlightAdditive { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS FlashlightAngleRange { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<STATICSETTINGS>)STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS.FlashlightAngleRangeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[6];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS(ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS other)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_10;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_11;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_12;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_13;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_14;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_15;
        ADDITIVESTATIC val_16;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_17;
        if(other != null)
        {
                this.startsActive_ = other.startsActive_;
        }
        else
        {
                this.startsActive_ = false;
        }
        
        val_10 = other.angleRange_;
        this.angleRange_ = val_10.Clone();
        val_11 = other.distanceRange_;
        this.distanceRange_ = val_11.Clone();
        val_12 = other.cooldown_;
        this.cooldown_ = val_12.Clone();
        val_13 = other.fadeSettings_;
        this.fadeSettings_ = val_13.Clone();
        val_14 = other.duration_;
        this.duration_ = val_14.Clone();
        val_15 = other.shaderSettings_;
        this.shaderSettings_ = val_15.Clone();
        val_16 = other.flashlightAdditive_;
        this.flashlightAdditive_ = val_16.Clone();
        val_17 = other.flashlightAngleRange_;
        this.flashlightAngleRange_ = val_17.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS Clone()
    {
        return (STATICSETTINGS)new STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_StartsActive()
    {
        return (bool)this.startsActive_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StartsActive(bool value)
    {
        this.startsActive_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_AngleRange()
    {
        return (RANGESETTINGS)this.angleRange_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AngleRange(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.angleRange_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_DistanceRange()
    {
        return (RANGESETTINGS)this.distanceRange_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DistanceRange(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.distanceRange_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_Cooldown()
    {
        return (RANGESETTINGS)this.cooldown_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Cooldown(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.cooldown_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS get_FadeSettings()
    {
        return (FADESETTINGS)this.fadeSettings_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FadeSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS value)
    {
        this.fadeSettings_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_Duration()
    {
        return (RANGESETTINGS)this.duration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Duration(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.duration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS get_ShaderSettings()
    {
        return (SHADERSETTINGS)this.shaderSettings_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShaderSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS value)
    {
        this.shaderSettings_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC get_FlashlightAdditive()
    {
        return (ADDITIVESTATIC)this.flashlightAdditive_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightAdditive(ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC value)
    {
        this.flashlightAdditive_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS get_FlashlightAngleRange()
    {
        return (RANGESETTINGS)this.flashlightAngleRange_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightAngleRange(ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS value)
    {
        this.flashlightAngleRange_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        STATICSETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS other)
    {
        var val_11;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        var val_1 = (this.startsActive_ == true) ? 1 : 0;
        val_1 = val_1 ^ ((other.startsActive_ == true) ? 1 : 0);
        if(((((((((val_1 & 1) == 0) && ((System.Object.Equals(objA:  this.angleRange_, objB:  other.angleRange_)) != false)) && ((System.Object.Equals(objA:  this.distanceRange_, objB:  other.distanceRange_)) != false)) && ((System.Object.Equals(objA:  this.cooldown_, objB:  other.cooldown_)) != false)) && ((System.Object.Equals(objA:  this.fadeSettings_, objB:  other.fadeSettings_)) != false)) && ((System.Object.Equals(objA:  this.duration_, objB:  other.duration_)) != false)) && ((System.Object.Equals(objA:  this.shaderSettings_, objB:  other.shaderSettings_)) != false)) && ((System.Object.Equals(objA:  this.flashlightAdditive_, objB:  other.flashlightAdditive_)) != false))
        {
                if((System.Object.Equals(objA:  this.flashlightAngleRange_, objB:  other.flashlightAngleRange_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_11 = 0;
        return (bool)val_11;
        label_1:
        val_11 = 1;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        var val_3;
        val_2 = 1;
        if(this.startsActive_ != false)
        {
                val_3 = 0;
            val_2 = val_2.GetHashCode() ^ 1;
        }
        
        if(this.angleRange_ != null)
        {
                val_2 = this.angleRange_ ^ val_2;
        }
        
        if(this.distanceRange_ != null)
        {
                val_2 = this.distanceRange_ ^ val_2;
        }
        
        if(this.cooldown_ != null)
        {
                val_2 = this.cooldown_ ^ val_2;
        }
        
        if(this.fadeSettings_ != null)
        {
                val_2 = this.fadeSettings_ ^ val_2;
        }
        
        if(this.duration_ != null)
        {
                val_2 = this.duration_ ^ val_2;
        }
        
        if(this.shaderSettings_ != null)
        {
                val_2 = this.shaderSettings_ ^ val_2;
        }
        
        if(this.flashlightAdditive_ != null)
        {
                val_2 = this.flashlightAdditive_ ^ val_2;
        }
        
        if(this.flashlightAngleRange_ != null)
        {
                val_2 = this.flashlightAngleRange_ ^ val_2;
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
        bool val_2;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_4;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_5;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_6;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_7;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_8;
        ADDITIVESTATIC val_9;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_10;
        if(this.startsActive_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_2 = this.startsActive_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_2 = this.startsActive_;
        }
        
            output.WriteBool(value:  (val_2 == true) ? 1 : 0);
        }
        
        if(this.angleRange_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.angleRange_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.angleRange_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.distanceRange_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.distanceRange_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.distanceRange_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.cooldown_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_5 = this.cooldown_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_5 = this.cooldown_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.fadeSettings_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_6 = this.fadeSettings_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_6 = this.fadeSettings_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.duration_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_7 = this.duration_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_7 = this.duration_;
        }
        
            output.WriteMessage(value:  val_7);
        }
        
        if(this.shaderSettings_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_8 = this.shaderSettings_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_8 = this.shaderSettings_;
        }
        
            output.WriteMessage(value:  val_8);
        }
        
        if(this.flashlightAdditive_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_9 = this.flashlightAdditive_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_9 = this.flashlightAdditive_;
        }
        
            output.WriteMessage(value:  val_9);
        }
        
        if(this.flashlightAngleRange_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_10 = this.flashlightAngleRange_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_10 = this.flashlightAngleRange_;
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
        var val_19 = this.startsActive_ << 1;
        if(this.angleRange_ != null)
        {
                val_19 = (val_19 | 1) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.angleRange_));
        }
        
        if(this.distanceRange_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.distanceRange_))) + 1;
        }
        
        if(this.cooldown_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cooldown_))) + 1;
        }
        
        if(this.fadeSettings_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.fadeSettings_))) + 1;
        }
        
        if(this.duration_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.duration_))) + 1;
        }
        
        if(this.shaderSettings_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.shaderSettings_))) + 1;
        }
        
        if(this.flashlightAdditive_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightAdditive_))) + 1;
        }
        
        if(this.flashlightAngleRange_ != null)
        {
                val_19 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightAngleRange_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_19;
        }
        
        val_19 = this._unknownFields.CalculateSize() + val_19;
        return (int)val_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS other)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_10;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_11;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_12;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_13;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_14;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_15;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_16;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_17;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_18;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_19;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_20;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_21;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_22;
        ADDITIVESTATIC val_23;
        ADDITIVESTATIC val_24;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_25;
        if(other == null)
        {
                return;
        }
        
        if(other.startsActive_ != false)
        {
                this.startsActive_ = other.startsActive_;
        }
        
        val_11 = other.angleRange_;
        if(val_11 != null)
        {
                val_12 = this.angleRange_;
            if(val_12 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1 = null;
            val_12 = val_1;
            val_1 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.angleRange_ = val_12;
            val_11 = other.angleRange_;
        }
        
            val_1.MergeFrom(other:  val_11);
        }
        
        val_13 = other.distanceRange_;
        if(val_13 != null)
        {
                val_14 = this.distanceRange_;
            if(val_14 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_2 = null;
            val_14 = val_2;
            val_2 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.distanceRange_ = val_14;
            val_13 = other.distanceRange_;
        }
        
            val_2.MergeFrom(other:  val_13);
        }
        
        val_15 = other.cooldown_;
        if(val_15 != null)
        {
                val_16 = this.cooldown_;
            if(val_16 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3 = null;
            val_16 = val_3;
            val_3 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.cooldown_ = val_16;
            val_15 = other.cooldown_;
        }
        
            val_3.MergeFrom(other:  val_15);
        }
        
        val_17 = other.fadeSettings_;
        if(val_17 != null)
        {
                val_18 = this.fadeSettings_;
            if(val_18 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_4 = null;
            val_18 = val_4;
            val_4 = new STATIC_DATA.Types.ENTRY.Types.FADESETTINGS();
            this.fadeSettings_ = val_18;
            val_17 = other.fadeSettings_;
        }
        
            val_4.MergeFrom(other:  val_17);
        }
        
        val_19 = other.duration_;
        if(val_19 != null)
        {
                val_20 = this.duration_;
            if(val_20 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_5 = null;
            val_20 = val_5;
            val_5 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.duration_ = val_20;
            val_19 = other.duration_;
        }
        
            val_5.MergeFrom(other:  val_19);
        }
        
        val_21 = other.shaderSettings_;
        if(val_21 != null)
        {
                val_22 = this.shaderSettings_;
            if(val_22 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_6 = null;
            val_22 = val_6;
            val_6 = new STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS();
            this.shaderSettings_ = val_22;
            val_21 = other.shaderSettings_;
        }
        
            val_6.MergeFrom(other:  val_21);
        }
        
        val_23 = other.flashlightAdditive_;
        if(val_23 != null)
        {
                val_24 = this.flashlightAdditive_;
            if(val_24 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC val_7 = null;
            val_24 = val_7;
            val_7 = new STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC();
            this.flashlightAdditive_ = val_24;
            val_23 = other.flashlightAdditive_;
        }
        
            val_7.MergeFrom(other:  val_23);
        }
        
        val_10 = other.flashlightAngleRange_;
        if(val_10 != null)
        {
                val_25 = this.flashlightAngleRange_;
            if(val_25 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_8 = null;
            val_25 = val_8;
            val_8 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.flashlightAngleRange_ = val_25;
            val_10 = other.flashlightAngleRange_;
        }
        
            val_8.MergeFrom(other:  val_10);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_13;
        goto label_40;
        label_44:
        if(42072 > 34)
        {
            goto label_2;
        }
        
        if(42072 > 18)
        {
            goto label_3;
        }
        
        if(42072 == 8)
        {
            goto label_4;
        }
        
        if(42072 != 18)
        {
            goto label_22;
        }
        
        val_13 = this.angleRange_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1 = null;
        val_13 = val_1;
        val_1 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.angleRange_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_2:
        if(42072 > 50)
        {
            goto label_9;
        }
        
        if(42072 == 42)
        {
            goto label_10;
        }
        
        if(42072 != 50)
        {
            goto label_22;
        }
        
        val_13 = this.duration_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_2 = null;
        val_13 = val_2;
        val_2 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.duration_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_3:
        if(42072 == 26)
        {
            goto label_15;
        }
        
        if(42072 != 34)
        {
            goto label_22;
        }
        
        val_13 = this.cooldown_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3 = null;
        val_13 = val_3;
        val_3 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.cooldown_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_9:
        if(42072 == 58)
        {
            goto label_20;
        }
        
        if(42072 == 66)
        {
            goto label_21;
        }
        
        if(42072 != 74)
        {
            goto label_22;
        }
        
        val_13 = this.flashlightAngleRange_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_4 = null;
        val_13 = val_4;
        val_4 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.flashlightAngleRange_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_22:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_40;
        label_4:
        this.startsActive_ = input.ReadBool();
        goto label_40;
        label_10:
        val_13 = this.fadeSettings_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_8 = null;
        val_13 = val_8;
        val_8 = new STATIC_DATA.Types.ENTRY.Types.FADESETTINGS();
        this.fadeSettings_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_15:
        val_13 = this.distanceRange_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9 = null;
        val_13 = val_9;
        val_9 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.distanceRange_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_21:
        val_13 = this.flashlightAdditive_;
        if(val_13 != null)
        {
            goto label_35;
        }
        
        STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC val_10 = null;
        val_13 = val_10;
        val_10 = new STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC();
        this.flashlightAdditive_ = val_13;
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_20:
        val_13 = this.shaderSettings_;
        if(val_13 == null)
        {
            goto label_38;
        }
        
        label_35:
        if(input != null)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        input.ReadMessage(builder:  val_13);
        goto label_40;
        label_38:
        this.shaderSettings_ = new STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS();
        if(input != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_40:
        if(input.ReadTag() != 0)
        {
            goto label_44;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS.FlashlightAngleRangeFieldNumber = new Google.Protobuf.MessageParser<STATICSETTINGS>(factory:  new System.Func<STATICSETTINGS>(object:  STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS.<>c.<>9, method:  STATICSETTINGS STATIC_DATA.Types.ENTRY.Types.STATICSETTINGS.<>c::<.cctor>b__65_0()));
    }

}
