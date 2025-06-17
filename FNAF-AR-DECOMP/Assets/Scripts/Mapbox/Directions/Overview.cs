using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Overview
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.Overview Full;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.Overview Simplified;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.Overview False;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string overview;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Overview(string overview)
        {
            this.overview = overview;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.overview;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Overview()
        {
            .overview = "full";
            Mapbox.Directions.Overview.Full = new Mapbox.Directions.Overview();
            .overview = "simplified";
            Mapbox.Directions.Overview.Simplified = new Mapbox.Directions.Overview();
            .overview = "false";
            Mapbox.Directions.Overview.False = new Mapbox.Directions.Overview();
        }
    
    }

}
