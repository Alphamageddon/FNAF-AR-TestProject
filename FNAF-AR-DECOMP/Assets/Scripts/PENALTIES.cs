using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES : IMessage<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES>, IMessage, IEquatable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES>, IDeepCloneable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CloakTimerFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER cloakTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RareRewardChanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double rareRewardChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CommonRewardChanceFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double commonRewardChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS parts_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywireCircleChanceFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE haywireCircleChance_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HaywirePauseChanceFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE haywirePauseChance_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER CloakTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RareRewardChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CommonRewardChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS Parts { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE HaywireCircleChance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE HaywirePauseChance { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PENALTIES>)WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.HaywirePauseChanceFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return WEARANDTEAR_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES other)
    {
        PARTS val_6;
        HAYWIRECHANCE val_7;
        HAYWIRECHANCE val_8;
        if(other.cloakTimer_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.cloakTimer_ = other.cloakTimer_.Clone();
        this.rareRewardChance_ = other.rareRewardChance_;
        this.commonRewardChance_ = other.commonRewardChance_;
        val_6 = other.parts_;
        this.parts_ = val_6.Clone();
        val_7 = other.haywireCircleChance_;
        this.haywireCircleChance_ = val_7.Clone();
        val_8 = other.haywirePauseChance_;
        this.haywirePauseChance_ = val_8.Clone();
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
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES Clone()
    {
        return (PENALTIES)new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER get_CloakTimer()
    {
        return (CLOAKTIMER)this.cloakTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CloakTimer(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER value)
    {
        this.cloakTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RareRewardChance()
    {
        return (double)this.rareRewardChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RareRewardChance(double value)
    {
        this.rareRewardChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CommonRewardChance()
    {
        return (double)this.commonRewardChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CommonRewardChance(double value)
    {
        this.commonRewardChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS get_Parts()
    {
        return (PARTS)this.parts_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Parts(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS value)
    {
        this.parts_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE get_HaywireCircleChance()
    {
        return (HAYWIRECHANCE)this.haywireCircleChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HaywireCircleChance(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE value)
    {
        this.haywireCircleChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE get_HaywirePauseChance()
    {
        return (HAYWIRECHANCE)this.haywirePauseChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HaywirePauseChance(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE value)
    {
        this.haywirePauseChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PENALTIES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES other)
    {
        var val_7;
        double val_8;
        var val_9;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.Object.Equals(objA:  this.cloakTimer_, objB:  other.cloakTimer_)) != false)
        {
                val_8 = this.rareRewardChance_;
            val_7 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_7 & 1) != 0)
        {
                val_8 = this.commonRewardChance_;
            val_7 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((((val_7 & 1) != 0) && ((System.Object.Equals(objA:  this.parts_, objB:  other.parts_)) != false)) && ((System.Object.Equals(objA:  this.haywireCircleChance_, objB:  other.haywireCircleChance_)) != false))
        {
                if((System.Object.Equals(objA:  this.haywirePauseChance_, objB:  other.haywirePauseChance_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_14:
        val_9 = 0;
        return (bool)val_9;
        label_2:
        val_9 = 1;
        return (bool)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.cloakTimer_ != null)
        {
                val_5 = this.cloakTimer_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.rareRewardChance_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.commonRewardChance_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.parts_ != null)
        {
                val_5 = this.parts_ ^ val_5;
        }
        
        if(this.haywireCircleChance_ != null)
        {
                val_5 = this.haywireCircleChance_ ^ val_5;
        }
        
        if(this.haywirePauseChance_ != null)
        {
                val_5 = this.haywirePauseChance_ ^ val_5;
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
        CLOAKTIMER val_1;
        double val_2;
        double val_3;
        PARTS val_4;
        HAYWIRECHANCE val_5;
        HAYWIRECHANCE val_6;
        if(this.cloakTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.cloakTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.cloakTimer_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.rareRewardChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.rareRewardChance_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.rareRewardChance_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.commonRewardChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.commonRewardChance_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.commonRewardChance_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.parts_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.parts_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.parts_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.haywireCircleChance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.haywireCircleChance_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.haywireCircleChance_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.haywirePauseChance_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.haywirePauseChance_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.haywirePauseChance_;
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
        var val_12;
        var val_13;
        if(this.cloakTimer_ != null)
        {
                val_12 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cloakTimer_)) + 1;
        }
        else
        {
                val_12 = 0;
        }
        
        var val_2 = val_12 + 9;
        val_12 = (this.rareRewardChance_ == 0f) ? (val_12) : (val_2);
        val_2 = val_12 + 9;
        if(this.parts_ != null)
        {
                val_13 = (((this.commonRewardChance_ == 0f) ? (val_12) : (val_2)) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.parts_))) + 1;
        }
        
        if(this.haywireCircleChance_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.haywireCircleChance_))) + 1;
        }
        
        if(this.haywirePauseChance_ != null)
        {
                val_13 = (val_13 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.haywirePauseChance_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_13;
        }
        
        val_13 = this._unknownFields.CalculateSize() + val_13;
        return (int)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES other)
    {
        HAYWIRECHANCE val_6;
        CLOAKTIMER val_7;
        CLOAKTIMER val_8;
        PARTS val_9;
        PARTS val_10;
        HAYWIRECHANCE val_11;
        HAYWIRECHANCE val_12;
        HAYWIRECHANCE val_13;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.cloakTimer_;
        if(val_7 != null)
        {
                val_8 = this.cloakTimer_;
            if(val_8 == null)
        {
                WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER val_1 = null;
            val_8 = val_1;
            val_1 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER();
            this.cloakTimer_ = val_8;
            val_7 = other.cloakTimer_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        if(other.rareRewardChance_ != 0f)
        {
                this.rareRewardChance_ = other.rareRewardChance_;
        }
        
        if(other.commonRewardChance_ != 0f)
        {
                this.commonRewardChance_ = other.commonRewardChance_;
        }
        
        val_9 = other.parts_;
        if(val_9 != null)
        {
                val_10 = this.parts_;
            if(val_10 == null)
        {
                WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS val_2 = null;
            val_10 = val_2;
            val_2 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS();
            this.parts_ = val_10;
            val_9 = other.parts_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        val_11 = other.haywireCircleChance_;
        if(val_11 != null)
        {
                val_12 = this.haywireCircleChance_;
            if(val_12 == null)
        {
                WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE val_3 = null;
            val_12 = val_3;
            val_3 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE();
            this.haywireCircleChance_ = val_12;
            val_11 = other.haywireCircleChance_;
        }
        
            val_3.MergeFrom(other:  val_11);
        }
        
        val_6 = other.haywirePauseChance_;
        if(val_6 != null)
        {
                val_13 = this.haywirePauseChance_;
            if(val_13 == null)
        {
                WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE val_4 = null;
            val_13 = val_4;
            val_4 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE();
            this.haywirePauseChance_ = val_13;
            val_6 = other.haywirePauseChance_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        HAYWIRECHANCE val_9;
        goto label_25;
        label_29:
        if(35235 > 25)
        {
            goto label_2;
        }
        
        if(35235 == 10)
        {
            goto label_3;
        }
        
        if(35235 == 17)
        {
            goto label_4;
        }
        
        if(35235 != 25)
        {
            goto label_10;
        }
        
        this.commonRewardChance_ = input.ReadDouble();
        goto label_25;
        label_2:
        if(35235 == 34)
        {
            goto label_8;
        }
        
        if(35235 == 42)
        {
            goto label_9;
        }
        
        if(35235 != 50)
        {
            goto label_10;
        }
        
        val_9 = this.haywirePauseChance_;
        if(val_9 != null)
        {
            goto label_20;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE val_2 = null;
        val_9 = val_2;
        val_2 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE();
        this.haywirePauseChance_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_25;
        label_4:
        this.rareRewardChance_ = input.ReadDouble();
        goto label_25;
        label_9:
        val_9 = this.haywireCircleChance_;
        if(val_9 != null)
        {
            goto label_20;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE val_5 = null;
        val_9 = val_5;
        val_5 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.HAYWIRECHANCE();
        this.haywireCircleChance_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_3:
        val_9 = this.cloakTimer_;
        if(val_9 != null)
        {
            goto label_20;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER val_6 = null;
        val_9 = val_6;
        val_6 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.CLOAKTIMER();
        this.cloakTimer_ = val_9;
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_8:
        val_9 = this.parts_;
        if(val_9 == null)
        {
            goto label_23;
        }
        
        label_20:
        if(input != null)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        input.ReadMessage(builder:  val_9);
        goto label_25;
        label_23:
        this.parts_ = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.Types.PARTS();
        if(input != null)
        {
            goto label_26;
        }
        
        goto label_27;
        label_25:
        if(input.ReadTag() != 0)
        {
            goto label_29;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES()
    {
        null = null;
        WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.HaywirePauseChanceFieldNumber = new Google.Protobuf.MessageParser<PENALTIES>(factory:  new System.Func<PENALTIES>(object:  WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.<>c.<>9, method:  PENALTIES WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES.<>c::<.cctor>b__51_0()));
    }

}
