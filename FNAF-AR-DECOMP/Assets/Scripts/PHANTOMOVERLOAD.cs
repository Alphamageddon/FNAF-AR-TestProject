using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.PHANTOMOVERLOAD : IMessage<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ReactionTimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE reactionTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightDisableTimeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE flashlightDisableTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE ReactionTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE FlashlightDisableTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHANTOMOVERLOAD>)ATTACK_DATA.Types.PHANTOMOVERLOAD.FlashlightDisableTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[14];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.PHANTOMOVERLOAD.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PHANTOMOVERLOAD()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PHANTOMOVERLOAD(ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        if(other.reactionTime_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.reactionTime_ = other.reactionTime_.Clone();
        val_4 = other.flashlightDisableTime_;
        this.flashlightDisableTime_ = val_4.Clone();
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
    public ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD Clone()
    {
        return (PHANTOMOVERLOAD)new ATTACK_DATA.Types.PHANTOMOVERLOAD(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_ReactionTime()
    {
        return (RANGE)this.reactionTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ReactionTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.reactionTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_FlashlightDisableTime()
    {
        return (RANGE)this.flashlightDisableTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightDisableTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.flashlightDisableTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHANTOMOVERLOAD val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD other)
    {
        var val_3;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.reactionTime_, objB:  other.reactionTime_)) != false)
        {
                if((System.Object.Equals(objA:  this.flashlightDisableTime_, objB:  other.flashlightDisableTime_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_1:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.reactionTime_ != null)
        {
                val_3 = this.reactionTime_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.flashlightDisableTime_ != null)
        {
                val_3 = this.flashlightDisableTime_ ^ val_3;
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
        ATTACK_DATA.Types.RANGE val_1;
        ATTACK_DATA.Types.RANGE val_2;
        if(this.reactionTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.reactionTime_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.reactionTime_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.flashlightDisableTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.flashlightDisableTime_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.flashlightDisableTime_;
        }
        
            output.WriteMessage(value:  val_2);
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
        ATTACK_DATA.Types.RANGE val_5 = this.reactionTime_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.reactionTime_)) + 1;
        }
        
        if(this.flashlightDisableTime_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightDisableTime_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.PHANTOMOVERLOAD other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        ATTACK_DATA.Types.RANGE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.reactionTime_;
        if(val_5 != null)
        {
                val_6 = this.reactionTime_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.reactionTime_ = val_6;
            val_5 = other.reactionTime_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.flashlightDisableTime_;
        if(val_4 != null)
        {
                val_7 = this.flashlightDisableTime_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.flashlightDisableTime_ = val_7;
            val_4 = other.flashlightDisableTime_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.reactionTime_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_5 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.reactionTime_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.flashlightDisableTime_;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(input != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        input.ReadMessage(builder:  val_5);
        goto label_8;
        label_6:
        this.flashlightDisableTime_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_8:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_12;
        }
        
        if(val_4 == 18)
        {
            goto label_13;
        }
        
        if(val_4 != 0)
        {
            goto label_14;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.PHANTOMOVERLOAD()
    {
        null = null;
        ATTACK_DATA.Types.PHANTOMOVERLOAD.FlashlightDisableTimeFieldNumber = new Google.Protobuf.MessageParser<PHANTOMOVERLOAD>(factory:  new System.Func<PHANTOMOVERLOAD>(object:  ATTACK_DATA.Types.PHANTOMOVERLOAD.<>c.<>9, method:  PHANTOMOVERLOAD ATTACK_DATA.Types.PHANTOMOVERLOAD.<>c::<.cctor>b__30_0()));
    }

}
