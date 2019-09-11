using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateSceneBundles : MonoBehaviour
{
	[MenuItem("Scene Bundles/Build")]
	static void Build()
	{
		BuildAssetBundleOptions options = BuildAssetBundleOptions.None;
		BuildTarget target = BuildTarget.StandaloneWindows64;
		BuildPipeline.BuildAssetBundles("SceneBundles", options, target);
	}
}
