using UnityEngine;

namespace Animatronics.Animatronic3d.Model
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicModelConfig : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.ModelTransforms ModelTransforms;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.BoxCollider AABBCollider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicMaterialController AnimatronicMaterialController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningFxController ShockLightningEffect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EyeGlowLightController EyeGlowLightController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomFxController PhantomFxController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.Animation.AnimationEventListener AnimationEventListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Animator Animator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter AkAudioEmitter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.AdditionalOffsets AdditionalOffsets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.Effects.CloakSettings CloakSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.Animatronic3d.Model.MovementSettings MovementSettings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicModelConfig()
        {
        
        }
    
    }

}
