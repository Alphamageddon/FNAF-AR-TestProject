using UnityEngine;

namespace Ionic.Crc
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CRC32
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint dwPolynomial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _TotalBytesRead;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool reverseBits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint[] crc32Table;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int BUFFER_SIZE = 8192;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint _register;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TotalBytesRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Crc32Result { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_TotalBytesRead()
        {
            return (long)this._TotalBytesRead;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Crc32Result()
        {
            return (int)~this._register;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetCrc32(System.IO.Stream input)
        {
            return this.GetCrc32AndCopy(input:  input, output:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetCrc32AndCopy(System.IO.Stream input, System.IO.Stream output)
        {
            if(input == null)
            {
                goto label_1;
            }
            
            this._TotalBytesRead = 0;
            goto label_2;
            label_4:
            this.SlurpBlock(block:  new byte[8192], offset:  0, count:  W23);
            label_2:
            long val_3 = this._TotalBytesRead;
            val_3 = val_3 + (input << );
            this._TotalBytesRead = val_3;
            if(input >= 1)
            {
                goto label_4;
            }
            
            return (int)~this._register;
            label_1:
            System.Exception val_2 = new System.Exception(message:  "The input stream must not be null.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ComputeCrc32(int W, byte B)
        {
            return this._InternalComputeCrc32(W:  W, B:  B);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal int _InternalComputeCrc32(uint W, byte B)
        {
            byte val_3 = B;
            val_3 = W ^ val_3 & 255;
            return (int)(this.crc32Table[(((W ^ B) & 255)) << 2]) ^ (W >> 8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SlurpBlock(byte[] block, int offset, int count)
        {
            var val_5;
            System.UInt32[] val_6;
            uint val_7;
            if(block != null)
            {
                    if(count >= 1)
            {
                    do
            {
                var val_8 = (long)offset;
                byte val_5 = block[val_8];
                if(this.reverseBits != false)
            {
                    val_6 = this.crc32Table;
                byte val_1 = val_5 ^ (this._register >> 24);
                val_7 = (val_6[((block[(long)(int)(offset)][0] ^ (this._register) >> 24)) << 2]) ^ (this._register << 8);
            }
            else
            {
                    val_6 = this.crc32Table;
                uint val_3 = (this._register & 255) ^ val_5;
                val_7 = (val_6[(((this._register & 255) ^ block[(long)(int)(offset)][0])) << 2]) ^ (this._register >> 8);
            }
            
                val_5 = count - 1;
                val_8 = val_8 + 1;
                this._register = val_7;
            }
            while(val_5 != 0);
            
            }
            
                long val_9 = this._TotalBytesRead;
                val_9 = val_9 + (count << );
                this._TotalBytesRead = val_9;
                return;
            }
            
            System.Exception val_4 = new System.Exception(message:  "The data buffer must not be null.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateCRC(byte b)
        {
            System.UInt32[] val_5;
            uint val_6;
            if(this.reverseBits != false)
            {
                    val_5 = this.crc32Table;
                byte val_2 = (b & 255) ^ (this._register >> 24);
                val_6 = (val_5[(((b & 255) ^ (this._register) >> 24)) << 2]) ^ (this._register << 8);
            }
            else
            {
                    val_5 = this.crc32Table;
                uint val_4 = this._register ^ b & 255;
                val_6 = (val_5[(((this._register ^ b) & 255)) << 2]) ^ (this._register >> 8);
            }
            
            this._register = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateCRC(byte b, int n)
        {
            System.UInt32[] val_6;
            uint val_7;
            if(n < 1)
            {
                    return;
            }
            
            uint val_6 = this._register;
            byte val_1 = b & 255;
            int val_2 = n + 1;
            do
            {
                val_6 = this.crc32Table;
                if(this.reverseBits != false)
            {
                    byte val_3 = val_1 ^ (val_6 >> 24);
                val_6 = val_6 << 8;
                val_7 = (val_6[(((b & 255) ^ (this._register) >> 24)) << 2]) ^ val_6;
            }
            else
            {
                    uint val_5 = (val_6 & 255) ^ val_1;
                val_6 = val_6[(((this._register & 255) ^ (b & 255))) << 2];
                val_6 = val_6 >> 8;
                val_7 = val_6 ^ val_6;
            }
            
                val_2 = val_2 - 1;
                this._register = val_7;
            }
            while(val_2 > 1);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static uint ReverseBits(uint data)
        {
            return (uint)data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static byte ReverseBits(byte data)
        {
            byte val_1 = data & 255;
            byte val_2 = val_1 * 131586;
            val_1 = val_1 * 526344;
            val_2 = val_2 & 17055760;
            val_1 = val_1 & 34111520;
            val_1 = val_1 | val_2;
            val_1 = val_1 * 16781313;
            data = val_1 >> 24;
            return (byte)data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateLookupTable()
        {
            uint val_4;
            var val_5;
            var val_6 = 0;
            this.crc32Table = new uint[256];
            label_10:
            var val_5 = 8;
            do
            {
                if((val_6 & 1) == 0)
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = this.dwPolynomial ^ 0;
            }
            
                val_5 = val_5 + 255;
                val_5 = val_5 & 255;
            }
            while(val_5 != 0);
            
            if(this.reverseBits == false)
            {
                goto label_4;
            }
            
            var val_2 = val_6 * 131586;
            var val_3 = val_6 * 526344;
            val_2 = val_2 & 17055760;
            val_3 = val_3 & 34111520;
            val_2 = val_3 | val_2;
            val_2 = val_2 * 16781313;
            val_5 = val_2 >> 24;
            val_4 = Ionic.Crc.CRC32.ReverseBits(data:  val_4);
            if(val_5 < this.crc32Table.Length)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            val_5 = val_6;
            label_7:
            val_6 = val_6 + 1;
            this.crc32Table[0] = val_4;
            if(val_6 != 256)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint gf2_matrix_times(uint[] matrix, uint vec)
        {
            var val_1;
            uint val_1 = vec;
            if(val_1 != 0)
            {
                    var val_2 = 0;
                val_1 = 0;
                do
            {
                if((val_1 & 1) != 0)
            {
                    val_1 = 1152921505374836288 ^ val_1;
            }
            
                val_1 = val_1 >> 1;
                val_2 = val_2 + 1;
            }
            while(val_1 != 0);
            
                return (uint)val_1;
            }
            
            val_1 = 0;
            return (uint)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void gf2_matrix_square(uint[] square, uint[] mat)
        {
            var val_3 = 0;
            do
            {
                mem2[0] = this.gf2_matrix_times(matrix:  mat, vec:  mat[0]);
                val_3 = val_3 + 1;
            }
            while(val_3 != 32);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Combine(int crc, int length)
        {
            var val_6;
            var val_7;
            uint val_8;
            val_6 = length;
            uint[] val_1 = new uint[32];
            uint[] val_2 = new uint[32];
            if(val_6 == 0)
            {
                    return;
            }
            
            if(val_2 == null)
            {
                    val_7 = 0;
            }
            
            val_8 = this._register;
            val_8 = ~this._register;
            val_2[0] = this.dwPolynomial;
            do
            {
                mem2[0] = 1;
            }
            while((0 + 1) != 31);
            
            this.gf2_matrix_square(square:  val_1, mat:  val_2);
            this.gf2_matrix_square(square:  val_2, mat:  val_1);
            label_9:
            this.gf2_matrix_square(square:  val_1, mat:  val_2);
            if((val_6 & 1) != 0)
            {
                    uint val_4 = this.gf2_matrix_times(matrix:  val_1, vec:  val_8);
                val_8 = val_4;
            }
            
            int val_5 = val_6 >> 1;
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            val_4.gf2_matrix_square(square:  val_2, mat:  val_1);
            if((val_6 & 2) != 0)
            {
                    val_8 = val_4.gf2_matrix_times(matrix:  val_2, vec:  val_8);
            }
            
            val_6 = val_6 >> 2;
            if(val_6 != 0)
            {
                goto label_9;
            }
            
            label_7:
            this._register = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CRC32()
        {
            this._register = 0;
            this.reverseBits = false;
            this.dwPolynomial = -306674912;
            this.GenerateLookupTable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CRC32(bool reverseBits)
        {
            this._register = 0;
            this.reverseBits = reverseBits;
            this.dwPolynomial = -306674912;
            this.GenerateLookupTable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CRC32(int polynomial, bool reverseBits)
        {
            this._register = 0;
            this.reverseBits = reverseBits;
            this.dwPolynomial = polynomial;
            this.GenerateLookupTable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this._register = 0;
        }
    
    }

}
