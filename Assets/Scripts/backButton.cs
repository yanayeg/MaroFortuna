using UnityEngine;
using System.Collections;

public class backButton : MonoBehaviour {
	
	//public GameObject loadingImage;
	
	public void BackToMenu(string level)
	{
		//loadingImage.SetActive(true);
		Data.hitBack = true;
		for(int i=0; i<Data.currentCrewSize; i++)
			Data.activeMissionChars [i].setPicked ();
		Data.activeMissionChars.Clear ();
		Data.currentCrewSize = 0;
		Application.LoadLevel(level);
	}
}