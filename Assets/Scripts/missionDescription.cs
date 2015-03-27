using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class missionDescription : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
		string missionDesc = Mission.description.ToString();
		Text guiText = GameObject.Find("Description").GetComponent<Text>();
		guiText.text = missionDesc;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
