using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	void Start() {
		LoadInformation.LoadAllInformation ();
		Debug.Log ("Player Name: " + GameInformation.playerName);
		Debug.Log ("Player Level: " + GameInformation.playerLevel);
		Debug.Log ("Player Stamina: " + GameInformation.stamina);
		Debug.Log ("Player Endurance: " + GameInformation.endurance);
		Debug.Log ("Player Intellect: " + GameInformation.intellect);
		Debug.Log ("Player Strength: " + GameInformation.strength);
	}
}
