using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	BasePlayer newPlayer;
	bool isMageClass = true;
	bool isWarriorClass = false;
	string playerName = "Player";
	
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	void OnGUI() {
		playerName = GUILayout.TextArea (playerName);
		if (GUILayout.Toggle (isMageClass, "Mage Class")) {
			isMageClass = true;
			isWarriorClass = false;
		}
		if (GUILayout.Toggle (isWarriorClass, "Warrior Class")) {
			isMageClass = false;
			isWarriorClass = true;
		}

		if (GUILayout.Button ("Create")) {
			if(isMageClass) {
				newPlayer.playerClass = new BaseMageClass();
			}
			else if(isWarriorClass) {
				newPlayer.playerClass = new BaseWarriorClass();
			}

			newPlayer.playerName = playerName;
			newPlayer.playerLevel = 1;
			newPlayer.stamina = newPlayer.playerClass.stamina;
			newPlayer.endurance = newPlayer.playerClass.endurance;
			newPlayer.intellect = newPlayer.playerClass.intellect;
			newPlayer.strength = newPlayer.playerClass.strength;

			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();

			Debug.Log ("Player Name: " + newPlayer.playerName);
			Debug.Log ("Player Class: " + newPlayer.playerClass);
			Debug.Log ("Player Level: " + newPlayer.playerLevel);
			Debug.Log ("Player Stamina: " + newPlayer.stamina);
			Debug.Log ("Player Endurance: " + newPlayer.endurance);
			Debug.Log ("Player Intellect: " + newPlayer.intellect);
			Debug.Log ("Player Strength: " + newPlayer.strength);
		}

		if (GUILayout.Button ("Load")) {
			Application.LoadLevel("test");
		}
	}

	private void StoreNewPlayerInfo() {
		GameInformation.playerName = newPlayer.playerName;
		GameInformation.playerLevel = newPlayer.playerLevel;
		GameInformation.stamina = newPlayer.stamina;
		GameInformation.endurance = newPlayer.endurance;
		GameInformation.intellect = newPlayer.intellect;
		GameInformation.strength = newPlayer.strength;
	}
}
