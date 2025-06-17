public class FriendCodeModel
{
	private MasterDomain _masterDomain;

	private string _myCurrentFriendCode;

	public string MyCurrentFriendCode => _myCurrentFriendCode;

	public FriendCodeModel(MasterDomain masterDomain)
	{
		_masterDomain = masterDomain;
		masterDomain.eventExposer.add_PersonalFriendCodeUpdated(EventExposer_PersonalFriendCodeUpdated);
		_myCurrentFriendCode = "[No Friend Code]";
	}

	private void EventExposer_PersonalFriendCodeUpdated(string friendCode)
	{
		_myCurrentFriendCode = friendCode;
	}
}
