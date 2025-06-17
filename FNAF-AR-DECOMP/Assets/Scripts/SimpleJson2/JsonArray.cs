using UnityEngine;

namespace SimpleJson2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class JsonArray : List<object>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonArray()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public JsonArray(int capacity)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            int val_2;
            if((SimpleJson2.SimpleJson2.SerializeObject(json:  this)) != null)
            {
                    return (string)val_2;
            }
            
            val_2 = System.String.alignConst;
            return (string)val_2;
        }
    
    }

}
