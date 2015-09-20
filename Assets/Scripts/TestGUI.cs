using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseCharacterClass class1 = new BaseMageClass();
	private BaseCharacterClass class2 = new BaseWarriorClass();

	void OnGUI() {
		GUILayout.Label (class1.characterClassName);
		GUILayout.Label (class1.characterClassDescription);
		GUILayout.Label (class2.characterClassName);
		GUILayout.Label (class2.characterClassDescription);
	}
}
