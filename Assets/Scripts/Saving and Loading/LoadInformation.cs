using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation() {
		GameInformation.playerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.playerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.stamina = PlayerPrefs.GetInt("STAMINA");
		GameInformation.endurance = PlayerPrefs.GetInt("ENDURANCE");
		GameInformation.intellect = PlayerPrefs.GetInt("INTELLECT");
		GameInformation.strength = PlayerPrefs.GetInt("STRENGTH");

		if(PlayerPrefs.GetString("EQUIPMENTITEM1") != null) {
			GameInformation.equipment1 = (BaseEquipment) PPSerialization.Load ("EQUIPMENTITEM1");
		}
	}
}
