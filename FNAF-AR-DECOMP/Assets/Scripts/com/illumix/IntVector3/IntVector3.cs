using UnityEngine;

namespace com.illumix.IntVector3
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntVector3 : IEquatable<com.illumix.IntVector3.IntVector3>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly int <Item1>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly int <Item2>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly int <Item3>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int maxValue = 500;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int squaredValue = 250000;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Item1 { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Item2 { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Item3 { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Item1()
        {
            return (int)this.<Item1>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Item2()
        {
            return (int)this.<Item2>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Item3()
        {
            return (int)this.<Item3>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntVector3(int item1, int item2, int item3)
        {
            this.<Item1>k__BackingField = item1;
            this.<Item2>k__BackingField = item2;
            this.<Item3>k__BackingField = item3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            int val_8 = this.<Item1>k__BackingField;
            int val_9 = this.<Item3>k__BackingField;
            int val_10 = this.<Item3>k__BackingField;
            int val_1 = val_8 * 274877907;
            int val_2 = val_9 * 274877907;
            val_1 = val_1 >> 37;
            int val_4 = val_10 * 274877907;
            val_1 = val_1 + (val_1 >> 63);
            val_2 = val_2 >> 37;
            val_2 = val_2 + (val_2 >> 63);
            val_4 = val_4 >> 37;
            val_4 = val_4 + (val_4 >> 63);
            val_8 = val_8 - (val_1 * 500);
            val_9 = val_9 - (val_2 * 500);
            val_8 = val_8 + (val_9 * 500);
            val_10 = val_10 - (val_4 * 500);
            return (int)val_8 + (val_10 * 250000);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Equals(com.illumix.IntVector3.IntVector3 other)
        {
            var val_2;
            if(((other.<Item1>k__BackingField) == (this.<Item1>k__BackingField)) && ((other.<Item3>k__BackingField) == (this.<Item3>k__BackingField)))
            {
                    var val_1 = ((other.<Item2>k__BackingField) == (this.<Item2>k__BackingField)) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            var val_2;
            if((11993091 == (this.<Item1>k__BackingField)) && (15026800 == (this.<Item3>k__BackingField)))
            {
                    var val_1 = (1 == (this.<Item2>k__BackingField)) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Equality(com.illumix.IntVector3.IntVector3 left, com.illumix.IntVector3.IntVector3 right)
        {
            if(left != null)
            {
                    return left.Equals(other:  right);
            }
            
            return left.Equals(other:  right);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool op_Inequality(com.illumix.IntVector3.IntVector3 left, com.illumix.IntVector3.IntVector3 right)
        {
            bool val_1 = left.Equals(other:  right);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
    
    }

}
