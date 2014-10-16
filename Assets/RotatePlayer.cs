using UnityEngine;
using System.Collections;

public class RotatePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, Input.acceleration.x * 5, 0);
	}
}
