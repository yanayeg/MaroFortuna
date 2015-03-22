using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickCharacter : MonoBehaviour {
	// Use this for initialization
	public int teamCount = 0;
	public int mCount, sCount, dCount, eCount = 0;
	Text textObject;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnMouseDown(string characterType)
	{
		Debug.Log ("name is:" + characterType);
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
