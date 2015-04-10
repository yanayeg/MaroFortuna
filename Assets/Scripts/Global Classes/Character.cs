﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	public int profession;    
	public string charName;     
	public Texture sprite;
	public double experience;
	public int status;        //0 = Dead, 1 = alive, 2 = injured
	public string description;

	public Character() {
		//empty constructor
	}

	public Character(int profession, string charName, Texture sprite, double experience, int status, string description) {
		this.profession = profession;
		this.charName = charName;
		this.sprite = sprite;
		this.experience = experience;
		this.status = status;
		this.description = description;
	}

	public void setStatus(int status){
		this.status = status;
	}

	public void addExperience(int expGain){
		this.experience += expGain;
	}
}