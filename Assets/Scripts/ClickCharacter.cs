using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickCharacter : MonoBehaviour {
	// Use this for initialization
	public int lCount = 5; //pass in from previous screen
	public int mCount, sCount, dCount, eCount = 0;
	Text textObject;
	void Start () {
		textObject = GameObject.Find("lCount").GetComponent<Text>();
		textObject.text = lCount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnMouseDown(string characterType)
	{
		if (lCount <= 0) {
		}
		else {
			lCount--;
			Text left = GameObject.Find("lCount").GetComponent<Text>();
			left.text = lCount.ToString ();
			switch (characterType) {
			case "military":
				mCount++;
				textObject = GameObject.Find("mCount").GetComponent<Text>();
				textObject.text = mCount.ToString();
				break;
			case "science":
				sCount++;
				textObject = GameObject.Find("sCount").GetComponent<Text>();
				textObject.text = sCount.ToString();
				break;
			case "diplomatic":
				dCount++;
				textObject = GameObject.Find("dCount").GetComponent<Text>();
				textObject.text = dCount.ToString();
				break;
			case "espionage":
				eCount++;
				textObject = GameObject.Find("eCount").GetComponent<Text>();
				textObject.text = eCount.ToString();
				break;		
			}
		}
	}
}
