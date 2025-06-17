using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct Vector2d
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const double kEpsilon = 1E-05;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double x;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double y;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Item { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d normalized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double magnitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double sqrMagnitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d zero { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d one { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d up { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d right { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Item(int index)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Item(int index, double value)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_normalized()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_magnitude()
        {
            double val_1 = D0 * D0;
            val_1 = val_1 + (D1 * D1);
            return Mapbox.Utils.Mathd.Sqrt(d:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_sqrMagnitude()
        {
            double val_1 = D0 * D0;
            val_1 = val_1 + (D1 * D1);
            return (double)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d get_zero()
        {
            return new Mapbox.Utils.Vector2d();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d get_one()
        {
            return new Mapbox.Utils.Vector2d() {x = 1, y = 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d get_up()
        {
            return new Mapbox.Utils.Vector2d() {y = 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d get_right()
        {
            return new Mapbox.Utils.Vector2d() {x = 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Vector2d(double x, double y)
        {
            mem[1152921519941242496] = x;
            mem[1152921519941242504] = y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_Addition(Mapbox.Utils.Vector2d a, Mapbox.Utils.Vector2d b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return new Mapbox.Utils.Vector2d() {x = a.x, y = a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_Subtraction(Mapbox.Utils.Vector2d a, Mapbox.Utils.Vector2d b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return new Mapbox.Utils.Vector2d() {x = a.x, y = a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_UnaryNegation(Mapbox.Utils.Vector2d a)
        {
            return new Mapbox.Utils.Vector2d() {x = -a.x, y = -a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_Multiply(Mapbox.Utils.Vector2d a, double d)
        {
            a.x = a.x * d;
            a.y = a.y * d;
            return new Mapbox.Utils.Vector2d() {x = a.x, y = a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_Multiply(float d, Mapbox.Utils.Vector2d a)
        {
            d = a.x * (double)d;
            return new Mapbox.Utils.Vector2d() {x = d, y = a.y * (double)d};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d op_Division(Mapbox.Utils.Vector2d a, double d)
        {
            a.x = a.x / d;
            a.y = a.y / d;
            return new Mapbox.Utils.Vector2d() {x = a.x, y = a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Equality(Mapbox.Utils.Vector2d lhs, Mapbox.Utils.Vector2d rhs)
        {
            lhs.x = lhs.x - rhs.x;
            lhs.y = lhs.y - rhs.y;
            lhs.x = lhs.x * lhs.x;
            lhs.y = lhs.y * lhs.y;
            lhs.x = lhs.x + lhs.y;
            return (bool)(lhs.x <= 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Inequality(Mapbox.Utils.Vector2d lhs, Mapbox.Utils.Vector2d rhs)
        {
            lhs.x = lhs.x - rhs.x;
            lhs.y = lhs.y - rhs.y;
            lhs.x = lhs.x * lhs.x;
            lhs.y = lhs.y * lhs.y;
            lhs.x = lhs.x + lhs.y;
            return (bool)(lhs.x > 0f) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Set(double new_x, double new_y)
        {
            mem[1152921519942250496] = new_x;
            mem[1152921519942250504] = new_y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d Lerp(Mapbox.Utils.Vector2d from, Mapbox.Utils.Vector2d to, double t)
        {
            to.x = to.x - from.x;
            to.y = to.y - from.y;
            float val_1 = (t < 0) ? 0 : t;
            to.x = to.x * val_1;
            to.y = to.y * val_1;
            from.x = from.x + to.x;
            from.y = from.y + to.y;
            return new Mapbox.Utils.Vector2d() {x = from.x, y = from.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d MoveTowards(Mapbox.Utils.Vector2d current, Mapbox.Utils.Vector2d target, double maxDistanceDelta)
        {
            float val_4;
            float val_5;
            val_4 = target.y;
            val_5 = target.x;
            double val_1 = val_5 - current.x;
            double val_2 = val_4 - current.y;
            current.x = val_1 * val_1;
            current.y = val_2 * val_2;
            current.x = current.x + current.y;
            double val_3 = Mapbox.Utils.Mathd.Sqrt(d:  current.x);
            if(val_3 <= maxDistanceDelta)
            {
                    return new Mapbox.Utils.Vector2d() {x = val_5, y = val_4};
            }
            
            if(val_3 == 0f)
            {
                    return new Mapbox.Utils.Vector2d() {x = val_5, y = val_4};
            }
            
            current.y = val_1 / val_3;
            val_3 = val_2 / val_3;
            current.y = current.y * maxDistanceDelta;
            val_3 = val_3 * maxDistanceDelta;
            val_5 = current.x + current.y;
            val_4 = current.y + val_3;
            return new Mapbox.Utils.Vector2d() {x = val_5, y = val_4};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d Scale(Mapbox.Utils.Vector2d a, Mapbox.Utils.Vector2d b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return new Mapbox.Utils.Vector2d() {x = a.x, y = a.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Scale(Mapbox.Utils.Vector2d scale)
        {
            scale.x = scale.x * D2;
            scale.y = scale.y * D3;
            mem[1152921519942698496] = scale.x;
            mem[1152921519942698504] = scale.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Normalize()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            int val_2 = GetHashCode();
            val_2 = GetHashCode() ^ (val_2 << 2);
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object other)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Dot(Mapbox.Utils.Vector2d lhs, Mapbox.Utils.Vector2d rhs)
        {
            lhs.x = lhs.x * rhs.x;
            lhs.y = lhs.y * rhs.y;
            lhs.x = lhs.x + lhs.y;
            return (double)lhs.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Angle(Mapbox.Utils.Vector2d from, Mapbox.Utils.Vector2d to)
        {
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            from.x = from.x * from.x;
            from.y = from.y * from.y;
            from.x = from.x + from.y;
            double val_1 = Mapbox.Utils.Mathd.Sqrt(d:  from.x);
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            if(val_1 > (9.99999974737875E-06))
            {
                    val_12 = from.x / val_1;
                val_13 = from.y / val_1;
            }
            
            double val_2 = to.x * to.x;
            val_2 = val_2 + (to.y * to.y);
            double val_4 = Mapbox.Utils.Mathd.Sqrt(d:  val_2);
            val_14 = 0;
            if(val_4 > (9.99999974737875E-06))
            {
                    val_11 = to.x / val_4;
                val_14 = to.y / val_4;
            }
            
            val_4 = val_12 * val_11;
            val_14 = val_13 * val_14;
            val_4 = val_4 + val_14;
            double val_6 = Mapbox.Utils.Mathd.Acos(d:  (val_4 < 0) ? -1 : (val_14));
            val_6 = val_6 * 57.29578;
            return (double)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double Distance(Mapbox.Utils.Vector2d a, Mapbox.Utils.Vector2d b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            a.x = a.x * a.x;
            a.y = a.y * a.y;
            a.x = a.x + a.y;
            return Mapbox.Utils.Mathd.Sqrt(d:  a.x);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d ClampMagnitude(Mapbox.Utils.Vector2d vector, double maxLength)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            val_5 = vector.y;
            val_6 = vector.x;
            vector.x = val_6 * val_6;
            vector.y = val_5 * val_5;
            vector.x = vector.x + vector.y;
            if(vector.x <= (maxLength * maxLength))
            {
                    return new Mapbox.Utils.Vector2d() {x = val_6, y = val_5};
            }
            
            double val_2 = Mapbox.Utils.Mathd.Sqrt(d:  vector.x);
            val_7 = 0;
            val_8 = 0;
            if(val_2 > (9.99999974737875E-06))
            {
                    val_7 = val_6 / val_2;
                val_8 = val_5 / val_2;
            }
            
            val_6 = val_7 * maxLength;
            val_5 = val_8 * maxLength;
            return new Mapbox.Utils.Vector2d() {x = val_6, y = val_5};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static double SqrMagnitude(Mapbox.Utils.Vector2d a)
        {
            a.x = a.x * a.x;
            a.y = a.y * a.y;
            a.x = a.x + a.y;
            return (double)a.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double SqrMagnitude()
        {
            double val_1 = D0 * D0;
            val_1 = val_1 + (D1 * D1);
            return (double)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d Min(Mapbox.Utils.Vector2d lhs, Mapbox.Utils.Vector2d rhs)
        {
            return new Mapbox.Utils.Vector2d() {x = (lhs.x < 0) ? lhs.x : rhs.x, y = (lhs.y < 0) ? lhs.y : rhs.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2d Max(Mapbox.Utils.Vector2d lhs, Mapbox.Utils.Vector2d rhs)
        {
            return new Mapbox.Utils.Vector2d() {x = (lhs.x > rhs.x) ? lhs.x : rhs.x, y = (lhs.y > rhs.y) ? lhs.y : rhs.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] ToArray()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsNaN(Mapbox.Utils.Vector2d vector)
        {
            if((System.Double.IsNaN(d:  vector.x)) == false)
            {
                    return System.Double.IsNaN(d:  vector.y);
            }
            
            return true;
        }
    
    }

}
