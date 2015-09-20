using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialization : MonoBehaviour {

	public static BinaryFormatter bf = new BinaryFormatter();

	public static void Save(string tag, object obj) {
		MemoryStream mem = new MemoryStream ();
		bf.Serialize (mem, obj);
		string temp = System.Convert.ToBase64String (mem.ToArray ());
		PlayerPrefs.SetString (tag, temp);
	}

	public static object Load(string tag) {
		string temp = PlayerPrefs.GetString (tag);
		if (temp == string.Empty) {
			return null;
		}
		MemoryStream mem = new MemoryStream (System.Convert.FromBase64String(temp));
		return bf.Deserialize (mem);
	}
}
