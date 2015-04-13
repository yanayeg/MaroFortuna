using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestMission : MonoBehaviour {

	void Awake(){
		Character[] squad = {Data.charList [5], Data.charList [9]};
		Mission testMiss = Data.missionList [0];

		if (testMiss.runMission (testMiss, squad))
			Debug.Log ("Success");
		//if (testMiss.runMission (testMiss, squad) == false)
		else
			Debug.Log ("Fail");

	}
}
