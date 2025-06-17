using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR : IMessage<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR>, IDeepCloneable<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PartsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS parts_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE essence_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS Parts { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE Essence { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<PVPANIMATRONICSAGGRESSOR>)CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.EssenceFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CPU_DATA.Types.REWARDS.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR(ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR other)
    {
        ESSENCE val_4;
        if(other.parts_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.parts_ = other.parts_.Clone();
        val_4 = other.essence_;
        this.essence_ = val_4.Clone();
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
    public ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR Clone()
    {
        return (PVPANIMATRONICSAGGRESSOR)new CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS get_Parts()
    {
        return (PARTS)this.parts_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Parts(ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS value)
    {
        this.parts_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE get_Essence()
    {
        return (ESSENCE)this.essence_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Essence(ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE value)
    {
        this.essence_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        PVPANIMATRONICSAGGRESSOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR other)
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
        
        if((System.Object.Equals(objA:  this.parts_, objB:  other.parts_)) != false)
        {
                if((System.Object.Equals(objA:  this.essence_, objB:  other.essence_)) != false)
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
        if(this.parts_ != null)
        {
                val_3 = this.parts_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.essence_ != null)
        {
                val_3 = this.essence_ ^ val_3;
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
        PARTS val_1;
        ESSENCE val_2;
        if(this.parts_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.parts_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.parts_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.essence_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.essence_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.essence_;
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
        PARTS val_5 = this.parts_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.parts_)) + 1;
        }
        
        if(this.essence_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.essence_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR other)
    {
        ESSENCE val_4;
        PARTS val_5;
        PARTS val_6;
        ESSENCE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.parts_;
        if(val_5 != null)
        {
                val_6 = this.parts_;
            if(val_6 == null)
        {
                CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS val_1 = null;
            val_6 = val_1;
            val_1 = new CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS();
            this.parts_ = val_6;
            val_5 = other.parts_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.essence_;
        if(val_4 != null)
        {
                val_7 = this.essence_;
            if(val_7 == null)
        {
                CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE val_2 = null;
            val_7 = val_2;
            val_2 = new CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE();
            this.essence_ = val_7;
            val_4 = other.essence_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        PARTS val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.parts_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS val_2 = null;
        val_5 = val_2;
        val_2 = new CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.PARTS();
        this.parts_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.essence_;
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
        this.essence_ = new CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.Types.ESSENCE();
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
    private static CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR()
    {
        null = null;
        CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.EssenceFieldNumber = new Google.Protobuf.MessageParser<PVPANIMATRONICSAGGRESSOR>(factory:  new System.Func<PVPANIMATRONICSAGGRESSOR>(object:  CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.<>c.<>9, method:  PVPANIMATRONICSAGGRESSOR CPU_DATA.Types.REWARDS.Types.PVPANIMATRONICSAGGRESSOR.<>c::<.cctor>b__31_0()));
    }

}
