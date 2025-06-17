using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.TROPHIES : IMessage<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AutoFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO auto_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CommonFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON common_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UncommonFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON uncommon_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RareFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE rare_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO Auto { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON Common { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON Uncommon { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE Rare { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.TROPHIES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<TROPHIES>)ANIMATRONIC_DATA.Types.TROPHIES.RareFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.TROPHIES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.TROPHIES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.TROPHIES(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES other)
    {
        COMMON val_6;
        UNCOMMON val_7;
        RARE val_8;
        if(other.auto_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.auto_ = other.auto_.Clone();
        val_6 = other.common_;
        this.common_ = val_6.Clone();
        val_7 = other.uncommon_;
        this.uncommon_ = val_7.Clone();
        val_8 = other.rare_;
        this.rare_ = val_8.Clone();
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
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES Clone()
    {
        return (TROPHIES)new ANIMATRONIC_DATA.Types.TROPHIES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO get_Auto()
    {
        return (AUTO)this.auto_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Auto(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO value)
    {
        this.auto_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON get_Common()
    {
        return (COMMON)this.common_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Common(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON value)
    {
        this.common_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON get_Uncommon()
    {
        return (UNCOMMON)this.uncommon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Uncommon(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON value)
    {
        this.uncommon_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE get_Rare()
    {
        return (RARE)this.rare_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Rare(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE value)
    {
        this.rare_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        TROPHIES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES other)
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
        
        if((((System.Object.Equals(objA:  this.auto_, objB:  other.auto_)) != false) && ((System.Object.Equals(objA:  this.common_, objB:  other.common_)) != false)) && ((System.Object.Equals(objA:  this.uncommon_, objB:  other.uncommon_)) != false))
        {
                if((System.Object.Equals(objA:  this.rare_, objB:  other.rare_)) != false)
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
        if(this.auto_ != null)
        {
                val_3 = this.auto_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.common_ != null)
        {
                val_3 = this.common_ ^ val_3;
        }
        
        if(this.uncommon_ != null)
        {
                val_3 = this.uncommon_ ^ val_3;
        }
        
        if(this.rare_ != null)
        {
                val_3 = this.rare_ ^ val_3;
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
        AUTO val_1;
        COMMON val_2;
        UNCOMMON val_3;
        RARE val_4;
        if(this.auto_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.auto_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.auto_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.common_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.common_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.common_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.uncommon_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.uncommon_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.uncommon_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.rare_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.rare_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.rare_;
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
        AUTO val_9 = this.auto_;
        if(val_9 != null)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_9 = this.auto_)) + 1;
        }
        
        if(this.common_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.common_))) + 1;
        }
        
        if(this.uncommon_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.uncommon_))) + 1;
        }
        
        if(this.rare_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.rare_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.TROPHIES other)
    {
        RARE val_6;
        AUTO val_7;
        AUTO val_8;
        COMMON val_9;
        COMMON val_10;
        UNCOMMON val_11;
        UNCOMMON val_12;
        RARE val_13;
        if(other == null)
        {
                return;
        }
        
        val_7 = other.auto_;
        if(val_7 != null)
        {
                val_8 = this.auto_;
            if(val_8 == null)
        {
                ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO val_1 = null;
            val_8 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO();
            this.auto_ = val_8;
            val_7 = other.auto_;
        }
        
            val_1.MergeFrom(other:  val_7);
        }
        
        val_9 = other.common_;
        if(val_9 != null)
        {
                val_10 = this.common_;
            if(val_10 == null)
        {
                ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON val_2 = null;
            val_10 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON();
            this.common_ = val_10;
            val_9 = other.common_;
        }
        
            val_2.MergeFrom(other:  val_9);
        }
        
        val_11 = other.uncommon_;
        if(val_11 != null)
        {
                val_12 = this.uncommon_;
            if(val_12 == null)
        {
                ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON val_3 = null;
            val_12 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON();
            this.uncommon_ = val_12;
            val_11 = other.uncommon_;
        }
        
            val_3.MergeFrom(other:  val_11);
        }
        
        val_6 = other.rare_;
        if(val_6 != null)
        {
                val_13 = this.rare_;
            if(val_13 == null)
        {
                ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE val_4 = null;
            val_13 = val_4;
            val_4 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE();
            this.rare_ = val_13;
            val_6 = other.rare_;
        }
        
            val_4.MergeFrom(other:  val_6);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        COMMON val_7;
        goto label_19;
        label_23:
        if(47490 > 18)
        {
            goto label_2;
        }
        
        if(47490 == 10)
        {
            goto label_3;
        }
        
        if(47490 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.common_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON val_1 = null;
        val_7 = val_1;
        val_1 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.COMMON();
        this.common_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_2:
        if(47490 == 26)
        {
            goto label_8;
        }
        
        if(47490 != 34)
        {
            goto label_9;
        }
        
        val_7 = this.rare_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE val_2 = null;
        val_7 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.RARE();
        this.rare_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_19;
        label_3:
        val_7 = this.auto_;
        if(val_7 != null)
        {
            goto label_14;
        }
        
        ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO val_4 = null;
        val_7 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.TROPHIES.Types.AUTO();
        this.auto_ = val_7;
        if(input != null)
        {
            goto label_20;
        }
        
        goto label_21;
        label_8:
        val_7 = this.uncommon_;
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
        this.uncommon_ = new ANIMATRONIC_DATA.Types.TROPHIES.Types.UNCOMMON();
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
    private static ANIMATRONIC_DATA.Types.TROPHIES()
    {
        null = null;
        ANIMATRONIC_DATA.Types.TROPHIES.RareFieldNumber = new Google.Protobuf.MessageParser<TROPHIES>(factory:  new System.Func<TROPHIES>(object:  ANIMATRONIC_DATA.Types.TROPHIES.<>c.<>9, method:  TROPHIES ANIMATRONIC_DATA.Types.TROPHIES.<>c::<.cctor>b__41_0()));
    }

}
