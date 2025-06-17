using UnityEngine;

public class DroppedObjectMaterialController : MonoBehaviour
{
	private DroppedObject _config;

	private MeshRenderer _renderer;

	private MaterialPropertyBlock _propertyBlock;

	private static readonly int RimlightBias;

	private bool _shouldUpdate;

	public void Setup(DroppedObject droppedObject)
	{
		if (!(droppedObject == null))
		{
			_config = droppedObject;
			_renderer = droppedObject.GetComponentInChildren<MeshRenderer>(includeInactive: true);
			if (!(_config == null) && !(_renderer == null))
			{
				_propertyBlock = new MaterialPropertyBlock();
				_shouldUpdate = true;
			}
		}
	}

	private void Update()
	{
		if (_shouldUpdate)
		{
			_propertyBlock.Clear();
			_propertyBlock.SetFloat(RimlightBias, _config.rimlightBias);
			if (!(_renderer == null))
			{
				_renderer.SetPropertyBlock(_propertyBlock, 0);
			}
		}
	}

	static DroppedObjectMaterialController()
	{
		RimlightBias = Shader.PropertyToID("_Rimlightbias");
	}
}
