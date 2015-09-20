using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseItem {

	public string itemName { get; set;}
	public string itemDescription { get; set;}
	public int itemID { get; set;}
	public ItemTypes itemType { get; set;}

	public enum ItemTypes {
		NONE,
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}

}
