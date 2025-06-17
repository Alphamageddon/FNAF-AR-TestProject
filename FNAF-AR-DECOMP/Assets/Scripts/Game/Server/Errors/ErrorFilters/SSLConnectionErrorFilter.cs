using UnityEngine;

namespace Game.Server.Errors.ErrorFilters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SSLConnectionErrorFilter : BaseErrorFilter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SSLConnectionErrorFilter()
        {
            this = new System.Object();
            mem[1152921525221337248] = "Unable to complete SSL connection";
            mem[1152921525221337256] = "SSLConnectionErrorFilter";
        }
    
    }

}
