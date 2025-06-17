using UnityEngine;

namespace Ionic.Zlib
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Adler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly uint BASE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly int NMAX;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static uint Adler32(uint adler, byte[] buf, int index, int len)
        {
            var val_31;
            int val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            int val_37;
            var val_38;
            int val_39;
            var val_40;
            var val_41;
            var val_42;
            int val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            val_32 = len;
            val_33 = index;
            if(buf == null)
            {
                goto label_1;
            }
            
            val_34 = adler & 65535;
            val_35 = adler >> 16;
            if(val_32 < 1)
            {
                goto label_2;
            }
            
            val_31 = 1152921505284853760;
            val_36 = null;
            label_34:
            val_36 = null;
            val_37 = val_32;
            if(val_32 >= Ionic.Zlib.Adler.NMAX)
            {
                    val_37 = Ionic.Zlib.Adler.NMAX;
            }
            
            int val_1 =  - 16;
            if(val_32 >= Ionic.Zlib.Adler.NMAX)
            {
                goto label_9;
            }
            
            val_38 = ;
            val_39 = val_33;
            if(val_38 == 0)
            {
                goto label_10;
            }
            
            label_31:
            val_40 = ;
            var val_27 = val_38;
            do
            {
                int val_2 = val_39 + 1;
                val_27 = val_27 - 1;
                val_41 = val_34 + buf[(long)val_39];
                val_42 = val_41 + val_35;
            }
            while(val_27 != 0);
            
            val_31 = 1152921505284853760;
            val_33 = val_38 + val_39;
            val_37 = val_40;
            goto label_13;
            label_9:
            val_1 = val_1 & 4294967280;
            val_1 = val_33 + val_1;
            val_1 = val_1 + 16;
            int val_3 =  + 16;
            do
            {
                val_43 = buf.Length;
                var val_42 = (long)val_33;
                if(val_33 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                var val_5 = val_42 + 1;
                val_34 = val_34 + buf[val_42];
                uint val_7 = val_34 + val_35;
                if(val_5 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                var val_8 = val_5 + 1;
                uint val_10 = val_34 + (buf[(long)val_33 + 1]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 2]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 3]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 4]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 5]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 6]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 7]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 8]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 9]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 10]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 11]);
                val_7 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_10 = val_10 + (buf[(long)val_42 + 12]);
                val_7 = val_7 + val_10;
                var val_43 = (long)val_42 + 13;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_8 = val_8 + 1;
                val_42 = val_42 + 15;
                val_10 = val_10 + buf[val_43];
                val_43 = val_7 + val_10;
                if(val_8 >= val_43)
            {
                    val_43 = buf.Length;
            }
            
                val_10 = val_10 + (buf[(long)val_42 + 14]);
                val_43 = val_43 + val_10;
                val_3 = val_3 - 16;
                var val_23 = (val_8 + 1) + 1;
                val_41 = val_10 + buf[(long)val_42];
                val_42 = val_43;
            }
            while(val_3 > 31);
            
            val_38 = val_1 - val_1;
            val_39 = val_1;
            val_32 = val_32;
            val_40 = 1152921505284853760;
            val_31 = val_40;
            if(val_38 != 0)
            {
                goto label_31;
            }
            
            label_10:
            val_33 = val_39;
            label_13:
            val_32 = val_32 - ;
            val_44 = null;
            val_45 = val_41 - ((val_41 / Ionic.Zlib.Adler.BASE) * Ionic.Zlib.Adler.BASE);
            val_46 = val_42;
            if(val_32 > 0)
            {
                goto label_34;
            }
            
            label_2:
            val_47 = val_45;
            return (uint)val_47;
            label_1:
            val_47 = 1;
            return (uint)val_47;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Adler()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Adler()
        {
            Ionic.Zlib.Adler.BASE = 65521;
            Ionic.Zlib.Adler.NMAX = 5552;
        }
    
    }

}
