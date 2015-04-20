using UnityEngine;
using System.Collections;

public class ventureButtonWinCond : MonoBehaviour {
	

	public void VentureLoadScene(string level)
	{




		if (Data.dayCounter == 16) {
			int resourceSum = 0;
			resourceSum = Data.militaryResCount + Data.scienceResCount + Data.espionageResCount + Data.diplomacyResCount;
			int maxSum = -1;
			int type = 1; //1 =  military, 2 = science, 3 = espionage, 4 = diplomacy
			if (resourceSum < 1000) {
				Application.LoadLevel ("NoWin");
			} else {
				//you win
				if (maxSum < Data.militaryResCount) {
					maxSum = Data.militaryResCount;
				}
				if (maxSum < Data.scienceResCount) {
					maxSum = Data.scienceResCount;
					type = 2;
				}
				if (maxSum < Data.espionageResCount) {
					maxSum = Data.espionageResCount;
					type = 3;
				}
				if (maxSum < Data.diplomacyResCount) {
					maxSum = Data.diplomacyResCount;
					type = 4;
				}

				switch (type) {
				case 1:
					Application.LoadLevel ("MilWin");
					break;
				case 2:
					Application.LoadLevel ("SciWin");
					break;
				case 3:
					Application.LoadLevel ("EspWin");
					break;
				case 4:
					Application.LoadLevel ("DipWin");
					break;
				}
			}
		
		}

		else
			Application.LoadLevel(level);



	}
}
