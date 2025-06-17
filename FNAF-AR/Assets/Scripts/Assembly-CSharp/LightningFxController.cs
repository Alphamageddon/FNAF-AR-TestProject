using DigitalRuby.LightningBolt;
using DigitalRuby.ThunderAndLightning;
using UnityEngine;

public class LightningFxController : MonoBehaviour
{
	public bool spawn;

	private GameObject[] _lightnings;

	private LightningMeshSurfaceScript[] _lightningScripts;

	private DigitalRuby.LightningBolt.LightningBoltScript[] _lightningBoltScripts;

	private Camera _fxCamera;

	private bool _lastSpawnStatus;

	private SimpleTimer _timer;

	private void Start()
	{
		_lightningScripts = base.gameObject.GetComponentsInChildren<LightningMeshSurfaceScript>();
		_lightningBoltScripts = base.gameObject.GetComponentsInChildren<DigitalRuby.LightningBolt.LightningBoltScript>();
		_timer = new SimpleTimer();
		MasterDomain.GetDomain().SceneLookupTableAccess.GetCameraSceneLookupTableAsync(CameraSceneLookupTableReady);
	}

	public void SpawnForSeconds(float seconds)
	{
		spawn = true;
		_timer.StartTimer(seconds);
	}

	private void Update()
	{
		if (_timer.Started && _timer.IsExpired())
		{
			spawn = false;
			_timer.Reset();
		}
		UpdateLightningScripts();
		UpdateLightningBoltScripts();
		_lastSpawnStatus = spawn;
	}

	private void CameraSceneLookupTableReady(CameraSceneLookupTable table)
	{
		_fxCamera = table.CameraController.Camera;
		LightningMeshSurfaceScript[] lightningScripts = _lightningScripts;
		for (int i = 0; i < lightningScripts.Length; i++)
		{
			lightningScripts[i].Camera = _fxCamera;
		}
	}

	private void UpdateLightningScripts()
	{
		if (_lightningScripts != null && spawn != _lastSpawnStatus && _lightningScripts.Length >= 1)
		{
			LightningMeshSurfaceScript[] lightningScripts = _lightningScripts;
			for (int i = 0; i < lightningScripts.Length; i++)
			{
				lightningScripts[i].ManualMode = !spawn;
			}
		}
	}

	private void UpdateLightningBoltScripts()
	{
		if (_lightningBoltScripts != null && spawn != _lastSpawnStatus && _lightningBoltScripts.Length >= 1)
		{
			DigitalRuby.LightningBolt.LightningBoltScript[] lightningBoltScripts = _lightningBoltScripts;
			for (int i = 0; i < lightningBoltScripts.Length; i++)
			{
				lightningBoltScripts[i].ManualMode = !spawn;
			}
		}
	}
}
