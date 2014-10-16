using UnityEngine;
using System.Collections;

public class Clicked : MonoBehaviour {

	public int type;

	public GameObject player;

	RingTravel travel;
	// Use this for initialization
	void Start () {
		travel = player.GetComponent<RingTravel> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		travel.Move (type);
	}
}
