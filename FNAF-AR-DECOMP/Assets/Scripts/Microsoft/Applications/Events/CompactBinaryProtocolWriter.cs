using UnityEngine;

namespace Microsoft.Applications.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class CompactBinaryProtocolWriter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<byte> _output;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<byte> Data { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<byte> get_Data()
        {
            return (System.Collections.Generic.List<System.Byte>)this._output;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CompactBinaryProtocolWriter()
        {
            this._output = new System.Collections.Generic.List<System.Byte>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CompactBinaryProtocolWriter(System.Collections.Generic.List<byte> output)
        {
            this._output = output;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteStructBegin(object nullptr, bool isBase)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(ushort value)
        {
            ushort val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            val_2 = val_2 & 65535;
            if(val_2 > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  val_2 & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(short value)
        {
            short val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            if(((int)val_2 & 65535) > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  ((int)val_2 & 65535) & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(int value)
        {
            int val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            if(val_2 > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  val_2 & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(uint value)
        {
            uint val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            if(val_2 > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  val_2 & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(long value)
        {
            long val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            if(val_2 > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  val_2 & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void writeVarint(ulong value)
        {
            ulong val_2 = value;
            goto label_1;
            label_3:
            value = val_2 | 128;
            Add(item:  value);
            val_2 = val_2 >> 7;
            label_1:
            if(val_2 > 127)
            {
                goto label_3;
            }
            
            this._output.Add(item:  val_2 & 127);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteBlob(System.Collections.Generic.List<byte> data, int size)
        {
            this._output.AddRange(collection:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteBlob(byte[] data, int size)
        {
            this._output.AddRange(collection:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteBool(bool value)
        {
            this._output.Add(item:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteUInt8(byte value)
        {
            this._output.Add(item:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteUInt16(ushort value)
        {
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteUInt32(uint value)
        {
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteUInt64(ulong value)
        {
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteInt8(sbyte value)
        {
            this.WriteUInt8(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteInt16(short value)
        {
            value = W9 ^ (((int)value & 65535) >> 15);
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteInt32(int value)
        {
            value = (value << 1) ^ (value >> 31);
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteInt64(long value)
        {
            value = (value << 1) ^ (value >> 63);
            this.writeVarint(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteDouble(double value)
        {
            this.WriteBlob(data:  System.BitConverter.GetBytes(value:  value), size:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteString(string value)
        {
            if((System.String.IsNullOrEmpty(value:  value)) != false)
            {
                    this.writeVarint(value:  0);
                return;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if(val_2 != null)
            {
                    this.writeVarint(value:  val_2.dataItem);
            }
            else
            {
                    this.writeVarint(value:  15026800);
            }
            
            this.WriteBlob(data:  val_2, size:  typeof(System.Text.Encoding).__il2cppRuntimeField_250>>0&0xFFFFFFFF);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteWString(string value)
        {
            if((System.String.IsNullOrEmpty(value:  value)) != false)
            {
                    this.writeVarint(value:  0);
                return;
            }
            
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            if(val_2 != null)
            {
                    this.writeVarint(value:  val_2.dataItem);
            }
            else
            {
                    this.writeVarint(value:  15026800);
            }
            
            this.WriteBlob(data:  val_2, size:  typeof(System.Text.Encoding).__il2cppRuntimeField_250>>0&0xFFFFFFFF);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteContainerBegin(ushort size, byte elementType)
        {
            this.WriteUInt8(value:  elementType);
            this.writeVarint(value:  size & 65535);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteMapContainerBegin(ushort size, byte keyType, byte valueType)
        {
            this.WriteUInt8(value:  keyType);
            this.WriteUInt8(value:  valueType);
            this.writeVarint(value:  size & 65535);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteContainerEnd()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteFieldBegin(byte type, ushort id)
        {
            System.Collections.Generic.List<System.Byte> val_4;
            System.Collections.Generic.List<System.Byte> val_5;
            var val_6;
            byte val_7;
            val_4 = type;
            if((id & 65535) > 5)
            {
                goto label_1;
            }
            
            val_5 = this._output;
            val_6 = public System.Void System.Collections.Generic.List<System.Byte>::Add(System.Byte item);
            val_7 = W9 | (val_4 & 255);
            goto label_3;
            label_1:
            if((id & 65535) > 255)
            {
                goto label_5;
            }
            
            type = val_4 | 4294967232;
            this._output.Add(item:  type);
            val_6 = public System.Void System.Collections.Generic.List<System.Byte>::Add(System.Byte item);
            val_7 = id;
            goto label_7;
            label_5:
            type = val_4 | 4294967264;
            this._output.Add(item:  type);
            val_4 = this._output;
            val_4.Add(item:  id);
            val_5 = this._output;
            val_6 = public System.Void System.Collections.Generic.List<System.Byte>::Add(System.Byte item);
            val_7 = (uint)(id >> 8) & 255;
            label_3:
            label_7:
            val_5.Add(item:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteFieldEnd()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WriteStructEnd(bool isBase)
        {
            this.WriteUInt8(value:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void WriteFieldOmitted(byte bT_STRING, int v)
        {
        
        }
    
    }

}
