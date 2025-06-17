using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.CAMERASHAKE : IMessage<ProtoData.ATTACK_DATA.Types.CAMERASHAKE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.CAMERASHAKE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.CAMERASHAKE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CAMERASHAKE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MagnitudeFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double magnitude_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RoughnessFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double roughness_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeInFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double fadeIn_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FadeOutFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double fadeOut_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CAMERASHAKE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Magnitude { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double Roughness { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FadeIn { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FadeOut { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.CAMERASHAKE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CAMERASHAKE>)ATTACK_DATA.Types.CAMERASHAKE.FadeOutFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[16];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.CAMERASHAKE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CAMERASHAKE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.CAMERASHAKE(ProtoData.ATTACK_DATA.Types.CAMERASHAKE other)
    {
        if(other != null)
        {
                this.magnitude_ = other.magnitude_;
            this.roughness_ = other.roughness_;
            this.fadeIn_ = other.fadeIn_;
            this.fadeOut_ = other.fadeOut_;
        }
        else
        {
                this.magnitude_ = 7.42422564692724E-317;
            this.roughness_ = 3.16202013338398E-322;
            this.fadeIn_ = 3.41288492945375E-316;
            this.fadeOut_ = 1.33509863819657E-307;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CAMERASHAKE Clone()
    {
        return (CAMERASHAKE)new ATTACK_DATA.Types.CAMERASHAKE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Magnitude()
    {
        return (double)this.magnitude_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Magnitude(double value)
    {
        this.magnitude_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_Roughness()
    {
        return (double)this.roughness_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Roughness(double value)
    {
        this.roughness_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FadeIn()
    {
        return (double)this.fadeIn_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FadeIn(double value)
    {
        this.fadeIn_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FadeOut()
    {
        return (double)this.fadeOut_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FadeOut(double value)
    {
        this.fadeOut_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CAMERASHAKE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.CAMERASHAKE other)
    {
        var val_5;
        double val_6;
        var val_7;
        if(other == null)
        {
            goto label_18;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_6 = this.magnitude_;
        val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_5 & 1) != 0)
        {
                val_6 = this.roughness_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.fadeIn_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                val_6 = this.fadeOut_;
            val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_5 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_5;
        if(this.magnitude_ == 0f)
        {
                val_5 = 1;
        }
        else
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.roughness_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.fadeIn_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this.fadeOut_ != 0f)
        {
                val_5 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_5;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields ^ val_5;
        return (int)val_5;
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
        double val_4;
        if(this.magnitude_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.magnitude_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.magnitude_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.roughness_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.roughness_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.roughness_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.fadeIn_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.fadeIn_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.fadeIn_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.fadeOut_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.fadeOut_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.fadeOut_;
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
        var val_5;
        var val_1 = (this.magnitude_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.roughness_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.fadeIn_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.fadeOut_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.CAMERASHAKE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.magnitude_ != 0f)
        {
                this.magnitude_ = other.magnitude_;
        }
        
        if(other.roughness_ != 0f)
        {
                this.roughness_ = other.roughness_;
        }
        
        if(other.fadeIn_ != 0f)
        {
                this.fadeIn_ = other.fadeIn_;
        }
        
        if(other.fadeOut_ != 0f)
        {
                this.fadeOut_ = other.fadeOut_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_12;
        label_15:
        if(this > 17)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this != 17)
        {
            goto label_7;
        }
        
        this.roughness_ = input.ReadDouble();
        goto label_12;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this != 33)
        {
            goto label_7;
        }
        
        this.fadeOut_ = input.ReadDouble();
        goto label_12;
        label_7:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_12;
        label_2:
        this.magnitude_ = input.ReadDouble();
        goto label_12;
        label_6:
        this.fadeIn_ = input.ReadDouble();
        label_12:
        if(input.ReadTag() != 0)
        {
            goto label_15;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.CAMERASHAKE()
    {
        null = null;
        ATTACK_DATA.Types.CAMERASHAKE.FadeOutFieldNumber = new Google.Protobuf.MessageParser<CAMERASHAKE>(factory:  new System.Func<CAMERASHAKE>(object:  ATTACK_DATA.Types.CAMERASHAKE.<>c.<>9, method:  CAMERASHAKE ATTACK_DATA.Types.CAMERASHAKE.<>c::<.cctor>b__40_0()));
    }

}
