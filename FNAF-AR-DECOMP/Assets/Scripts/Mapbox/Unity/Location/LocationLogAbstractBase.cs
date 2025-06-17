using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class LocationLogAbstractBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string Delimiter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected readonly System.Globalization.CultureInfo _invariantCulture;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] HeaderNames { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_HeaderNames()
        {
            var val_10;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Array val_2 = System.Enum.GetValues(enumType:  val_1);
            int val_3 = val_2.Length;
            string[] val_4 = new string[0];
            val_10 = 0;
            goto label_6;
            label_20:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = System.Enum.Parse(enumType:  val_1, value:  val_2.GetValue(index:  0))});
            string val_8 = Mapbox.VectorTile.ExtensionMethods.EnumExtensions.Description(value:  new System.Enum());
            if(val_4 == null)
            {
                goto label_13;
            }
            
            if(val_8 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_8 == null)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            val_4[0] = val_8;
            val_10 = 1;
            label_6:
            if(val_10 < val_2.Length)
            {
                goto label_20;
            }
            
            return (System.String[])val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected LocationLogAbstractBase()
        {
            this.Delimiter = ";";
            this._invariantCulture = System.Globalization.CultureInfo.InvariantCulture;
        }
    
    }

}
