using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int OnSpawnFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool onSpawn_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AfterFeintFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool afterFeint_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool OnSpawn { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AfterFeint { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SHOULDUSEPHASE>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE.AfterFeintFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE other)
    {
        if(other != null)
        {
                this.onSpawn_ = other.onSpawn_;
            this.afterFeint_ = other.afterFeint_;
        }
        else
        {
                this.onSpawn_ = false;
            this.afterFeint_ = false;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE Clone()
    {
        return (SHOULDUSEPHASE)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_OnSpawn()
    {
        return (bool)this.onSpawn_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_OnSpawn(bool value)
    {
        this.onSpawn_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_AfterFeint()
    {
        return (bool)this.afterFeint_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AfterFeint(bool value)
    {
        this.afterFeint_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SHOULDUSEPHASE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE other)
    {
        if(other == null)
        {
                return false;
        }
        
        if(other == this)
        {
                return true;
        }
        
        var val_1 = (this.onSpawn_ == true) ? 1 : 0;
        val_1 = val_1 ^ ((other.onSpawn_ == true) ? 1 : 0);
        if((val_1 & 1) != 0)
        {
                return false;
        }
        
        var val_3 = (this.afterFeint_ == true) ? 1 : 0;
        val_3 = val_3 ^ ((other.afterFeint_ == true) ? 1 : 0);
        if((val_3 & 1) == 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        var val_4;
        val_3 = 1;
        if(this.onSpawn_ != false)
        {
                val_4 = 0;
            val_3 = val_3.GetHashCode() ^ 1;
        }
        
        if(this.afterFeint_ != false)
        {
                val_4 = 0;
            val_3 = 1.GetHashCode() ^ val_3;
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
        bool val_3;
        bool val_4;
        if(this.onSpawn_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  8);
            val_3 = this.onSpawn_;
        }
        else
        {
                0.WriteRawTag(b1:  8);
            val_3 = this.onSpawn_;
        }
        
            output.WriteBool(value:  (val_3 == true) ? 1 : 0);
        }
        
        if(this.afterFeint_ != false)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  16);
            val_4 = this.afterFeint_;
        }
        else
        {
                0.WriteRawTag(b1:  16);
            val_4 = this.afterFeint_;
        }
        
            output.WriteBool(value:  (val_4 == true) ? 1 : 0);
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
        var val_4;
        bool val_4 = this.onSpawn_;
        val_4 = val_4 << 1;
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields.CalculateSize() + ((this.afterFeint_ == true) ? (val_4 + 2) : (val_4));
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.onSpawn_ != false)
        {
                this.onSpawn_ = other.onSpawn_;
        }
        
        if(other.afterFeint_ != false)
        {
                this.afterFeint_ = other.afterFeint_;
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
        this.onSpawn_ = input.ReadBool();
        goto label_3;
        label_7:
        this.afterFeint_ = input.ReadBool();
        label_3:
        uint val_6 = input.ReadTag();
        if(val_6 == 8)
        {
            goto label_6;
        }
        
        if(val_6 == 16)
        {
            goto label_7;
        }
        
        if(val_6 != 0)
        {
            goto label_8;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE.AfterFeintFieldNumber = new Google.Protobuf.MessageParser<SHOULDUSEPHASE>(factory:  new System.Func<SHOULDUSEPHASE>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE.<>c.<>9, method:  SHOULDUSEPHASE ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.INITIALPAUSE.Types.SHOULDUSEPHASE.<>c::<.cctor>b__30_0()));
    }

}
