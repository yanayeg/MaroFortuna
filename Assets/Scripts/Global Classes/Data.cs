using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour {
	public static List<Character> charList = new List<Character> ();      //list of available characters
	public static List<Mission> missionList = new List<Mission> ();      //list of available missions
	public static List<Resource> resourceList = new List<Resource> ();      //list of available missions
	public static int dayCounter;
	public static Mission pickedMission;

	void Awake(){
		//--------------------------------------CHARACTER CREATION SECTION-------------------------------------------//
		//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character c;
		//MILITARY CHARACTERS
		c = new Character ("Military", "Sitting Bull", Resources.Load("/Portrait.png") as Texture, 0, 1,
		                   "Leader of the great tribes.");
		charList.Add (c);
		c = new Character ("Military", "Sun Tzu the Tiger", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                  "Wrote important military tactics in his novel, “The Art of Roar.");
		charList.Add(c);
		c = new Character ("Military", "Artemis the Wolf", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);
		c = new Character ("Military", "Zorro the Fox", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);
		//SCIENCE CHARACTERS
		c = new Character ("Science", "Mousie Curie", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Won the Swiss Prize in her studies of radiated cheese curds.");
		charList.Add (c);
		c = new Character ("Science", "Hathaway the Hare", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "This black hat hacker named Hathaway.");
		charList.Add (c);
		c = new Character ("Science", "Ram Descartes", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Mathematician and philisophist, most famous statement: If it fits, I sits.");
		charList.Add (c);
		c = new Character ("Science", "Olympia the Owl", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);
		//ESPIONAGE CHARACTERS
		c = new Character ("Espionage", "Margreet the Bat", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "A master of disguise and dancing.");
		charList.Add (c);
		c = new Character ("Espionage", "Pierre The Parrot", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Pierre the pickpocketing parrot.");
		charList.Add (c);
		c = new Character ("Espionage", "Roy the Boartender", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He hears a lot of gossip around the speakeasy.");
		charList.Add (c);
		c = new Character ("Espionage", "Lucia the Crow", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);
		//DIPLOMACY CHARACTERS
		c = new Character ("Diplomacy", "Espresso the Dog", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He just wants to talk things out over some good coffee.");
		charList.Add (c);
		c = new Character ("Diplomacy", "Octavia the Octopus", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He just wants to talk things out over some good coffee.");
		charList.Add (c);
		c = new Character ("Diplomacy", "Eisenhower the Elk", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);
		c = new Character ("Diplomacy", "Masako the Monkey", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ");
		charList.Add (c);

		//-----------------------------------RESOURCE CREATION SECTION--------------------------------------------//
		//create a list of resouces
		Resource r1 = new Resource ("Gold", "Diplomacy", 100);


		//-----------------------------------MISSION CREATION SECTION--------------------------------------------//
		//create and add all missions to this list and add resource to list when success
		Mission m1 = new Mission ("Car-tastrophe", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. " +
		                          "You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. " +
		                          "After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.",
		                          "After hours of struggling you and your crew fail to dislodge the car. Your muscles are weak and your spirits are low as from the dark depths of the abyss below you the car almost seems to smirk, " +
		                          "satisfied by your failure and content in its eternal aquatic home. The mystery of what resides inside that underwater car will haunt you for years to come. ", 2, "Military", "Espionage",
		                          "Science", "Diplomacy", 85, 1, "Military", r1, "None", false, false);
		missionList.Add (m1);
		m1 = new Mission ("test2", "Changed stuff here. As your ship approaches to investigate you discover the remnants of a submerged automobile. " +
		                          "You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. " +
		                          "After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.",
		                          "After hours of struggling you and your crew fail to dislodge the car. Your muscles are weak and your spirits are low as from the dark depths of the abyss below you the car almost seems to smirk, " +
		                          "satisfied by your failure and content in its eternal aquatic home. The mystery of what resides inside that underwater car will haunt you for years to come. ", 2, "Military", "Espionage",
		                          "Science", "Diplomacy", 85, 1, "Military", r1, "None", false, false);
		missionList.Add (m1);
		m1 = new Mission ("test3", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. " +
		                          "You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. " +
		                          "After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.",
		                          "After hours of struggling you and your crew fail to dislodge the car. Your muscles are weak and your spirits are low as from the dark depths of the abyss below you the car almost seems to smirk, " +
		                          "satisfied by your failure and content in its eternal aquatic home. The mystery of what resides inside that underwater car will haunt you for years to come. ", 2, "Military", "Espionage",
		                          "Science", "Diplomacy", 85, 1, "Military", r1, "None", false, false);
		missionList.Add (m1);
		
		


		//this allows it to persist (don't delete please)
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
