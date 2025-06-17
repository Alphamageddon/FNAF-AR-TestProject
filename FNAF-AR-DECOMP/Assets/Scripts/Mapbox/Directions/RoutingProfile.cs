using UnityEngine;

namespace Mapbox.Directions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class RoutingProfile
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.RoutingProfile Driving;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.RoutingProfile Walking;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly Mapbox.Directions.RoutingProfile Cycling;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string profile;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private RoutingProfile(string profile)
        {
            this.profile = profile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)this.profile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static RoutingProfile()
        {
            .profile = "mapbox/driving/";
            Mapbox.Directions.RoutingProfile.Driving = new Mapbox.Directions.RoutingProfile();
            .profile = "mapbox/walking/";
            Mapbox.Directions.RoutingProfile.Walking = new Mapbox.Directions.RoutingProfile();
            .profile = "mapbox/cycling/";
            Mapbox.Directions.RoutingProfile.Cycling = new Mapbox.Directions.RoutingProfile();
        }
    
    }

}
