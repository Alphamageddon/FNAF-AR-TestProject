using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NodeEditorElementAttribute : Attribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NodeEditorElementAttribute(string s)
        {
            this.Name = s;
        }
    
    }

}
