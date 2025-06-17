using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class LOGIN_REPEAT_DATA : IMessage<ProtoData.LOGIN_REPEAT_DATA>, IMessage, IEquatable<ProtoData.LOGIN_REPEAT_DATA>, IDeepCloneable<ProtoData.LOGIN_REPEAT_DATA>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Google.Protobuf.MessageParser<ProtoData.LOGIN_REPEAT_DATA> _parser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.UnknownFieldSet _unknownFields;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int EntriesFieldNumber = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Google.Protobuf.FieldCodec<ProtoData.LOGIN_REPEAT_DATA.Types.ENTRY> _repeated_entries_codec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Google.Protobuf.Collections.RepeatedField<ProtoData.LOGIN_REPEAT_DATA.Types.ENTRY> entries_;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.MessageParser<ProtoData.LOGIN_REPEAT_DATA> Parser { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Google.Protobuf.Collections.RepeatedField<ProtoData.LOGIN_REPEAT_DATA.Types.ENTRY> Entries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.MessageParser<ProtoData.LOGIN_REPEAT_DATA> get_Parser()
        {
            null = null;
            return (Google.Protobuf.MessageParser<ProtoData.LOGIN_REPEAT_DATA>)ProtoData.LOGIN_REPEAT_DATA.EntriesFieldNumber;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return ProtoData.LOGINREPEATDATAReflection.Descriptor.MessageTypes.Item[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
        {
            return ProtoData.LOGIN_REPEAT_DATA.Descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LOGIN_REPEAT_DATA()
        {
            this.entries_ = new Google.Protobuf.Collections.RepeatedField<ENTRY>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LOGIN_REPEAT_DATA(ProtoData.LOGIN_REPEAT_DATA other)
        {
            this.entries_ = other.entries_.Clone();
            this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.LOGIN_REPEAT_DATA Clone()
        {
            return (ProtoData.LOGIN_REPEAT_DATA)new ProtoData.LOGIN_REPEAT_DATA(other:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Google.Protobuf.Collections.RepeatedField<ProtoData.LOGIN_REPEAT_DATA.Types.ENTRY> get_Entries()
        {
            return (Google.Protobuf.Collections.RepeatedField<ENTRY>)this.entries_;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object other)
        {
            ProtoData.LOGIN_REPEAT_DATA val_1;
            if(other != null)
            {
                    other = (null == null) ? other : 0;
                return this.Equals(other:  val_1 = 0);
            }
            
            return this.Equals(other:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(ProtoData.LOGIN_REPEAT_DATA other)
        {
            Google.Protobuf.Collections.RepeatedField<ENTRY> val_2;
            var val_3;
            if(other == null)
            {
                goto label_4;
            }
            
            if(other == this)
            {
                goto label_2;
            }
            
            val_2 = this.entries_;
            if((val_2.Equals(other:  other.entries_)) != false)
            {
                    return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
            }
            
            label_4:
            val_3 = 0;
            return (bool)val_3;
            label_2:
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            var val_2 = this.entries_ ^ 1;
            if(this._unknownFields == null)
            {
                    return (int)val_2;
            }
            
            val_2 = this._unknownFields ^ val_2;
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteTo(Google.Protobuf.CodedOutputStream output)
        {
            null = null;
            this.entries_.WriteTo(output:  output, codec:  ProtoData.LOGIN_REPEAT_DATA._repeated_entries_codec);
            if(this._unknownFields == null)
            {
                    return;
            }
            
            this._unknownFields.WriteTo(output:  output);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CalculateSize()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            val_4 = this.entries_.CalculateSize(codec:  ProtoData.LOGIN_REPEAT_DATA._repeated_entries_codec);
            if(this._unknownFields == null)
            {
                    return (int)val_4;
            }
            
            val_4 = this._unknownFields.CalculateSize() + val_4;
            return (int)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MergeFrom(ProtoData.LOGIN_REPEAT_DATA other)
        {
            Google.Protobuf.Collections.RepeatedField<ENTRY> val_2;
            if(other == null)
            {
                    return;
            }
            
            val_2 = this.entries_;
            val_2.Add(values:  other.entries_);
            this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MergeFrom(Google.Protobuf.CodedInputStream input)
        {
            Google.Protobuf.Collections.RepeatedField<ENTRY> val_3;
            var val_4;
            goto label_2;
            label_8:
            this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
            goto label_2;
            label_7:
            val_3 = this.entries_;
            val_4 = null;
            val_4 = null;
            val_3.AddEntriesFrom(input:  input, codec:  ProtoData.LOGIN_REPEAT_DATA._repeated_entries_codec);
            label_2:
            uint val_2 = input.ReadTag();
            if(val_2 == 10)
            {
                goto label_7;
            }
            
            if(val_2 != 0)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LOGIN_REPEAT_DATA()
        {
            null = null;
            ProtoData.LOGIN_REPEAT_DATA.EntriesFieldNumber = new Google.Protobuf.MessageParser<ProtoData.LOGIN_REPEAT_DATA>(factory:  new System.Func<ProtoData.LOGIN_REPEAT_DATA>(object:  LOGIN_REPEAT_DATA.<>c.<>9, method:  ProtoData.LOGIN_REPEAT_DATA LOGIN_REPEAT_DATA.<>c::<.cctor>b__26_0()));
            ProtoData.LOGIN_REPEAT_DATA._repeated_entries_codec = Google.Protobuf.FieldCodec.ForMessage<ENTRY>(tag:  10, parser:  LOGIN_REPEAT_DATA.Types.ENTRY.Parser);
        }
    
    }

}
