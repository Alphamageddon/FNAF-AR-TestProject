using UnityEngine;

namespace Mapbox.Tokens
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public enum MapboxTokenStatus
    {
        // Fields
        TokenValid = 0
        ,TokenMalformed = 1
        ,TokenInvalid = 2
        ,TokenExpired = 3
        ,TokenRevoked = 4
        ,StatusNotYetSet = 5
        
    
    }

}
