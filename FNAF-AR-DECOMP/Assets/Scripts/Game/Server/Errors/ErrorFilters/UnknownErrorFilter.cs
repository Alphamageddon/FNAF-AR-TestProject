using UnityEngine;

namespace Game.Server.Errors.ErrorFilters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnknownErrorFilter : BaseErrorFilter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnknownErrorFilter()
        {
            this = new System.Object();
            mem[1152921525221449456] = "Unknown Error";
            mem[1152921525221449464] = "UnknownErrorFilter";
        }
    
    }

}
