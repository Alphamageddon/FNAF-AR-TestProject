public class AssetRefData
{
	public readonly object Asset;

	private int _refCount;

	public string BundleName { get; }

	public string AssetName { get; }

	public AssetRefData Parent { get; }

	public AssetRefData(string bundleName, string assetName, object asset, int refCount)
	{
		Asset = asset;
		BundleName = bundleName;
		AssetName = assetName;
		_refCount = refCount;
	}

	public AssetRefData(string bundleName, string assetName, object asset, AssetRefData parent)
	{
		Asset = asset;
		BundleName = bundleName;
		AssetName = assetName;
		Parent = parent;
	}

	public void IncrementRefCount()
	{
		_refCount++;
	}

	public void DecrementRefCount()
	{
		_refCount--;
	}

	public bool HasRefs()
	{
		return _refCount > 0;
	}
}
