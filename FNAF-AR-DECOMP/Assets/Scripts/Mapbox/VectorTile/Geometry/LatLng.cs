using UnityEngine;

namespace Mapbox.VectorTile.Geometry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct LatLng
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Lat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <Lng>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Lat { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Lng { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Lat()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Lat(double value)
        {
            mem[1152921519890881296] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_Lng()
        {
            return (double)D0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Lng(double value)
        {
            mem[1152921519891105304] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            return (string)new Mapbox.VectorTile.Geometry.LatLng();
        }
    
    }

}
