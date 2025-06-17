using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class STORE_DATA.Types.ENTRY.Types.BADGE : IMessage<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE>, IMessage, IEquatable<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE>, IDeepCloneable<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BadgeArtRefFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string badgeArtRef_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BadgeLocRefFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string badgeLocRef_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string BadgeArtRef { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string BadgeLocRef { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<BADGE>)STORE_DATA.Types.ENTRY.Types.BADGE.BadgeLocRefFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return STORE_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return STORE_DATA.Types.ENTRY.Types.BADGE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.BADGE()
    {
        this.badgeArtRef_ = "";
        this.badgeLocRef_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public STORE_DATA.Types.ENTRY.Types.BADGE(ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE other)
    {
        if(other != null)
        {
                this.badgeArtRef_ = other.badgeArtRef_;
            this.badgeLocRef_ = other.badgeLocRef_;
        }
        else
        {
                this.badgeArtRef_ = 15026800;
            this.badgeLocRef_ = 64;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE Clone()
    {
        return (BADGE)new STORE_DATA.Types.ENTRY.Types.BADGE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_BadgeArtRef()
    {
        return (string)this.badgeArtRef_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BadgeArtRef(string value)
    {
        this.badgeArtRef_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_BadgeLocRef()
    {
        return (string)this.badgeLocRef_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_BadgeLocRef(string value)
    {
        this.badgeLocRef_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        BADGE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE other)
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
        
        if((System.String.op_Inequality(a:  this.badgeArtRef_, b:  other.badgeArtRef_)) != true)
        {
                if((System.String.op_Inequality(a:  this.badgeLocRef_, b:  other.badgeLocRef_)) == false)
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
        if(this.badgeArtRef_.Length != 0)
        {
                val_3 = this.badgeArtRef_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        val_4 = 0;
        if(this.badgeLocRef_.Length != 0)
        {
                val_3 = this.badgeLocRef_ ^ val_3;
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
        if(this.badgeArtRef_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_3 = this.badgeArtRef_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_3 = this.badgeArtRef_;
        }
        
            output.WriteString(value:  val_3);
        }
        
        if(this.badgeLocRef_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_4 = this.badgeLocRef_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_4 = this.badgeLocRef_;
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
        if(this.badgeArtRef_.Length != 0)
        {
                val_7 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.badgeArtRef_)) + 1;
        }
        else
        {
                val_7 = 0;
        }
        
        if(this.badgeLocRef_.Length != 0)
        {
                val_7 = (val_7 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.badgeLocRef_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_7;
        }
        
        val_7 = this._unknownFields.CalculateSize() + val_7;
        return (int)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.STORE_DATA.Types.ENTRY.Types.BADGE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.badgeArtRef_.Length != 0)
        {
                this.BadgeArtRef = other.badgeArtRef_;
        }
        
        if(other.badgeLocRef_.Length != 0)
        {
                this.BadgeLocRef = other.badgeLocRef_;
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
        this.BadgeArtRef = input.ReadString();
        goto label_3;
        label_7:
        this.BadgeLocRef = input.ReadString();
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
    private static STORE_DATA.Types.ENTRY.Types.BADGE()
    {
        null = null;
        STORE_DATA.Types.ENTRY.Types.BADGE.BadgeLocRefFieldNumber = new Google.Protobuf.MessageParser<BADGE>(factory:  new System.Func<BADGE>(object:  STORE_DATA.Types.ENTRY.Types.BADGE.<>c.<>9, method:  BADGE STORE_DATA.Types.ENTRY.Types.BADGE.<>c::<.cctor>b__30_0()));
    }

}
