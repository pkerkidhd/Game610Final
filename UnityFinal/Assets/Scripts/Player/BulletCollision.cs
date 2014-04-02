using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(this.gameObject, 5);
	}

	void OnCollisionEnter (Collision Target) {
		if (Target.gameObject.tag == "Wall") {
			Destroy(this.gameObject);
		}
	}
}
