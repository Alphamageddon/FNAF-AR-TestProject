using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOnTimerFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER flashlightOnTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightFlickerTimerFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER flashlightFlickerTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOffTimerFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER flashlightOffTimer_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int FlashlightOffMultFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double flashlightOffMult_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER FlashlightOnTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER FlashlightFlickerTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER FlashlightOffTimer { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double FlashlightOffMult { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FLASHLIGHTBEHAVIOR>)CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.FlashlightOffMultFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[5];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR other)
    {
        FLASHLIGHTFLICKERTIMER val_5;
        FLASHLIGHTOFFTIMER val_6;
        if(other.flashlightOnTimer_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        this.flashlightOnTimer_ = other.flashlightOnTimer_.Clone();
        val_5 = other.flashlightFlickerTimer_;
        this.flashlightFlickerTimer_ = val_5.Clone();
        val_6 = other.flashlightOffTimer_;
        this.flashlightOffTimer_ = val_6.Clone();
        this.flashlightOffMult_ = other.flashlightOffMult_;
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR Clone()
    {
        return (FLASHLIGHTBEHAVIOR)new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER get_FlashlightOnTimer()
    {
        return (FLASHLIGHTONTIMER)this.flashlightOnTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOnTimer(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER value)
    {
        this.flashlightOnTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER get_FlashlightFlickerTimer()
    {
        return (FLASHLIGHTFLICKERTIMER)this.flashlightFlickerTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightFlickerTimer(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER value)
    {
        this.flashlightFlickerTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER get_FlashlightOffTimer()
    {
        return (FLASHLIGHTOFFTIMER)this.flashlightOffTimer_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOffTimer(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER value)
    {
        this.flashlightOffTimer_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_FlashlightOffMult()
    {
        return (double)this.flashlightOffMult_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_FlashlightOffMult(double value)
    {
        this.flashlightOffMult_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FLASHLIGHTBEHAVIOR val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR other)
    {
        var val_5;
        if(other == null)
        {
            goto label_9;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((System.Object.Equals(objA:  this.flashlightOnTimer_, objB:  other.flashlightOnTimer_)) != false) && ((System.Object.Equals(objA:  this.flashlightFlickerTimer_, objB:  other.flashlightFlickerTimer_)) != false)) && ((System.Object.Equals(objA:  this.flashlightOffTimer_, objB:  other.flashlightOffTimer_)) != false))
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_9:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        val_5 = 1;
        return (bool)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.flashlightOnTimer_ != null)
        {
                val_4 = this.flashlightOnTimer_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.flashlightFlickerTimer_ != null)
        {
                val_4 = this.flashlightFlickerTimer_ ^ val_4;
        }
        
        if(this.flashlightOffTimer_ != null)
        {
                val_4 = this.flashlightOffTimer_ ^ val_4;
        }
        
        if(this.flashlightOffMult_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        FLASHLIGHTONTIMER val_1;
        FLASHLIGHTFLICKERTIMER val_2;
        FLASHLIGHTOFFTIMER val_3;
        double val_4;
        if(this.flashlightOnTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.flashlightOnTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.flashlightOnTimer_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.flashlightFlickerTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.flashlightFlickerTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.flashlightFlickerTimer_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.flashlightOffTimer_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.flashlightOffTimer_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.flashlightOffTimer_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.flashlightOffMult_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.flashlightOffMult_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.flashlightOffMult_;
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
        var val_9;
        var val_10;
        if(this.flashlightOnTimer_ != null)
        {
                val_9 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightOnTimer_)) + 1;
        }
        else
        {
                val_9 = 0;
        }
        
        if(this.flashlightFlickerTimer_ != null)
        {
                val_9 = (val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightFlickerTimer_))) + 1;
        }
        
        if(this.flashlightOffTimer_ != null)
        {
                int val_5 = val_9 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.flashlightOffTimer_));
            val_9 = val_5 + 1;
        }
        
        val_5 = val_9 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + ((this.flashlightOffMult_ == 0f) ? (val_9) : (val_5));
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR other)
    {
        FLASHLIGHTOFFTIMER val_5;
        FLASHLIGHTONTIMER val_6;
        FLASHLIGHTONTIMER val_7;
        FLASHLIGHTFLICKERTIMER val_8;
        FLASHLIGHTFLICKERTIMER val_9;
        FLASHLIGHTOFFTIMER val_10;
        if(other == null)
        {
                return;
        }
        
        val_6 = other.flashlightOnTimer_;
        if(val_6 != null)
        {
                val_7 = this.flashlightOnTimer_;
            if(val_7 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER val_1 = null;
            val_7 = val_1;
            val_1 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER();
            this.flashlightOnTimer_ = val_7;
            val_6 = other.flashlightOnTimer_;
        }
        
            val_1.MergeFrom(other:  val_6);
        }
        
        val_8 = other.flashlightFlickerTimer_;
        if(val_8 != null)
        {
                val_9 = this.flashlightFlickerTimer_;
            if(val_9 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER val_2 = null;
            val_9 = val_2;
            val_2 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER();
            this.flashlightFlickerTimer_ = val_9;
            val_8 = other.flashlightFlickerTimer_;
        }
        
            val_2.MergeFrom(other:  val_8);
        }
        
        val_5 = other.flashlightOffTimer_;
        if(val_5 != null)
        {
                val_10 = this.flashlightOffTimer_;
            if(val_10 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER val_3 = null;
            val_10 = val_3;
            val_3 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER();
            this.flashlightOffTimer_ = val_10;
            val_5 = other.flashlightOffTimer_;
        }
        
            val_3.MergeFrom(other:  val_5);
        }
        
        if(other.flashlightOffMult_ != 0f)
        {
                this.flashlightOffMult_ = other.flashlightOffMult_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        FLASHLIGHTFLICKERTIMER val_7;
        CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER val_5 = 22495;
        goto label_18;
        label_22:
        if(val_5 > 18)
        {
            goto label_2;
        }
        
        if(val_5 == 10)
        {
            goto label_3;
        }
        
        if(val_5 != 18)
        {
            goto label_9;
        }
        
        val_7 = this.flashlightFlickerTimer_;
        if(val_7 != null)
        {
            goto label_13;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER val_1 = null;
        val_7 = val_1;
        val_1 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTFLICKERTIMER();
        this.flashlightFlickerTimer_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_2:
        if(val_5 == 26)
        {
            goto label_8;
        }
        
        if(val_5 != 33)
        {
            goto label_9;
        }
        
        this.flashlightOffMult_ = input.ReadDouble();
        goto label_18;
        label_9:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_18;
        label_3:
        val_7 = this.flashlightOnTimer_;
        if(val_7 != null)
        {
            goto label_13;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER val_4 = null;
        val_7 = val_4;
        val_4 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTONTIMER();
        this.flashlightOnTimer_ = val_7;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_8:
        val_7 = this.flashlightOffTimer_;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_13:
        if(input != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        input.ReadMessage(builder:  val_7);
        goto label_18;
        label_16:
        val_5 = new CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.Types.FLASHLIGHTOFFTIMER();
        this.flashlightOffTimer_ = val_5;
        if(input != null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_18:
        if(input.ReadTag() != 0)
        {
            goto label_22;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.FlashlightOffMultFieldNumber = new Google.Protobuf.MessageParser<FLASHLIGHTBEHAVIOR>(factory:  new System.Func<FLASHLIGHTBEHAVIOR>(object:  CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.<>c.<>9, method:  FLASHLIGHTBEHAVIOR CONFIG_DATA.Types.ENTRY.Types.FLASHLIGHTBEHAVIOR.<>c::<.cctor>b__41_0()));
    }

}
