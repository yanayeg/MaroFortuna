using UnityEngine;
using System.Collections;

public class TriggeredEvent : MonoBehaviour {
	public bool doWindowBadTrigger = false;
	public bool doWindowGoodTrigger = false;

	// Use this for initialization
	void Start () {
		if(Data.dayCounter == 6){
			doWindowBadTrigger = true;
			//we take away gold 
			if(Data.diplomacyResCount > 100){
				Data.diplomacyResCount -=100;
			}
		}

		if (Data.dayCounter == 12) {
			doWindowGoodTrigger = true;
			//we add a fish 
			Data.scienceResCount +=100;
		}
	}



	void DoWindowGood(int windowID) {
		GUILayout.Label("The day breaks with particularly rough seas. The large waves batter the ship, and your beleaguered crew is soaked with the spray. But it seems every cloud has a silver lining, as a rogue wave washes a large fish onto the deck. Your crew will have food for days to come!");
		if (GUI.Button (new Rect (20, 160, 200, 20), "Accept")) {
			doWindowGoodTrigger = false;
		}
		
		
	}

	void DoWindowBad(int windowID) {
			GUILayout.Label("As you wake on the eigth day, you see that a large coffer of gold has disappeared from the holds below deck. Perhaps you should post guards to watch for pesky theives in the night...");
			if (GUI.Button (new Rect (20, 160, 200, 20), "Accept")) {
				doWindowBadTrigger = false;
			}
			
		 
	}

	void OnGUI() {
		//doWindow0 = GUI.Toggle(new Rect(10, 10, 100, 20), doWindow0, "Window 0");
		if (doWindowBadTrigger) {
			GUI.Window (0, new Rect (300, 100, 250, 200), DoWindowBad, "OH NO!");
		}
		if (doWindowGoodTrigger) {
			GUI.Window (0, new Rect (300, 100, 250, 200), DoWindowGood, "Awesome!");
		}
	}


	// Update is called once per frame
	//void Update () {

	//}
}
