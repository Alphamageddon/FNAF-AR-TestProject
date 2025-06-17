using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.MTXSECTION : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int HardCurrencyCostFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double hardCurrencyCost_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StackableFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool stackable_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinStreakFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double minStreak_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double HardCurrencyCost { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Stackable { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MinStreak { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<MTXSECTION>)DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.MinStreakFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.MTXSECTION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.MTXSECTION(ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION other)
    {
        if(other != null)
        {
                this.hardCurrencyCost_ = other.hardCurrencyCost_;
            this.stackable_ = other.stackable_;
            this.minStreak_ = other.minStreak_;
        }
        else
        {
                this.hardCurrencyCost_ = 7.42422564692724E-317;
            this.stackable_ = false;
            this.minStreak_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION Clone()
    {
        return (MTXSECTION)new DEVICES_DATA.Types.ENTRY.Types.MTXSECTION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_HardCurrencyCost()
    {
        return (double)this.hardCurrencyCost_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_HardCurrencyCost(double value)
    {
        this.hardCurrencyCost_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Stackable()
    {
        return (bool)this.stackable_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Stackable(bool value)
    {
        this.stackable_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MinStreak()
    {
        return (double)this.minStreak_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MinStreak(double value)
    {
        this.minStreak_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        MTXSECTION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION other)
    {
        var val_5;
        double val_6;
        var val_7;
        if(other == null)
        {
            goto label_11;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_6 = this.hardCurrencyCost_;
        val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_5 & 1) != 0)
        {
                var val_2 = (this.stackable_ == true) ? 1 : 0;
            val_2 = val_2 ^ ((other.stackable_ == true) ? 1 : 0);
            if((val_2 & 1) == 0)
        {
                val_6 = this.minStreak_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_11:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.hardCurrencyCost_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.stackable_ != false)
        {
                val_5 = 0;
            val_4 = 1.GetHashCode() ^ val_4;
        }
        
        if(this.minStreak_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        double val_2;
        bool val_3;
        double val_4;
        if(this.hardCurrencyCost_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.hardCurrencyCost_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.hardCurrencyCost_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.stackable_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_3 = this.stackable_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_3 = this.stackable_;
        }
        
            output.WriteBool(value:  (val_3 == true) ? 1 : 0);
        }
        
        if(this.minStreak_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_4 = this.minStreak_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_4 = this.minStreak_;
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
        var val_1 = (this.hardCurrencyCost_ == 0f) ? 0 : 9;
        var val_2 = val_1 | 2;
        val_1 = (this.stackable_ == true) ? (val_2) : (val_1);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.minStreak_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.MTXSECTION other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.hardCurrencyCost_ != 0f)
        {
                this.hardCurrencyCost_ = other.hardCurrencyCost_;
        }
        
        if(other.stackable_ != false)
        {
                this.stackable_ = other.stackable_;
        }
        
        if(other.minStreak_ != 0f)
        {
                this.minStreak_ = other.minStreak_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 15)
        {
            goto label_2;
        }
        
        if(val_2 == 16)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.minStreak_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.hardCurrencyCost_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.stackable_ = input.ReadBool();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.MTXSECTION()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.MinStreakFieldNumber = new Google.Protobuf.MessageParser<MTXSECTION>(factory:  new System.Func<MTXSECTION>(object:  DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.<>c.<>9, method:  MTXSECTION DEVICES_DATA.Types.ENTRY.Types.MTXSECTION.<>c::<.cctor>b__35_0()));
    }

}
