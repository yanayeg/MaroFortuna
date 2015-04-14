using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public string profession;    
	public string charName;     
	public Sprite sprite;
	public double experience; //Lvl 1: 0 - 500; Lvl 2: 501 - 1000; Lvl 3: 1001 - 1500
	public int status;        //0 = Dead, 1 = alive, 2 = injured
	public string description;
	public bool isPicked;

	public Character() {
		//empty constructor
	}

	public Character(string profession, string charName, Sprite sprite, double experience, int status, string description, bool isPicked) {
		this.profession = profession;
		this.charName = charName;
		this.sprite = sprite;
		this.experience = experience;
		this.status = status;
		this.description = description;
		this.isPicked = isPicked;
	}

	public void setStatus(int status){
		this.status = status;
	}

	public void addExperience(int expGain){
		this.experience += expGain;
	}

	public void setPicked(){
		if(this.isPicked == true)
			this.isPicked = false;
		else
			this.isPicked = true;
	}
}