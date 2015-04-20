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
		guiText.text = Data.pickedMission.title + "\n" + missionDesc;

		//at end of displaying messages clear isListed properties for missions 
		foreach(Mission m in Data.missionList){
			m.isListed = false;
		}




		for (int i = 0; i < Data.charList.Count; i++) {
			GameObject.Find (Data.charList [i].charName).GetComponent<SpriteRenderer> ().color = Color.gray;
		}



	}
	
	// Update is called once per frame
	void Update () {
		string remaining = "";
		Text guiText = GameObject.Find("Remaining").GetComponent<Text>();
		guiText.text = "Characters Needed:\n               " + (Data.pickedMission.squadSize - Data.currentCrewSize);
	
	}
}
