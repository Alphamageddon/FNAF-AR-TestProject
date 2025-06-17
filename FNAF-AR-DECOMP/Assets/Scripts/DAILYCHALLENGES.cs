using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EnableFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool enable_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Enable { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<DAILYCHALLENGES>)CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.EnableFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[19];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES other)
    {
        if(other != null)
        {
                this.enable_ = other.enable_;
        }
        else
        {
                this.enable_ = false;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES Clone()
    {
        return (DAILYCHALLENGES)new CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Enable()
    {
        return (bool)this.enable_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Enable(bool value)
    {
        this.enable_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        DAILYCHALLENGES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES other)
    {
        if(other == null)
        {
                return false;
        }
        
        if(other == this)
        {
                return true;
        }
        
        var val_1 = (this.enable_ == true) ? 1 : 0;
        val_1 = val_1 ^ ((other.enable_ == true) ? 1 : 0);
        if((val_1 & 1) == 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2 = 1;
        if(this.enable_ != false)
        {
                val_2 = val_2.GetHashCode() ^ 1;
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
        bool val_2;
        if(this.enable_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_2 = this.enable_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_2 = this.enable_;
        }
        
            output.WriteBool(value:  (val_2 == true) ? 1 : 0);
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
        var val_3 = this.enable_ << 1;
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + val_3;
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.enable_ != false)
        {
                this.enable_ = other.enable_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_1;
        label_5:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_1;
        label_4:
        this.enable_ = input.ReadBool();
        label_1:
        uint val_4 = input.ReadTag();
        if(val_4 == 8)
        {
            goto label_4;
        }
        
        if(val_4 != 0)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.EnableFieldNumber = new Google.Protobuf.MessageParser<DAILYCHALLENGES>(factory:  new System.Func<DAILYCHALLENGES>(object:  CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.<>c.<>9, method:  DAILYCHALLENGES CONFIG_DATA.Types.ENTRY.Types.DAILYCHALLENGES.<>c::<.cctor>b__25_0()));
    }

}
