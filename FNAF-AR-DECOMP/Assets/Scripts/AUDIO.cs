using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SoundBankFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string soundBank_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BundleFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string bundle_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string SoundBank { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Bundle { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<AUDIO>)PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO.BundleFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return PLUSHSUIT_DATA.Types.ARTASSETS.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO()
    {
        this.soundBank_ = "";
        this.bundle_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO other)
    {
        if(other != null)
        {
                this.soundBank_ = other.soundBank_;
            this.bundle_ = other.bundle_;
        }
        else
        {
                this.soundBank_ = 15026800;
            this.bundle_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO Clone()
    {
        return (AUDIO)new PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_SoundBank()
    {
        return (string)this.soundBank_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SoundBank(string value)
    {
        this.soundBank_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Bundle()
    {
        return (string)this.bundle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Bundle(string value)
    {
        this.bundle_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        AUDIO val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO other)
    {
        var val_3;
        if(other == null)
        {
            goto label_2;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.String.op_Inequality(a:  this.soundBank_, b:  other.soundBank_)) != true)
        {
                if((System.String.op_Inequality(a:  this.bundle_, b:  other.bundle_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_2:
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
        var val_4;
        if(this.soundBank_.Length != 0)
        {
                val_3 = this.soundBank_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.bundle_.Length != 0)
        {
                val_3 = this.bundle_ ^ val_3;
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
        string val_3;
        string val_4;
        if(this.soundBank_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.soundBank_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.soundBank_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.bundle_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.bundle_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.bundle_;
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
        var val_7;
        if(this.soundBank_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.soundBank_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.bundle_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.bundle_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.soundBank_.Length != 0)
        {
                this.SoundBank = other.soundBank_;
        }
        
        if(other.bundle_.Length != 0)
        {
                this.Bundle = other.bundle_;
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
        this.SoundBank = input.ReadString();
        goto label_3;
        label_7:
        this.Bundle = input.ReadString();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_6;
        }
        
        if(val_4 == 18)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO.BundleFieldNumber = new Google.Protobuf.MessageParser<AUDIO>(factory:  new System.Func<AUDIO>(object:  PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO.<>c.<>9, method:  AUDIO PLUSHSUIT_DATA.Types.ARTASSETS.Types.AUDIO.<>c::<.cctor>b__30_0()));
    }

}
