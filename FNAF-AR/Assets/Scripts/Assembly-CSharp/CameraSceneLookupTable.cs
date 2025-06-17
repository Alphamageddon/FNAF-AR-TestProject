using UnityEngine;

public class CameraSceneLookupTable : MonoBehaviour
{
	[SerializeField]
	private GameObject _displayParent;

	[SerializeField]
	private CameraSceneController _cameraSceneController;

	[SerializeField]
	private Transform _stableCameraTransform;

	[SerializeField]
	private ShockerFxController _shockerFxController;

	[SerializeField]
	private ModifiedGlitchShader _modifiedGlitchShader;

	[SerializeField]
	private HaywireFxController _haywireFxController;

	[SerializeField]
	private FlashlightFxController _flashlightFxController;

	[SerializeField]
	private MaskController _maskController;

	[SerializeField]
	private Camera _minireenaCamera;

	[SerializeField]
	private Transform _droppedObjectsVisualsParent;

	[SerializeField]
	private GameObject _audioListenerParent;

	[SerializeField]
	private DisruptionFxController _disruptionFxController;

	public GameObject DisplayParent => _displayParent;

	public CameraSceneController CameraController => _cameraSceneController;

	public Transform StableCameraTransform => _stableCameraTransform;

	public ShockerFxController ShockerFxController => _shockerFxController;

	public ModifiedGlitchShader ModifiedGlitchShader => _modifiedGlitchShader;

	public HaywireFxController HaywireFxController => _haywireFxController;

	public FlashlightFxController FlashlightFxController => _flashlightFxController;

	public MaskController MaskController => _maskController;

	public Camera MinireenaCamera => _minireenaCamera;

	public Transform DroppedObjectsVisualsParent => _droppedObjectsVisualsParent;

	public GameObject AudioListenerParent => _audioListenerParent;

	public DisruptionFxController DisruptionFxController => _disruptionFxController;
}
