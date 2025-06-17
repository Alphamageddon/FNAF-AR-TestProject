using UnityEngine;

namespace Ionic.Crc
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CrcCalculatorStream : Stream, IDisposable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly long UnsetLengthLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal System.IO.Stream _innerStream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Crc.CRC32 _Crc32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _lengthLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _leaveOpen;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long TotalBytesSlurped { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Crc { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LeaveOpen { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanSeek { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanWrite { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Length { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Position { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrcCalculatorStream(System.IO.Stream stream)
        {
            null = null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrcCalculatorStream(System.IO.Stream stream, bool leaveOpen)
        {
            null = null;
            bool val_1 = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrcCalculatorStream(System.IO.Stream stream, long length)
        {
            if((length & 9223372036854775808) == 0)
            {
                    return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "length");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrcCalculatorStream(System.IO.Stream stream, long length, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
            if((length & 9223372036854775808) == 0)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "length");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CrcCalculatorStream(System.IO.Stream stream, long length, bool leaveOpen, Ionic.Crc.CRC32 crc32)
        {
            bool val_1 = leaveOpen;
            if((length & 9223372036854775808) == 0)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "length");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CrcCalculatorStream(bool leaveOpen, long length, System.IO.Stream stream, Ionic.Crc.CRC32 crc32)
        {
            Ionic.Crc.CRC32 val_4 = crc32;
            this._lengthLimit = 98;
            val_1 = new System.IO.Stream();
            this._innerStream = val_1;
            if(val_4 == null)
            {
                    Ionic.Crc.CRC32 val_2 = null;
                val_4 = val_2;
                ._register = 0;
                val_2 = new Ionic.Crc.CRC32();
                .reverseBits = false;
                .dwPolynomial = -306674912;
                val_2.GenerateLookupTable();
            }
            
            this._Crc32 = val_4;
            this._lengthLimit = length;
            this._leaveOpen = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_TotalBytesSlurped()
        {
            if(this._Crc32 != null)
            {
                    return (long)this._Crc32._TotalBytesRead;
            }
            
            return (long)this._Crc32._TotalBytesRead;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Crc()
        {
            if(this._Crc32 != null)
            {
                    return (int)~this._Crc32._register;
            }
            
            return (int)~this._Crc32._register;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_LeaveOpen()
        {
            return (bool)this._leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_LeaveOpen(bool value)
        {
            this._leaveOpen = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int Read(byte[] buffer, int offset, int count)
        {
            var val_2;
            Ionic.Crc.CRC32 val_3;
            var val_4;
            long val_5;
            int val_6;
            val_2 = count;
            val_3 = this;
            val_4 = null;
            val_4 = null;
            if(this._lengthLimit == Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit)
            {
                goto label_3;
            }
            
            val_5 = this._lengthLimit;
            if(this._Crc32._TotalBytesRead >= val_5)
            {
                goto label_5;
            }
            
            long val_2 = this._Crc32._TotalBytesRead;
            val_2 = val_5 - val_2;
            var val_1 = (val_2 < (val_2 << )) ? (val_2) : (val_2);
            label_3:
            val_5 = this._innerStream;
            val_6 = val_5;
            if(val_6 < 1)
            {
                    return (int)val_6;
            }
            
            val_3 = this._Crc32;
            val_3.SlurpBlock(block:  buffer, offset:  offset, count:  val_6);
            return (int)val_6;
            label_5:
            val_6 = 0;
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(count >= 1)
            {
                    this._Crc32.SlurpBlock(block:  buffer, offset:  offset, count:  count);
            }
            
            if(this._innerStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanRead()
        {
            if(this._innerStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanSeek()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanWrite()
        {
            if(this._innerStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Flush()
        {
            if(this._innerStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Length()
        {
            var val_6;
            var val_7;
            val_6 = this;
            val_7 = null;
            val_7 = null;
            if(this._lengthLimit != Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit)
            {
                    return (long)val_6 + 56;
            }
            
            val_6 = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_1D8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Position()
        {
            if(this._Crc32 != null)
            {
                    return (long)this._Crc32._TotalBytesRead;
            }
            
            return (long)this._Crc32._TotalBytesRead;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void System.IDisposable.Dispose()
        {
            goto typeof(Ionic.Crc.CrcCalculatorStream).__il2cppRuntimeField_258;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Close()
        {
            this.Close();
            if(this._leaveOpen != false)
            {
                    return;
            }
            
            if(this._innerStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CrcCalculatorStream()
        {
            Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit = 98;
        }
    
    }

}
