using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct Mathd
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double PI = 3.141593;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double Infinity = ∞;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double NegativeInfinity = -∞;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double Deg2Rad = 0.01745329;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double Rad2Deg = 57.29578;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double Epsilon = 1.401298E-45;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Sin(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Cos(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Tan(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Asin(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Acos(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Atan(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Atan2(double y, double x)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Sqrt(double d)
        {
            if(d <= _TYPE_MAX_)
            {
                    return (double)d;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Abs(double d)
        {
            return (double)System.Math.Abs(d);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Abs(int value)
        {
            return (int)(value < 0) ? (-value) : value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Min(double a, double b)
        {
            return (double)(a < 0) ? a : b;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Min(double[] values)
        {
            double val_2;
            int val_3;
            var val_4;
            if(values.Length == 0)
            {
                goto label_1;
            }
            
            val_2 = values[0];
            if(values.Length < 2)
            {
                    return (double)val_2;
            }
            
            val_3 = values.Length & 4294967295;
            val_4 = 0;
            goto label_3;
            label_7:
            val_3 = values.Length;
            val_4 = 1;
            label_3:
            if(D0 < 0)
            {
                    val_2 = V0.16B;
            }
            
            if((val_3 - 2) != val_4)
            {
                goto label_7;
            }
            
            return (double)val_2;
            label_1:
            val_2 = 0;
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Min(int a, int b)
        {
            return (int)(a < b) ? a : b;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Min(int[] values)
        {
            int val_2;
            int val_3;
            var val_4;
            if(values.Length == 0)
            {
                goto label_1;
            }
            
            val_2 = values[0];
            if(values.Length < 2)
            {
                    return (int)val_2;
            }
            
            val_3 = values.Length & 4294967295;
            val_4 = 0;
            goto label_3;
            label_7:
            val_3 = values.Length;
            val_4 = 1;
            label_3:
            if(val_3 < val_2)
            {
                    val_2 = val_3;
            }
            
            if((val_3 - 2) != val_4)
            {
                goto label_7;
            }
            
            return (int)val_2;
            label_1:
            val_2 = 0;
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Max(double a, double b)
        {
            return (double)(a > b) ? a : b;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Max(double[] values)
        {
            double val_2;
            int val_3;
            var val_4;
            if(values.Length == 0)
            {
                goto label_1;
            }
            
            val_2 = values[0];
            if(values.Length < 2)
            {
                    return (double)val_2;
            }
            
            val_3 = values.Length & 4294967295;
            val_4 = 0;
            goto label_3;
            label_7:
            val_3 = values.Length;
            val_4 = 1;
            label_3:
            if(D0 > val_2)
            {
                    val_2 = V0.16B;
            }
            
            if((val_3 - 2) != val_4)
            {
                goto label_7;
            }
            
            return (double)val_2;
            label_1:
            val_2 = 0;
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Max(int a, int b)
        {
            return (int)(a > b) ? a : b;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Max(int[] values)
        {
            int val_2;
            int val_3;
            var val_4;
            if(values.Length == 0)
            {
                goto label_1;
            }
            
            val_2 = values[0];
            if(values.Length < 2)
            {
                    return (int)val_2;
            }
            
            val_3 = values.Length & 4294967295;
            val_4 = 0;
            goto label_3;
            label_7:
            val_3 = values.Length;
            val_4 = 1;
            label_3:
            if(val_3 > val_2)
            {
                    val_2 = val_3;
            }
            
            if((val_3 - 2) != val_4)
            {
                goto label_7;
            }
            
            return (int)val_2;
            label_1:
            val_2 = 0;
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Pow(double d, double p)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Exp(double power)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Log(double d, double p)
        {
            return System.Math.Log(a:  d, newBase:  p);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Log(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Log10(double d)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Ceil(double d)
        {
            return (double)d;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Floor(double d)
        {
            return (double)d;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Round(double d)
        {
            float val_1;
            float val_4;
            double val_5;
            if(d >= 0f)
            {
                goto label_3;
            }
            
            if(d != (-0.5))
            {
                goto label_4;
            }
            
            val_4 = val_1;
            val_5 = -1;
            goto label_5;
            label_3:
            if(d != 0.5)
            {
                    return (double)d + 0.5;
            }
            
            val_4 = val_1;
            val_5 = 1;
            label_5:
            val_5 = val_4 + val_5;
            val_4 = (((long)val_4 & 1) != 0) ? (val_4) : (val_5);
            return (double)d + 0.5;
            label_4:
            double val_2 = d + (-0.5);
            return (double)d + 0.5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CeilToInt(double d)
        {
            return (int)null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int FloorToInt(double d)
        {
            return (int)null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int RoundToInt(double d)
        {
            float val_1;
            float val_4;
            double val_5;
            if(d >= 0f)
            {
                goto label_3;
            }
            
            if(d != (-0.5))
            {
                goto label_4;
            }
            
            val_4 = val_1;
            val_5 = -1;
            goto label_5;
            label_3:
            if(d != 0.5)
            {
                    return (int)(int)d + 0.5;
            }
            
            val_4 = val_1;
            val_5 = 1;
            label_5:
            val_5 = val_4 + val_5;
            val_4 = (((long)val_4 & 1) != 0) ? (val_4) : (val_5);
            return (int)(int)d + 0.5;
            label_4:
            double val_2 = d + (-0.5);
            return (int)(int)d + 0.5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Sign(double d)
        {
            return (double)(d < 0f) ? -1 : 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Clamp(double value, double min, double max)
        {
            if(value >= 0)
            {
                    return (double)(value > max) ? max : value;
            }
            
            return (double)min;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Clamp(int value, int min, int max)
        {
            if(value >= min)
            {
                    return (int)(value > max) ? max : value;
            }
            
            return (int)min;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Clamp01(double value)
        {
            if(value >= 0)
            {
                    return (double)value;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Lerp(double from, double to, double t)
        {
            to = to - from;
            to = to * ((t < 0) ? 0 : t);
            from = to + from;
            return (double)from;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double LerpAngle(double a, double b, double t)
        {
            double val_1 = b - a;
            a = val_1 / 360;
            double val_2 = Mapbox.Utils.Mathd.Floor(d:  a);
            double val_4 = -360;
            val_2 = val_2 * 360;
            val_2 = val_1 - val_2;
            val_4 = val_2 + val_4;
            val_2 = (val_2 > 180) ? (val_4) : (val_2);
            val_2 = ((t < 0) ? 0 : 1) * val_2;
            val_2 = val_2 + a;
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double MoveTowards(double current, double target, double maxDelta)
        {
            double val_4 = target;
            double val_1 = val_4 - current;
            if((Mapbox.Utils.Mathd.Abs(d:  val_1)) <= maxDelta)
            {
                    return (double)val_4;
            }
            
            float val_3 = (val_1 < 0f) ? -1 : 1;
            val_3 = val_3 * maxDelta;
            val_4 = val_3 + current;
            return (double)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double MoveTowardsAngle(double current, double target, double maxDelta)
        {
            float val_5;
            double val_1 = target - current;
            current = val_1 / 360;
            double val_2 = Mapbox.Utils.Mathd.Floor(d:  current);
            double val_5 = -360;
            val_2 = val_2 * 360;
            val_2 = val_1 - val_2;
            val_5 = val_2 + val_5;
            val_2 = (val_2 > 180) ? (val_5) : (val_2);
            val_5 = val_2 + current;
            val_1 = val_5 - current;
            if((Mapbox.Utils.Mathd.Abs(d:  val_1)) <= maxDelta)
            {
                    return (double)val_5;
            }
            
            float val_4 = (val_1 < 0f) ? -1 : 1;
            val_4 = val_4 * maxDelta;
            val_5 = val_4 + current;
            return (double)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double SmoothStep(double from, double to, double t)
        {
            double val_2 = -2;
            float val_1 = (t < 0) ? 0 : t;
            double val_3 = 3;
            val_2 = val_1 * val_2;
            val_3 = val_1 * val_3;
            val_2 = val_1 * val_2;
            val_3 = val_1 * val_3;
            val_1 = val_1 * val_2;
            val_1 = val_3 + val_1;
            to = val_1 * to;
            val_1 = 1 - val_1;
            from = val_1 * from;
            from = to + from;
            return (double)from;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Gamma(double value, double absmax, double gamma)
        {
            double val_1 = Mapbox.Utils.Mathd.Abs(d:  value);
            if(val_1 > absmax)
            {
                    val_1 = (value < 0) ? (-val_1) : (val_1);
                return (double)(value < 0) ? (val_2) : (val_4);
            }
            
            val_1 = val_1 / absmax;
            double val_4 = gamma;
            double val_2 = Mapbox.Utils.Mathd.Pow(d:  val_1, p:  val_4);
            val_4 = val_2 * absmax;
            val_2 = -(val_2 * absmax);
            return (double)(value < 0) ? (val_2) : (val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool Approximately(double a, double b)
        {
            a = b - a;
            double val_2 = Mapbox.Utils.Mathd.Abs(d:  a);
            double val_3 = Mapbox.Utils.Mathd.Abs(d:  b);
            float val_4 = (val_2 > val_3) ? (val_2) : (val_3);
            val_4 = val_4 * (1E-06);
            return (bool)((Mapbox.Utils.Mathd.Abs(d:  a)) < 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            double val_16;
            double val_1 = current - target;
            double val_2 = 2 / 0.0001;
            double val_3 = 0.0001 * maxSpeed;
            maxSpeed = -(0.0001 * maxSpeed);
            double val_15 = 0.479999989271164;
            double val_16 = 0.234999999403954;
            float val_5 = (val_1 < 0) ? (maxSpeed) : ((val_1 > val_3) ? (val_3) : (val_1));
            double val_6 = val_2 * deltaTime;
            val_15 = val_6 * val_15;
            val_15 = val_6 * val_15;
            val_15 = (val_6 + 1) + val_15;
            val_16 = val_6 * val_16;
            val_16 = val_6 * val_16;
            val_6 = val_6 * val_16;
            val_6 = val_15 + val_6;
            double val_9 = (val_2 * val_5) + currentVelocity;
            val_6 = 1 / val_6;
            double val_10 = val_9 * deltaTime;
            val_9 = val_5 + val_10;
            current = current - val_5;
            val_9 = val_6 * val_9;
            current = current + val_9;
            var val_12 = ((target - current) > 0f) ? 1 : 0;
            val_12 = val_12 ^ ((current > target) ? 1 : 0);
            if((val_12 & 1) != 0)
            {
                    target = val_2 * val_10;
                target = currentVelocity - target;
                val_16 = val_6 * target;
            }
            else
            {
                    val_16 = (target - target) / deltaTime;
            }
            
            currentVelocity = val_16;
            return (double)target;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double SmoothDampAngle(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            double val_1 = target - current;
            current = val_1 / 360;
            double val_2 = Mapbox.Utils.Mathd.Floor(d:  current);
            double val_4 = -360;
            val_2 = val_2 * 360;
            val_2 = val_1 - val_2;
            val_4 = val_2 + val_4;
            val_2 = (val_2 > 180) ? (val_4) : (val_2);
            val_4 = val_2 + current;
            return Mapbox.Utils.Mathd.SmoothDamp(current:  current, target:  val_4, currentVelocity: ref  1.28823413940876E-231, smoothTime:  smoothTime, maxSpeed:  maxSpeed, deltaTime:  deltaTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Repeat(double t, double length)
        {
            t = t / length;
            double val_1 = Mapbox.Utils.Mathd.Floor(d:  t);
            val_1 = val_1 * length;
            val_1 = t - val_1;
            return (double)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double PingPong(double t, double length)
        {
            double val_1 = length + length;
            t = t / val_1;
            double val_2 = Mapbox.Utils.Mathd.Floor(d:  t);
            val_2 = val_1 * val_2;
            val_2 = t - val_2;
            val_2 = val_2 - length;
            double val_3 = Mapbox.Utils.Mathd.Abs(d:  val_2);
            val_3 = length - val_3;
            return (double)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double InverseLerp(double from, double to, double value)
        {
            if(from < 0)
            {
                    if(value < 0)
            {
                    return (double)val_2;
            }
            
                if(value > to)
            {
                    return 1;
            }
            
                double val_1 = value - from;
                to = to - from;
                val_1 = val_1 / to;
                return (double)val_1;
            }
            
            if(from <= to)
            {
                    return (double)val_2;
            }
            
            if(value < 0)
            {
                    return 1;
            }
            
            if(value > from)
            {
                    return (double)val_2;
            }
            
            double val_2 = value - to;
            to = from - to;
            val_2 = val_2 / to;
            val_2 = 1 - val_2;
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double DeltaAngle(double current, double target)
        {
            double val_1 = target - current;
            current = val_1 / 360;
            double val_2 = Mapbox.Utils.Mathd.Floor(d:  current);
            double val_3 = -360;
            val_2 = val_2 * 360;
            val_2 = val_1 - val_2;
            val_3 = val_2 + val_3;
            val_2 = (val_2 > 180) ? (val_3) : (val_2);
            return (double)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static bool LineIntersection(Mapbox.Utils.Vector2d p1, Mapbox.Utils.Vector2d p2, Mapbox.Utils.Vector2d p3, Mapbox.Utils.Vector2d p4, ref Mapbox.Utils.Vector2d result)
        {
            double val_1 = p2.x - p1.x;
            double val_2 = p2.y - p1.y;
            double val_3 = p4.x - p3.x;
            double val_4 = p4.y - p3.y;
            p4.y = val_1 * val_4;
            p4.y = p4.y - (val_2 * val_3);
            if(p4.y == 0f)
            {
                    return false;
            }
            
            p3.y = p3.y - p1.y;
            p3.x = p3.x - p1.x;
            p3.x = p3.x * val_4;
            val_3 = p3.y * val_3;
            val_3 = p3.x - val_3;
            val_3 = val_3 / p4.y;
            p3.x = val_1 * val_3;
            val_2 = val_2 * val_3;
            p1.x = p1.x + p3.x;
            p1.y = p1.y + val_2;
            result.x = p1.x;
            result.y = p1.y;
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static bool LineSegmentIntersection(Mapbox.Utils.Vector2d p1, Mapbox.Utils.Vector2d p2, Mapbox.Utils.Vector2d p3, Mapbox.Utils.Vector2d p4, ref Mapbox.Utils.Vector2d result)
        {
            var val_7;
            double val_1 = p2.x - p1.x;
            double val_2 = p2.y - p1.y;
            double val_3 = p4.x - p3.x;
            p4.y = p4.y - p3.y;
            double val_4 = val_1 * p4.y;
            val_4 = val_4 - (val_2 * val_3);
            if(val_4 != 0f)
            {
                    p3.x = p3.x - p1.x;
                p3.y = p3.y - p1.y;
                p4.y = p3.x * p4.y;
                val_3 = p3.y * val_3;
                val_3 = p4.y - val_3;
                val_3 = val_3 / val_4;
                val_7 = 0;
                if(val_3 < 0)
            {
                    return (bool)val_7;
            }
            
                if(val_3 > 1)
            {
                    return (bool)val_7;
            }
            
                p3.x = val_2 * p3.x;
                p3.y = val_1 * p3.y;
                p3.x = p3.x - p3.y;
                p3.x = p3.x / val_4;
                val_7 = 0;
                if(p3.x < 0)
            {
                    return (bool)val_7;
            }
            
                if(p3.x > 1)
            {
                    return (bool)val_7;
            }
            
                val_2 = val_2 * val_3;
                p1.x = p1.x + (val_1 * val_3);
                p1.y = p1.y + val_2;
                val_7 = 1;
                result.x = p1.x;
                result.y = p1.y;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
    
    }

}
