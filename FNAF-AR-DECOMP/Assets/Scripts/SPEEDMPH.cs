using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CPU_DATA.Types.SPEEDMPH : IMessage<ProtoData.CPU_DATA.Types.SPEEDMPH>, IMessage, IEquatable<ProtoData.CPU_DATA.Types.SPEEDMPH>, IDeepCloneable<ProtoData.CPU_DATA.Types.SPEEDMPH>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapSpeedMPHFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH mapSpeedMPH_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int TravelSpeedMPHFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double travelSpeedMPH_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH MapSpeedMPH { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double TravelSpeedMPH { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CPU_DATA.Types.SPEEDMPH> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<SPEEDMPH>)CPU_DATA.Types.SPEEDMPH.TravelSpeedMPHFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.CPU_DATA.Descriptor.NestedTypes.Item[3];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CPU_DATA.Types.SPEEDMPH.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPEEDMPH()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CPU_DATA.Types.SPEEDMPH(ProtoData.CPU_DATA.Types.SPEEDMPH other)
    {
        if(other.mapSpeedMPH_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.mapSpeedMPH_ = other.mapSpeedMPH_.Clone();
        this.travelSpeedMPH_ = other.travelSpeedMPH_;
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
    public ProtoData.CPU_DATA.Types.SPEEDMPH Clone()
    {
        return (SPEEDMPH)new CPU_DATA.Types.SPEEDMPH(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH get_MapSpeedMPH()
    {
        return (MAPSPEEDMPH)this.mapSpeedMPH_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapSpeedMPH(ProtoData.CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH value)
    {
        this.mapSpeedMPH_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_TravelSpeedMPH()
    {
        return (double)this.travelSpeedMPH_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_TravelSpeedMPH(double value)
    {
        this.travelSpeedMPH_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        SPEEDMPH val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CPU_DATA.Types.SPEEDMPH other)
    {
        var val_3;
        if(other == null)
        {
            goto label_7;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((System.Object.Equals(objA:  this.mapSpeedMPH_, objB:  other.mapSpeedMPH_)) != false)
        {
                if((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_7:
        val_3 = 0;
        return (bool)val_3;
        label_2:
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.mapSpeedMPH_ != null)
        {
                val_4 = this.mapSpeedMPH_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.travelSpeedMPH_ != 0f)
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
        MAPSPEEDMPH val_1;
        double val_2;
        if(this.mapSpeedMPH_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.mapSpeedMPH_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.mapSpeedMPH_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.travelSpeedMPH_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.travelSpeedMPH_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.travelSpeedMPH_;
        }
        
            output.WriteDouble(value:  val_2);
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
        var val_5;
        var val_6;
        if(this.mapSpeedMPH_ != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.mapSpeedMPH_)) + 1;
        }
        else
        {
                val_5 = 0;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields.CalculateSize() + ((this.travelSpeedMPH_ == 0f) ? (val_5) : (val_5 + 9));
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CPU_DATA.Types.SPEEDMPH other)
    {
        MAPSPEEDMPH val_4;
        MAPSPEEDMPH val_5;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.mapSpeedMPH_;
        if(val_5 == null)
        {
            goto label_5;
        }
        
        val_4 = this.mapSpeedMPH_;
        if(val_4 != null)
        {
            goto label_3;
        }
        
        CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH val_1 = null;
        val_4 = val_1;
        val_1 = new CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH();
        this.mapSpeedMPH_ = val_4;
        val_5 = other.mapSpeedMPH_;
        if(val_5 == null)
        {
            goto label_5;
        }
        
        label_3:
        if(other.mapSpeedMPH_.notUpgraded_ != 0f)
        {
                .notUpgraded_ = other.mapSpeedMPH_.notUpgraded_;
        }
        
        ._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  (CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH)[1152921524143279184]._unknownFields, other:  other.mapSpeedMPH_._unknownFields);
        label_5:
        if(other.travelSpeedMPH_ != 0f)
        {
                this.travelSpeedMPH_ = other.travelSpeedMPH_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_7;
        label_13:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_7;
        label_11:
        if(this.mapSpeedMPH_ == null)
        {
            goto label_3;
        }
        
        label_9:
        input.ReadMessage(builder:  this.mapSpeedMPH_);
        goto label_7;
        label_12:
        this.travelSpeedMPH_ = input.ReadDouble();
        goto label_7;
        label_3:
        this.mapSpeedMPH_ = new CPU_DATA.Types.SPEEDMPH.Types.MAPSPEEDMPH();
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_7:
        uint val_4 = input.ReadTag();
        if(val_4 == 10)
        {
            goto label_11;
        }
        
        if(val_4 == 17)
        {
            goto label_12;
        }
        
        if(val_4 != 0)
        {
            goto label_13;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CPU_DATA.Types.SPEEDMPH()
    {
        null = null;
        CPU_DATA.Types.SPEEDMPH.TravelSpeedMPHFieldNumber = new Google.Protobuf.MessageParser<SPEEDMPH>(factory:  new System.Func<SPEEDMPH>(object:  CPU_DATA.Types.SPEEDMPH.<>c.<>9, method:  SPEEDMPH CPU_DATA.Types.SPEEDMPH.<>c::<.cctor>b__31_0()));
    }

}
