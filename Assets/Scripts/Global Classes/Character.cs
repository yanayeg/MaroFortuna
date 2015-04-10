using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {
	//public static List<Character> charList = new List<Character> ();      //list of available characters
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



	void Awake(){

		/*//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character char1 = new Character (1, "Jorts Bear", Resources.Load("/Users/Craig/Documents/MaroFortuna/Assets/Textures/Captain Portrait.png") as Texture, 0, 1,
		                               "A rogue cop who doesn't play by the rules... in jorts.");
		charList.Add (char1);

		//this allows it to persist
		DontDestroyOnLoad (transform.gameObject);*/

	}
}