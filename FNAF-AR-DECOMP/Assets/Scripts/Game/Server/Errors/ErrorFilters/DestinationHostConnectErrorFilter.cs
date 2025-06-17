using UnityEngine;

namespace Game.Server.Errors.ErrorFilters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DestinationHostConnectErrorFilter : BaseErrorFilter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DestinationHostConnectErrorFilter()
        {
            this = new System.Object();
            mem[1152921525220439328] = "Cannot connect to destination host";
            mem[1152921525220439336] = "DestinationHostConnectErrorFilter";
        }
    
    }

}
