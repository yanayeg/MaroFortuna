using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mission : MonoBehaviour{
	public static List<Mission> missionList = new List<Mission> ();      //list of available characters
	public string title;
	public string description;
	public string successDescription;

	public Mission(){
		//empty constructer
	}
	public Mission(string title, string description, string successDescription){
		this.title = title;
		this.description = description;
		this.successDescription = successDescription;
	}

	void Awake(){
		//create and add all missions to this list
		Mission m1 = new Mission ("Car-tastrophe", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.");
		missionList.Add (m1);

		DontDestroyOnLoad (transform.gameObject);
	}


}