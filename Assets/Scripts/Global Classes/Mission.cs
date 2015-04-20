using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mission : MonoBehaviour{
	public string title;
	public string description;
	public string successDesc;
	public string failDesc;
	public int squadSize;
	public string majorAd;
	public string minorAd;
	public string majorDis;
	public string minorDis;
	public int successChance;
	public int difficulty;    //1 = easy, 2 = medium, 3 = hard
	public string type;
	public Resource rewardRsc;
	public string rewardChar;
	public bool isListed;
	public bool isDone;

	public Mission(){
		//empty constructer
	}
	public Mission(string title, string description, string successDesc, string failDesc, int squadSize,
	               string majorAd, string minorAd, string majorDis, string minorDis, int successChance,
	               int difficulty, string type, Resource rewardRsc, string rewardChar, bool isListed, bool isDone){
	            

		this.title = title;
		this.description = description;
		this.successDesc = successDesc;
		this.failDesc = failDesc;
		this.squadSize = squadSize;
		this.majorAd = majorAd;
		this.minorAd = minorAd;
		this.majorDis = majorDis;
		this.minorDis = minorDis;
		this.successDesc = successDesc;
		this.difficulty = difficulty;
		this.type = type;
		this.rewardRsc = rewardRsc;
		this.rewardChar = rewardChar;
		this.isListed = isListed;
		this.isDone = isDone;

	}
	public bool runMission(Mission mission, List<Character> charList){
		double chance = 50;

		System.Random r = new System.Random ();
		int  adjustment1 = r.Next (0, 1);
		int  adjustment2 = r.Next (1, 2);
		int adjustedDiff = mission.difficulty;


	//adjusting difficulty of missions based on daycounter

		if (Data.dayCounter <= 5) {
			switch (mission.difficulty) {
			case 1:
				break;
			case 2:
				adjustedDiff = mission.difficulty - adjustment1;
				break;
			case 3:
				adjustedDiff = mission.difficulty - adjustment2;
				break;
			}
		} 
		else if (Data.dayCounter <= 10) {
				switch (mission.difficulty) {
				case 1:
					break;
				case 2:
					break;
				case 3:
					adjustedDiff = mission.difficulty - adjustment1;
					break;
				}
		}

		for (int i = 0; i < mission.squadSize; i++) {    

			switch (adjustedDiff)
			{
			case 1:
				if (charList [i].experience > 1000)
					chance += 33 / mission.squadSize;
				else if (charList [i].experience > 500)
					chance += 17 / mission.squadSize;
				break;
			case 2:
				if (charList [i].experience < 501)
					chance -= 17 / mission.squadSize;
				if (charList [i].experience > 1000)
					chance += 17 / mission.squadSize;
				break;
			case 3:
				if (charList [i].experience < 501)
					chance -= 33 / mission.squadSize;
				else if (charList [i].experience < 1001)
					chance -= 17 / mission.squadSize;
				break;
			}

			if (charList [i].profession == mission.majorAd)
				chance += 33 / mission.squadSize;
			if (charList [i].profession == mission.minorAd)
				chance += 17 / mission.squadSize;
			if (charList [i].profession == mission.majorDis)
				chance -= 25 / mission.squadSize;
			if (charList [i].profession == mission.minorDis)
				chance -= 12 / mission.squadSize;


		}
		Debug.Log ("AdjustedDiff = " + adjustedDiff + "\nActual = " + mission.difficulty);
		Debug.Log (chance);
		if (chance >= 100)
			return true;
		else {
			int  randomNumber = r.Next (0, 100);
			if (randomNumber <= chance)
				return true;
			else
				return false;
		}


	}
}