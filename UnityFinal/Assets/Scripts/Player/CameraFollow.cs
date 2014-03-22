using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private Vector3 myPos;
	public Transform player;

	// Use this for initialization
	void Start () {
		myPos = new Vector3(0, 9.180595f, -2.707023f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position + myPos;
	}
}