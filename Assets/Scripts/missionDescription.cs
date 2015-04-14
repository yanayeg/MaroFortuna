using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class missionDescription : MonoBehaviour {
	// Use this for initialization
	void Start () {
		//select the description of the mission picked
		string missionDesc = Data.pickedMission.description;
		Text guiText = GameObject.Find("Description").GetComponent<Text>();
		guiText.text = missionDesc;

		//at end of displaying messages clear isListed properties for missions 
		foreach(Mission m in Data.missionList){
			m.isListed = false;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
