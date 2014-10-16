using UnityEngine;
using System.Collections;

public class RingTravel : MonoBehaviour {

	private Touch touch;
	private float travel;

	private class Rings {
		static Vector3 ring4 = new Vector3 (0, 0, 4.55f);
		static Vector3 ring3 = new Vector3 (0, 0, 3.83f);
		static Vector3 ring2 = new Vector3 (0, 0, 3.21f);
		static Vector3 ring1 = new Vector3 (0, 0, 2.49f);

		public Vector3 [] ringList = {ring1, ring2, ring3, ring4};
	}

	Rings rings;

	int currentRing = 3;

	// Use this for initialization
	void Start () {
		touch = new Touch ();
		rings = new Rings ();

		//move = false;
	}

	// Update is called once per frame
	void Update () {
		travel = Mathf.Lerp (transform.localPosition.z, rings.ringList[currentRing].z, 0.20f);
		Vector3 temp = new Vector3 (0, 0, travel);
		transform.localPosition = temp;
		Debug.Log (transform.localPosition);
		//transform.position = Vector3.Lerp(transform.position, rings.ringList[currentRing], 1f);
	}

	public void Move(int type) {

		Debug.Log (type);
		//Move In
		if (type == 0 && currentRing != 0) {
			currentRing -= 1;
			//move = true;
			//player.transform.position = Vector3.Lerp(player.transform.position, rings.ringList[currentRing], 1f);
		}
		//Move Out
		if (type == 1 && currentRing != 3) {
			currentRing += 1;
			//move = true;
			//player.transform.position = Vector3.Lerp(player.transform.position, rings.ringList[currentRing], 1f);
		}
//
//		Debug.Log (rings.ringList[currentRing]);
	}
}
