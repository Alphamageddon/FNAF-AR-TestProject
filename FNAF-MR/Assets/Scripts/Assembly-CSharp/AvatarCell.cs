using UnityEngine;
using UnityEngine.UI;

public class AvatarCell : MonoBehaviour, ICellInterface<AvatarCellDataPack>
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public AvatarCellDataPack data;

		internal void _003CSetData_003Eb__0()
		{
			data.SelectCell(data.id);
		}
	}

	[SerializeField]
	[Header("Hookups")]
	private Image avatarImage;

	[SerializeField]
	private Button button;

	public void SetData(AvatarCellDataPack data)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.data = data;
		button.onClick.RemoveAllListeners();
		button.onClick.AddListener(_003C_003Ec__DisplayClass2_._003CSetData_003Eb__0);
	}

	public void SetSprite(Sprite sprite)
	{
		avatarImage.sprite = sprite;
	}
}
