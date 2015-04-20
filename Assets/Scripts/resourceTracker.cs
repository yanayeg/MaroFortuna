using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class resourceTracker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string m = Data.militaryResCount.ToString();
		string s = Data.scienceResCount.ToString();
		string e = Data.espionageResCount.ToString();
		string d = Data.diplomacyResCount.ToString();
		Text guiText1 = GameObject.Find("mtext").GetComponent<Text>();
		guiText1.text = "Military Resources: " + m;

		guiText1 = GameObject.Find("stext").GetComponent<Text>();
		guiText1.text = "Science Resources: " + s;

		guiText1 = GameObject.Find("etext").GetComponent<Text>();
		guiText1.text = "Espionage Resources: " + e;

		guiText1 = GameObject.Find("dtext").GetComponent<Text>();
		guiText1.text = "Diplomatic Resources: " + d;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
