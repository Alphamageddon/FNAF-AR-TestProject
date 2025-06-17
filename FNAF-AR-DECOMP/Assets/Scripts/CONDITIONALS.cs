using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS : IMessage<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS>, IMessage, IEquatable<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS>, IDeepCloneable<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CONDITIONALS>)DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS._parser;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return DAILY_CHALLENGE_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS other)
    {
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS Clone()
    {
        return (CONDITIONALS)new DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        if(other != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        return false;
        label_2:
        if(other == this)
        {
                return false;
        }
        
        return System.Object.Equals(objA:  this._unknownFields, objB:  other);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS other)
    {
        if(other == null)
        {
                return false;
        }
        
        if(other == this)
        {
                return true;
        }
        
        return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        Google.Protobuf.UnknownFieldSet val_1 = this._unknownFields;
        if(val_1 == null)
        {
                return 1;
        }
        
        val_1 = val_1 ^ 1;
        return (int)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        if(this._unknownFields == null)
        {
                return;
        }
        
        this._unknownFields.WriteTo(output:  output);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CalculateSize()
    {
        if(this._unknownFields == null)
        {
                return (int)this._unknownFields;
        }
        
        return this._unknownFields.CalculateSize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS other)
    {
        if(other == null)
        {
                return;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_0;
        label_2:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_0:
        if(input.ReadTag() != 0)
        {
            goto label_2;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS()
    {
        null = null;
        DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS._parser = new Google.Protobuf.MessageParser<CONDITIONALS>(factory:  new System.Func<CONDITIONALS>(object:  DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS.<>c.<>9, method:  CONDITIONALS DAILY_CHALLENGE_DATA.Types.ENTRY.Types.CONDITIONALS.<>c::<.cctor>b__21_0()));
    }

}
