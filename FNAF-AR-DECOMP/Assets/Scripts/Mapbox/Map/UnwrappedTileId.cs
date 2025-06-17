using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct UnwrappedTileId : IEquatable<Mapbox.Map.UnwrappedTileId>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Z;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int X;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Y;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId Canonical { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId North { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId East { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId South { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId West { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId NorthEast { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId SouthEast { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId NorthWest { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId SouthWest { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnwrappedTileId(int z, int x, int y)
        {
            mem[1152921519990740912] = z;
            mem[1152921519990740916] = x;
            mem[1152921519990740920] = y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId get_Canonical()
        {
            return new Mapbox.Map.CanonicalTileId();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(Mapbox.Map.UnwrappedTileId other)
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
            var val_1 = W8 << 16;
            val_1 = val_1 ^ ((W9) << 6);
            return (int)val_1 ^ ((W10) << 8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Equality(Mapbox.Map.UnwrappedTileId a, Mapbox.Map.UnwrappedTileId b)
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
        public static bool op_Inequality(Mapbox.Map.UnwrappedTileId a, Mapbox.Map.UnwrappedTileId b)
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
        public Mapbox.Map.UnwrappedTileId get_North()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1795071072, X = 268435459, Y = W8 - 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_East()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = X8, X = W9 + 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_South()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1794847072, X = 268435459, Y = W8 + 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_West()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = X8, X = W9 - 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_NorthEast()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1794623072, X = W8 + 1, Y = W9 - 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_SouthEast()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1794511072, X = W8 + 1, Y = W9 + 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_NorthWest()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1794399072, X = W8 - 1, Y = W9 - 1};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_SouthWest()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = -1794287072, X = W8 - 1, Y = W9 + 1};
        }
    
    }

}
