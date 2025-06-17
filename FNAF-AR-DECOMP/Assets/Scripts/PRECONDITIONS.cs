using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionAnimatronicCheckPhaseFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONANIMATRONICCHECKPHASE preconditionAnimatronicCheckPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionPassiveCheckPhaseFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONPASSIVECHECKPHASE preconditionPassiveCheckPhase_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionWeightFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double preconditionWeight_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PreconditionRequirementsFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS preconditionRequirements_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONANIMATRONICCHECKPHASE PreconditionAnimatronicCheckPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONPASSIVECHECKPHASE PreconditionPassiveCheckPhase { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PreconditionWeight { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS PreconditionRequirements { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PRECONDITIONS>)ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.PreconditionRequirementsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS other)
    {
        PRECONDITIONREQUIREMENTS val_3;
        if(other != null)
        {
                this.preconditionAnimatronicCheckPhase_ = other.preconditionAnimatronicCheckPhase_;
            this.preconditionPassiveCheckPhase_ = other.preconditionPassiveCheckPhase_;
            this.preconditionWeight_ = other.preconditionWeight_;
        }
        else
        {
                this.preconditionAnimatronicCheckPhase_ = 15026800;
            this.preconditionPassiveCheckPhase_ = 0;
            this.preconditionWeight_ = 3.16202013338398E-322;
        }
        
        val_3 = other.preconditionRequirements_;
        this.preconditionRequirements_ = val_3.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS Clone()
    {
        return (PRECONDITIONS)new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONANIMATRONICCHECKPHASE get_PreconditionAnimatronicCheckPhase()
    {
        return (PRECONDITIONANIMATRONICCHECKPHASE)this.preconditionAnimatronicCheckPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionAnimatronicCheckPhase(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONANIMATRONICCHECKPHASE value)
    {
        this.preconditionAnimatronicCheckPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONPASSIVECHECKPHASE get_PreconditionPassiveCheckPhase()
    {
        return (PRECONDITIONPASSIVECHECKPHASE)this.preconditionPassiveCheckPhase_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionPassiveCheckPhase(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONPASSIVECHECKPHASE value)
    {
        this.preconditionPassiveCheckPhase_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PreconditionWeight()
    {
        return (double)this.preconditionWeight_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionWeight(double value)
    {
        this.preconditionWeight_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS get_PreconditionRequirements()
    {
        return (PRECONDITIONREQUIREMENTS)this.preconditionRequirements_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreconditionRequirements(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS value)
    {
        this.preconditionRequirements_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PRECONDITIONS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS other)
    {
        var val_3;
        if(other == null)
        {
            goto label_9;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if(((this.preconditionAnimatronicCheckPhase_ == other.preconditionAnimatronicCheckPhase_) && (this.preconditionPassiveCheckPhase_ == other.preconditionPassiveCheckPhase_)) && ((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0))
        {
                if((System.Object.Equals(objA:  this.preconditionRequirements_, objB:  other.preconditionRequirements_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_9:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        var val_6;
        if(this.preconditionAnimatronicCheckPhase_ != 0)
        {
                val_5 = 0;
            val_6 = this.preconditionAnimatronicCheckPhase_.region ^ 1;
        }
        else
        {
                val_6 = 1;
        }
        
        if(this.preconditionPassiveCheckPhase_ != 0)
        {
                val_5 = 0;
            val_6 = this.preconditionPassiveCheckPhase_.region ^ val_6;
        }
        
        if(this.preconditionWeight_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.preconditionRequirements_ != null)
        {
                val_6 = this.preconditionRequirements_ ^ val_6;
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
        PRECONDITIONANIMATRONICCHECKPHASE val_1;
        PRECONDITIONPASSIVECHECKPHASE val_2;
        double val_3;
        PRECONDITIONREQUIREMENTS val_4;
        if(this.preconditionAnimatronicCheckPhase_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_1 = this.preconditionAnimatronicCheckPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_1 = this.preconditionAnimatronicCheckPhase_;
        }
        
            output.WriteEnum(value:  val_1);
        }
        
        if(this.preconditionPassiveCheckPhase_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_2 = this.preconditionPassiveCheckPhase_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_2 = this.preconditionPassiveCheckPhase_;
        }
        
            output.WriteEnum(value:  val_2);
        }
        
        if(this.preconditionWeight_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.preconditionWeight_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.preconditionWeight_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.preconditionRequirements_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.preconditionRequirements_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.preconditionRequirements_;
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
        var val_8;
        var val_9;
        if(this.preconditionAnimatronicCheckPhase_ != 0)
        {
                val_8 = (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  this.preconditionAnimatronicCheckPhase_)) + 1;
        }
        else
        {
                val_8 = 0;
        }
        
        PRECONDITIONPASSIVECHECKPHASE val_7 = this.preconditionPassiveCheckPhase_;
        if(val_7 != 0)
        {
                int val_3 = val_8 + (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  val_7));
            val_8 = val_3 + 1;
        }
        
        val_3 = val_8 + 9;
        val_7 = (this.preconditionWeight_ == 0f) ? (val_8) : (val_3);
        if(this.preconditionRequirements_ != null)
        {
                val_9 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.preconditionRequirements_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS other)
    {
        PRECONDITIONREQUIREMENTS val_3;
        PRECONDITIONREQUIREMENTS val_4;
        if(other == null)
        {
                return;
        }
        
        if(other.preconditionAnimatronicCheckPhase_ != 0)
        {
                this.preconditionAnimatronicCheckPhase_ = other.preconditionAnimatronicCheckPhase_;
        }
        
        if(other.preconditionPassiveCheckPhase_ != 0)
        {
                this.preconditionPassiveCheckPhase_ = other.preconditionPassiveCheckPhase_;
        }
        
        if(other.preconditionWeight_ != 0f)
        {
                this.preconditionWeight_ = other.preconditionWeight_;
        }
        
        val_3 = other.preconditionRequirements_;
        if(val_3 != null)
        {
                val_4 = this.preconditionRequirements_;
            if(val_4 == null)
        {
                ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS val_1 = null;
            val_4 = val_1;
            val_1 = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS();
            this.preconditionRequirements_ = val_4;
            val_3 = other.preconditionRequirements_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_16;
        label_20:
        if(35491 > 16)
        {
            goto label_2;
        }
        
        if(35491 == 8)
        {
            goto label_3;
        }
        
        if(35491 != 16)
        {
            goto label_8;
        }
        
        this.preconditionPassiveCheckPhase_ = input.ReadEnum();
        goto label_16;
        label_2:
        if(35491 == 25)
        {
            goto label_7;
        }
        
        if(35491 != 34)
        {
            goto label_8;
        }
        
        if(this.preconditionRequirements_ == null)
        {
            goto label_9;
        }
        
        label_18:
        input.ReadMessage(builder:  this.preconditionRequirements_);
        goto label_16;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_16;
        label_3:
        this.preconditionAnimatronicCheckPhase_ = input.ReadEnum();
        goto label_16;
        label_7:
        this.preconditionWeight_ = input.ReadDouble();
        goto label_16;
        label_9:
        this.preconditionRequirements_ = new ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.Types.PRECONDITIONREQUIREMENTS();
        if(input != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_16:
        if(input.ReadTag() != 0)
        {
            goto label_20;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.PreconditionRequirementsFieldNumber = new Google.Protobuf.MessageParser<PRECONDITIONS>(factory:  new System.Func<PRECONDITIONS>(object:  ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.<>c.<>9, method:  PRECONDITIONS ALERT_DATA.Types.ENTRY.Types.PRECONDITIONS.<>c::<.cctor>b__41_0()));
    }

}
