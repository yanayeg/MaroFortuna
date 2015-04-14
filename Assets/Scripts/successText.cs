using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class successText : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
		string success = Data.pickedMission.successDesc;
		string fail = Data.pickedMission.failDesc;
		Mission activeMission = Data.pickedMission;
		Text guiText1 = GameObject.Find("SuccessText").GetComponent<Text>();
		if (activeMission.runMission (activeMission, Data.activeMissionChars))
			guiText1.text = success;
		else
			guiText1.text = fail;


		Text guiText2 = GameObject.Find ("SquadList").GetComponent<Text> ();
		string names = "";
		for (int i = 0; i<Data.activeMissionChars.Capacity; i++)
			names += Data.activeMissionChars [i].charName + "\n";

		guiText2.text = names;
		
		//at end of displaying messages clear activeMissionChars
		Data.activeMissionChars.Clear ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}