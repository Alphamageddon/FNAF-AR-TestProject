using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.INITIALPAUSE : IMessage<ProtoData.ATTACK_DATA.Types.INITIALPAUSE>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.INITIALPAUSE>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.INITIALPAUSE>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.INITIALPAUSE> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE seconds_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.INITIALPAUSE> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE Seconds { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.INITIALPAUSE> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<INITIALPAUSE>)ATTACK_DATA.Types.INITIALPAUSE.SecondsFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.INITIALPAUSE.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.INITIALPAUSE()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.INITIALPAUSE(ProtoData.ATTACK_DATA.Types.INITIALPAUSE other)
    {
        if(other.seconds_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.seconds_ = other.seconds_.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_3;
        }
        
        goto label_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.INITIALPAUSE Clone()
    {
        return (INITIALPAUSE)new ATTACK_DATA.Types.INITIALPAUSE(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_Seconds()
    {
        return (RANGE)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        INITIALPAUSE val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.INITIALPAUSE other)
    {
        var val_2;
        if(other == null)
        {
            goto label_2;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_2:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_2;
        if(this.seconds_ != null)
        {
                val_2 = this.seconds_ ^ 1;
        }
        else
        {
                val_2 = 1;
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
        ATTACK_DATA.Types.RANGE val_1;
        if(this.seconds_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.seconds_;
        }
        
            output.WriteMessage(value:  val_1);
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
        ATTACK_DATA.Types.RANGE val_3 = this.seconds_;
        if(val_3 != null)
        {
                val_3 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_3 = this.seconds_)) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_3;
        }
        
        val_3 = this._unknownFields.CalculateSize() + val_3;
        return (int)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.INITIALPAUSE other)
    {
        ATTACK_DATA.Types.RANGE val_3;
        ATTACK_DATA.Types.RANGE val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.seconds_;
        if(val_3 != null)
        {
                val_4 = this.seconds_;
            if(val_4 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_4 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.seconds_ = val_4;
            val_3 = other.seconds_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_5;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_5;
        label_9:
        if(this.seconds_ == null)
        {
            goto label_3;
        }
        
        label_7:
        input.ReadMessage(builder:  this.seconds_);
        goto label_5;
        label_3:
        this.seconds_ = new ATTACK_DATA.Types.RANGE();
        if(input != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_5:
        uint val_3 = input.ReadTag();
        if(val_3 == 10)
        {
            goto label_9;
        }
        
        if(val_3 != 0)
        {
            goto label_10;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ATTACK_DATA.Types.INITIALPAUSE()
    {
        null = null;
        ATTACK_DATA.Types.INITIALPAUSE.SecondsFieldNumber = new Google.Protobuf.MessageParser<INITIALPAUSE>(factory:  new System.Func<INITIALPAUSE>(object:  ATTACK_DATA.Types.INITIALPAUSE.<>c.<>9, method:  INITIALPAUSE ATTACK_DATA.Types.INITIALPAUSE.<>c::<.cctor>b__25_0()));
    }

}
