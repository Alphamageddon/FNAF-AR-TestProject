using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG : IMessage<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EffectDelayFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double effectDelay_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CameraShakeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.CAMERASHAKE cameraShake_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int VibrationTypeFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string vibrationType_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double EffectDelay { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CAMERASHAKE CameraShake { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string VibrationType { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FOOTSTEPCONFIG>)ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.VibrationTypeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ATTACK_DATA.Types.FOOTSTEPS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG()
    {
        this.vibrationType_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG other)
    {
        ATTACK_DATA.Types.CAMERASHAKE val_3;
        if(other != null)
        {
                this.effectDelay_ = other.effectDelay_;
        }
        else
        {
                this.effectDelay_ = 7.42422564692724E-317;
        }
        
        val_3 = other.cameraShake_;
        this.cameraShake_ = val_3.Clone();
        this.vibrationType_ = other.vibrationType_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG Clone()
    {
        return (FOOTSTEPCONFIG)new ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_EffectDelay()
    {
        return (double)this.effectDelay_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EffectDelay(double value)
    {
        this.effectDelay_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.CAMERASHAKE get_CameraShake()
    {
        return (CAMERASHAKE)this.cameraShake_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CameraShake(ProtoData.ATTACK_DATA.Types.CAMERASHAKE value)
    {
        this.cameraShake_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_VibrationType()
    {
        return (string)this.vibrationType_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_VibrationType(string value)
    {
        this.vibrationType_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FOOTSTEPCONFIG val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG other)
    {
        var val_4;
        if(other == null)
        {
            goto label_7;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                if((System.Object.Equals(objA:  this.cameraShake_, objB:  other.cameraShake_)) != false)
        {
                if((System.String.op_Inequality(a:  this.vibrationType_, b:  other.vibrationType_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_7:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        if(this.effectDelay_ == 0f)
        {
                val_3 = 1;
        }
        else
        {
                val_3 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.cameraShake_ != null)
        {
                val_3 = this.cameraShake_ ^ val_3;
        }
        
        val_4 = 0;
        if(this.vibrationType_.Length != 0)
        {
                val_3 = this.vibrationType_ ^ val_3;
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
        double val_2;
        ATTACK_DATA.Types.CAMERASHAKE val_3;
        string val_4;
        if(this.effectDelay_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_2 = this.effectDelay_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_2 = this.effectDelay_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.cameraShake_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_3 = this.cameraShake_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_3 = this.cameraShake_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.vibrationType_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_4 = this.vibrationType_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_4 = this.vibrationType_;
        }
        
            output.WriteString(value:  val_4);
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
        if(this.cameraShake_ != null)
        {
                val_8 = (((this.effectDelay_ == 0f) ? 0 : 9) + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cameraShake_))) + 1;
        }
        
        if(this.vibrationType_.Length != 0)
        {
                val_8 = (val_8 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.vibrationType_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_8;
        }
        
        val_8 = this._unknownFields.CalculateSize() + val_8;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG other)
    {
        string val_4;
        ATTACK_DATA.Types.CAMERASHAKE val_5;
        ATTACK_DATA.Types.CAMERASHAKE val_6;
        if(other == null)
        {
                return;
        }
        
        if(other.effectDelay_ != 0f)
        {
                this.effectDelay_ = other.effectDelay_;
        }
        
        val_5 = other.cameraShake_;
        if(val_5 != null)
        {
                val_6 = this.cameraShake_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.CAMERASHAKE val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.CAMERASHAKE();
            this.cameraShake_ = val_6;
            val_5 = other.cameraShake_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.vibrationType_;
        if(val_4.Length != 0)
        {
                this.VibrationType = other.vibrationType_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.CAMERASHAKE val_6;
        goto label_16;
        label_17:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_16;
        label_14:
        ATTACK_DATA.Types.CAMERASHAKE val_2 = null;
        val_6 = val_2;
        val_2 = new ATTACK_DATA.Types.CAMERASHAKE();
        this.cameraShake_ = val_6;
        if(input != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_16:
        uint val_3 = input.ReadTag();
        if(val_3 <= 17)
        {
            goto label_6;
        }
        
        if(val_3 == 18)
        {
            goto label_7;
        }
        
        if(val_3 != 26)
        {
            goto label_17;
        }
        
        this.VibrationType = input.ReadString();
        goto label_16;
        label_6:
        if(val_3 != 9)
        {
            goto label_11;
        }
        
        this.effectDelay_ = input.ReadDouble();
        goto label_16;
        label_7:
        val_6 = this.cameraShake_;
        if(val_6 == null)
        {
            goto label_14;
        }
        
        label_4:
        input.ReadMessage(builder:  val_6);
        goto label_16;
        label_11:
        if(val_3 != 0)
        {
            goto label_17;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG()
    {
        null = null;
        ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.VibrationTypeFieldNumber = new Google.Protobuf.MessageParser<FOOTSTEPCONFIG>(factory:  new System.Func<FOOTSTEPCONFIG>(object:  ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.<>c.<>9, method:  FOOTSTEPCONFIG ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG.<>c::<.cctor>b__35_0()));
    }

}
