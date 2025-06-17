using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChanceToChargeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chanceToCharge_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ChanceIncreaseFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double chanceIncrease_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ChanceToCharge { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ChanceIncrease { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PAUSEPARAMETERS>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.ChanceIncreaseFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS other)
    {
        if(other.seconds_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.seconds_ = other.seconds_.Clone();
        this.chanceToCharge_ = other.chanceToCharge_;
        this.chanceIncrease_ = other.chanceIncrease_;
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
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS Clone()
    {
        return (PAUSEPARAMETERS)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS get_Seconds()
    {
        return (SECONDS)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ChanceToCharge()
    {
        return (double)this.chanceToCharge_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChanceToCharge(double value)
    {
        this.chanceToCharge_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ChanceIncrease()
    {
        return (double)this.chanceIncrease_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ChanceIncrease(double value)
    {
        this.chanceIncrease_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PAUSEPARAMETERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_11;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false)
        {
                val_5 = this.chanceToCharge_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.chanceIncrease_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_11:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.seconds_ != null)
        {
                val_5 = this.seconds_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.chanceToCharge_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.chanceIncrease_ != 0f)
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
        SECONDS val_1;
        double val_2;
        double val_3;
        if(this.seconds_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.chanceToCharge_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.chanceToCharge_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.chanceToCharge_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.chanceIncrease_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.chanceIncrease_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.chanceIncrease_;
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
        var val_6;
        var val_7;
        if(this.seconds_ != null)
        {
                val_6 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.seconds_)) + 1;
        }
        else
        {
                val_6 = 0;
        }
        
        var val_2 = val_6 + 9;
        val_6 = (this.chanceToCharge_ == 0f) ? (val_6) : (val_2);
        val_2 = val_6 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + ((this.chanceIncrease_ == 0f) ? (val_6) : (val_2));
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS other)
    {
        SECONDS val_3;
        SECONDS val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.seconds_;
        if(val_3 != null)
        {
                val_4 = this.seconds_;
            if(val_4 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS val_1 = null;
            val_4 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS();
            this.seconds_ = val_4;
            val_3 = other.seconds_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        if(other.chanceToCharge_ != 0f)
        {
                this.chanceToCharge_ = other.chanceToCharge_;
        }
        
        if(other.chanceIncrease_ != 0f)
        {
                this.chanceIncrease_ = other.chanceIncrease_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SECONDS val_6;
        goto label_16;
        label_17:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_16;
        label_12:
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS val_2 = null;
        val_6 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.Types.SECONDS();
        this.seconds_ = val_6;
        if(input != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_16:
        uint val_3 = input.ReadTag();
        if(val_3 <= 16)
        {
            goto label_6;
        }
        
        if(val_3 == 17)
        {
            goto label_7;
        }
        
        if(val_3 != 25)
        {
            goto label_17;
        }
        
        this.chanceIncrease_ = input.ReadDouble();
        goto label_16;
        label_6:
        if(val_3 != 10)
        {
            goto label_11;
        }
        
        val_6 = this.seconds_;
        if(val_6 == null)
        {
            goto label_12;
        }
        
        label_4:
        input.ReadMessage(builder:  val_6);
        goto label_16;
        label_7:
        this.chanceToCharge_ = input.ReadDouble();
        goto label_16;
        label_11:
        if(val_3 != 0)
        {
            goto label_17;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.ChanceIncreaseFieldNumber = new Google.Protobuf.MessageParser<PAUSEPARAMETERS>(factory:  new System.Func<PAUSEPARAMETERS>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.<>c.<>9, method:  PAUSEPARAMETERS ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.PAUSEPARAMETERS.<>c::<.cctor>b__36_0()));
    }

}
