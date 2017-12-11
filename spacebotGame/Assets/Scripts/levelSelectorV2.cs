using UnityEngine;
using UnityEngine.UI;

public class levelSelectorV2 : MonoBehaviour {

	public Button[] levelbuttons;
	public Button[] levelbuttons2;

	public void Start(){
		int levelReached = PlayerPrefs.GetInt ("levelReached2", 0); 
		for (int i = 0; i < levelbuttons.Length; i++) {
			if (i + 1 > levelReached)
			levelbuttons [i].interactable = false;
		}
	}
}
