using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER : IMessage<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER>, IMessage, IEquatable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER>, IDeepCloneable<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsBonusFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double partsBonus_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StuffBonusFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double stuffBonus_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctionBonusFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double malfunctionBonus_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PartsBonus { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double StuffBonus { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MalfunctionBonus { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SALVAGESCANNER>)DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.MalfunctionBonusFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER other)
    {
        if(other != null)
        {
                this.partsBonus_ = other.partsBonus_;
            this.stuffBonus_ = other.stuffBonus_;
            this.malfunctionBonus_ = other.malfunctionBonus_;
        }
        else
        {
                this.partsBonus_ = 7.42422564692724E-317;
            this.stuffBonus_ = 3.16202013338398E-322;
            this.malfunctionBonus_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER Clone()
    {
        return (SALVAGESCANNER)new DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PartsBonus()
    {
        return (double)this.partsBonus_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PartsBonus(double value)
    {
        this.partsBonus_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_StuffBonus()
    {
        return (double)this.stuffBonus_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StuffBonus(double value)
    {
        this.stuffBonus_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MalfunctionBonus()
    {
        return (double)this.malfunctionBonus_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MalfunctionBonus(double value)
    {
        this.malfunctionBonus_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SALVAGESCANNER val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.partsBonus_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.stuffBonus_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.malfunctionBonus_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_14:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.partsBonus_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.stuffBonus_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.malfunctionBonus_ != 0f)
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
        double val_1;
        double val_2;
        double val_3;
        if(this.partsBonus_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.partsBonus_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.partsBonus_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.stuffBonus_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.stuffBonus_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.stuffBonus_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.malfunctionBonus_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.malfunctionBonus_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.malfunctionBonus_;
        }
        
            output.WriteDouble(value:  val_3);
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
        var val_1 = (this.partsBonus_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.stuffBonus_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.malfunctionBonus_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.partsBonus_ != 0f)
        {
                this.partsBonus_ = other.partsBonus_;
        }
        
        if(other.stuffBonus_ != 0f)
        {
                this.stuffBonus_ = other.stuffBonus_;
        }
        
        if(other.malfunctionBonus_ != 0f)
        {
                this.malfunctionBonus_ = other.malfunctionBonus_;
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
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.malfunctionBonus_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.partsBonus_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.stuffBonus_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER()
    {
        null = null;
        DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.MalfunctionBonusFieldNumber = new Google.Protobuf.MessageParser<SALVAGESCANNER>(factory:  new System.Func<SALVAGESCANNER>(object:  DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.<>c.<>9, method:  SALVAGESCANNER DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.SALVAGESCANNER.<>c::<.cctor>b__35_0()));
    }

}
