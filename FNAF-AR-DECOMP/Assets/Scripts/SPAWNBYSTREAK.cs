using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.SPAWNBYSTREAK : IMessage<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK>, IDeepCloneable<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RankRangeByBestStreakFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK rankRangeByBestStreak_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RankRangeByCurrentStreakFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK rankRangeByCurrentStreak_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK RankRangeByBestStreak { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK RankRangeByCurrentStreak { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPAWNBYSTREAK> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SPAWNBYSTREAK>)CPU_DATA.Types.SPAWNBYSTREAK.RankRangeByCurrentStreakFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.SPAWNBYSTREAK.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPAWNBYSTREAK()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPAWNBYSTREAK(ProtoData.CPU_DATA.Types.SPAWNBYSTREAK other)
    {
        RANKRANGEBYCURRENTSTREAK val_4;
        if(other.rankRangeByBestStreak_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.rankRangeByBestStreak_ = other.rankRangeByBestStreak_.Clone();
        val_4 = other.rankRangeByCurrentStreak_;
        this.rankRangeByCurrentStreak_ = val_4.Clone();
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
    public ProtoData.CPU_DATA.Types.SPAWNBYSTREAK Clone()
    {
        return (SPAWNBYSTREAK)new CPU_DATA.Types.SPAWNBYSTREAK(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK get_RankRangeByBestStreak()
    {
        return (RANKRANGEBYBESTSTREAK)this.rankRangeByBestStreak_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RankRangeByBestStreak(ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK value)
    {
        this.rankRangeByBestStreak_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK get_RankRangeByCurrentStreak()
    {
        return (RANKRANGEBYCURRENTSTREAK)this.rankRangeByCurrentStreak_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RankRangeByCurrentStreak(ProtoData.CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK value)
    {
        this.rankRangeByCurrentStreak_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SPAWNBYSTREAK val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.SPAWNBYSTREAK other)
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
        
        if((System.Object.Equals(objA:  this.rankRangeByBestStreak_, objB:  other.rankRangeByBestStreak_)) != false)
        {
                if((System.Object.Equals(objA:  this.rankRangeByCurrentStreak_, objB:  other.rankRangeByCurrentStreak_)) != false)
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
        if(this.rankRangeByBestStreak_ != null)
        {
                val_3 = this.rankRangeByBestStreak_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.rankRangeByCurrentStreak_ != null)
        {
                val_3 = this.rankRangeByCurrentStreak_ ^ val_3;
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
        RANKRANGEBYBESTSTREAK val_1;
        RANKRANGEBYCURRENTSTREAK val_2;
        if(this.rankRangeByBestStreak_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.rankRangeByBestStreak_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.rankRangeByBestStreak_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.rankRangeByCurrentStreak_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.rankRangeByCurrentStreak_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.rankRangeByCurrentStreak_;
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
        RANKRANGEBYBESTSTREAK val_5 = this.rankRangeByBestStreak_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.rankRangeByBestStreak_)) + 1;
        }
        
        if(this.rankRangeByCurrentStreak_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.rankRangeByCurrentStreak_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.SPAWNBYSTREAK other)
    {
        RANKRANGEBYCURRENTSTREAK val_4;
        RANKRANGEBYBESTSTREAK val_5;
        RANKRANGEBYBESTSTREAK val_6;
        RANKRANGEBYCURRENTSTREAK val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.rankRangeByBestStreak_;
        if(val_5 != null)
        {
                val_6 = this.rankRangeByBestStreak_;
            if(val_6 == null)
        {
                CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK val_1 = null;
            val_6 = val_1;
            val_1 = new CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK();
            this.rankRangeByBestStreak_ = val_6;
            val_5 = other.rankRangeByBestStreak_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.rankRangeByCurrentStreak_;
        if(val_4 != null)
        {
                val_7 = this.rankRangeByCurrentStreak_;
            if(val_7 == null)
        {
                CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK val_2 = null;
            val_7 = val_2;
            val_2 = new CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK();
            this.rankRangeByCurrentStreak_ = val_7;
            val_4 = other.rankRangeByCurrentStreak_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        RANKRANGEBYBESTSTREAK val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.rankRangeByBestStreak_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK val_2 = null;
        val_5 = val_2;
        val_2 = new CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYBESTSTREAK();
        this.rankRangeByBestStreak_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.rankRangeByCurrentStreak_;
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
        this.rankRangeByCurrentStreak_ = new CPU_DATA.Types.SPAWNBYSTREAK.Types.RANKRANGEBYCURRENTSTREAK();
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
    private static CPU_DATA.Types.SPAWNBYSTREAK()
    {
        null = null;
        CPU_DATA.Types.SPAWNBYSTREAK.RankRangeByCurrentStreakFieldNumber = new Google.Protobuf.MessageParser<SPAWNBYSTREAK>(factory:  new System.Func<SPAWNBYSTREAK>(object:  CPU_DATA.Types.SPAWNBYSTREAK.<>c.<>9, method:  SPAWNBYSTREAK CPU_DATA.Types.SPAWNBYSTREAK.<>c::<.cctor>b__31_0()));
    }

}
