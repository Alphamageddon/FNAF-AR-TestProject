using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS : IMessage<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS>, IMessage, IEquatable<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS>, IDeepCloneable<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int LootTableIdFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string lootTableId_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string LootTableId { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<REWARDS>)DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.LootTableIdFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DAILY_CHALLENGE_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS()
    {
        this.lootTableId_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS other)
    {
        if(other != null)
        {
                this.lootTableId_ = other.lootTableId_;
        }
        else
        {
                this.lootTableId_ = 15026800;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS Clone()
    {
        return (REWARDS)new DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_LootTableId()
    {
        return (string)this.lootTableId_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_LootTableId(string value)
    {
        this.lootTableId_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        REWARDS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS other)
    {
        var val_2;
        if(other == null)
        {
            goto label_0;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.String.op_Inequality(a:  this.lootTableId_, b:  other.lootTableId_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        label_0:
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
        var val_3;
        val_2 = 0;
        if(this.lootTableId_.Length != 0)
        {
                val_3 = this.lootTableId_ ^ 1;
        }
        else
        {
                val_3 = 1;
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
        string val_2;
        if(this.lootTableId_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_2 = this.lootTableId_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_2 = this.lootTableId_;
        }
        
            output.WriteString(value:  val_2);
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
        if(this.lootTableId_.Length != 0)
        {
                val_4 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.lootTableId_)) + 1;
        }
        else
        {
                val_4 = 0;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields.CalculateSize() + val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.lootTableId_.Length != 0)
        {
                this.LootTableId = other.lootTableId_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_1;
        label_5:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_1;
        label_4:
        this.LootTableId = input.ReadString();
        label_1:
        uint val_3 = input.ReadTag();
        if(val_3 == 10)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_5;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS()
    {
        null = null;
        DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.LootTableIdFieldNumber = new Google.Protobuf.MessageParser<REWARDS>(factory:  new System.Func<REWARDS>(object:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.<>c.<>9, method:  REWARDS DAILY_CHALLENGE_DATA.Types.ENTRY.Types.REWARDS.<>c::<.cctor>b__25_0()));
    }

}
