using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddMonoBehavioursModifierType
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _typeString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Type _type;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type get_Type()
        {
            System.Type val_4;
            if((System.Type.op_Equality(left:  this._type, right:  0)) != false)
            {
                    this._type = System.Type.GetType(typeName:  this._typeString);
                return val_4;
            }
            
            val_4 = this._type;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddMonoBehavioursModifierType()
        {
        
        }
    
    }

}
