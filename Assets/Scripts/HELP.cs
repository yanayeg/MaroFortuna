using UnityEngine;
using System.Collections;

public class HELP : MonoBehaviour {

	public bool doWindow0 = false;
	void DoWindow0(int windowID) {
		GUI.Button(new Rect(10, 30, 80, 20), "Click Me!");
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
			GUI.Window (0, new Rect (110, 10, 200, 60), DoWindow0, "Basic Window");
		}
		
	}



}
