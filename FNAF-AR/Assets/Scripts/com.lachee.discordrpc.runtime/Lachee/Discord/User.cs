using System;
using System.Collections;
using System.IO;
using DiscordRPC;
using UnityEngine;
using UnityEngine.Networking;

namespace Lachee.Discord
{
	[Serializable]
	public sealed class User
	{
		[Flags]
		public enum CacheLevelFlag
		{
			None = 0,
			UserId = 1,
			Hash = 3,
			Size = 5
		}

		public delegate void AvatarDownloadCallback(User user, Texture2D avatar);

		public static string CacheDirectory;

		public static CacheLevelFlag CacheLevel;

		private DiscordRPC.User _user;

		public static DiscordAvatarFormat AvatarFormat { get; set; }

		public string username => _user?.Username;

		public string displayName => _user?.DisplayName;

		[Obsolete("Discord no longer uses discriminators.")]
		public int discriminator => (_user?.Discriminator).GetValueOrDefault();

		[Obsolete("Discord no longer uses discriminators.")]
		public string discrim => "#" + discriminator.ToString("D4");

		public ulong ID => (_user?.ID).GetValueOrDefault();

		public string avatarHash => _user?.Avatar;

		public Texture2D avatar { get; private set; }

		public DiscordAvatarSize cacheSize { get; private set; }

		public DiscordAvatarFormat cacheFormat { get; private set; }

		private string cdnEndpoint => _user?.CdnEndpoint;

		public User(DiscordRPC.User user)
		{
			_user = user;
		}

		public void GetAvatar(DiscordAvatarSize size = DiscordAvatarSize.x128, AvatarDownloadCallback callback = null)
		{
			DiscordManager.current.StartCoroutine(GetAvatarCoroutine(size, callback));
		}

		public IEnumerator GetAvatarCoroutine(DiscordAvatarSize size = DiscordAvatarSize.x128, AvatarDownloadCallback callback = null)
		{
			if (avatar != null)
			{
				callback?.Invoke(this, avatar);
				yield break;
			}
			if (string.IsNullOrEmpty(avatarHash))
			{
				yield return GetDefaultAvatarCoroutine(size, callback);
				yield break;
			}
			string path = null;
			if (CacheLevel != CacheLevelFlag.None)
			{
				SetupDefaultCacheDirectory();
				string text = "{0}";
				if ((CacheLevel & CacheLevelFlag.Hash) == CacheLevelFlag.Hash)
				{
					text += "-{1}";
				}
				if ((CacheLevel & CacheLevelFlag.Size) == CacheLevelFlag.Size)
				{
					text += "{2}";
				}
				else
				{
					size = DiscordAvatarSize.x512;
				}
				string path2 = string.Format(text + ".{3}", ID, avatarHash, size.ToString(), AvatarFormat.ToString().ToLowerInvariant());
				path = Path.Combine(CacheDirectory, path2);
				Debug.Log("<color=#FA0B0F>Cache:</color> " + path);
			}
			Texture2D avatarTexture = new Texture2D((int)size, (int)size, TextureFormat.RGBA32, mipChain: false);
			if (CacheLevel != CacheLevelFlag.None && File.Exists(path))
			{
				byte[] data = File.ReadAllBytes(path);
				avatarTexture.LoadImage(data);
			}
			else
			{
				using UnityWebRequest req = UnityWebRequestTexture.GetTexture(GetAvatarURL(AvatarFormat, size));
				yield return req.SendWebRequest();
				if (req.result == UnityWebRequest.Result.ConnectionError || req.result == UnityWebRequest.Result.ProtocolError)
				{
					Debug.LogError("Failed to download user avatar: " + req.error);
				}
				else
				{
					avatarTexture = DownloadHandlerTexture.GetContent(req);
				}
			}
			if (avatarTexture != null)
			{
				CacheAvatarTexture(avatarTexture, path);
				avatar = avatarTexture;
				cacheFormat = AvatarFormat;
				cacheSize = size;
				callback?.Invoke(this, avatarTexture);
			}
		}

