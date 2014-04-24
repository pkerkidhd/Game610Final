using UnityEngine;
using System.Collections;

public class BoidFollowPlayer : MonoBehaviour {
	
	public Transform playerObject;
	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(transform.position, playerObject.position); 
		Debug.Log(dist);
		if( dist > 1)
		{
			//transform.LookAt(playerObject.transform);
			//transform.position();
			transform.Translate(speed * Vector3.forward*Time.deltaTime);
		}
	}
}
