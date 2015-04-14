using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class squadSelect : MonoBehaviour {
	public bool doWindow0 = false;
	List<Mission> missionListMenu = new List<Mission> (); 
	int size = 0;
	void DoWindow0(int windowID) {
		//if (missionListMenu.Count < 3) {
		//	if (GUI.Button (new Rect (20, 160, 200, 20), "Close")) {
			//	doWindow0 = false;
			//}
		//} 

		int space = 40;
		for(int i = 0; i<Data.currentChars.Capacity; i++){
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, space, 200, 20), Data.currentChars[i].charName)) {
				Data.activeMissionChars.Add (Data.currentChars[i]);
				size++;
				//Application.LoadLevel ("ResultsScene");
			}
			space += 40;
		}
		if (GUI.Button (new Rect (20, space, 200, 20), "Close")) 
			doWindow0 = false;
	}
	
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(Data.pickedMission.squadSize == size)
			Application.LoadLevel ("ResultsScene");
		
	}
	
	void OnMouseDown (){
		doWindow0 = true;
	}
	
	
	void OnGUI() {
		//doWindow0 = GUI.Toggle(new Rect(10, 10, 100, 20), doWindow0, "Window 0");
		if (doWindow0) {
			GUI.Window (0, new Rect (300, 100, 290, 200), DoWindow0, "Characters");
		}
		
	}

}