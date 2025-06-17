using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SRFStringExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Fmt(string formatString, object[] args)
        {
            return System.String.Format(format:  formatString, args:  args);
        }
    
    }

}
