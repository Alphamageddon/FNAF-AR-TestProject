using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.BATTERY : IMessage<ProtoData.ATTACK_DATA.Types.BATTERY>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.BATTERY>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.BATTERY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BaseFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE base_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT flashlight_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShockerFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.BATTERY.Types.SHOCKER shocker_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywireFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE haywire_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE Base { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT Flashlight { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.SHOCKER Shocker { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE Haywire { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.BATTERY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BATTERY>)ATTACK_DATA.Types.BATTERY.HaywireFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[11];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.BATTERY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.BATTERY(ProtoData.ATTACK_DATA.Types.BATTERY other)
    {
        FLASHLIGHT val_6;
        SHOCKER val_7;
        HAYWIRE val_8;
        if(other.base_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.base_ = other.base_.Clone();
        val_6 = other.flashlight_;
        this.flashlight_ = val_6.Clone();
        val_7 = other.shocker_;
        this.shocker_ = val_7.Clone();
        val_8 = other.haywire_;
        this.haywire_ = val_8.Clone();
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
    public ProtoData.ATTACK_DATA.Types.BATTERY Clone()
    {
        return (BATTERY)new ATTACK_DATA.Types.BATTERY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE get_Base()
    {
        return (BASE)this.base_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Base(ProtoData.ATTACK_DATA.Types.BATTERY.Types.BASE value)
    {
        this.base_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT get_Flashlight()
    {
        return (FLASHLIGHT)this.flashlight_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Flashlight(ProtoData.ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT value)
    {
        this.flashlight_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.SHOCKER get_Shocker()
    {
        return (SHOCKER)this.shocker_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Shocker(ProtoData.ATTACK_DATA.Types.BATTERY.Types.SHOCKER value)
    {
        this.shocker_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE get_Haywire()
    {
        return (HAYWIRE)this.haywire_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Haywire(ProtoData.ATTACK_DATA.Types.BATTERY.Types.HAYWIRE value)
    {
        this.haywire_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BATTERY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.BATTERY other)
    {
        var val_5;
        if(other == null)
        {
            goto label_5;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.Object.Equals(objA:  this.base_, objB:  other.base_)) != false) && ((System.Object.Equals(objA:  this.flashlight_, objB:  other.flashlight_)) != false)) && ((System.Object.Equals(objA:  this.shocker_, objB:  other.shocker_)) != false))
        {
                if((System.Object.Equals(objA:  this.haywire_, objB:  other.haywire_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_5:
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
        if(this.base_ != null)
        {
                val_3 = this.base_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.flashlight_ != null)
        {
                val_3 = this.flashlight_ ^ val_3;
        }
        
        if(this.shocker_ != null)
        {
                val_3 = this.shocker_ ^ val_3;
        }
        
        if(this.haywire_ != null)
        {
                val_3 = this.haywire_ ^ val_3;
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
        BASE val_1;
        FLASHLIGHT val_2;
        SHOCKER val_3;
        HAYWIRE val_4;
        if(this.base_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.base_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.base_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.flashlight_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.flashlight_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.flashlight_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.shocker_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.shocker_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.shocker_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.haywire_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.haywire_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.haywire_;
        }
        
            output.WriteMessage(value:  val_4);
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
        BASE val_9 = this.base_;
        if(val_9 != null)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_9 = this.base_)) + 1;
        }
        
        if(this.flashlight_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlight_))) + 1;
        }
        
        if(this.shocker_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.shocker_))) + 1;
        }
        
        if(this.haywire_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.haywire_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.BATTERY other)
    {
        FLASHLIGHT val_9;
        BASE val_10;
        BASE val_11;
        FLASHLIGHT val_12;
        SHOCKER val_13;
        HAYWIRE val_14;
        if(other == null)
        {
                return;
        }
        
        val_10 = other.base_;
        if(val_10 == null)
        {
            goto label_5;
        }
        
        val_11 = this.base_;
        if(val_11 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.BASE val_1 = null;
        val_11 = val_1;
        val_1 = new ATTACK_DATA.Types.BATTERY.Types.BASE();
        this.base_ = val_11;
        val_10 = other.base_;
        if(val_10 == null)
        {
            goto label_5;
        }
        
        label_3:
        if(other.base_.baseDrain_ != 0f)
        {
                .baseDrain_ = other.base_.baseDrain_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (ATTACK_DATA.Types.BATTERY.Types.BASE)[1152921523912974976]._unknownFields, other:  other.base_._unknownFields);
        label_5:
        val_9 = other.flashlight_;
        if(val_9 != null)
        {
                val_12 = this.flashlight_;
            if(val_12 == null)
        {
                ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT val_3 = null;
            val_12 = val_3;
            val_3 = new ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT();
            this.flashlight_ = val_12;
            val_9 = other.flashlight_;
        }
        
            val_3.MergeFrom(other:  val_9);
        }
        
        val_13 = other.shocker_;
        if(val_13 == null)
        {
            goto label_13;
        }
        
        val_9 = this.shocker_;
        if(val_9 != null)
        {
            goto label_11;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.SHOCKER val_4 = null;
        val_9 = val_4;
        val_4 = new ATTACK_DATA.Types.BATTERY.Types.SHOCKER();
        this.shocker_ = val_9;
        val_13 = other.shocker_;
        if(val_13 == null)
        {
            goto label_13;
        }
        
        label_11:
        if(other.shocker_.activationDrain_ != 0f)
        {
                .activationDrain_ = other.shocker_.activationDrain_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (ATTACK_DATA.Types.BATTERY.Types.SHOCKER)[1152921523913020032]._unknownFields, other:  other.shocker_._unknownFields);
        label_13:
        val_14 = other.haywire_;
        if(val_14 == null)
        {
            goto label_18;
        }
        
        val_9 = this.haywire_;
        if(val_9 != null)
        {
            goto label_16;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.HAYWIRE val_6 = null;
        val_9 = val_6;
        val_6 = new ATTACK_DATA.Types.BATTERY.Types.HAYWIRE();
        this.haywire_ = val_9;
        val_14 = other.haywire_;
        if(val_14 == null)
        {
            goto label_18;
        }
        
        label_16:
        if(other.haywire_.shockDrain_ != 0f)
        {
                .shockDrain_ = other.haywire_.shockDrain_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (ATTACK_DATA.Types.BATTERY.Types.HAYWIRE)[1152921523913048704]._unknownFields, other:  other.haywire_._unknownFields);
        label_18:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        FLASHLIGHT val_7;
        goto label_19;
        label_23:
        if(8777 > 18)
        {
            goto label_2;
        }
        
        if(8777 == 10)
        {
            goto label_3;
        }
        
        if(8777 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.flashlight_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT val_1 = null;
        val_7 = val_1;
        val_1 = new ATTACK_DATA.Types.BATTERY.Types.FLASHLIGHT();
        this.flashlight_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_2:
        if(8777 == 26)
        {
            goto label_8;
        }
        
        if(8777 != 34)
        {
            goto label_9;
        }
        
        val_7 = this.haywire_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.HAYWIRE val_2 = null;
        val_7 = val_2;
        val_2 = new ATTACK_DATA.Types.BATTERY.Types.HAYWIRE();
        this.haywire_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_19;
        label_3:
        val_7 = this.base_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ATTACK_DATA.Types.BATTERY.Types.BASE val_4 = null;
        val_7 = val_4;
        val_4 = new ATTACK_DATA.Types.BATTERY.Types.BASE();
        this.base_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_8:
        val_7 = this.shocker_;
        if(val_7 == null)
        {
            goto label_17;
        }
        
        label_14:
        if(input != null)
        {
            goto label_20;
        }
        
        label_21:
        label_20:
        input.ReadMessage(builder:  val_7);
        goto label_19;
        label_17:
        this.shocker_ = new ATTACK_DATA.Types.BATTERY.Types.SHOCKER();
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        if(input.ReadTag() != 0)
        {
            goto label_23;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.BATTERY()
    {
        null = null;
        ATTACK_DATA.Types.BATTERY.HaywireFieldNumber = new Google.Protobuf.MessageParser<BATTERY>(factory:  new System.Func<BATTERY>(object:  ATTACK_DATA.Types.BATTERY.<>c.<>9, method:  BATTERY ATTACK_DATA.Types.BATTERY.<>c::<.cctor>b__41_0()));
    }

}
