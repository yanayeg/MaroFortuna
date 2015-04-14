using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//select the mission that was picked
		string successDesc = Data.pickedMission.successDesc;
		Text guiText = GameObject.Find("Description").GetComponent<Text>();
		guiText.text = successDesc;

		string outcome = "Success!";
		Text guiText2 = GameObject.Find("successMessage").GetComponent<Text>();
		guiText2.text = outcome;
		// if it was successful mission call:
		Resource reward = Data.pickedMission.rewardRsc;
		Data.resourceList.Add (reward);
		//test if it worked
		if (Data.resourceList != null) {
			Debug.Log(Data.resourceList[0].rscName);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
