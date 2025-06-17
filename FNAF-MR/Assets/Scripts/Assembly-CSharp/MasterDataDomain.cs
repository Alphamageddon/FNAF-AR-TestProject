public class MasterDataDomain
{
	private GetAccessToData _getAccessToData;

	public GetAccessToData GetAccessToData => _getAccessToData;

	private void set__getAccessToData(GetAccessToData value)
	{
		_getAccessToData = value;
	}

	public MasterDataDomain(EventExposer eventExposer)
	{
		_getAccessToData = new GetAccessToData();
	}

	public void Setup()
	{
	}

	public void Teardown()
	{
		_getAccessToData = null;
	}
}
