using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class SharedUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int URShift(int number, int bits)
        {
            number = number >> (bits & 31);
            return (int)number;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int ReadInput(System.IO.TextReader sourceTextReader, byte[] target, int start, int count)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_6 = start;
            val_7 = sourceTextReader;
            if(target.Length == 0)
            {
                goto label_2;
            }
            
            int val_1 = target.Length & 4294967295;
            val_5 = new char[0];
            val_8 = val_7;
            if(val_8 == null)
            {
                goto label_4;
            }
            
            System.IO.TextReader val_3 = val_8 + val_6;
            if(val_3 <= val_6)
            {
                    return (int)val_8;
            }
            
            var val_4 = (long)val_3 - (val_6 << );
            do
            {
                mem2[0] = null;
                val_4 = val_4 - 1;
                val_6 = val_6 + 1;
            }
            while(val_4 != 0);
            
            return (int)val_8;
            label_2:
            val_8 = 0;
            return (int)val_8;
            label_4:
            val_8 = 0;
            return (int)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static byte[] ToByteArray(string sourceString)
        {
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static char[] ToCharArray(byte[] byteArray)
        {
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedUtils()
        {
        
        }
    
    }

}
