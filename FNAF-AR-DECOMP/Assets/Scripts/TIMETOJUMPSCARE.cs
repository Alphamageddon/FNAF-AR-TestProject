using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE : IMessage<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NotUpgradedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED notUpgraded_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade1FieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 upgrade1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade2FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2 upgrade2_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MinFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double min_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaxFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double max_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED NotUpgraded { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 Upgrade1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2 Upgrade2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Min { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Max { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<TIMETOJUMPSCARE>)ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.MaxFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Descriptor.NestedTypes.Item[4];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE other)
    {
        UPGRADE1 val_5;
        UPGRADE2 val_6;
        if(other.notUpgraded_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.notUpgraded_ = other.notUpgraded_.Clone();
        val_5 = other.upgrade1_;
        this.upgrade1_ = val_5.Clone();
        val_6 = other.upgrade2_;
        this.upgrade2_ = val_6.Clone();
        this.min_ = other.min_;
        this.max_ = other.max_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE Clone()
    {
        return (TIMETOJUMPSCARE)new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED get_NotUpgraded()
    {
        return (NOTUPGRADED)this.notUpgraded_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NotUpgraded(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED value)
    {
        this.notUpgraded_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 get_Upgrade1()
    {
        return (UPGRADE1)this.upgrade1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade1(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 value)
    {
        this.upgrade1_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2 get_Upgrade2()
    {
        return (UPGRADE2)this.upgrade2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade2(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2 value)
    {
        this.upgrade2_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Min()
    {
        return (double)this.min_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Min(double value)
    {
        this.min_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Max()
    {
        return (double)this.max_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Max(double value)
    {
        this.max_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        TIMETOJUMPSCARE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE other)
    {
        var val_6;
        double val_7;
        var val_8;
        if(other == null)
        {
            goto label_13;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((System.Object.Equals(objA:  this.notUpgraded_, objB:  other.notUpgraded_)) != false) && ((System.Object.Equals(objA:  this.upgrade1_, objB:  other.upgrade1_)) != false)) && ((System.Object.Equals(objA:  this.upgrade2_, objB:  other.upgrade2_)) != false))
        {
                val_7 = this.min_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.max_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_13:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 1;
        return (bool)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.notUpgraded_ != null)
        {
                val_5 = this.notUpgraded_ ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.upgrade1_ != null)
        {
                val_5 = this.upgrade1_ ^ val_5;
        }
        
        if(this.upgrade2_ != null)
        {
                val_5 = this.upgrade2_ ^ val_5;
        }
        
        if(this.min_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.max_ != 0f)
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
        NOTUPGRADED val_1;
        UPGRADE1 val_2;
        UPGRADE2 val_3;
        double val_4;
        double val_5;
        if(this.notUpgraded_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.notUpgraded_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.notUpgraded_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.upgrade1_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.upgrade1_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.upgrade1_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.upgrade2_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.upgrade2_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.upgrade2_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.min_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.min_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.min_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.max_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.max_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.max_;
        }
        
            output.WriteDouble(value:  val_5);
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
        var val_11;
        var val_12;
        if(this.notUpgraded_ != null)
        {
                val_11 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.notUpgraded_)) + 1;
        }
        else
        {
                val_11 = 0;
        }
        
        if(this.upgrade1_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.upgrade1_))) + 1;
        }
        
        if(this.upgrade2_ != null)
        {
                int val_5 = val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.upgrade2_));
            val_11 = val_5 + 1;
        }
        
        val_5 = val_11 + 9;
        var val_6 = (this.min_ == 0f) ? (val_11) : (val_5);
        if(this._unknownFields == null)
        {
                return (int)val_12;
        }
        
        val_12 = this._unknownFields.CalculateSize() + ((this.max_ == 0f) ? (val_6) : (val_6 + 9));
        return (int)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE other)
    {
        UPGRADE2 val_5;
        NOTUPGRADED val_6;
        NOTUPGRADED val_7;
        UPGRADE1 val_8;
        UPGRADE1 val_9;
        UPGRADE2 val_10;
        if(other == null)
        {
                return;
        }
        
        val_6 = other.notUpgraded_;
        if(val_6 != null)
        {
                val_7 = this.notUpgraded_;
            if(val_7 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED val_1 = null;
            val_7 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED();
            this.notUpgraded_ = val_7;
            val_6 = other.notUpgraded_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        val_8 = other.upgrade1_;
        if(val_8 != null)
        {
                val_9 = this.upgrade1_;
            if(val_9 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 val_2 = null;
            val_9 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1();
            this.upgrade1_ = val_9;
            val_8 = other.upgrade1_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        val_5 = other.upgrade2_;
        if(val_5 != null)
        {
                val_10 = this.upgrade2_;
            if(val_10 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2 val_3 = null;
            val_10 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2();
            this.upgrade2_ = val_10;
            val_5 = other.upgrade2_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        if(other.min_ != 0f)
        {
                this.min_ = other.min_;
        }
        
        if(other.max_ != 0f)
        {
                this.max_ = other.max_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        UPGRADE1 val_8;
        goto label_21;
        label_25:
        if(47011 > 18)
        {
            goto label_2;
        }
        
        if(47011 == 10)
        {
            goto label_3;
        }
        
        if(47011 != 18)
        {
            goto label_10;
        }
        
        val_8 = this.upgrade1_;
        if(val_8 != null)
        {
            goto label_14;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1 val_1 = null;
        val_8 = val_1;
        val_1 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE1();
        this.upgrade1_ = val_8;
        if(input != null)
        {
            goto label_22;
        }
        
        goto label_23;
        label_2:
        if(47011 == 26)
        {
            goto label_8;
        }
        
        if(47011 == 33)
        {
            goto label_9;
        }
        
        if(47011 != 41)
        {
            goto label_10;
        }
        
        this.max_ = input.ReadDouble();
        goto label_21;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_21;
        label_3:
        val_8 = this.notUpgraded_;
        if(val_8 != null)
        {
            goto label_14;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED val_4 = null;
        val_8 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.NOTUPGRADED();
        this.notUpgraded_ = val_8;
        if(input != null)
        {
            goto label_22;
        }
        
        goto label_23;
        label_9:
        this.min_ = input.ReadDouble();
        goto label_21;
        label_8:
        val_8 = this.upgrade2_;
        if(val_8 == null)
        {
            goto label_19;
        }
        
        label_14:
        if(input != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        input.ReadMessage(builder:  val_8);
        goto label_21;
        label_19:
        this.upgrade2_ = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.Types.UPGRADE2();
        if(input != null)
        {
            goto label_22;
        }
        
        goto label_23;
        label_21:
        if(input.ReadTag() != 0)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE()
    {
        null = null;
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.MaxFieldNumber = new Google.Protobuf.MessageParser<TIMETOJUMPSCARE>(factory:  new System.Func<TIMETOJUMPSCARE>(object:  ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.<>c.<>9, method:  TIMETOJUMPSCARE ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE.<>c::<.cctor>b__46_0()));
    }

}
