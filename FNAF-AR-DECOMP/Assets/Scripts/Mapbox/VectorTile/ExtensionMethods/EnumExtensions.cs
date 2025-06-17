using UnityEngine;

namespace Mapbox.VectorTile.ExtensionMethods
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class EnumExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Description(System.Enum value)
        {
            var val_15;
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            var val_20;
            if(value != 0)
            {
                    val_15 = 0;
                val_16 = value.GetType();
                val_17 = value;
            }
            else
            {
                    val_15 = 0;
                val_16 = 0.GetType();
                val_17 = 0;
            }
            
            val_18 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_19 = val_16.GetField(name:  val_17);
            if(null != null)
            {
                    if(null == null)
            {
                    val_18 = 0;
            }
            
                if(value == 0)
            {
                    return (string)val_20;
            }
            
                val_18 = null;
                val_18 = 0;
                val_20 = 0;
                return (string)val_20;
            }
            
            val_20 = ???;
            val_18 = mem[mem[value] + 344 + 8];
            val_18 = mem[value] + 344 + 8;
            val_19 = ???;
            goto mem[value] + 344;
        }
    
    }

}
