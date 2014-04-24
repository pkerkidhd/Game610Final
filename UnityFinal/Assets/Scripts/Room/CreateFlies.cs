using UnityEngine;
using System.Collections;

public class CreateFlies : MonoBehaviour {

	private GameObject flies;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log("YES!");
		if (col.gameObject.name == "SoldierPlayer") {
				//col.transform.GetChild(3).gameObject.SetActive(true);
			col.transform.GetChild(6).gameObject.SetActive(true);
			Debug.Log("DONE!");
//			for (int i = 0; i < col.transform.GetChildCount(); ++i)
//			{
//				col.transform.GetChild(i).gameObject.SetActive(true);
//				Debug.Log(col.transform.GetChild(i) + "Number: " + i);
//			}
		}
	}
}
