using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}

	public static BaseEquipment equipment1 { get; set; }
	public static string playerName { get; set; }
	public static int playerLevel { get; set; }
	public static BaseCharacterClass playerClass { get; set; }
	public static int stamina { get; set; }
	public static int endurance { get; set; }
	public static int intellect { get; set; }
	public static int strength { get; set; }
}
