using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE : IMessage<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int NotUpgradedFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED notUpgraded_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade1FieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 upgrade1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Upgrade2FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 upgrade2_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED NotUpgraded { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 Upgrade1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 Upgrade2 { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FIZZLEPREVISIBLE>)ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Upgrade2FieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE other)
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
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE Clone()
    {
        return (FIZZLEPREVISIBLE)new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED get_NotUpgraded()
    {
        return (NOTUPGRADED)this.notUpgraded_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_NotUpgraded(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED value)
    {
        this.notUpgraded_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 get_Upgrade1()
    {
        return (UPGRADE1)this.upgrade1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade1(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 value)
    {
        this.upgrade1_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 get_Upgrade2()
    {
        return (UPGRADE2)this.upgrade2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Upgrade2(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 value)
    {
        this.upgrade2_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FIZZLEPREVISIBLE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE other)
    {
        var val_4;
        if(other == null)
        {
            goto label_4;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((System.Object.Equals(objA:  this.notUpgraded_, objB:  other.notUpgraded_)) != false) && ((System.Object.Equals(objA:  this.upgrade1_, objB:  other.upgrade1_)) != false))
        {
                if((System.Object.Equals(objA:  this.upgrade2_, objB:  other.upgrade2_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_4:
        val_4 = 0;
        return (bool)val_4;
        label_1:
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.notUpgraded_ != null)
        {
                val_3 = this.notUpgraded_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.upgrade1_ != null)
        {
                val_3 = this.upgrade1_ ^ val_3;
        }
        
        if(this.upgrade2_ != null)
        {
                val_3 = this.upgrade2_ ^ val_3;
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
        NOTUPGRADED val_1;
        UPGRADE1 val_2;
        UPGRADE2 val_3;
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
        
        if(this._unknownFields == null)
        {
                return;
        }
        
        this._unknownFields.WriteTo(output:  output);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CalculateSize()
    {
        NOTUPGRADED val_7 = this.notUpgraded_;
        if(val_7 != null)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_7 = this.notUpgraded_)) + 1;
        }
        
        if(this.upgrade1_ != null)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.upgrade1_))) + 1;
        }
        
        if(this.upgrade2_ != null)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.upgrade2_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE other)
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
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED val_1 = null;
            val_7 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED();
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
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 val_2 = null;
            val_9 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1();
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
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 val_3 = null;
            val_10 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2();
            this.upgrade2_ = val_10;
            val_5 = other.upgrade2_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        UPGRADE1 val_6;
        goto label_18;
        label_19:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_16:
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1 val_2 = null;
        val_6 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE1();
        this.upgrade1_ = val_6;
        if(input != null)
        {
            goto label_17;
        }
        
        goto label_15;
        label_18:
        uint val_3 = input.ReadTag();
        if(val_3 <= 17)
        {
            goto label_6;
        }
        
        if(val_3 == 18)
        {
            goto label_7;
        }
        
        if(val_3 != 26)
        {
            goto label_19;
        }
        
        val_6 = this.upgrade2_;
        if(val_6 != null)
        {
            goto label_13;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2 val_4 = null;
        val_6 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.UPGRADE2();
        this.upgrade2_ = val_6;
        if(input != null)
        {
            goto label_17;
        }
        
        goto label_15;
        label_6:
        if(val_3 != 10)
        {
            goto label_12;
        }
        
        val_6 = this.notUpgraded_;
        if(val_6 != null)
        {
            goto label_13;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED val_5 = null;
        val_6 = val_5;
        val_5 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Types.NOTUPGRADED();
        this.notUpgraded_ = val_6;
        if(input != null)
        {
            goto label_17;
        }
        
        goto label_15;
        label_7:
        val_6 = this.upgrade1_;
        if(val_6 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(input != null)
        {
            goto label_17;
        }
        
        label_15:
        label_17:
        input.ReadMessage(builder:  val_6);
        goto label_18;
        label_12:
        if(val_3 != 0)
        {
            goto label_19;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE()
    {
        null = null;
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.Upgrade2FieldNumber = new Google.Protobuf.MessageParser<FIZZLEPREVISIBLE>(factory:  new System.Func<FIZZLEPREVISIBLE>(object:  ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.<>c.<>9, method:  FIZZLEPREVISIBLE ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE.<>c::<.cctor>b__36_0()));
    }

}
