using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testTextScript : MonoBehaviour {



	// Use this for initialization
	void Start () {

		var AVariable = "FUCK UNITY";
		Text guiText = GameObject.Find("successMessage").GetComponent<Text>();
		guiText.text = AVariable;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
