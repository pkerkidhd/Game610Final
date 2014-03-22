using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float playerSpeed;
	private Vector3 movePoint;
	public Camera camera;

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
		}
	}

	void checkState() {
		switch(currentState) {
		case states.Idle:
			Debug.Log("Idle");
				currentState = states.Idle;
			break;
		case states.Moving:
			Debug.Log("Moving");
				currentState = states.Moving;
			break;
		}
	}

	void checkInput() {
		if (Input.GetMouseButton(1))
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
	}
}
