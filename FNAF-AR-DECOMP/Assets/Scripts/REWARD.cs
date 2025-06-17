using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TokenRewardsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS tokenRewards_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardAnimatronicFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string rewardAnimatronic_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS TokenRewards { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string RewardAnimatronic { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<REWARD>)ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.RewardAnimatronicFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD()
    {
        this.rewardAnimatronic_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD other)
    {
        if(other.tokenRewards_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.tokenRewards_ = other.tokenRewards_.Clone();
        this.rewardAnimatronic_ = other.rewardAnimatronic_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD Clone()
    {
        return (REWARD)new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS get_TokenRewards()
    {
        return (TOKENREWARDS)this.tokenRewards_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TokenRewards(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS value)
    {
        this.tokenRewards_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_RewardAnimatronic()
    {
        return (string)this.rewardAnimatronic_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardAnimatronic(string value)
    {
        this.rewardAnimatronic_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        REWARD val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD other)
    {
        var val_3;
        if(other == null)
        {
            goto label_2;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.tokenRewards_, objB:  other.tokenRewards_)) != false)
        {
                if((System.String.op_Inequality(a:  this.rewardAnimatronic_, b:  other.rewardAnimatronic_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_2:
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
        var val_4;
        if(this.tokenRewards_ != null)
        {
                val_3 = this.tokenRewards_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.rewardAnimatronic_.Length != 0)
        {
                val_3 = this.rewardAnimatronic_ ^ val_3;
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
        TOKENREWARDS val_2;
        string val_3;
        if(this.tokenRewards_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.tokenRewards_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.tokenRewards_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.rewardAnimatronic_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.rewardAnimatronic_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.rewardAnimatronic_;
        }
        
            output.WriteString(value:  val_3);
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
        TOKENREWARDS val_6 = this.tokenRewards_;
        if(val_6 != null)
        {
                val_6 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_6 = this.tokenRewards_)) + 1;
        }
        
        if(this.rewardAnimatronic_.Length != 0)
        {
                val_6 = (val_6 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.rewardAnimatronic_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields.CalculateSize() + val_6;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD other)
    {
        string val_4;
        TOKENREWARDS val_5;
        TOKENREWARDS val_6;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.tokenRewards_;
        if(val_5 != null)
        {
                val_6 = this.tokenRewards_;
            if(val_6 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS val_1 = null;
            val_6 = val_1;
            val_1 = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS();
            this.tokenRewards_ = val_6;
            val_5 = other.tokenRewards_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.rewardAnimatronic_;
        if(val_4.Length != 0)
        {
                this.RewardAnimatronic = other.rewardAnimatronic_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_7;
        label_13:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_7;
        label_11:
        if(this.tokenRewards_ == null)
        {
            goto label_3;
        }
        
        label_9:
        input.ReadMessage(builder:  this.tokenRewards_);
        goto label_7;
        label_12:
        this.RewardAnimatronic = input.ReadString();
        goto label_7;
        label_3:
        this.tokenRewards_ = new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_7:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_11;
        }
        
        if(val_4 == 18)
        {
            goto label_12;
        }
        
        if(val_4 != 0)
        {
            goto label_13;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.RewardAnimatronicFieldNumber = new Google.Protobuf.MessageParser<REWARD>(factory:  new System.Func<REWARD>(object:  ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.<>c.<>9, method:  REWARD ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.<>c::<.cctor>b__31_0()));
    }

}
