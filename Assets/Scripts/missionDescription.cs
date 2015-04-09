using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class missionDescription : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string missionDesc = Mission.missionList[0].description;
		Text guiText = GameObject.Find("Description").GetComponent<Text>();
		guiText.text = missionDesc;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
