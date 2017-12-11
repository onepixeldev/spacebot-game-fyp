using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationManager : MonoBehaviour {


	public void LoadScene (string name)
	{
		Debug.Log ("Go to "+name);
		SceneManager.LoadScene (name);
	}
}
