using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClickButtonScript : MonoBehaviour {

	public void OnClick () {
		SceneManager.LoadScene ("Level1");
	}
}
