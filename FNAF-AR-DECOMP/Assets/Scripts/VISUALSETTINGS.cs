using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.VISUALSETTINGS : IMessage<ProtoData.CPU_DATA.Types.VISUALSETTINGS>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.VISUALSETTINGS>, IDeepCloneable<ProtoData.CPU_DATA.Types.VISUALSETTINGS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ConditionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double condition_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AttackEyesFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR attackEyes_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LookAtEyesFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR lookAtEyes_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LookAwayEyesFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR lookAwayEyes_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Condition { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR AttackEyes { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR LookAtEyes { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR LookAwayEyes { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.VISUALSETTINGS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<VISUALSETTINGS>)CPU_DATA.Types.VISUALSETTINGS.LookAwayEyesFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[12];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.VISUALSETTINGS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.VISUALSETTINGS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.VISUALSETTINGS(ProtoData.CPU_DATA.Types.VISUALSETTINGS other)
    {
        EYECOLOR val_5;
        EYECOLOR val_6;
        EYECOLOR val_7;
        if(other != null)
        {
                this.condition_ = other.condition_;
        }
        else
        {
                this.condition_ = 7.42422564692724E-317;
        }
        
        val_5 = other.attackEyes_;
        this.attackEyes_ = val_5.Clone();
        val_6 = other.lookAtEyes_;
        this.lookAtEyes_ = val_6.Clone();
        val_7 = other.lookAwayEyes_;
        this.lookAwayEyes_ = val_7.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS Clone()
    {
        return (VISUALSETTINGS)new CPU_DATA.Types.VISUALSETTINGS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Condition()
    {
        return (double)this.condition_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Condition(double value)
    {
        this.condition_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR get_AttackEyes()
    {
        return (EYECOLOR)this.attackEyes_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AttackEyes(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR value)
    {
        this.attackEyes_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR get_LookAtEyes()
    {
        return (EYECOLOR)this.lookAtEyes_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LookAtEyes(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR value)
    {
        this.lookAtEyes_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR get_LookAwayEyes()
    {
        return (EYECOLOR)this.lookAwayEyes_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LookAwayEyes(ProtoData.CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR value)
    {
        this.lookAwayEyes_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        VISUALSETTINGS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.VISUALSETTINGS other)
    {
        var val_5;
        if(other == null)
        {
            goto label_9;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0) && ((System.Object.Equals(objA:  this.attackEyes_, objB:  other.attackEyes_)) != false)) && ((System.Object.Equals(objA:  this.lookAtEyes_, objB:  other.lookAtEyes_)) != false))
        {
                if((System.Object.Equals(objA:  this.lookAwayEyes_, objB:  other.lookAwayEyes_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_9:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        if(this.condition_ == 0f)
        {
                val_2 = 1;
        }
        else
        {
                val_2 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.attackEyes_ != null)
        {
                val_2 = this.attackEyes_ ^ val_2;
        }
        
        if(this.lookAtEyes_ != null)
        {
                val_2 = this.lookAtEyes_ ^ val_2;
        }
        
        if(this.lookAwayEyes_ != null)
        {
                val_2 = this.lookAwayEyes_ ^ val_2;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_2;
        }
        
        val_2 = this._unknownFields ^ val_2;
        return (int)val_2;
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
        EYECOLOR val_2;
        EYECOLOR val_3;
        EYECOLOR val_4;
        if(this.condition_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.condition_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.condition_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.attackEyes_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.attackEyes_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.attackEyes_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.lookAtEyes_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.lookAtEyes_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.lookAtEyes_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.lookAwayEyes_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.lookAwayEyes_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.lookAwayEyes_;
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
        var val_9;
        if(this.attackEyes_ != null)
        {
                val_9 = (((this.condition_ == 0f) ? 0 : 9) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.attackEyes_))) + 1;
        }
        
        if(this.lookAtEyes_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.lookAtEyes_))) + 1;
        }
        
        if(this.lookAwayEyes_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.lookAwayEyes_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_9;
        }
        
        val_9 = this._unknownFields.CalculateSize() + val_9;
        return (int)val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.VISUALSETTINGS other)
    {
        EYECOLOR val_5;
        EYECOLOR val_6;
        EYECOLOR val_7;
        EYECOLOR val_8;
        EYECOLOR val_9;
        EYECOLOR val_10;
        if(other == null)
        {
                return;
        }
        
        if(other.condition_ != 0f)
        {
                this.condition_ = other.condition_;
        }
        
        val_6 = other.attackEyes_;
        if(val_6 != null)
        {
                val_7 = this.attackEyes_;
            if(val_7 == null)
        {
                CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR val_1 = null;
            val_7 = val_1;
            val_1 = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
            this.attackEyes_ = val_7;
            val_6 = other.attackEyes_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        val_8 = other.lookAtEyes_;
        if(val_8 != null)
        {
                val_9 = this.lookAtEyes_;
            if(val_9 == null)
        {
                CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR val_2 = null;
            val_9 = val_2;
            val_2 = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
            this.lookAtEyes_ = val_9;
            val_8 = other.lookAtEyes_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        val_5 = other.lookAwayEyes_;
        if(val_5 != null)
        {
                val_10 = this.lookAwayEyes_;
            if(val_10 == null)
        {
                CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR val_3 = null;
            val_10 = val_3;
            val_3 = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
            this.lookAwayEyes_ = val_10;
            val_5 = other.lookAwayEyes_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        EYECOLOR val_7;
        goto label_18;
        label_22:
        if(53315 > 18)
        {
            goto label_2;
        }
        
        if(53315 == 9)
        {
            goto label_3;
        }
        
        if(53315 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.attackEyes_;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR val_1 = null;
        val_7 = val_1;
        val_1 = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
        this.attackEyes_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        if(53315 == 26)
        {
            goto label_8;
        }
        
        if(53315 != 34)
        {
            goto label_9;
        }
        
        val_7 = this.lookAwayEyes_;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR val_2 = null;
        val_7 = val_2;
        val_2 = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
        this.lookAwayEyes_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        this.condition_ = input.ReadDouble();
        goto label_18;
        label_8:
        val_7 = this.lookAtEyes_;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_10:
        if(input != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        input.ReadMessage(builder:  val_7);
        goto label_18;
        label_16:
        this.lookAtEyes_ = new CPU_DATA.Types.VISUALSETTINGS.Types.EYECOLOR();
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_18:
        if(input.ReadTag() != 0)
        {
            goto label_22;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.VISUALSETTINGS()
    {
        null = null;
        CPU_DATA.Types.VISUALSETTINGS.LookAwayEyesFieldNumber = new Google.Protobuf.MessageParser<VISUALSETTINGS>(factory:  new System.Func<VISUALSETTINGS>(object:  CPU_DATA.Types.VISUALSETTINGS.<>c.<>9, method:  VISUALSETTINGS CPU_DATA.Types.VISUALSETTINGS.<>c::<.cctor>b__41_0()));
    }

}
