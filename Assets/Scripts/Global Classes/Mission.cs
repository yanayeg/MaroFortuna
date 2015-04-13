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
<<<<<<< Updated upstream
	               string difficulty, string type, Resource rewardRsc, string rewardChar, bool isListed, bool isDone){
=======
<<<<<<< HEAD
	               int difficulty, string type, Resource rewardRsc, string rewardChar){
=======
	               string difficulty, string type, Resource rewardRsc, string rewardChar, bool isListed, bool isDone){
>>>>>>> origin/master
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
	}

	public bool runMission(Mission mission, Character[] charList){
		double chance = 50;
		/*
		if (mission.difficulty == 1)
			chance += 50;
		if (mission.difficulty == 2)
			chance += 35;
		if (mission.difficulty == 3)
			chance += 20;
		*/
		for (int i = 0; i < charList.Length; i++) {    //charList.Length should be the same as squadSize

			if (mission.difficulty == 1) {
				if (charList [i].experience > 1000)
					chance += 33 / mission.squadSize;
				else if (charList [i].experience > 500)
					chance += 17 / mission.squadSize;
			}

			if (mission.difficulty == 2) {
				if (charList [i].experience < 501)
					chance -= 17 / mission.squadSize;
				if (charList [i].experience > 1000)
					chance += 17 / mission.squadSize;
			}

			if (mission.difficulty == 3) {
				if (charList [i].experience < 501)
					chance -= 33 / mission.squadSize;
				else if (charList [i].experience < 1001)
					chance -= 17 / mission.squadSize;
			}
			Debug.Log (chance);
			if (charList [i].profession == mission.majorAd)
				chance += 33 / mission.squadSize;
			Debug.Log (chance);
			if (charList [i].profession == mission.minorAd)
				chance += 17 / mission.squadSize;
			Debug.Log (chance);
			if (charList [i].profession == mission.majorDis)
				chance -= 33 / mission.squadSize;
			Debug.Log (chance);
			if (charList [i].profession == mission.minorDis)
				chance -= 17 / mission.squadSize;
			Debug.Log (chance);



		}
		Debug.Log (chance);
		if (chance >= 100)
			return true;
		else {
			System.Random r = new System.Random ();
			int  randomNumber = r.Next (0, 100);
			if (randomNumber <= chance)
				return true;
			else
				return false;
		}


>>>>>>> Stashed changes
	}
}