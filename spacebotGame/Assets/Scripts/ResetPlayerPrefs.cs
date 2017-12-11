using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
	public void ResetPrefs()
	{
		PlayerPrefs.DeleteAll();
		Debug.Log ("Reset Prefs..");	
	}
}