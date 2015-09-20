using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

	public PotionTypes potionType { get; set; }
	public int spellEffectID { get; set; }

	public enum PotionTypes {
		NONE,
		HEALTH,
		ENERGY,
		STRENGTH,
		INTELLECT,
		VITALITY,
		ENDURANCE,
		SPEED
	}
}
