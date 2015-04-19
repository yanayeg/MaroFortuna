using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class successText : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Character rewardChar = null;
		string success = Data.pickedMission.successDesc;
		string fail = Data.pickedMission.failDesc;
		Mission activeMission = Data.pickedMission;
		Text guiText1 = GameObject.Find("SuccessText").GetComponent<Text>();

		//guiText1.text = "Success \n" + success + "\n\nRewards: \n" + Data.pickedMission.rewardRsc.rscName;

		if (activeMission.runMission (activeMission, Data.activeMissionChars)) {
			Resource reward = Data.pickedMission.rewardRsc;
			Data.resourceList.Add (reward);
			for (int i = 0; i<Data.pickedMission.squadSize; i++)
				Data.activeMissionChars [i].addExperience (100);






			Text guiText3 = GameObject.Find ("MilReward").GetComponent<Text> ();
			Text guiText4 = GameObject.Find ("SciReward").GetComponent<Text> ();
			Text guiText5 = GameObject.Find ("EspReward").GetComponent<Text> ();
			Text guiText6 = GameObject.Find ("DipReward").GetComponent<Text> ();
			guiText3.text = "";
			guiText4.text = "";
			guiText5.text = "";
			guiText6.text = "";
			if(Data.pickedMission.rewardRsc.type == "Military")
				guiText3.text = "+" + Data.pickedMission.rewardRsc.quantity + " Military Resources";
			if(Data.pickedMission.rewardRsc.type == "Science")
				guiText4.text = "+" + Data.pickedMission.rewardRsc.quantity + " Science Resources";
			if(Data.pickedMission.rewardRsc.type == "Espionage")
				guiText5.text = "+" + Data.pickedMission.rewardRsc.quantity + " Espionage Resources";
			if(Data.pickedMission.rewardRsc.type == "Diplomacy")
				guiText6.text = "+" + Data.pickedMission.rewardRsc.quantity + " Diplomacy Resources";






			bool addChar = false;

			//grant character if it's a third day and successful
			//do rewardChar method
			//if rewardChar isn't null fields alert the user about the new char
			if (Data.dayCounter % 2 == 0 && Data.dayCounter != 0) {
				addChar = true;
				rewardChar = Data.charList[0];
				Data.charList.RemoveAt(0);
				Data.currentChars.Add (rewardChar);
			}
			if(addChar)
				guiText1.text = success + "\nRewards: " + Data.pickedMission.rewardRsc.rscName + "\nNew Character: " + rewardChar.charName;
			else
				guiText1.text = success + "\nRewards: " + Data.pickedMission.rewardRsc.rscName;
		

			Text guiText2 = GameObject.Find ("SquadList").GetComponent<Text> ();
			string names = "";
			for (int i = 0; i<Data.activeMissionChars.Count; i++) {
				names += Data.activeMissionChars [i].charName + " +100 XP \n";
				Data.activeMissionChars [i].setPicked ();
			}
			guiText2.text = names;

		
			//at end of displaying messages clear activeMissionChars
			Data.activeMissionChars.Clear ();
			Data.currentCrewSize = 0;

			//mark mission as done
			foreach (Mission m in Data.missionList) {
				if (m.title == Data.pickedMission.title)
					m.isDone = true;
			}

			//update day counter
			Data.dayCounter++;
		}

		else {
			Application.LoadLevel ("FailResults");
		}
	}

	void rewardNewChar(){
	}
	

	// Update is called once per frame
	void Update () {
		
	}
}