using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class MaterialControllerLinker : MonoBehaviour
{
	public AnimatronicMaterialController[] Controllers;

	private AnimatronicMaterialController source;

	private AnimatronicMaterialController[] destinations;

	private bool _controllerNotNull;

	private void Start()
	{
		if (Controllers != null)
		{
			source = Controllers[0];
			destinations = Controllers.Skip(1).ToArray();
			_controllerNotNull = true;
		}
	}

	private void Update()
	{
		if (!_controllerNotNull)
		{
			return;
		}
		AnimatronicMaterialController[] array = destinations;
		foreach (AnimatronicMaterialController animatronicMaterialController in array)
		{
			if (source.IsColorOverriden())
			{
				animatronicMaterialController.StartEyeColorOverride(source.GetEyeColorOverride());
			}
			else
			{
				animatronicMaterialController.EndEyeColorOverride();
			}
			animatronicMaterialController.eyeGlowMultiplier = source.eyeGlowMultiplier;
			animatronicMaterialController.SetEyeGlow(source.IsGlowing());
			animatronicMaterialController.wearAndTearPercentage = source.wearAndTearPercentage;
			animatronicMaterialController.offset = source.offset;
		}
	}
}
