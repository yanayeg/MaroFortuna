using UnityEngine;
using System.Collections;

public class HELP : MonoBehaviour {

	public bool doWindow0 = false;
	void DoWindow0(int windowID) {
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,200,20), Mission.title)) {
			Application.LoadLevel("MissionSelect");
		}
		

		//Close the panel.
		if (GUI.Button (new Rect (20,100,200,20), "Close")) {
			doWindow0 = false;
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown (){
		doWindow0 = true;
	}


	void OnGUI() {
		//doWindow0 = GUI.Toggle(new Rect(10, 10, 100, 20), doWindow0, "Window 0");
		if (doWindow0) {
			GUI.Window (0, new Rect (Screen.width/2, Screen.height/2, 250, 200), DoWindow0, "Basic Window");
		}

	}
		
	



}
