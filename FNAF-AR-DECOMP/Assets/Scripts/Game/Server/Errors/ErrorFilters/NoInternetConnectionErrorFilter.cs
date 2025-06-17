using UnityEngine;

namespace Game.Server.Errors.ErrorFilters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NoInternetConnectionErrorFilter : BaseErrorFilter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NoInternetConnectionErrorFilter()
        {
            this = new System.Object();
            mem[1152921525221000496] = "{\"error\":\"No Internet Connection\"}";
            mem[1152921525221000504] = "NoInternetConnectionErrorFilter";
        }
    
    }

}
