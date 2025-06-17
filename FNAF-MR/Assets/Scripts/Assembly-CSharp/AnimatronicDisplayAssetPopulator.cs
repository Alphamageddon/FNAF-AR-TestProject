using System;
using SRF;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class AnimatronicDisplayAssetPopulator
{
	private const int ANIMATRONIC_DISPLAY_LAYER = 22;

	private const float ANIMATRONIC_CAMERA_DEPTH = 10f;

	private const string RIG_PREFAB_NAME = "AnimatronicUIRig";

	private const string RIG_ASSET_BUNDLE_NAME = "ui/mapentitycommon";

	private const string ANIMATRONIC_MOUNT_NAME = "AnimatronicMount";

	private const string RENDER_TEXTURE_PATH = "ContentAssets/DialogPrefabs/Map_UI_Animatronic";

	private Transform _rootTransform;

	private RectTransform _cameraReferenceRect;

	private AssetCache _assetCache;

	private bool _hasTornDown;

	private GameObject _rigPrefab;

	private GameObject _animatronicPrefab;

	private string _plushsuitBundleName;

	private string _plushsuitAssetName;

	private ComponentContainer _rigComponents;

	private Action completedPreviewLoadCallback;

	public void Setup(Transform rootTransform, RectTransform cameraReferenceRect, MapEntity entity, ItemDefinitionDomain itemDefinitionDomain, AssetCache assetCache, Action loadedCallback)
	{
		completedPreviewLoadCallback = loadedCallback;
		_rootTransform = rootTransform;
		_cameraReferenceRect = cameraReferenceRect;
		_assetCache = assetCache;
		if (!entity.SynchronizeableState.parts.ContainsKey("PlushSuit"))
		{
			Debug.LogError("AnimatronicDisplayAssetPopulator Setup - Could not find plushsuit on entity to populate 3d animatronic for entity " + entity.EntityId);
			Teardown();
		}
		else
		{
			RequestAssetsForPlushSuitId(itemDefinitionDomain, entity.SynchronizeableState.parts["PlushSuit"]);
		}
	}

	public void Teardown()
	{
		if (!_hasTornDown)
		{
			_hasTornDown = true;
			_assetCache.ReleaseAsset(_rigPrefab);
			_assetCache.ReleaseAsset(_animatronicPrefab);
			_rigPrefab = null;
			_animatronicPrefab = null;
			_cameraReferenceRect.GetComponentInParent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
			_rigComponents = null;
			_assetCache = null;
		}
	}

	private void RequestAssetsForPlushSuitId(ItemDefinitionDomain itemDefinitionDomain, string plushSuitId)
	{
		PlushSuitData plushSuitById = itemDefinitionDomain.ItemDefinitions.GetPlushSuitById(plushSuitId);
		if (plushSuitById == null)
		{
			Debug.LogError("BRO WHO TF IS " + plushSuitId);
		}
		_plushsuitBundleName = plushSuitById.AnimatronicAssetBundle;
		_plushsuitAssetName = plushSuitById.AnimatronicPrefab;
		_assetCache.LoadAsset<GameObject>(_plushsuitBundleName, _plushsuitAssetName, RequestAssetsForPlushSuitIdb__17_2, RequestAssetsForPlushSuitIdb__17_3);
		_assetCache.LoadAsset<GameObject>("ui/mapentitycommon", "AnimatronicUIRig", RequestAssetsForPlushSuitIdb__17_0, RequestAssetsForPlushSuitIdb__17_1);
	}

	private void OnAssetFailed(string role, string asset)
	{
		Debug.LogError("AnimatronicDisplayAssetPopulator OnAssetFailed - Failed to load " + role + " '" + asset + "'");
		Teardown();
	}

	private void OnAssetsLoaded()
	{
		if (!(_rigPrefab == null) && !(_animatronicPrefab == null))
		{
			ComponentContainer rigComponents = new ComponentContainer();
			_rigComponents = rigComponents;
			Type[] onlyCacheTypes = new Type[4]
			{
				typeof(Camera),
				typeof(Transform),
				typeof(Animator),
				typeof(Light)
			};
			_rigComponents.CacheComponents(UnityEngine.Object.Instantiate(_rigPrefab, _rootTransform, worldPositionStays: false), onlyCacheTypes);
			_cameraReferenceRect.GetComponentInParent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
			SetupAnimatronicCamera(_rigComponents);
			SetupAnimatronicInstance();
			completedPreviewLoadCallback();
		}
	}

	private Rect GetViewportRectFromUIElement(Canvas dialogCanvas, RectTransform element)
	{
		Camera worldCamera = dialogCanvas.worldCamera;
		Vector3[] array = new Vector3[4];
		element.GetWorldCorners(array);
		Vector3 vector = worldCamera.WorldToViewportPoint(array[0]);
		Vector3 vector2 = worldCamera.WorldToViewportPoint(array[2]);
		return new Rect(vector, vector2 - vector);
	}

	private void SetupAnimatronicCamera(ComponentContainer container)
	{
		if (container.TryGetComponent<Camera>("Camera", out var returnComponent))
		{
			returnComponent.depth = 10f;
			returnComponent.farClipPlane = 200f;
			PostProcessLayer postProcessLayer = returnComponent.gameObject.AddComponent<PostProcessLayer>();
			postProcessLayer.enabled = false;
			postProcessLayer.volumeLayer = 8388608;
			postProcessLayer.volumeTrigger = returnComponent.transform;
			postProcessLayer.Init(Resources.Load<GameObject>("PostProcessResources").GetComponent<PostProcessResourceFinder>().Resource);
			PostProcessVolume postProcessVolume = returnComponent.gameObject.AddComponent<PostProcessVolume>();
			postProcessVolume.enabled = false;
			postProcessVolume.isGlobal = true;
			postProcessVolume.weight = 1f;
			postProcessVolume.priority = 0f;
			postProcessVolume.profile = Resources.Load<PostProcessProfile>("MapEntityCommonProfile");
			postProcessVolume.enabled = true;
			postProcessLayer.enabled = true;
			RenderTexture renderTexture = Resources.Load<RenderTexture>("ContentAssets/DialogPrefabs/Map_UI_Animatronic");
			if (!(renderTexture == null))
			{
				returnComponent.targetTexture = renderTexture;
			}
		}
	}

	private void SetupAnimatronicInstance()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(_animatronicPrefab, _rigComponents.TryGetComponent<Transform>("AnimatronicMount"), worldPositionStays: false);
		AnimatronicModelConfig component = gameObject.GetComponent<AnimatronicModelConfig>();
		gameObject.SetLayerRecursive(23);
		component.Animator.SetInteger("AnimationMode", 1);
		component.Animator.SetTrigger("SwitchMode");
		component.Animator.SetTrigger("Idle");
		gameObject.transform.localPosition = new Vector3(0f, -0.9f, -2f);
	}

	private void RequestAssetsForPlushSuitIdb__17_0(GameObject prefab)
	{
		_rigPrefab = prefab;
		OnAssetsLoaded();
	}

	private void RequestAssetsForPlushSuitIdb__17_1()
	{
		OnAssetFailed("RigPrefab", "AnimatronicUIRig");
	}

	private void RequestAssetsForPlushSuitIdb__17_2(GameObject prefab)
	{
		_animatronicPrefab = prefab;
		OnAssetsLoaded();
	}

	private void RequestAssetsForPlushSuitIdb__17_3()
	{
		OnAssetFailed("AnimatronicPrefab", _plushsuitAssetName);
	}
}
