using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.TELEPORTREPOSITION : IMessage<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int AngleFromCameraFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE angleFromCamera_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DistanceFromCameraFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.RANGE distanceFromCamera_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE AngleFromCamera { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE DistanceFromCamera { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<TELEPORTREPOSITION>)ATTACK_DATA.Types.TELEPORTREPOSITION.DistanceFromCameraFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.TELEPORTREPOSITION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.TELEPORTREPOSITION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.TELEPORTREPOSITION(ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        if(other.angleFromCamera_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.angleFromCamera_ = other.angleFromCamera_.Clone();
        val_4 = other.distanceFromCamera_;
        this.distanceFromCamera_ = val_4.Clone();
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
    public ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION Clone()
    {
        return (TELEPORTREPOSITION)new ATTACK_DATA.Types.TELEPORTREPOSITION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_AngleFromCamera()
    {
        return (RANGE)this.angleFromCamera_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_AngleFromCamera(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.angleFromCamera_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.RANGE get_DistanceFromCamera()
    {
        return (RANGE)this.distanceFromCamera_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DistanceFromCamera(ProtoData.ATTACK_DATA.Types.RANGE value)
    {
        this.distanceFromCamera_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        TELEPORTREPOSITION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION other)
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
        
        if((System.Object.Equals(objA:  this.angleFromCamera_, objB:  other.angleFromCamera_)) != false)
        {
                if((System.Object.Equals(objA:  this.distanceFromCamera_, objB:  other.distanceFromCamera_)) != false)
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
        if(this.angleFromCamera_ != null)
        {
                val_3 = this.angleFromCamera_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.distanceFromCamera_ != null)
        {
                val_3 = this.distanceFromCamera_ ^ val_3;
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
        ATTACK_DATA.Types.RANGE val_1;
        ATTACK_DATA.Types.RANGE val_2;
        if(this.angleFromCamera_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.angleFromCamera_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.angleFromCamera_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.distanceFromCamera_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.distanceFromCamera_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.distanceFromCamera_;
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
        ATTACK_DATA.Types.RANGE val_5 = this.angleFromCamera_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.angleFromCamera_)) + 1;
        }
        
        if(this.distanceFromCamera_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.distanceFromCamera_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.TELEPORTREPOSITION other)
    {
        ATTACK_DATA.Types.RANGE val_4;
        ATTACK_DATA.Types.RANGE val_5;
        ATTACK_DATA.Types.RANGE val_6;
        ATTACK_DATA.Types.RANGE val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.angleFromCamera_;
        if(val_5 != null)
        {
                val_6 = this.angleFromCamera_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.RANGE val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.RANGE();
            this.angleFromCamera_ = val_6;
            val_5 = other.angleFromCamera_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.distanceFromCamera_;
        if(val_4 != null)
        {
                val_7 = this.distanceFromCamera_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.RANGE val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.RANGE();
            this.distanceFromCamera_ = val_7;
            val_4 = other.distanceFromCamera_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        ATTACK_DATA.Types.RANGE val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.angleFromCamera_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.RANGE val_2 = null;
        val_5 = val_2;
        val_2 = new ATTACK_DATA.Types.RANGE();
        this.angleFromCamera_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.distanceFromCamera_;
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
        this.distanceFromCamera_ = new ATTACK_DATA.Types.RANGE();
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
    private static ATTACK_DATA.Types.TELEPORTREPOSITION()
    {
        null = null;
        ATTACK_DATA.Types.TELEPORTREPOSITION.DistanceFromCameraFieldNumber = new Google.Protobuf.MessageParser<TELEPORTREPOSITION>(factory:  new System.Func<TELEPORTREPOSITION>(object:  ATTACK_DATA.Types.TELEPORTREPOSITION.<>c.<>9, method:  TELEPORTREPOSITION ATTACK_DATA.Types.TELEPORTREPOSITION.<>c::<.cctor>b__30_0()));
    }

}
