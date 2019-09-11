using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneFromBundle : MonoBehaviour
{
	public Text log;
	public string bundleName;
	public string sceneName;

	IEnumerator Start()
	{
		yield return new WaitForSeconds(5);

		string path = 
			Path.Combine(
				Path.Combine(
					Path.GetDirectoryName(Application.dataPath),
					"SceneBundles"),
				bundleName);

		log.text = string.Format("Loading scene bundle {0}", path);
		yield return new WaitForSeconds(1);

		AssetBundleCreateRequest request =
			AssetBundle.LoadFromFileAsync(path);

		yield return request;
		yield return SceneManager.LoadSceneAsync(sceneName);
	}
}
