using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class WEARANDTEAR_DATA.Types.ENTRY : IMessage<ProtoData.WEARANDTEAR_DATA.Types.ENTRY>, IMessage, IEquatable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY>, IDeepCloneable<ProtoData.WEARANDTEAR_DATA.Types.ENTRY>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WearAndTearFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR wearAndTear_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MalfunctionModFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD malfunctionMod_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PenaltiesFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES penalties_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RepairPartsFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double repairParts_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR WearAndTear { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD MalfunctionMod { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES Penalties { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double RepairParts { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.WEARANDTEAR_DATA.Types.ENTRY> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ENTRY>)WEARANDTEAR_DATA.Types.ENTRY.RepairPartsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.WEARANDTEAR_DATA.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return WEARANDTEAR_DATA.Types.ENTRY.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WEARANDTEAR_DATA.Types.ENTRY(ProtoData.WEARANDTEAR_DATA.Types.ENTRY other)
    {
        MALFUNCTIONMOD val_5;
        PENALTIES val_6;
        if(other.wearAndTear_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.wearAndTear_ = other.wearAndTear_.Clone();
        val_5 = other.malfunctionMod_;
        this.malfunctionMod_ = val_5.Clone();
        val_6 = other.penalties_;
        this.penalties_ = val_6.Clone();
        this.repairParts_ = other.repairParts_;
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
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY Clone()
    {
        return (ENTRY)new WEARANDTEAR_DATA.Types.ENTRY(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR get_WearAndTear()
    {
        return (WEARANDTEAR)this.wearAndTear_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WearAndTear(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR value)
    {
        this.wearAndTear_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD get_MalfunctionMod()
    {
        return (MALFUNCTIONMOD)this.malfunctionMod_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MalfunctionMod(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD value)
    {
        this.malfunctionMod_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES get_Penalties()
    {
        return (PENALTIES)this.penalties_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Penalties(ProtoData.WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES value)
    {
        this.penalties_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_RepairParts()
    {
        return (double)this.repairParts_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RepairParts(double value)
    {
        this.repairParts_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ENTRY val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.WEARANDTEAR_DATA.Types.ENTRY other)
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
        
        if((((System.Object.Equals(objA:  this.wearAndTear_, objB:  other.wearAndTear_)) != false) && ((System.Object.Equals(objA:  this.malfunctionMod_, objB:  other.malfunctionMod_)) != false)) && ((System.Object.Equals(objA:  this.penalties_, objB:  other.penalties_)) != false))
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
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
        var val_4;
        if(this.wearAndTear_ != null)
        {
                val_4 = this.wearAndTear_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.malfunctionMod_ != null)
        {
                val_4 = this.malfunctionMod_ ^ val_4;
        }
        
        if(this.penalties_ != null)
        {
                val_4 = this.penalties_ ^ val_4;
        }
        
        if(this.repairParts_ != 0f)
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
        WEARANDTEAR val_1;
        MALFUNCTIONMOD val_2;
        PENALTIES val_3;
        double val_4;
        if(this.wearAndTear_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.wearAndTear_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.wearAndTear_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.malfunctionMod_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.malfunctionMod_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.malfunctionMod_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.penalties_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.penalties_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.penalties_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.repairParts_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.repairParts_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.repairParts_;
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
        var val_9;
        var val_10;
        if(this.wearAndTear_ != null)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.wearAndTear_)) + 1;
        }
        else
        {
                val_9 = 0;
        }
        
        if(this.malfunctionMod_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.malfunctionMod_))) + 1;
        }
        
        if(this.penalties_ != null)
        {
                int val_5 = val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.penalties_));
            val_9 = val_5 + 1;
        }
        
        val_5 = val_9 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + ((this.repairParts_ == 0f) ? (val_9) : (val_5));
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.WEARANDTEAR_DATA.Types.ENTRY other)
    {
        PENALTIES val_7;
        WEARANDTEAR val_8;
        WEARANDTEAR val_9;
        MALFUNCTIONMOD val_10;
        MALFUNCTIONMOD val_11;
        PENALTIES val_12;
        if(other == null)
        {
                return;
        }
        
        val_8 = other.wearAndTear_;
        if(val_8 == null)
        {
            goto label_5;
        }
        
        val_9 = this.wearAndTear_;
        if(val_9 != null)
        {
            goto label_3;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR val_1 = null;
        val_9 = val_1;
        val_1 = new WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR();
        this.wearAndTear_ = val_9;
        val_8 = other.wearAndTear_;
        if(val_8 == null)
        {
            goto label_5;
        }
        
        label_3:
        if(other.wearAndTear_.wearAndTear_ != 0f)
        {
                .wearAndTear_ = other.wearAndTear_.wearAndTear_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR)[1152921524592861680]._unknownFields, other:  other.wearAndTear_._unknownFields);
        label_5:
        val_10 = other.malfunctionMod_;
        if(val_10 == null)
        {
            goto label_10;
        }
        
        val_11 = this.malfunctionMod_;
        if(val_11 != null)
        {
            goto label_8;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD val_3 = null;
        val_11 = val_3;
        val_3 = new WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD();
        this.malfunctionMod_ = val_11;
        val_10 = other.malfunctionMod_;
        if(val_10 == null)
        {
            goto label_10;
        }
        
        label_8:
        if(other.malfunctionMod_.malfunction_ != 0f)
        {
                .malfunction_ = other.malfunctionMod_.malfunction_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD)[1152921524592890352]._unknownFields, other:  other.malfunctionMod_._unknownFields);
        label_10:
        val_7 = other.penalties_;
        if(val_7 != null)
        {
                val_12 = this.penalties_;
            if(val_12 == null)
        {
                WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES val_5 = null;
            val_12 = val_5;
            val_5 = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES();
            this.penalties_ = val_12;
            val_7 = other.penalties_;
        }
        
            val_5.MergeFrom(other:  val_7);
        }
        
        if(other.repairParts_ != 0f)
        {
                this.repairParts_ = other.repairParts_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        MALFUNCTIONMOD val_7;
        goto label_18;
        label_22:
        if(17987 > 18)
        {
            goto label_2;
        }
        
        if(17987 == 10)
        {
            goto label_3;
        }
        
        if(17987 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.malfunctionMod_;
        if(val_7 != null)
        {
            goto label_13;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD val_1 = null;
        val_7 = val_1;
        val_1 = new WEARANDTEAR_DATA.Types.ENTRY.Types.MALFUNCTIONMOD();
        this.malfunctionMod_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        if(17987 == 26)
        {
            goto label_8;
        }
        
        if(17987 != 33)
        {
            goto label_9;
        }
        
        this.repairParts_ = input.ReadDouble();
        goto label_18;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        val_7 = this.wearAndTear_;
        if(val_7 != null)
        {
            goto label_13;
        }
        
        WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR val_4 = null;
        val_7 = val_4;
        val_4 = new WEARANDTEAR_DATA.Types.ENTRY.Types.WEARANDTEAR();
        this.wearAndTear_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_8:
        val_7 = this.penalties_;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(input != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        input.ReadMessage(builder:  val_7);
        goto label_18;
        label_16:
        this.penalties_ = new WEARANDTEAR_DATA.Types.ENTRY.Types.PENALTIES();
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
    private static WEARANDTEAR_DATA.Types.ENTRY()
    {
        null = null;
        WEARANDTEAR_DATA.Types.ENTRY.RepairPartsFieldNumber = new Google.Protobuf.MessageParser<ENTRY>(factory:  new System.Func<ENTRY>(object:  WEARANDTEAR_DATA.Types.ENTRY.<>c.<>9, method:  ENTRY WEARANDTEAR_DATA.Types.ENTRY.<>c::<.cctor>b__41_0()));
    }

}
