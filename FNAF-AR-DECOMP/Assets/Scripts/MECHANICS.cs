using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class SEASONAL_DATA.Types.ENTRY.Types.MECHANICS : IMessage<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS>, IMessage, IEquatable<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS>, IDeepCloneable<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SequentialRewardsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string sequentialRewards_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StoreSaleFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string storeSale_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StoreSkinFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string storeSkin_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StoreIdFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string storeId_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SeasonalAssetsGroupFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string seasonalAssetsGroup_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string SequentialRewards { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string StoreSale { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string StoreSkin { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string StoreId { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string SeasonalAssetsGroup { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MECHANICS>)SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.SeasonalAssetsGroupFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return SEASONAL_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SEASONAL_DATA.Types.ENTRY.Types.MECHANICS()
    {
        this.sequentialRewards_ = "";
        this.storeSale_ = "";
        this.storeSkin_ = "";
        this.storeId_ = "";
        this.seasonalAssetsGroup_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SEASONAL_DATA.Types.ENTRY.Types.MECHANICS(ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS other)
    {
        if(other != null)
        {
                this.sequentialRewards_ = other.sequentialRewards_;
            this.storeSale_ = other.storeSale_;
            this.storeSkin_ = other.storeSkin_;
            this.storeId_ = other.storeId_;
            this.seasonalAssetsGroup_ = other.seasonalAssetsGroup_;
        }
        else
        {
                this.sequentialRewards_ = 15026800;
            this.storeSale_ = 64;
            this.storeSkin_ = 69077560;
            this.storeId_ = 0;
            this.seasonalAssetsGroup_ = 4194311;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS Clone()
    {
        return (MECHANICS)new SEASONAL_DATA.Types.ENTRY.Types.MECHANICS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_SequentialRewards()
    {
        return (string)this.sequentialRewards_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SequentialRewards(string value)
    {
        this.sequentialRewards_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_StoreSale()
    {
        return (string)this.storeSale_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StoreSale(string value)
    {
        this.storeSale_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_StoreSkin()
    {
        return (string)this.storeSkin_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StoreSkin(string value)
    {
        this.storeSkin_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_StoreId()
    {
        return (string)this.storeId_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StoreId(string value)
    {
        this.storeId_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_SeasonalAssetsGroup()
    {
        return (string)this.seasonalAssetsGroup_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SeasonalAssetsGroup(string value)
    {
        this.seasonalAssetsGroup_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MECHANICS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS other)
    {
        var val_6;
        if(other == null)
        {
            goto label_5;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((System.String.op_Inequality(a:  this.sequentialRewards_, b:  other.sequentialRewards_)) != true) && ((System.String.op_Inequality(a:  this.storeSale_, b:  other.storeSale_)) != true)) && ((System.String.op_Inequality(a:  this.storeSkin_, b:  other.storeSkin_)) != true))
        {
                if((System.String.op_Inequality(a:  this.storeId_, b:  other.storeId_)) != true)
        {
                if((System.String.op_Inequality(a:  this.seasonalAssetsGroup_, b:  other.seasonalAssetsGroup_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_6;
        var val_7;
        if(this.sequentialRewards_.Length != 0)
        {
                val_6 = this.sequentialRewards_ ^ 1;
        }
        else
        {
                val_6 = 1;
        }
        
        if(this.storeSale_.Length != 0)
        {
                val_6 = this.storeSale_ ^ val_6;
        }
        
        if(this.storeSkin_.Length != 0)
        {
                val_6 = this.storeSkin_ ^ val_6;
        }
        
        if(this.storeId_.Length != 0)
        {
                val_6 = this.storeId_ ^ val_6;
        }
        
        val_7 = 0;
        if(this.seasonalAssetsGroup_.Length != 0)
        {
                val_6 = this.seasonalAssetsGroup_ ^ val_6;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields ^ val_6;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_6;
        string val_7;
        string val_8;
        string val_9;
        string val_10;
        if(this.sequentialRewards_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_6 = this.sequentialRewards_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_6 = this.sequentialRewards_;
        }
        
            output.WriteString(value:  val_6);
        }
        
        if(this.storeSale_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_7 = this.storeSale_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_7 = this.storeSale_;
        }
        
            output.WriteString(value:  val_7);
        }
        
        if(this.storeSkin_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_8 = this.storeSkin_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_8 = this.storeSkin_;
        }
        
            output.WriteString(value:  val_8);
        }
        
        if(this.storeId_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_9 = this.storeId_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_9 = this.storeId_;
        }
        
            output.WriteString(value:  val_9);
        }
        
        if(this.seasonalAssetsGroup_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_10 = this.seasonalAssetsGroup_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_10 = this.seasonalAssetsGroup_;
        }
        
            output.WriteString(value:  val_10);
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
        var val_16;
        if(this.sequentialRewards_.Length != 0)
        {
                val_16 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.sequentialRewards_)) + 1;
        }
        else
        {
                val_16 = 0;
        }
        
        if(this.storeSale_.Length != 0)
        {
                val_16 = (val_16 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.storeSale_))) + 1;
        }
        
        if(this.storeSkin_.Length != 0)
        {
                val_16 = (val_16 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.storeSkin_))) + 1;
        }
        
        if(this.storeId_.Length != 0)
        {
                val_16 = (val_16 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.storeId_))) + 1;
        }
        
        if(this.seasonalAssetsGroup_.Length != 0)
        {
                val_16 = (val_16 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.seasonalAssetsGroup_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_16;
        }
        
        val_16 = this._unknownFields.CalculateSize() + val_16;
        return (int)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.SEASONAL_DATA.Types.ENTRY.Types.MECHANICS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.sequentialRewards_.Length != 0)
        {
                this.SequentialRewards = other.sequentialRewards_;
        }
        
        if(other.storeSale_.Length != 0)
        {
                this.StoreSale = other.storeSale_;
        }
        
        if(other.storeSkin_.Length != 0)
        {
                this.StoreSkin = other.storeSkin_;
        }
        
        if(other.storeId_.Length != 0)
        {
                this.StoreId = other.storeId_;
        }
        
        if(other.seasonalAssetsGroup_.Length != 0)
        {
                this.SeasonalAssetsGroup = other.seasonalAssetsGroup_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_15;
        label_18:
        if(this > 18)
        {
            goto label_1;
        }
        
        if(this == 10)
        {
            goto label_2;
        }
        
        if(this != 18)
        {
            goto label_8;
        }
        
        this.StoreSale = input.ReadString();
        goto label_15;
        label_1:
        if(this == 42)
        {
            goto label_6;
        }
        
        if(this == 50)
        {
            goto label_7;
        }
        
        if(this != 58)
        {
            goto label_8;
        }
        
        this.SeasonalAssetsGroup = input.ReadString();
        goto label_15;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_15;
        label_2:
        this.SequentialRewards = input.ReadString();
        goto label_15;
        label_7:
        this.StoreId = input.ReadString();
        goto label_15;
        label_6:
        this.StoreSkin = input.ReadString();
        label_15:
        if(input.ReadTag() != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static SEASONAL_DATA.Types.ENTRY.Types.MECHANICS()
    {
        null = null;
        SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.SeasonalAssetsGroupFieldNumber = new Google.Protobuf.MessageParser<MECHANICS>(factory:  new System.Func<MECHANICS>(object:  SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.<>c.<>9, method:  MECHANICS SEASONAL_DATA.Types.ENTRY.Types.MECHANICS.<>c::<.cctor>b__45_0()));
    }

}
