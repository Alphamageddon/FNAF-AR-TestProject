public interface IAssetLoader
{
	void Load(BundleCache bundleCache, string bundleName, string assetName);

	string GetBundleName();

	string GetAssetName();

	int GetNumRequests();
}
