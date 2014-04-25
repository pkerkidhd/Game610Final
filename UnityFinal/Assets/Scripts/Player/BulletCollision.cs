using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	public GameObject explosion;

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
			Destroy(Target.gameObject);
		}

		if (Target.gameObject.tag == "enemy") {
			Instantiate(explosion, Target.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(Target.gameObject);
		}

	}
}
