using System;
using UnityEngine;

public class SceneLoadingInformation
{
	public string bundleName;

	public string assetName;

	public Action<AsyncOperation> successAction;

	public Action failureAction;

	public SceneLoadingInformation(string bundle, string asset, Action<AsyncOperation> success, Action failure)
	{
		bundleName = bundle;
		assetName = asset;
		successAction = success;
		failureAction = failure;
	}
}
