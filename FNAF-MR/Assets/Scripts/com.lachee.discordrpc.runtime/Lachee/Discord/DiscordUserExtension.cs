using System.Collections;
using DiscordRPC;

namespace Lachee.Discord
{
	public static class DiscordUserExtension
	{
		public static User GetAvatar(this DiscordRPC.User user, DiscordAvatarSize size = DiscordAvatarSize.x128, User.AvatarDownloadCallback callback = null)
		{
			User user2 = new User(user);
			user2.GetAvatar(size, callback);
			return user2;
		}

		public static IEnumerator GetAvatarCoroutine(this DiscordRPC.User user, DiscordAvatarSize size = DiscordAvatarSize.x128, User.AvatarDownloadCallback callback = null)
		{
			return new User(user).GetDefaultAvatarCoroutine(size, callback);
		}

		public static IEnumerator GetDefaultAvatarCoroutine(this DiscordRPC.User user, DiscordAvatarSize size = DiscordAvatarSize.x128, User.AvatarDownloadCallback callback = null)
		{
			return new User(user).GetDefaultAvatarCoroutine(size, callback);
		}
	}
}
