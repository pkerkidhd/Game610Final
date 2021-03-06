﻿using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

	public Rigidbody projectile;
	public float speed = 10.0f;
	float lastFireTime;
	float shootDelay = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(1)) {
			if(Time.time > (lastFireTime + shootDelay)) {
				Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
				lastFireTime = Time.time;
			}
		}
	}
}
