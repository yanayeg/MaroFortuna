using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour {
	public static List<Character> charList = new List<Character> ();      //list of available characters
	public static List<Character> currentChars = new List<Character> ();  //active character list
	public static List<Mission> missionList = new List<Mission> ();      //list of available missions
	public static List<Resource> resourceList = new List<Resource> ();      //list of available missions
	public static int dayCounter;
	public static Mission pickedMission;
	public static List<Character> activeMissionChars = new List<Character> ();   //list for characters sent on a mission


	void Awake(){
		//--------------------------------------CHARACTER CREATION SECTION-------------------------------------------//
		//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character c;
		//MILITARY CHARACTERS
		c = new Character ("Military", "Sitting Bull", Resources.Load("/Portrait.png") as Texture, 0, 1,
		                   "Leader of the great tribes.", false);
		charList.Add (c);
		currentChars.Add (c);
		c = new Character ("Military", "Sun Tzu the Tiger", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                  "Wrote important military tactics in his novel, “The Art of Roar.", false);
		charList.Add(c);
		c = new Character ("Military", "Artemis the Wolf", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);
		c = new Character ("Military", "Zorro the Fox", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);
		//SCIENCE CHARACTERS
		c = new Character ("Science", "Mousie Curie", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Won the Swiss Prize in her studies of radiated cheese curds.", false);
		charList.Add (c);
		currentChars.Add (c);
		c = new Character ("Science", "Hathaway the Hare", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "This black hat hacker named Hathaway.", false);
		charList.Add (c);
		c = new Character ("Science", "Ram Descartes", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Mathematician and philisophist, most famous statement: If it fits, I sits.", false);
		charList.Add (c);
		c = new Character ("Science", "Olympia the Owl", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);
		//ESPIONAGE CHARACTERS
		c = new Character ("Espionage", "Margreet the Bat", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "A master of disguise and dancing.", false);
		charList.Add (c);
		currentChars.Add (c);
		c = new Character ("Espionage", "Pierre The Parrot", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "Pierre the pickpocketing parrot.", false);
		charList.Add (c);
		c = new Character ("Espionage", "Roy the Boartender", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He hears a lot of gossip around the speakeasy.", false);
		charList.Add (c);
		c = new Character ("Espionage", "Lucia the Crow", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);
		//DIPLOMACY CHARACTERS
		c = new Character ("Diplomacy", "Espresso the Dog", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He just wants to talk things out over some good coffee.", false);
		charList.Add (c);
		currentChars.Add (c);
		c = new Character ("Diplomacy", "Octavia the Octopus", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   "He just wants to talk things out over some good coffee.", false);
		charList.Add (c);
		c = new Character ("Diplomacy", "Eisenhower the Elk", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);
		c = new Character ("Diplomacy", "Masako the Monkey", Resources.Load ("/Portrait.png") as Texture, 0, 1,
		                   " ", false);
		charList.Add (c);

		//-----------------------------------RESOURCE CREATION SECTION--------------------------------------------//
		//create a list of resouces

		
		Resource m1 = new Resource ("Raw Materials", "Military", 100);
		Resource m2 = new Resource ("Metal", "Military", 100);
		Resource m3 = new Resource ("2 Ships", "Military", 500);

		Resource s1 = new Resource ("Alien Technology", "Science", 100);
		Resource s2 = new Resource ("Potions", "Science", 100);
		Resource s3 = new Resource ("Chemical Knowledge", "Science", 100);
		Resource s4 = new Resource ("Rock Samples", "Science", 100);

		Resource e1 = new Resource ("Cold hard cash", "Espionage", 100);
		Resource e2 = new Resource ("Fishing Secrets", "Espionage", 100);
		Resource e3 = new Resource ("Miniture Mama Money", "Espionage", 100);

		Resource d1 = new Resource ("Flock of flavorful fish", "Diplomacy", 100);
		Resource d2 = new Resource ("Gold", "Diplomacy", 100);
		Resource d3 = new Resource ("Favor of the locals", "Diplomacy", 100);


		//-----------------------------------MISSION CREATION SECTION--------------------------------------------//
		//create and add all missions to this list and add resource to list when success

		/* public Mission(string title, string description, string successDesc, string failDesc, int squadSize,
	               string majorAd, string minorAd, string majorDis, string minorDis, int successChance,
	               int difficulty, string type, Resource rewardRsc, string rewardChar, bool isListed, bool isDone */

		Mission m = new Mission ("Car-tastrophe", "You see an opaque object underneath the nearby water. As your ship approaches to investigate you discover the remnants of a submerged automobile. " +
		                          "You send some crew members to try and retrieve the car to search it for supplies.", "Your crew members take advantage of their skills to successfully raise the car from the water. " +
		                          "After shuffling the spooky skeleton of the unfortunate past passenger out of the seat you find a small stash of supplies in the glove box! Nice one champ.",
		                          "After hours of struggling you and your crew fail to dislodge the car. Your muscles are weak and your spirits are low as from the dark depths of the abyss below you the car almost seems to smirk, " +
		                          "satisfied by your failure and content in its eternal aquatic home. The mystery of what resides inside that underwater car will haunt you for years to come. ", 2, "Military", "Espionage",
		                          "Science", "Diplomacy", 85, 1, "Military", m1, "None", false, false);
		missionList.Add (m);
		m = new Mission ("You Got to be Squidding Me", "You come across a ship stranded in shallow water. It has a faint but distinct signal of a SOS beacon. Your co-captain suggests planning a rescue mission",
		                  		" Your crew was attacked by a giant squid inside the ship but sucessfully neutralized all hostile elements. The ship is is mostly intact and ready to salvage for supplies." ,
		                  		" Your crew was unprepared for the giant squid inside the ship and some of your crew was injured, The ship exploded with ink as soon as your crew managed to get back on your ship." , 
		                  		2, "Military", "Espionage", "Diplomacy", "Science", 60, 2, "Military", m2, "None", false, false);
		missionList.Add (m);
		m = new Mission ("Mars Attacks!","A neighboring planet sends over two ships filled with hostile squad members, angry because some debris from your ship had landed " +
						 		"on their planet and destroyed one of their cities. They cannot be calmed down, and will not back down from a fight. You have no choice but to send your best fighters out on this mission!",
						 		"As I always say, it's better to have no enemies than to have enemies at all. After successfully defeating the war-minded species, you ransack their ships and find many supplies. Plus, you get to keep their two ships! Success!",
						 		"You win some, and you lose some. Unfortunately, you lost this battle. After your enemies captured some supplies to bring back to their home planet, they warn you not to mess with them or they will come back... with MORE forces! Yikes!",
						   		3, "Military", "Espionage", "Diplomacy", "Science", 50, 3, "Military", m3, "None", false, false);
		missionList.Add (m);

		//------------------------------------- SCIENCE MISSIONS -----------------------------------------------//
		
		m = new Mission("Portal to the Unknown","You see a weird set of machines as you approach this island. As you look closer it looks like some kind of modern portal. You're not sure where it may lead you. " + 
							"There's a chance if you send some crew members into this portal that it could lead to some big rewards.",
							"After waiting for what seems like forever for your crew members to return from the portal you are worried about if they ever will come back. However, as the day almost closes and you " +
							"are about to give up, your crew members come back out the portal carrying fancy new laser guns and high tech utility belts. It looks like their smarts helped them navigate through the " +
							"alien universe they visited and helped them come back with some equipment.", 
							"After waiting for what seems like forever for your crew members to return from the portal you are worried that they may never come back. However, as the day almost closes and you are " +
							"about to give up you see a bright spark come from the portal. All of a sudden your members are thrown out of the portal. It seems like they don't remember anything that just happened to them. They must have been brain wiped before they were kicked out.",
							 2, "Science", "Espionage", "Military", "Diplomacy", 80, 1, "Science", s1, "None", false, false);
		missionList.Add (m);
		m = new Mission("Drill Baby Drill", "You hear a rumor that a mining company in the sector is trying to station a refinery on a  nearby gas giant and are having trouble stabilizing it's ocean platform. One of your advisors suggest that we could be rewarded if we help them solve their problem",
						 "Your crew realizes there are fluctuations due to an anomoly from an underwater vent. By accounting for this, the refinery was stabilized and the mining company's representative thanks you for your help.",
						 "Your crew couldn't come up with a solution and the mining company had to call in help from their holding company. They thank you for your efforts, despite the lack of progress, but you recieve no reward. ",
						  1, "Science", "Espionage", "Military", "Diplomacy", 60, 2, "Science", s2, "None", false, false);
		missionList.Add (m);
		m = new Mission("Don't Poison Me, Bro!", "A strange, purple liquid is found oozing out of a nearby water source. This gives rise to a rumor that poison is being pumped into the water supply and many people become outraged. " + 
						 "However, it is up to you to investigate and figure out what is going on.", "After running some tests in the lab, you come to find that the substance found in the water supply is completely harmless. In fact, " + 
						 "the water tastes even better, and apparently has some healthier properties. Yay!",
						 "After running some tests in the lab, you come to find that the substance found in the water supply actually has traces of rat poison in it! Now half of the inhabitants on this planet do not trust you. Boo!",
						  1, "Science", "Espionage", "Diplomacy", "Military", 80, 1, "Science", s3, "None", false, false); 

		missionList.Add (m);
		m = new Mission("Quick Before the Volcano Blows!", "You hear an explosion in the distance. After approaching the area, you see weird light emitting from a rock formation. Not knowing if the area is dangerous or not, you decide to explore anyways.",
						 "You realize the light being emitted came from a small disco party being held within the nearby dormant volcano. They explain that the explosion formed when they started throwing around some " + 
						 "old rocks they found lying around the floor. Intrigued, you decide to stay and study the properties of this \"dormant\" volcano.", 
						 "After exploring for a while, you realize the area is in the way of multiple, dangerous magnetic fields. All of your equipment is damaged!",
						  3, "Science", "Diplomacy", "Military", "Espionage", 60, 2, "Science", s4, "None", false, false);


		//-----------------------------------------------Espionage--------------------------------------------------------------\\

		missionList.Add (m);
		m = new Mission("The Drop Off", "You pick up transmissions about a \"deal\" going on between two ships in the nearby area. One of your advisors suggests that this \"deal\" can be used to our advantage to curry favor with the nearby authorities.",
						 "You collect transmission data and report it back to local authorities. They deploy bounty hunters and give you money for the information.",
						 "The two ships picked up your crew members spying on them in the vicinity and quickly bailed. Any opportunity to take action is now lost.",
						 1, "Espionage", "Military", "Diplomacy", "Science", 70, 1, "Espionage", e1, "None", false, false);

		missionList.Add(m);
		m = new Mission("Go Fish", "An undercover agent, Q, selects you to man a secret mission that will involve wiretapping a nearby successful fishing boat in order to listen in on secret information that will help you in the long run. Are you up for it?",
						 "You successfully listen in on many conversations aboard the neighboring ship without being caught. Now you know a cornucopia of secrets about fishing and the citizens of your planet won't starve. Yay!",
						 "You accidentally mixed up the wiring and got completely mixed up signals. Looks like you should have picked some better spies for this mission, buddy. Maybe next time!",
						 3, "Espionage", "Diplomacy", "Science", "Military", 70, 1, "Espionage", e2, "None", false, false);

		missionList.Add (m);
		m = new Mission("Gone Baby", "A baby is dropped on the doorstep of your ship. Whose baby is this? Where did it come from? Where will it go? You must try to find the reason for this random baby at once!", 
						 "With your investigation taking place at once, you come to realize this \"baby\" is really a small woman in disguise! She is flabbergasted by your sleuthing skills and awards you a small sum of money. She would have gotten away with it if it weren't for you pesky kids!",
						 "Before you figure out the secret of the baby, it's too late. You realize the baby is a small SPY woman in disguise and she steals top secret information before she escapes!",
						 2, "Espionage", "Diplomacy", "Science", "Military", 77, 1, "Espionage", e3, "None", false, false);


		//-------------------------------------------------------Diplomacy---------------------------------------------// 

		missionList.Add (m);
		m = new Mission("Grill Baby Grill", "You see a smoke signal from a nearby island, as you approach you see a group of fishermen grilling fish. They don't seem hostile.",
						 "Your crew members approach the fishermen and are given a friendly welcome. You make a remark about a school of fish you came across on your way here. In return they offer you some fish to take back to the ship with you.",
						 "There was almost a confrontation between the fishermen and your crew. You were asked to promptly leave, in order to avoid the situation you withdraw.",
						 2, "Diplomacy", "Science", "Military", "Espionage", 80, 1, "Diplomacy", d1, "None", false, false);

		missionList.Add (m);
		m = new Mission("We're Not in Kansas Anymore", "A ship crashes into your planet, but nothing comes out of it for an hour. After another hour passes, you see a figure trying to climb out of the ship. You decide to send some of your crew over to see what is going on.",
						 "You find a small family of five, but you can't understand their language! Luckily, one of your diplomats is able to translate. The family is grateful for your help and pay you a small sum of money for fixing their ship. It's the least they could do.",
						 "You approach the ship, and the small family trapped inside react in a hostile manner. You cannot understand their alien language, and they become angrier. Everything you do seems to upset them! After a minute of arguing, the entire family vanishes in thin air. Oh well.",
						 2, "Diplomacy", "Espionage", "Military", "Science", 50, 3, "Diplomacy", d2, "None", false, false);

		missionList.Add (m);
		m = new Mission("It's All Greek to Me", "A sealed capsule is uncovered near an ancient ruin in the middle of a desert island. You manage to open it, and find only a slip of paper with the message \"ØƔʤϱϔҨ\" marked upon it. You must figure out what this means!", 
						 "After sleuthing around various ruins, you find the same message encrypted into a wall on a neighboring island. With the help of the local villagers, you realize the message states \"we come in peace.\" The makers of the message are long gone, but the local villagers now trust you. Woo!",
						 "You cannot figure out what the message says, no matter what you do. But it doesn't matter, because before you can guess that the message means \"stay away\" a ninja clan swoops out of nowhere and attacks! AH!", 
						 2, "Diplomacy", "Espionage", "Military", "Science", 60, 2, "Espionage", d3, "None", false, false);

		missionList.Add (m);
		
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
