using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation() {
		PlayerPrefs.SetInt("PLAYERLEVEL",GameInformation.playerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.playerName);
		PlayerPrefs.SetInt("STAMINA",GameInformation.stamina);
		PlayerPrefs.SetInt("ENDURANCE",GameInformation.endurance);
		PlayerPrefs.SetInt("INTELLECT",GameInformation.intellect);
		PlayerPrefs.SetInt("STRENGTH",GameInformation.strength);

		if (GameInformation.equipment1 != null) {
			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.equipment1);
		}

	}
}
