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
	public string difficulty;
	public string type;
	public Resource rewardRsc;
	public string rewardChar;

	public Mission(){
		//empty constructer
	}
	public Mission(string title, string description, string successDesc, string failDesc, int squadSize,
	               string majorAd, string minorAd, string majorDis, string minorDis, int successChance,
	               string difficulty, string type, Resource rewardRsc, string rewardChar){
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
	}
}