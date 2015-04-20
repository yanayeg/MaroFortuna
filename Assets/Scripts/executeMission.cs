using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class executeMission : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Data.hitBack = false;
		Mission activeMission = Data.pickedMission;
		if (activeMission.runMission(activeMission, Data.activeMissionChars))
		   Application.LoadLevel ("ResultsScene");
		else 
			Application.LoadLevel ("FailResults");
		
	}
	// Update is called once per frame
	void Update () {

	}
}