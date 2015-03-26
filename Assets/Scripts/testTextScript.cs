using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testTextScript : MonoBehaviour {



	// Use this for initialization
	void Start () {


		string successDesc = Mission.successDescription.ToString();
		Text guiText = GameObject.Find("Description").GetComponent<Text>();
		guiText.text = successDesc;

		string outcome = "Success!";
		Text guiText2 = GameObject.Find("successMessage").GetComponent<Text>();
		guiText2.text = outcome;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
