using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour {
	public static List<Character> charList = new List<Character> ();      //list of available characters
	public static List<Mission> missionList = new List<Mission> ();      //list of available missions
	public static List<Resource> resourceList = new List<Resource> ();      //list of available missions
	public int dayCounter;

	void Awake(){

		//create a list of resouces
		Resource r1 = new Resource ("Gold", "Diplomacy", 100);

	
		//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character c1 = new Character (1, "Jorts Bear", Resources.Load("/Users/Craig/Documents/MaroFortuna/Assets/Textures/Captain Portrait.png") as Texture, 0, 1,
		                                 "A rogue cop who doesn't play by the rules... in jorts.");
		charList.Add (c1);

		//create and add all missions to this list and add resource to list when success
		Mission m1 = new Mission ("Car-tastrophe", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. " +
		                          "You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. " +
		                          "After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.",
		                          "After hours of struggling you and your crew fail to dislodge the car. Your muscles are weak and your spirits are low as from the dark depths of the abyss below you the car almost seems to smirk, " +
		                          "satisfied by your failure and content in its eternal aquatic home. The mystery of what resides inside that underwater car will haunt you for years to come. ", 2, "Military", "Espionage",
		                          "Science", "Diplomacy", 85, "Easy", "Military", r1, "None");
		missionList.Add (m1);

		//this allows it to persist
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		List<Character> playerVar;
		//can now access data of a character
		playerVar = charList;
		if (playerVar != null) {
			Debug.Log (playerVar[0].charName);
			Debug.Log (playerVar[0].profession);
		} else {
			Debug.Log ("not found");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
