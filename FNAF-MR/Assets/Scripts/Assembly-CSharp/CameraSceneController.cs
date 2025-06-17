using EZCameraShake;
using UnityEngine;

public class CameraSceneController : MonoBehaviour
{
	[SerializeField]
	private Canvas _effectsCanvas;

	[SerializeField]
	private CameraShaker _cameraShaker;

	[SerializeField]
	private CameraConfigurationController _configurationController;

	[SerializeField]
	private FlashlightFxController _flashlightFx;

	[SerializeField]
	private Camera _defaultCamera;

	[SerializeField]
	private Transform _cameraContainer;

	private Camera _currentCamera;

	public Camera Camera => _currentCamera;

	public CameraConfigurationController ConfigurationController => _configurationController;

	public void Awake()
	{
		_currentCamera = _defaultCamera;
	}

	public void InstallNewCamera(Camera newCamera)
	{
		if (!(_currentCamera == newCamera) && !(newCamera == null))
		{
			if (_currentCamera != _defaultCamera)
			{
				Object.Destroy(_currentCamera.gameObject);
			}
			_currentCamera = newCamera;
			newCamera.transform.SetParent(_cameraContainer, worldPositionStays: true);
			_currentCamera.gameObject.SetActive(value: true);
			if (_currentCamera != _defaultCamera)
			{
				_defaultCamera.gameObject.SetActive(value: false);
			}
			HookupCurrentCamera();
		}
	}

	public void UninstallCamera()
	{
		InstallNewCamera(_defaultCamera);
	}

	private void HookupCurrentCamera()
	{
		_effectsCanvas.worldCamera = _currentCamera;
		_flashlightFx.vignetteController = _currentCamera.GetComponent<VignetteController>();
	}
}
