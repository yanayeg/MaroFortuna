using UnityEngine;
using System.Collections;

public class deployButton : MonoBehaviour {
	
	//public GameObject loadingImage;
	
	public void DeployLoadScene(string level)
	{
		//loadingImage.SetActive(true);
		if((Data.pickedMission.squadSize - Data.currentCrewSize) == 0)
			Application.LoadLevel(level);
	}
}