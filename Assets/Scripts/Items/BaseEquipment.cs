using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment : BaseStatItem {

	public EquipmentTypes equipmentType { get; set; }
	public int spellEffectId { get; set; }

	public enum EquipmentTypes {
		NONE,
		HEAD,
		CHEST,
		SHOULDERS,
		LEGS,
		FEET,
		NECK,
		EARRING,
		RING
	}

}
