using UnityEngine;

public class ProfileTabHandler
{
	private ProfileTabData _profileTabData;

	private string _nameSaver;

	public ProfileTabHandler(ProfileTabData profileTabData)
	{
		_profileTabData = profileTabData;
		SetupDisplayNameInputField(_profileTabData.profileUIActions);
	}

	private void SetupDisplayNameInputField(ProfileUIActions profileUIActions)
	{
		_profileTabData.tMP_Input.onSelect.RemoveListener(OnSelect);
		_profileTabData.tMP_Input.onSelect.AddListener(OnSelect);
		_profileTabData.tMP_Input.onEndEdit.RemoveListener(OnEndEdit);
		_profileTabData.tMP_Input.onEndEdit.AddListener(OnEndEdit);
	}

	private void OnSelect(string arg0)
	{
		if (_profileTabData != null)
		{
			LoginDomain loginDomain = _profileTabData.masterDomain.TheGameDomain.loginDomain;
			_profileTabData.tMP_Input.text = loginDomain.playerProfile.displayName;
		}
	}

	private void OnSubmit(string newName)
	{
		LoginDomain loginDomain = _profileTabData.masterDomain.TheGameDomain.loginDomain;
		loginDomain.playerProfile.displayName = newName;
		loginDomain.changeDisplayNameRequester.ChangeDisplayName(newName);
	}

	private void OnEndEdit(string characters)
	{
		if (!string.IsNullOrEmpty(characters))
		{
			OnSubmit(characters);
		}
		_profileTabData.tMP_Input.text = string.Empty;
	}

	private void UpdateProfileStatsDisplay()
	{
		_ = _profileTabData.masterDomain.ItemDefinitionDomain.ItemDefinitions;
		_profileTabData.levelText.text = "0";
		_profileTabData.experienceText.text = "XP NOT ADDED";
		int serverCurrentStreak = _profileTabData.masterDomain.GameUIDomain.GameUIData.serverGameUIDataModel.GetServerCurrentStreak();
		_profileTabData.currentStreakNumText.text = FormatNumber.ToTopBarKMB(serverCurrentStreak);
		_profileTabData.bonusXPGroup.SetActive(value: false);
		decimal num = _profileTabData.masterDomain.GameUIDomain.GameUIData.serverGameUIDataModel.wins;
		_profileTabData.winsText.text = ((FormatNumber.ToTopBarKMB(num) == null) ? "" : FormatNumber.ToTopBarKMB(num));
		decimal num2 = _profileTabData.masterDomain.GameUIDomain.GameUIData.serverGameUIDataModel.encounters;
		_profileTabData.encountersText.text = ((FormatNumber.ToTopBarKMB(num2) == null) ? "" : FormatNumber.ToTopBarKMB(num2));
	}

	private void UpdateProfilePlayerNameDisplay()
	{
		if (_profileTabData != null)
		{
			_profileTabData.userNameText.text = _profileTabData.masterDomain.TheGameDomain.loginDomain.playerProfile.displayName;
		}
	}

	private void UpdateDisplay()
	{
		UpdateProfileStatsDisplay();
		UpdateProfilePlayerNameDisplay();
	}

	private void SetAvatarIconSprite(Sprite sprite)
	{
		_profileTabData.avatarImage.SetSprite(sprite);
	}

	public void RefreshAvatarIcon()
	{
		if (_profileTabData != null)
		{
			_profileTabData.avatarIconLookup.GetAvatarProfileSprite(_profileTabData.masterDomain.TheGameDomain.loginDomain.playerProfile.avatarId, SetAvatarIconSprite);
		}
	}

	public void Update()
	{
		UpdateDisplay();
	}
}
