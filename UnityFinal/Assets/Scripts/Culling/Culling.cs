using UnityEngine;
using System.Collections;

public class Culling : MonoBehaviour {

	private Transform playerTransform;
	private GameObject player;
	private float targetDist;
	public float targetWithin;

	Renderer[] renderers;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("soldier");
		playerTransform = player.transform;
		renderers = GetComponentsInChildren<Renderer>();
		foreach(Renderer r in renderers) {
			r.enabled = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		targetDist = Vector3.Distance(playerTransform.position, this.transform.position);
		//Debug.Log(targetDist);
		if(targetDist < targetWithin) {
			foreach(Renderer r in renderers) {
				r.enabled = true;
			}
		} else {
			foreach(Renderer r in renderers) {
				r.enabled = false;
			}
		}
	}
}
