using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testTextScript : MonoBehaviour {



	// Use this for initialization
	void Start () {

		var AVariable = "YOU HAVE SUCCESSFULLY COMPLETED THE MISSION!";
		Text guiText = GameObject.Find("successMessage").GetComponent<Text>();
		guiText.text = AVariable;
	
		var AVariable1 = "No one died yay omg okay you successfully killed all the space pirates";
		Text guiText1 = GameObject.Find("Description").GetComponent<Text>();
		guiText1.text = AVariable1;

		//var AVariable2 = "YOU HAVE SUCCESSFULLY COMPLETED THE MISSION!";
		//Text guiText2 = GameObject.Find("successMessage").GetComponent<Text>();
		//guiText2.text = AVariable2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