		private void CacheAvatarTexture(Texture2D texture, string path)
		{
			if (CacheLevel != CacheLevelFlag.None)
			{
				if (!Directory.Exists(CacheDirectory))
				{
					Directory.CreateDirectory(CacheDirectory);
				}
				DiscordAvatarFormat avatarFormat = AvatarFormat;
				byte[] bytes = ((avatarFormat != DiscordAvatarFormat.PNG && avatarFormat == DiscordAvatarFormat.JPEG) ? texture.EncodeToJPG() : texture.EncodeToPNG());
				File.WriteAllBytes(path, bytes);
			}
		}

		public IEnumerator GetDefaultAvatarCoroutine(DiscordAvatarSize size = DiscordAvatarSize.x128, AvatarDownloadCallback callback = null)
		{
			string path = null;
			int num = (int)((ID >> 22) % 6);
			if (discriminator > 0)
			{
				num = discriminator % 5;
			}
			if (CacheLevel != CacheLevelFlag.None)
			{
				SetupDefaultCacheDirectory();
				bool flag = (CacheLevel & CacheLevelFlag.Size) == CacheLevelFlag.Size;
				if (!flag)
				{
					size = DiscordAvatarSize.x512;
				}
				string path2 = string.Format("default-{0}{1}.png", num, flag ? size.ToString() : "");
				path = Path.Combine(CacheDirectory, path2);
			}
			Texture2D avatarTexture = new Texture2D((int)size, (int)size, TextureFormat.RGBA32, mipChain: false);
			if (CacheLevel != CacheLevelFlag.None && File.Exists(path))
			{
				byte[] data = File.ReadAllBytes(path);
				avatarTexture.LoadImage(data);
			}
			else
			{
				string uri = $"https://{cdnEndpoint}/embed/avatars/{num}.png?size={(int)size}";
				using (UnityWebRequest req = UnityWebRequestTexture.GetTexture(uri))
				{
					yield return req.SendWebRequest();
					if (req.result == UnityWebRequest.Result.ConnectionError || req.result == UnityWebRequest.Result.ProtocolError)
					{
						Debug.LogError("Failed to download default avatar: " + req.error);
					}
					else
					{
						avatarTexture = DownloadHandlerTexture.GetContent(req);
					}
				}
				if (CacheLevel != CacheLevelFlag.None)
				{
					if (!Directory.Exists(CacheDirectory))
					{
						Directory.CreateDirectory(CacheDirectory);
					}
					byte[] bytes = avatarTexture.EncodeToPNG();
					File.WriteAllBytes(path, bytes);
				}
			}
			avatar = avatarTexture;
			cacheFormat = DiscordAvatarFormat.PNG;
			cacheSize = size;
			callback?.Invoke(this, avatar);
		}

		private static void SetupDefaultCacheDirectory()
		{
			if (CacheDirectory == null)
			{
				CacheDirectory = Application.dataPath + "/Discord Rpc/Cache";
			}
		}

		private string GetAvatarURL(DiscordAvatarFormat format, DiscordAvatarSize size)
		{
			return _user.GetAvatarURL((format != DiscordAvatarFormat.PNG) ? DiscordRPC.User.AvatarFormat.JPEG : DiscordRPC.User.AvatarFormat.PNG, (DiscordRPC.User.AvatarSize)size);
		}

		public override string ToString()
		{
			if (_user == null)
			{
				return "N/A";
			}
			return _user.ToString();
		}

		public static implicit operator User(DiscordRPC.User user)
		{
			return new User(user);
		}

		public static implicit operator DiscordRPC.User(User user)
		{
			return user._user;
		}

		public override int GetHashCode()
		{
			return ID.GetHashCode() ^ 7;
		}

		public override bool Equals(object obj)
		{
			if (obj is User)
			{
				return ID == ((User)obj).ID;
			}
			return false;
		}
	}
}
