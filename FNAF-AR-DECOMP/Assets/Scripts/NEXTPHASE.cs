using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE : IMessage<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CircleFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE circle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int JumpscareFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE jumpscare_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PauseFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CHANCE pause_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ForceCircleAfterPauseFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool forceCircleAfterPause_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE Circle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE Jumpscare { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE Pause { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ForceCircleAfterPause { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<NEXTPHASE>)ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.ForceCircleAfterPauseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.CHARGE.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE(ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE other)
    {
        ATTACK_DATA.Types.CHANCE val_5;
        ATTACK_DATA.Types.CHANCE val_6;
        if(other.circle_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.circle_ = other.circle_.Clone();
        val_5 = other.jumpscare_;
        this.jumpscare_ = val_5.Clone();
        val_6 = other.pause_;
        this.pause_ = val_6.Clone();
        this.forceCircleAfterPause_ = other.forceCircleAfterPause_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE Clone()
    {
        return (NEXTPHASE)new ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_Circle()
    {
        return (CHANCE)this.circle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Circle(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.circle_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_Jumpscare()
    {
        return (CHANCE)this.jumpscare_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Jumpscare(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.jumpscare_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CHANCE get_Pause()
    {
        return (CHANCE)this.pause_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Pause(ProtoData.ATTACK_DATA.Types.CHANCE value)
    {
        this.pause_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ForceCircleAfterPause()
    {
        return (bool)this.forceCircleAfterPause_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ForceCircleAfterPause(bool value)
    {
        this.forceCircleAfterPause_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        NEXTPHASE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE other)
    {
        var val_6;
        if(other == null)
        {
            goto label_4;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((System.Object.Equals(objA:  this.circle_, objB:  other.circle_)) != false) && ((System.Object.Equals(objA:  this.jumpscare_, objB:  other.jumpscare_)) != false))
        {
                if((System.Object.Equals(objA:  this.pause_, objB:  other.pause_)) != false)
        {
                var val_4 = (this.forceCircleAfterPause_ == true) ? 1 : 0;
            val_4 = val_4 ^ ((other.forceCircleAfterPause_ == true) ? 1 : 0);
            if((val_4 & 1) == 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_4:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.circle_ != null)
        {
                val_4 = this.circle_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.jumpscare_ != null)
        {
                val_4 = this.jumpscare_ ^ val_4;
        }
        
        if(this.pause_ != null)
        {
                val_4 = this.pause_ ^ val_4;
        }
        
        if(this.forceCircleAfterPause_ != false)
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
        ATTACK_DATA.Types.CHANCE val_2;
        ATTACK_DATA.Types.CHANCE val_3;
        ATTACK_DATA.Types.CHANCE val_4;
        bool val_5;
        if(this.circle_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.circle_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.circle_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.jumpscare_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.jumpscare_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.jumpscare_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.pause_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.pause_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.pause_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.forceCircleAfterPause_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  32);
            val_5 = this.forceCircleAfterPause_;
        }
        else
        {
                0.WriteRawTag(b1:  32);
            val_5 = this.forceCircleAfterPause_;
        }
        
            output.WriteBool(value:  (val_5 == true) ? 1 : 0);
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
        var val_10;
        var val_11;
        if(this.circle_ != null)
        {
                val_10 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.circle_)) + 1;
        }
        else
        {
                val_10 = 0;
        }
        
        if(this.jumpscare_ != null)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.jumpscare_))) + 1;
        }
        
        if(this.pause_ != null)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.pause_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields.CalculateSize() + ((this.forceCircleAfterPause_ == true) ? (val_10 + 2) : (val_10));
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE other)
    {
        ATTACK_DATA.Types.CHANCE val_5;
        ATTACK_DATA.Types.CHANCE val_6;
        ATTACK_DATA.Types.CHANCE val_7;
        ATTACK_DATA.Types.CHANCE val_8;
        ATTACK_DATA.Types.CHANCE val_9;
        ATTACK_DATA.Types.CHANCE val_10;
        if(other == null)
        {
                return;
        }
        
        val_6 = other.circle_;
        if(val_6 != null)
        {
                val_7 = this.circle_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.CHANCE val_1 = null;
            val_7 = val_1;
            val_1 = new ATTACK_DATA.Types.CHANCE();
            this.circle_ = val_7;
            val_6 = other.circle_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        val_8 = other.jumpscare_;
        if(val_8 != null)
        {
                val_9 = this.jumpscare_;
            if(val_9 == null)
        {
                ATTACK_DATA.Types.CHANCE val_2 = null;
            val_9 = val_2;
            val_2 = new ATTACK_DATA.Types.CHANCE();
            this.jumpscare_ = val_9;
            val_8 = other.jumpscare_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        val_5 = other.pause_;
        if(val_5 != null)
        {
                val_10 = this.pause_;
            if(val_10 == null)
        {
                ATTACK_DATA.Types.CHANCE val_3 = null;
            val_10 = val_3;
            val_3 = new ATTACK_DATA.Types.CHANCE();
            this.pause_ = val_10;
            val_5 = other.pause_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        if(other.forceCircleAfterPause_ != false)
        {
                this.forceCircleAfterPause_ = other.forceCircleAfterPause_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.CHANCE val_8;
        goto label_18;
        label_22:
        if(33625 > 18)
        {
            goto label_2;
        }
        
        if(33625 == 10)
        {
            goto label_3;
        }
        
        if(33625 != 18)
        {
            goto label_9;
        }
        
        val_8 = this.jumpscare_;
        if(val_8 != null)
        {
            goto label_13;
        }
        
        ATTACK_DATA.Types.CHANCE val_1 = null;
        val_8 = val_1;
        val_1 = new ATTACK_DATA.Types.CHANCE();
        this.jumpscare_ = val_8;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        if(33625 == 26)
        {
            goto label_8;
        }
        
        if(33625 != 32)
        {
            goto label_9;
        }
        
        this.forceCircleAfterPause_ = input.ReadBool();
        goto label_18;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        val_8 = this.circle_;
        if(val_8 != null)
        {
            goto label_13;
        }
        
        ATTACK_DATA.Types.CHANCE val_5 = null;
        val_8 = val_5;
        val_5 = new ATTACK_DATA.Types.CHANCE();
        this.circle_ = val_8;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_8:
        val_8 = this.pause_;
        if(val_8 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(input != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        input.ReadMessage(builder:  val_8);
        goto label_18;
        label_16:
        this.pause_ = new ATTACK_DATA.Types.CHANCE();
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_18:
        if(input.ReadTag() != 0)
        {
            goto label_22;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE()
    {
        null = null;
        ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.ForceCircleAfterPauseFieldNumber = new Google.Protobuf.MessageParser<NEXTPHASE>(factory:  new System.Func<NEXTPHASE>(object:  ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.<>c.<>9, method:  NEXTPHASE ATTACK_DATA.Types.CHARGE.Types.NEXTPHASE.<>c::<.cctor>b__40_0()));
    }

}
