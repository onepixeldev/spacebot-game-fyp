using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

	//public GameHandler succ;
	public bool levelHasComplete = false;
	public GameObject levelCompleteUI;
	public GameObject handPointer;
	public GameObject alertText;
	public GameHandler gameHandler;

	public string nextLevel = "basic2";
	public int levelToUnlock = 2;
	public int levelToUnlock2 = 0;

	public void Start() {
		levelCompleteUI.SetActive(false);
	}
		
	public void EndGame() {
		
		if (levelHasComplete == false) {
			levelHasComplete = true;
			levelCompleteUI.SetActive(true);
			PlayerPrefs.SetInt ("levelReached", levelToUnlock);
			PlayerPrefs.SetInt ("levelReached2", levelToUnlock2);
			Debug.Log ("level complete");
		}
	}

	public void LoadScene (string name)
	{
		Debug.Log ("Go to "+name);
		SceneManager.LoadScene (name);
	}

	public void HandPointer() {
		handPointer.SetActive (true);
		if (gameHandler.typeSelect == true) {
			handPointer.SetActive (false);
			Debug.Log (gameHandler.typeSelect);
		}
	}

	public void AlertTextUI() {
		alertText.SetActive (true);
		if (gameHandler.alertTextUI == true) {
			alertText.SetActive (false);
			Debug.Log (gameHandler.alertTextUI);
		}
	}
}
