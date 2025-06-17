using UnityEngine;

namespace ProtoData
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ANIMATRONIC_DATA : IMessage<ProtoData.ANIMATRONIC_DATA>, IMessage, IEquatable<ProtoData.ANIMATRONIC_DATA>, IDeepCloneable<ProtoData.ANIMATRONIC_DATA>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA> _parser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.UnknownFieldSet _unknownFields;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int EntriesFieldNumber = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Google.Protobuf.FieldCodec<ProtoData.ANIMATRONIC_DATA.Types.ENTRY> _repeated_entries_codec;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Google.Protobuf.Collections.RepeatedField<ProtoData.ANIMATRONIC_DATA.Types.ENTRY> entries_;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA> Parser { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Google.Protobuf.Collections.RepeatedField<ProtoData.ANIMATRONIC_DATA.Types.ENTRY> Entries { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA> get_Parser()
        {
            null = null;
            return (Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA>)ProtoData.ANIMATRONIC_DATA.EntriesFieldNumber;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return ProtoData.ANIMATRONICDATAReflection.Descriptor.MessageTypes.Item[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
        {
            return ProtoData.ANIMATRONIC_DATA.Descriptor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ANIMATRONIC_DATA()
        {
            this.entries_ = new Google.Protobuf.Collections.RepeatedField<ENTRY>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ANIMATRONIC_DATA(ProtoData.ANIMATRONIC_DATA other)
        {
            this.entries_ = other.entries_.Clone();
            this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ANIMATRONIC_DATA Clone()
        {
            return (ProtoData.ANIMATRONIC_DATA)new ProtoData.ANIMATRONIC_DATA(other:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Google.Protobuf.Collections.RepeatedField<ProtoData.ANIMATRONIC_DATA.Types.ENTRY> get_Entries()
        {
            return (Google.Protobuf.Collections.RepeatedField<ENTRY>)this.entries_;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object other)
        {
            ProtoData.ANIMATRONIC_DATA val_1;
            if(other != null)
            {
                    other = (null == null) ? other : 0;
                return this.Equals(other:  val_1 = 0);
            }
            
            return this.Equals(other:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(ProtoData.ANIMATRONIC_DATA other)
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
            this.entries_.WriteTo(output:  output, codec:  ProtoData.ANIMATRONIC_DATA._repeated_entries_codec);
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
            val_4 = this.entries_.CalculateSize(codec:  ProtoData.ANIMATRONIC_DATA._repeated_entries_codec);
            if(this._unknownFields == null)
            {
                    return (int)val_4;
            }
            
            val_4 = this._unknownFields.CalculateSize() + val_4;
            return (int)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MergeFrom(ProtoData.ANIMATRONIC_DATA other)
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
            val_3.AddEntriesFrom(input:  input, codec:  ProtoData.ANIMATRONIC_DATA._repeated_entries_codec);
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
        private static ANIMATRONIC_DATA()
        {
            null = null;
            ProtoData.ANIMATRONIC_DATA.EntriesFieldNumber = new Google.Protobuf.MessageParser<ProtoData.ANIMATRONIC_DATA>(factory:  new System.Func<ProtoData.ANIMATRONIC_DATA>(object:  ANIMATRONIC_DATA.<>c.<>9, method:  ProtoData.ANIMATRONIC_DATA ANIMATRONIC_DATA.<>c::<.cctor>b__26_0()));
            ProtoData.ANIMATRONIC_DATA._repeated_entries_codec = Google.Protobuf.FieldCodec.ForMessage<ENTRY>(tag:  10, parser:  ANIMATRONIC_DATA.Types.ENTRY.Parser);
        }
    
    }

}
