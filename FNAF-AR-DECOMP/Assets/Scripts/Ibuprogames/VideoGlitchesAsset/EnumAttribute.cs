using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class EnumAttribute : PropertyAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> enumNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Type type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EnumAttribute(System.Type enumType)
        {
            this.enumNames = new System.Collections.Generic.List<System.String>();
            this.type = enumType;
            this.enumNames.AddRange(collection:  System.Enum.GetNames(enumType:  enumType));
        }
    
    }

}
