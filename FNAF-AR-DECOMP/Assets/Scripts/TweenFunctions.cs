using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private static class SRMath.TweenFunctions
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float Linear(float t, float b, float c, float d)
    {
        t = t * c;
        t = t / d;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ExpoEaseOut(float t, float b, float c, float d)
    {
        float val_1 = c;
        if(t != d)
        {
                float val_1 = -10f;
            val_1 = t * val_1;
            val_1 = val_1 / d;
            val_1 = 1f - val_1;
            val_1 = val_1 * val_1;
        }
        
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ExpoEaseIn(float t, float b, float c, float d)
    {
        float val_1 = b;
        if(t == 0f)
        {
                return (float)val_1;
        }
        
        t = t / d;
        t = t + (-1f);
        t = t * 10f;
        t = t * c;
        val_1 = t + val_1;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ExpoEaseInOut(float t, float b, float c, float d)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_4 = d;
        val_5 = b;
        if(t == 0f)
        {
                return (float)val_5;
        }
        
        if(t == val_4)
        {
                val_5 = val_5 + c;
            return (float)val_5;
        }
        
        val_4 = t / (val_4 * 0.5f);
        if(val_4 < 0)
        {
                float val_2 = -1f;
            val_2 = val_4 + val_2;
            val_6 = val_2 * 10f;
            val_7 = c * 0.5f;
        }
        else
        {
                val_4 = val_4 + (-1f);
            float val_3 = -10f;
            val_3 = val_4 * val_3;
            val_7 = c * 0.5f;
            val_6 = 2f - val_3;
        }
        
        val_6 = val_7 * val_6;
        val_5 = val_6 + val_5;
        return (float)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ExpoEaseOutIn(float t, float b, float c, float d)
    {
        t = t + t;
        if((d * 0.5f) > t)
        {
                c = c * 0.5f;
            return SRMath.TweenFunctions.ExpoEaseOut(t:  t, b:  b, c:  c, d:  d);
        }
        
        c = c * 0.5f;
        t = t - d;
        b = c + b;
        return SRMath.TweenFunctions.ExpoEaseIn(t:  t, b:  b, c:  c, d:  d);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CircEaseOut(float t, float b, float c, float d)
    {
        float val_1;
        float val_1 = d;
        t = t / val_1;
        val_1 = t + (-1f);
        t = val_1 * val_1;
        float val_2 = 1f;
        val_2 = val_2 - t;
        if(t >= _TYPE_MAX_)
        {
                val_1 = val_2;
        }
        
        val_1 = val_1 * c;
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CircEaseIn(float t, float b, float c, float d)
    {
        float val_1;
        float val_1 = d;
        val_1 = t / val_1;
        t = val_1 * val_1;
        float val_2 = 1f;
        val_2 = val_2 - t;
        if(t >= _TYPE_MAX_)
        {
                val_1 = val_2;
        }
        
        val_1 = val_1 + (-1f);
        val_1 = val_1 * c;
        val_1 = b - val_1;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CircEaseInOut(float t, float b, float c, float d)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_4 = t;
        val_4 = 0.5f;
        val_4 = val_4 / (d * val_4);
        if(val_4 < 0)
        {
                val_5 = val_4 * val_4;
            val_6 = -1f;
            val_4 = -0.5f;
        }
        else
        {
                val_4 = val_4 + (-2f);
            val_5 = val_4 * val_4;
            val_6 = 1f;
        }
        
        if(val_5 >= _TYPE_MAX_)
        {
                val_7 = 1f - val_5;
        }
        
        val_7 = val_6 + val_7;
        val_7 = (val_4 * c) * val_7;
        val_7 = val_7 + b;
        return (float)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CircEaseOutIn(float t, float b, float c, float d)
    {
        t = t + t;
        if((d * 0.5f) > t)
        {
                c = c * 0.5f;
            return SRMath.TweenFunctions.CircEaseOut(t:  t, b:  b, c:  c, d:  d);
        }
        
        c = c * 0.5f;
        t = t - d;
        b = c + b;
        return SRMath.TweenFunctions.CircEaseIn(t:  t, b:  b, c:  c, d:  d);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuadEaseOut(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        t = t + (-2f);
        t = c * t;
        t = b - t;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuadEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuadEaseInOut(float t, float b, float c, float d)
    {
        float val_1;
        d = d * 0.5f;
        t = t / d;
        if(t < 0)
        {
                c = c * 0.5f;
            c = c * t;
            val_1 = t * c;
        }
        else
        {
                t = t + (-1f);
            c = c * (-0.5f);
            float val_1 = -2f;
            val_1 = t + val_1;
            t = t * val_1;
            t = t + (-1f);
            val_1 = c * t;
        }
        
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuadEaseOutIn(float t, float b, float c, float d)
    {
        float val_2;
        t = t + t;
        if((d * 0.5f) > t)
        {
                t = t / d;
            c = c * (-0.5f);
            c = c * t;
            t = t + (-2f);
            val_2 = c * t;
        }
        else
        {
                t = t - d;
            c = c * 0.5f;
            t = t / d;
            b = c + b;
            c = c * t;
            val_2 = t * c;
        }
        
        val_2 = b + val_2;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SineEaseOut(float t, float b, float c, float d)
    {
        float val_2 = 1.570796f;
        val_2 = (t / d) * val_2;
        val_2 = val_2 * c;
        val_2 = val_2 + b;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SineEaseIn(float t, float b, float c, float d)
    {
        float val_2 = 1.570796f;
        val_2 = (t / d) * val_2;
        val_2 = val_2 * c;
        val_2 = c - val_2;
        val_2 = val_2 + b;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SineEaseInOut(float t, float b, float c, float d)
    {
        float val_3;
        float val_4;
        float val_5;
        val_3 = t / (d * 0.5f);
        if(val_3 < 0)
        {
                float val_2 = 3.141593f;
            val_2 = val_3 * val_2;
            val_4 = val_2 * 0.5f;
            val_5 = c * 0.5f;
        }
        else
        {
                val_3 = val_3 + (-1f);
            float val_3 = 3.141593f;
            val_3 = val_3 * val_3;
            val_3 = val_3 * 0.5f;
            val_5 = c * (-0.5f);
            val_4 = val_3 + (-2f);
        }
        
        val_4 = val_5 * val_4;
        val_4 = val_4 + b;
        return (float)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SineEaseOutIn(float t, float b, float c, float d)
    {
        t = t + t;
        if((d * 0.5f) > t)
        {
                c = c * 0.5f;
            return SRMath.TweenFunctions.SineEaseOut(t:  t, b:  b, c:  c, d:  d);
        }
        
        c = c * 0.5f;
        t = t - d;
        b = c + b;
        return SRMath.TweenFunctions.SineEaseIn(t:  t, b:  b, c:  c, d:  d);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CubicEaseOut(float t, float b, float c, float d)
    {
        t = t / d;
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        t = t * val_1;
        t = t + 1f;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CubicEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        c = t * c;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CubicEaseInOut(float t, float b, float c, float d)
    {
        float val_1;
        d = d * 0.5f;
        t = t / d;
        if(t < 0)
        {
                c = c * 0.5f;
            c = c * t;
            c = t * c;
            val_1 = t * c;
        }
        else
        {
                float val_1 = -2f;
            t = t + val_1;
            val_1 = t * t;
            t = t * val_1;
            c = c * 0.5f;
            t = t + 2f;
            val_1 = c * t;
        }
        
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float CubicEaseOutIn(float t, float b, float c, float d)
    {
        float val_2;
        t = t + t;
        if((d * 0.5f) > t)
        {
                t = t / d;
            float val_2 = -1f;
            t = t + val_2;
            val_2 = t * t;
            t = t * val_2;
            c = c * 0.5f;
            t = t + 1f;
            val_2 = c * t;
        }
        else
        {
                t = t - d;
            c = c * 0.5f;
            t = t / d;
            b = c + b;
            c = c * t;
            c = t * c;
            val_2 = t * c;
        }
        
        val_2 = b + val_2;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuartEaseOut(float t, float b, float c, float d)
    {
        t = t / d;
        t = t + (-1f);
        float val_1 = t * t;
        val_1 = t * val_1;
        t = t * val_1;
        t = t + (-1f);
        t = t * c;
        t = b - t;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuartEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        c = t * c;
        c = t * c;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuartEaseInOut(float t, float b, float c, float d)
    {
        float val_2;
        d = d * 0.5f;
        t = t / d;
        if(t < 0)
        {
                c = c * 0.5f;
            c = c * t;
            c = t * c;
            c = t * c;
            val_2 = t * c;
        }
        else
        {
                t = t + (-2f);
            c = c * (-0.5f);
            float val_1 = t * t;
            val_1 = t * val_1;
            t = t * val_1;
            t = t + (-2f);
            val_2 = c * t;
        }
        
        val_2 = val_2 + b;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuartEaseOutIn(float t, float b, float c, float d)
    {
        float val_3;
        t = t + t;
        if((d * 0.5f) > t)
        {
                t = t / d;
            t = t + (-1f);
            c = c * (-0.5f);
            float val_2 = t * t;
            val_2 = t * val_2;
            t = t * val_2;
            t = t + (-1f);
            val_3 = c * t;
        }
        else
        {
                t = t - d;
            c = c * 0.5f;
            t = t / d;
            b = c + b;
            c = c * t;
            c = t * c;
            c = t * c;
            val_3 = t * c;
        }
        
        val_3 = b + val_3;
        return (float)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuintEaseOut(float t, float b, float c, float d)
    {
        t = t / d;
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * t;
        val_1 = t * val_1;
        val_1 = t * val_1;
        t = t * val_1;
        t = t + 1f;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuintEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        c = t * c;
        c = t * c;
        c = t * c;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuintEaseInOut(float t, float b, float c, float d)
    {
        float val_1;
        d = d * 0.5f;
        t = t / d;
        if(t < 0)
        {
                c = c * 0.5f;
            c = c * t;
            c = t * c;
            c = t * c;
            c = t * c;
            val_1 = t * c;
        }
        else
        {
                float val_1 = -2f;
            t = t + val_1;
            val_1 = t * t;
            val_1 = t * val_1;
            val_1 = t * val_1;
            t = t * val_1;
            c = c * 0.5f;
            t = t + 2f;
            val_1 = c * t;
        }
        
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float QuintEaseOutIn(float t, float b, float c, float d)
    {
        float val_2;
        t = t + t;
        if((d * 0.5f) > t)
        {
                t = t / d;
            float val_2 = -1f;
            t = t + val_2;
            val_2 = t * t;
            val_2 = t * val_2;
            val_2 = t * val_2;
            t = t * val_2;
            c = c * 0.5f;
            t = t + 1f;
            val_2 = c * t;
        }
        else
        {
                t = t - d;
            c = c * 0.5f;
            t = t / d;
            b = c + b;
            c = c * t;
            c = t * c;
            c = t * c;
            c = t * c;
            val_2 = t * c;
        }
        
        val_2 = b + val_2;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ElasticEaseOut(float t, float b, float c, float d)
    {
        float val_6 = c;
        float val_1 = t / d;
        if(val_1 != 1f)
        {
                float val_2 = d * 0.3f;
            float val_6 = -10f;
            val_6 = val_1 * val_6;
            float val_7 = 6.283185f;
            float val_4 = val_1 * d;
            val_4 = val_4 - (val_2 * 0.25f);
            val_7 = val_4 * val_7;
            val_7 = val_7 / val_2;
            val_7 = (val_6 * val_6) * val_7;
            val_6 = val_7 + val_6;
        }
        
        val_7 = val_6 + b;
        return (float)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ElasticEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        if(t == 1f)
        {
                float val_1 = b + c;
            return (float)val_8;
        }
        
        float val_2 = d * 0.3f;
        float val_7 = -1f;
        float val_4 = t + val_7;
        float val_6 = 10f;
        val_6 = val_4 * val_6;
        float val_8 = 6.283185f;
        val_7 = val_4 * d;
        val_7 = val_7 - (val_2 * 0.25f);
        val_8 = val_7 * val_8;
        val_8 = val_8 / val_2;
        val_8 = (val_6 * c) * val_8;
        val_8 = b - val_8;
        return (float)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ElasticEaseInOut(float t, float b, float c, float d)
    {
        float val_1 = d * 0.5f;
        val_1 = t / val_1;
        if(val_1 == 2f)
        {
                float val_2 = b + c;
            return (float)val_13;
        }
        
        float val_3 = d * 0.45f;
        float val_4 = val_3 * 0.25f;
        float val_5 = val_1 + (-1f);
        if(val_1 < 0)
        {
                float val_10 = 10f;
            val_10 = val_5 * val_10;
            float val_11 = 6.283185f;
            float val_6 = val_5 * d;
            val_6 = val_6 - val_4;
            val_11 = val_6 * val_11;
            val_11 = val_11 / val_3;
            val_11 = (val_10 * c) * val_11;
            val_11 = val_11 * (-0.5f);
            val_11 = b + val_11;
            return (float)val_13;
        }
        
        float val_12 = -10f;
        val_12 = val_5 * val_12;
        float val_13 = 6.283185f;
        float val_8 = val_5 * d;
        val_8 = val_8 - val_4;
        val_13 = val_8 * val_13;
        val_13 = val_13 / val_3;
        val_13 = (val_12 * c) * val_13;
        val_13 = val_13 * 0.5f;
        val_13 = val_13 + c;
        val_13 = val_13 + b;
        return (float)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float ElasticEaseOutIn(float t, float b, float c, float d)
    {
        t = t + t;
        if((d * 0.5f) > t)
        {
                c = c * 0.5f;
            return SRMath.TweenFunctions.ElasticEaseOut(t:  t, b:  b, c:  c, d:  d);
        }
        
        c = c * 0.5f;
        t = t - d;
        b = c + b;
        return SRMath.TweenFunctions.ElasticEaseIn(t:  t, b:  b, c:  c, d:  d);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BounceEaseOut(float t, float b, float c, float d)
    {
        float val_1;
        t = t / d;
        if(t < 0)
        {
                float val_1 = 7.5625f;
            val_1 = t * val_1;
            val_1 = t * val_1;
        }
        else
        {
                if((double)t < 0)
        {
                float val_2 = -0.5454546f;
            t = t + val_2;
            val_2 = t * 7.5625f;
            t = t * val_2;
            val_1 = t + 0.75f;
        }
        else
        {
                if((double)t < 0)
        {
                float val_3 = -0.8181818f;
            t = t + val_3;
            val_3 = t * 7.5625f;
            t = t * val_3;
            val_1 = t + 0.9375f;
        }
        else
        {
                float val_4 = -0.9545454f;
            t = t + val_4;
            val_4 = t * 7.5625f;
            t = t * val_4;
            val_1 = t + 0.984375f;
        }
        
        }
        
        }
        
        val_1 = val_1 * c;
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BounceEaseIn(float t, float b, float c, float d)
    {
        t = d - t;
        float val_1 = SRMath.TweenFunctions.BounceEaseOut(t:  t, b:  0f, c:  c, d:  d);
        val_1 = c - val_1;
        val_1 = val_1 + b;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BounceEaseInOut(float t, float b, float c, float d)
    {
        float val_6;
        t = t + t;
        if((d * 0.5f) > t)
        {
                t = d - t;
            float val_2 = SRMath.TweenFunctions.BounceEaseOut(t:  t, b:  0f, c:  c, d:  d);
            val_2 = c - val_2;
            val_2 = val_2 + 0f;
            val_6 = val_2 * 0.5f;
        }
        else
        {
                t = t - d;
            float val_3 = SRMath.TweenFunctions.BounceEaseOut(t:  t, b:  0f, c:  c, d:  d);
            val_3 = val_3 * 0.5f;
            val_6 = (c * 0.5f) + val_3;
        }
        
        val_6 = val_6 + b;
        return (float)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BounceEaseOutIn(float t, float b, float c, float d)
    {
        t = t + t;
        if((d * 0.5f) > t)
        {
                c = c * 0.5f;
            return SRMath.TweenFunctions.BounceEaseOut(t:  t, b:  b, c:  c, d:  d);
        }
        
        t = t - d;
        float val_2 = c * 0.5f;
        t = d - t;
        float val_4 = SRMath.TweenFunctions.BounceEaseOut(t:  t, b:  0f, c:  val_2, d:  d);
        val_4 = val_2 - val_4;
        val_4 = (val_2 + b) + val_4;
        return (float)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BackEaseOut(float t, float b, float c, float d)
    {
        t = t / d;
        float val_1 = -1f;
        t = t + val_1;
        val_1 = t * 2.70158f;
        t = t * t;
        val_1 = val_1 + 1.70158f;
        t = t * val_1;
        t = t + 1f;
        t = t * c;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BackEaseIn(float t, float b, float c, float d)
    {
        t = t / d;
        c = t * c;
        c = t * c;
        t = t * 2.70158f;
        t = t + (-1.70158f);
        t = c * t;
        t = t + b;
        return (float)t;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BackEaseInOut(float t, float b, float c, float d)
    {
        float val_1;
        float val_2;
        float val_1 = 0.5f;
        d = d * val_1;
        t = t / d;
        if(t < 0)
        {
                val_1 = c * val_1;
            val_1 = t * t;
            t = t * 3.594909f;
            t = t + (-2.594909f);
            val_2 = val_1 * t;
        }
        else
        {
                val_1 = c * val_1;
            float val_2 = -2f;
            t = t + val_2;
            val_2 = t * t;
            t = t * 3.594909f;
            t = t + 2.594909f;
            t = val_2 * t;
            val_2 = t + 2f;
        }
        
        val_2 = val_1 * val_2;
        val_2 = val_2 + b;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float BackEaseOutIn(float t, float b, float c, float d)
    {
        float val_5;
        float val_6;
        float val_2 = t + t;
        if((d * 0.5f) > t)
        {
                val_5 = c * 0.5f;
            float val_3 = val_2 / d;
            float val_4 = -1f;
            val_3 = val_3 + val_4;
            val_4 = val_3 * val_3;
            val_3 = val_3 * 2.70158f;
            val_3 = val_3 + 1.70158f;
            val_3 = val_4 * val_3;
            val_6 = val_3 + 1f;
        }
        else
        {
                t = val_2 - d;
            t = t / d;
            c = c * 0.5f;
            b = c + b;
            c = c * t;
            val_6 = t * c;
            t = t * 2.70158f;
            val_5 = t + (-1.70158f);
        }
        
        val_5 = val_5 * val_6;
        val_5 = val_5 + b;
        return (float)val_5;
    }

}
