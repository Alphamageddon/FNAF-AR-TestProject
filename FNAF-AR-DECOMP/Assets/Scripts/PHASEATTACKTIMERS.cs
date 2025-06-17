using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int StealthFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH stealth_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpottedFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED spotted_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FizzlePreVisibleFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE fizzlePreVisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FizzleVisibleFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE fizzleVisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TimeToJumpscareFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE timeToJumpscare_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int InvisibleFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE invisible_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CloakedFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED cloaked_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DecloakedFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED decloaked_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH Stealth { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED Spotted { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE FizzlePreVisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE FizzleVisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE TimeToJumpscare { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE Invisible { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED Cloaked { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED Decloaked { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHASEATTACKTIMERS>)ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.DecloakedFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ANIMATRONIC_DATA.Descriptor.NestedTypes.Item[9];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS other)
    {
        SPOTTED val_10;
        FIZZLEPREVISIBLE val_11;
        FIZZLEVISIBLE val_12;
        TIMETOJUMPSCARE val_13;
        INVISIBLE val_14;
        CLOAKED val_15;
        DECLOAKED val_16;
        if(other.stealth_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        this.stealth_ = other.stealth_.Clone();
        val_10 = other.spotted_;
        this.spotted_ = val_10.Clone();
        val_11 = other.fizzlePreVisible_;
        this.fizzlePreVisible_ = val_11.Clone();
        val_12 = other.fizzleVisible_;
        this.fizzleVisible_ = val_12.Clone();
        val_13 = other.timeToJumpscare_;
        this.timeToJumpscare_ = val_13.Clone();
        val_14 = other.invisible_;
        this.invisible_ = val_14.Clone();
        val_15 = other.cloaked_;
        this.cloaked_ = val_15.Clone();
        val_16 = other.decloaked_;
        this.decloaked_ = val_16.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS Clone()
    {
        return (PHASEATTACKTIMERS)new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH get_Stealth()
    {
        return (STEALTH)this.stealth_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Stealth(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH value)
    {
        this.stealth_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED get_Spotted()
    {
        return (SPOTTED)this.spotted_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Spotted(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED value)
    {
        this.spotted_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE get_FizzlePreVisible()
    {
        return (FIZZLEPREVISIBLE)this.fizzlePreVisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FizzlePreVisible(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE value)
    {
        this.fizzlePreVisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE get_FizzleVisible()
    {
        return (FIZZLEVISIBLE)this.fizzleVisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FizzleVisible(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE value)
    {
        this.fizzleVisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE get_TimeToJumpscare()
    {
        return (TIMETOJUMPSCARE)this.timeToJumpscare_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TimeToJumpscare(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE value)
    {
        this.timeToJumpscare_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE get_Invisible()
    {
        return (INVISIBLE)this.invisible_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Invisible(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE value)
    {
        this.invisible_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED get_Cloaked()
    {
        return (CLOAKED)this.cloaked_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Cloaked(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED value)
    {
        this.cloaked_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED get_Decloaked()
    {
        return (DECLOAKED)this.decloaked_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Decloaked(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED value)
    {
        this.decloaked_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHASEATTACKTIMERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS other)
    {
        var val_9;
        if(other == null)
        {
            goto label_9;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((((((((System.Object.Equals(objA:  this.stealth_, objB:  other.stealth_)) != false) && ((System.Object.Equals(objA:  this.spotted_, objB:  other.spotted_)) != false)) && ((System.Object.Equals(objA:  this.fizzlePreVisible_, objB:  other.fizzlePreVisible_)) != false)) && ((System.Object.Equals(objA:  this.fizzleVisible_, objB:  other.fizzleVisible_)) != false)) && ((System.Object.Equals(objA:  this.timeToJumpscare_, objB:  other.timeToJumpscare_)) != false)) && ((System.Object.Equals(objA:  this.invisible_, objB:  other.invisible_)) != false)) && ((System.Object.Equals(objA:  this.cloaked_, objB:  other.cloaked_)) != false))
        {
                if((System.Object.Equals(objA:  this.decloaked_, objB:  other.decloaked_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_9:
        val_9 = 0;
        return (bool)val_9;
        label_1:
        val_9 = 1;
        return (bool)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.stealth_ != null)
        {
                val_3 = this.stealth_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.spotted_ != null)
        {
                val_3 = this.spotted_ ^ val_3;
        }
        
        if(this.fizzlePreVisible_ != null)
        {
                val_3 = this.fizzlePreVisible_ ^ val_3;
        }
        
        if(this.fizzleVisible_ != null)
        {
                val_3 = this.fizzleVisible_ ^ val_3;
        }
        
        if(this.timeToJumpscare_ != null)
        {
                val_3 = this.timeToJumpscare_ ^ val_3;
        }
        
        if(this.invisible_ != null)
        {
                val_3 = this.invisible_ ^ val_3;
        }
        
        if(this.cloaked_ != null)
        {
                val_3 = this.cloaked_ ^ val_3;
        }
        
        if(this.decloaked_ != null)
        {
                val_3 = this.decloaked_ ^ val_3;
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
        STEALTH val_1;
        SPOTTED val_2;
        FIZZLEPREVISIBLE val_3;
        FIZZLEVISIBLE val_4;
        TIMETOJUMPSCARE val_5;
        INVISIBLE val_6;
        CLOAKED val_7;
        DECLOAKED val_8;
        if(this.stealth_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.stealth_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.stealth_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.spotted_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.spotted_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.spotted_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.fizzlePreVisible_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.fizzlePreVisible_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.fizzlePreVisible_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.fizzleVisible_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.fizzleVisible_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.fizzleVisible_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.timeToJumpscare_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.timeToJumpscare_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.timeToJumpscare_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.invisible_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.invisible_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.invisible_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.cloaked_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_7 = this.cloaked_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_7 = this.cloaked_;
        }
        
            output.WriteMessage(value:  val_7);
        }
        
        if(this.decloaked_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_8 = this.decloaked_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_8 = this.decloaked_;
        }
        
            output.WriteMessage(value:  val_8);
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
        STEALTH val_17 = this.stealth_;
        if(val_17 != null)
        {
                val_17 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_17 = this.stealth_)) + 1;
        }
        
        if(this.spotted_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.spotted_))) + 1;
        }
        
        if(this.fizzlePreVisible_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.fizzlePreVisible_))) + 1;
        }
        
        if(this.fizzleVisible_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.fizzleVisible_))) + 1;
        }
        
        if(this.timeToJumpscare_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.timeToJumpscare_))) + 1;
        }
        
        if(this.invisible_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.invisible_))) + 1;
        }
        
        if(this.cloaked_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cloaked_))) + 1;
        }
        
        if(this.decloaked_ != null)
        {
                val_17 = (val_17 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.decloaked_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_17;
        }
        
        val_17 = this._unknownFields.CalculateSize() + val_17;
        return (int)val_17;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS other)
    {
        DECLOAKED val_10;
        STEALTH val_11;
        STEALTH val_12;
        SPOTTED val_13;
        SPOTTED val_14;
        FIZZLEPREVISIBLE val_15;
        FIZZLEPREVISIBLE val_16;
        FIZZLEVISIBLE val_17;
        FIZZLEVISIBLE val_18;
        TIMETOJUMPSCARE val_19;
        TIMETOJUMPSCARE val_20;
        INVISIBLE val_21;
        INVISIBLE val_22;
        CLOAKED val_23;
        CLOAKED val_24;
        DECLOAKED val_25;
        if(other == null)
        {
                return;
        }
        
        val_11 = other.stealth_;
        if(val_11 != null)
        {
                val_12 = this.stealth_;
            if(val_12 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH val_1 = null;
            val_12 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH();
            this.stealth_ = val_12;
            val_11 = other.stealth_;
        }
        
            val_1.MergeFrom(other:  val_11);
        }
        
        val_13 = other.spotted_;
        if(val_13 != null)
        {
                val_14 = this.spotted_;
            if(val_14 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED val_2 = null;
            val_14 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED();
            this.spotted_ = val_14;
            val_13 = other.spotted_;
        }
        
            val_2.MergeFrom(other:  val_13);
        }
        
        val_15 = other.fizzlePreVisible_;
        if(val_15 != null)
        {
                val_16 = this.fizzlePreVisible_;
            if(val_16 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE val_3 = null;
            val_16 = val_3;
            val_3 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE();
            this.fizzlePreVisible_ = val_16;
            val_15 = other.fizzlePreVisible_;
        }
        
            val_3.MergeFrom(other:  val_15);
        }
        
        val_17 = other.fizzleVisible_;
        if(val_17 != null)
        {
                val_18 = this.fizzleVisible_;
            if(val_18 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE val_4 = null;
            val_18 = val_4;
            val_4 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE();
            this.fizzleVisible_ = val_18;
            val_17 = other.fizzleVisible_;
        }
        
            val_4.MergeFrom(other:  val_17);
        }
        
        val_19 = other.timeToJumpscare_;
        if(val_19 != null)
        {
                val_20 = this.timeToJumpscare_;
            if(val_20 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE val_5 = null;
            val_20 = val_5;
            val_5 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE();
            this.timeToJumpscare_ = val_20;
            val_19 = other.timeToJumpscare_;
        }
        
            val_5.MergeFrom(other:  val_19);
        }
        
        val_21 = other.invisible_;
        if(val_21 != null)
        {
                val_22 = this.invisible_;
            if(val_22 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE val_6 = null;
            val_22 = val_6;
            val_6 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE();
            this.invisible_ = val_22;
            val_21 = other.invisible_;
        }
        
            val_6.MergeFrom(other:  val_21);
        }
        
        val_23 = other.cloaked_;
        if(val_23 != null)
        {
                val_24 = this.cloaked_;
            if(val_24 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED val_7 = null;
            val_24 = val_7;
            val_7 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED();
            this.cloaked_ = val_24;
            val_23 = other.cloaked_;
        }
        
            val_7.MergeFrom(other:  val_23);
        }
        
        val_10 = other.decloaked_;
        if(val_10 != null)
        {
                val_25 = this.decloaked_;
            if(val_25 == null)
        {
                ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED val_8 = null;
            val_25 = val_8;
            val_8 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED();
            this.decloaked_ = val_25;
            val_10 = other.decloaked_;
        }
        
            val_8.MergeFrom(other:  val_10);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SPOTTED val_11;
        goto label_37;
        label_41:
        if(35311 > 34)
        {
            goto label_2;
        }
        
        if(35311 > 18)
        {
            goto label_3;
        }
        
        if(35311 == 10)
        {
            goto label_4;
        }
        
        if(35311 != 18)
        {
            goto label_21;
        }
        
        val_11 = this.spotted_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED val_1 = null;
        val_11 = val_1;
        val_1 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.SPOTTED();
        this.spotted_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_2:
        if(35311 > 50)
        {
            goto label_9;
        }
        
        if(35311 == 42)
        {
            goto label_10;
        }
        
        if(35311 != 50)
        {
            goto label_21;
        }
        
        val_11 = this.invisible_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE val_2 = null;
        val_11 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.INVISIBLE();
        this.invisible_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_3:
        if(35311 == 26)
        {
            goto label_15;
        }
        
        if(35311 != 34)
        {
            goto label_21;
        }
        
        val_11 = this.fizzleVisible_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE val_3 = null;
        val_11 = val_3;
        val_3 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEVISIBLE();
        this.fizzleVisible_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_9:
        if(35311 == 58)
        {
            goto label_20;
        }
        
        if(35311 != 66)
        {
            goto label_21;
        }
        
        val_11 = this.decloaked_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED val_4 = null;
        val_11 = val_4;
        val_4 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.DECLOAKED();
        this.decloaked_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_21:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_37;
        label_4:
        val_11 = this.stealth_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH val_6 = null;
        val_11 = val_6;
        val_6 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.STEALTH();
        this.stealth_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_10:
        val_11 = this.timeToJumpscare_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE val_7 = null;
        val_11 = val_7;
        val_7 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.TIMETOJUMPSCARE();
        this.timeToJumpscare_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_15:
        val_11 = this.fizzlePreVisible_;
        if(val_11 != null)
        {
            goto label_32;
        }
        
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE val_8 = null;
        val_11 = val_8;
        val_8 = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.FIZZLEPREVISIBLE();
        this.fizzlePreVisible_ = val_11;
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_20:
        val_11 = this.cloaked_;
        if(val_11 == null)
        {
            goto label_35;
        }
        
        label_32:
        if(input != null)
        {
            goto label_38;
        }
        
        label_39:
        label_38:
        input.ReadMessage(builder:  val_11);
        goto label_37;
        label_35:
        this.cloaked_ = new ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.Types.CLOAKED();
        if(input != null)
        {
            goto label_38;
        }
        
        goto label_39;
        label_37:
        if(input.ReadTag() != 0)
        {
            goto label_41;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.DecloakedFieldNumber = new Google.Protobuf.MessageParser<PHASEATTACKTIMERS>(factory:  new System.Func<PHASEATTACKTIMERS>(object:  ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.<>c.<>9, method:  PHASEATTACKTIMERS ANIMATRONIC_DATA.Types.PHASEATTACKTIMERS.<>c::<.cctor>b__61_0()));
    }

}
