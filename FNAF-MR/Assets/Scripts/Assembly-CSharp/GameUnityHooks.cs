using System;
using UnityEngine;

[Serializable]
public class GameUnityHooks
{
	[SerializeField]
	private SceneLookupTableAccess _sceneLookupTableAccess;

	[SerializeField]
	private SkyboxSceneConfig _skyboxConfigs;

	[SerializeField]
	private Configs _configs;

	[SerializeField]
	private GameObject _afterTOSAccept;

	[SerializeField]
	private LocalLocalizationKVPs _localLocalizationKVPs;

	[SerializeField]
	private CameraFx _cameraFx;

	public Configs Configs => _configs;

	public CameraFx CameraFx => _cameraFx;

	public GameObject AfterTosAccept => _afterTOSAccept;

	public SceneLookupTableAccess SceneLookupTableAccess => _sceneLookupTableAccess;

	public SkyboxSceneConfig SkyboxConfigs => _skyboxConfigs;

	public LocalLocalizationKVPs LocalLocalizationKVPs => _localLocalizationKVPs;
}
