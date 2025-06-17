using System;
using System.Collections.Generic;
using System.Linq;
using SRF;
using SRF.Service;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(ISystemInformationService))]
	public class StandardSystemInformationService : ISystemInformationService
	{
		private readonly Dictionary<string, IList<InfoEntry>> _info = new Dictionary<string, IList<InfoEntry>>();

		public StandardSystemInformationService()
		{
			CreateDefaultSet();
		}

		public IEnumerable<string> GetCategories()
		{
			return _info.Keys;
		}

		public IList<InfoEntry> GetInfo(string category)
		{
			if (!_info.TryGetValue(category, out var value))
			{
				Debug.LogError("[SystemInformationService] Category not found: {0}".Fmt(category));
				return new InfoEntry[0];
			}
			return value;
		}

		public void Add(InfoEntry info, string category = "Default")
		{
			if (!_info.TryGetValue(category, out var value))
			{
				value = new List<InfoEntry>();
				_info.Add(category, value);
			}
			if (value.Any((InfoEntry p) => p.Title == info.Title))
			{
				throw new ArgumentException("An InfoEntry object with the same title already exists in that category.", "info");
			}
			value.Add(info);
		}

		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false)
		{
			Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>();
			foreach (KeyValuePair<string, IList<InfoEntry>> item in _info)
			{
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				foreach (InfoEntry item2 in item.Value)
				{
					if (!item2.IsPrivate || includePrivate)
					{
						dictionary2.Add(item2.Title, item2.Value);
					}
				}
				dictionary.Add(item.Key, dictionary2);
			}
			return dictionary;
		}

		private void CreateDefaultSet()
		{
			_info.Add("System", new InfoEntry[7]
			{
				InfoEntry.Create("Operating System", SystemInfo.operatingSystem),
				InfoEntry.Create("Device Name", SystemInfo.deviceName, isPrivate: true),
				InfoEntry.Create("Device Type", SystemInfo.deviceType),
				InfoEntry.Create("Device Model", SystemInfo.deviceModel),
				InfoEntry.Create("CPU Type", SystemInfo.processorType),
				InfoEntry.Create("CPU Count", SystemInfo.processorCount),
				InfoEntry.Create("System Memory", SRFileUtil.GetBytesReadable((long)SystemInfo.systemMemorySize * 1024L * 1024))
			});
			_info.Add("Unity", new InfoEntry[9]
			{
				InfoEntry.Create("Version", Application.unityVersion),
				InfoEntry.Create("Debug", Debug.isDebugBuild),
				InfoEntry.Create("Unity Pro", Application.HasProLicense()),
				InfoEntry.Create("Genuine", "{0} ({1})".Fmt(Application.genuine ? "Yes" : "No", Application.genuineCheckAvailable ? "Trusted" : "Untrusted")),
				InfoEntry.Create("System Language", Application.systemLanguage),
				InfoEntry.Create("Platform", Application.platform),
				InfoEntry.Create("IL2CPP", "No"),
				InfoEntry.Create("Application Version", Application.version),
				InfoEntry.Create("SRDebugger Version", "1.7.1")
			});
			_info.Add("Display", new InfoEntry[4]
			{
				InfoEntry.Create("Resolution", () => Screen.width + "x" + Screen.height),
				InfoEntry.Create("DPI", () => Screen.dpi),
				InfoEntry.Create("Fullscreen", () => Screen.fullScreen),
				InfoEntry.Create("Orientation", () => Screen.orientation)
			});
			_info.Add("Runtime", new InfoEntry[4]
			{
				InfoEntry.Create("Play Time", () => Time.unscaledTime),
				InfoEntry.Create("Level Play Time", () => Time.timeSinceLevelLoad),
				InfoEntry.Create("Current Level", delegate
				{
					Scene activeScene = SceneManager.GetActiveScene();
					return "{0} (Index: {1})".Fmt(activeScene.name, activeScene.buildIndex);
				}),
				InfoEntry.Create("Quality Level", () => QualitySettings.names[QualitySettings.GetQualityLevel()] + " (" + QualitySettings.GetQualityLevel() + ")")
			});
			TextAsset textAsset = (TextAsset)Resources.Load("UnityCloudBuildManifest.json");
			Dictionary<string, object> dictionary = ((textAsset != null) ? (Json.Deserialize(textAsset.text) as Dictionary<string, object>) : null);
			if (dictionary != null)
			{
				List<InfoEntry> list = new List<InfoEntry>(dictionary.Count);
				foreach (KeyValuePair<string, object> item in dictionary)
				{
					if (item.Value != null)
					{
						string value = item.Value.ToString();
						list.Add(InfoEntry.Create(GetCloudManifestPrettyName(item.Key), value));
					}
				}
				_info.Add("Build", list);
			}
			_info.Add("Features", new InfoEntry[4]
			{
				InfoEntry.Create("Location", SystemInfo.supportsLocationService),
				InfoEntry.Create("Accelerometer", SystemInfo.supportsAccelerometer),
				InfoEntry.Create("Gyroscope", SystemInfo.supportsGyroscope),
				InfoEntry.Create("Vibration", SystemInfo.supportsVibration)
			});
			_info.Add("Graphics", new InfoEntry[13]
			{
				InfoEntry.Create("Device Name", SystemInfo.graphicsDeviceName),
				InfoEntry.Create("Device Vendor", SystemInfo.graphicsDeviceVendor),
				InfoEntry.Create("Device Version", SystemInfo.graphicsDeviceVersion),
				InfoEntry.Create("Max Tex Size", SystemInfo.maxTextureSize),
				InfoEntry.Create("NPOT Support", SystemInfo.npotSupport),
				InfoEntry.Create("Render Textures", "{0} ({1})".Fmt(SystemInfo.supportsRenderTextures ? "Yes" : "No", SystemInfo.supportedRenderTargetCount)),
				InfoEntry.Create("3D Textures", SystemInfo.supports3DTextures),
				InfoEntry.Create("Compute Shaders", SystemInfo.supportsComputeShaders),
				InfoEntry.Create("Image Effects", SystemInfo.supportsImageEffects),
				InfoEntry.Create("Cubemaps", SystemInfo.supportsRenderToCubemap),
				InfoEntry.Create("Shadows", SystemInfo.supportsShadows),
				InfoEntry.Create("Stencil", SystemInfo.supportsStencil),
				InfoEntry.Create("Sparse Textures", SystemInfo.supportsSparseTextures)
			});
		}

		private static string GetCloudManifestPrettyName(string name)
		{
			return name switch
			{
				"scmCommitId" => "Commit", 
				"scmBranch" => "Branch", 
				"cloudBuildTargetName" => "Build Target", 
				"buildStartTime" => "Build Date", 
				_ => name.Substring(0, 1).ToUpper() + name.Substring(1), 
			};
		}
	}
}
