using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FriendRemoveCell : MonoBehaviour, ICellInterface<FriendsRemoveCellData>
{
	[SerializeField]
	private Button selectButton;

	[SerializeField]
	private Button sendButton;

	[SerializeField]
	private TextMeshProUGUI playerName;

	[SerializeField]
	private Image avatar;

	[SerializeField]
	private HighlightToggle highlightToggle;

	[SerializeField]
	private GameObject sentPanel;

	private FriendsRemoveCellData _data;

	private void UpdateText()
	{
		if (!(playerName == null) && _data != null && _data.playerFriendsEntry != null && _data.playerFriendsEntry.displayName != null)
		{
			playerName.text = _data.playerFriendsEntry.displayName;
		}
	}

	public void RemoveFriend()
	{
		if (_data.callback != null)
		{
			_data.callback(_data.playerFriendsEntry.userId, this);
		}
	}

	public void SetData(FriendsRemoveCellData data)
	{
		_data = data;
		UpdateText();
	}

	public void SetSprite(Sprite sprite)
	{
		avatar.overrideSprite = sprite;
	}

	private void OnDisable()
	{
		highlightToggle.SetHighlight(value: false);
		sentPanel.SetActive(value: false);
	}
}
