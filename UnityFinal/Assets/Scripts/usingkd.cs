using UnityEngine;
using System.Collections;

public class usingkd : MonoBehaviour {

	KDTree tree;
	public Vector3[] pointsArray;
	int nearest;
	public GameObject player;
	public GameObject[] enemies;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
	}
	
	// Update is called once per frame
	void Update () {
		tree = KDTree.MakeFromPoints(pointsArray);
		for (int i = 0; i < enemies.Length; i++) {
			pointsArray[i] = enemies[i].transform.position;
		}
		nearest = tree.FindNearest(player.transform.position);
	
		Debug.Log(nearest);
	}
}
