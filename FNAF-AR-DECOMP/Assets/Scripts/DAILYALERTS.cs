using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DailyAlertPeriodSecFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double dailyAlertPeriodSec_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DailyAlertCheckChanceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double dailyAlertCheckChance_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DailyAlertPeriodSec { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DailyAlertCheckChance { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DAILYALERTS>)CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.DailyAlertCheckChanceFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS other)
    {
        if(other != null)
        {
                this.dailyAlertPeriodSec_ = other.dailyAlertPeriodSec_;
            this.dailyAlertCheckChance_ = other.dailyAlertCheckChance_;
        }
        else
        {
                this.dailyAlertPeriodSec_ = 7.42422564692724E-317;
            this.dailyAlertCheckChance_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS Clone()
    {
        return (DAILYALERTS)new CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DailyAlertPeriodSec()
    {
        return (double)this.dailyAlertPeriodSec_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DailyAlertPeriodSec(double value)
    {
        this.dailyAlertPeriodSec_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DailyAlertCheckChance()
    {
        return (double)this.dailyAlertCheckChance_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DailyAlertCheckChance(double value)
    {
        this.dailyAlertCheckChance_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DAILYALERTS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS other)
    {
        var val_3;
        double val_4;
        var val_5;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_4 = this.dailyAlertPeriodSec_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.dailyAlertCheckChance_;
            val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_3 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.dailyAlertPeriodSec_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.dailyAlertCheckChance_ != 0f)
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_3;
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
        double val_1;
        double val_2;
        if(this.dailyAlertPeriodSec_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.dailyAlertPeriodSec_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.dailyAlertPeriodSec_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.dailyAlertCheckChance_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.dailyAlertCheckChance_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.dailyAlertCheckChance_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_1 = (this.dailyAlertPeriodSec_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.dailyAlertCheckChance_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.dailyAlertPeriodSec_ != 0f)
        {
                this.dailyAlertPeriodSec_ = other.dailyAlertPeriodSec_;
        }
        
        if(other.dailyAlertCheckChance_ != 0f)
        {
                this.dailyAlertCheckChance_ = other.dailyAlertCheckChance_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_3;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_3;
        label_6:
        this.dailyAlertPeriodSec_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.dailyAlertCheckChance_ = input.ReadDouble();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 9)
        {
            goto label_6;
        }
        
        if(val_4 == 17)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.DailyAlertCheckChanceFieldNumber = new Google.Protobuf.MessageParser<DAILYALERTS>(factory:  new System.Func<DAILYALERTS>(object:  CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.<>c.<>9, method:  DAILYALERTS CONFIG_DATA.Types.ENTRY.Types.DAILYALERTS.<>c::<.cctor>b__30_0()));
    }

}
