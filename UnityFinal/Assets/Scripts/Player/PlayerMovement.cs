using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float playerSpeed;
	private Vector3 movePoint;

	public enum states { Idle, Moving, Attacking, Dead }
	public states currentState;

	// Use this for initialization
	void Start () {
		playerSpeed = 3.0f;
		currentState = states.Idle;
	}
	
	// Update is called once per frame
	void Update () {

		checkState();
		checkInput();

		if(currentState == states.Idle) {
		
		} else if (currentState == states.Moving) {
			float moveDist = Vector3.Distance(movePoint, transform.position);
			if(moveDist > 1.0f) {
				transform.position = Vector3.MoveTowards(transform.position, movePoint, playerSpeed * Time.deltaTime);
				//Debug.Log(moveDist);
			} else if(moveDist < 1.0f){
				currentState = states.Idle;
			}
		} else if (currentState == states.Attacking) {

		}
	}

	void checkState() {
		switch(currentState) {
		case states.Idle:
			Debug.Log("Idle");
			animation.CrossFade("soldierIdle");
			currentState = states.Idle;
			break;
		case states.Moving:
			Debug.Log("Moving");
			animation.CrossFade("soldierRun");
			currentState = states.Moving;
			break;
		case states.Attacking:
			Debug.Log("Attacking");
			animation.CrossFade("soldierFiring");
			currentState = states.Attacking;
			break;
		}
	}

	void checkInput() {
		if (Input.GetMouseButton(0))
		{
			RaycastHit hit;
			Ray ray = (Camera.main.ScreenPointToRay(Input.mousePosition));
			
			if (Physics.Raycast(ray, out hit))
			{
				Debug.Log("Hit: " + hit.transform.name);
				if (hit.transform.name == "Ground")
				{
					movePoint = new Vector3(hit.point.x, 0, hit.point.z);
					transform.LookAt(movePoint);
					Debug.DrawLine(Camera.main.transform.position, hit.point);
					currentState = states.Moving;
				}
			}                   
		}
		if (Input.GetMouseButton(1)) {
			currentState = states.Attacking;
		} else if (Input.GetMouseButtonUp(1)) {
			currentState = states.Idle;
		}
	}
}
