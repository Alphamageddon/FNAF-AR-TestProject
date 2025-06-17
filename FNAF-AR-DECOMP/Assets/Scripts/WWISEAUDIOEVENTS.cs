using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS : IMessage<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS>, IMessage, IEquatable<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS>, IDeepCloneable<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Event1FieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO event1_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Event2FieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO event2_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Event3FieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO event3_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Event4FieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO event4_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int Event5FieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO event5_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Event1 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Event2 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Event3 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Event4 { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO Event5 { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<WWISEAUDIOEVENTS>)AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Event5FieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return AUDIO_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS other)
    {
        WWISEEVENTINFO val_7;
        WWISEEVENTINFO val_8;
        WWISEEVENTINFO val_9;
        WWISEEVENTINFO val_10;
        if(other.event1_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        this.event1_ = other.event1_.Clone();
        val_7 = other.event2_;
        this.event2_ = val_7.Clone();
        val_8 = other.event3_;
        this.event3_ = val_8.Clone();
        val_9 = other.event4_;
        this.event4_ = val_9.Clone();
        val_10 = other.event5_;
        this.event5_ = val_10.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS Clone()
    {
        return (WWISEAUDIOEVENTS)new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO get_Event1()
    {
        return (WWISEEVENTINFO)this.event1_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Event1(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO value)
    {
        this.event1_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO get_Event2()
    {
        return (WWISEEVENTINFO)this.event2_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Event2(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO value)
    {
        this.event2_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO get_Event3()
    {
        return (WWISEEVENTINFO)this.event3_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Event3(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO value)
    {
        this.event3_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO get_Event4()
    {
        return (WWISEEVENTINFO)this.event4_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Event4(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO value)
    {
        this.event4_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO get_Event5()
    {
        return (WWISEEVENTINFO)this.event5_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Event5(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO value)
    {
        this.event5_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        WWISEAUDIOEVENTS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS other)
    {
        var val_6;
        if(other == null)
        {
            goto label_6;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if(((((System.Object.Equals(objA:  this.event1_, objB:  other.event1_)) != false) && ((System.Object.Equals(objA:  this.event2_, objB:  other.event2_)) != false)) && ((System.Object.Equals(objA:  this.event3_, objB:  other.event3_)) != false)) && ((System.Object.Equals(objA:  this.event4_, objB:  other.event4_)) != false))
        {
                if((System.Object.Equals(objA:  this.event5_, objB:  other.event5_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_6:
        val_6 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_3;
        if(this.event1_ != null)
        {
                val_3 = this.event1_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.event2_ != null)
        {
                val_3 = this.event2_ ^ val_3;
        }
        
        if(this.event3_ != null)
        {
                val_3 = this.event3_ ^ val_3;
        }
        
        if(this.event4_ != null)
        {
                val_3 = this.event4_ ^ val_3;
        }
        
        if(this.event5_ != null)
        {
                val_3 = this.event5_ ^ val_3;
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
        WWISEEVENTINFO val_1;
        WWISEEVENTINFO val_2;
        WWISEEVENTINFO val_3;
        WWISEEVENTINFO val_4;
        WWISEEVENTINFO val_5;
        if(this.event1_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.event1_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.event1_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.event2_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.event2_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.event2_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.event3_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.event3_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.event3_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.event4_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  34);
            val_4 = this.event4_;
        }
        else
        {
                0.WriteRawTag(b1:  34);
            val_4 = this.event4_;
        }
        
            output.WriteMessage(value:  val_4);
        }
        
        if(this.event5_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.event5_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.event5_;
        }
        
            output.WriteMessage(value:  val_5);
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
        WWISEEVENTINFO val_11 = this.event1_;
        if(val_11 != null)
        {
                val_11 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_11 = this.event1_)) + 1;
        }
        
        if(this.event2_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.event2_))) + 1;
        }
        
        if(this.event3_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.event3_))) + 1;
        }
        
        if(this.event4_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.event4_))) + 1;
        }
        
        if(this.event5_ != null)
        {
                val_11 = (val_11 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.event5_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_11;
        }
        
        val_11 = this._unknownFields.CalculateSize() + val_11;
        return (int)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS other)
    {
        WWISEEVENTINFO val_7;
        WWISEEVENTINFO val_8;
        WWISEEVENTINFO val_9;
        WWISEEVENTINFO val_10;
        WWISEEVENTINFO val_11;
        WWISEEVENTINFO val_12;
        WWISEEVENTINFO val_13;
        WWISEEVENTINFO val_14;
        WWISEEVENTINFO val_15;
        WWISEEVENTINFO val_16;
        if(other == null)
        {
                return;
        }
        
        val_8 = other.event1_;
        if(val_8 != null)
        {
                val_9 = this.event1_;
            if(val_9 == null)
        {
                AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_1 = null;
            val_9 = val_1;
            val_1 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
            this.event1_ = val_9;
            val_8 = other.event1_;
        }
        
            val_1.MergeFrom(other:  val_8);
        }
        
        val_10 = other.event2_;
        if(val_10 != null)
        {
                val_11 = this.event2_;
            if(val_11 == null)
        {
                AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_2 = null;
            val_11 = val_2;
            val_2 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
            this.event2_ = val_11;
            val_10 = other.event2_;
        }
        
            val_2.MergeFrom(other:  val_10);
        }
        
        val_12 = other.event3_;
        if(val_12 != null)
        {
                val_13 = this.event3_;
            if(val_13 == null)
        {
                AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_3 = null;
            val_13 = val_3;
            val_3 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
            this.event3_ = val_13;
            val_12 = other.event3_;
        }
        
            val_3.MergeFrom(other:  val_12);
        }
        
        val_14 = other.event4_;
        if(val_14 != null)
        {
                val_15 = this.event4_;
            if(val_15 == null)
        {
                AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_4 = null;
            val_15 = val_4;
            val_4 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
            this.event4_ = val_15;
            val_14 = other.event4_;
        }
        
            val_4.MergeFrom(other:  val_14);
        }
        
        val_7 = other.event5_;
        if(val_7 != null)
        {
                val_16 = this.event5_;
            if(val_16 == null)
        {
                AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_5 = null;
            val_16 = val_5;
            val_5 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
            this.event5_ = val_16;
            val_7 = other.event5_;
        }
        
            val_5.MergeFrom(other:  val_7);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        WWISEEVENTINFO val_8;
        goto label_23;
        label_27:
        if(54523 > 18)
        {
            goto label_2;
        }
        
        if(54523 == 10)
        {
            goto label_3;
        }
        
        if(54523 != 18)
        {
            goto label_10;
        }
        
        val_8 = this.event2_;
        if(val_8 != null)
        {
            goto label_18;
        }
        
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_1 = null;
        val_8 = val_1;
        val_1 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
        this.event2_ = val_8;
        if(input != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_2:
        if(54523 == 26)
        {
            goto label_8;
        }
        
        if(54523 == 34)
        {
            goto label_9;
        }
        
        if(54523 != 42)
        {
            goto label_10;
        }
        
        val_8 = this.event5_;
        if(val_8 != null)
        {
            goto label_18;
        }
        
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_2 = null;
        val_8 = val_2;
        val_2 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
        this.event5_ = val_8;
        if(input != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_10:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_23;
        label_3:
        val_8 = this.event1_;
        if(val_8 != null)
        {
            goto label_18;
        }
        
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_4 = null;
        val_8 = val_4;
        val_4 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
        this.event1_ = val_8;
        if(input != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_9:
        val_8 = this.event4_;
        if(val_8 != null)
        {
            goto label_18;
        }
        
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO val_5 = null;
        val_8 = val_5;
        val_5 = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
        this.event4_ = val_8;
        if(input != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_8:
        val_8 = this.event3_;
        if(val_8 == null)
        {
            goto label_21;
        }
        
        label_18:
        if(input != null)
        {
            goto label_24;
        }
        
        label_25:
        label_24:
        input.ReadMessage(builder:  val_8);
        goto label_23;
        label_21:
        this.event3_ = new AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO();
        if(input != null)
        {
            goto label_24;
        }
        
        goto label_25;
        label_23:
        if(input.ReadTag() != 0)
        {
            goto label_27;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS()
    {
        null = null;
        AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Event5FieldNumber = new Google.Protobuf.MessageParser<WWISEAUDIOEVENTS>(factory:  new System.Func<WWISEAUDIOEVENTS>(object:  AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.<>c.<>9, method:  WWISEAUDIOEVENTS AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.<>c::<.cctor>b__46_0()));
    }

}
