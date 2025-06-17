using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.DISRUPTION.Types.SHAKE : IMessage<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeMagnitudeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shakeMagnitude_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeGraceTimeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double shakeGraceTime_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShakeMagnitude { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ShakeGraceTime { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SHAKE>)ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.ShakeGraceTimeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.DISRUPTION.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.DISRUPTION.Types.SHAKE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.DISRUPTION.Types.SHAKE(ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE other)
    {
        if(other != null)
        {
                this.shakeMagnitude_ = other.shakeMagnitude_;
            this.shakeGraceTime_ = other.shakeGraceTime_;
        }
        else
        {
                this.shakeMagnitude_ = 7.42422564692724E-317;
            this.shakeGraceTime_ = 3.16202013338398E-322;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE Clone()
    {
        return (SHAKE)new ATTACK_DATA.Types.DISRUPTION.Types.SHAKE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShakeMagnitude()
    {
        return (double)this.shakeMagnitude_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShakeMagnitude(double value)
    {
        this.shakeMagnitude_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ShakeGraceTime()
    {
        return (double)this.shakeGraceTime_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ShakeGraceTime(double value)
    {
        this.shakeGraceTime_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SHAKE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE other)
    {
        var val_3;
        double val_4;
        var val_5;
        if(other == null)
        {
            goto label_10;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_4 = this.shakeMagnitude_;
        val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_3 & 1) != 0)
        {
                val_4 = this.shakeGraceTime_;
            val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_3 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.shakeMagnitude_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.shakeGraceTime_ != 0f)
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_3;
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
        double val_1;
        double val_2;
        if(this.shakeMagnitude_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_1 = this.shakeMagnitude_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_1 = this.shakeMagnitude_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.shakeGraceTime_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_2 = this.shakeGraceTime_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_2 = this.shakeGraceTime_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_1 = (this.shakeMagnitude_ == 0f) ? 0 : 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.shakeGraceTime_ == 0f) ? (val_1) : (val_1 + 9));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.shakeMagnitude_ != 0f)
        {
                this.shakeMagnitude_ = other.shakeMagnitude_;
        }
        
        if(other.shakeGraceTime_ != 0f)
        {
                this.shakeGraceTime_ = other.shakeGraceTime_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_3;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_3;
        label_6:
        this.shakeMagnitude_ = input.ReadDouble();
        goto label_3;
        label_7:
        this.shakeGraceTime_ = input.ReadDouble();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 17)
        {
            goto label_6;
        }
        
        if(val_4 == 25)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.DISRUPTION.Types.SHAKE()
    {
        null = null;
        ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.ShakeGraceTimeFieldNumber = new Google.Protobuf.MessageParser<SHAKE>(factory:  new System.Func<SHAKE>(object:  ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.<>c.<>9, method:  SHAKE ATTACK_DATA.Types.DISRUPTION.Types.SHAKE.<>c::<.cctor>b__30_0()));
    }

}
