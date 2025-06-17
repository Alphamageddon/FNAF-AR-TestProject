using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC : IMessage<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC>, IMessage, IEquatable<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC>, IDeepCloneable<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeSettingsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS fadeSettings_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DurationFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS duration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShaderSettingsFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS shaderSettings_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int IsPositionalFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isPositional_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EffectsFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS effects_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS FadeSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS Duration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS ShaderSettings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsPositional { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS Effects { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ADDITIVESTATIC>)STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC.EffectsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STATIC_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC(ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC other)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_6;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_7;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_8;
        if(other.fadeSettings_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.fadeSettings_ = other.fadeSettings_.Clone();
        val_6 = other.duration_;
        this.duration_ = val_6.Clone();
        val_7 = other.shaderSettings_;
        this.shaderSettings_ = val_7.Clone();
        this.isPositional_ = other.isPositional_;
        val_8 = other.effects_;
        this.effects_ = val_8.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC Clone()
    {
        return (ADDITIVESTATIC)new STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC(other:  this);
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
    public bool get_IsPositional()
    {
        return (bool)this.isPositional_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_IsPositional(bool value)
    {
        this.isPositional_ = value;
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
    public override bool Equals(object other)
    {
        ADDITIVESTATIC val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC other)
    {
        var val_7;
        if(other == null)
        {
            goto label_6;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.Object.Equals(objA:  this.fadeSettings_, objB:  other.fadeSettings_)) != false) && ((System.Object.Equals(objA:  this.duration_, objB:  other.duration_)) != false)) && ((System.Object.Equals(objA:  this.shaderSettings_, objB:  other.shaderSettings_)) != false))
        {
                var val_4 = (this.isPositional_ == true) ? 1 : 0;
            val_4 = val_4 ^ ((other.isPositional_ == true) ? 1 : 0);
            if((val_4 & 1) == 0)
        {
                if((System.Object.Equals(objA:  this.effects_, objB:  other.effects_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_6:
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
        var val_4;
        if(this.fadeSettings_ != null)
        {
                val_4 = this.fadeSettings_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.duration_ != null)
        {
                val_4 = this.duration_ ^ val_4;
        }
        
        if(this.shaderSettings_ != null)
        {
                val_4 = this.shaderSettings_ ^ val_4;
        }
        
        if(this.isPositional_ != false)
        {
                val_3 = 0;
            val_4 = 1.GetHashCode() ^ val_4;
        }
        
        if(this.effects_ != null)
        {
                val_4 = this.effects_ ^ val_4;
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
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_2;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_3;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_4;
        bool val_5;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_6;
        if(this.fadeSettings_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.fadeSettings_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.fadeSettings_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.duration_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.duration_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.duration_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.shaderSettings_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.shaderSettings_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.shaderSettings_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.isPositional_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  32);
            val_5 = this.isPositional_;
        }
        else
        {
                0.WriteRawTag(b1:  32);
            val_5 = this.isPositional_;
        }
        
            output.WriteBool(value:  (val_5 == true) ? 1 : 0);
        }
        
        if(this.effects_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_6 = this.effects_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_6 = this.effects_;
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
        var val_11;
        var val_12;
        if(this.fadeSettings_ != null)
        {
                val_11 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.fadeSettings_)) + 1;
        }
        else
        {
                val_11 = 0;
        }
        
        if(this.duration_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.duration_))) + 1;
        }
        
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_10 = this.shaderSettings_;
        if(val_10 != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_10))) + 1;
        }
        
        val_10 = (this.isPositional_ == true) ? (val_11 + 2) : (val_11);
        if(this.effects_ != null)
        {
                val_12 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.effects_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_12;
        }
        
        val_12 = this._unknownFields.CalculateSize() + val_12;
        return (int)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC other)
    {
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_6;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_7;
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_8;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9;
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_10;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_11;
        STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_12;
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_13;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.fadeSettings_;
        if(val_7 != null)
        {
                val_8 = this.fadeSettings_;
            if(val_8 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_1 = null;
            val_8 = val_1;
            val_1 = new STATIC_DATA.Types.ENTRY.Types.FADESETTINGS();
            this.fadeSettings_ = val_8;
            val_7 = other.fadeSettings_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.duration_;
        if(val_9 != null)
        {
                val_10 = this.duration_;
            if(val_10 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_2 = null;
            val_10 = val_2;
            val_2 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
            this.duration_ = val_10;
            val_9 = other.duration_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        val_11 = other.shaderSettings_;
        if(val_11 != null)
        {
                val_12 = this.shaderSettings_;
            if(val_12 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS val_3 = null;
            val_12 = val_3;
            val_3 = new STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS();
            this.shaderSettings_ = val_12;
            val_11 = other.shaderSettings_;
        }
        
            val_3.MergeFrom(other:  val_11);
        }
        
        if(other.isPositional_ != false)
        {
                this.isPositional_ = other.isPositional_;
        }
        
        val_6 = other.effects_;
        if(val_6 != null)
        {
                val_13 = this.effects_;
            if(val_13 == null)
        {
                STATIC_DATA.Types.ENTRY.Types.EFFECTS val_4 = null;
            val_13 = val_4;
            val_4 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
            this.effects_ = val_13;
            val_6 = other.effects_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_9;
        goto label_22;
        label_26:
        if(18 > 18)
        {
            goto label_2;
        }
        
        if(18 == 10)
        {
            goto label_3;
        }
        
        if(18 != 18)
        {
            goto label_10;
        }
        
        val_9 = this.duration_;
        if(val_9 != null)
        {
            goto label_15;
        }
        
        STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS val_1 = null;
        val_9 = val_1;
        val_1 = new STATIC_DATA.Types.ENTRY.Types.RANGESETTINGS();
        this.duration_ = val_9;
        if(input != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_2:
        if(18 == 26)
        {
            goto label_8;
        }
        
        if(18 == 32)
        {
            goto label_9;
        }
        
        if(18 != 42)
        {
            goto label_10;
        }
        
        val_9 = this.effects_;
        if(val_9 != null)
        {
            goto label_15;
        }
        
        STATIC_DATA.Types.ENTRY.Types.EFFECTS val_2 = null;
        val_9 = val_2;
        val_2 = new STATIC_DATA.Types.ENTRY.Types.EFFECTS();
        this.effects_ = val_9;
        if(input != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_22;
        label_3:
        val_9 = this.fadeSettings_;
        if(val_9 != null)
        {
            goto label_15;
        }
        
        STATIC_DATA.Types.ENTRY.Types.FADESETTINGS val_4 = null;
        val_9 = val_4;
        val_4 = new STATIC_DATA.Types.ENTRY.Types.FADESETTINGS();
        this.fadeSettings_ = val_9;
        if(input != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_9:
        this.isPositional_ = input.ReadBool();
        goto label_22;
        label_8:
        val_9 = this.shaderSettings_;
        if(val_9 == null)
        {
            goto label_20;
        }
        
        label_15:
        if(input != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        input.ReadMessage(builder:  val_9);
        goto label_22;
        label_20:
        this.shaderSettings_ = new STATIC_DATA.Types.ENTRY.Types.SHADERSETTINGS();
        if(input != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_22:
        if(input.ReadTag() != 0)
        {
            goto label_26;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC()
    {
        null = null;
        STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC.EffectsFieldNumber = new Google.Protobuf.MessageParser<ADDITIVESTATIC>(factory:  new System.Func<ADDITIVESTATIC>(object:  STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC.<>c.<>9, method:  ADDITIVESTATIC STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC.<>c::<.cctor>b__45_0()));
    }

}
