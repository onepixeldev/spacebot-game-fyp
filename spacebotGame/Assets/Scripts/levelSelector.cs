using UnityEngine;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour {

	public Button[] levelbuttons;
	public Button[] levelbuttons2;
	public Button[] levelbuttons3;

	public void Start(){
		int levelReached = PlayerPrefs.GetInt ("levelReached", 1); 
		for (int i = 0; i < levelbuttons.Length; i++) {
			if (i + 1 > levelReached)
			levelbuttons [i].interactable = false;
		}

		int levelReached2 = PlayerPrefs.GetInt ("levelReached2", 0); 
		for (int i = 0; i < levelbuttons2.Length; i++) {
			if (i + 1 > levelReached2)
				levelbuttons2 [i].interactable = false;
		}

		int levelReached3 = PlayerPrefs.GetInt ("levelReached3", 0); 
		for (int i = 0; i < levelbuttons3.Length; i++) {
			if (i + 1 > levelReached3)
				levelbuttons3 [i].interactable = false;
		}
	}
}
