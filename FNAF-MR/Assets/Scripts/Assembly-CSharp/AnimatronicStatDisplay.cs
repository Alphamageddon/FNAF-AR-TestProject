using TMPro;
using UnityEngine.UI;

public class AnimatronicStatDisplay : IxItemCellDisplay<AnimatronicStatDisplayData>
{
	private TextMeshProUGUI _nameLabel;

	private Image _backdrop;

	private Image _filler;

	private MasterDomain _masterDomain;

	protected override void PopulateComponents()
	{
		_masterDomain = MasterDomain.GetDomain();
		_components.CacheComponents(_root, ComponentContainer.TextsImages);
		_backdrop = _components.TryGetComponent<Image>("StatBackingImage");
		_filler = _components.TryGetComponent<Image>("StatFillImage");
		_nameLabel = _components.TryGetComponent<TextMeshProUGUI>("StatText");
	}

	public override void UpdateData()
	{
		if (_dataItem.fillerSprite != null)
		{
			_filler.sprite = _dataItem.fillerSprite;
		}
		if (_dataItem.backdropSprite != null)
		{
			_backdrop.sprite = _dataItem.backdropSprite;
		}
	}

	public void SetStatValue(float value, float loadAmount, float minValue, float maxValue)
	{
		float fillAmount = 0f;
		if (maxValue != 0f)
		{
			fillAmount = (maxValue - minValue - (maxValue - value)) / (maxValue - minValue) * loadAmount;
		}
		_filler.fillAmount = fillAmount;
	}
}
