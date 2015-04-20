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
	public static int currentCrewSize;
	public static int militaryResCount;
	public static int espionageResCount;
	public static int diplomacyResCount;
	public static int scienceResCount;
	public static bool needCharacter;
	public static int adjustedDifficulty;
	public static bool hitBack;


	void Awake(){
		//--------------------------------------CHARACTER CREATION SECTION-------------------------------------------//
		//instantiate and add to list all your characters (we probably need to do this for each single one, so copy paste!)
		Character c;
		//MILITARY CHARACTERS
		c = new Character ("Military", "Sitting Bull", Resources.Load("MilitaryTiger.prefab") as Sprite, 0, 1,
		                   "Leader of the great tribes.", false);
		currentChars.Add (c);
		c = new Character ("Military", "Sun Tzu the Tiger", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Wrote important military tactics in his novel, 'The Art of Roar.'", false);
		charList.Add(c);
		c = new Character ("Military", "Artemis the Wolf", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Master of the bow and arrow.", false);
		charList.Add (c);
		c = new Character ("Military", "Zorro the Fox", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "The ferocity of this fox will leave foes in fear of furnishing faux fur.", false);
		charList.Add (c);
		//SCIENCE CHARACTERS
		c = new Character ("Science", "Mousie Curie", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Won the Swiss Prize in her studies of radiated cheese curds.", false);
		charList.Add (c);
		c = new Character ("Science", "Hathaway the Hare", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "This black hat hacker named Hathaway.", false);
		charList.Add (c);
		c = new Character ("Science", "Ram Descartes", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Mathematician and philisophist, most famous statement: If it fits, I sits.", false);
		currentChars.Add (c);
		c = new Character ("Science", "Olympia the Owl", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "A healer of the many.", false);
		charList.Add (c);
		//ESPIONAGE CHARACTERS
		c = new Character ("Espionage", "Margreet the Bat", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "A master of disguise and dancing.", false);
		currentChars.Add (c);
		c = new Character ("Espionage", "Pierre the Parrot", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Pickpoketing extraordinaire.", false);
		charList.Add (c);
		c = new Character ("Espionage", "Roy the Boartender", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "He hears a lot of gossip around the speakeasy.", false);
		charList.Add (c);
		c = new Character ("Espionage", "Lucia the Crow", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "A cunning crow that can get around anywhere.", false);
		charList.Add (c);
		//DIPLOMACY CHARACTERS
		c = new Character ("Diplomacy", "Espresso the Dog", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "He just wants to talk things out over some good coffee.", false);
		charList.Add (c);
		c = new Character ("Diplomacy", "Octavia the Octopus", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "Tangles people up in contracts and paperwork.", false);
		charList.Add (c);
		c = new Character ("Diplomacy", "Eisenhower the Elk", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "A fancy dancy elk.", false);
		currentChars.Add (c);
		c = new Character ("Diplomacy", "Masako the Monkey", Resources.Load ("/Portrait.png") as Sprite, 0, 1,
		                   "This monkey knows a tune that can make a girl swoon.", false);
		charList.Add (c);
		//shuffle list
		charList = ShuffleList (charList);
		//-----------------------------------RESOURCE CREATION SECTION--------------------------------------------//
		//create a list of resouces

		//Military
		Resource m1 = new Resource ("Raw Materials", "Military", 100);
		Resource m2 = new Resource ("Metal", "Military", 100);
		Resource m3 = new Resource ("2 Ships", "Military", 100);
		Resource m4 = new Resource ("Tactical Knowledge", "Military", 100);
		Resource m5 = new Resource ("The loose hounds of war", "Military", 100);
		Resource m6 = new Resource ("Gold Bars", "Military", 100);
		Resource m7 = new Resource ("Mmmmm Prison Food!", "Military", 100);
		Resource m8 = new Resource ("Fruity fruits", "Military", 100);

		//Science
		Resource s1 = new Resource ("Alien Technology", "Science", 100);
		Resource s2 = new Resource ("Potions", "Science", 100);
		Resource s3 = new Resource ("Chemical Knowledge", "Science", 100);
		Resource s4 = new Resource ("Rock Samples", "Science", 100);
		Resource s5 = new Resource ("Science Materials", "Science", 100);
		Resource s6 = new Resource ("Scientific Knowledge", "Science", 100);
		Resource s7 = new Resource ("Yummy fruit!", "Science", 100);

		//Espionage
		Resource e1 = new Resource ("Cold hard cash", "Espionage", 100);
		Resource e2 = new Resource ("Fishing Secrets", "Espionage", 100);
		Resource e3 = new Resource ("Miniture Mama Money", "Espionage", 100);
		Resource e4 = new Resource ("Slightly sticky gold", "Espionage", 100);
		Resource e5 = new Resource ("Blueprints", "Espionage", 100);
		Resource e6 = new Resource ("Fistfuls of fruits and forrest nuts", "Espionage", 100);
		Resource e7 = new Resource ("Got the goods", "Espionage", 100);
		Resource e8 = new Resource ("Textbooks!", "Espionage", 100);


		//Diplomacy
		Resource d1 = new Resource ("Flock of flavorful fish", "Diplomacy", 100);
		Resource d2 = new Resource ("Gold", "Diplomacy", 100);
		Resource d3 = new Resource ("Favor of the locals", "Diplomacy", 100);
		Resource d4 = new Resource ("Bountiful bounty", "Diplomacy", 100);
		Resource d5 = new Resource ("Lumber", "Diplomacy", 100);
		Resource d6 = new Resource ("Curency", "Diplomacy", 100);
		Resource d7 = new Resource ("Gifts galore!", "Diplomacy", 100);
		Resource d8 = new Resource ("Swords and knives and other sharp things", "Diplomacy", 100);


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

		m = new Mission ("The Tides of March", "A young man approaches your ship seeking mercenaries. His uncle, the emperor, was murdered by a group of his best friends, and he desires vengeance. He's willing to pay for your assistance. Send some warriors to help his cause!",
						 "The opposing leaders, at the sight of your warriors, killed themselves in despair. Their sole surviving leader fled on a small boat. All in all, the victory was pretty effortless.", 
						 "Your band of mercernaries was routed! The enemy leaders, believing the day to be lost, killed themselves pretty early in the battle. Their much-more-intelligent lieutenants took command and turned the tide of the battle.",
						 3, "Military", "Science", "Espionage", "Diplomacy", 85, 1, "Military", m5, "None", false, false); 
		missionList.Add (m);

		m = new Mission ("The Fallen Colossus", "As you approach the nearby island, a large statue overseeing their harbor tumbles into the ocean with a thunderous groan. The natives blame you for the misfortune, and demand you send some burly crew members to help clear the wreckage. Or at least help them repair the broken statue.",
						 "Your crew toils late into the night, but the wreckage has been dredged from the harbor and the restoration work is already well underway. This society has produced some surprisingly advanced engineers. As thanks, they share some of their knowledge with you.",
						 "Your weary crew tries to assist with the recovery efforts, but the statue previously overlooking the harbor was too large and complex for them to handle. Embarassed for you, the natives ask you politely to leave while they clean up the mess.",
						 4, "Military", "Science", "Espionage", "Diplomacy", 60, 2 , "Military", m4, "None", false, false);
		missionList.Add (m);

		m = new Mission ("Do Well", "A local hero from the island approaches your ship and demands that you send her someone to fight. For too long she has lived amongst the weaklings on this island. Now that you're here, she hopes you can alleviate her ennui.",
						 "The duel lasts the majority of the afternoon, neither combatant willing to give the other an inch. Striking surely and swiftly, your crew member smiles as the village's hero finally falls. The villagers shower your crew in gold and the deck of your ship is carpeted in roses.",
						 "The local hero makes quick work of your crew member. Smirking, the hero watches as they slink back to your ship, defeated.",
						 1, "Military", "Espionage", "Diplomacy", "Science", 40, 3, "Military", m6, "None", false, false);
		missionList.Add (m);

		m = new Mission ("Live at Folsom Prison", "It has been a while since you've been able to stop and restock your supplies. As your ship sails onward an island is spotted in the distance. You use your spyglass to get a closer look. You see concrete towers and walls, a brutalistic monument to an era where laws were still enforced. Approaching the shore you notice smoke pouring into the sky and the decayed state of the infastructure. A man in an orange jumpsuit flags you down, but his disposition isn't the friendliest. You must arrange a party to meet him.", "You send a party to parley with the man. Apparently, having spent years in the correctional facility has rehabilitated the islands residents. The former felons have formed a utopian society. After hosting a feast in your honor, the ex-cons wish you luck on your journey, and send you off with food for the journey ahead.",
						 "Sadly, years spent languishing in the halls of justice has done little to change the residents of this island. Your party lands on the beach to meet with the man and are soon ambushed by his fellow felons. Your crewmates make quick work of the malnourished convicts, executing justice swiftly and exactly. Their debt to society finally paid, the criminals will make a decent meal for the crabs on the beach. Your crew returns to the ship with nothing but injuries from the battle.",
						 2, "Military", "Diplomacy", "Espionage", "Science", 50, 1, "Military", m7, "None", false, false);
		missionList.Add (m); 

		m = new Mission ("Bucket Brigade", "As your ship nears the island, a pillar of black smoke begins billowing into the sky. Looking with your spyglass, you see that a large building has caught fire in a village near the beach. Panicked citizens can be seen running to an fro, athough a few villagers are carrying buckets of water from the sea in an attempt to douse the flames. Send some of your crew to help put out the fire, or at least help the villagers think of a way to keep it from spreading.",
						 "Your crew works swiftly and efficiently. They help the villagers to quickly douse the blaze before it can spread. Grateful for your assistance, the villagers offer you the bounty from their recent harvest. Your holds are now laden with delicious fruit!",
						 "Unfortunately, the fire quickly turns into a raging inferno. Despite the best efforts of your crew, the village is consumed by the blaze. The villagers thank you for your assistance, and weep at the thought of their lost possessions. You leave them to mourn and to being rebuilding.",
						 2, "Military", "Science", "Espionage", "Diplomacy", 60, 2, "Military", m8, "None", false, false);

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

		missionList.Add (m);
		m = new Mission("No! Not the Trees!", "It might just be a trick of the light, but it looks like the trees on that island are moving! They appear to be advancing towards a city. Maybe we could learn something by studying their biology.",
						 "The figures turned out to indeed be a race of sentient trees. This planet is truly alien. Their technology was surprisingly advanced, and they shared some schematics with the crew. You could learn much from them.",
						 "The figures were an army of warriors disguised as trees! They attacked our group and drove us back to the ship. Apparently, they were attempting to sack the city while it was unawares.",
						 2, "Science", "Military", "Diplomacy", "Espionage", 40, 3, "Science", s5, "None", false, false);

		missionList.Add (m);
		m = new Mission("Buffalo buffalo buffalo", "The buffalo that live on one side of this island seem much more robust than those that live on the other side. As a result, they often bully the other buffalo. See if you can find out what makes them so much stronger. The information may prove useful in the future.",
						"It turns out that their large size is due mainly to and earnest work ethic and clean living. That, and the abundance of growth hormones in the grass on their side of the island. You collect some samples of the grass.", 
						"The larger buffalo buffalo your crew as well. After roughing them up and hanging their underwear from a flagpole, they allow your crew to return to the ship, defeated.",
						3, "Science", "Military", "Espionage", "Diplomacy", 60, 2, "Science", s5, "None", false, false);

		missionList.Add (m);
		m = new Mission("Zombo Combo", "The island nearby seems to be embroiled in war. As you approach the beach, you receive a transmission asking for scientists to help cure the madness plaguing some citizens. Or perhaps someone to investigate the source of the problem.",
						"After tracking down the source of the madness: a virus introduced into the town's water source, your crew and the town's scientists work feverishly to develop a cure. The town is saved, and your crew has gained much medical knowledge.",
						"The madness seems to be transmissable through the air. The entire island seems to be overcome with insanity. Your crew manages to escape, but just barely.",
						2, "Science", "Espionage", "Diplomacy", "Military", 40, 3, "Science", s6, "None", false, false);

		missionList.Add (m);
		m = new Mission("Gravity Well", "Your ship seems mysteriously drawn towards the island nearby. Preliminary readings reveal some sort of gravitational anomaly. Send some crew members to investigate the phenomenon.", 
						"The island appears to be covered in ancient technology, some of which is causing fluctuations in gravity local to the area. Their technology is too advanced to possibly understand, but you collect some fruit from the many trees on the island.",
						"Your crew investigates the island, but can find no apparent explanation for the fluctuations in gravity. Perhaps your mother crash-landed somewhere in the forest.",
						1, "Science", "Espionage", "Military", "Diplomacy", 80, 1, "Science", s7, "None", false, false);


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

		missionList.Add (m);
		m = new Mission("Clamlet", "\"Clamlet... Clamlet...\" A ghost has appeared on the ship, calling out someone's name. He's pretty spooky with all that moaning! He wants someone to kill the king of that island nearby. Who cares why? Just do it and maybe he'll go away!",
						 "You dispatch the king and manage to grab some gold and jewels from his bedchamber. Disappearing in a puff of green smoke, the ghost leaves more ectoplasm-covered gold on the deck of your ship. ",
						 "You manage to infiltrate the castle, but stumble into the backstage of the king's theater. Unfortunately for you, an acting troupe is in the middle of a performance! Dragged onto the stage, you act your heart out, but receive only jeers and rotten tomatoes for your efforts.",
						 1, "Espionage", "Military", "Diplomacy", "Science", 40, 3, "Espionage", e4, "None", false, false);

		missionList.Add (m);
		m = new Mission("The Fair's Fair Fare", "You hear an announcement on the nearby island that a science fair will be held at their kingdom's captial. There is sure to be some innovative machines there for showcase. By hook or by crook, getting some of those schematics would be invaluable.", "Armed with only your wits, a pair of stage glasses, and a white coat, you sneak into the science fair and grab a few conveniently rolled-up blueprints. Your scientists will surely appreciate your efforts.",
						"You rush into the science fair pavillion and grab some rolled-up papers, assuming them to be schematics of some sort. Unfortunately, when you get back to the ship, you realize they are just rolls of paper towels! Better luck next time.",
						1, "Espionage", "Science", "Military", "Diplomacy", 60, 2, "Espionage", e5, "None", false, false);

		missionList.Add (m);
		m = new Mission("Dog Day Afternoon", "There's talk that the island's coffers are overflowing with food. Surely no one would mind if some of that food were to go missing?",
						"The island's food supply is indeed plentiful. Their numerous trees are heavy with a bountiful harvest. Grabbing as many fruits and nuts as they can carry, your crew brings enough food to last a good while.",
						"The island's food stores are laden with pizza! Searching for enough boxes to bring back an appreciable amount, your crew is discovered by some villagers! Managing to hide for the night in the attic of an abandoned home, they return empty-handed early the next day.",
						2, "Espionage", "Diplomacy", "Science", "Military", 60, 2, "Espionage", e6, "None", false, false);

		missionList.Add(m);
		m = new Mission("The Caravan", "You see a caravan of trade goods that appears to be stopping for the night. It doesn't look like they have very many guards set to watch for potential trouble, and they are well-exposed, camped in the middle of an open field. Perhaps you could sneak into their camp and make off with some goodies.",
						"With panache and a quick flash of steel, you manage to wrest some goods from the ill-defended caravan.",
						"The caravan, while seeming well-defended from the beach, had more guards than you anticipated. Thievery might be common in this area.",
						3, "Espionage", "Military", "Science", "Diplomacy", 40, 3, "Espionage", e7, "None", false, false);

		missionList.Add(m);
		m = new Mission("Playing Hooky", "The mayor of a city near the beach has come to the ship looking for assistance. Truancy is rampant at the local school. The majority of the police force is searching for the miscreants, but they need more help. Send a party to search for them. Or help find a way to make school fun.", "Interrogating some less-than-savory parents, you manage to locate a few of their delinquent children. The mayor thanks you and pays you in textbooks. Knowledge is power!",
 						"You find out the children have been skipping school to organize a militia. You attempt to alert the mayor, but he just laughs in your face. School may soon be out forever.",
 						2, "Espionage", "Science", "Diplomacy", "Military", 60, 2, "Espionage", e8, "None", false, false);


		
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
						 2, "Diplomacy", "Espionage", "Military", "Science", 60, 2, "Diplomacy", d3, "None", false, false);

		missionList.Add (m);
		m = new Mission("A Tail of Two Kiddies", "It appears the two tribes on this island are preparing to go to war. Preliminary investigations reveal that one of the chieftain's sons has eloped to be with the other's daughter. Perhaps if you negotiate peace, they will reward us in some way. Or maybe it'd be better for everyone if the kids just... went away.", 
						"That was pretty easy! After sitting down to think about it, both chieftains realized going to war over a couple of kids is pretty ridiculous. Each tribe shares some of their bounty with the crew!",
						"The kids killed themselves before you could do anything. Both chieftains are too overcome with grief to negotiate with each other. The drums of war beat ever-louder...",
						1, "Diplomacy", "Espionage", "Science", "Military", 80, 1, "Diplomacy", d4, "None", false, false);

		missionList.Add (m);
		m = new Mission("The Catfields & McKois", "A group of working-class fish, the McKois have gotten into an argument with a local lumber magnate, Pappy Catfield, over ownership of a pet hog. The fish patriarch has come to your ship, begging for you to act as a mediator to end the dispute before it gets violent.",
						"After examining the hog, you discover a collar with a tag reading \"Henrietta McKoi.\" Clearly, the fish are in the right. They realize the Catfields have grown attached to the hog and agreed to let them see her Tuesdays, Thursdays, and every other weekend. The Catfields are overjoyed and reward you with some lumber.",
						"The two families refuse to see the light of day. Both of them claimed to have written their name of either side of the hog, but it appears the marker washed off in a recent rainstorm. After attempting to get them to share custody of the hog, they begin fighting and the hog runs away.",
						3, "Diplomacy", "Military", "Espionage", "Science", 40, 3, "Diplomacy", d5, "None", false, false);

		missionList.Add (m);
		m = new Mission("WILL You Help Out?", "As you land on the island, a messenger brings a missive to the ship. A noble has passed away recently and his family seeks an impartial party to execute his will. They promise a just reward for your service.",
						"You read over his will and execute it to the letter. Reasonably, his wife and eldest son get the lion's share of his goods. While his younger children would wish for a larger inheritance, they accept your adjudication.",
						"Each of his children attempted to bribe you to rule in their favor. Failing that, they hired thugs to force your hand. You managed to escape unscathed, but have received no recompense for your troubles.",
						1, "Diplomacy", "Science", "Espionage", "Military", 60, 2, "Diplomacy", d6, "None", false, false);

		missionList.Add (m);
		m = new Mission("Green Vs Blue", "The residents of the nearby island are in love with the local horse races. They are so fanatic, in fact, that a recent upset at one of the races has led to widespread rioting in the capital. Their emperor has attempted to pass some laws in order to quell their rage, but he has decided to seek a powerful orator to calm the crowds. Alternately, perhaps the crowds would disperse if they were met with armed resistance...",
						"After delivering a moving speech extolling the virtues of good sportsman and enjoying the game with your fellow citizens, you have successfully calmed the enraged citizens. Thankful for your assistance, the emperor lavishes you with gifts.",
						"The citizens' love for horse racing truly runs deep! Your attempts to remind them, \"It's just a sport... It doesn't really matter,\" have just driven them into a frothing madness. You barely manage to escape their gibbering wrath.",
						1, "Diplomacy", "Military", "Science", "Espionage", 60, 2, "Diplomacy", d7, "None", false, false);

		missionList.Add (m);
		m = new Mission("Foxanne", "A young officer from a local militia comes to the ship with an unusual request. He is desperate to win the heart of his neighbor, but fears that his skill for poetry isn't sufficient. His friends also lack a certain... je ne sais quoi. If you could help him win her heart, he would be forever greatful. After some prodding, he mentions that she's also a fan of nerdy types.",
						"After detailing an elaborate plan in which you hide in the bushes below his neighbor's window and feed him lines to win her heart. Thankful for your assistance, he gives you some weapons from his militia's armory.",
						"Despite your best efforts, the young man is flustered and delivers your lines with poor timing and ends up running away.",
						2, "Diplomacy", "Science", "Military", "Espionage", 40, 3, "Diplomacy", d8, "None", false, false);
		missionList.Add (m);

		dayCounter = 1;
		militaryResCount = 0;
		scienceResCount = 0;
		espionageResCount = 0;
		diplomacyResCount = 0;
		adjustedDifficulty = 0;
		needCharacter = false;
		hitBack = false;
		//this allows it to persist (don't delete please)
		DontDestroyOnLoad (transform.gameObject);
	}

	//shuffle method
	private List<Character> ShuffleList(List<Character> inputList)
	{
		List<Character> randomList = new List<Character>();
		System.Random r = new System.Random();
		int randomIndex = 0;

		while (inputList.Count > 0)
		{
			randomIndex = r.Next(0, inputList.Count - 1); //Choose a random object in the list
			randomList.Add(inputList[randomIndex]); //add it to the new, random list
			inputList.RemoveAt(randomIndex); //remove to avoid duplicates
		}
		
		return randomList; //return the new random list
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
