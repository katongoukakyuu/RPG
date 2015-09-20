using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	void Start() {
		CreateWeapon ();
		Debug.Log (newWeapon.itemName);
		Debug.Log (newWeapon.itemDescription);
		Debug.Log (newWeapon.itemID.ToString());
		Debug.Log (newWeapon.weaponType.ToString());
		Debug.Log (newWeapon.stamina.ToString());
	}

	public void CreateWeapon() {
		newWeapon = new BaseWeapon ();
		newWeapon.itemName = "W" + Random.Range (1, 101);
		newWeapon.itemDescription = "This is a new Weapon.";
		newWeapon.itemID = Random.Range (1, 101);

		newWeapon.stamina = Random.Range (1, 11);
		newWeapon.endurance = Random.Range (1, 11);
		newWeapon.strength = Random.Range (1, 11);
		newWeapon.intellect = Random.Range (1, 11);

		ChooseWeaponType ();
		newWeapon.spellEffectID = Random.Range (1, 101);

	}

	private void ChooseWeaponType() {
		int enumLength = System.Enum.GetValues (typeof(BaseWeapon.WeaponTypes)).Length;
		int randomTemp = Random.Range (1, enumLength);
		newWeapon.weaponType = (BaseWeapon.WeaponTypes)randomTemp;
	}
}
