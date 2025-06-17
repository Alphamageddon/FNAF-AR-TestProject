using UnityEngine;

public class AnimatronicModelConfig : MonoBehaviour
{
	[Header("Model Transforms")]
	public ModelTransforms ModelTransforms;

	[Header("Colliders")]
	public BoxCollider AABBCollider;

	[Header("Effect Connections")]
	public AnimatronicMaterialController AnimatronicMaterialController;

	public LightningFxController ShockLightningEffect;

	public EyeGlowLightController EyeGlowLightController;

	public PhantomFxController PhantomFxController;

	[Header("Component Connections")]
	public AnimationEventListener AnimationEventListener;

	public Animator Animator;

	public AnimatronicAudioManager AnimatronicAudioManager;

	public FieldOfView FieldOfView;

	[Header("Animatronic Settings")]
	public AdditionalOffsets AdditionalOffsets;

	public CloakSettings CloakSettings;

	public MovementSettings MovementSettings;
}
