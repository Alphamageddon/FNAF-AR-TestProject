using UnityEngine;

namespace Mapbox.Examples.Voxels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextureScale
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Color[] texColors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Color[] newColors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int w;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float ratioX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float ratioY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int w2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int finishCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Threading.Mutex mutex;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Point(UnityEngine.Texture2D tex, int newWidth, int newHeight)
        {
            Mapbox.Examples.Voxels.TextureScale.ThreadedScale(tex:  tex, newWidth:  newWidth, newHeight:  newHeight, useBilinear:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Bilinear(UnityEngine.Texture2D tex, int newWidth, int newHeight)
        {
            Mapbox.Examples.Voxels.TextureScale.ThreadedScale(tex:  tex, newWidth:  newWidth, newHeight:  newHeight, useBilinear:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ThreadedScale(UnityEngine.Texture2D tex, int newWidth, int newHeight, bool useBilinear)
        {
            int val_23;
            int val_24;
            int val_25;
            UnityEngine.Texture2D val_26;
            var val_27;
            var val_28;
            float val_29;
            object val_30;
            object val_31;
            IntPtr val_32;
            val_24 = newHeight;
            val_25 = newWidth;
            val_26 = tex;
            val_27 = 1152921505122340864;
            int val_2 = val_24 * val_25;
            Mapbox.Examples.Voxels.TextureScale.texColors = val_26.GetPixels();
            UnityEngine.Color[] val_3 = new UnityEngine.Color[0];
            Mapbox.Examples.Voxels.TextureScale.newColors = val_3;
            int val_4 = val_26.width;
            if(useBilinear != false)
            {
                    float val_22 = (float)val_25;
                val_22 = val_22 / ((float)val_4 - 1);
                val_22 = 1f / val_22;
                Mapbox.Examples.Voxels.TextureScale.ratioX = val_22;
                val_28 = public System.Int32 UnityEngine.Texture::get_height();
                float val_23 = (float)val_24;
                val_23 = val_23 / ((float)val_26.height - 1);
                val_29 = 1f / val_23;
            }
            else
            {
                    float val_24 = (float)val_4;
                val_24 = val_24 / (float)val_25;
                Mapbox.Examples.Voxels.TextureScale.ratioX = val_24;
                val_28 = public System.Int32 UnityEngine.Texture::get_height();
                val_29 = (float)val_26.height / (float)val_24;
            }
            
            Mapbox.Examples.Voxels.TextureScale.ratioY = val_29;
            Mapbox.Examples.Voxels.TextureScale.w = val_26.width;
            Mapbox.Examples.Voxels.TextureScale.w2 = val_25;
            val_30 = UnityEngine.Mathf.Min(a:  UnityEngine.SystemInfo.processorCount, b:  val_24);
            Mapbox.Examples.Voxels.TextureScale.finishCount = 0;
            if(Mapbox.Examples.Voxels.TextureScale.mutex == null)
            {
                    Mapbox.Examples.Voxels.TextureScale.mutex = new System.Threading.Mutex(initiallyOwned:  false);
            }
            
            if(val_30 >= 2)
            {
                goto label_8;
            }
            
            TextureScale.ThreadData val_13 = null;
            val_30 = val_13;
            val_13 = new TextureScale.ThreadData();
            .start = 0;
            .end = val_24;
            if(useBilinear == false)
            {
                goto label_9;
            }
            
            Mapbox.Examples.Voxels.TextureScale.BilinearScale(obj:  val_13);
            if(val_26 != null)
            {
                goto label_24;
            }
            
            goto label_19;
            label_8:
            int val_14 = val_30 - 1;
            val_31 = new TextureScale.ThreadData();
            if(val_14 < 1)
            {
                goto label_12;
            }
            
            int val_26 = 0;
            int val_15 = val_24 / val_30;
            var val_25 = val_14;
            do
            {
                val_31 = new System.Object();
                .start = val_26;
                .end = val_15 + val_26;
                if(useBilinear != false)
            {
                    val_32 = 1152921519866607552;
            }
            else
            {
                    val_32 = 1152921519866608576;
            }
            
                new System.Threading.ParameterizedThreadStart() = new System.Threading.ParameterizedThreadStart(object:  0, method:  val_32);
                new System.Threading.Thread(start:  new System.Threading.ParameterizedThreadStart()).Start(parameter:  new TextureScale.ThreadData());
                val_31 = new TextureScale.ThreadData();
                val_25 = val_25 - 1;
                val_26 = val_26 + val_15;
            }
            while(val_25 != 0);
            
            val_25 = val_25;
            val_26 = val_26;
            val_27 = 1152921505122340864;
            val_24 = val_24;
            val_23 = val_15 * val_14;
            goto label_17;
            label_9:
            Mapbox.Examples.Voxels.TextureScale.PointScale(obj:  val_13);
            if(val_26 != null)
            {
                goto label_24;
            }
            
            goto label_19;
            label_12:
            val_23 = 0;
            label_17:
            val_31 = new System.Object();
            .start = val_23;
            .end = val_24;
            if(useBilinear == false)
            {
                goto label_20;
            }
            
            Mapbox.Examples.Voxels.TextureScale.BilinearScale(obj:  new TextureScale.ThreadData());
            goto label_22;
            label_20:
            Mapbox.Examples.Voxels.TextureScale.PointScale(obj:  new TextureScale.ThreadData());
            goto label_22;
            label_23:
            System.Threading.Thread.Sleep(millisecondsTimeout:  1);
            label_22:
            if(Mapbox.Examples.Voxels.TextureScale.finishCount < val_30)
            {
                goto label_23;
            }
            
            if(val_26 != null)
            {
                goto label_24;
            }
            
            label_19:
            label_24:
            bool val_21 = val_26.Resize(width:  val_25, height:  val_24);
            if(val_26 != null)
            {
                    val_26.SetPixels(colors:  val_3);
            }
            else
            {
                    0.SetPixels(colors:  val_3);
            }
            
            val_26.Apply();
            Mapbox.Examples.Voxels.TextureScale.texColors = 0;
            Mapbox.Examples.Voxels.TextureScale.newColors = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void BilinearScale(object obj)
        {
            object val_23;
            var val_24;
            var val_25;
            float val_27;
            val_23 = obj;
            if(val_23 != null)
            {
                    val_24 = null;
                val_25 = null;
                do
            {
                val_27 = Mapbox.Examples.Voxels.TextureScale.ratioY;
                val_25 = null;
                if(Mapbox.Examples.Voxels.TextureScale.w2 >= 1)
            {
                    var val_26 = 0;
                float val_23 = (float)???;
                val_23 = val_27 * val_23;
                do
            {
                val_25 = null;
                float val_6 = Mapbox.Examples.Voxels.TextureScale.ratioX * 0f;
                float val_24 = Mapbox.Examples.Voxels.TextureScale.ratioX;
                int val_7 = (Mapbox.Examples.Voxels.TextureScale.w * W12) + W28;
                if(val_7 >= Mapbox.Examples.Voxels.TextureScale.texColors.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_8 = Mapbox.Examples.Voxels.TextureScale.texColors + (((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28))) << 4);
                val_24 = val_24 * 0f;
                float val_10 = val_24 - (float)W28;
                if(((long)val_7 + 1) >= Mapbox.Examples.Voxels.TextureScale.texColors.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_11 = Mapbox.Examples.Voxels.TextureScale.texColors + (((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28)) + 1))) << 4);
                UnityEngine.Color val_12 = Mapbox.Examples.Voxels.TextureScale.ColorLerpUnclamped(c1:  new UnityEngine.Color() {r = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28))) << 4) + 32, g = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28))) << 4) + 32 + 4, b = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28))) << 4) + 40, a = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28))) << 4) + 40 + 4}, c2:  new UnityEngine.Color() {r = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28)) + 1))) << 4) + 32, g = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28)) + 1))) << 4) + 32 + 4, b = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28)) + 1))) << 4) + 40, a = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * W12) + W28)) + 1))) << 4) + 40 + 4}, value:  val_10);
                int val_13 = (Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28;
                if(val_13 >= Mapbox.Examples.Voxels.TextureScale.texColors.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_14 = Mapbox.Examples.Voxels.TextureScale.texColors + (((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28))) << 4);
                var val_15 = (long)val_13 + 1;
                val_23 = (long)val_15;
                if(val_15 >= Mapbox.Examples.Voxels.TextureScale.texColors.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_16 = Mapbox.Examples.Voxels.TextureScale.texColors + (((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28)) + 1))) << 4);
                UnityEngine.Color val_17 = Mapbox.Examples.Voxels.TextureScale.ColorLerpUnclamped(c1:  new UnityEngine.Color() {r = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28))) << 4) + 32, g = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28))) << 4) + 32 + 4, b = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28))) << 4) + 40, a = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28))) << 4) + 40 + 4}, c2:  new UnityEngine.Color() {r = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28)) + 1))) << 4) + 32, g = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28)) + 1))) << 4) + 32 + 4, b = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28)) + 1))) << 4) + 40, a = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w * (W12 + 1)) + W28)) + 1))) << 4) + 40 + 4}, value:  val_10);
                float val_25 = Mapbox.Examples.Voxels.TextureScale.ratioY;
                val_25 = val_25 * val_23;
                val_25 = val_25 - (float)W12;
                UnityEngine.Color val_18 = Mapbox.Examples.Voxels.TextureScale.ColorLerpUnclamped(c1:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a}, c2:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a}, value:  val_25);
                val_27 = val_18.r;
                if(((Mapbox.Examples.Voxels.TextureScale.w2 * (???)) + val_26) >= Mapbox.Examples.Voxels.TextureScale.newColors.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_20 = Mapbox.Examples.Voxels.TextureScale.newColors + (((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * ???) + 0))) << 4);
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * ???) + 0))) << 4).__unknownFiledOffset_20 = val_27;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * ???) + 0))) << 4).__unknownFiledOffset_24 = val_18.g;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * ???) + 0))) << 4).__unknownFiledOffset_28 = val_18.b;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * ???) + 0))) << 4).__unknownFiledOffset_2C = val_18.a;
                val_26 = val_26 + 1;
            }
            while(val_26 < Mapbox.Examples.Voxels.TextureScale.w2);
            
            }
            
                var val_27 = ???;
                val_27 = val_27 + 1;
            }
            while(val_27 < (obj + 20));
            
                bool val_21 = Mapbox.Examples.Voxels.TextureScale.mutex.WaitOne();
                int val_28 = Mapbox.Examples.Voxels.TextureScale.finishCount;
                val_28 = val_28 + 1;
                Mapbox.Examples.Voxels.TextureScale.finishCount = val_28;
                Mapbox.Examples.Voxels.TextureScale.mutex.ReleaseMutex();
                return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PointScale(object obj)
        {
            var val_9;
            var val_10;
            if(obj != null)
            {
                    val_9 = null;
                do
            {
                if(Mapbox.Examples.Voxels.TextureScale.w2 >= 1)
            {
                    float val_8 = Mapbox.Examples.Voxels.TextureScale.ratioY;
                int val_9 = Mapbox.Examples.Voxels.TextureScale.w;
                var val_11 = 0;
                val_8 = val_8 * (float)W21;
                val_9 = val_9 * (int)val_8;
                do
            {
                float val_10 = 0f;
                val_10 = Mapbox.Examples.Voxels.TextureScale.ratioX * val_10;
                val_10 = val_10 + (float)val_9;
                if((int)val_10 >= Mapbox.Examples.Voxels.TextureScale.texColors.Length)
            {
                    val_9 = 0;
            }
            
                UnityEngine.Color[] val_3 = Mapbox.Examples.Voxels.TextureScale.texColors + (((long)(int)(((Mapbox.Examples.Voxels.TextureScale.ratioX * 0f) + (Mapbox.Examples.Voxels.TextureScale.w * (Mapbox.Examples.Voxels.TextureScale.ratioY * W21))))) << 4);
                if(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + val_11) >= Mapbox.Examples.Voxels.TextureScale.newColors.Length)
            {
                    val_9 = 0;
            }
            
                UnityEngine.Color[] val_5 = Mapbox.Examples.Voxels.TextureScale.newColors + (((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + 0))) << 4);
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + 0))) << 4).__unknownFiledOffset_20 = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.ratioX * 0f) + (Mapbox.Examples.Voxels.TextureScale.w * (Mapbox.Examples.Voxels.TextureScale.ratioY  + 32;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + 0))) << 4).__unknownFiledOffset_24 = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.ratioX * 0f) + (Mapbox.Examples.Voxels.TextureScale.w * (Mapbox.Examples.Voxels.TextureScale.ratioY  + 32 + 4;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + 0))) << 4).__unknownFiledOffset_28 = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.ratioX * 0f) + (Mapbox.Examples.Voxels.TextureScale.w * (Mapbox.Examples.Voxels.TextureScale.ratioY  + 40;
                (Mapbox.Examples.Voxels.TextureScale.newColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.w2 * W21) + 0))) << 4).__unknownFiledOffset_2C = (Mapbox.Examples.Voxels.TextureScale.texColors + ((long)(int)(((Mapbox.Examples.Voxels.TextureScale.ratioX * 0f) + (Mapbox.Examples.Voxels.TextureScale.w * (Mapbox.Examples.Voxels.TextureScale.ratioY  + 40 + 4;
                val_11 = val_11 + 1;
            }
            while(val_11 < Mapbox.Examples.Voxels.TextureScale.w2);
            
            }
            
                val_10 = W21 + 1;
            }
            while(val_10 < (obj + 20));
            
                bool val_6 = Mapbox.Examples.Voxels.TextureScale.mutex.WaitOne();
                int val_12 = Mapbox.Examples.Voxels.TextureScale.finishCount;
                val_12 = val_12 + 1;
                Mapbox.Examples.Voxels.TextureScale.finishCount = val_12;
                Mapbox.Examples.Voxels.TextureScale.mutex.ReleaseMutex();
                return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.Color ColorLerpUnclamped(UnityEngine.Color c1, UnityEngine.Color c2, float value)
        {
            c2.r = c2.r - c1.r;
            c2.g = c2.g - c1.g;
            c2.b = c2.b - c1.b;
            c2.a = c2.a - c1.a;
            c2.r = c2.r * value;
            c2.g = c2.g * value;
            c2.b = c2.b * value;
            c2.a = c2.a * value;
            c1.r = c1.r + c2.r;
            c1.g = c1.g + c2.g;
            c1.b = c1.b + c2.b;
            c1.a = c1.a + c2.a;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextureScale()
        {
        
        }
    
    }

}
