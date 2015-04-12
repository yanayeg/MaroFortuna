using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HELP : MonoBehaviour {
	public bool doWindow0 = false;
	void DoWindow0(int windowID) {
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,200,20), Data.missionList[0].title)) {
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
			GUI.Window (0, new Rect (300, 100, 250, 200), DoWindow0, "Missions");
		}

	}
		
	



}
