using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class ATTACK_DATA.Types.FOOTSTEPS : IMessage<ProtoData.ATTACK_DATA.Types.FOOTSTEPS>, IMessage, IEquatable<ProtoData.ATTACK_DATA.Types.FOOTSTEPS>, IDeepCloneable<ProtoData.ATTACK_DATA.Types.FOOTSTEPS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int WalkFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG walk_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int RunFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG run_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG Walk { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG Run { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.ATTACK_DATA.Types.FOOTSTEPS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<FOOTSTEPS>)ATTACK_DATA.Types.FOOTSTEPS.RunFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return ProtoData.ATTACK_DATA.Descriptor.NestedTypes.Item[17];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return ATTACK_DATA.Types.FOOTSTEPS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FOOTSTEPS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ATTACK_DATA.Types.FOOTSTEPS(ProtoData.ATTACK_DATA.Types.FOOTSTEPS other)
    {
        FOOTSTEPCONFIG val_4;
        if(other.walk_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        this.walk_ = other.walk_.Clone();
        val_4 = other.run_;
        this.run_ = val_4.Clone();
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
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS Clone()
    {
        return (FOOTSTEPS)new ATTACK_DATA.Types.FOOTSTEPS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG get_Walk()
    {
        return (FOOTSTEPCONFIG)this.walk_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Walk(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG value)
    {
        this.walk_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG get_Run()
    {
        return (FOOTSTEPCONFIG)this.run_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Run(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG value)
    {
        this.run_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        FOOTSTEPS val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.ATTACK_DATA.Types.FOOTSTEPS other)
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
        
        if((System.Object.Equals(objA:  this.walk_, objB:  other.walk_)) != false)
        {
                if((System.Object.Equals(objA:  this.run_, objB:  other.run_)) != false)
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
        if(this.walk_ != null)
        {
                val_3 = this.walk_ ^ 1;
        }
        else
        {
                val_3 = 1;
        }
        
        if(this.run_ != null)
        {
                val_3 = this.run_ ^ val_3;
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
        FOOTSTEPCONFIG val_1;
        FOOTSTEPCONFIG val_2;
        if(this.walk_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.walk_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.walk_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.run_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.run_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.run_;
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
        FOOTSTEPCONFIG val_5 = this.walk_;
        if(val_5 != null)
        {
                val_5 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_5 = this.walk_)) + 1;
        }
        
        if(this.run_ != null)
        {
                val_5 = (val_5 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.run_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + val_5;
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.ATTACK_DATA.Types.FOOTSTEPS other)
    {
        FOOTSTEPCONFIG val_4;
        FOOTSTEPCONFIG val_5;
        FOOTSTEPCONFIG val_6;
        FOOTSTEPCONFIG val_7;
        if(other == null)
        {
                return;
        }
        
        val_5 = other.walk_;
        if(val_5 != null)
        {
                val_6 = this.walk_;
            if(val_6 == null)
        {
                ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG val_1 = null;
            val_6 = val_1;
            val_1 = new ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG();
            this.walk_ = val_6;
            val_5 = other.walk_;
        }
        
            val_1.MergeFrom(other:  val_5);
        }
        
        val_4 = other.run_;
        if(val_4 != null)
        {
                val_7 = this.run_;
            if(val_7 == null)
        {
                ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG val_2 = null;
            val_7 = val_2;
            val_2 = new ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG();
            this.run_ = val_7;
            val_4 = other.run_;
        }
        
            val_2.MergeFrom(other:  val_4);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        FOOTSTEPCONFIG val_5;
        goto label_8;
        label_14:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_8;
        label_12:
        val_5 = this.walk_;
        if(val_5 != null)
        {
            goto label_3;
        }
        
        ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG val_2 = null;
        val_5 = val_2;
        val_2 = new ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG();
        this.walk_ = val_5;
        if(input != null)
        {
            goto label_9;
        }
        
        goto label_10;
        label_13:
        val_5 = this.run_;
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
        this.run_ = new ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG();
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
    private static ATTACK_DATA.Types.FOOTSTEPS()
    {
        null = null;
        ATTACK_DATA.Types.FOOTSTEPS.RunFieldNumber = new Google.Protobuf.MessageParser<FOOTSTEPS>(factory:  new System.Func<FOOTSTEPS>(object:  ATTACK_DATA.Types.FOOTSTEPS.<>c.<>9, method:  FOOTSTEPS ATTACK_DATA.Types.FOOTSTEPS.<>c::<.cctor>b__31_0()));
    }

}
