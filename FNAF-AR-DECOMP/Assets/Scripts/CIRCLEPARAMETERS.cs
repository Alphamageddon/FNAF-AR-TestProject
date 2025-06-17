using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS : IMessage<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SecondsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS seconds_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DegreesPerSecondFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND degreesPerSecond_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS Seconds { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND DegreesPerSecond { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CIRCLEPARAMETERS>)ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.DegreesPerSecondFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS other)
    {
        DEGREESPERSECOND val_4;
        if(other.seconds_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.seconds_ = other.seconds_.Clone();
        val_4 = other.degreesPerSecond_;
        this.degreesPerSecond_ = val_4.Clone();
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
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS Clone()
    {
        return (CIRCLEPARAMETERS)new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS get_Seconds()
    {
        return (SECONDS)this.seconds_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Seconds(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS value)
    {
        this.seconds_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND get_DegreesPerSecond()
    {
        return (DEGREESPERSECOND)this.degreesPerSecond_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DegreesPerSecond(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND value)
    {
        this.degreesPerSecond_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CIRCLEPARAMETERS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS other)
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
        
        if((System.Object.Equals(objA:  this.seconds_, objB:  other.seconds_)) != false)
        {
                if((System.Object.Equals(objA:  this.degreesPerSecond_, objB:  other.degreesPerSecond_)) != false)
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
        if(this.seconds_ != null)
        {
                val_3 = this.seconds_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.degreesPerSecond_ != null)
        {
                val_3 = this.degreesPerSecond_ ^ val_3;
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
        SECONDS val_1;
        DEGREESPERSECOND val_2;
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
        
        if(this.degreesPerSecond_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.degreesPerSecond_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.degreesPerSecond_;
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
        SECONDS val_5 = this.seconds_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.seconds_)) + 1;
        }
        
        if(this.degreesPerSecond_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.degreesPerSecond_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS other)
    {
        DEGREESPERSECOND val_4;
        SECONDS val_5;
        SECONDS val_6;
        DEGREESPERSECOND val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.seconds_;
        if(val_5 != null)
        {
                val_6 = this.seconds_;
            if(val_6 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS val_1 = null;
            val_6 = val_1;
            val_1 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS();
            this.seconds_ = val_6;
            val_5 = other.seconds_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.degreesPerSecond_;
        if(val_4 != null)
        {
                val_7 = this.degreesPerSecond_;
            if(val_7 == null)
        {
                ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND val_2 = null;
            val_7 = val_2;
            val_2 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND();
            this.degreesPerSecond_ = val_7;
            val_4 = other.degreesPerSecond_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SECONDS val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.seconds_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS val_2 = null;
        val_5 = val_2;
        val_2 = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.SECONDS();
        this.seconds_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.degreesPerSecond_;
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
        this.degreesPerSecond_ = new ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.Types.DEGREESPERSECOND();
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
    private static ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS()
    {
        null = null;
        ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.DegreesPerSecondFieldNumber = new Google.Protobuf.MessageParser<CIRCLEPARAMETERS>(factory:  new System.Func<CIRCLEPARAMETERS>(object:  ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.<>c.<>9, method:  CIRCLEPARAMETERS ANIMATRONIC_DATA.Types.ATTACKTUNINGVALUES.Types.CIRCLEPARAMETERS.<>c::<.cctor>b__31_0()));
    }

}
