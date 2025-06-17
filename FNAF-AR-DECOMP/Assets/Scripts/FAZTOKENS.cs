using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.FAZTOKENS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CostToOrderFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double costToOrder_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardOnWinFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN rewardOnWin_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardOnSkillShotFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT rewardOnSkillShot_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CostToOrder { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN RewardOnWin { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT RewardOnSkillShot { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FAZTOKENS>)ANIMATRONIC_DATA.Types.FAZTOKENS.RewardOnSkillShotFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.FAZTOKENS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS other)
    {
        REWARDONWIN val_4;
        REWARDONSKILLSHOT val_5;
        if(other != null)
        {
                this.costToOrder_ = other.costToOrder_;
        }
        else
        {
                this.costToOrder_ = 7.42422564692724E-317;
        }
        
        val_4 = other.rewardOnWin_;
        this.rewardOnWin_ = val_4.Clone();
        val_5 = other.rewardOnSkillShot_;
        this.rewardOnSkillShot_ = val_5.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS Clone()
    {
        return (FAZTOKENS)new ANIMATRONIC_DATA.Types.FAZTOKENS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CostToOrder()
    {
        return (double)this.costToOrder_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CostToOrder(double value)
    {
        this.costToOrder_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN get_RewardOnWin()
    {
        return (REWARDONWIN)this.rewardOnWin_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardOnWin(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN value)
    {
        this.rewardOnWin_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT get_RewardOnSkillShot()
    {
        return (REWARDONSKILLSHOT)this.rewardOnSkillShot_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardOnSkillShot(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT value)
    {
        this.rewardOnSkillShot_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FAZTOKENS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS other)
    {
        var val_4;
        if(other == null)
        {
            goto label_8;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0) && ((System.Object.Equals(objA:  this.rewardOnWin_, objB:  other.rewardOnWin_)) != false))
        {
                if((System.Object.Equals(objA:  this.rewardOnSkillShot_, objB:  other.rewardOnSkillShot_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_8:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        if(this.costToOrder_ == 0f)
        {
                val_2 = 1;
        }
        else
        {
                val_2 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.rewardOnWin_ != null)
        {
                val_2 = this.rewardOnWin_ ^ val_2;
        }
        
        if(this.rewardOnSkillShot_ != null)
        {
                val_2 = this.rewardOnSkillShot_ ^ val_2;
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
        double val_1;
        REWARDONWIN val_2;
        REWARDONSKILLSHOT val_3;
        if(this.costToOrder_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.costToOrder_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.costToOrder_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.rewardOnWin_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.rewardOnWin_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.rewardOnWin_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.rewardOnSkillShot_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.rewardOnSkillShot_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.rewardOnSkillShot_;
        }
        
            output.WriteMessage(value:  val_3);
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
        var val_7;
        if(this.rewardOnWin_ != null)
        {
                val_7 = (((this.costToOrder_ == 0f) ? 0 : 9) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.rewardOnWin_))) + 1;
        }
        
        if(this.rewardOnSkillShot_ != null)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.rewardOnSkillShot_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS other)
    {
        REWARDONSKILLSHOT val_4;
        REWARDONWIN val_5;
        REWARDONWIN val_6;
        REWARDONSKILLSHOT val_7;
        if(other == null)
        {
                return;
        }
        
        if(other.costToOrder_ != 0f)
        {
                this.costToOrder_ = other.costToOrder_;
        }
        
        val_5 = other.rewardOnWin_;
        if(val_5 != null)
        {
                val_6 = this.rewardOnWin_;
            if(val_6 == null)
        {
                ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN val_1 = null;
            val_6 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN();
            this.rewardOnWin_ = val_6;
            val_5 = other.rewardOnWin_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.rewardOnSkillShot_;
        if(val_4 != null)
        {
                val_7 = this.rewardOnSkillShot_;
            if(val_7 == null)
        {
                ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT val_2 = null;
            val_7 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT();
            this.rewardOnSkillShot_ = val_7;
            val_4 = other.rewardOnSkillShot_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        REWARDONWIN val_6;
        goto label_17;
        label_18:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_17;
        label_15:
        ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN val_2 = null;
        val_6 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONWIN();
        this.rewardOnWin_ = val_6;
        if(input != null)
        {
            goto label_16;
        }
        
        goto label_11;
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
        
        if(val_3 != 26)
        {
            goto label_18;
        }
        
        val_6 = this.rewardOnSkillShot_;
        if(val_6 != null)
        {
            goto label_9;
        }
        
        ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT val_4 = null;
        val_6 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT();
        this.rewardOnSkillShot_ = val_6;
        if(input != null)
        {
            goto label_16;
        }
        
        goto label_11;
        label_6:
        if(val_3 != 9)
        {
            goto label_12;
        }
        
        this.costToOrder_ = input.ReadDouble();
        goto label_17;
        label_7:
        val_6 = this.rewardOnWin_;
        if(val_6 == null)
        {
            goto label_15;
        }
        
        label_9:
        if(input != null)
        {
            goto label_16;
        }
        
        label_11:
        label_16:
        input.ReadMessage(builder:  val_6);
        goto label_17;
        label_12:
        if(val_3 != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.FAZTOKENS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.FAZTOKENS.RewardOnSkillShotFieldNumber = new Google.Protobuf.MessageParser<FAZTOKENS>(factory:  new System.Func<FAZTOKENS>(object:  ANIMATRONIC_DATA.Types.FAZTOKENS.<>c.<>9, method:  FAZTOKENS ANIMATRONIC_DATA.Types.FAZTOKENS.<>c::<.cctor>b__36_0()));
    }

}
