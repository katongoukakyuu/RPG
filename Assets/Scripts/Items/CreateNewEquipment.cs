using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[] {
		"None",
		"Common",
		"Great",
		"Amazing",
		"Insane"
	};
	private string[] itemDes = new string[] {
		"None",
		"A new cool item",
		"A new not-so-cool item"
	};

	void Start() {
		CreateEquipment ();
		Debug.Log (newEquipment.itemName);
		Debug.Log (newEquipment.itemDescription);
		Debug.Log (newEquipment.itemID.ToString());
		Debug.Log (newEquipment.equipmentType.ToString());
		Debug.Log (newEquipment.stamina.ToString());
	}

	private void CreateEquipment() {
		newEquipment = new BaseEquipment ();
		newEquipment.itemName = itemNames[Random.Range (1, itemNames.Length)];
		newEquipment.itemID = Random.Range (1, 101);
		newEquipment.itemDescription = itemDes[Random.Range (1, itemDes.Length)];
		ChooseItemType ();

		newEquipment.stamina = Random.Range (1, 11);
		newEquipment.endurance = Random.Range (1, 11);
		newEquipment.strength = Random.Range (1, 11);
		newEquipment.intellect = Random.Range (1, 11);
	}

	private void ChooseItemType() {
		int enumLength = System.Enum.GetValues (typeof(BaseEquipment.EquipmentTypes)).Length;
		int randomTemp = Random.Range (1, enumLength);
		newEquipment.equipmentType = (BaseEquipment.EquipmentTypes) randomTemp;
	}
}
