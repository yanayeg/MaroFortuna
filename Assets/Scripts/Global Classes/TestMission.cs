using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestMission : MonoBehaviour {

	void Awake(){
		List<Character> squad = new List<Character> ();
		squad.Add(Data.charList [5]);
		squad.Add(Data.charList [9]);
		Mission testMiss = Data.missionList [0];

		if (testMiss.runMission (testMiss, squad))
			Debug.Log ("Success");
		//if (testMiss.runMission (testMiss, squad) == false)
		else
			Debug.Log ("Fail");

	}
}
