using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class DiscordTabHandler
{
	private DiscordTabData _discordTabData;

	public DiscordTabHandler(DiscordTabData discordTabData)
	{
		_discordTabData = discordTabData;
	}

	private void GetIcon()
	{
		CoroutineHelper.StartCoroutine(DownloadImage("https://cdn.discordapp.com/avatars/" + _discordTabData.controller.DiscordUserId + "/" + _discordTabData.controller.DiscordAvatarId + ".png"));
		_discordTabData.usernameText.text = _discordTabData.controller.DiscordUsername;
	}

	private IEnumerator DownloadImage(string MediaUrl)
	{
		UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
		yield return request.SendWebRequest();
		if (request.isNetworkError || request.isHttpError)
		{
			Debug.Log(request.error);
		}
		else
		{
			_discordTabData.profileRawImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
		}
	}

	public void PopulateDiscordTab()
	{
		GetIcon();
	}

	public void OnDestroy()
	{
	}
}
