using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public WeaponTypes weaponType { get; set; }
	public int spellEffectID { get; set; }

	public enum WeaponTypes {
		NONE,
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM
	}
}
