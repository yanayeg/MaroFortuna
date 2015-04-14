using UnityEngine;
using System.Collections;

public class BullSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Data.charList [0].setPicked ();
		Debug.Log("Is picked " + Data.charList[0].isPicked);
	}
}
