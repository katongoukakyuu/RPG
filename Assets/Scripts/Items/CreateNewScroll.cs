using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {

	private BaseScroll newScroll;
	
	void Start() {
		CreateScroll ();
		Debug.Log (newScroll.itemName);
		Debug.Log (newScroll.itemDescription);
		Debug.Log (newScroll.itemID.ToString());
		Debug.Log (newScroll.spellEffectID.ToString());
	}
	
	private void CreateScroll() {
		newScroll = new BaseScroll ();
		newScroll.itemName = "Scroll";
		newScroll.itemDescription = "This is a powerful scroll.";
		newScroll.itemID = Random.Range (1, 101);
		newScroll.spellEffectID = Random.Range (1, 101);
	}
}
