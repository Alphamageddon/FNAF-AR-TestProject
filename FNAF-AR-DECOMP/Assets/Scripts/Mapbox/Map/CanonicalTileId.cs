using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct CanonicalTileId : IEquatable<Mapbox.Map.CanonicalTileId>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Z;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int X;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Y;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CanonicalTileId(int z, int x, int y)
        {
            mem[1152921519980808768] = z;
            mem[1152921519980808772] = x;
            mem[1152921519980808776] = y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal CanonicalTileId(Mapbox.Map.UnwrappedTileId unwrapped)
        {
            unwrapped.Y = unwrapped.Y & 4294967295;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d ToVector2d()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(Mapbox.Map.CanonicalTileId other)
        {
            if(W8 != (other.Z >> 32))
            {
                    return false;
            }
            
            if(W8 != other.Y)
            {
                    return false;
            }
            
            return (bool)(W8 == other.Z) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            return (int)W9 ^ W8 ^ W10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Equality(Mapbox.Map.CanonicalTileId a, Mapbox.Map.CanonicalTileId b)
        {
            if((a.Z >> 32) != (b.Z >> 32))
            {
                    return false;
            }
            
            if(a.Y != b.Y)
            {
                    return false;
            }
            
            return (bool)(a.Z == b.Z) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Inequality(Mapbox.Map.CanonicalTileId a, Mapbox.Map.CanonicalTileId b)
        {
            if((a.Z >> 32) != (b.Z >> 32))
            {
                    return true;
            }
            
            if(a.Y != b.Y)
            {
                    return true;
            }
            
            return (bool)(a.Z != b.Z) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            return true;
        }
    
    }

}
