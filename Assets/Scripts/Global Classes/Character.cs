using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	int profession;    //1 = Espionage, 2 = Scientist, 3 = Diplomat, 4 = Military
	string charName;       //character name
	Texture sprite;
	double experience;
	int status;        //0 = Dead, 1 = alive, 2 = injured
	string description;

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

		//constructing one character, I am not sure how to assign the sprite image yet, this is my best guess.
		//What I think happens is when you add this script to the static script empty game object in our first scene (the on that we dont destroy)
		//it will give us fields with all these unassigned GameObject sprite variables where we will assign the images.
		//GameObject spriteChar1;
		Character char1 = new Character (1, "Jorts Bear", Resources.Load("/Users/Craig/Documents/MaroFortuna/Assets/Textures/Captain Portrait.png") as Texture, 0, 1,
		                                "A rogue cop who doesn't play by the rules... in jorts.");

		Debug.Log (char1.charName);



		Character[] availableCharcters = {char1};        //list of available characters
		Character[] squad = new Character[availableCharcters.Length]; //creates an empty squad list the size of our availableCharacter list


	}

}