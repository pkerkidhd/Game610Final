using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if(GUI.Button(new Rect(Screen.height / 2 + 100, 150 ,150 ,50), "Start Game")) {
			Application.LoadLevel("Game");
		}

		if(GUI.Button(new Rect(Screen.height / 2 + 100, 200 ,150 ,50), "Exit Game")) {
			Application.Quit();
		}
	}
}
