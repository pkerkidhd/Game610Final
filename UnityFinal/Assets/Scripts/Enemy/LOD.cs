using UnityEngine;
using System.Collections;

public class LOD : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(transform.position, player.transform.position);
		if (dist > 15) {
			transform.GetChild(0).gameObject.SetActive(false);
			transform.GetChild(1).gameObject.SetActive(true);
		} else if (dist < 15 && dist > 10) {
			transform.GetChild(1).gameObject.SetActive(false);
			transform.GetChild(2).gameObject.SetActive(true);
		} else if (dist < 5) {
			transform.GetChild(2).gameObject.SetActive(false);
			transform.GetChild(3).gameObject.SetActive(true);
		}
//		for (int i = 0; i < transform.GetChildCount(); ++i)
//		{
//			//col.transform.GetChild(i).gameObject.SetActive(true);
//			Debug.Log(transform.GetChild(i).name + "Number: " + i);
//		}
	}
}
