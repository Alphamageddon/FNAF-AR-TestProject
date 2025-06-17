using System;
using UnityEngine;

public class CreationRequest
{
	private bool _animatronicShadersComplete;

	private bool _animatronicGameObjectComplete;

	private bool _cpuSoundBankComplete;

	private bool _plushSuitSoundBankComplete;

	private bool _cancelled;

	public AnimatronicEntity Entity { get; }

	public AnimatronicConfigData ConfigData { get; }

	public Transform Parent { get; }

	public Animatronic3D Animatronic3D { get; set; }

	public bool IsComplete { get; set; }

	public event Action<CreationRequest> OnRequestComplete;

	public CreationRequest(AnimatronicEntity entity, Transform parent)
	{
		Entity = entity;
		ConfigData = entity.animatronicConfigData;
		Parent = parent;
		Animatronic3D = null;
		IsComplete = false;
		MasterDomain.GetDomain().eventExposer.add_GameDisplayChange(SceneChanged);
	}

	public CreationRequest(AnimatronicConfigData configData, Transform parent)
	{
		Entity = null;
		ConfigData = configData;
		Parent = parent;
		Animatronic3D = null;
		IsComplete = false;
		MasterDomain.GetDomain().eventExposer.add_GameDisplayChange(SceneChanged);
	}

	private void SceneChanged(GameDisplayData data)
	{
		Debug.LogError("Scene changed while instantiating animatronic");
		CancelRequest();
	}

	public void LoadAnimatronicShaders(AssetCache assetCache)
	{
		if (string.IsNullOrWhiteSpace(ConfigData.PlushSuitData.AnimatronicAssetBundle))
		{
			_animatronicShadersComplete = true;
			TryToNotifyComplete();
		}
		else
		{
			new ShaderCollectionInitializer(assetCache, ConfigData.PlushSuitData.AnimatronicAssetBundle, "PreWarmOnLoad", forceLoad: false, delegate
			{
				AnimatronicShaderLoadComplete();
			});
		}
	}

	public void AnimatronicShaderLoadComplete()
	{
		_animatronicShadersComplete = true;
		TryToNotifyComplete();
	}

	public void LoadCpuSoundBank(AudioPlayer audioPlayer)
	{
		if (string.IsNullOrWhiteSpace(ConfigData.CpuData.SoundBankName))
		{
			_cpuSoundBankComplete = true;
			TryToNotifyComplete();
			return;
		}
		SoundBankRequest soundBankRequest = new SoundBankRequest();
		soundBankRequest.SoundBankName = ConfigData.CpuData.SoundBankName;
		soundBankRequest.Success = delegate(string soundBankName)
		{
			CpuSoundBankLoadComplete(soundBankName, success: true);
		};
		soundBankRequest.Failure = delegate(string soundBankName)
		{
			CpuSoundBankLoadComplete(soundBankName, success: false);
		};
		Debug.Log("Sent CPU soundbank req " + ConfigData.CpuData.SoundBankName);
		audioPlayer.SoundBankLoader.RequestSoundBank(soundBankRequest);
	}

	public void CpuSoundBankLoadComplete(string soundBankName, bool success)
	{
		Debug.Log("CPU soundbank load success");
		_cpuSoundBankComplete = true;
		TryToNotifyComplete();
	}

	public void LoadPlushSuitSoundBank(AudioPlayer audioPlayer)
	{
		if (string.IsNullOrWhiteSpace(ConfigData.PlushSuitSoundbank))
		{
			_plushSuitSoundBankComplete = true;
			TryToNotifyComplete();
			return;
		}
		SoundBankRequest soundBankRequest = new SoundBankRequest();
		soundBankRequest.SoundBankName = ConfigData.PlushSuitSoundbank;
		soundBankRequest.Success = delegate(string soundBankName)
		{
			PlushSuitSoundBankLoadComplete(soundBankName, success: true);
		};
		soundBankRequest.Failure = delegate(string soundBankName)
		{
			PlushSuitSoundBankLoadComplete(soundBankName, success: false);
		};
		Debug.Log("Sent PlushSuit soundbank req " + ConfigData.PlushSuitSoundbank);
		audioPlayer.SoundBankLoader.RequestSoundBank(soundBankRequest);
	}

	public void PlushSuitSoundBankLoadComplete(string soundBankName, bool success)
	{
		Debug.Log("PlushSuit soundbank load success");
		_plushSuitSoundBankComplete = true;
		TryToNotifyComplete();
	}

	public void SetAnimatronicCreationSuccess(Animatronic3D animatronic3D)
	{
		_animatronicGameObjectComplete = true;
		Animatronic3D = animatronic3D;
		TryToNotifyComplete();
	}

	public void SetAnimatronicCreationFailure()
	{
		_animatronicGameObjectComplete = true;
		Animatronic3D = null;
		TryToNotifyComplete();
	}

	public void CancelRequest()
	{
		Debug.Log("Animatronic3D req cancelled");
		_cancelled = true;
	}

	public bool IsCancelled()
	{
		return _cancelled;
	}

	private void SoundBankLoadComplete(string soundBankName, bool success)
	{
		TryToNotifyComplete();
	}

	private void TryToNotifyComplete()
	{
		if (!_animatronicShadersComplete)
		{
			Debug.LogError("Shader Collection Warmup not Complete.");
			return;
		}
		if (!_animatronicGameObjectComplete)
		{
			Debug.LogError("Animatronic GameObject not Complete.");
			return;
		}
		if (!_cpuSoundBankComplete)
		{
			Debug.LogError("CPU SoundBank not Complete.");
			return;
		}
		if (!_plushSuitSoundBankComplete)
		{
			Debug.LogError("PlushSuit SoundBank not Complete.");
			return;
		}
		IsComplete = true;
		if (!_cancelled && Animatronic3D != null)
		{
			Animatronic3D.SetVisible(isVisible: true);
		}
		if (_cancelled)
		{
			MasterDomain.GetDomain().Animatronic3DDomain.ReleaseAnimatronic3D(Animatronic3D);
			Animatronic3D.Teardown();
			Animatronic3D = null;
		}
		if (this.OnRequestComplete != null)
		{
			this.OnRequestComplete(this);
		}
		this.OnRequestComplete = null;
		MasterDomain.GetDomain().eventExposer.remove_GameDisplayChange(SceneChanged);
	}
}
