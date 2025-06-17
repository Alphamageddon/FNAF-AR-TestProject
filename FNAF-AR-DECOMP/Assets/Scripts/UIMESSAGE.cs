using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ALERT_DATA.Types.ENTRY.Types.UIMESSAGE : IMessage<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE>, IMessage, IEquatable<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE>, IDeepCloneable<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UIDisplayRestrictionFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION uIDisplayRestriction_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int UIDeferFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDEFER uIDefer_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION UIDisplayRestriction { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDEFER UIDefer { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<UIMESSAGE>)ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.UIDeferFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ALERT_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.UIMESSAGE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ALERT_DATA.Types.ENTRY.Types.UIMESSAGE(ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE other)
    {
        if(other != null)
        {
                this.uIDisplayRestriction_ = other.uIDisplayRestriction_;
            this.uIDefer_ = other.uIDefer_;
        }
        else
        {
                this.uIDisplayRestriction_ = 15026800;
            this.uIDefer_ = 0;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE Clone()
    {
        return (UIMESSAGE)new ALERT_DATA.Types.ENTRY.Types.UIMESSAGE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION get_UIDisplayRestriction()
    {
        return (UIDISPLAYRESTRICTION)this.uIDisplayRestriction_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UIDisplayRestriction(ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION value)
    {
        this.uIDisplayRestriction_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDEFER get_UIDefer()
    {
        return (UIDEFER)this.uIDefer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_UIDefer(ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDEFER value)
    {
        this.uIDefer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        UIMESSAGE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE other)
    {
        if(other == null)
        {
                return false;
        }
        
        if(other == this)
        {
                return true;
        }
        
        if(this.uIDisplayRestriction_ != other.uIDisplayRestriction_)
        {
                return false;
        }
        
        if(this.uIDefer_ != other.uIDefer_)
        {
                return false;
        }
        
        return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.uIDisplayRestriction_ != 0)
        {
                val_4 = 0;
            val_5 = this.uIDisplayRestriction_.region ^ 1;
        }
        else
        {
                val_5 = 1;
        }
        
        if(this.uIDefer_ != 0)
        {
                val_4 = 0;
            val_5 = this.uIDefer_.region ^ val_5;
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
        UIDISPLAYRESTRICTION val_1;
        UIDEFER val_2;
        if(this.uIDisplayRestriction_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_1 = this.uIDisplayRestriction_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_1 = this.uIDisplayRestriction_;
        }
        
            output.WriteEnum(value:  val_1);
        }
        
        if(this.uIDefer_ != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_2 = this.uIDefer_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_2 = this.uIDefer_;
        }
        
            output.WriteEnum(value:  val_2);
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
        UIDISPLAYRESTRICTION val_5 = this.uIDisplayRestriction_;
        if(val_5 != 0)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  val_5 = this.uIDisplayRestriction_)) + 1;
        }
        
        if(this.uIDefer_ != 0)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeEnumSize(value:  this.uIDefer_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ALERT_DATA.Types.ENTRY.Types.UIMESSAGE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.uIDisplayRestriction_ != 0)
        {
                this.uIDisplayRestriction_ = other.uIDisplayRestriction_;
        }
        
        if(other.uIDefer_ != 0)
        {
                this.uIDefer_ = other.uIDefer_;
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
        this.uIDisplayRestriction_ = input.ReadEnum();
        goto label_3;
        label_7:
        this.uIDefer_ = input.ReadEnum();
        label_3:
        uint val_4 = input.ReadTag();
        if(val_4 == 8)
        {
            goto label_6;
        }
        
        if(val_4 == 16)
        {
            goto label_7;
        }
        
        if(val_4 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ALERT_DATA.Types.ENTRY.Types.UIMESSAGE()
    {
        null = null;
        ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.UIDeferFieldNumber = new Google.Protobuf.MessageParser<UIMESSAGE>(factory:  new System.Func<UIMESSAGE>(object:  ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.<>c.<>9, method:  UIMESSAGE ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.<>c::<.cctor>b__31_0()));
    }

}
