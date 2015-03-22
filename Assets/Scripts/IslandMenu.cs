using UnityEngine;
using System.Collections;

public class IslandMenu : MonoBehaviour {

	public bool clicked = false;
	void DoWindow(int windowID) {
		if(GUI.Button(new Rect(10, 30, 80, 20), "Click Me!")){
			clicked = false;
		}
		GUI.Button(new Rect(10, 60, 80, 20), "NOOOOO Me!");
		GUI.Button(new Rect(10, 90, 80, 20), "Click Me!");
		GUI.Button(new Rect(10, 120, 80, 20), "Click Me!");

	}

	
	void OnMouseDown (){
		clicked = true;
	}
	
	
	void OnGUI() {
		//doWindow0 = GUI.Toggle(new Rect(10, 10, 100, 20), doWindow0, "Window 0");
		if (clicked) {
			GUI.Window (0, new Rect (100, 50, 300, 300), DoWindow, "Basic Window");
		}
		
	}

	}

