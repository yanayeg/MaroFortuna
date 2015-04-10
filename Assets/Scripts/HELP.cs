using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HELP : MonoBehaviour {
	public static List<Mission> missionList = new List<Mission> ();      //list of available missions
	public bool doWindow0 = false;

	void Awake(){
		//create and add all missions to this list
		Mission m1 = new Mission ("Car-tastrophe", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.");
		missionList.Add (m1);
		
		DontDestroyOnLoad (transform.gameObject);
	}


	void DoWindow0(int windowID) {
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,200,20), missionList[0].title)) {
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
