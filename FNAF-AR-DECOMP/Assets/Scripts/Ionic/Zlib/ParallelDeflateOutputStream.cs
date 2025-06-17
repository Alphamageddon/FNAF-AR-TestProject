using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ParallelDeflateOutputStream : Stream
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int IO_BUFFER_SIZE_DEFAULT;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int BufferPairsPerCore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Ionic.Zlib.WorkItem> _pool;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _leaveOpen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool emitting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.IO.Stream _outStream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxBufferPairs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _bufferSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Threading.AutoResetEvent _newlyCompressedBlob;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _outputLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isClosed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _firstWriteDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currentlyFilling;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _lastFilled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _lastWritten;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _latestCompressed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _Crc32;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Crc.CRC32 _runningCrc;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _latestLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<int> _toWrite;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<int> _toFill;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _totalBytesProcessed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.CompressionLevel _compressLevel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Exception _pendingException;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _handlingException;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _eLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.ParallelDeflateOutputStream.TraceBits _DesiredTrace;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ionic.Zlib.CompressionStrategy <Strategy>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ionic.Zlib.CompressionStrategy Strategy { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxBufferPairs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BufferSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Crc32 { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long BytesProcessed { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanSeek { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanWrite { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Length { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long Position { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParallelDeflateOutputStream(System.IO.Stream stream)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParallelDeflateOutputStream(System.IO.Stream stream, Ionic.Zlib.CompressionLevel level)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParallelDeflateOutputStream(System.IO.Stream stream, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParallelDeflateOutputStream(System.IO.Stream stream, Ionic.Zlib.CompressionLevel level, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParallelDeflateOutputStream(System.IO.Stream stream, Ionic.Zlib.CompressionLevel level, Ionic.Zlib.CompressionStrategy strategy, bool leaveOpen)
        {
            null = null;
            this._bufferSize = Ionic.Zlib.ParallelDeflateOutputStream.IO_BUFFER_SIZE_DEFAULT;
            this._outputLock = new System.Object();
            this._latestLock = new System.Object();
            this._eLock = new System.Object();
            this._DesiredTrace = 26942;
            this._outStream = stream;
            this._compressLevel = level;
            this.<Strategy>k__BackingField = strategy;
            this._leaveOpen = leaveOpen;
            this._maxBufferPairs = 16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ionic.Zlib.CompressionStrategy get_Strategy()
        {
            return (Ionic.Zlib.CompressionStrategy)this.<Strategy>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Strategy(Ionic.Zlib.CompressionStrategy value)
        {
            this.<Strategy>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaxBufferPairs()
        {
            return (int)this._maxBufferPairs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxBufferPairs(int value)
        {
            if(value > 3)
            {
                    this._maxBufferPairs = value;
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "MaxBufferPairs", paramName:  "Value must be 4 or greater.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_BufferSize()
        {
            return (int)this._bufferSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_BufferSize(int value)
        {
            if(value > 1023)
            {
                    this._bufferSize = value;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  "BufferSize", message:  "BufferSize must be greater than 1024 bytes");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Crc32()
        {
            return (int)this._Crc32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_BytesProcessed()
        {
            return (long)this._totalBytesProcessed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _InitializePoolOfWorkItems()
        {
            var val_9;
            int val_10;
            this._toWrite = new System.Collections.Generic.Queue<System.Int32>();
            this._toFill = new System.Collections.Generic.Queue<System.Int32>();
            this._pool = new System.Collections.Generic.List<Ionic.Zlib.WorkItem>();
            val_9 = null;
            val_9 = null;
            val_10 = System.Environment.ProcessorCount * Ionic.Zlib.ParallelDeflateOutputStream.BufferPairsPerCore;
            int val_5 = System.Math.Min(val1:  val_10, val2:  this._maxBufferPairs);
            if(val_5 >= 1)
            {
                    do
            {
                this._pool.Add(item:  new Ionic.Zlib.WorkItem(size:  this._bufferSize, compressLevel:  this._compressLevel, strategy:  null, ix:  0));
                this._toFill.Enqueue(item:  0);
                val_10 = 0 + 1;
            }
            while(val_5 != val_10);
            
            }
            
            this._newlyCompressedBlob = new System.Threading.AutoResetEvent(initialState:  false);
            this._runningCrc = new Ionic.Crc.CRC32();
            this._lastWritten = 0;
            this._latestCompressed = 0;
            this._currentlyFilling = 0;
            this._lastFilled = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Write(byte[] buffer, int offset, int count)
        {
            int val_10;
            System.Exception val_11;
            int val_12;
            int val_13;
            int val_11 = count;
            val_10 = offset;
            if(this._isClosed == true)
            {
                goto label_1;
            }
            
            val_11 = this._pendingException;
            if(val_11 != null)
            {
                goto label_2;
            }
            
            if(val_11 == 0)
            {
                    return;
            }
            
            if(this._firstWriteDone != true)
            {
                    this._InitializePoolOfWorkItems();
                this._firstWriteDone = true;
            }
            
            label_20:
            this.EmitPendingBuffers(doAll:  false, mustWait:  false);
            val_11 = this._currentlyFilling;
            if((val_11 & 2147483648) != 0)
            {
                    if(this._toFill.Count == 0)
            {
                goto label_6;
            }
            
                int val_9 = this._lastFilled;
                val_11 = this._toFill.Dequeue();
                val_9 = val_9 + 1;
                this._lastFilled = val_9;
            }
            
            val_12 = val_3.inputBytesAvailable;
            int val_10 = val_3.buffer.Length;
            val_10 = val_10 - val_12;
            if(val_10 > val_11)
            {
                    val_13 = val_11;
            }
            else
            {
                    if(val_3.buffer == null)
            {
                    val_12 = val_3.inputBytesAvailable;
            }
            
                val_13 = val_3.buffer.Length - val_12;
            }
            
            val_3.ordinal = this._lastFilled;
            System.Buffer.BlockCopy(src:  buffer, srcOffset:  val_10, dst:  val_3.buffer, dstOffset:  val_12, count:  val_13);
            int val_4 = val_3.inputBytesAvailable + val_13;
            val_3.inputBytesAvailable = val_4;
            if(val_4 != val_3.buffer.Length)
            {
                goto label_18;
            }
            
            if((System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  System.Void Ionic.Zlib.ParallelDeflateOutputStream::_DeflateOne(object wi)), state:  this._pool.Item[val_11])) == false)
            {
                goto label_19;
            }
            
            val_11 = 0;
            label_18:
            val_11 = val_11 - val_13;
            val_10 = val_13 + val_10;
            this._currentlyFilling = val_11;
            label_6:
            if(val_11 > 0)
            {
                goto label_20;
            }
            
            return;
            label_19:
            System.Exception val_7 = new System.Exception(message:  "Cannot enqueue workitem");
            label_21:
            label_22:
            label_1:
            System.InvalidOperationException val_8 = new System.InvalidOperationException();
            goto label_21;
            label_2:
            this._handlingException = true;
            this._pendingException = 0;
            goto label_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _FlushFinish()
        {
            int val_12;
            byte[] val_1 = new byte[128];
            Ionic.Zlib.ZlibCodec val_2 = null;
            .CompressLevel = 15;
            val_2 = new Ionic.Zlib.ZlibCodec();
            if(val_2 != null)
            {
                    .CompressLevel = this._compressLevel;
                int val_3 = val_2._InternalInitializeDeflate(wantRfc1950Header:  false);
                .InputBuffer = 0;
                .NextIn = 0;
                .AvailableBytesIn = 0;
                .OutputBuffer = val_1;
            }
            else
            {
                    .CompressLevel = this._compressLevel;
                int val_4 = val_2._InternalInitializeDeflate(wantRfc1950Header:  false);
                mem[16] = 0;
                mem[24] = 0;
                .AvailableBytesIn = 0;
                mem[40] = val_1;
            }
            
            .NextOut = 0;
            .AvailableBytesOut = val_1.Length;
            if((val_2.Deflate(flush:  4)) < 2)
            {
                    val_12 = val_1.Length;
                if((val_12 - (Ionic.Zlib.ZlibCodec)[1152921525572512912].AvailableBytesOut) >= 1)
            {
                    if(this._outStream == null)
            {
                    val_12 = val_1.Length;
            }
            
                int val_7 = val_12 - (Ionic.Zlib.ZlibCodec)[1152921525572512912].AvailableBytesOut;
            }
            
                int val_8 = val_2.EndDeflate();
                this._Crc32 = this._runningCrc.Crc32Result;
                return;
            }
            
            System.Exception val_11 = new System.Exception(message:  "deflating: "("deflating: ") + (Ionic.Zlib.ZlibCodec)[1152921525572512912].Message);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _Flush(bool lastInput)
        {
            if(this._isClosed != true)
            {
                    if(this.emitting != false)
            {
                    return;
            }
            
                if((this._currentlyFilling & 2147483648) == 0)
            {
                    this._DeflateOne(wi:  this._pool.Item[this._currentlyFilling]);
                this._currentlyFilling = 0;
            }
            
                if(lastInput != false)
            {
                    this.EmitPendingBuffers(doAll:  true, mustWait:  false);
                this._FlushFinish();
                return;
            }
            
                this.EmitPendingBuffers(doAll:  false, mustWait:  false);
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Flush()
        {
            if(this._pendingException == null)
            {
                    if(this._handlingException != false)
            {
                    return;
            }
            
                this._Flush(lastInput:  false);
                return;
            }
            
            this._handlingException = true;
            this._pendingException = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Close()
        {
            if(this._pendingException == null)
            {
                    if(this._handlingException == true)
            {
                    return;
            }
            
                if(this._isClosed == true)
            {
                    return;
            }
            
                this._Flush(lastInput:  true);
                this._isClosed = true;
                return;
            }
            
            this._handlingException = true;
            this._pendingException = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dispose()
        {
            this._pool = 0;
            goto typeof(Ionic.Zlib.ParallelDeflateOutputStream).__il2cppRuntimeField_268;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Dispose(bool disposing)
        {
            this.Dispose(disposing:  disposing);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset(System.IO.Stream stream)
        {
            Ionic.Crc.CRC32 val_6;
            if(this._firstWriteDone == false)
            {
                    return;
            }
            
            this._toWrite.Clear();
            this._toFill.Clear();
            List.Enumerator<T> val_1 = this._pool.GetEnumerator();
            goto label_5;
            label_8:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            this._toFill.Enqueue(item:  W23);
            val_2._emailIdsToBeDeletedOnServer = 0;
            label_5:
            if(((-508407496) & 1) != 0)
            {
                goto label_8;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525573275960});
            this._firstWriteDone = false;
            this._totalBytesProcessed = 0;
            Ionic.Crc.CRC32 val_5 = null;
            val_6 = val_5;
            val_5 = new Ionic.Crc.CRC32();
            this._runningCrc = val_6;
            this._isClosed = false;
            this._lastWritten = 0;
            this._latestCompressed = 0;
            this._currentlyFilling = 0;
            this._lastFilled = 0;
            this._outStream = stream;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EmitPendingBuffers(bool doAll, bool mustWait)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            int val_16;
            System.Collections.Generic.Queue<System.Int32> val_18;
            var val_19;
            System.Threading.AutoResetEvent val_20;
            System.Collections.Generic.Queue<System.Int32> val_21;
            var val_22;
            val_13 = mustWait;
            if(this.emitting == true)
            {
                    return;
            }
            
            this.emitting = true;
            if(doAll != true)
            {
                    if(val_13 == false)
            {
                goto label_3;
            }
            
            }
            
            label_3:
            val_14 = (int)(val_13 >> 0) & 1;
            val_15 = 0;
            val_16 = 200;
            val_12 = 0;
            val_13 = 114;
            int val_1 = (doAll != true) ? 200 : (val_14);
            label_43:
            val_18 = this._toWrite;
            goto label_5;
            label_36:
            val_14 = 1152921525571903344;
            if(this._toWrite.Count >= 1)
            {
                    val_14 = 1152921525571908464;
                val_20 = this._toWrite.Dequeue();
            }
            else
            {
                    val_20 = 0;
            }
            
            System.Threading.Monitor.Exit(obj:  this._toWrite);
            if(((114 == 0) ? 114 : 114) != 114)
            {
                goto label_17;
            }
            
            val_12 = 0;
            if((val_20 & 2147483648) == 0)
            {
                goto label_21;
            }
            
            goto label_37;
            label_17:
            if(0 == 0)
            {
                goto label_20;
            }
            
            val_15 = 0;
            val_19 = 0;
            if((val_20 & 2147483648) == 0)
            {
                goto label_21;
            }
            
            goto label_37;
            label_20:
            val_15 = 0;
            if((val_20 & 2147483648) != 0)
            {
                goto label_37;
            }
            
            label_21:
            Ionic.Zlib.WorkItem val_5 = this._pool.Item[0];
            int val_12 = this._lastWritten;
            val_16 = val_5.ordinal;
            val_12 = val_12 + 1;
            if(val_16 == val_12)
            {
                goto label_26;
            }
            
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  this._toWrite, lockTaken: ref  val_6);
            val_21 = this._toWrite;
            val_22 = val_20;
            val_21.Enqueue(item:  0);
            if(val_6 != 0)
            {
                    val_22 = 0;
                System.Threading.Monitor.Exit(obj:  this._toWrite);
            }
            
            val_14 = 196;
            if(((196 == 0) ? 196 : 196) == 196)
            {
                    val_12 = 0;
            }
            else
            {
                    if(0 != 0)
            {
                    val_22 = 0;
                val_15 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            }
            
            if(0 == val_20)
            {
                    val_20 = this._newlyCompressedBlob;
                if(val_20 != null)
            {
                goto label_35;
            }
            
            }
            else
            {
                    var val_8 = (0 == 1) ? (val_20) : 0;
            }
            
            label_35:
            if((System.Threading.Monitor.TryEnter(obj:  this._toWrite, millisecondsTimeout:  val_1)) == true)
            {
                goto label_36;
            }
            
            goto label_37;
            label_26:
            val_21 = val_5.crc;
            this._runningCrc.Combine(crc:  val_21, length:  val_5.inputBytesAvailable);
            long val_13 = this._totalBytesProcessed;
            val_16 = val_5.inputBytesAvailable;
            val_13 = val_13 + val_16;
            this._totalBytesProcessed = val_13;
            val_5.inputBytesAvailable = 0;
            val_20 = this._toFill;
            this._lastWritten = val_5.ordinal;
            val_14 = 1152921525571682800;
            val_20.Enqueue(item:  val_5.index);
            val_18 = this._toWrite;
            label_5:
            if((System.Threading.Monitor.TryEnter(obj:  val_18, millisecondsTimeout:  (val_1 == 1) ? 0 : (val_1))) == true)
            {
                goto label_36;
            }
            
            label_37:
            if(doAll != false)
            {
                    if(this._lastWritten != this._latestCompressed)
            {
                goto label_43;
            }
            
            }
            
            this.emitting = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _DeflateOne(object wi)
        {
            Ionic.Zlib.WorkItem val_10;
            System.Byte[] val_11;
            var val_12;
            val_10 = wi;
            if(val_10 != null)
            {
                    val_10 = 0;
            }
            
            new Ionic.Crc.CRC32() = new Ionic.Crc.CRC32();
            if(val_10 != 0)
            {
                    val_11 = 11993091;
            }
            else
            {
                    val_11 = 11993091;
            }
            
            new Ionic.Crc.CRC32().SlurpBlock(block:  val_11, offset:  0, count:  0);
            bool val_4 = new Ionic.Crc.CRC32().DeflateOneSegment(workitem:  val_10);
            mem[32] = new Ionic.Crc.CRC32().Crc32Result;
            bool val_6 = false;
            System.Threading.Monitor.Enter(obj:  this._latestLock, lockTaken: ref  val_6);
            if(69077560 > this._latestCompressed)
            {
                    val_12 = 0;
                this._latestCompressed = 69077560;
            }
            else
            {
                    val_12 = 0;
            }
            
            if(val_6 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._latestLock);
            }
            
            if(107 == 107)
            {
                
            }
            else
            {
                    if(val_12 != 0)
            {
                    val_12 = 0;
            }
            
            }
            
            bool val_7 = false;
            System.Threading.Monitor.Enter(obj:  this._toWrite, lockTaken: ref  val_7);
            this._toWrite.Enqueue(item:  0);
            if(val_7 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._toWrite);
            }
            
            if(((156 == 0) ? 156 : 156) == 156)
            {
                
            }
            
            bool val_9 = this._newlyCompressedBlob.Set();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool DeflateOneSegment(Ionic.Zlib.WorkItem workitem)
        {
            int val_4;
            if(workitem.compressor != null)
            {
                    workitem.compressor.ResetDeflate();
                workitem.compressor.NextIn = 0;
                val_4 = workitem.compressor.AvailableBytesIn;
                workitem.compressor.AvailableBytesIn = workitem.inputBytesAvailable;
            }
            else
            {
                    0.ResetDeflate();
                mem[24] = 0;
                val_4 = 28;
                mem[28] = workitem.inputBytesAvailable;
            }
            
            workitem.compressor.NextOut = 0;
            workitem.compressor.AvailableBytesOut = workitem.compressed.Length;
            do
            {
                if(workitem.compressor != null)
            {
                    int val_1 = workitem.compressor.Deflate(flush:  0);
            }
            else
            {
                    int val_2 = 0.Deflate(flush:  0);
            }
            
            }
            while((val_4 > 0) || (workitem.compressor.AvailableBytesOut == 0));
            
            int val_3 = workitem.compressor.Deflate(flush:  2);
            workitem.compressedBytesAvailable = workitem.compressor.TotalBytesOut;
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TraceOutput(Ionic.Zlib.ParallelDeflateOutputStream.TraceBits bits, string format, object[] varParams)
        {
            string val_3;
            object val_4;
            val_3 = format;
            val_4 = this;
            TraceBits val_3 = this._DesiredTrace;
            val_3 = val_3 & bits;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = this._outputLock;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  val_4, lockTaken: ref  val_1);
            System.Console.Write(format:  "{0:000} PDOS ", arg0:  System.Threading.Thread.CurrentThread);
            System.Console.WriteLine(format:  val_3, arg:  varParams);
            val_3 = 73;
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  val_4);
            }
            
            if(73 == 73)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanSeek()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanRead()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_CanWrite()
        {
            if(this._outStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override long get_Position()
        {
            if(this._outStream == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int Read(byte[] buffer, int offset, int count)
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
        private static ParallelDeflateOutputStream()
        {
            Ionic.Zlib.ParallelDeflateOutputStream.IO_BUFFER_SIZE_DEFAULT = 65536;
            Ionic.Zlib.ParallelDeflateOutputStream.BufferPairsPerCore = 4;
        }
    
    }

}
