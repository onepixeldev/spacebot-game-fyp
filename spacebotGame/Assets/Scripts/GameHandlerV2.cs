using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameHandlerV2 : MonoBehaviour {
	public Button btnMain;
	public Button btnProc;
	public Button btnProc2;
	public Sprite spForward;
	public Sprite spLeft;
	public Sprite spRight;
	public Sprite spLight;
	public Sprite spP1;
	public Sprite spP2;
	public Sprite spBlank;
	public Sprite spTarget;
	public Sprite spOn;
	public GameObject goRocket;
	public GameObject goPath;
	public List<GameObject> targets;
	public GameOverManagerV2 gameManagerV2;
	public SoundManager soundMgr;

	private string type; //either main or proc
	private List<int> mainSteps; // keeps track of the steps the user entered for main
	private List<int> procSteps; // keeps track of the steps the user entered for proc
	private List<int> procSteps2;
	private int maxMain = 2; // maximum steps allowed in main
	private int maxMain2 = 3;
	private int maxMain3 = 6;
	private int maxMain4 = 9;
	private int maxMain5 = 1;
	private int maxMain6 = 1;
	private int maxMain7 = 4;
	private int maxMain8 = 1;
	private int maxProc = 3; // maximum steps allowed in proc
	private int maxProc2 = 4;
	private int maxProc3 = 3;
	private int maxProc4 = 3;
	private int maxProc5 = 3;
	private int maxProc6 = 5;
	private int maxProc7 = 5;
	private int maxProc8 = 7;
	private int maxProc9 = 2;
	private Dictionary<int, Sprite> iconDict;
	public bool typeSelect = false;
	public bool alertTextUI = false;

	private int direction; //0-right, 1-down, 2-left, 3-up; maybe circular array in the future
	private Vector3 startPos;
	private Quaternion startRot;
	private bool test = true;

	// Use this for initialization
	void Start () {
		mainSteps = new List<int> ();
		procSteps = new List<int> ();
		procSteps2 = new List<int> ();
		direction = 0;

		// initializing the icon dictionary
		iconDict = new Dictionary<int, Sprite> () {
			{ 0, spForward },
			{ 1, spLeft },
			{ 2, spRight },
			{ 3, spLight },
			{ 4, spP1 },
			{ 5, spP2 }
		};

		// store start position and rotation
		startPos = goRocket.transform.position;
		startRot = goRocket.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < mainSteps.Count; i++) {
			Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
			img.sprite = iconDict[mainSteps[i]];
		}

		for (int i = 0; i < procSteps.Count; i++) {
			Image img = (Image)GameObject.Find (string.Format("img_p{0:00}", i+1)).GetComponent<Image>();
			img.sprite = iconDict[procSteps[i]];
		}

		for (int i = 0; i < procSteps2.Count; i++) {
			Image img = (Image)GameObject.Find (string.Format("img_p2{0:00}", i+1)).GetComponent<Image>();
			img.sprite = iconDict[procSteps2[i]];
		}
	}

	public void SetTypeToMain()
	{
		type = "main";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer ();
	}

	public void SetTypeToMain2()
	{
		type = "main2";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer ();
	}

	public void SetTypeToMain3()
	{
		type = "main3";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer ();
	}

	public void SetTypeToMain4()
	{
		type = "main4";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToMain5()
	{
		type = "main5";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToMain6()
	{
		type = "main6";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToMain7()
	{
		type = "main7";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToMain8()
	{
		type = "main8";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = color;
		btnProc.image.color = Color.white;
		btnProc2.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc()
	{
		type = "proc";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc2()
	{
		type = "proc2";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc3()
	{
		type = "proc3";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc4()
	{
		type = "proc4";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc5()
	{
		type = "proc5";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc6()
	{
		type = "proc6";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc7()
	{
		type = "proc7";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc8()
	{
		type = "proc8";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc.image.color = color;
		btnProc2.image.color = Color.white;

		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public void SetTypeToProc9()
	{
		type = "proc9";
		Color32 color = new Color32(71, 185, 237, 255);
		btnMain.image.color = Color.white;
		btnProc2.image.color = color;
		btnProc.image.color = Color.white;

		Debug.Log ("proc9");
		typeSelect = true;
		gameManagerV2.HandPointer();
	}

	public bool TypeSelected()
	{
		if (type != null)
			return true;
		else
			return false;
	}

	public void AddToStepList(int index)
	{
		if (!TypeSelected ()) {
			FindObjectOfType<SoundManager>().PlaySoundTypeNotSel();
			Debug.Log ("Type Not Selected Yet");
			gameManagerV2.HandPointer();
			return;
		}

		if (type == "main") {
			if (mainSteps.Count < maxMain)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main");
		}

		if (type == "main2") {
			if (mainSteps.Count < maxMain2)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main2");
		}

		if (type == "main3") {
			if (mainSteps.Count < maxMain3)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main3");
		}

		if (type == "main4") {
			if (mainSteps.Count < maxMain4)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main4");
		}

		if (type == "main5") {
			if (mainSteps.Count < maxMain5)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main5");
		}

		if (type == "main6") {
			if (mainSteps.Count < maxMain6)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main6");
		}

		if (type == "main7") {
			if (mainSteps.Count < maxMain7)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main7");
		}

		if (type == "main8") {
			if (mainSteps.Count < maxMain8)
				mainSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set Main8");
		}
	
		if (type == "proc") {
			if(procSteps.Count < maxProc)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func");
		}

		if (type == "proc2") {
			if(procSteps.Count < maxProc2)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 2");
		}

		if (type == "proc3") {
			if(procSteps.Count < maxProc3)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 3");
		}

		if (type == "proc4") {
			if(procSteps.Count < maxProc4)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 4");
		}

		if (type == "proc5") {
			if(procSteps.Count < maxProc5)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 5");
		}

		if (type == "proc6") {
			if(procSteps.Count < maxProc6)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 6");
		}

		if (type == "proc7") {
			if(procSteps.Count < maxProc7)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 7");
		}

		if (type == "proc8") {
			if(procSteps.Count < maxProc8)
				procSteps.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 8");
		}

		if (type == "proc9") {
			if(procSteps2.Count < maxProc9)
				procSteps2.Add (index);
			FindObjectOfType<SoundManager> ().PlaySoundSetCommand ();
			Debug.Log("set func 9");
		}
	}

	public void Reset()
	{
		// clear lists
		mainSteps.Clear();
		procSteps.Clear();
		procSteps2.Clear();

		// reset steps UI
		if (type == "main") {
			for (int i = 0; i < maxMain; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main2") {
			for (int i = 0; i < maxMain2; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main3") {
			for (int i = 0; i < maxMain3; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main4") {
			for (int i = 0; i < maxMain4; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main5") {
			for (int i = 0; i < maxMain5; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main6") {
			for (int i = 0; i < maxMain6; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main7") {
			for (int i = 0; i < maxMain7; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "main8") {
			for (int i = 0; i < maxMain8; i++) {
				Image img = (Image)GameObject.Find (string.Format("img_m{0:00}", i+1)).GetComponent<Image>();
				img.sprite = spBlank;
			}
		}

		if (type == "proc") {
			for (int i = 0; i < maxProc; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc2") {
			for (int i = 0; i < maxProc2; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc3") {
			for (int i = 0; i < maxProc3; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc4") {
			for (int i = 0; i < maxProc4; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc5") {
			for (int i = 0; i < maxProc5; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc6") {
			for (int i = 0; i < maxProc6; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc7") {
			for (int i = 0; i < maxProc7; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc8") {
			for (int i = 0; i < maxProc8; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}

		if (type == "proc9") {
			for (int i = 0; i < maxProc9; i++) {
				Image img = (Image)GameObject.Find (string.Format ("img_p2{0:00}", i + 1)).GetComponent<Image> ();
				img.sprite = spBlank;
			}
		}
		// reset rocket position and orientation
		goRocket.transform.position = startPos;
		goRocket.transform.rotation = startRot;
		direction = 0;

		// reset targets
		foreach (GameObject go in targets) {
			SpriteRenderer sr = go.GetComponent<SpriteRenderer> ();
			sr.sprite = spTarget;
		}

		// hide alert text ui
		alertTextUI = true;
		gameManagerV2.AlertTextUI ();
	}

	public void Run()
	{
		goRocket.transform.position = startPos;
		goRocket.transform.rotation = startRot;
		direction = 0;

		foreach (GameObject go in targets) {
			SpriteRenderer sr = go.GetComponent<SpriteRenderer> ();
			sr.sprite = spTarget;
		}
		StartCoroutine(ExecuteSteps());
	}
	/*	
	IEnumerator ExecuteSteps()
	{	
		foreach (int action in mainSteps) {
			if (action == 0) { // move forward
				MoveForward ();
				yield return new WaitForSeconds (0.7f);
			} else if (action == 1) { // turn left
				Debug.Log ("light2");
				Turn(true);
				yield return new WaitForSeconds (0.7f);
			} else if (action == 2) { // turn right
				Turn(false);
				yield return new WaitForSeconds (0.7f);
			} else if (action == 3) { // toggle light
				toggleLight();
				yield return new WaitForSeconds (0.7f);
			} else if (action == 4) { // run P1
				foreach (int act in procSteps) {
					if (act == 0) { // move forward
						MoveForward ();
						yield return new WaitForSeconds (0.7f);
					} else if (act == 1) { // turn left
						Turn (true);
						yield return new WaitForSeconds (0.7f);
					} else if (act == 2) { // turn right
						Turn (false);
						yield return new WaitForSeconds (0.7f);
					} else if (act == 3) { // toggle light
						toggleLight ();
						yield return new WaitForSeconds (0.7f);
					} else if (act == 4) { // run loop
						while (test == true) {
							foreach (int d in procSteps) {

								if (d == 0) { // move forward
									MoveForward ();
									yield return new WaitForSeconds (0.7f);
								} else if (d == 1) { // turn left
									Turn (true);
									yield return new WaitForSeconds (0.7f);
								} else if (d == 2) { // turn right
									Turn (false);
									yield return new WaitForSeconds (0.7f);
								} else if (d == 3) { // toggle light
									toggleLight ();
									yield return new WaitForSeconds (0.7f);
								} 

								if (Success ()) {
									gameManagerV2.EndGame();
									Debug.Log ("Level complete!");
									test = false;
								}
							}
						}
					}
				}
			}

		}
		// check success
		if (Success ()) {
			gameManagerV2.EndGame();
			Debug.Log ("Level complete!");
		} else {
			alertTextUI = false;
			gameManagerV2.AlertTextUI ();
			Debug.Log ("Didn't light all the targets!");
		}
	}
*/
	IEnumerator ExecuteSteps()
	{	
		foreach (int action in mainSteps) {
			if (action == 0) { // move forward
				MoveForward ();
				yield return new WaitForSeconds (0.7f);
			} else if (action == 1) { // turn left
				Debug.Log ("light2");
				Turn(true);
				yield return new WaitForSeconds (0.7f);
			} else if (action == 2) { // turn right
				Turn(false);
				yield return new WaitForSeconds (0.7f);
			} else if (action == 3) { // toggle light
				toggleLight();
				yield return new WaitForSeconds (0.7f);
			} else if (action == 4) { // run P1
				foreach (int act in procSteps) {
					if (act == 0) { // move forward
						MoveForward ();
						yield return new WaitForSeconds (0.7f);
					} else if (act == 1) { // turn left
						Turn (true);
						yield return new WaitForSeconds (0.7f);
					} else if (act == 2) { // turn right
						Turn (false);
						yield return new WaitForSeconds (0.7f);
					} else if (act == 3) { // toggle light
						toggleLight ();
						yield return new WaitForSeconds (0.7f);
					} else if (act == 4) { // run loop
						while (test == true) {
							foreach (int d in procSteps) {

								if (d == 0) { // move forward
									MoveForward ();
									yield return new WaitForSeconds (0.7f);
								} else if (d == 1) { // turn left
									Turn (true);
									yield return new WaitForSeconds (0.7f);
								} else if (d == 2) { // turn right
									Turn (false);
									yield return new WaitForSeconds (0.7f);
								} else if (d == 3) { // toggle light
									toggleLight ();
									yield return new WaitForSeconds (0.7f);
								} 
								else if (d == 5) { // toggle light
									foreach (int f2 in procSteps2) {

										if (f2 == 0) { // move forward
											MoveForward ();
											yield return new WaitForSeconds (0.7f);
										} else if (f2 == 1) { // turn left
											Turn (true);
											yield return new WaitForSeconds (0.7f);
										} else if (f2 == 2) { // turn right
											Turn (false);
											yield return new WaitForSeconds (0.7f);
										} else if (f2 == 3) { // toggle light
											toggleLight ();
											yield return new WaitForSeconds (0.7f);
										}
									}
								}

								if (Success ()) {
									gameManagerV2.EndGame();
									Debug.Log ("Level complete!");
									test = false;
								}
							}
						}
					}
				}
			}

			else if (action == 5) { // run P2
				foreach (int act2 in procSteps2) {
					if (act2 == 0) { // move forward
						MoveForward ();
						yield return new WaitForSeconds (0.7f);
					} else if (act2 == 1) { // turn left
						Turn (true);
						yield return new WaitForSeconds (0.7f);
					} else if (act2 == 2) { // turn right
						Turn (false);
						yield return new WaitForSeconds (0.7f);
					} else if (act2 == 3) { // toggle light
						toggleLight ();
						yield return new WaitForSeconds (0.7f);
					} else if (act2 == 4) { // run loop
						while (test == true) {
							foreach (int d2 in procSteps) {

								if (d2 == 0) { // move forward
									MoveForward ();
									yield return new WaitForSeconds (0.7f);
								} else if (d2 == 1) { // turn left
									Turn (true);
									yield return new WaitForSeconds (0.7f);
								} else if (d2 == 2) { // turn right
									Turn (false);
									yield return new WaitForSeconds (0.7f);
								} else if (d2 == 3) { // toggle light
									toggleLight ();
									yield return new WaitForSeconds (0.7f);
								} else if (d2 == 4) { // toggle light
									foreach (int f22 in procSteps2) {

										if (f22 == 0) { // move forward
											MoveForward ();
											yield return new WaitForSeconds (0.7f);
										} else if (f22 == 1) { // turn left
											Turn (true);
											yield return new WaitForSeconds (0.7f);
										} else if (f22 == 2) { // turn right
											Turn (false);
											yield return new WaitForSeconds (0.7f);
										} else if (f22 == 3) { // toggle light
											toggleLight ();
											yield return new WaitForSeconds (0.7f);
										}
									}
								}

								if (Success ()) {
									gameManagerV2.EndGame();
									Debug.Log ("Level complete!");
									test = false;
								}
							}
						}
					}
				}
			}

		}
		// check success
		if (Success ()) {
			gameManagerV2.EndGame();
			Debug.Log ("Level complete!");
		} else {
			alertTextUI = false;
			gameManagerV2.AlertTextUI ();
			Debug.Log ("Didn't light all the targets!");
		}
	}



	public void MoveForward()
	{
		Vector3 finalPosition = new Vector3(0,0,0);
		//int dir = direction.Peek();
		if (direction == 0) {
			finalPosition = new Vector3 (1.5f, 0, 0); //1.5f distance movement
		} else if (direction == 1) {
			finalPosition = new Vector3 (0, -1.5f, 0);
		} else if (direction == 2) {
			finalPosition = new Vector3 (-1.5f, 0, 0);
		} else if (direction == 3) {
			finalPosition = new Vector3 (0, 1.5f, 0);
		}
		if (PathExist (goRocket.transform.position + finalPosition)) {
			FindObjectOfType<SoundManager>().PlaySoundShipMovement();
			goRocket.transform.position += finalPosition;
		}
		else
			Debug.Log ("Path does not exist");
	}

	public void Turn(bool isLeft)
	{
		if (isLeft) {
			goRocket.transform.Rotate (0, 0, 90);
		} else {
			goRocket.transform.Rotate (0, 0, -90);
		}
		// turn sound
		FindObjectOfType<SoundManager>().PlaySoundTurnCommand();
		newDir (isLeft);
	}

	public void newDir(bool isLeft)
	{
		if (isLeft) {
			direction--;
			direction = direction < 0 ? 3 : direction;
		} else {
			direction++;
			direction = direction > 3 ? 0 : direction;
		}
	}

	public bool PathExist(Vector3 newPos)
	{
		// Check if new position has path
		RectTransform rt = (RectTransform)goPath.transform;
		float w = rt.rect.width;
		float h = rt.rect.height;

		// if overlap, path exist
		if (Physics2D.OverlapBox (newPos, new Vector2 (w, h), 0f) != null)
			return true;
		return false;
	}

	public void toggleLight()
	{
		// Check if current position is a target
		RectTransform rt = (RectTransform)goPath.transform;
		float w = rt.rect.width;
		float h = rt.rect.height;

		// if overlap, path exist
		Collider2D colliders = Physics2D.OverlapBox (goRocket.transform.position, new Vector2 (w, h), 0f); // assume all other checks are successful, there should always be 1 item in this array
		GameObject block = colliders.gameObject;
		SpriteRenderer sr = block.GetComponent<SpriteRenderer> ();

		// check if path is a target, then toggle blue/yellow
		if (sr.sprite == spTarget) {
			sr.sprite = spOn;
			FindObjectOfType<SoundManager>().PlaySoundTileLightOn();
			Debug.Log("tile on Sound");
		} else if (sr.sprite == spOn) {
			sr.sprite = spTarget;
			//soundMgr.PlaySoundWrongLight ();
		} else {
			soundMgr.PlaySoundWrongLight ();
		}
	}

	public bool Success()
	{
		// TODO: check if all target are lit
		foreach (GameObject go in targets) {
			SpriteRenderer sr = go.GetComponent<SpriteRenderer> ();
			if (sr.sprite == spTarget)
				return false;
		}
		return true;
	}
}
