using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct Vector2dBounds
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d SouthWest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d NorthEast;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double South { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double West { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double North { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double East { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Center { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Vector2dBounds(Mapbox.Utils.Vector2d sw, Mapbox.Utils.Vector2d ne)
        {
            this.NorthEast = sw;
            mem[1152921519930967336] = sw.y;
            mem[1152921519930967344] = ne.x;
            mem[1152921519930967352] = ne.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_South()
        {
            return (double)this.NorthEast;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_West()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_North()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_East()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Center()
        {
            Mapbox.Utils.Vector2d val_2 = this.NorthEast;
            double val_1 = D1 + D2;
            val_2 = val_2 + D3;
            val_1 = val_1 * 0.5;
            val_2 = val_2 * 0.5;
            return new Mapbox.Utils.Vector2d() {x = val_2, y = val_1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Center(Mapbox.Utils.Vector2d value)
        {
            double val_1 = D2 - this.NorthEast;
            double val_2 = D3 - D5;
            double val_4 = 0.5;
            val_1 = val_1 * val_4;
            val_2 = val_2 * val_4;
            val_4 = value.x - val_1;
            value.x = value.x + val_1;
            value.y = value.y + val_2;
            this.NorthEast = val_4;
            mem[1152921519931639336] = value.y - val_2;
            mem[1152921519931639344] = value.x;
            mem[1152921519931639352] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2dBounds FromCoordinates(Mapbox.Utils.Vector2d a, Mapbox.Utils.Vector2d b)
        {
            Mapbox.Utils.Vector2dBounds val_0;
            var val_1 = (b.x < 0) ? b.x : a.x;
            var val_2 = (b.x > a.x) ? b.x : a.x;
            var val_3 = (b.y < 0) ? b.y : a.y;
            var val_4 = (b.y > a.y) ? b.y : a.y;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Utils.Vector2dBounds World()
        {
            Mapbox.Utils.Vector2dBounds val_0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Extend(Mapbox.Utils.Vector2d point)
        {
            if(point.x < 0)
            {
                    this.NorthEast = point;
            }
            
            if(point.x > this.NorthEast)
            {
                    mem[1152921519931991344] = point.x;
            }
            
            if(point.y < 0)
            {
                    mem[1152921519931991336] = point.y;
            }
            
            if(point.y <= point.x)
            {
                    return;
            }
            
            mem[1152921519931991352] = point.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Extend(Mapbox.Utils.Vector2dBounds bounds)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEmpty()
        {
            if(this.NorthEast > D1)
            {
                    return true;
            }
            
            return (bool)(this.NorthEast > D1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] ToArray()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            mem2[0] = this.NorthEast.x;
            mem2[0] = mem[this.NorthEast + 4];
            mem2[0] = this.NorthEast.y;
            return (string)this.NorthEast;
        }
    
    }

}
