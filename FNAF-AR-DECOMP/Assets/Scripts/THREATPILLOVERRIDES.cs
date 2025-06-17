using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES : IMessage<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES>, IMessage, IEquatable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES>, IDeepCloneable<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int SpawnBehaviorFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR spawnBehavior_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetachedMovementBehaviorFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR detachedMovementBehavior_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR SpawnBehavior { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR DetachedMovementBehavior { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<THREATPILLOVERRIDES>)ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.DetachedMovementBehaviorFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ESSENCE_TYPES_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES other)
    {
        DETACHEDMOVEMENTBEHAVIOR val_4;
        if(other.spawnBehavior_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.spawnBehavior_ = other.spawnBehavior_.Clone();
        val_4 = other.detachedMovementBehavior_;
        this.detachedMovementBehavior_ = val_4.Clone();
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
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES Clone()
    {
        return (THREATPILLOVERRIDES)new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR get_SpawnBehavior()
    {
        return (SPAWNBEHAVIOR)this.spawnBehavior_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_SpawnBehavior(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR value)
    {
        this.spawnBehavior_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR get_DetachedMovementBehavior()
    {
        return (DETACHEDMOVEMENTBEHAVIOR)this.detachedMovementBehavior_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DetachedMovementBehavior(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR value)
    {
        this.detachedMovementBehavior_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        THREATPILLOVERRIDES val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES other)
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
        
        if((System.Object.Equals(objA:  this.spawnBehavior_, objB:  other.spawnBehavior_)) != false)
        {
                if((System.Object.Equals(objA:  this.detachedMovementBehavior_, objB:  other.detachedMovementBehavior_)) != false)
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
        if(this.spawnBehavior_ != null)
        {
                val_3 = this.spawnBehavior_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.detachedMovementBehavior_ != null)
        {
                val_3 = this.detachedMovementBehavior_ ^ val_3;
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
        SPAWNBEHAVIOR val_1;
        DETACHEDMOVEMENTBEHAVIOR val_2;
        if(this.spawnBehavior_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.spawnBehavior_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.spawnBehavior_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.detachedMovementBehavior_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.detachedMovementBehavior_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.detachedMovementBehavior_;
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
        SPAWNBEHAVIOR val_5 = this.spawnBehavior_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.spawnBehavior_)) + 1;
        }
        
        if(this.detachedMovementBehavior_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.detachedMovementBehavior_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES other)
    {
        DETACHEDMOVEMENTBEHAVIOR val_4;
        SPAWNBEHAVIOR val_5;
        SPAWNBEHAVIOR val_6;
        DETACHEDMOVEMENTBEHAVIOR val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.spawnBehavior_;
        if(val_5 != null)
        {
                val_6 = this.spawnBehavior_;
            if(val_6 == null)
        {
                ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR val_1 = null;
            val_6 = val_1;
            val_1 = new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR();
            this.spawnBehavior_ = val_6;
            val_5 = other.spawnBehavior_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.detachedMovementBehavior_;
        if(val_4 != null)
        {
                val_7 = this.detachedMovementBehavior_;
            if(val_7 == null)
        {
                ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR val_2 = null;
            val_7 = val_2;
            val_2 = new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR();
            this.detachedMovementBehavior_ = val_7;
            val_4 = other.detachedMovementBehavior_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        SPAWNBEHAVIOR val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.spawnBehavior_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR val_2 = null;
        val_5 = val_2;
        val_2 = new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.SPAWNBEHAVIOR();
        this.spawnBehavior_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.detachedMovementBehavior_;
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
        this.detachedMovementBehavior_ = new ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.Types.DETACHEDMOVEMENTBEHAVIOR();
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
    private static ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES()
    {
        null = null;
        ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.DetachedMovementBehaviorFieldNumber = new Google.Protobuf.MessageParser<THREATPILLOVERRIDES>(factory:  new System.Func<THREATPILLOVERRIDES>(object:  ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.<>c.<>9, method:  THREATPILLOVERRIDES ESSENCE_TYPES_DATA.Types.ENTRY.Types.THREATPILLOVERRIDES.<>c::<.cctor>b__31_0()));
    }

}
