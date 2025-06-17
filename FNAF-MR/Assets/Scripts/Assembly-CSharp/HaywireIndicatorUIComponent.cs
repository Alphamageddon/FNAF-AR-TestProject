using System;
using UnityEngine;
using UnityEngine.UI;

public class HaywireIndicatorUIComponent : EncounterHUDComponent
{
	private Image indicatorImage;

	private HaywireIndicator _indicator;

	public HaywireIndicatorUIComponent(GameObject mainCanvas)
		: base(mainCanvas)
	{
	}

	public void Setup(HaywireIndicator indicator)
	{
		_indicator = indicator;
	}

	protected override void CacheAndPopulateComponents()
	{
		_components = new ComponentContainer();
		Type[] onlyCacheTypes = new Type[1] { typeof(Image) };
		_components.CacheComponents(_root, onlyCacheTypes);
		indicatorImage = _components.TryGetComponent<Image>("IndicatorImage");
	}

	public override void Update()
	{
		if (_root.activeSelf && indicatorImage != null)
		{
			indicatorImage.overrideSprite = _indicator.CurrentSprite();
		}
	}

	public override void UpdateVisibility(bool isMaskFullyOff)
	{
		_root.SetActive(_indicator.ShouldShow());
	}
}
