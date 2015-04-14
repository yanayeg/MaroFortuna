using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class successText : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Character rewardChar;
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
			//grant character if it's a third day and successful
			if (Data.dayCounter % 3 == 0 && Data.dayCounter != 0) 
				rewardChar = rewardNewChar();
			//if rewardChar isn't null fields alert the user about the new char
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

	Character rewardNewChar(){
		Character rewardChar = new Character();
		List<Character> charsToPickFrom = Data.charList;
		charsToPickFrom = ShuffleList(charsToPickFrom);
		bool exists = false;
		for (int i = 0; i < charsToPickFrom.Count ; i++) 
		{
			for(int j = 0; j < Data.currentChars.Count ; j++)
			{
				if (charsToPickFrom[i].name == Data.currentChars[j].name)
				{
					//already listed skip it
					exists = true;
					break;
				}
				else
				{
					exists = false;
				}
			}
			
			if(exists == false){
				Data.currentChars.Add(charsToPickFrom[i]);
				rewardChar = charsToPickFrom[i];
				return rewardChar;
			}
		}
		return rewardChar;
	}
	
	private List<Character> ShuffleList(List<Character> inputList)
	{
		List<Character> randomList = new List<Character>();
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
	
	// Update is called once per frame
	void Update () {
		
	}
}