using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardTokensPercMinFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rewardTokensPercMin_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardTokensPercMaxFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rewardTokensPercMax_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardTokensAbsMinFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rewardTokensAbsMin_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RewardTokensAbsMaxFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rewardTokensAbsMax_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RewardTokensPercMin { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RewardTokensPercMax { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RewardTokensAbsMin { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RewardTokensAbsMax { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<TOKENREWARDS>)ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS.RewardTokensAbsMaxFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS other)
    {
        if(other != null)
        {
                this.rewardTokensPercMin_ = other.rewardTokensPercMin_;
            this.rewardTokensPercMax_ = other.rewardTokensPercMax_;
            this.rewardTokensAbsMin_ = other.rewardTokensAbsMin_;
            this.rewardTokensAbsMax_ = other.rewardTokensAbsMax_;
        }
        else
        {
                this.rewardTokensPercMin_ = 7.42422564692724E-317;
            this.rewardTokensPercMax_ = 3.16202013338398E-322;
            this.rewardTokensAbsMin_ = 3.41288492945375E-316;
            this.rewardTokensAbsMax_ = 1.33509863819657E-307;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS Clone()
    {
        return (TOKENREWARDS)new ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RewardTokensPercMin()
    {
        return (double)this.rewardTokensPercMin_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardTokensPercMin(double value)
    {
        this.rewardTokensPercMin_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RewardTokensPercMax()
    {
        return (double)this.rewardTokensPercMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardTokensPercMax(double value)
    {
        this.rewardTokensPercMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RewardTokensAbsMin()
    {
        return (double)this.rewardTokensAbsMin_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardTokensAbsMin(double value)
    {
        this.rewardTokensAbsMin_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RewardTokensAbsMax()
    {
        return (double)this.rewardTokensAbsMax_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RewardTokensAbsMax(double value)
    {
        this.rewardTokensAbsMax_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        TOKENREWARDS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS other)
    {
        var val_5;
        double val_6;
        var val_7;
        if(other == null)
        {
            goto label_18;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_6 = this.rewardTokensPercMin_;
        val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_5 & 1) != 0)
        {
                val_6 = this.rewardTokensPercMax_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.rewardTokensAbsMin_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.rewardTokensAbsMax_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.rewardTokensPercMin_ == 0f)
        {
                val_5 = 1;
        }
        else
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.rewardTokensPercMax_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.rewardTokensAbsMin_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.rewardTokensAbsMax_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields ^ val_5;
        return (int)val_5;
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
        double val_2;
        double val_3;
        double val_4;
        if(this.rewardTokensPercMin_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.rewardTokensPercMin_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.rewardTokensPercMin_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.rewardTokensPercMax_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.rewardTokensPercMax_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.rewardTokensPercMax_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.rewardTokensAbsMin_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.rewardTokensAbsMin_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.rewardTokensAbsMin_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.rewardTokensAbsMax_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.rewardTokensAbsMax_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.rewardTokensAbsMax_;
        }
        
            output.WriteDouble(value:  val_4);
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
        var val_5;
        var val_1 = (this.rewardTokensPercMin_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.rewardTokensPercMax_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.rewardTokensAbsMin_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.rewardTokensAbsMax_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.rewardTokensPercMin_ != 0f)
        {
                this.rewardTokensPercMin_ = other.rewardTokensPercMin_;
        }
        
        if(other.rewardTokensPercMax_ != 0f)
        {
                this.rewardTokensPercMax_ = other.rewardTokensPercMax_;
        }
        
        if(other.rewardTokensAbsMin_ != 0f)
        {
                this.rewardTokensAbsMin_ = other.rewardTokensAbsMin_;
        }
        
        if(other.rewardTokensAbsMax_ != 0f)
        {
                this.rewardTokensAbsMax_ = other.rewardTokensAbsMax_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
        if(this > 17)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this != 17)
        {
            goto label_7;
        }
        
        this.rewardTokensPercMax_ = input.ReadDouble();
        goto label_12;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this != 33)
        {
            goto label_7;
        }
        
        this.rewardTokensAbsMax_ = input.ReadDouble();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.rewardTokensPercMin_ = input.ReadDouble();
        goto label_12;
        label_6:
        this.rewardTokensAbsMin_ = input.ReadDouble();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS.RewardTokensAbsMaxFieldNumber = new Google.Protobuf.MessageParser<TOKENREWARDS>(factory:  new System.Func<TOKENREWARDS>(object:  ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS.<>c.<>9, method:  TOKENREWARDS ALERT_DATA.Types.ENTRY.Types.EVENTBODY.Types.REWARD.Types.TOKENREWARDS.<>c::<.cctor>b__40_0()));
    }

}
