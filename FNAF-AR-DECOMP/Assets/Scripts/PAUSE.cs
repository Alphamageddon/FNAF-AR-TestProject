using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.PAUSE : IMessage<ProtoData.ATTACK_DATA.Types.PAUSE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.PAUSE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.PAUSE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PAUSE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NextPhaseFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE nextPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UseGlimpseFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool useGlimpse_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PAUSE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE NextPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseGlimpse { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PAUSE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PAUSE>)ATTACK_DATA.Types.PAUSE.UseGlimpseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.PAUSE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PAUSE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PAUSE(ProtoData.ATTACK_DATA.Types.PAUSE other)
    {
        NEXTPHASE val_4;
        if(other.seconds_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.seconds_ = other.seconds_.Clone();
        val_4 = other.nextPhase_;
        this.nextPhase_ = val_4.Clone();
        this.useGlimpse_ = other.useGlimpse_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.PAUSE Clone()
    {
        return (PAUSE)new ATTACK_DATA.Types.PAUSE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Seconds()
    {
        return (RANGE)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE get_NextPhase()
    {
        return (NEXTPHASE)this.nextPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NextPhase(ProtoData.ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE value)
    {
        this.nextPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_UseGlimpse()
    {
        return (bool)this.useGlimpse_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UseGlimpse(bool value)
    {
        this.useGlimpse_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PAUSE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.PAUSE other)
    {
        var val_5;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false)
        {
                if((System.Object.Equals(objA:  this.nextPhase_, objB:  other.nextPhase_)) != false)
        {
                var val_3 = (this.useGlimpse_ == true) ? 1 : 0;
            val_3 = val_3 ^ ((other.useGlimpse_ == true) ? 1 : 0);
            if((val_3 & 1) == 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.seconds_ != null)
        {
                val_4 = this.seconds_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.nextPhase_ != null)
        {
                val_4 = this.nextPhase_ ^ val_4;
        }
        
        if(this.useGlimpse_ != false)
        {
                val_3 = 0;
            val_4 = 1.GetHashCode() ^ val_4;
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
        ATTACK_DATA.Types.RANGE val_2;
        NEXTPHASE val_3;
        bool val_4;
        if(this.seconds_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.seconds_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.nextPhase_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.nextPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.nextPhase_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.useGlimpse_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  24);
            val_4 = this.useGlimpse_;
        }
        else
        {
                0.WriteRawTag(b1:  24);
            val_4 = this.useGlimpse_;
        }
        
            output.WriteBool(value:  (val_4 == true) ? 1 : 0);
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
        var val_8;
        var val_9;
        if(this.seconds_ != null)
        {
                val_8 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.seconds_)) + 1;
        }
        else
        {
                val_8 = 0;
        }
        
        if(this.nextPhase_ != null)
        {
                val_8 = (val_8 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.nextPhase_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + ((this.useGlimpse_ == true) ? (val_8 + 2) : (val_8));
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.PAUSE other)
    {
        NEXTPHASE val_4;
        ATTACK_DATA.Types.RANGE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        NEXTPHASE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.seconds_;
        if(val_5 != null)
        {
                val_6 = this.seconds_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.seconds_ = val_6;
            val_5 = other.seconds_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.nextPhase_;
        if(val_4 != null)
        {
                val_7 = this.nextPhase_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE();
            this.nextPhase_ = val_7;
            val_4 = other.nextPhase_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        if(other.useGlimpse_ != false)
        {
                this.useGlimpse_ = other.useGlimpse_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        NEXTPHASE val_7;
        goto label_17;
        label_18:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_17;
        label_15:
        ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE val_2 = null;
        val_7 = val_2;
        val_2 = new ATTACK_DATA.Types.PAUSE.Types.NEXTPHASE();
        this.nextPhase_ = val_7;
        if(input != null)
        {
            goto label_16;
        }
        
        goto label_14;
        label_17:
        uint val_3 = input.ReadTag();
        if(val_3 <= 17)
        {
            goto label_6;
        }
        
        if(val_3 == 18)
        {
            goto label_7;
        }
        
        if(val_3 != 24)
        {
            goto label_18;
        }
        
        this.useGlimpse_ = input.ReadBool();
        goto label_17;
        label_6:
        if(val_3 != 10)
        {
            goto label_11;
        }
        
        val_7 = this.seconds_;
        if(val_7 != null)
        {
            goto label_12;
        }
        
        ATTACK_DATA.Types.RANGE val_6 = null;
        val_7 = val_6;
        val_6 = new ATTACK_DATA.Types.RANGE();
        this.seconds_ = val_7;
        if(input != null)
        {
            goto label_16;
        }
        
        goto label_14;
        label_7:
        val_7 = this.nextPhase_;
        if(val_7 == null)
        {
            goto label_15;
        }
        
        label_12:
        if(input != null)
        {
            goto label_16;
        }
        
        label_14:
        label_16:
        input.ReadMessage(builder:  val_7);
        goto label_17;
        label_11:
        if(val_3 != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.PAUSE()
    {
        null = null;
        ATTACK_DATA.Types.PAUSE.UseGlimpseFieldNumber = new Google.Protobuf.MessageParser<PAUSE>(factory:  new System.Func<PAUSE>(object:  ATTACK_DATA.Types.PAUSE.<>c.<>9, method:  PAUSE ATTACK_DATA.Types.PAUSE.<>c::<.cctor>b__36_0()));
    }

}
