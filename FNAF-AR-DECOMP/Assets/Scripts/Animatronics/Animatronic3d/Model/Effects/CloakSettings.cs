using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Effects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CloakSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 CloakedRevealPlanePosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 DecloakedRevealPlanePosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DecloakTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShockWindowOpenTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldUpdateEveryTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldCloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldDecloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldShowEyes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShouldHideEyes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CloakSettings()
        {
        
        }
    
    }

}
