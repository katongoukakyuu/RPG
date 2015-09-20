using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	void Start() {
		CreatePotion ();
		Debug.Log (newPotion.itemName);
		Debug.Log (newPotion.itemDescription);
		Debug.Log (newPotion.itemID.ToString());
		Debug.Log (newPotion.potionType.ToString());
		Debug.Log (newPotion.stamina.ToString());
	}

	private void CreatePotion() {
		newPotion = new BasePotion ();
		newPotion.itemName = "Potion";
		newPotion.itemDescription = "This is a potion.";
		newPotion.itemID = Random.Range (1, 101);
		ChoosePotionType ();

		newPotion.stamina = Random.Range (1, 11);
		newPotion.endurance = Random.Range (1, 11);
		newPotion.strength = Random.Range (1, 11);
		newPotion.intellect = Random.Range (1, 11);
	}

	private void ChoosePotionType() {
		int enumLength = System.Enum.GetValues (typeof(BasePotion.PotionTypes)).Length;
		int randomTemp = Random.Range (1, enumLength);
		newPotion.potionType = (BasePotion.PotionTypes) randomTemp;
	}
}
