using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class successText : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
		string success = Data.pickedMission.successDesc;
		string fail = Data.pickedMission.failDesc;
		bool win = false;
		Mission activeMission = Data.pickedMission;
		Text guiText1 = GameObject.Find("SuccessText").GetComponent<Text>();
		if (activeMission.runMission (activeMission, Data.activeMissionChars)) {
			win = true;
			Resource reward = Data.pickedMission.rewardRsc;
			Data.resourceList.Add (reward);
			for (int i = 0; i<Data.pickedMission.squadSize; i++)
				Data.activeMissionChars[i].addExperience(100);

			guiText1.text = "Success \n" + success + "\n\nRewards: \n" + Data.pickedMission.rewardRsc.rscName;
		}
		else
			guiText1.text = "Fail \n" + fail;


		Text guiText2 = GameObject.Find ("SquadList").GetComponent<Text> ();
		string names = "";
		for (int i = 0; i<Data.pickedMission.squadSize; i++) {
			if (win)
				names += Data.activeMissionChars [i].charName + " +100 XP \n";
			else
				names += Data.activeMissionChars [i].charName + " +0 XP \n";
		}

		guiText2.text = names;
		
		//at end of displaying messages clear activeMissionChars
		Data.activeMissionChars.Clear ();

		//mark mission as done
		foreach(Mission m in Data.missionList){
			if(m.title == Data.pickedMission.title)
				m.isDone = true;
		}

		//update day counter
		Data.dayCounter++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}