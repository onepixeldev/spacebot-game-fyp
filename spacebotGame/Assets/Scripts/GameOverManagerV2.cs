using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManagerV2 : MonoBehaviour {

	public bool levelHasComplete = false;
	public GameObject levelCompleteUI;
	public GameObject handPointer;
	public GameObject handPointer2;
	public GameObject alertText;
	public GameHandlerV2 gameHandlerV2;

	public string nextLevel2 = "basic2";
	public int levelToUnlock2 = 1;

	public void Start() {
		levelCompleteUI.SetActive(false);
	}
		
	public void EndGame() {
		
		if (levelHasComplete == false) {
			levelHasComplete = true;
			levelCompleteUI.SetActive(true);
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
		handPointer2.SetActive (true);
		if (gameHandlerV2.typeSelect == true) {
			handPointer.SetActive (false);
			handPointer2.SetActive (false);
			//Debug.Log (gameHandlerV2.typeSelect);
		}
	}

	public void AlertTextUI() {
		alertText.SetActive (true);
		if (gameHandlerV2.alertTextUI == true) {
			alertText.SetActive (false);
			Debug.Log (gameHandlerV2.alertTextUI);
		}
	}
}
