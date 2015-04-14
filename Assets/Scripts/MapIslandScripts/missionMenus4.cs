using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class missionMenus4 : MonoBehaviour {
	public bool doWindow0 = false;
	List<Mission> missionListMenu = new List<Mission> (); 
	void DoWindow0(int windowID) {
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,200,20), missionListMenu[0].title)) {
			Data.pickedMission = Data.missionList[0];
			Debug.Log("the picked missions is: " + Data.pickedMission.title);
			Application.LoadLevel("MissionSelect");
		}
		if(GUI.Button(new Rect(20,80,200,20), missionListMenu[1].title)) {
			Data.pickedMission = Data.missionList[1];
			Debug.Log("the picked missions is: " + Data.pickedMission.title);
			Application.LoadLevel("MissionSelect");
		}
		if(GUI.Button(new Rect(20,120,200,20), missionListMenu[2].title)) {
			Data.pickedMission = Data.missionList[2];
			Debug.Log("the picked missions is: " + Data.pickedMission.title);
			Application.LoadLevel("MissionSelect");
		}
		//Close the panel.
		if (GUI.Button (new Rect (20,160,200,20), "Close")) {
			doWindow0 = false;
		}
		
	}
	
	// Use this for initialization
	void Start () {
		Data.missionList = ShuffleList (Data.missionList);
		for (int i = 0; i < 3; i++) {
			if (Data.missionList [i].isListed == false && Data.missionList [i].isDone == false) {
				Debug.Log("Listed" + Data.missionList[i].title);
				Data.missionList[i].isListed = true;
				missionListMenu.Add(Data.missionList [i]);
			}
		}
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
	
	private List<Mission> ShuffleList(List<Mission> inputList)
	{
		List<Mission> randomList = new List<Mission>();
		System.Random r = new System.Random();
		int randomIndex = 0;
		while (inputList.Count > 0)
		{
			randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
			randomList.Add(inputList[randomIndex]); //add it to the new, random list
			inputList.RemoveAt(randomIndex); //remove to avoid duplicates
		}
		
		return randomList; //return the new random list
	}
}