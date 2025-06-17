using UnityEngine;

namespace Mapbox.VectorTile
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PbfReader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Tag>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong <Value>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.Contants.WireTypes <WireType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] _buffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong _length;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong _pos;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Tag { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong Value { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.Contants.WireTypes WireType { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Tag()
        {
            return (int)this.<Tag>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Tag(int value)
        {
            this.<Tag>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong get_Value()
        {
            return (ulong)this.<Value>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Value(ulong value)
        {
            this.<Value>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.Contants.WireTypes get_WireType()
        {
            return (Mapbox.VectorTile.Contants.WireTypes)this.<WireType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_WireType(Mapbox.VectorTile.Contants.WireTypes value)
        {
            this.<WireType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PbfReader(byte[] tileBuffer)
        {
            this._buffer = tileBuffer;
            this.<WireType>k__BackingField = 99;
            this._length = tileBuffer.Length;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long Varint()
        {
            var val_4;
            var val_5;
            val_4 = 35907;
            var val_6 = 0;
            var val_7 = -7;
            label_5:
            if((this._pos & 9223372036854775808) != 0)
            {
                goto label_1;
            }
            
            byte val_5 = this._buffer[this._pos];
            byte val_3 = val_5 & 127;
            val_3 = val_3 << (val_7 + 7);
            val_6 = val_3 | val_6;
            this._pos = this._pos + 1;
            if((val_5 & 128) == 0)
            {
                    return (long)val_6;
            }
            
            val_7 = val_7 + 7;
            if(val_7 < 57)
            {
                goto label_5;
            }
            
            val_5 = 1152921519880227744;
            val_4 = new System.ArgumentException(message:  "Invalid varint");
            goto label_6;
            label_1:
            val_5 = 1152921519880227744;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] View()
        {
            var val_6;
            string val_8;
            var val_9;
            if((this.<Tag>k__BackingField) == 0)
            {
                goto label_1;
            }
            
            if((this.<WireType>k__BackingField) != 2)
            {
                goto label_2;
            }
            
            long val_1 = this.Varint();
            val_6 = this;
            this.SkipBytes(skip:  val_1);
            if((val_1 & 9223372036854775808) != 0)
            {
                goto label_3;
            }
            
            long val_2 = val_1 & 4294967295;
            byte[] val_3 = new byte[0];
            System.Array.Copy(sourceArray:  this._buffer, sourceIndex:  this._pos - val_1, destinationArray:  val_3, destinationIndex:  0, length:  val_1);
            return (System.Byte[])val_3;
            label_1:
            val_8 = "call next() before accessing field value";
            goto label_4;
            label_2:
            System.Exception val_5 = null;
            val_8 = "not of type string, bytes or message";
            label_4:
            val_5 = new System.Exception(message:  val_8);
            val_9 = 1152921519880435280;
            val_6 = val_5;
            goto label_5;
            label_3:
            val_9 = 1152921519880435280;
            label_5:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<uint> GetPackedUnit32()
        {
            System.Collections.Generic.List<System.UInt32> val_1 = new System.Collections.Generic.List<System.UInt32>(capacity:  200);
            ulong val_3 = this._pos + this.Varint();
            if(this._pos >= val_3)
            {
                    return val_1;
            }
            
            do
            {
                val_1.Add(item:  this.Varint());
            }
            while(this._pos < val_3);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> GetPackedSInt32()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>(capacity:  200);
            ulong val_3 = this._pos + this.Varint();
            if(this._pos >= val_3)
            {
                    return val_1;
            }
            
            do
            {
                long val_4 = this.Varint();
                val_1.Add(item:  (-(val_4 & 1)) ^ (val_4 >> 1));
            }
            while(this._pos < val_3);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<long> GetPackedSInt64()
        {
            System.Collections.Generic.List<System.Int64> val_1 = new System.Collections.Generic.List<System.Int64>(capacity:  200);
            ulong val_3 = this._pos + this.Varint();
            if(this._pos >= val_3)
            {
                    return val_1;
            }
            
            do
            {
                long val_4 = this.Varint();
                val_1.Add(item:  (-(val_4 & 1)) ^ (val_4 >> 1));
            }
            while(this._pos < val_3);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int decodeZigZag32(int value)
        {
            return (int)(-(value & 1)) ^ (value >> 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long decodeZigZag64(long value)
        {
            return (long)(-(value & 1)) ^ (value >> 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double GetDouble()
        {
            byte[] val_1 = new byte[8];
            System.Array.Copy(sourceArray:  this._buffer, sourceIndex:  this._pos, destinationArray:  val_1, destinationIndex:  0, length:  8);
            ulong val_2 = this._pos;
            val_2 = val_2 + 8;
            this._pos = val_2;
            return System.BitConverter.ToDouble(value:  val_1, startIndex:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetFloat()
        {
            byte[] val_1 = new byte[4];
            System.Array.Copy(sourceArray:  this._buffer, sourceIndex:  this._pos, destinationArray:  val_1, destinationIndex:  0, length:  4);
            ulong val_2 = this._pos;
            val_2 = val_2 + 4;
            this._pos = val_2;
            return System.BitConverter.ToSingle(value:  val_1, startIndex:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetString(ulong length)
        {
            var val_3;
            if((length & 9223372036854775808) != 0)
            {
                goto label_1;
            }
            
            length = length & 4294967295;
            byte[] val_1 = new byte[0];
            System.Array.Copy(sourceArray:  this._buffer, sourceIndex:  this._pos, destinationArray:  val_1, destinationIndex:  0, length:  length);
            ulong val_3 = this._pos;
            val_3 = val_3 + length;
            this._pos = val_3;
            val_3 = System.Text.Encoding.UTF8;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            label_5:
            val_3 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
            label_2:
            if(val_3 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool NextByte()
        {
            var val_5;
            if(this._pos >= this._length)
            {
                goto label_1;
            }
            
            long val_1 = this.Varint();
            long val_2 = val_1 >> 3;
            this.<Value>k__BackingField = val_1;
            this.<Tag>k__BackingField = val_2;
            if((val_2 == 0) || (val_2 >= 19000))
            {
                goto label_3;
            }
            
            val_5 = 1;
            this.<WireType>k__BackingField = val_1 & 7;
            return (bool)val_5;
            label_1:
            val_5 = 0;
            return (bool)val_5;
            label_3:
            System.Exception val_4 = new System.Exception(message:  "tag out of range");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SkipVarint()
        {
            long val_1 = this.Varint();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SkipBytes(ulong skip)
        {
            static_value_04280E76 = true;
            ulong val_4 = this._pos;
            val_4 = val_4 + skip;
            if(val_4 <= this._length)
            {
                    this._pos = val_4;
                return;
            }
            
            System.Exception val_3 = new System.Exception(message:  System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "[SkipBytes()] skip:{0} pos:{1} len:{2}", arg0:  skip, arg1:  this._pos, arg2:  this._length));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong Skip()
        {
            string val_6;
            if((this.<Tag>k__BackingField) == 0)
            {
                goto label_1;
            }
            
            if((this.<WireType>k__BackingField) > 5)
            {
                goto label_2;
            }
            
            var val_4 = 52948560 + (this.<WireType>k__BackingField) << 2;
            val_4 = val_4 + 52948560;
            goto (52948560 + (this.<WireType>k__BackingField) << 2 + 52948560);
            label_1:
            val_6 = "call next() before calling skip()";
            goto label_8;
            label_2:
            if((this.<WireType>k__BackingField) == 99)
            {
                    val_6 = "undefined wire type";
            }
            else
            {
                    val_6 = "unknown wire type";
            }
            
            label_8:
            null = new System.Exception(message:  val_6);
        }
    
    }

}
