using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT : IMessage<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SelfFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF self_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int OtherFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER other_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF Self { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER Other { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<REWARDONSKILLSHOT>)ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.OtherFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.FAZTOKENS.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT other)
    {
        OTHER val_4;
        if(other.self_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.self_ = other.self_.Clone();
        val_4 = other.other_;
        this.other_ = val_4.Clone();
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
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT Clone()
    {
        return (REWARDONSKILLSHOT)new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF get_Self()
    {
        return (SELF)this.self_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Self(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF value)
    {
        this.self_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER get_Other()
    {
        return (OTHER)this.other_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Other(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER value)
    {
        this.other_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        REWARDONSKILLSHOT val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT other)
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
        
        if((System.Object.Equals(objA:  this.self_, objB:  other.self_)) != false)
        {
                if((System.Object.Equals(objA:  this.other_, objB:  other.other_)) != false)
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
        if(this.self_ != null)
        {
                val_3 = this.self_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.other_ != null)
        {
                val_3 = this.other_ ^ val_3;
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
        SELF val_1;
        OTHER val_2;
        if(this.self_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.self_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.self_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.other_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.other_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.other_;
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
        SELF val_5 = this.self_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.self_)) + 1;
        }
        
        if(this.other_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.other_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT other)
    {
        OTHER val_4;
        SELF val_5;
        SELF val_6;
        OTHER val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.self_;
        if(val_5 != null)
        {
                val_6 = this.self_;
            if(val_6 == null)
        {
                ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF val_1 = null;
            val_6 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF();
            this.self_ = val_6;
            val_5 = other.self_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.other_;
        if(val_4 != null)
        {
                val_7 = this.other_;
            if(val_7 == null)
        {
                ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER val_2 = null;
            val_7 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER();
            this.other_ = val_7;
            val_4 = other.other_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SELF val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.self_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF val_2 = null;
        val_5 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.SELF();
        this.self_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.other_;
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
        this.other_ = new ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.Types.OTHER();
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
    private static ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT()
    {
        null = null;
        ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.OtherFieldNumber = new Google.Protobuf.MessageParser<REWARDONSKILLSHOT>(factory:  new System.Func<REWARDONSKILLSHOT>(object:  ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.<>c.<>9, method:  REWARDONSKILLSHOT ANIMATRONIC_DATA.Types.FAZTOKENS.Types.REWARDONSKILLSHOT.<>c::<.cctor>b__31_0()));
    }

}
