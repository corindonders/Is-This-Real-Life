using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
	public void LoadScene(string sceneName) {
		SceneManager.LoadScene (sceneName);
	}
}