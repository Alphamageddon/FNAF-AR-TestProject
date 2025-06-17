using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR : IMessage<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR>, IMessage, IEquatable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR>, IDeepCloneable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachedAccelerationFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double detachedAcceleration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachedDecelerationFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double detachedDeceleration_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MaximumDetachedSpeedFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double maximumDetachedSpeed_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedAcceleration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DetachedDeceleration { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MaximumDetachedSpeed { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DETACHEDMOVEMENTBEHAVIOR>)ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR.MaximumDetachedSpeedFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR other)
    {
        if(other != null)
        {
                this.detachedAcceleration_ = other.detachedAcceleration_;
            this.detachedDeceleration_ = other.detachedDeceleration_;
            this.maximumDetachedSpeed_ = other.maximumDetachedSpeed_;
        }
        else
        {
                this.detachedAcceleration_ = 7.42422564692724E-317;
            this.detachedDeceleration_ = 3.16202013338398E-322;
            this.maximumDetachedSpeed_ = 3.41288492945375E-316;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR Clone()
    {
        return (DETACHEDMOVEMENTBEHAVIOR)new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DetachedAcceleration()
    {
        return (double)this.detachedAcceleration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachedAcceleration(double value)
    {
        this.detachedAcceleration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DetachedDeceleration()
    {
        return (double)this.detachedDeceleration_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachedDeceleration(double value)
    {
        this.detachedDeceleration_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MaximumDetachedSpeed()
    {
        return (double)this.maximumDetachedSpeed_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MaximumDetachedSpeed(double value)
    {
        this.maximumDetachedSpeed_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DETACHEDMOVEMENTBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR other)
    {
        var val_4;
        double val_5;
        var val_6;
        if(other == null)
        {
            goto label_14;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_5 = this.detachedAcceleration_;
        val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_4 & 1) != 0)
        {
                val_5 = this.detachedDeceleration_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                val_5 = this.maximumDetachedSpeed_;
            val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_4 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_14:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.detachedAcceleration_ == 0f)
        {
                val_4 = 1;
        }
        else
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.detachedDeceleration_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.maximumDetachedSpeed_ != 0f)
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
        double val_1;
        double val_2;
        double val_3;
        if(this.detachedAcceleration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.detachedAcceleration_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.detachedAcceleration_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.detachedDeceleration_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.detachedDeceleration_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.detachedDeceleration_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.maximumDetachedSpeed_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.maximumDetachedSpeed_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.maximumDetachedSpeed_;
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
        var val_5;
        var val_1 = (this.detachedAcceleration_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.detachedDeceleration_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.maximumDetachedSpeed_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.detachedAcceleration_ != 0f)
        {
                this.detachedAcceleration_ = other.detachedAcceleration_;
        }
        
        if(other.detachedDeceleration_ != 0f)
        {
                this.detachedDeceleration_ = other.detachedDeceleration_;
        }
        
        if(other.maximumDetachedSpeed_ != 0f)
        {
                this.maximumDetachedSpeed_ = other.maximumDetachedSpeed_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 16)
        {
            goto label_2;
        }
        
        if(val_2 == 17)
        {
            goto label_3;
        }
        
        if(val_2 != 25)
        {
            goto label_12;
        }
        
        this.maximumDetachedSpeed_ = input.ReadDouble();
        goto label_11;
        label_2:
        if(val_2 != 9)
        {
            goto label_7;
        }
        
        this.detachedAcceleration_ = input.ReadDouble();
        goto label_11;
        label_3:
        this.detachedDeceleration_ = input.ReadDouble();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR()
    {
        null = null;
        ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR.MaximumDetachedSpeedFieldNumber = new Google.Protobuf.MessageParser<DETACHEDMOVEMENTBEHAVIOR>(factory:  new System.Func<DETACHEDMOVEMENTBEHAVIOR>(object:  ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR.<>c.<>9, method:  DETACHEDMOVEMENTBEHAVIOR ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR.<>c::<.cctor>b__35_0()));
    }

}
