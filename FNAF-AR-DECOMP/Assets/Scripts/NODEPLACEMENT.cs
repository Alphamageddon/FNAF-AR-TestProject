using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ConnectionsFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS connections_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PrefNodeToNodeDistFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double prefNodeToNodeDist_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS Connections { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double PrefNodeToNodeDist { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<NODEPLACEMENT>)CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.PrefNodeToNodeDistFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[6];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT other)
    {
        if(other.connections_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_3;
        }
        
        label_4:
        label_3:
        this.connections_ = other.connections_.Clone();
        this.prefNodeToNodeDist_ = other.prefNodeToNodeDist_;
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
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT Clone()
    {
        return (NODEPLACEMENT)new CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS get_Connections()
    {
        return (CONNECTIONS)this.connections_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Connections(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS value)
    {
        this.connections_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_PrefNodeToNodeDist()
    {
        return (double)this.prefNodeToNodeDist_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PrefNodeToNodeDist(double value)
    {
        this.prefNodeToNodeDist_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        NODEPLACEMENT val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT other)
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
        
        if((System.Object.Equals(objA:  this.connections_, objB:  other.connections_)) != false)
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
        if(this.connections_ != null)
        {
                val_4 = this.connections_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.prefNodeToNodeDist_ != 0f)
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
        CONNECTIONS val_1;
        double val_2;
        if(this.connections_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.connections_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.connections_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.prefNodeToNodeDist_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.prefNodeToNodeDist_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.prefNodeToNodeDist_;
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
        if(this.connections_ != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.connections_)) + 1;
        }
        else
        {
                val_5 = 0;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields.CalculateSize() + ((this.prefNodeToNodeDist_ == 0f) ? (val_5) : (val_5 + 9));
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT other)
    {
        CONNECTIONS val_3;
        CONNECTIONS val_4;
        if(other == null)
        {
                return;
        }
        
        val_3 = other.connections_;
        if(val_3 != null)
        {
                val_4 = this.connections_;
            if(val_4 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS val_1 = null;
            val_4 = val_1;
            val_1 = new CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS();
            this.connections_ = val_4;
            val_3 = other.connections_;
        }
        
            val_1.MergeFrom(other:  val_3);
        }
        
        if(other.prefNodeToNodeDist_ != 0f)
        {
                this.prefNodeToNodeDist_ = other.prefNodeToNodeDist_;
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
        if(this.connections_ == null)
        {
            goto label_3;
        }
        
        label_9:
        input.ReadMessage(builder:  this.connections_);
        goto label_7;
        label_12:
        this.prefNodeToNodeDist_ = input.ReadDouble();
        goto label_7;
        label_3:
        this.connections_ = new CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.Types.CONNECTIONS();
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
    private static CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.PrefNodeToNodeDistFieldNumber = new Google.Protobuf.MessageParser<NODEPLACEMENT>(factory:  new System.Func<NODEPLACEMENT>(object:  CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.<>c.<>9, method:  NODEPLACEMENT CONFIG_DATA.Types.ENTRY.Types.NODEPLACEMENT.<>c::<.cctor>b__31_0()));
    }

}
