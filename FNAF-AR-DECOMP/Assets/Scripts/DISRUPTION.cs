using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.DISRUPTION : IMessage<ProtoData.ATTACK_DATA.Types.DISRUPTION>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.DISRUPTION>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.DISRUPTION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SettingsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS settings_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ShakeFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE shake_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS Settings { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE Shake { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.DISRUPTION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DISRUPTION>)ATTACK_DATA.Types.DISRUPTION.ShakeFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[9];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.DISRUPTION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.DISRUPTION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.DISRUPTION(ProtoData.ATTACK_DATA.Types.DISRUPTION other)
    {
        SHAKE val_4;
        if(other.settings_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.settings_ = other.settings_.Clone();
        val_4 = other.shake_;
        this.shake_ = val_4.Clone();
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
    public ProtoData.ATTACK_DATA.Types.DISRUPTION Clone()
    {
        return (DISRUPTION)new ATTACK_DATA.Types.DISRUPTION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS get_Settings()
    {
        return (SETTINGS)this.settings_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Settings(ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS value)
    {
        this.settings_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE get_Shake()
    {
        return (SHAKE)this.shake_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Shake(ProtoData.ATTACK_DATA.Types.DISRUPTION.Types.SHAKE value)
    {
        this.shake_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DISRUPTION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.DISRUPTION other)
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
        
        if((System.Object.Equals(objA:  this.settings_, objB:  other.settings_)) != false)
        {
                if((System.Object.Equals(objA:  this.shake_, objB:  other.shake_)) != false)
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
        if(this.settings_ != null)
        {
                val_3 = this.settings_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.shake_ != null)
        {
                val_3 = this.shake_ ^ val_3;
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
        SETTINGS val_1;
        SHAKE val_2;
        if(this.settings_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.settings_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.settings_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.shake_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.shake_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.shake_;
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
        SETTINGS val_5 = this.settings_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.settings_)) + 1;
        }
        
        if(this.shake_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.shake_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.DISRUPTION other)
    {
        SHAKE val_4;
        SETTINGS val_5;
        SETTINGS val_6;
        SHAKE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.settings_;
        if(val_5 != null)
        {
                val_6 = this.settings_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS();
            this.settings_ = val_6;
            val_5 = other.settings_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.shake_;
        if(val_4 != null)
        {
                val_7 = this.shake_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.DISRUPTION.Types.SHAKE val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.DISRUPTION.Types.SHAKE();
            this.shake_ = val_7;
            val_4 = other.shake_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SETTINGS val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.settings_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS val_2 = null;
        val_5 = val_2;
        val_2 = new ATTACK_DATA.Types.DISRUPTION.Types.SETTINGS();
        this.settings_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.shake_;
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
        this.shake_ = new ATTACK_DATA.Types.DISRUPTION.Types.SHAKE();
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
    private static ATTACK_DATA.Types.DISRUPTION()
    {
        null = null;
        ATTACK_DATA.Types.DISRUPTION.ShakeFieldNumber = new Google.Protobuf.MessageParser<DISRUPTION>(factory:  new System.Func<DISRUPTION>(object:  ATTACK_DATA.Types.DISRUPTION.<>c.<>9, method:  DISRUPTION ATTACK_DATA.Types.DISRUPTION.<>c::<.cctor>b__31_0()));
    }

}
