using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.PHANTOMWALK : IMessage<ProtoData.ATTACK_DATA.Types.PHANTOMWALK>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.PHANTOMWALK>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.PHANTOMWALK>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMWALK> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EncounterBurnTimeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE encounterBurnTime_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PhaseBurnTimeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE phaseBurnTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMWALK> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE EncounterBurnTime { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE PhaseBurnTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.PHANTOMWALK> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PHANTOMWALK>)ATTACK_DATA.Types.PHANTOMWALK.PhaseBurnTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[13];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.PHANTOMWALK.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PHANTOMWALK()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.PHANTOMWALK(ProtoData.ATTACK_DATA.Types.PHANTOMWALK other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        if(other.encounterBurnTime_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.encounterBurnTime_ = other.encounterBurnTime_.Clone();
        val_4 = other.phaseBurnTime_;
        this.phaseBurnTime_ = val_4.Clone();
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
    public ProtoData.ATTACK_DATA.Types.PHANTOMWALK Clone()
    {
        return (PHANTOMWALK)new ATTACK_DATA.Types.PHANTOMWALK(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_EncounterBurnTime()
    {
        return (RANGE)this.encounterBurnTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EncounterBurnTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.encounterBurnTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_PhaseBurnTime()
    {
        return (RANGE)this.phaseBurnTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PhaseBurnTime(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.phaseBurnTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PHANTOMWALK val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.PHANTOMWALK other)
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
        
        if((System.Object.Equals(objA:  this.encounterBurnTime_, objB:  other.encounterBurnTime_)) != false)
        {
                if((System.Object.Equals(objA:  this.phaseBurnTime_, objB:  other.phaseBurnTime_)) != false)
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
        if(this.encounterBurnTime_ != null)
        {
                val_3 = this.encounterBurnTime_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.phaseBurnTime_ != null)
        {
                val_3 = this.phaseBurnTime_ ^ val_3;
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
        ATTACK_DATA.Types.RANGE val_1;
        ATTACK_DATA.Types.RANGE val_2;
        if(this.encounterBurnTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.encounterBurnTime_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.encounterBurnTime_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.phaseBurnTime_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.phaseBurnTime_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.phaseBurnTime_;
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
        ATTACK_DATA.Types.RANGE val_5 = this.encounterBurnTime_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.encounterBurnTime_)) + 1;
        }
        
        if(this.phaseBurnTime_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.phaseBurnTime_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.PHANTOMWALK other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        ATTACK_DATA.Types.RANGE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.encounterBurnTime_;
        if(val_5 != null)
        {
                val_6 = this.encounterBurnTime_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.encounterBurnTime_ = val_6;
            val_5 = other.encounterBurnTime_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.phaseBurnTime_;
        if(val_4 != null)
        {
                val_7 = this.phaseBurnTime_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.phaseBurnTime_ = val_7;
            val_4 = other.phaseBurnTime_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.encounterBurnTime_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_5 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.encounterBurnTime_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.phaseBurnTime_;
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
        this.phaseBurnTime_ = new ATTACK_DATA.Types.RANGE();
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
    private static ATTACK_DATA.Types.PHANTOMWALK()
    {
        null = null;
        ATTACK_DATA.Types.PHANTOMWALK.PhaseBurnTimeFieldNumber = new Google.Protobuf.MessageParser<PHANTOMWALK>(factory:  new System.Func<PHANTOMWALK>(object:  ATTACK_DATA.Types.PHANTOMWALK.<>c.<>9, method:  PHANTOMWALK ATTACK_DATA.Types.PHANTOMWALK.<>c::<.cctor>b__30_0()));
    }

}
